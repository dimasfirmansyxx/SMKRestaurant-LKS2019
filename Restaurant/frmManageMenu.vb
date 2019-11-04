Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Public Class frmManageMenu
    Function newMenuId()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblmenu ORDER BY id_menu DESC", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                Return CStr(CInt(reader.Item("id_menu")) + 1)
            Else
                Return 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            conn.Close()
        End Try
    End Function

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txtname.Text = "" Or txtname.Text = " " Or IsNothing(txtname.Text) Then
            MessageBox.Show("Isikan nama terlebih dahulu")
        ElseIf txtprice.Text = "" Or txtprice.Text = " " Or IsNothing(txtprice.Text) Then
            MessageBox.Show("Isikan harga terlebih dahulu")
        ElseIf IsNumeric(txtprice.Text) = False Then
            MessageBox.Show("Isikan harga hanya dengan angka")
        Else
            Dim id, name, price As String
            id = txtid.Text
            name = txtname.Text
            price = txtprice.Text
            Try
                conn.Open()
                Dim ms As New MemoryStream
                boxPicture.Image.Save(ms, boxPicture.Image.RawFormat)
                cmd = New SqlCommand("INSERT INTO tblmenu(id_menu,name,price,photo) VALUES (@id,@name,@price,@photo)", conn)
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name
                cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = price
                cmd.Parameters.Add("@photo", SqlDbType.Image).Value = ms.ToArray

                If cmd.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Sukses")
                Else
                    MessageBox.Show("Gagal")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png;*.jpg;*.jpeg;*.bmp;*.gif")
                .FilterIndex = 4
            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                boxPicture.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
                boxPicture.BackgroundImageLayout = ImageLayout.Zoom
                txtphoto.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub frmManageMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        txtid.Text = newMenuId()
    End Sub
End Class