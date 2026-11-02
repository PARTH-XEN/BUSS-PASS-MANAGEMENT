<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RouteManagementForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpRouteEditor = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtMonthlyFare = New System.Windows.Forms.TextBox()
        Me.lblMonthlyFare = New System.Windows.Forms.Label()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.txtRouteName = New System.Windows.Forms.TextBox()
        Me.lblRouteName = New System.Windows.Forms.Label()
        Me.txtRouteNumber = New System.Windows.Forms.TextBox()
        Me.lblRouteNumber = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.dgvRoutes = New System.Windows.Forms.DataGridView()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.grpRouteEditor.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvRoutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
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
        Me.lblTitle.Text = "Bus Routes && Fares Management"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpRouteEditor
        '
        Me.grpRouteEditor.Controls.Add(Me.btnDelete)
        Me.grpRouteEditor.Controls.Add(Me.btnClear)
        Me.grpRouteEditor.Controls.Add(Me.btnUpdate)
        Me.grpRouteEditor.Controls.Add(Me.btnAdd)
        Me.grpRouteEditor.Controls.Add(Me.cmbStatus)
        Me.grpRouteEditor.Controls.Add(Me.lblStatus)
        Me.grpRouteEditor.Controls.Add(Me.txtMonthlyFare)
        Me.grpRouteEditor.Controls.Add(Me.lblMonthlyFare)
        Me.grpRouteEditor.Controls.Add(Me.txtDestination)
        Me.grpRouteEditor.Controls.Add(Me.lblDestination)
        Me.grpRouteEditor.Controls.Add(Me.txtSource)
        Me.grpRouteEditor.Controls.Add(Me.lblSource)
        Me.grpRouteEditor.Controls.Add(Me.txtRouteName)
        Me.grpRouteEditor.Controls.Add(Me.lblRouteName)
        Me.grpRouteEditor.Controls.Add(Me.txtRouteNumber)
        Me.grpRouteEditor.Controls.Add(Me.lblRouteNumber)
        Me.grpRouteEditor.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpRouteEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRouteEditor.ForeColor = System.Drawing.Color.Navy
        Me.grpRouteEditor.Location = New System.Drawing.Point(0, 60)
        Me.grpRouteEditor.Name = "grpRouteEditor"
        Me.grpRouteEditor.Size = New System.Drawing.Size(430, 640)
        Me.grpRouteEditor.TabIndex = 1
        Me.grpRouteEditor.TabStop = False
        Me.grpRouteEditor.Text = " Route Information "
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.DarkRed
        Me.btnDelete.Location = New System.Drawing.Point(225, 410)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(185, 42)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete Route"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(20, 410)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(185, 42)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear / New"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Navy
        Me.btnUpdate.Location = New System.Drawing.Point(225, 350)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(185, 42)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update Route"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnAdd.Location = New System.Drawing.Point(20, 350)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(185, 42)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "+ Add Route"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbStatus.Location = New System.Drawing.Point(155, 275)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(255, 26)
        Me.cmbStatus.TabIndex = 11
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(15, 278)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(52, 17)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "Status:"
        '
        'txtMonthlyFare
        '
        Me.txtMonthlyFare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonthlyFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyFare.Location = New System.Drawing.Point(155, 228)
        Me.txtMonthlyFare.Name = "txtMonthlyFare"
        Me.txtMonthlyFare.Size = New System.Drawing.Size(255, 24)
        Me.txtMonthlyFare.TabIndex = 9
        Me.txtMonthlyFare.Text = "500.00"
        '
        'lblMonthlyFare
        '
        Me.lblMonthlyFare.AutoSize = True
        Me.lblMonthlyFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyFare.ForeColor = System.Drawing.Color.Black
        Me.lblMonthlyFare.Location = New System.Drawing.Point(15, 231)
        Me.lblMonthlyFare.Name = "lblMonthlyFare"
        Me.lblMonthlyFare.Size = New System.Drawing.Size(125, 17)
        Me.lblMonthlyFare.TabIndex = 8
        Me.lblMonthlyFare.Text = "Monthly Fare (Rs):"
        '
        'txtDestination
        '
        Me.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.Location = New System.Drawing.Point(155, 180)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(255, 24)
        Me.txtDestination.TabIndex = 7
        '
        'lblDestination
        '
        Me.lblDestination.AutoSize = True
        Me.lblDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestination.ForeColor = System.Drawing.Color.Black
        Me.lblDestination.Location = New System.Drawing.Point(15, 183)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(116, 17)
        Me.lblDestination.TabIndex = 6
        Me.lblDestination.Text = "Destination Stop:"
        '
        'txtSource
        '
        Me.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSource.Location = New System.Drawing.Point(155, 132)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(255, 24)
        Me.txtSource.TabIndex = 5
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSource.ForeColor = System.Drawing.Color.Black
        Me.lblSource.Location = New System.Drawing.Point(15, 135)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(90, 17)
        Me.lblSource.TabIndex = 4
        Me.lblSource.Text = "Source Stop:"
        '
        'txtRouteName
        '
        Me.txtRouteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRouteName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRouteName.Location = New System.Drawing.Point(155, 85)
        Me.txtRouteName.Name = "txtRouteName"
        Me.txtRouteName.Size = New System.Drawing.Size(255, 24)
        Me.txtRouteName.TabIndex = 3
        '
        'lblRouteName
        '
        Me.lblRouteName.AutoSize = True
        Me.lblRouteName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouteName.ForeColor = System.Drawing.Color.Black
        Me.lblRouteName.Location = New System.Drawing.Point(15, 88)
        Me.lblRouteName.Name = "lblRouteName"
        Me.lblRouteName.Size = New System.Drawing.Size(91, 17)
        Me.lblRouteName.TabIndex = 2
        Me.lblRouteName.Text = "Route Name:"
        '
        'txtRouteNumber
        '
        Me.txtRouteNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRouteNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRouteNumber.Location = New System.Drawing.Point(155, 38)
        Me.txtRouteNumber.Name = "txtRouteNumber"
        Me.txtRouteNumber.Size = New System.Drawing.Size(255, 24)
        Me.txtRouteNumber.TabIndex = 1
        '
        'lblRouteNumber
        '
        Me.lblRouteNumber.AutoSize = True
        Me.lblRouteNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRouteNumber.ForeColor = System.Drawing.Color.Black
        Me.lblRouteNumber.Location = New System.Drawing.Point(15, 41)
        Me.lblRouteNumber.Name = "lblRouteNumber"
        Me.lblRouteNumber.Size = New System.Drawing.Size(104, 17)
        Me.lblRouteNumber.TabIndex = 0
        Me.lblRouteNumber.Text = "Route Number:"
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.dgvRoutes)
        Me.pnlGrid.Controls.Add(Me.pnlSearch)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(430, 60)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlGrid.Size = New System.Drawing.Size(754, 640)
        Me.pnlGrid.TabIndex = 2
        '
        'dgvRoutes
        '
        Me.dgvRoutes.AllowUserToAddRows = False
        Me.dgvRoutes.AllowUserToDeleteRows = False
        Me.dgvRoutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRoutes.BackgroundColor = System.Drawing.Color.White
        Me.dgvRoutes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRoutes.ColumnHeadersHeight = 35
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRoutes.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRoutes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRoutes.Location = New System.Drawing.Point(10, 60)
        Me.dgvRoutes.MultiSelect = False
        Me.dgvRoutes.Name = "dgvRoutes"
        Me.dgvRoutes.ReadOnly = True
        Me.dgvRoutes.RowHeadersVisible = False
        Me.dgvRoutes.RowTemplate.Height = 30
        Me.dgvRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoutes.Size = New System.Drawing.Size(734, 570)
        Me.dgvRoutes.TabIndex = 1
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.SystemColors.Control
        Me.pnlSearch.Controls.Add(Me.btnClose)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.lblSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(10, 10)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(734, 50)
        Me.pnlSearch.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(615, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 36)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(135, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(320, 24)
        Me.txtSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(12, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(112, 17)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search Route:"
        '
        'RouteManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1184, 700)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.grpRouteEditor)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RouteManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bus Pass Management - Bus Routes and Fares"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.grpRouteEditor.ResumeLayout(False)
        Me.grpRouteEditor.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvRoutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpRouteEditor As System.Windows.Forms.GroupBox
    Friend WithEvents lblRouteNumber As System.Windows.Forms.Label
    Friend WithEvents txtRouteNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblRouteName As System.Windows.Forms.Label
    Friend WithEvents txtRouteName As System.Windows.Forms.TextBox
    Friend WithEvents lblSource As System.Windows.Forms.Label
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents lblMonthlyFare As System.Windows.Forms.Label
    Friend WithEvents txtMonthlyFare As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dgvRoutes As System.Windows.Forms.DataGridView

End Class
