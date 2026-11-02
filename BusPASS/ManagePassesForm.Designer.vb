<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagePassesForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmbStatusFilter = New System.Windows.Forms.ComboBox()
        Me.lblStatusFilter = New System.Windows.Forms.Label()
        Me.txtSearchKeyword = New System.Windows.Forms.TextBox()
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.dgvPasses = New System.Windows.Forms.DataGridView()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.grpRenew = New System.Windows.Forms.GroupBox()
        Me.lblSelectedPassInfo = New System.Windows.Forms.Label()
        Me.btnRenew = New System.Windows.Forms.Button()
        Me.cmbRenewMonths = New System.Windows.Forms.ComboBox()
        Me.lblRenewMonths = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancelPass = New System.Windows.Forms.Button()
        Me.btnPrintPass = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvPasses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.grpRenew.SuspendLayout()
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
        Me.lblTitle.Text = "Manage && Renew Bus Passes"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.SystemColors.Control
        Me.pnlSearch.Controls.Add(Me.btnRefresh)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.cmbStatusFilter)
        Me.pnlSearch.Controls.Add(Me.lblStatusFilter)
        Me.pnlSearch.Controls.Add(Me.txtSearchKeyword)
        Me.pnlSearch.Controls.Add(Me.cmbSearchBy)
        Me.pnlSearch.Controls.Add(Me.lblSearchBy)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 60)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlSearch.Size = New System.Drawing.Size(1184, 55)
        Me.pnlSearch.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(990, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(130, 34)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Show All"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(860, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 34)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmbStatusFilter
        '
        Me.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatusFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatusFilter.FormattingEnabled = True
        Me.cmbStatusFilter.Items.AddRange(New Object() {"All Statuses", "Active", "Expired", "Cancelled"})
        Me.cmbStatusFilter.Location = New System.Drawing.Point(700, 14)
        Me.cmbStatusFilter.Name = "cmbStatusFilter"
        Me.cmbStatusFilter.Size = New System.Drawing.Size(145, 26)
        Me.cmbStatusFilter.TabIndex = 4
        '
        'lblStatusFilter
        '
        Me.lblStatusFilter.AutoSize = True
        Me.lblStatusFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusFilter.Location = New System.Drawing.Point(635, 17)
        Me.lblStatusFilter.Name = "lblStatusFilter"
        Me.lblStatusFilter.Size = New System.Drawing.Size(61, 18)
        Me.lblStatusFilter.TabIndex = 3
        Me.lblStatusFilter.Text = "Status:"
        '
        'txtSearchKeyword
        '
        Me.txtSearchKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchKeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchKeyword.Location = New System.Drawing.Point(310, 14)
        Me.txtSearchKeyword.Name = "txtSearchKeyword"
        Me.txtSearchKeyword.Size = New System.Drawing.Size(305, 24)
        Me.txtSearchKeyword.TabIndex = 2
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.Items.AddRange(New Object() {"All", "Pass Number", "Passenger Name", "Contact Number", "Pass Category", "Route Stops"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(115, 14)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(180, 26)
        Me.cmbSearchBy.TabIndex = 1
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.Location = New System.Drawing.Point(18, 17)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(91, 18)
        Me.lblSearchBy.TabIndex = 0
        Me.lblSearchBy.Text = "Search By:"
        '
        'dgvPasses
        '
        Me.dgvPasses.AllowUserToAddRows = False
        Me.dgvPasses.AllowUserToDeleteRows = False
        Me.dgvPasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPasses.BackgroundColor = System.Drawing.Color.White
        Me.dgvPasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        Me.dgvPasses.ColumnHeadersHeight = 35
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPasses.DefaultCellStyle = dataGridViewCellStyle2
        Me.dgvPasses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPasses.Location = New System.Drawing.Point(0, 115)
        Me.dgvPasses.MultiSelect = False
        Me.dgvPasses.Name = "dgvPasses"
        Me.dgvPasses.ReadOnly = True
        Me.dgvPasses.RowHeadersVisible = False
        Me.dgvPasses.RowTemplate.Height = 30
        Me.dgvPasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPasses.Size = New System.Drawing.Size(1184, 435)
        Me.dgvPasses.TabIndex = 2
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBottom.Controls.Add(Me.grpRenew)
        Me.pnlBottom.Controls.Add(Me.btnClose)
        Me.pnlBottom.Controls.Add(Me.btnDelete)
        Me.pnlBottom.Controls.Add(Me.btnCancelPass)
        Me.pnlBottom.Controls.Add(Me.btnPrintPass)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 550)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlBottom.Size = New System.Drawing.Size(1184, 150)
        Me.pnlBottom.TabIndex = 3
        '
        'grpRenew
        '
        Me.grpRenew.Controls.Add(Me.lblSelectedPassInfo)
        Me.grpRenew.Controls.Add(Me.btnRenew)
        Me.grpRenew.Controls.Add(Me.cmbRenewMonths)
        Me.grpRenew.Controls.Add(Me.lblRenewMonths)
        Me.grpRenew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRenew.ForeColor = System.Drawing.Color.Navy
        Me.grpRenew.Location = New System.Drawing.Point(12, 10)
        Me.grpRenew.Name = "grpRenew"
        Me.grpRenew.Size = New System.Drawing.Size(680, 125)
        Me.grpRenew.TabIndex = 0
        Me.grpRenew.TabStop = False
        Me.grpRenew.Text = " Renew Selected Pass "
        '
        'lblSelectedPassInfo
        '
        Me.lblSelectedPassInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedPassInfo.ForeColor = System.Drawing.Color.Black
        Me.lblSelectedPassInfo.Location = New System.Drawing.Point(15, 28)
        Me.lblSelectedPassInfo.Name = "lblSelectedPassInfo"
        Me.lblSelectedPassInfo.Size = New System.Drawing.Size(650, 28)
        Me.lblSelectedPassInfo.TabIndex = 0
        Me.lblSelectedPassInfo.Text = "Select a pass from the table above."
        '
        'btnRenew
        '
        Me.btnRenew.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRenew.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnRenew.Location = New System.Drawing.Point(420, 68)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(220, 42)
        Me.btnRenew.TabIndex = 3
        Me.btnRenew.Text = "Confirm Renewal"
        Me.btnRenew.UseVisualStyleBackColor = True
        '
        'cmbRenewMonths
        '
        Me.cmbRenewMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRenewMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRenewMonths.FormattingEnabled = True
        Me.cmbRenewMonths.Items.AddRange(New Object() {"1 Month", "3 Months", "6 Months", "1 Year"})
        Me.cmbRenewMonths.Location = New System.Drawing.Point(175, 75)
        Me.cmbRenewMonths.Name = "cmbRenewMonths"
        Me.cmbRenewMonths.Size = New System.Drawing.Size(220, 26)
        Me.cmbRenewMonths.TabIndex = 2
        '
        'lblRenewMonths
        '
        Me.lblRenewMonths.AutoSize = True
        Me.lblRenewMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenewMonths.ForeColor = System.Drawing.Color.Black
        Me.lblRenewMonths.Location = New System.Drawing.Point(15, 78)
        Me.lblRenewMonths.Name = "lblRenewMonths"
        Me.lblRenewMonths.Size = New System.Drawing.Size(127, 18)
        Me.lblRenewMonths.TabIndex = 1
        Me.lblRenewMonths.Text = "Extend Validity By:"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(950, 80)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(200, 46)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.DarkRed
        Me.btnDelete.Location = New System.Drawing.Point(725, 80)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(200, 46)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete Pass"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancelPass
        '
        Me.btnCancelPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPass.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCancelPass.Location = New System.Drawing.Point(950, 20)
        Me.btnCancelPass.Name = "btnCancelPass"
        Me.btnCancelPass.Size = New System.Drawing.Size(200, 46)
        Me.btnCancelPass.TabIndex = 2
        Me.btnCancelPass.Text = "Cancel Pass"
        Me.btnCancelPass.UseVisualStyleBackColor = True
        '
        'btnPrintPass
        '
        Me.btnPrintPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPass.ForeColor = System.Drawing.Color.Navy
        Me.btnPrintPass.Location = New System.Drawing.Point(725, 20)
        Me.btnPrintPass.Name = "btnPrintPass"
        Me.btnPrintPass.Size = New System.Drawing.Size(200, 46)
        Me.btnPrintPass.TabIndex = 1
        Me.btnPrintPass.Text = "View / Print Pass"
        Me.btnPrintPass.UseVisualStyleBackColor = True
        '
        'ManagePassesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1184, 700)
        Me.Controls.Add(Me.dgvPasses)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ManagePassesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bus Pass Management - Manage and Renew Passes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.dgvPasses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.grpRenew.ResumeLayout(False)
        Me.grpRenew.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents lblSearchBy As System.Windows.Forms.Label
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearchKeyword As System.Windows.Forms.TextBox
    Friend WithEvents lblStatusFilter As System.Windows.Forms.Label
    Friend WithEvents cmbStatusFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvPasses As System.Windows.Forms.DataGridView
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents grpRenew As System.Windows.Forms.GroupBox
    Friend WithEvents lblSelectedPassInfo As System.Windows.Forms.Label
    Friend WithEvents lblRenewMonths As System.Windows.Forms.Label
    Friend WithEvents cmbRenewMonths As System.Windows.Forms.ComboBox
    Friend WithEvents btnRenew As System.Windows.Forms.Button
    Friend WithEvents btnPrintPass As System.Windows.Forms.Button
    Friend WithEvents btnCancelPass As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
