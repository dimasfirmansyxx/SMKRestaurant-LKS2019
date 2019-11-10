<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cmbId = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.cmbBank = New System.Windows.Forms.ComboBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.menu, Me.price, Me.qty, Me.total})
        Me.dgv.Location = New System.Drawing.Point(30, 119)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(464, 222)
        Me.dgv.TabIndex = 7
        '
        'cmbId
        '
        Me.cmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbId.FormattingEnabled = True
        Me.cmbId.Location = New System.Drawing.Point(226, 81)
        Me.cmbId.Name = "cmbId"
        Me.cmbId.Size = New System.Drawing.Size(148, 21)
        Me.cmbId.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(158, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Order ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(155, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Form View Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total :"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(406, 349)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(145, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Payment Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Card Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(145, 426)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Bank Name"
        '
        'cmbPayment
        '
        Me.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayment.Enabled = False
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Items.AddRange(New Object() {"Credit Card", "Debit Card"})
        Me.cmbPayment.Location = New System.Drawing.Point(226, 371)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(148, 21)
        Me.cmbPayment.TabIndex = 13
        '
        'cmbBank
        '
        Me.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBank.Enabled = False
        Me.cmbBank.FormattingEnabled = True
        Me.cmbBank.Items.AddRange(New Object() {"BNI", "BCA", "Mandiri"})
        Me.cmbBank.Location = New System.Drawing.Point(226, 423)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(148, 21)
        Me.cmbBank.TabIndex = 14
        '
        'txtNumber
        '
        Me.txtNumber.Enabled = False
        Me.txtNumber.Location = New System.Drawing.Point(226, 397)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(148, 20)
        Me.txtNumber.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(299, 450)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.menu.HeaderText = "Menu"
        Me.menu.Name = "menu"
        Me.menu.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 483)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.cmbBank)
        Me.Controls.Add(Me.cmbPayment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cmbId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents cmbId As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbPayment As ComboBox
    Friend WithEvents cmbBank As ComboBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents menu As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
