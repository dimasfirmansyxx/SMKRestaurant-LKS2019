<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.id_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxPicture = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.dgvorder = New System.Windows.Forms.DataGridView()
        Me.id_order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMenu
        '
        Me.dgvMenu.AllowUserToAddRows = False
        Me.dgvMenu.AllowUserToDeleteRows = False
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_menu, Me.name, Me.price})
        Me.dgvMenu.Location = New System.Drawing.Point(12, 12)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.ReadOnly = True
        Me.dgvMenu.Size = New System.Drawing.Size(522, 189)
        Me.dgvMenu.TabIndex = 0
        '
        'id_menu
        '
        Me.id_menu.HeaderText = "id"
        Me.id_menu.Name = "id_menu"
        Me.id_menu.ReadOnly = True
        Me.id_menu.Visible = False
        '
        'name
        '
        Me.name.HeaderText = "Menu"
        Me.name.Name = "name"
        Me.name.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'boxPicture
        '
        Me.boxPicture.Location = New System.Drawing.Point(12, 208)
        Me.boxPicture.Name = "boxPicture"
        Me.boxPicture.Size = New System.Drawing.Size(120, 120)
        Me.boxPicture.TabIndex = 1
        Me.boxPicture.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(157, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Menu Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(157, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Qty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(157, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Price"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(247, 217)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 20)
        Me.txtName.TabIndex = 5
        '
        'txtQty
        '
        Me.txtQty.Enabled = False
        Me.txtQty.Location = New System.Drawing.Point(247, 247)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(192, 20)
        Me.txtQty.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(247, 277)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(192, 20)
        Me.txtPrice.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(283, 303)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.Location = New System.Drawing.Point(364, 303)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'dgvorder
        '
        Me.dgvorder.AllowUserToAddRows = False
        Me.dgvorder.AllowUserToDeleteRows = False
        Me.dgvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvorder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_order, Me.menu, Me.price_menu, Me.qty, Me.total})
        Me.dgvorder.Location = New System.Drawing.Point(12, 334)
        Me.dgvorder.Name = "dgvorder"
        Me.dgvorder.ReadOnly = True
        Me.dgvorder.Size = New System.Drawing.Size(522, 167)
        Me.dgvorder.TabIndex = 10
        '
        'id_order
        '
        Me.id_order.HeaderText = "id"
        Me.id_order.Name = "id_order"
        Me.id_order.ReadOnly = True
        Me.id_order.Visible = False
        '
        'menu
        '
        Me.menu.HeaderText = "Menu"
        Me.menu.Name = "menu"
        Me.menu.ReadOnly = True
        '
        'price_menu
        '
        Me.price_menu.HeaderText = "Price"
        Me.price_menu.Name = "price_menu"
        Me.price_menu.ReadOnly = True
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
        'btnOrder
        '
        Me.btnOrder.Enabled = False
        Me.btnOrder.Location = New System.Drawing.Point(210, 508)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(121, 38)
        Me.btnOrder.TabIndex = 12
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(372, 508)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Total : Rp."
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(441, 508)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(16, 17)
        Me.lbltotal.TabIndex = 14
        Me.lbltotal.Text = "0"
        '
        'frmOrder
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 554)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.dgvorder)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.boxPicture)
        Me.Controls.Add(Me.dgvMenu)
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order"
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents id_menu As DataGridViewTextBoxColumn
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents boxPicture As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents dgvorder As DataGridView
    Friend WithEvents id_order As DataGridViewTextBoxColumn
    Friend WithEvents menu As DataGridViewTextBoxColumn
    Friend WithEvents price_menu As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents btnOrder As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbltotal As Label
End Class
