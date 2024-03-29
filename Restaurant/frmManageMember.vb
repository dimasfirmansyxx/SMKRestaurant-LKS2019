﻿Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmManageMember

    Dim dgvselected As Integer
    Dim oldmail As String

    Sub loadData()
        dgvdata.Rows.Clear()

        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblmember", conn)
            reader = cmd.ExecuteReader

            While reader.Read
                Dim newrow As Integer = dgvdata.Rows.Add
                Dim joindate As DateTime = reader.Item("joindate")
                dgvdata.Rows(newrow).Cells(0).Value = reader.Item("id_member")
                dgvdata.Rows(newrow).Cells(1).Value = reader.Item("name")
                dgvdata.Rows(newrow).Cells(2).Value = reader.Item("email")
                dgvdata.Rows(newrow).Cells(3).Value = joindate.ToString("dd/MM/yyyy")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Function getNewId()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblmember ORDER BY id_member DESC", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                Return CStr(CInt(reader.Item("id_member")) + 1)
            Else
                Return 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Function

    Private Sub frmManageMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        loadData()
        txtid.Text = getNewId()
        txtid.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        txtpassword.PasswordChar = "*"
    End Sub

    Private Sub dgvdata_Click(sender As Object, e As EventArgs) Handles dgvdata.Click
        dgvselected = dgvdata.CurrentRow.Index
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If txtname.Text = "" Or txtname.Text = " " Or IsNothing(txtname.Text) Then
            MessageBox.Show("Isi nama terlebih dahulu")
        ElseIf txtemail.Text = "" Or txtemail.Text = " " Or IsNothing(txtemail.Text) Then
            MessageBox.Show("Isi email terlebih dahulu")
        ElseIf txtpassword.Text = "" Or txtpassword.Text = " " Or IsNothing(txtpassword.Text) Then
            MessageBox.Show("Isi password terlebih dahulu")
        Else
            Dim id, name, email, password, joindate As String
            Dim email_availability As Boolean = False
            id = txtid.Text
            name = txtname.Text
            email = txtemail.Text
            password = txtpassword.Text
            joindate = Format(Now, "yyyy-MM-dd HH:mm:ss")

            'cek email
            Try
                conn.Open()
                cmd = New SqlCommand("SELECT * FROM tblmember WHERE email = '" & email & "'", conn)
                reader = cmd.ExecuteReader
                reader.Read()

                If reader.HasRows Then
                    MessageBox.Show("Email sudah terdaftar")
                    email_availability = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                conn.Close()
            End Try

            If email_availability = False Then
                Try
                    conn.Open()
                    cmd = New SqlCommand("SET IDENTITY_INSERT tblmember ON
                                            INSERT INTO tblmember(id_member,name,email,password,joindate) VALUES
                                            ('" & id & "','" & name & "','" & email & "','" & password & "','" & joindate & "')", conn)
                    Dim insert = cmd.ExecuteNonQuery

                    If insert > 0 Then
                        MessageBox.Show("Sukses")
                    Else
                        MessageBox.Show("Gagal")
                    End If
                    txtname.Clear()
                    txtemail.Clear()
                    txtpassword.Clear()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    conn.Close()
                End Try
            End If
            loadData()
            txtid.Text = getNewId()

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            btnUpdate.Text = "Save"
            btnDelete.Text = "Cancel"
            btnInsert.Visible = False
            txtid.Text = dgvdata.Rows(dgvselected).Cells(0).Value
            txtname.Text = dgvdata.Rows(dgvselected).Cells(1).Value
            txtemail.Text = dgvdata.Rows(dgvselected).Cells(2).Value
            oldmail = txtemail.Text
            txtpassword.Visible = False
            Label5.Visible = False
        ElseIf btnUpdate.Text = "Save" Then
            If txtname.Text = "" Or txtname.Text = " " Or IsNothing(txtname.Text) Then
                MessageBox.Show("Isi nama terlebih dahulu")
            ElseIf txtemail.Text = "" Or txtemail.Text = " " Or IsNothing(txtemail.Text) Then
                MessageBox.Show("Isi email terlebih dahulu")
            Else
                Dim id, name, newmail As String
                Dim email_availability As Boolean = False
                id = txtid.Text
                name = txtname.Text
                newmail = txtemail.Text

                If newmail <> oldmail Then
                    Try
                        conn.Open()
                        cmd = New SqlCommand("SELECT * FROM tblmember WHERE email = '" & newmail & "'", conn)
                        reader = cmd.ExecuteReader
                        reader.Read()

                        If reader.HasRows Then
                            MessageBox.Show("Email sudah terdaftar")
                            email_availability = True
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    Finally
                        conn.Close()
                    End Try
                End If

                If email_availability = False Then
                    Try
                        conn.Open()
                        cmd = New SqlCommand("UPDATE tblmember SET
                                                name = '" & name & "', email = '" & newmail & "'
                                              WHERE id_member = '" & id & "'", conn)
                        Dim update = cmd.ExecuteNonQuery

                        If update > 0 Then
                            MessageBox.Show("Berhasil")
                        Else
                            MessageBox.Show("Gagal")
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    Finally
                        conn.Close()
                        btnDelete.PerformClick()
                    End Try
                End If
                loadData()
                txtid.Text = getNewId()
                txtpassword.Visible = True
                Label5.Visible = True
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Delete" Then
            Dim rows As Integer = dgvdata.CurrentRow.Index
            Dim id As String = dgvdata.Rows(rows).Cells(0).Value
            Dim nama As String = dgvdata.Rows(rows).Cells(1).Value
            If MessageBox.Show("Yakin ingin menghapus " & nama & " ?", "Yakin?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    conn.Open()
                    cmd = New SqlCommand("DELETE FROM tblmember WHERE id_member = '" & id & "'", conn)
                    Dim delete = cmd.ExecuteNonQuery
                    If delete > 0 Then
                        MessageBox.Show("Sukses")
                    Else
                        MessageBox.Show("Gagal")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    conn.Close()
                    loadData()
                End Try
            End If
        End If
        txtpassword.Visible = True
        Label5.Visible = True
        txtid.Text = getNewId()
        btnUpdate.Text = "Update"
        btnDelete.Text = "Delete"
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnInsert.Visible = True
        txtname.Clear()
        txtemail.Clear()
    End Sub
End Class