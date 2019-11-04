Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Public Class frmManageMenu

    Dim dgvselected As Integer

    Sub loadData()
        dgvdata.Rows.Clear()

        Try
        conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblmenu", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim newrow As Integer = dgvdata.Rows.Add
                dgvdata.Rows(newrow).Cells(0).Value = reader.Item("id_menu")
                dgvdata.Rows(newrow).Cells(1).Value = reader.Item("name")
                dgvdata.Rows(newrow).Cells(2).Value = reader.Item("price")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

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
                Dim img As Byte()
                Dim fs As New FileStream(txtphoto.Text, FileMode.Open, FileAccess.Read)
                Dim br As New BinaryReader(fs)
                img = br.ReadBytes(CInt(fs.Length))

                cmd = New SqlCommand("SET IDENTITY_INSERT tblmenu ON 
                                        INSERT INTO tblmenu (id_menu,name,price,photo) VALUES ('" & id & "','" & name & "','" & price & "',@image)", conn)
                cmd.Parameters.Add("@image", img)
                Dim insert = cmd.ExecuteNonQuery

                If insert > 0 Then
                    MessageBox.Show("Sukses")
                    cmd.Parameters.Clear()
                Else
                    MessageBox.Show("Gagal")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                conn.Close()
            End Try
            loadData()
            txtid.Text = newMenuId()
            txtname.Clear()
            txtphoto.Clear()
            txtprice.Clear()
            boxPicture.BackgroundImage = Nothing
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            Try
                Dim id As Integer
                id = dgvdata.Rows(dgvselected).Cells(0).Value
                conn.Open()
                cmd = New SqlCommand("SELECT * FROM tblmenu WHERE id_menu = '" & id & "'", conn)
                reader = cmd.ExecuteReader
                reader.Read()
                txtid.Text = reader.Item("id_menu")
                txtname.Text = reader.Item("name")
                txtprice.Text = reader.Item("price")
                Dim img As Byte() = System.Text.Encoding.UTF8.GetBytes(reader.Item("photo"))

                Dim ms As New MemoryStream(img)
                boxPicture.Image = Image.FromStream(ms)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                conn.Close()
            End Try
        End If
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
        loadData()
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    Private Sub dgvdata_Click(sender As Object, e As EventArgs) Handles dgvdata.Click
        dgvselected = dgvdata.CurrentRow.Index
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub
End Class