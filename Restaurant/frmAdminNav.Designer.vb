<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminNav
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
        Me.lblAdminName = New System.Windows.Forms.Label()
        Me.btnManageEmployee = New System.Windows.Forms.Button()
        Me.btnManageMenu = New System.Windows.Forms.Button()
        Me.btnManageMember = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(72, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Navigation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(27, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Welcome, "
        '
        'lblAdminName
        '
        Me.lblAdminName.AutoSize = True
        Me.lblAdminName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAdminName.Location = New System.Drawing.Point(93, 72)
        Me.lblAdminName.Name = "lblAdminName"
        Me.lblAdminName.Size = New System.Drawing.Size(96, 17)
        Me.lblAdminName.TabIndex = 2
        Me.lblAdminName.Text = "[Admin Name]"
        '
        'btnManageEmployee
        '
        Me.btnManageEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnManageEmployee.Location = New System.Drawing.Point(103, 114)
        Me.btnManageEmployee.Name = "btnManageEmployee"
        Me.btnManageEmployee.Size = New System.Drawing.Size(160, 34)
        Me.btnManageEmployee.TabIndex = 3
        Me.btnManageEmployee.Text = "Manage Employee"
        Me.btnManageEmployee.UseVisualStyleBackColor = True
        '
        'btnManageMenu
        '
        Me.btnManageMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnManageMenu.Location = New System.Drawing.Point(103, 154)
        Me.btnManageMenu.Name = "btnManageMenu"
        Me.btnManageMenu.Size = New System.Drawing.Size(160, 34)
        Me.btnManageMenu.TabIndex = 4
        Me.btnManageMenu.Text = "Manage Menu"
        Me.btnManageMenu.UseVisualStyleBackColor = True
        '
        'btnManageMember
        '
        Me.btnManageMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnManageMember.Location = New System.Drawing.Point(103, 194)
        Me.btnManageMember.Name = "btnManageMember"
        Me.btnManageMember.Size = New System.Drawing.Size(160, 34)
        Me.btnManageMember.TabIndex = 5
        Me.btnManageMember.Text = "Manage Member"
        Me.btnManageMember.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnChangePassword.Location = New System.Drawing.Point(103, 234)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(160, 34)
        Me.btnChangePassword.TabIndex = 6
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnLogout.Location = New System.Drawing.Point(103, 274)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(160, 34)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'frmAdminNav
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 337)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnManageMember)
        Me.Controls.Add(Me.btnManageMenu)
        Me.Controls.Add(Me.btnManageEmployee)
        Me.Controls.Add(Me.lblAdminName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAdminNav"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome Admin!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAdminName As Label
    Friend WithEvents btnManageEmployee As Button
    Friend WithEvents btnManageMenu As Button
    Friend WithEvents btnManageMember As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnLogout As Button
End Class
