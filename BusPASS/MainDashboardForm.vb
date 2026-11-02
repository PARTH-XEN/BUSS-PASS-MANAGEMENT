Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class MainDashboardForm

    Private Sub MainDashboardForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & DBConnection.LoggedInAdminFullName & " (Admin Portal)"
        lblCurrentDate.Text = "Today: " & DateTime.Now.ToString("dd-MMM-yyyy dddd")
        RefreshDashboard()
    End Sub

    Public Sub RefreshDashboard()
        Try
            ' 1. Check and automatically update pass status for expired ones
            Dim updateExpiredSql As String = "UPDATE dbo.Passes SET Status = 'Expired' WHERE ExpiryDate < CAST(GETDATE() AS DATE) AND Status = 'Active'"
            DBConnection.ExecuteNonQuery(updateExpiredSql)

            ' 2. Load Summary Counters
            Dim totalPassesObj As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM dbo.Passes")
            Dim activePassesObj As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM dbo.Passes WHERE Status = 'Active'")
            Dim expiredPassesObj As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM dbo.Passes WHERE Status = 'Expired'")
            Dim totalRoutesObj As Object = DBConnection.ExecuteScalar("SELECT COUNT(*) FROM dbo.Routes WHERE Status = 'Active'")

            lblCountTotal.Text = If(totalPassesObj IsNot Nothing, totalPassesObj.ToString(), "0")
            lblCountActive.Text = If(activePassesObj IsNot Nothing, activePassesObj.ToString(), "0")
            lblCountExpired.Text = If(expiredPassesObj IsNot Nothing, expiredPassesObj.ToString(), "0")
            lblCountRoutes.Text = If(totalRoutesObj IsNot Nothing, totalRoutesObj.ToString(), "0")

            ' 3. Load Recent Passes into DataGridView
            Dim sql As String = "SELECT TOP 15 PassNumber AS [Pass No], FullName AS [Passenger Name], PassCategory AS [Category], " & _
                                "SourceStop + ' -> ' + DestinationStop AS [Route Stops], " & _
                                "CONVERT(VARCHAR(10), StartDate, 105) AS [Valid From], " & _
                                "CONVERT(VARCHAR(10), ExpiryDate, 105) AS [Valid To], " & _
                                "'Rs. ' + CAST(TotalAmount AS VARCHAR) AS [Total Paid], Status " & _
                                "FROM dbo.Passes ORDER BY PassId DESC"

            Dim dt As DataTable = DBConnection.ExecuteQuery(sql)
            dgvRecentPasses.DataSource = dt

            ' Format status column visual highlighting
            HighlightGridRows()

        Catch ex As Exception
            MessageBox.Show("Error refreshing dashboard data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HighlightGridRows()
        For Each row As DataGridViewRow In dgvRecentPasses.Rows
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

    Private Sub btnRefreshDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshDashboard.Click
        RefreshDashboard()
    End Sub

    Private Sub btnNewPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewPass.Click
        Dim f As New NewPassForm()
        f.ShowDialog()
        RefreshDashboard()
    End Sub

    Private Sub btnManagePasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManagePasses.Click
        Dim f As New ManagePassesForm()
        f.ShowDialog()
        RefreshDashboard()
    End Sub

    Private Sub btnManageRoutes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageRoutes.Click
        Dim f As New RouteManagementForm()
        f.ShowDialog()
        RefreshDashboard()
    End Sub

    Private Sub btnPrintPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPass.Click
        ' Check if row selected in recent passes
        Dim selectedPassNo As String = ""
        If dgvRecentPasses.SelectedRows.Count > 0 Then
            selectedPassNo = dgvRecentPasses.SelectedRows(0).Cells("Pass No").Value.ToString()
        End If

        Dim f As New PrintPassForm(selectedPassNo)
        f.ShowDialog()
    End Sub

    Private Sub btnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePassword.Click
        Dim f As New ChangePasswordForm()
        f.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out from the Admin Panel?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            ' Show login form
            Dim login As New LoginForm()
            login.Show()
        End If
    End Sub

    Private Sub MainDashboardForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ' If closed directly via X button, ensure application exits cleanly
        If Application.OpenForms("LoginForm") IsNot Nothing AndAlso Not Application.OpenForms("LoginForm").Visible Then
            Application.Exit()
        End If
    End Sub

End Class
