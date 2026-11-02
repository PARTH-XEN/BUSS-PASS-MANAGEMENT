Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ChangePasswordForm

    Private Sub chkShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShow.CheckedChanged
        txtOldPass.UseSystemPasswordChar = Not chkShow.Checked
        txtNewPass.UseSystemPasswordChar = Not chkShow.Checked
        txtConfirmPass.UseSystemPasswordChar = Not chkShow.Checked
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim oldPass As String = txtOldPass.Text.Trim()
        Dim newPass As String = txtNewPass.Text.Trim()
        Dim confirmPass As String = txtConfirmPass.Text.Trim()

        If String.IsNullOrEmpty(oldPass) Then
            MessageBox.Show("Please enter your current password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtOldPass.Focus()
            Return
        End If

        If String.IsNullOrEmpty(newPass) Then
            MessageBox.Show("Please enter a new password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNewPass.Focus()
            Return
        End If

        If newPass <> confirmPass Then
            MessageBox.Show("The new passwords do not match. Please re-enter.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtConfirmPass.Focus()
            Return
        End If

        Try
            ' Verify old password
            Dim verifySql As String = "SELECT COUNT(*) FROM dbo.AdminLogin WHERE Username = @Username AND Password = @OldPassword"
            Dim pVerify(1) As SqlParameter
            pVerify(0) = New SqlParameter("@Username", DBConnection.LoggedInAdminUsername)
            pVerify(1) = New SqlParameter("@OldPassword", oldPass)

            Dim countObj As Object = DBConnection.ExecuteScalar(verifySql, pVerify)

            If Convert.ToInt32(countObj) = 0 Then
                MessageBox.Show("Current password is incorrect!", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtOldPass.Clear()
                txtOldPass.Focus()
                Return
            End If

            ' Update password
            Dim updateSql As String = "UPDATE dbo.AdminLogin SET Password = @NewPassword WHERE Username = @Username"
            Dim pUpdate(1) As SqlParameter
            pUpdate(0) = New SqlParameter("@NewPassword", newPass)
            pUpdate(1) = New SqlParameter("@Username", DBConnection.LoggedInAdminUsername)

            DBConnection.ExecuteNonQuery(updateSql, pUpdate)

            MessageBox.Show("Admin password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
