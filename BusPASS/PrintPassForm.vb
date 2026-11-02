Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class PrintPassForm

    Private _initialPassNumber As String = ""
    Private _printDoc As PrintDocument
    Private _cardBitmap As Bitmap

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal passNo As String)
        InitializeComponent()
        _initialPassNumber = passNo
    End Sub

    Private Sub PrintPassForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _printDoc = New PrintDocument()
        AddHandler _printDoc.PrintPage, AddressOf PrintDocument_PrintPage

        If Not String.IsNullOrEmpty(_initialPassNumber) Then
            txtPassNumberInput.Text = _initialPassNumber
            LoadPassData(_initialPassNumber)
        Else
            ' Load the latest pass from database
            Try
                Dim latestObj As Object = DBConnection.ExecuteScalar("SELECT TOP 1 PassNumber FROM dbo.Passes ORDER BY PassId DESC")
                If latestObj IsNot Nothing Then
                    txtPassNumberInput.Text = latestObj.ToString()
                    LoadPassData(latestObj.ToString())
                End If
            Catch ex As Exception
                ' Keep default preview
            End Try
        End If
    End Sub

    Public Sub LoadPassData(ByVal passNumber As String)
        If String.IsNullOrWhiteSpace(passNumber) Then
            MessageBox.Show("Please enter a valid Bus Pass Number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim sql As String = "SELECT PassNumber, FullName, Gender, Age, ContactNumber, PassCategory, " & _
                                "IdProofType, IdProofNumber, SourceStop, DestinationStop, ValidityPeriod, " & _
                                "StartDate, ExpiryDate, TotalAmount, Status " & _
                                "FROM dbo.Passes WHERE PassNumber = @PassNumber"

            Dim p(0) As SqlParameter
            p(0) = New SqlParameter("@PassNumber", passNumber.Trim())

            Dim dt As DataTable = DBConnection.ExecuteQuery(sql, p)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                Dim passNo As String = row("PassNumber").ToString()
                Dim name As String = row("FullName").ToString()
                Dim gender As String = row("Gender").ToString()
                Dim age As Integer = Convert.ToInt32(row("Age"))
                Dim contact As String = row("ContactNumber").ToString()
                Dim cat As String = row("PassCategory").ToString()
                Dim idType As String = row("IdProofType").ToString()
                Dim idNum As String = row("IdProofNumber").ToString()
                Dim src As String = row("SourceStop").ToString()
                Dim dest As String = row("DestinationStop").ToString()
                Dim valPeriod As String = row("ValidityPeriod").ToString()
                Dim sDate As DateTime = Convert.ToDateTime(row("StartDate"))
                Dim eDate As DateTime = Convert.ToDateTime(row("ExpiryDate"))
                Dim amt As Decimal = Convert.ToDecimal(row("TotalAmount"))
                Dim status As String = row("Status").ToString()

                ' Update Card Display
                lblCardPassNumber.Text = "PASS NO: " & passNo
                lblCardPassengerName.Text = name.ToUpper() & " (" & age.ToString() & ", " & gender & ")"
                lblCardCategory.Text = "CATEGORY: " & cat.ToUpper() & " PASS (" & valPeriod & ")"
                lblCardRoute.Text = src & " <--> " & dest
                lblCardValidFrom.Text = sDate.ToString("dd-MM-yyyy")
                lblCardValidTo.Text = eDate.ToString("dd-MM-yyyy")
                lblCardContact.Text = contact
                lblCardIdProof.Text = idType & ": " & idNum
                lblCardAmount.Text = "Rs. " & amt.ToString("F2")
                lblBarcodeText.Text = "|| | " & passNo & " || |||"

                ' Status Badge
                lblCardStatusBadge.Text = status.ToUpper()
                If status = "Active" Then
                    lblCardStatusBadge.BackColor = Color.ForestGreen
                ElseIf status = "Expired" Then
                    lblCardStatusBadge.BackColor = Color.Firebrick
                Else
                    lblCardStatusBadge.BackColor = Color.Gray
                End If

            Else
                MessageBox.Show("Pass [" & passNumber & "] not found in database!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading pass: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLoadPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPass.Click
        LoadPassData(txtPassNumberInput.Text.Trim())
    End Sub

    Private Sub txtPassNumberInput_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassNumberInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLoadPass.PerformClick()
        End If
    End Sub

    Private Sub CaptureCard()
        _cardBitmap = New Bitmap(pnlPassCard.Width, pnlPassCard.Height)
        pnlPassCard.DrawToBitmap(_cardBitmap, New Rectangle(0, 0, pnlPassCard.Width, pnlPassCard.Height))
    End Sub

    Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        If _cardBitmap IsNot Nothing Then
            ' Center card on printed page
            Dim x As Integer = (e.PageBounds.Width - _cardBitmap.Width) / 2
            Dim y As Integer = 100
            If x < 20 Then x = 20
            e.Graphics.DrawImage(_cardBitmap, x, y)
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        CaptureCard()
        Using dlg As New PrintDialog()
            dlg.Document = _printDoc
            If dlg.ShowDialog() = DialogResult.OK Then
                Try
                    _printDoc.Print()
                Catch ex As Exception
                    MessageBox.Show("Printing error: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        CaptureCard()
        Using dlg As New PrintPreviewDialog()
            dlg.Document = _printDoc
            dlg.Width = 900
            dlg.Height = 700
            dlg.StartPosition = FormStartPosition.CenterScreen
            dlg.ShowDialog()
        End Using
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
