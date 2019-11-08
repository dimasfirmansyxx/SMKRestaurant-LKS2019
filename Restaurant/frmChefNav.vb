Public Class frmChefNav
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New frmLogin
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim changePassw As New frmChangePassword
        changePassw.Show()
    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        Dim vieworder As New frmViewOrder
        vieworder.Show()
    End Sub
End Class