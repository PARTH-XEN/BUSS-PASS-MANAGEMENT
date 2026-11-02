Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class NewPassForm

    Private _routesTable As DataTable
    Private _currentMonthlyFare As Decimal = 0.0D
    Private _calculatedTotalFare As Decimal = 0.0D
    Private _calculatedDiscount As Decimal = 0.0D
    Private _lastSavedPassNumber As String = ""

    Private Sub NewPassForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub

    Private Sub ResetForm()
        ' Generate next Pass Number
        GenerateNextPassNumber()

        ' Clear inputs
        txtFullName.Clear()
        cmbGender.SelectedIndex = 0
        txtAge.Text = "20"
        txtContact.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        cmbIdProofType.SelectedIndex = 0
        txtIdProofNumber.Clear()

        ' Reset combo defaults
        cmbCategory.SelectedIndex = 0  ' Student
        cmbValidity.SelectedIndex = 0  ' 1 Month

        dtpStartDate.Value = DateTime.Today
        dtpExpiryDate.Value = DateTime.Today.AddMonths(1)

        ' Load bus routes from DB
        LoadRoutes()

        btnPrint.Enabled = False
        _lastSavedPassNumber = ""

        CalculateFare()
        txtFullName.Focus()
    End Sub

    Private Sub GenerateNextPassNumber()
        Try
            Dim maxIdObj As Object = DBConnection.ExecuteScalar("SELECT ISNULL(MAX(PassId), 1000) FROM dbo.Passes")
            Dim nextId As Integer = Convert.ToInt32(maxIdObj) + 1
            txtPassNumber.Text = "BP-" & nextId.ToString()
        Catch ex As Exception
            txtPassNumber.Text = "BP-" & DateTime.Now.ToString("yyyyMMddHHmm")
        End Try
    End Sub

    Private Sub LoadRoutes()
        Try
            Dim sql As String = "SELECT RouteId, RouteNumber + ' : ' + RouteName AS DisplayText, RouteNumber, RouteName, SourceStop, DestinationStop, MonthlyFare FROM dbo.Routes WHERE Status = 'Active'"
            _routesTable = DBConnection.ExecuteQuery(sql)

            cmbRoute.DisplayMember = "DisplayText"
            cmbRoute.ValueMember = "RouteId"
            cmbRoute.DataSource = _routesTable

            If _routesTable.Rows.Count > 0 Then
                cmbRoute.SelectedIndex = 0
                UpdateRouteDetails()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading routes: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateRouteDetails()
        If cmbRoute.SelectedIndex >= 0 AndAlso _routesTable IsNot Nothing AndAlso cmbRoute.SelectedIndex < _routesTable.Rows.Count Then
            Dim row As DataRow = _routesTable.Rows(cmbRoute.SelectedIndex)
            txtSource.Text = row("SourceStop").ToString()
            txtDestination.Text = row("DestinationStop").ToString()
            _currentMonthlyFare = Convert.ToDecimal(row("MonthlyFare"))
            CalculateFare()
        End If
    End Sub

    Private Sub cmbRoute_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRoute.SelectedIndexChanged
        UpdateRouteDetails()
    End Sub

    Private Sub cmbValidity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbValidity.SelectedIndexChanged
        Dim months As Integer = GetValidityMonths()
        dtpExpiryDate.Value = dtpStartDate.Value.AddMonths(months)
        CalculateFare()
    End Sub

    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        Dim months As Integer = GetValidityMonths()
        dtpExpiryDate.Value = dtpStartDate.Value.AddMonths(months)
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        CalculateFare()
    End Sub

    Private Function GetValidityMonths() As Integer
        Select Case cmbValidity.SelectedIndex
            Case 0 : Return 1
            Case 1 : Return 3
            Case 2 : Return 6
            Case 3 : Return 12
            Case Else : Return 1
        End Select
    End Function

    Private Sub CalculateFare()
        Dim months As Integer = GetValidityMonths()
        Dim baseFare As Decimal = _currentMonthlyFare * months
        Dim discountPercent As Decimal = 0.0D

        Select Case cmbCategory.SelectedIndex
            Case 0 : discountPercent = 0.3D  ' Student (30%)
            Case 1 : discountPercent = 0.5D  ' Senior Citizen (50%)
            Case 2 : discountPercent = 0.0D  ' General Public (0%)
            Case 3 : discountPercent = 0.2D  ' Employee (20%)
        End Select

        _calculatedDiscount = baseFare * discountPercent
        _calculatedTotalFare = baseFare - _calculatedDiscount

        txtBaseFare.Text = baseFare.ToString("F2")
        txtDiscount.Text = _calculatedDiscount.ToString("F2")
        lblTotalAmountDisplay.Text = "Rs. " & _calculatedTotalFare.ToString("F2")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Validations
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Please enter the passenger's Full Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Return
        End If

        Dim ageVal As Integer = 0
        If Not Integer.TryParse(txtAge.Text.Trim(), ageVal) OrElse ageVal < 1 OrElse ageVal > 120 Then
            MessageBox.Show("Please enter a valid age between 1 and 120.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAge.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtContact.Text) Then
            MessageBox.Show("Please enter the passenger's Contact / Mobile Number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContact.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtIdProofNumber.Text) Then
            MessageBox.Show("Please enter the ID Proof Number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdProofNumber.Focus()
            Return
        End If

        If cmbRoute.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a valid bus route.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Clean category name
        Dim catName As String = "General"
        Select Case cmbCategory.SelectedIndex
            Case 0 : catName = "Student"
            Case 1 : catName = "Senior Citizen"
            Case 2 : catName = "General"
            Case 3 : catName = "Employee"
        End Select

        Try
            Dim sql As String = "INSERT INTO dbo.Passes (PassNumber, FullName, Gender, Age, ContactNumber, Email, Address, " & _
                                "PassCategory, IdProofType, IdProofNumber, RouteId, SourceStop, DestinationStop, " & _
                                "ValidityPeriod, StartDate, ExpiryDate, FareAmount, Discount, TotalAmount, Status) " & _
                                "VALUES (@PassNumber, @FullName, @Gender, @Age, @ContactNumber, @Email, @Address, " & _
                                "@PassCategory, @IdProofType, @IdProofNumber, @RouteId, @SourceStop, @DestinationStop, " & _
                                "@ValidityPeriod, @StartDate, @ExpiryDate, @FareAmount, @Discount, @TotalAmount, 'Active')"

            Dim p(18) As SqlParameter
            p(0) = New SqlParameter("@PassNumber", txtPassNumber.Text.Trim())
            p(1) = New SqlParameter("@FullName", txtFullName.Text.Trim())
            p(2) = New SqlParameter("@Gender", cmbGender.SelectedItem.ToString())
            p(3) = New SqlParameter("@Age", ageVal)
            p(4) = New SqlParameter("@ContactNumber", txtContact.Text.Trim())
            p(5) = New SqlParameter("@Email", txtEmail.Text.Trim())
            p(6) = New SqlParameter("@Address", txtAddress.Text.Trim())
            p(7) = New SqlParameter("@PassCategory", catName)
            p(8) = New SqlParameter("@IdProofType", cmbIdProofType.SelectedItem.ToString())
            p(9) = New SqlParameter("@IdProofNumber", txtIdProofNumber.Text.Trim())
            p(10) = New SqlParameter("@RouteId", Convert.ToInt32(cmbRoute.SelectedValue))
            p(11) = New SqlParameter("@SourceStop", txtSource.Text.Trim())
            p(12) = New SqlParameter("@DestinationStop", txtDestination.Text.Trim())
            p(13) = New SqlParameter("@ValidityPeriod", cmbValidity.SelectedItem.ToString())
            p(14) = New SqlParameter("@StartDate", dtpStartDate.Value.Date)
            p(15) = New SqlParameter("@ExpiryDate", dtpExpiryDate.Value.Date)
            p(16) = New SqlParameter("@FareAmount", Convert.ToDecimal(txtBaseFare.Text))
            p(17) = New SqlParameter("@Discount", _calculatedDiscount)
            p(18) = New SqlParameter("@TotalAmount", _calculatedTotalFare)

            Dim rows As Integer = DBConnection.ExecuteNonQuery(sql, p)

            If rows > 0 Then
                _lastSavedPassNumber = txtPassNumber.Text.Trim()
                btnPrint.Enabled = True

                Dim res As DialogResult = MessageBox.Show("Bus Pass [" & _lastSavedPassNumber & "] issued successfully!" & vbCrLf & vbCrLf & _
                                                          "Passenger: " & txtFullName.Text.Trim() & vbCrLf & _
                                                          "Total Amount Paid: Rs. " & _calculatedTotalFare.ToString("F2") & vbCrLf & vbCrLf & _
                                                          "Do you want to view and print the Pass Card now?", "Pass Issued", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If res = DialogResult.Yes Then
                    Dim printForm As New PrintPassForm(_lastSavedPassNumber)
                    printForm.ShowDialog()
                End If

                ' Generate next pass number for further entries
                GenerateNextPassNumber()
            Else
                MessageBox.Show("Failed to save bus pass. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error saving bus pass: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Not String.IsNullOrEmpty(_lastSavedPassNumber) Then
            Dim printForm As New PrintPassForm(_lastSavedPassNumber)
            printForm.ShowDialog()
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
