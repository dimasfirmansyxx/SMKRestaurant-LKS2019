Public Class frmManageMenu
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            boxPicture.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            boxPicture.BackgroundImageLayout = ImageLayout.Zoom
        End If
    End Sub
End Class