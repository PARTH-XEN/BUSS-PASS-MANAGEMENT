Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ManagePassesForm

    Private _selectedPassId As Integer = 0
    Private _selectedPassNumber As String = ""
    Private _selectedPassengerName As String = ""
    Private _selectedCurrentExpiry As DateTime = DateTime.Today
    Private _selectedPassStatus As String = ""
    Private _selectedMonthlyFare As Decimal = 0.0D

    Private Sub ManagePassesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbSearchBy.SelectedIndex = 0
        cmbStatusFilter.SelectedIndex = 0
        cmbRenewMonths.SelectedIndex = 0
        LoadPasses()
    End Sub

    Public Sub LoadPasses()
        Try
            ' Update any newly expired passes
            DBConnection.ExecuteNonQuery("UPDATE dbo.Passes SET Status = 'Expired' WHERE ExpiryDate < CAST(GETDATE() AS DATE) AND Status = 'Active'")

            Dim sql As String = "SELECT P.PassId, P.PassNumber AS [Pass No], P.FullName AS [Passenger Name], " & _
                                "P.Gender, P.Age, P.ContactNumber AS [Mobile No], P.PassCategory AS [Category], " & _
                                "P.SourceStop + ' <-> ' + P.DestinationStop AS [Route Stops], " & _
                                "CONVERT(VARCHAR(10), P.StartDate, 105) AS [Valid From], " & _
                                "CONVERT(VARCHAR(10), P.ExpiryDate, 105) AS [Valid To], " & _
                                "'Rs. ' + CAST(P.TotalAmount AS VARCHAR) AS [Amount Paid], " & _
                                "P.Status, P.ExpiryDate, R.MonthlyFare " & _
                                "FROM dbo.Passes P " & _
                                "LEFT JOIN dbo.Routes R ON P.RouteId = R.RouteId " & _
                                "WHERE 1=1 "

            Dim pList As New List(Of SqlParameter)()
            Dim keyword As String = txtSearchKeyword.Text.Trim()

            ' Filter by keyword
            If Not String.IsNullOrEmpty(keyword) Then
                Select Case cmbSearchBy.SelectedIndex
                    Case 1 ' Pass Number
                        sql &= "AND P.PassNumber LIKE @Keyword "
                    Case 2 ' Name
                        sql &= "AND P.FullName LIKE @Keyword "
                    Case 3 ' Contact
                        sql &= "AND P.ContactNumber LIKE @Keyword "
                    Case 4 ' Category
                        sql &= "AND P.PassCategory LIKE @Keyword "
                    Case 5 ' Route Stops
                        sql &= "AND (P.SourceStop LIKE @Keyword OR P.DestinationStop LIKE @Keyword) "
                    Case Else ' All fields
                        sql &= "AND (P.PassNumber LIKE @Keyword OR P.FullName LIKE @Keyword OR P.ContactNumber LIKE @Keyword OR P.PassCategory LIKE @Keyword OR P.SourceStop LIKE @Keyword OR P.DestinationStop LIKE @Keyword) "
                End Select
                pList.Add(New SqlParameter("@Keyword", "%" & keyword & "%"))
            End If

            ' Filter by Status
            If cmbStatusFilter.SelectedIndex > 0 Then
                Dim selectedStatus As String = cmbStatusFilter.SelectedItem.ToString()
                sql &= "AND P.Status = @Status "
                pList.Add(New SqlParameter("@Status", selectedStatus))
            End If

            sql &= "ORDER BY P.PassId DESC"

            Dim dt As DataTable = DBConnection.ExecuteQuery(sql, pList.ToArray())
            dgvPasses.DataSource = dt

            ' Hide technical helper columns
            If dgvPasses.Columns.Contains("PassId") Then dgvPasses.Columns("PassId").Visible = False
            If dgvPasses.Columns.Contains("ExpiryDate") Then dgvPasses.Columns("ExpiryDate").Visible = False
            If dgvPasses.Columns.Contains("MonthlyFare") Then dgvPasses.Columns("MonthlyFare").Visible = False

            HighlightGridRows()

            ' Select first row if available
            If dgvPasses.Rows.Count > 0 Then
                dgvPasses.Rows(0).Selected = True
                UpdateSelectionDetails()
            Else
                ClearSelectionDetails()
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading passes: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HighlightGridRows()
        For Each row As DataGridViewRow In dgvPasses.Rows
            If row.Cells("Status").Value IsNot Nothing Then
                Dim st As String = row.Cells("Status").Value.ToString()
                If st = "Active" Then
                    row.DefaultCellStyle.ForeColor = Drawing.Color.DarkGreen
                ElseIf st = "Expired" Then
                    row.DefaultCellStyle.ForeColor = Drawing.Color.Firebrick
                ElseIf st = "Cancelled" Then
                    row.DefaultCellStyle.ForeColor = Drawing.Color.Gray
                End If
            End If
        Next
    End Sub

    Private Sub UpdateSelectionDetails()
        If dgvPasses.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvPasses.SelectedRows(0)
            _selectedPassId = Convert.ToInt32(row.Cells("PassId").Value)
            _selectedPassNumber = row.Cells("Pass No").Value.ToString()
            _selectedPassengerName = row.Cells("Passenger Name").Value.ToString()
            _selectedPassStatus = row.Cells("Status").Value.ToString()

            If row.Cells("ExpiryDate").Value IsNot DBNull.Value Then
                _selectedCurrentExpiry = Convert.ToDateTime(row.Cells("ExpiryDate").Value)
            Else
                _selectedCurrentExpiry = DateTime.Today
            End If

            If row.Cells("MonthlyFare").Value IsNot DBNull.Value Then
                _selectedMonthlyFare = Convert.ToDecimal(row.Cells("MonthlyFare").Value)
            Else
                _selectedMonthlyFare = 500.0D
            End If

            lblSelectedPassInfo.Text = "Selected: [" & _selectedPassNumber & "] " & _selectedPassengerName & _
                                      " | Expiry: " & _selectedCurrentExpiry.ToString("dd-MMM-yyyy") & _
                                      " | Status: " & _selectedPassStatus
        Else
            ClearSelectionDetails()
        End If
    End Sub

    Private Sub ClearSelectionDetails()
        _selectedPassId = 0
        _selectedPassNumber = ""
        _selectedPassengerName = ""
        lblSelectedPassInfo.Text = "No pass selected. Click on a row above to select."
    End Sub

    Private Sub dgvPasses_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPasses.SelectionChanged
        UpdateSelectionDetails()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadPasses()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        txtSearchKeyword.Clear()
        cmbSearchBy.SelectedIndex = 0
        cmbStatusFilter.SelectedIndex = 0
        LoadPasses()
    End Sub

    Private Sub btnRenew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRenew.Click
        If _selectedPassId = 0 Then
            MessageBox.Show("Please select a pass from the list to renew.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim months As Integer = 1
        Select Case cmbRenewMonths.SelectedIndex
            Case 0 : months = 1
            Case 1 : months = 3
            Case 2 : months = 6
            Case 3 : months = 12
        End Select

        ' Calculate new expiry date: extend from current expiry if not already expired, or from today
        Dim baseDate As DateTime = _selectedCurrentExpiry
        If baseDate < DateTime.Today Then
            baseDate = DateTime.Today
        End If
        Dim newExpiry As DateTime = baseDate.AddMonths(months)
        Dim renewalAmount As Decimal = _selectedMonthlyFare * months

        Dim confirmMsg As String = "Confirm Renewal for Pass [" & _selectedPassNumber & "]?" & vbCrLf & vbCrLf & _
                                   "Passenger: " & _selectedPassengerName & vbCrLf & _
                                   "Previous Expiry: " & _selectedCurrentExpiry.ToString("dd-MM-yyyy") & vbCrLf & _
                                   "New Expiry: " & newExpiry.ToString("dd-MM-yyyy") & vbCrLf & _
                                   "Renewal Period: " & months.ToString() & " Month(s)" & vbCrLf & _
                                   "Renewal Fee: Rs. " & renewalAmount.ToString("F2")

        Dim result As DialogResult = MessageBox.Show(confirmMsg, "Confirm Pass Renewal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                ' 1. Update pass record
                Dim updateSql As String = "UPDATE dbo.Passes SET ExpiryDate = @NewExpiry, Status = 'Active' WHERE PassId = @PassId"
                Dim pUpdate(1) As SqlParameter
                pUpdate(0) = New SqlParameter("@NewExpiry", newExpiry.Date)
                pUpdate(1) = New SqlParameter("@PassId", _selectedPassId)
                DBConnection.ExecuteNonQuery(updateSql, pUpdate)

                ' 2. Insert renewal log
                Dim logSql As String = "INSERT INTO dbo.PassRenewals (PassId, PassNumber, PreviousExpiryDate, NewExpiryDate, MonthsExtended, RenewalAmount) " & _
                                       "VALUES (@PassId, @PassNumber, @PrevExpiry, @NewExpiry, @Months, @Amount)"
                Dim pLog(5) As SqlParameter
                pLog(0) = New SqlParameter("@PassId", _selectedPassId)
                pLog(1) = New SqlParameter("@PassNumber", _selectedPassNumber)
                pLog(2) = New SqlParameter("@PrevExpiry", _selectedCurrentExpiry.Date)
                pLog(3) = New SqlParameter("@NewExpiry", newExpiry.Date)
                pLog(4) = New SqlParameter("@Months", months)
                pLog(5) = New SqlParameter("@Amount", renewalAmount)
                DBConnection.ExecuteNonQuery(logSql, pLog)

                MessageBox.Show("Pass [" & _selectedPassNumber & "] renewed successfully until " & newExpiry.ToString("dd-MMM-yyyy") & "!", "Renewal Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPasses()

            Catch ex As Exception
                MessageBox.Show("Error renewing pass: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnPrintPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPass.Click
        If _selectedPassId = 0 Then
            MessageBox.Show("Please select a pass to print.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim printForm As New PrintPassForm(_selectedPassNumber)
        printForm.ShowDialog()
    End Sub

    Private Sub btnCancelPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelPass.Click
        If _selectedPassId = 0 Then
            MessageBox.Show("Please select a pass to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim res As DialogResult = MessageBox.Show("Are you sure you want to cancel pass [" & _selectedPassNumber & "] for " & _selectedPassengerName & "?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If res = DialogResult.Yes Then
            Try
                Dim sql As String = "UPDATE dbo.Passes SET Status = 'Cancelled' WHERE PassId = @PassId"
                Dim p(0) As SqlParameter
                p(0) = New SqlParameter("@PassId", _selectedPassId)
                DBConnection.ExecuteNonQuery(sql, p)

                MessageBox.Show("Pass [" & _selectedPassNumber & "] has been marked as Cancelled.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPasses()
            Catch ex As Exception
                MessageBox.Show("Error cancelling pass: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If _selectedPassId = 0 Then
            MessageBox.Show("Please select a pass to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim res As DialogResult = MessageBox.Show("WARNING: Are you sure you want to permanently delete pass [" & _selectedPassNumber & "]?" & vbCrLf & "This action cannot be undone.", "Confirm Permanent Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
        If res = DialogResult.Yes Then
            Try
                ' Delete renewal history first
                DBConnection.ExecuteNonQuery("DELETE FROM dbo.PassRenewals WHERE PassId = " & _selectedPassId)
                ' Delete pass
                DBConnection.ExecuteNonQuery("DELETE FROM dbo.Passes WHERE PassId = " & _selectedPassId)

                MessageBox.Show("Pass record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPasses()
            Catch ex As Exception
                MessageBox.Show("Error deleting pass: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearchKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadPasses()
        End If
    End Sub

End Class
