<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewOrder
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbId = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.id_detail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(105, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form View Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(108, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order ID"
        '
        'cmbId
        '
        Me.cmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbId.FormattingEnabled = True
        Me.cmbId.Location = New System.Drawing.Point(176, 59)
        Me.cmbId.Name = "cmbId"
        Me.cmbId.Size = New System.Drawing.Size(148, 21)
        Me.cmbId.TabIndex = 2
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_detail, Me.menu, Me.qty})
        Me.dgv.Location = New System.Drawing.Point(12, 97)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(409, 222)
        Me.dgv.TabIndex = 3
        '
        'id_detail
        '
        Me.id_detail.HeaderText = "id"
        Me.id_detail.Name = "id_detail"
        Me.id_detail.ReadOnly = True
        Me.id_detail.Visible = False
        '
        'menu
        '
        Me.menu.HeaderText = "Menu"
        Me.menu.Name = "menu"
        Me.menu.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'frmViewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 331)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cmbId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmViewOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Order"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbId As ComboBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents id_detail As DataGridViewTextBoxColumn
    Friend WithEvents menu As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
End Class
