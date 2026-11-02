<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDashboardForm
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
        Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.lblCountRoutes = New System.Windows.Forms.Label()
        Me.lblTitleRoutes = New System.Windows.Forms.Label()
        Me.lblCountExpired = New System.Windows.Forms.Label()
        Me.lblTitleExpired = New System.Windows.Forms.Label()
        Me.lblCountActive = New System.Windows.Forms.Label()
        Me.lblTitleActive = New System.Windows.Forms.Label()
        Me.lblCountTotal = New System.Windows.Forms.Label()
        Me.lblTitleTotal = New System.Windows.Forms.Label()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnPrintPass = New System.Windows.Forms.Button()
        Me.btnManageRoutes = New System.Windows.Forms.Button()
        Me.btnManagePasses = New System.Windows.Forms.Button()
        Me.btnNewPass = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.dgvRecentPasses = New System.Windows.Forms.DataGridView()
        Me.pnlTableTop = New System.Windows.Forms.Panel()
        Me.btnRefreshDashboard = New System.Windows.Forms.Button()
        Me.lblTableTitle = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        Me.grpStats.SuspendLayout()
        Me.pnlNav.SuspendLayout()
        Me.grpMenu.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvRecentPasses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTableTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlHeader.Controls.Add(Me.lblCurrentDate)
        Me.pnlHeader.Controls.Add(Me.lblWelcome)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1184, 80)
        Me.pnlHeader.TabIndex = 0
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.ForeColor = System.Drawing.Color.White
        Me.lblCurrentDate.Location = New System.Drawing.Point(820, 48)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(350, 22)
        Me.lblCurrentDate.TabIndex = 2
        Me.lblCurrentDate.Text = "Date: 28-Oct-2026"
        Me.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.LemonChiffon
        Me.lblWelcome.Location = New System.Drawing.Point(20, 48)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(550, 22)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, Administrator (Admin Panel)"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(18, 10)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(750, 36)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "BUS PASS MANAGEMENT SYSTEM - ADMIN DASHBOARD"
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.SystemColors.Control
        Me.pnlStats.Controls.Add(Me.grpStats)
        Me.pnlStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStats.Location = New System.Drawing.Point(0, 80)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Padding = New System.Windows.Forms.Padding(15, 8, 15, 8)
        Me.pnlStats.Size = New System.Drawing.Size(1184, 100)
        Me.pnlStats.TabIndex = 1
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.lblCountRoutes)
        Me.grpStats.Controls.Add(Me.lblTitleRoutes)
        Me.grpStats.Controls.Add(Me.lblCountExpired)
        Me.grpStats.Controls.Add(Me.lblTitleExpired)
        Me.grpStats.Controls.Add(Me.lblCountActive)
        Me.grpStats.Controls.Add(Me.lblTitleActive)
        Me.grpStats.Controls.Add(Me.lblCountTotal)
        Me.grpStats.Controls.Add(Me.lblTitleTotal)
        Me.grpStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStats.ForeColor = System.Drawing.Color.Navy
        Me.grpStats.Location = New System.Drawing.Point(15, 8)
        Me.grpStats.Name = "grpStats"
        Me.grpStats.Size = New System.Drawing.Size(1154, 84)
        Me.grpStats.TabIndex = 0
        Me.grpStats.TabStop = False
        Me.grpStats.Text = " System Summary Statistics "
        '
        'lblCountRoutes
        '
        Me.lblCountRoutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountRoutes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblCountRoutes.Location = New System.Drawing.Point(880, 45)
        Me.lblCountRoutes.Name = "lblCountRoutes"
        Me.lblCountRoutes.Size = New System.Drawing.Size(220, 30)
        Me.lblCountRoutes.TabIndex = 7
        Me.lblCountRoutes.Text = "0"
        Me.lblCountRoutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitleRoutes
        '
        Me.lblTitleRoutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleRoutes.ForeColor = System.Drawing.Color.Black
        Me.lblTitleRoutes.Location = New System.Drawing.Point(880, 22)
        Me.lblTitleRoutes.Name = "lblTitleRoutes"
        Me.lblTitleRoutes.Size = New System.Drawing.Size(220, 20)
        Me.lblTitleRoutes.TabIndex = 6
        Me.lblTitleRoutes.Text = "Total Bus Routes:"
        Me.lblTitleRoutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCountExpired
        '
        Me.lblCountExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountExpired.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCountExpired.Location = New System.Drawing.Point(600, 45)
        Me.lblCountExpired.Name = "lblCountExpired"
        Me.lblCountExpired.Size = New System.Drawing.Size(220, 30)
        Me.lblCountExpired.TabIndex = 5
        Me.lblCountExpired.Text = "0"
        Me.lblCountExpired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitleExpired
        '
        Me.lblTitleExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleExpired.ForeColor = System.Drawing.Color.Black
        Me.lblTitleExpired.Location = New System.Drawing.Point(600, 22)
        Me.lblTitleExpired.Name = "lblTitleExpired"
        Me.lblTitleExpired.Size = New System.Drawing.Size(220, 20)
        Me.lblTitleExpired.TabIndex = 4
        Me.lblTitleExpired.Text = "Expired Passes:"
        Me.lblTitleExpired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCountActive
        '
        Me.lblCountActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountActive.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblCountActive.Location = New System.Drawing.Point(320, 45)
        Me.lblCountActive.Name = "lblCountActive"
        Me.lblCountActive.Size = New System.Drawing.Size(220, 30)
        Me.lblCountActive.TabIndex = 3
        Me.lblCountActive.Text = "0"
        Me.lblCountActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitleActive
        '
        Me.lblTitleActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleActive.ForeColor = System.Drawing.Color.Black
        Me.lblTitleActive.Location = New System.Drawing.Point(320, 22)
        Me.lblTitleActive.Name = "lblTitleActive"
        Me.lblTitleActive.Size = New System.Drawing.Size(220, 20)
        Me.lblTitleActive.TabIndex = 2
        Me.lblTitleActive.Text = "Active Passes:"
        Me.lblTitleActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCountTotal
        '
        Me.lblCountTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountTotal.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCountTotal.Location = New System.Drawing.Point(40, 45)
        Me.lblCountTotal.Name = "lblCountTotal"
        Me.lblCountTotal.Size = New System.Drawing.Size(220, 30)
        Me.lblCountTotal.TabIndex = 1
        Me.lblCountTotal.Text = "0"
        Me.lblCountTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitleTotal
        '
        Me.lblTitleTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTitleTotal.Location = New System.Drawing.Point(40, 22)
        Me.lblTitleTotal.Name = "lblTitleTotal"
        Me.lblTitleTotal.Size = New System.Drawing.Size(220, 20)
        Me.lblTitleTotal.TabIndex = 0
        Me.lblTitleTotal.Text = "Total Passes Issued:"
        Me.lblTitleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.SystemColors.Control
        Me.pnlNav.Controls.Add(Me.grpMenu)
        Me.pnlNav.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlNav.Location = New System.Drawing.Point(0, 180)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Padding = New System.Windows.Forms.Padding(15, 10, 10, 15)
        Me.pnlNav.Size = New System.Drawing.Size(280, 520)
        Me.pnlNav.TabIndex = 2
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.btnLogout)
        Me.grpMenu.Controls.Add(Me.btnChangePassword)
        Me.grpMenu.Controls.Add(Me.btnPrintPass)
        Me.grpMenu.Controls.Add(Me.btnManageRoutes)
        Me.grpMenu.Controls.Add(Me.btnManagePasses)
        Me.grpMenu.Controls.Add(Me.btnNewPass)
        Me.grpMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMenu.ForeColor = System.Drawing.Color.Navy
        Me.grpMenu.Location = New System.Drawing.Point(15, 10)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(255, 495)
        Me.grpMenu.TabIndex = 0
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = " Navigation Menu "
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.DarkRed
        Me.btnLogout.Location = New System.Drawing.Point(15, 415)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(225, 52)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.Black
        Me.btnChangePassword.Location = New System.Drawing.Point(15, 340)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(225, 52)
        Me.btnChangePassword.TabIndex = 4
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnPrintPass
        '
        Me.btnPrintPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPass.ForeColor = System.Drawing.Color.Black
        Me.btnPrintPass.Location = New System.Drawing.Point(15, 265)
        Me.btnPrintPass.Name = "btnPrintPass"
        Me.btnPrintPass.Size = New System.Drawing.Size(225, 52)
        Me.btnPrintPass.TabIndex = 3
        Me.btnPrintPass.Text = "Print / View Pass"
        Me.btnPrintPass.UseVisualStyleBackColor = True
        '
        'btnManageRoutes
        '
        Me.btnManageRoutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageRoutes.ForeColor = System.Drawing.Color.Black
        Me.btnManageRoutes.Location = New System.Drawing.Point(15, 190)
        Me.btnManageRoutes.Name = "btnManageRoutes"
        Me.btnManageRoutes.Size = New System.Drawing.Size(225, 52)
        Me.btnManageRoutes.TabIndex = 2
        Me.btnManageRoutes.Text = "Bus Routes && Fares"
        Me.btnManageRoutes.UseVisualStyleBackColor = True
        '
        'btnManagePasses
        '
        Me.btnManagePasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagePasses.ForeColor = System.Drawing.Color.Black
        Me.btnManagePasses.Location = New System.Drawing.Point(15, 115)
        Me.btnManagePasses.Name = "btnManagePasses"
        Me.btnManagePasses.Size = New System.Drawing.Size(225, 52)
        Me.btnManagePasses.TabIndex = 1
        Me.btnManagePasses.Text = "Manage && Renew"
        Me.btnManagePasses.UseVisualStyleBackColor = True
        '
        'btnNewPass
        '
        Me.btnNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewPass.ForeColor = System.Drawing.Color.Navy
        Me.btnNewPass.Location = New System.Drawing.Point(15, 40)
        Me.btnNewPass.Name = "btnNewPass"
        Me.btnNewPass.Size = New System.Drawing.Size(225, 52)
        Me.btnNewPass.TabIndex = 0
        Me.btnNewPass.Text = "+ Issue New Pass"
        Me.btnNewPass.UseVisualStyleBackColor = True
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.SystemColors.Control
        Me.pnlContent.Controls.Add(Me.dgvRecentPasses)
        Me.pnlContent.Controls.Add(Me.pnlTableTop)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(280, 180)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(10, 10, 15, 15)
        Me.pnlContent.Size = New System.Drawing.Size(904, 520)
        Me.pnlContent.TabIndex = 3
        '
        'dgvRecentPasses
        '
        Me.dgvRecentPasses.AllowUserToAddRows = False
        Me.dgvRecentPasses.AllowUserToDeleteRows = False
        Me.dgvRecentPasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecentPasses.BackgroundColor = System.Drawing.Color.White
        Me.dgvRecentPasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecentPasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        Me.dgvRecentPasses.ColumnHeadersHeight = 35
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecentPasses.DefaultCellStyle = dataGridViewCellStyle2
        Me.dgvRecentPasses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecentPasses.Location = New System.Drawing.Point(10, 52)
        Me.dgvRecentPasses.MultiSelect = False
        Me.dgvRecentPasses.Name = "dgvRecentPasses"
        Me.dgvRecentPasses.ReadOnly = True
        Me.dgvRecentPasses.RowHeadersVisible = False
        Me.dgvRecentPasses.RowTemplate.Height = 30
        Me.dgvRecentPasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecentPasses.Size = New System.Drawing.Size(879, 453)
        Me.dgvRecentPasses.TabIndex = 1
        '
        'pnlTableTop
        '
        Me.pnlTableTop.Controls.Add(Me.btnRefreshDashboard)
        Me.pnlTableTop.Controls.Add(Me.lblTableTitle)
        Me.pnlTableTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTableTop.Location = New System.Drawing.Point(10, 10)
        Me.pnlTableTop.Name = "pnlTableTop"
        Me.pnlTableTop.Size = New System.Drawing.Size(879, 42)
        Me.pnlTableTop.TabIndex = 0
        '
        'btnRefreshDashboard
        '
        Me.btnRefreshDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshDashboard.Location = New System.Drawing.Point(729, 3)
        Me.btnRefreshDashboard.Name = "btnRefreshDashboard"
        Me.btnRefreshDashboard.Size = New System.Drawing.Size(150, 34)
        Me.btnRefreshDashboard.TabIndex = 1
        Me.btnRefreshDashboard.Text = "Refresh Table"
        Me.btnRefreshDashboard.UseVisualStyleBackColor = True
        '
        'lblTableTitle
        '
        Me.lblTableTitle.AutoSize = True
        Me.lblTableTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableTitle.ForeColor = System.Drawing.Color.Navy
        Me.lblTableTitle.Location = New System.Drawing.Point(3, 8)
        Me.lblTableTitle.Name = "lblTableTitle"
        Me.lblTableTitle.Size = New System.Drawing.Size(207, 22)
        Me.lblTableTitle.TabIndex = 0
        Me.lblTableTitle.Text = "Recent Issued Passes"
        '
        'MainDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1184, 700)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlNav)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainDashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bus Pass Management System - Admin Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlStats.ResumeLayout(False)
        Me.grpStats.ResumeLayout(False)
        Me.pnlNav.ResumeLayout(False)
        Me.grpMenu.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        CType(Me.dgvRecentPasses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTableTop.ResumeLayout(False)
        Me.pnlTableTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblCurrentDate As System.Windows.Forms.Label
    Friend WithEvents pnlStats As System.Windows.Forms.Panel
    Friend WithEvents grpStats As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitleTotal As System.Windows.Forms.Label
    Friend WithEvents lblCountTotal As System.Windows.Forms.Label
    Friend WithEvents lblTitleActive As System.Windows.Forms.Label
    Friend WithEvents lblCountActive As System.Windows.Forms.Label
    Friend WithEvents lblTitleExpired As System.Windows.Forms.Label
    Friend WithEvents lblCountExpired As System.Windows.Forms.Label
    Friend WithEvents lblTitleRoutes As System.Windows.Forms.Label
    Friend WithEvents lblCountRoutes As System.Windows.Forms.Label
    Friend WithEvents pnlNav As System.Windows.Forms.Panel
    Friend WithEvents grpMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnNewPass As System.Windows.Forms.Button
    Friend WithEvents btnManagePasses As System.Windows.Forms.Button
    Friend WithEvents btnManageRoutes As System.Windows.Forms.Button
    Friend WithEvents btnPrintPass As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlTableTop As System.Windows.Forms.Panel
    Friend WithEvents lblTableTitle As System.Windows.Forms.Label
    Friend WithEvents btnRefreshDashboard As System.Windows.Forms.Button
    Friend WithEvents dgvRecentPasses As System.Windows.Forms.DataGridView

End Class
