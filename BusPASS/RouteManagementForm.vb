Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class RouteManagementForm

    Private _selectedRouteId As Integer = 0

    Private Sub RouteManagementForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearInputs()
        LoadRoutes()
    End Sub

    Public Sub LoadRoutes()
        Try
            Dim sql As String = "SELECT RouteId, RouteNumber AS [Route No], RouteName AS [Route Name], " & _
                                "SourceStop AS [Source Stop], DestinationStop AS [Destination Stop], " & _
                                "MonthlyFare AS [Monthly Fare (Rs)], Status " & _
                                "FROM dbo.Routes WHERE 1=1 "

            Dim pList As New List(Of SqlParameter)()
            Dim keyword As String = txtSearch.Text.Trim()
            If Not String.IsNullOrEmpty(keyword) Then
                sql &= "AND (RouteNumber LIKE @kw OR RouteName LIKE @kw OR SourceStop LIKE @kw OR DestinationStop LIKE @kw) "
                pList.Add(New SqlParameter("@kw", "%" & keyword & "%"))
            End If

            sql &= "ORDER BY RouteId ASC"

            Dim dt As DataTable = DBConnection.ExecuteQuery(sql, pList.ToArray())
            dgvRoutes.DataSource = dt

            If dgvRoutes.Columns.Contains("RouteId") Then
                dgvRoutes.Columns("RouteId").Visible = False
            End If

            HighlightGridRows()

        Catch ex As Exception
            MessageBox.Show("Error loading routes: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HighlightGridRows()
        For Each row As DataGridViewRow In dgvRoutes.Rows
            If row.Cells("Status").Value IsNot Nothing Then
                Dim st As String = row.Cells("Status").Value.ToString()
                If st = "Active" Then
                    row.DefaultCellStyle.ForeColor = Drawing.Color.DarkGreen
                Else
                    row.DefaultCellStyle.ForeColor = Drawing.Color.Firebrick
                End If
            End If
        Next
    End Sub

    Private Sub ClearInputs()
        _selectedRouteId = 0
        txtRouteNumber.Clear()
        txtRouteName.Clear()
        txtSource.Clear()
        txtDestination.Clear()
        txtMonthlyFare.Text = "500.00"
        cmbStatus.SelectedIndex = 0

        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtRouteNumber.ReadOnly = False
        txtRouteNumber.Focus()
    End Sub

    Private Sub dgvRoutes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvRoutes.SelectionChanged
        If dgvRoutes.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvRoutes.SelectedRows(0)
            _selectedRouteId = Convert.ToInt32(row.Cells("RouteId").Value)
            txtRouteNumber.Text = row.Cells("Route No").Value.ToString()
            txtRouteName.Text = row.Cells("Route Name").Value.ToString()
            txtSource.Text = row.Cells("Source Stop").Value.ToString()
            txtDestination.Text = row.Cells("Destination Stop").Value.ToString()
            txtMonthlyFare.Text = Convert.ToDecimal(row.Cells("Monthly Fare (Rs)").Value).ToString("F2")

            Dim st As String = row.Cells("Status").Value.ToString()
            If st = "Active" Then
                cmbStatus.SelectedIndex = 0
            Else
                cmbStatus.SelectedIndex = 1
            End If

            btnAdd.Enabled = False
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim rNum As String = txtRouteNumber.Text.Trim()
        Dim rName As String = txtRouteName.Text.Trim()
        Dim rSource As String = txtSource.Text.Trim()
        Dim rDest As String = txtDestination.Text.Trim()
        Dim fareVal As Decimal = 0.0D

        If String.IsNullOrEmpty(rNum) Then
            MessageBox.Show("Please enter the Route Number (e.g. R-106).", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRouteNumber.Focus()
            Return
        End If

        If String.IsNullOrEmpty(rName) Then
            MessageBox.Show("Please enter the Route Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRouteName.Focus()
            Return
        End If

        If String.IsNullOrEmpty(rSource) OrElse String.IsNullOrEmpty(rDest) Then
            MessageBox.Show("Please enter both Source and Destination stops.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not Decimal.TryParse(txtMonthlyFare.Text.Trim(), fareVal) OrElse fareVal <= 0 Then
            MessageBox.Show("Please enter a valid monthly fare greater than 0.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMonthlyFare.Focus()
            Return
        End If

        Try
            ' Check duplicate route number
            Dim existsObj As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM dbo.Routes WHERE RouteNumber = '" & rNum.Replace("'", "''") & "'")
            If Convert.ToInt32(existsObj) > 0 Then
                MessageBox.Show("Route Number [" & rNum & "] already exists! Please use a unique route number.", "Duplicate Route", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim sql As String = "INSERT INTO dbo.Routes (RouteNumber, RouteName, SourceStop, DestinationStop, MonthlyFare, Status) " & _
                                "VALUES (@RouteNumber, @RouteName, @SourceStop, @DestinationStop, @MonthlyFare, @Status)"
            Dim p(5) As SqlParameter
            p(0) = New SqlParameter("@RouteNumber", rNum)
            p(1) = New SqlParameter("@RouteName", rName)
            p(2) = New SqlParameter("@SourceStop", rSource)
            p(3) = New SqlParameter("@DestinationStop", rDest)
            p(4) = New SqlParameter("@MonthlyFare", fareVal)
            p(5) = New SqlParameter("@Status", cmbStatus.SelectedItem.ToString())

            DBConnection.ExecuteNonQuery(sql, p)

            MessageBox.Show("New route [" & rNum & "] added successfully!", "Route Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearInputs()
            LoadRoutes()

        Catch ex As Exception
            MessageBox.Show("Error adding route: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If _selectedRouteId = 0 Then
            MessageBox.Show("Please select a route to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim fareVal As Decimal = 0.0D
        If Not Decimal.TryParse(txtMonthlyFare.Text.Trim(), fareVal) OrElse fareVal <= 0 Then
            MessageBox.Show("Please enter a valid monthly fare.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim sql As String = "UPDATE dbo.Routes SET RouteName = @RouteName, SourceStop = @SourceStop, " & _
                                "DestinationStop = @DestinationStop, MonthlyFare = @MonthlyFare, Status = @Status " & _
                                "WHERE RouteId = @RouteId"
            Dim p(5) As SqlParameter
            p(0) = New SqlParameter("@RouteName", txtRouteName.Text.Trim())
            p(1) = New SqlParameter("@SourceStop", txtSource.Text.Trim())
            p(2) = New SqlParameter("@DestinationStop", txtDestination.Text.Trim())
            p(3) = New SqlParameter("@MonthlyFare", fareVal)
            p(4) = New SqlParameter("@Status", cmbStatus.SelectedItem.ToString())
            p(5) = New SqlParameter("@RouteId", _selectedRouteId)

            DBConnection.ExecuteNonQuery(sql, p)

            MessageBox.Show("Route updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearInputs()
            LoadRoutes()

        Catch ex As Exception
            MessageBox.Show("Error updating route: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If _selectedRouteId = 0 Then
            MessageBox.Show("Please select a route to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if route is being used by any existing pass
        Dim passCountObj As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM dbo.Passes WHERE RouteId = " & _selectedRouteId)
        If Convert.ToInt32(passCountObj) > 0 Then
            MessageBox.Show("This route cannot be deleted because it is linked to existing issued passes." & vbCrLf & "You can set its Status to 'Inactive' instead.", "Route In Use", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim res As DialogResult = MessageBox.Show("Are you sure you want to delete route [" & txtRouteNumber.Text & "]?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = DialogResult.Yes Then
            Try
                DBConnection.ExecuteNonQuery("DELETE FROM dbo.Routes WHERE RouteId = " & _selectedRouteId)
                MessageBox.Show("Route deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearInputs()
                LoadRoutes()
            Catch ex As Exception
                MessageBox.Show("Error deleting route: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        LoadRoutes()
    End Sub

End Class
