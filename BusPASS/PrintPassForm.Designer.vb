<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintPassForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnLoadPass = New System.Windows.Forms.Button()
        Me.txtPassNumberInput = New System.Windows.Forms.TextBox()
        Me.lblInputPrompt = New System.Windows.Forms.Label()
        Me.pnlPassCard = New System.Windows.Forms.Panel()
        Me.lblSignatory = New System.Windows.Forms.Label()
        Me.lblSignLine = New System.Windows.Forms.Label()
        Me.pnlBarcode = New System.Windows.Forms.Panel()
        Me.lblBarcodeText = New System.Windows.Forms.Label()
        Me.lblCardAmount = New System.Windows.Forms.Label()
        Me.lblCardAmountTitle = New System.Windows.Forms.Label()
        Me.lblCardIdProof = New System.Windows.Forms.Label()
        Me.lblCardIdProofTitle = New System.Windows.Forms.Label()
        Me.lblCardContact = New System.Windows.Forms.Label()
        Me.lblCardContactTitle = New System.Windows.Forms.Label()
        Me.lblCardValidTo = New System.Windows.Forms.Label()
        Me.lblCardValidToTitle = New System.Windows.Forms.Label()
        Me.lblCardValidFrom = New System.Windows.Forms.Label()
        Me.lblCardValidFromTitle = New System.Windows.Forms.Label()
        Me.lblCardRoute = New System.Windows.Forms.Label()
        Me.lblCardRouteTitle = New System.Windows.Forms.Label()
        Me.lblCardCategory = New System.Windows.Forms.Label()
        Me.lblCardPassengerName = New System.Windows.Forms.Label()
        Me.lblCardPassNumber = New System.Windows.Forms.Label()
        Me.pnlPhoto = New System.Windows.Forms.Panel()
        Me.lblPhotoText = New System.Windows.Forms.Label()
        Me.pnlCardHeader = New System.Windows.Forms.Panel()
        Me.lblCardStatusBadge = New System.Windows.Forms.Label()
        Me.lblCardSubheader = New System.Windows.Forms.Label()
        Me.lblCardMainHeader = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.pnlPassCard.SuspendLayout()
        Me.pnlBarcode.SuspendLayout()
        Me.pnlPhoto.SuspendLayout()
        Me.pnlCardHeader.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.Control
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.btnLoadPass)
        Me.pnlTop.Controls.Add(Me.txtPassNumberInput)
        Me.pnlTop.Controls.Add(Me.lblInputPrompt)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(864, 65)
        Me.pnlTop.TabIndex = 0
        '
        'btnLoadPass
        '
        Me.btnLoadPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadPass.Location = New System.Drawing.Point(490, 14)
        Me.btnLoadPass.Name = "btnLoadPass"
        Me.btnLoadPass.Size = New System.Drawing.Size(140, 34)
        Me.btnLoadPass.TabIndex = 2
        Me.btnLoadPass.Text = "Load Pass"
        Me.btnLoadPass.UseVisualStyleBackColor = True
        '
        'txtPassNumberInput
        '
        Me.txtPassNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassNumberInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassNumberInput.Location = New System.Drawing.Point(260, 18)
        Me.txtPassNumberInput.Name = "txtPassNumberInput"
        Me.txtPassNumberInput.Size = New System.Drawing.Size(210, 26)
        Me.txtPassNumberInput.TabIndex = 1
        '
        'lblInputPrompt
        '
        Me.lblInputPrompt.AutoSize = True
        Me.lblInputPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputPrompt.ForeColor = System.Drawing.Color.Black
        Me.lblInputPrompt.Location = New System.Drawing.Point(50, 22)
        Me.lblInputPrompt.Name = "lblInputPrompt"
        Me.lblInputPrompt.Size = New System.Drawing.Size(193, 18)
        Me.lblInputPrompt.TabIndex = 0
        Me.lblInputPrompt.Text = "Enter Bus Pass Number:"
        '
        'pnlPassCard
        '
        Me.pnlPassCard.BackColor = System.Drawing.Color.White
        Me.pnlPassCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPassCard.Controls.Add(Me.lblSignatory)
        Me.pnlPassCard.Controls.Add(Me.lblSignLine)
        Me.pnlPassCard.Controls.Add(Me.pnlBarcode)
        Me.pnlPassCard.Controls.Add(Me.lblCardAmount)
        Me.pnlPassCard.Controls.Add(Me.lblCardAmountTitle)
        Me.pnlPassCard.Controls.Add(Me.lblCardIdProof)
        Me.pnlPassCard.Controls.Add(Me.lblCardIdProofTitle)
        Me.pnlPassCard.Controls.Add(Me.lblCardContact)
        Me.pnlPassCard.Controls.Add(Me.lblCardContactTitle)
        Me.pnlPassCard.Controls.Add(Me.lblCardValidTo)
        Me.pnlPassCard.Controls.Add(Me.lblCardValidToTitle)
        Me.pnlPassCard.Controls.Add(Me.lblCardValidFrom)
        Me.pnlPassCard.Controls.Add(Me.lblCardValidFromTitle)
        Me.pnlPassCard.Controls.Add(Me.lblCardRoute)
        Me.pnlPassCard.Controls.Add(Me.lblCardRouteTitle)
        Me.pnlPassCard.Controls.Add(Me.lblCardCategory)
        Me.pnlPassCard.Controls.Add(Me.lblCardPassengerName)
        Me.pnlPassCard.Controls.Add(Me.lblCardPassNumber)
        Me.pnlPassCard.Controls.Add(Me.pnlPhoto)
        Me.pnlPassCard.Controls.Add(Me.pnlCardHeader)
        Me.pnlPassCard.Location = New System.Drawing.Point(52, 85)
        Me.pnlPassCard.Name = "pnlPassCard"
        Me.pnlPassCard.Size = New System.Drawing.Size(760, 435)
        Me.pnlPassCard.TabIndex = 1
        '
        'lblSignatory
        '
        Me.lblSignatory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignatory.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblSignatory.Location = New System.Drawing.Point(535, 400)
        Me.lblSignatory.Name = "lblSignatory"
        Me.lblSignatory.Size = New System.Drawing.Size(200, 20)
        Me.lblSignatory.TabIndex = 19
        Me.lblSignatory.Text = "AUTHORIZED SIGNATORY"
        Me.lblSignatory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSignLine
        '
        Me.lblSignLine.BackColor = System.Drawing.Color.Black
        Me.lblSignLine.Location = New System.Drawing.Point(535, 395)
        Me.lblSignLine.Name = "lblSignLine"
        Me.lblSignLine.Size = New System.Drawing.Size(200, 2)
        Me.lblSignLine.TabIndex = 18
        '
        'pnlBarcode
        '
        Me.pnlBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBarcode.Controls.Add(Me.lblBarcodeText)
        Me.pnlBarcode.Location = New System.Drawing.Point(25, 375)
        Me.pnlBarcode.Name = "pnlBarcode"
        Me.pnlBarcode.Size = New System.Drawing.Size(350, 45)
        Me.pnlBarcode.TabIndex = 17
        '
        'lblBarcodeText
        '
        Me.lblBarcodeText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBarcodeText.Font = New System.Drawing.Font("Courier New", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcodeText.ForeColor = System.Drawing.Color.Black
        Me.lblBarcodeText.Location = New System.Drawing.Point(0, 0)
        Me.lblBarcodeText.Name = "lblBarcodeText"
        Me.lblBarcodeText.Size = New System.Drawing.Size(348, 43)
        Me.lblBarcodeText.TabIndex = 0
        Me.lblBarcodeText.Text = "|| |||| | |||||| |||| | |||"
        Me.lblBarcodeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCardAmount
        '
        Me.lblCardAmount.AutoSize = True
        Me.lblCardAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardAmount.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblCardAmount.Location = New System.Drawing.Point(545, 310)
        Me.lblCardAmount.Name = "lblCardAmount"
        Me.lblCardAmount.Size = New System.Drawing.Size(107, 22)
        Me.lblCardAmount.TabIndex = 16
        Me.lblCardAmount.Text = "Rs. 840.00"
        '
        'lblCardAmountTitle
        '
        Me.lblCardAmountTitle.AutoSize = True
        Me.lblCardAmountTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardAmountTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCardAmountTitle.Location = New System.Drawing.Point(435, 314)
        Me.lblCardAmountTitle.Name = "lblCardAmountTitle"
        Me.lblCardAmountTitle.Size = New System.Drawing.Size(104, 17)
        Me.lblCardAmountTitle.TabIndex = 15
        Me.lblCardAmountTitle.Text = "Amount Paid:"
        '
        'lblCardIdProof
        '
        Me.lblCardIdProof.AutoSize = True
        Me.lblCardIdProof.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardIdProof.ForeColor = System.Drawing.Color.Black
        Me.lblCardIdProof.Location = New System.Drawing.Point(130, 310)
        Me.lblCardIdProof.Name = "lblCardIdProof"
        Me.lblCardIdProof.Size = New System.Drawing.Size(193, 18)
        Me.lblCardIdProof.TabIndex = 14
        Me.lblCardIdProof.Text = "College ID: CLG-2024-88"
        '
        'lblCardIdProofTitle
        '
        Me.lblCardIdProofTitle.AutoSize = True
        Me.lblCardIdProofTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardIdProofTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCardIdProofTitle.Location = New System.Drawing.Point(25, 310)
        Me.lblCardIdProofTitle.Name = "lblCardIdProofTitle"
        Me.lblCardIdProofTitle.Size = New System.Drawing.Size(71, 17)
        Me.lblCardIdProofTitle.TabIndex = 13
        Me.lblCardIdProofTitle.Text = "ID Proof:"
        '
        'lblCardContact
        '
        Me.lblCardContact.AutoSize = True
        Me.lblCardContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardContact.ForeColor = System.Drawing.Color.Black
        Me.lblCardContact.Location = New System.Drawing.Point(545, 270)
        Me.lblCardContact.Name = "lblCardContact"
        Me.lblCardContact.Size = New System.Drawing.Size(98, 18)
        Me.lblCardContact.TabIndex = 12
        Me.lblCardContact.Text = "9876543210"
        '
        'lblCardContactTitle
        '
        Me.lblCardContactTitle.AutoSize = True
        Me.lblCardContactTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardContactTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCardContactTitle.Location = New System.Drawing.Point(435, 270)
        Me.lblCardContactTitle.Name = "lblCardContactTitle"
        Me.lblCardContactTitle.Size = New System.Drawing.Size(93, 17)
        Me.lblCardContactTitle.TabIndex = 11
        Me.lblCardContactTitle.Text = "Contact No:"
        '
        'lblCardValidTo
        '
        Me.lblCardValidTo.AutoSize = True
        Me.lblCardValidTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardValidTo.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCardValidTo.Location = New System.Drawing.Point(545, 225)
        Me.lblCardValidTo.Name = "lblCardValidTo"
        Me.lblCardValidTo.Size = New System.Drawing.Size(101, 20)
        Me.lblCardValidTo.TabIndex = 10
        Me.lblCardValidTo.Text = "28-01-2027"
        '
        'lblCardValidToTitle
        '
        Me.lblCardValidToTitle.AutoSize = True
        Me.lblCardValidToTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardValidToTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCardValidToTitle.Location = New System.Drawing.Point(435, 227)
        Me.lblCardValidToTitle.Name = "lblCardValidToTitle"
        Me.lblCardValidToTitle.Size = New System.Drawing.Size(76, 17)
        Me.lblCardValidToTitle.TabIndex = 9
        Me.lblCardValidToTitle.Text = "Valid Till:"
        '
        'lblCardValidFrom
        '
        Me.lblCardValidFrom.AutoSize = True
        Me.lblCardValidFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardValidFrom.ForeColor = System.Drawing.Color.Black
        Me.lblCardValidFrom.Location = New System.Drawing.Point(130, 270)
        Me.lblCardValidFrom.Name = "lblCardValidFrom"
        Me.lblCardValidFrom.Size = New System.Drawing.Size(92, 18)
        Me.lblCardValidFrom.TabIndex = 8
        Me.lblCardValidFrom.Text = "28-10-2026"
        '
        'lblCardValidFromTitle
        '
        Me.lblCardValidFromTitle.AutoSize = True
        Me.lblCardValidFromTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardValidFromTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCardValidFromTitle.Location = New System.Drawing.Point(25, 270)
        Me.lblCardValidFromTitle.Name = "lblCardValidFromTitle"
        Me.lblCardValidFromTitle.Size = New System.Drawing.Size(90, 17)
        Me.lblCardValidFromTitle.TabIndex = 7
        Me.lblCardValidFromTitle.Text = "Valid From:"
        '
        'lblCardRoute
        '
        Me.lblCardRoute.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardRoute.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblCardRoute.Location = New System.Drawing.Point(130, 225)
        Me.lblCardRoute.Name = "lblCardRoute"
        Me.lblCardRoute.Size = New System.Drawing.Size(280, 25)
        Me.lblCardRoute.TabIndex = 6
        Me.lblCardRoute.Text = "Railway Station <--> Central Univ"
        '
        'lblCardRouteTitle
        '
        Me.lblCardRouteTitle.AutoSize = True
        Me.lblCardRouteTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardRouteTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCardRouteTitle.Location = New System.Drawing.Point(25, 227)
        Me.lblCardRouteTitle.Name = "lblCardRouteTitle"
        Me.lblCardRouteTitle.Size = New System.Drawing.Size(102, 17)
        Me.lblCardRouteTitle.TabIndex = 5
        Me.lblCardRouteTitle.Text = "Route Stops:"
        '
        'lblCardCategory
        '
        Me.lblCardCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardCategory.ForeColor = System.Drawing.Color.DarkMagenta
        Me.lblCardCategory.Location = New System.Drawing.Point(155, 172)
        Me.lblCardCategory.Name = "lblCardCategory"
        Me.lblCardCategory.Size = New System.Drawing.Size(420, 25)
        Me.lblCardCategory.TabIndex = 4
        Me.lblCardCategory.Text = "CATEGORY: STUDENT PASS (3 Months)"
        '
        'lblCardPassengerName
        '
        Me.lblCardPassengerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardPassengerName.ForeColor = System.Drawing.Color.Navy
        Me.lblCardPassengerName.Location = New System.Drawing.Point(155, 132)
        Me.lblCardPassengerName.Name = "lblCardPassengerName"
        Me.lblCardPassengerName.Size = New System.Drawing.Size(420, 30)
        Me.lblCardPassengerName.TabIndex = 3
        Me.lblCardPassengerName.Text = "RAHUL SHARMA (21, Male)"
        '
        'lblCardPassNumber
        '
        Me.lblCardPassNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardPassNumber.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCardPassNumber.Location = New System.Drawing.Point(155, 95)
        Me.lblCardPassNumber.Name = "lblCardPassNumber"
        Me.lblCardPassNumber.Size = New System.Drawing.Size(420, 26)
        Me.lblCardPassNumber.TabIndex = 2
        Me.lblCardPassNumber.Text = "PASS NO: BP-1001"
        '
        'pnlPhoto
        '
        Me.pnlPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.pnlPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPhoto.Controls.Add(Me.lblPhotoText)
        Me.pnlPhoto.Location = New System.Drawing.Point(25, 95)
        Me.pnlPhoto.Name = "pnlPhoto"
        Me.pnlPhoto.Size = New System.Drawing.Size(110, 115)
        Me.pnlPhoto.TabIndex = 1
        '
        'lblPhotoText
        '
        Me.lblPhotoText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPhotoText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhotoText.ForeColor = System.Drawing.Color.Gray
        Me.lblPhotoText.Location = New System.Drawing.Point(0, 0)
        Me.lblPhotoText.Name = "lblPhotoText"
        Me.lblPhotoText.Size = New System.Drawing.Size(108, 113)
        Me.lblPhotoText.TabIndex = 0
        Me.lblPhotoText.Text = "PHOTO"
        Me.lblPhotoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCardHeader
        '
        Me.pnlCardHeader.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlCardHeader.Controls.Add(Me.lblCardStatusBadge)
        Me.pnlCardHeader.Controls.Add(Me.lblCardSubheader)
        Me.pnlCardHeader.Controls.Add(Me.lblCardMainHeader)
        Me.pnlCardHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCardHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlCardHeader.Name = "pnlCardHeader"
        Me.pnlCardHeader.Size = New System.Drawing.Size(758, 75)
        Me.pnlCardHeader.TabIndex = 0
        '
        'lblCardStatusBadge
        '
        Me.lblCardStatusBadge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCardStatusBadge.BackColor = System.Drawing.Color.ForestGreen
        Me.lblCardStatusBadge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardStatusBadge.ForeColor = System.Drawing.Color.White
        Me.lblCardStatusBadge.Location = New System.Drawing.Point(635, 20)
        Me.lblCardStatusBadge.Name = "lblCardStatusBadge"
        Me.lblCardStatusBadge.Size = New System.Drawing.Size(105, 32)
        Me.lblCardStatusBadge.TabIndex = 2
        Me.lblCardStatusBadge.Text = "ACTIVE"
        Me.lblCardStatusBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCardSubheader
        '
        Me.lblCardSubheader.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardSubheader.ForeColor = System.Drawing.Color.LemonChiffon
        Me.lblCardSubheader.Location = New System.Drawing.Point(15, 42)
        Me.lblCardSubheader.Name = "lblCardSubheader"
        Me.lblCardSubheader.Size = New System.Drawing.Size(590, 22)
        Me.lblCardSubheader.TabIndex = 1
        Me.lblCardSubheader.Text = "Official Commuter Bus Pass"
        '
        'lblCardMainHeader
        '
        Me.lblCardMainHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardMainHeader.ForeColor = System.Drawing.Color.White
        Me.lblCardMainHeader.Location = New System.Drawing.Point(15, 10)
        Me.lblCardMainHeader.Name = "lblCardMainHeader"
        Me.lblCardMainHeader.Size = New System.Drawing.Size(590, 28)
        Me.lblCardMainHeader.TabIndex = 0
        Me.lblCardMainHeader.Text = "MUNICIPAL TRANSPORT CORPORATION"
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBottom.Controls.Add(Me.btnClose)
        Me.pnlBottom.Controls.Add(Me.btnPreview)
        Me.pnlBottom.Controls.Add(Me.btnPrint)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 545)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(864, 75)
        Me.pnlBottom.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.DarkRed
        Me.btnClose.Location = New System.Drawing.Point(620, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(180, 44)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPreview.Location = New System.Drawing.Point(340, 15)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(220, 44)
        Me.btnPreview.TabIndex = 1
        Me.btnPreview.Text = "Print Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnPrint.Location = New System.Drawing.Point(60, 15)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(220, 44)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print Pass Card"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintPassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(864, 620)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlPassCard)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "PrintPassForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bus Pass Management - Print Bus Pass Card"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlPassCard.ResumeLayout(False)
        Me.pnlPassCard.PerformLayout()
        Me.pnlBarcode.ResumeLayout(False)
        Me.pnlPhoto.ResumeLayout(False)
        Me.pnlCardHeader.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblInputPrompt As System.Windows.Forms.Label
    Friend WithEvents txtPassNumberInput As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadPass As System.Windows.Forms.Button
    Friend WithEvents pnlPassCard As System.Windows.Forms.Panel
    Friend WithEvents pnlCardHeader As System.Windows.Forms.Panel
    Friend WithEvents lblCardMainHeader As System.Windows.Forms.Label
    Friend WithEvents lblCardSubheader As System.Windows.Forms.Label
    Friend WithEvents lblCardStatusBadge As System.Windows.Forms.Label
    Friend WithEvents pnlPhoto As System.Windows.Forms.Panel
    Friend WithEvents lblPhotoText As System.Windows.Forms.Label
    Friend WithEvents lblCardPassNumber As System.Windows.Forms.Label
    Friend WithEvents lblCardPassengerName As System.Windows.Forms.Label
    Friend WithEvents lblCardCategory As System.Windows.Forms.Label
    Friend WithEvents lblCardRouteTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardRoute As System.Windows.Forms.Label
    Friend WithEvents lblCardValidFromTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardValidFrom As System.Windows.Forms.Label
    Friend WithEvents lblCardValidToTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardValidTo As System.Windows.Forms.Label
    Friend WithEvents lblCardContactTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardContact As System.Windows.Forms.Label
    Friend WithEvents lblCardIdProofTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardIdProof As System.Windows.Forms.Label
    Friend WithEvents lblCardAmountTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardAmount As System.Windows.Forms.Label
    Friend WithEvents pnlBarcode As System.Windows.Forms.Panel
    Friend WithEvents lblBarcodeText As System.Windows.Forms.Label
    Friend WithEvents lblSignLine As System.Windows.Forms.Label
    Friend WithEvents lblSignatory As System.Windows.Forms.Label
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
