<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintMemberCard
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgMemberList = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.member_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.member_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.member_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valid_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expire_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.print_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.print_count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TimerPrintJob = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgMemberList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(109, 12)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(262, 26)
        Me.txtBarcode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Member No"
        '
        'dgMemberList
        '
        Me.dgMemberList.AllowUserToAddRows = False
        Me.dgMemberList.AllowUserToDeleteRows = False
        Me.dgMemberList.AllowUserToResizeColumns = False
        Me.dgMemberList.AllowUserToResizeRows = False
        Me.dgMemberList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMemberList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.member_no, Me.member_name, Me.member_type, Me.valid_date, Me.expire_date, Me.print_status, Me.print_count, Me.btnPrint})
        Me.dgMemberList.Location = New System.Drawing.Point(12, 53)
        Me.dgMemberList.Name = "dgMemberList"
        Me.dgMemberList.RowHeadersVisible = False
        Me.dgMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMemberList.Size = New System.Drawing.Size(877, 533)
        Me.dgMemberList.TabIndex = 2
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'member_no
        '
        Me.member_no.DataPropertyName = "member_no"
        Me.member_no.HeaderText = "Member No"
        Me.member_no.Name = "member_no"
        Me.member_no.ReadOnly = True
        '
        'member_name
        '
        Me.member_name.DataPropertyName = "member_name"
        Me.member_name.HeaderText = "Name"
        Me.member_name.Name = "member_name"
        Me.member_name.ReadOnly = True
        Me.member_name.Width = 200
        '
        'member_type
        '
        Me.member_type.DataPropertyName = "member_type"
        Me.member_type.HeaderText = "Type"
        Me.member_type.Name = "member_type"
        Me.member_type.ReadOnly = True
        Me.member_type.Width = 150
        '
        'valid_date
        '
        Me.valid_date.DataPropertyName = "valid_date"
        DataGridViewCellStyle1.Format = "D"
        Me.valid_date.DefaultCellStyle = DataGridViewCellStyle1
        Me.valid_date.HeaderText = "Valid Date"
        Me.valid_date.Name = "valid_date"
        Me.valid_date.ReadOnly = True
        '
        'expire_date
        '
        Me.expire_date.DataPropertyName = "expire_date"
        DataGridViewCellStyle2.Format = "D"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.expire_date.DefaultCellStyle = DataGridViewCellStyle2
        Me.expire_date.HeaderText = "Expire Date"
        Me.expire_date.Name = "expire_date"
        Me.expire_date.ReadOnly = True
        '
        'print_status
        '
        Me.print_status.DataPropertyName = "print_status"
        Me.print_status.HeaderText = "Print Status"
        Me.print_status.Name = "print_status"
        Me.print_status.ReadOnly = True
        Me.print_status.Width = 120
        '
        'print_count
        '
        Me.print_count.DataPropertyName = "print_count"
        Me.print_count.HeaderText = "print_count"
        Me.print_count.Name = "print_count"
        Me.print_count.ReadOnly = True
        Me.print_count.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.HeaderText = "#"
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Width = 80
        '
        'PrintDocument1
        '
        '
        'TimerPrintJob
        '
        Me.TimerPrintJob.Enabled = True
        Me.TimerPrintJob.Interval = 2000
        '
        'frmPrintMemberCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 598)
        Me.Controls.Add(Me.dgMemberList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBarcode)
        Me.Name = "frmPrintMemberCard"
        Me.Text = "Print Member Card"
        CType(Me.dgMemberList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgMemberList As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents member_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents member_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents member_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valid_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents expire_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents print_status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents print_count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TimerPrintJob As System.Windows.Forms.Timer

End Class
