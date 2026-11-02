<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPassForm
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpPassenger = New System.Windows.Forms.GroupBox()
        Me.txtIdProofNumber = New System.Windows.Forms.TextBox()
        Me.lblIdProofNumber = New System.Windows.Forms.Label()
        Me.cmbIdProofType = New System.Windows.Forms.ComboBox()
        Me.lblIdProofType = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtPassNumber = New System.Windows.Forms.TextBox()
        Me.lblPassNumber = New System.Windows.Forms.Label()
        Me.grpRouteFare = New System.Windows.Forms.GroupBox()
        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.lblTotalAmountDisplay = New System.Windows.Forms.Label()
        Me.lblTotalAmountHeading = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtBaseFare = New System.Windows.Forms.TextBox()
        Me.lblBaseFare = New System.Windows.Forms.Label()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.lblExpiryDate = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.cmbValidity = New System.Windows.Forms.ComboBox()
        Me.lblValidity = New System.Windows.Forms.Label()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.cmbRoute = New System.Windows.Forms.ComboBox()
        Me.lblRoute = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.grpPassenger.SuspendLayout()
        Me.grpRouteFare.SuspendLayout()
        Me.pnlTotal.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1184, 60)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Issue New Bus Pass"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpPassenger
        '
        Me.grpPassenger.Controls.Add(Me.txtIdProofNumber)
        Me.grpPassenger.Controls.Add(Me.lblIdProofNumber)
        Me.grpPassenger.Controls.Add(Me.cmbIdProofType)
        Me.grpPassenger.Controls.Add(Me.lblIdProofType)
        Me.grpPassenger.Controls.Add(Me.txtAddress)
        Me.grpPassenger.Controls.Add(Me.lblAddress)
        Me.grpPassenger.Controls.Add(Me.txtEmail)
        Me.grpPassenger.Controls.Add(Me.lblEmail)
        Me.grpPassenger.Controls.Add(Me.txtContact)
        Me.grpPassenger.Controls.Add(Me.lblContact)
        Me.grpPassenger.Controls.Add(Me.txtAge)
        Me.grpPassenger.Controls.Add(Me.lblAge)
        Me.grpPassenger.Controls.Add(Me.cmbGender)
        Me.grpPassenger.Controls.Add(Me.lblGender)
        Me.grpPassenger.Controls.Add(Me.txtFullName)
        Me.grpPassenger.Controls.Add(Me.lblFullName)
        Me.grpPassenger.Controls.Add(Me.txtPassNumber)
        Me.grpPassenger.Controls.Add(Me.lblPassNumber)
        Me.grpPassenger.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPassenger.ForeColor = System.Drawing.Color.Navy
        Me.grpPassenger.Location = New System.Drawing.Point(35, 75)
        Me.grpPassenger.Name = "grpPassenger"
        Me.grpPassenger.Size = New System.Drawing.Size(530, 480)
        Me.grpPassenger.TabIndex = 1
        Me.grpPassenger.TabStop = False
        Me.grpPassenger.Text = " 1. Passenger Personal Details "
        '
        'txtIdProofNumber
        '
        Me.txtIdProofNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdProofNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProofNumber.Location = New System.Drawing.Point(170, 425)
        Me.txtIdProofNumber.Name = "txtIdProofNumber"
        Me.txtIdProofNumber.Size = New System.Drawing.Size(330, 24)
        Me.txtIdProofNumber.TabIndex = 17
        '
        'lblIdProofNumber
        '
        Me.lblIdProofNumber.AutoSize = True
        Me.lblIdProofNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdProofNumber.ForeColor = System.Drawing.Color.Black
        Me.lblIdProofNumber.Location = New System.Drawing.Point(20, 428)
        Me.lblIdProofNumber.Name = "lblIdProofNumber"
        Me.lblIdProofNumber.Size = New System.Drawing.Size(115, 17)
        Me.lblIdProofNumber.TabIndex = 16
        Me.lblIdProofNumber.Text = "ID Proof Number:"
        '
        'cmbIdProofType
        '
        Me.cmbIdProofType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdProofType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdProofType.FormattingEnabled = True
        Me.cmbIdProofType.Items.AddRange(New Object() {"Aadhaar Card", "College / Student ID", "Voter ID Card", "Driving License", "Passport"})
        Me.cmbIdProofType.Location = New System.Drawing.Point(170, 380)
        Me.cmbIdProofType.Name = "cmbIdProofType"
        Me.cmbIdProofType.Size = New System.Drawing.Size(330, 26)
        Me.cmbIdProofType.TabIndex = 15
        '
        'lblIdProofType
        '
        Me.lblIdProofType.AutoSize = True
        Me.lblIdProofType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdProofType.ForeColor = System.Drawing.Color.Black
        Me.lblIdProofType.Location = New System.Drawing.Point(20, 383)
        Me.lblIdProofType.Name = "lblIdProofType"
        Me.lblIdProofType.Size = New System.Drawing.Size(97, 17)
        Me.lblIdProofType.TabIndex = 14
        Me.lblIdProofType.Text = "ID Proof Type:"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(170, 298)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(330, 65)
        Me.txtAddress.TabIndex = 13
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(20, 300)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(64, 17)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address:"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(170, 255)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(330, 24)
        Me.txtEmail.TabIndex = 11
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(20, 258)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(62, 17)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email ID:"
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(170, 210)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(330, 24)
        Me.txtContact.TabIndex = 9
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.Black
        Me.lblContact.Location = New System.Drawing.Point(20, 213)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(114, 17)
        Me.lblContact.TabIndex = 8
        Me.lblContact.Text = "Contact Number:"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(170, 168)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(110, 24)
        Me.txtAge.TabIndex = 7
        Me.txtAge.Text = "20"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(20, 171)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(37, 17)
        Me.lblAge.TabIndex = 6
        Me.lblAge.Text = "Age:"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(170, 125)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(220, 26)
        Me.cmbGender.TabIndex = 5
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(20, 128)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(60, 17)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "Gender:"
        '
        'txtFullName
        '
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(170, 80)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(330, 24)
        Me.txtFullName.TabIndex = 3
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.Black
        Me.lblFullName.Location = New System.Drawing.Point(20, 83)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(75, 17)
        Me.lblFullName.TabIndex = 2
        Me.lblFullName.Text = "Full Name:"
        '
        'txtPassNumber
        '
        Me.txtPassNumber.BackColor = System.Drawing.SystemColors.Info
        Me.txtPassNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassNumber.ForeColor = System.Drawing.Color.Navy
        Me.txtPassNumber.Location = New System.Drawing.Point(170, 35)
        Me.txtPassNumber.Name = "txtPassNumber"
        Me.txtPassNumber.ReadOnly = True
        Me.txtPassNumber.Size = New System.Drawing.Size(220, 25)
        Me.txtPassNumber.TabIndex = 1
        '
        'lblPassNumber
        '
        Me.lblPassNumber.AutoSize = True
        Me.lblPassNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassNumber.ForeColor = System.Drawing.Color.Black
        Me.lblPassNumber.Location = New System.Drawing.Point(20, 38)
        Me.lblPassNumber.Name = "lblPassNumber"
        Me.lblPassNumber.Size = New System.Drawing.Size(97, 17)
        Me.lblPassNumber.TabIndex = 0
        Me.lblPassNumber.Text = "Pass Number:"
        '
        'grpRouteFare
        '
        Me.grpRouteFare.Controls.Add(Me.pnlTotal)
        Me.grpRouteFare.Controls.Add(Me.txtDiscount)
        Me.grpRouteFare.Controls.Add(Me.lblDiscount)
        Me.grpRouteFare.Controls.Add(Me.txtBaseFare)
        Me.grpRouteFare.Controls.Add(Me.lblBaseFare)
        Me.grpRouteFare.Controls.Add(Me.dtpExpiryDate)
        Me.grpRouteFare.Controls.Add(Me.lblExpiryDate)
        Me.grpRouteFare.Controls.Add(Me.dtpStartDate)
        Me.grpRouteFare.Controls.Add(Me.lblStartDate)
        Me.grpRouteFare.Controls.Add(Me.cmbValidity)
        Me.grpRouteFare.Controls.Add(Me.lblValidity)
        Me.grpRouteFare.Controls.Add(Me.txtDestination)
        Me.grpRouteFare.Controls.Add(Me.lblDestination)
        Me.grpRouteFare.Controls.Add(Me.txtSource)
        Me.grpRouteFare.Controls.Add(Me.lblSource)
        Me.grpRouteFare.Controls.Add(Me.cmbRoute)
        Me.grpRouteFare.Controls.Add(Me.lblRoute)
        Me.grpRouteFare.Controls.Add(Me.cmbCategory)
        Me.grpRouteFare.Controls.Add(Me.lblCategory)
        Me.grpRouteFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRouteFare.ForeColor = System.Drawing.Color.Navy
        Me.grpRouteFare.Location = New System.Drawing.Point(595, 75)
        Me.grpRouteFare.Name = "grpRouteFare"
        Me.grpRouteFare.Size = New System.Drawing.Size(550, 480)
        Me.grpRouteFare.TabIndex = 2
        Me.grpRouteFare.TabStop = False
        Me.grpRouteFare.Text = " 2. Route && Fare Details "
        '
        'pnlTotal
        '
        Me.pnlTotal.BackColor = System.Drawing.SystemColors.Info
        Me.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotal.Controls.Add(Me.lblTotalAmountDisplay)
        Me.pnlTotal.Controls.Add(Me.lblTotalAmountHeading)
        Me.pnlTotal.Location = New System.Drawing.Point(25, 395)
        Me.pnlTotal.Name = "pnlTotal"
        Me.pnlTotal.Size = New System.Drawing.Size(495, 68)
        Me.pnlTotal.TabIndex = 18
        '
        'lblTotalAmountDisplay
        '
        Me.lblTotalAmountDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountDisplay.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTotalAmountDisplay.Location = New System.Drawing.Point(15, 28)
        Me.lblTotalAmountDisplay.Name = "lblTotalAmountDisplay"
        Me.lblTotalAmountDisplay.Size = New System.Drawing.Size(465, 32)
        Me.lblTotalAmountDisplay.TabIndex = 1
        Me.lblTotalAmountDisplay.Text = "Rs. 0.00"
        Me.lblTotalAmountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalAmountHeading
        '
        Me.lblTotalAmountHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountHeading.ForeColor = System.Drawing.Color.Black
        Me.lblTotalAmountHeading.Location = New System.Drawing.Point(15, 5)
        Me.lblTotalAmountHeading.Name = "lblTotalAmountHeading"
        Me.lblTotalAmountHeading.Size = New System.Drawing.Size(465, 18)
        Me.lblTotalAmountHeading.TabIndex = 0
        Me.lblTotalAmountHeading.Text = "TOTAL FARE PAYABLE:"
        Me.lblTotalAmountHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.SystemColors.Control
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Firebrick
        Me.txtDiscount.Location = New System.Drawing.Point(380, 350)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(140, 24)
        Me.txtDiscount.TabIndex = 17
        Me.txtDiscount.Text = "0.00"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.Black
        Me.lblDiscount.Location = New System.Drawing.Point(300, 353)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(67, 17)
        Me.lblDiscount.TabIndex = 16
        Me.lblDiscount.Text = "Discount:"
        '
        'txtBaseFare
        '
        Me.txtBaseFare.BackColor = System.Drawing.SystemColors.Control
        Me.txtBaseFare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBaseFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseFare.Location = New System.Drawing.Point(140, 350)
        Me.txtBaseFare.Name = "txtBaseFare"
        Me.txtBaseFare.ReadOnly = True
        Me.txtBaseFare.Size = New System.Drawing.Size(140, 24)
        Me.txtBaseFare.TabIndex = 15
        Me.txtBaseFare.Text = "0.00"
        '
        'lblBaseFare
        '
        Me.lblBaseFare.AutoSize = True
        Me.lblBaseFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBaseFare.ForeColor = System.Drawing.Color.Black
        Me.lblBaseFare.Location = New System.Drawing.Point(20, 353)
        Me.lblBaseFare.Name = "lblBaseFare"
        Me.lblBaseFare.Size = New System.Drawing.Size(77, 17)
        Me.lblBaseFare.TabIndex = 14
        Me.lblBaseFare.Text = "Base Fare:"
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpiryDate.Location = New System.Drawing.Point(170, 305)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.Size = New System.Drawing.Size(350, 24)
        Me.dtpExpiryDate.TabIndex = 13
        '
        'lblExpiryDate
        '
        Me.lblExpiryDate.AutoSize = True
        Me.lblExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiryDate.ForeColor = System.Drawing.Color.Black
        Me.lblExpiryDate.Location = New System.Drawing.Point(20, 308)
        Me.lblExpiryDate.Name = "lblExpiryDate"
        Me.lblExpiryDate.Size = New System.Drawing.Size(83, 17)
        Me.lblExpiryDate.TabIndex = 12
        Me.lblExpiryDate.Text = "Expiry Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(170, 260)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(350, 24)
        Me.dtpStartDate.TabIndex = 11
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.ForeColor = System.Drawing.Color.Black
        Me.lblStartDate.Location = New System.Drawing.Point(20, 263)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(76, 17)
        Me.lblStartDate.TabIndex = 10
        Me.lblStartDate.Text = "Start Date:"
        '
        'cmbValidity
        '
        Me.cmbValidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbValidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbValidity.FormattingEnabled = True
        Me.cmbValidity.Items.AddRange(New Object() {"1 Month", "3 Months", "6 Months", "1 Year"})
        Me.cmbValidity.Location = New System.Drawing.Point(170, 215)
        Me.cmbValidity.Name = "cmbValidity"
        Me.cmbValidity.Size = New System.Drawing.Size(350, 26)
        Me.cmbValidity.TabIndex = 9
        '
        'lblValidity
        '
        Me.lblValidity.AutoSize = True
        Me.lblValidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidity.ForeColor = System.Drawing.Color.Black
        Me.lblValidity.Location = New System.Drawing.Point(20, 218)
        Me.lblValidity.Name = "lblValidity"
        Me.lblValidity.Size = New System.Drawing.Size(101, 17)
        Me.lblValidity.TabIndex = 8
        Me.lblValidity.Text = "Validity Period:"
        '
        'txtDestination
        '
        Me.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.Location = New System.Drawing.Point(170, 170)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(350, 24)
        Me.txtDestination.TabIndex = 7
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.ForeColor = System.Drawing.Color.Black
        Me.lblDestination.Location = New System.Drawing.Point(20, 173)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(116, 17)
        Me.lblDestination.TabIndex = 6
        Me.lblDestination.Text = "Destination Stop:"
        '
        'txtSource
        '
        Me.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSource.Location = New System.Drawing.Point(170, 125)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(350, 24)
        Me.txtSource.TabIndex = 5
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSource.ForeColor = System.Drawing.Color.Black
        Me.lblSource.Location = New System.Drawing.Point(20, 128)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(90, 17)
        Me.lblSource.TabIndex = 4
        Me.lblSource.Text = "Source Stop:"
        '
        'cmbRoute
        '
        Me.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoute.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoute.FormattingEnabled = True
        Me.cmbRoute.Location = New System.Drawing.Point(170, 80)
        Me.cmbRoute.Name = "cmbRoute"
        Me.cmbRoute.Size = New System.Drawing.Size(350, 26)
        Me.cmbRoute.TabIndex = 3
        '
        'lblRoute
        '
        Me.lblRoute.AutoSize = True
        Me.lblRoute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoute.ForeColor = System.Drawing.Color.Black
        Me.lblRoute.Location = New System.Drawing.Point(20, 83)
        Me.lblRoute.Name = "lblRoute"
        Me.lblRoute.Size = New System.Drawing.Size(93, 17)
        Me.lblRoute.TabIndex = 2
        Me.lblRoute.Text = "Select Route:"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Student (30% Discount)", "Senior Citizen (50% Discount)", "General Public (No Discount)", "Employee (20% Discount)"})
        Me.cmbCategory.Location = New System.Drawing.Point(170, 35)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(350, 26)
        Me.cmbCategory.TabIndex = 1
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.Black
        Me.lblCategory.Location = New System.Drawing.Point(20, 38)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(104, 17)
        Me.lblCategory.TabIndex = 0
        Me.lblCategory.Text = "Pass Category:"
        '
        'pnlActions
        '
        Me.pnlActions.Controls.Add(Me.btnClose)
        Me.pnlActions.Controls.Add(Me.btnReset)
        Me.pnlActions.Controls.Add(Me.btnPrint)
        Me.pnlActions.Controls.Add(Me.btnSave)
        Me.pnlActions.Location = New System.Drawing.Point(35, 575)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(1110, 65)
        Me.pnlActions.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.DarkRed
        Me.btnClose.Location = New System.Drawing.Point(880, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(200, 46)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(620, 10)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(200, 46)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Navy
        Me.btnPrint.Location = New System.Drawing.Point(330, 10)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(230, 46)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print Pass Card"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSave.Location = New System.Drawing.Point(20, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(250, 46)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save && Issue Pass"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'NewPassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1184, 680)
        Me.Controls.Add(Me.pnlActions)
        Me.Controls.Add(Me.grpRouteFare)
        Me.Controls.Add(Me.grpPassenger)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewPassForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bus Pass Management - Issue New Pass"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.grpPassenger.ResumeLayout(False)
        Me.grpPassenger.PerformLayout()
        Me.grpRouteFare.ResumeLayout(False)
        Me.grpRouteFare.PerformLayout()
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpPassenger As System.Windows.Forms.GroupBox
    Friend WithEvents lblPassNumber As System.Windows.Forms.Label
    Friend WithEvents txtPassNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblIdProofType As System.Windows.Forms.Label
    Friend WithEvents cmbIdProofType As System.Windows.Forms.ComboBox
    Friend WithEvents lblIdProofNumber As System.Windows.Forms.Label
    Friend WithEvents txtIdProofNumber As System.Windows.Forms.TextBox
    Friend WithEvents grpRouteFare As System.Windows.Forms.GroupBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoute As System.Windows.Forms.Label
    Friend WithEvents cmbRoute As System.Windows.Forms.ComboBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents lblValidity As System.Windows.Forms.Label
    Friend WithEvents cmbValidity As System.Windows.Forms.ComboBox
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblExpiryDate As System.Windows.Forms.Label
    Friend WithEvents dtpExpiryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBaseFare As System.Windows.Forms.Label
    Friend WithEvents txtBaseFare As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents pnlTotal As System.Windows.Forms.Panel
    Friend WithEvents lblTotalAmountHeading As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmountDisplay As System.Windows.Forms.Label
    Friend WithEvents pnlActions As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
