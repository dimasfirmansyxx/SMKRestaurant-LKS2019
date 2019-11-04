Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmChangePassword
    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
    End Sub

    Private Function checkPassword(password As String)
        Dim length As Integer = password.Count
        Dim upper As Boolean = False
        Dim lower As Boolean = False
        Dim numeric As Boolean = False
        Dim index As Integer = 0
        While index < length
            Dim toascii As Short = Asc(password.Substring(index, 1))
            If toascii >= 65 And toascii <= 90 Then
                upper = True
            ElseIf toascii >= 97 And toascii <= 122 Then
                lower = True
            ElseIf IsNumeric(password.Substring(index, 1)) = True Then
                numeric = True
            End If
            index += 1
        End While
        If upper = True And lower = True And numeric = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim userinfo() As String = mdlKoneksi.userlogin.Split(New Char() {"|"c})
        If txtOld.Text = "" Or txtOld.Text = " " Or IsNothing(txtOld.Text) Then
            MessageBox.Show("Isi Password lama terlebih dahulu")
        ElseIf txtNew.Text = "" Or txtNew.Text = " " Or IsNothing(txtNew.Text) Then
            MessageBox.Show("Isi Password baru terlebih dahulu")
        ElseIf txtConfirm.Text = "" Or txtConfirm.Text = " " Or IsNothing(txtConfirm.Text) Then
            MessageBox.Show("Isi Konfirmasi Password baru terlebih dahulu")
        ElseIf userinfo(3) <> txtOld.Text Then
            MessageBox.Show("Password lama salah!")
        ElseIf Not checkPassword(txtNew.Text) Then
            MessageBox.Show("Password harus mengandung huruf kapital, huruf kecil, dan angka")
        ElseIf txtNew.Text <> txtConfirm.Text Then
            MessageBox.Show("Password baru dan konfirmasi tidak sama")
        Else
            Try
                conn.Open()
                Dim query As String
                query = "UPDATE tblemployee SET password = '" & txtNew.Text & "' WHERE id_employee = '" & userinfo(0) & "'"
                cmd = New SqlCommand(query, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil mengubah password")
                txtOld.Clear()
                txtNew.Clear()
                txtConfirm.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
End Class