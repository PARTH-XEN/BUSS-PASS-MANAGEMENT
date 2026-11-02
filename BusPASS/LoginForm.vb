Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class LoginForm

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Default focus to username or password
        txtUsername.Focus()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPassword.CheckedChanged
        ' Toggle password masking
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Simple validation
        If String.IsNullOrEmpty(username) Then
            MessageBox.Show("Please enter Admin Username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter Admin Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        Try
            ' Query admin credentials from database
            Dim sql As String = "SELECT AdminId, Username, FullName FROM dbo.AdminLogin WHERE Username = @Username AND Password = @Password"
            Dim p(1) As SqlParameter
            p(0) = New SqlParameter("@Username", username)
            p(1) = New SqlParameter("@Password", password)

            Dim dt As DataTable = DBConnection.ExecuteQuery(sql, p)

            If dt.Rows.Count > 0 Then
                ' Successful login
                DBConnection.LoggedInAdminId = Convert.ToInt32(dt.Rows(0)("AdminId"))
                DBConnection.LoggedInAdminUsername = dt.Rows(0)("Username").ToString()
                DBConnection.LoggedInAdminFullName = dt.Rows(0)("FullName").ToString()

                MessageBox.Show("Welcome, " & DBConnection.LoggedInAdminFullName & "!" & vbCrLf & "Login Successful.", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Open Main Dashboard
                Me.Hide()
                Dim dashboard As New MainDashboardForm()
                dashboard.Show()
            Else
                MessageBox.Show("Invalid Username or Password!" & vbCrLf & vbCrLf & "Default credentials:" & vbCrLf & "Username: admin" & vbCrLf & "Password: admin123", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Clear()
                txtPassword.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message & vbCrLf & vbCrLf & "Please make sure SQL Server Express is running and BusPassDB.mdf is accessible.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the system?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnTestDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim msg As String = ""
        If DBConnection.TestConnection(msg) Then
            MessageBox.Show(msg & vbCrLf & vbCrLf & "Connection String: " & DBConnection.GetConnectionString(), "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(msg, "Database Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
        End If
    End Sub

End Class
