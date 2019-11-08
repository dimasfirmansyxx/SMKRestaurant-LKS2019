<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageMember
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.id_member = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.joindate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(286, 449)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(76, 32)
        Me.btnUpdate.TabIndex = 44
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(374, 449)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(76, 32)
        Me.btnDelete.TabIndex = 43
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(195, 449)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(76, 32)
        Me.btnInsert.TabIndex = 42
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(266, 393)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(184, 20)
        Me.txtemail.TabIndex = 40
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(266, 364)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(184, 20)
        Me.txtname.TabIndex = 39
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(266, 337)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(184, 20)
        Me.txtid.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Member ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Name"
        '
        'dgvdata
        '
        Me.dgvdata.AllowUserToAddRows = False
        Me.dgvdata.AllowUserToDeleteRows = False
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_member, Me.name, Me.email, Me.joindate})
        Me.dgvdata.Location = New System.Drawing.Point(12, 57)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.ReadOnly = True
        Me.dgvdata.Size = New System.Drawing.Size(648, 266)
        Me.dgvdata.TabIndex = 33
        '
        'id_member
        '
        Me.id_member.HeaderText = "Member ID"
        Me.id_member.Name = "id_member"
        Me.id_member.ReadOnly = True
        '
        'name
        '
        Me.name.HeaderText = "Name"
        Me.name.Name = "name"
        Me.name.ReadOnly = True
        Me.name.Width = 200
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'joindate
        '
        Me.joindate.HeaderText = "Join Date"
        Me.joindate.Name = "joindate"
        Me.joindate.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(206, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 31)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Form Manage Member"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(266, 422)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(184, 20)
        Me.txtpassword.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Password"
        '
        'frmManageMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 490)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.Label1)
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Member"
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvdata As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents id_member As DataGridViewTextBoxColumn
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents joindate As DataGridViewTextBoxColumn
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label5 As Label
End Class
