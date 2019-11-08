Public Class frmAdminNav
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New frmLogin
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim changePassw As New frmChangePassword
        changePassw.Show()
    End Sub

    Private Sub btnManageEmployee_Click(sender As Object, e As EventArgs) Handles btnManageEmployee.Click
        Dim mngEmployee As New frmManageEmployee
        mngEmployee.Show()
    End Sub

    Private Sub btnManageMenu_Click(sender As Object, e As EventArgs) Handles btnManageMenu.Click
        Dim mngMenu As New frmManageMenu
        mngMenu.Show()
    End Sub

    Private Sub btnManageMember_Click(sender As Object, e As EventArgs) Handles btnManageMember.Click
        Dim mngMember As New frmManageMember
        mngMember.Show()
    End Sub
End Class