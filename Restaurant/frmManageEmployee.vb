Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmManageEmployee

    Dim dgvSelectedIndex As Integer

    Sub showEmployee()
        dgv.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblemployee", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim newrow As Integer = dgv.Rows.Add
                dgv.Rows(newrow).Cells(0).Value = reader.Item("id_employee")
                dgv.Rows(newrow).Cells(1).Value = reader.Item("name")
                dgv.Rows(newrow).Cells(2).Value = reader.Item("email")
                dgv.Rows(newrow).Cells(3).Value = reader.Item("handphone")
                dgv.Rows(newrow).Cells(4).Value = StrConv(reader.Item("position"), VbStrConv.ProperCase)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            conn.Close()
        End Try
    End Sub

    Function newEmployeId()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblemployee ORDER BY id_employee DESC", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                Return CStr(CInt(reader.Item("id_employee")) + 1)
            Else
                Return 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            conn.Close()
        End Try
    End Function

    Private Sub frmManageEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        showEmployee()
        txtid.Text = newEmployeId()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        If txtname.Text = "" Or txtname.Text = " " Or IsNothing(txtname.Text) Then
            MessageBox.Show("Isi nama terlebih dahulu")
        ElseIf txtemail.Text = "" Or txtemail.Text = " " Or IsNothing(txtemail.Text) Then
            MessageBox.Show("Isi email Terlebih dahulu")
        ElseIf txthp.Text = "" Or txthp.Text = " " Or IsNothing(txthp.Text) Then
            MessageBox.Show("Isikan nomor HP terlebih dahulu")
        ElseIf IsNumeric(txthp.Text) = False Then
            MessageBox.Show("Isikan nomor HP hanya dengan angka")
        ElseIf cmbposition.Text = "" Or cmbposition.Text = " " Then
            MessageBox.Show("Pilih position terlebih dahulu")
        Else
            Dim id_employee, name, email, password, hp, position As String
            Dim account_availability As Boolean = False
            id_employee = txtid.Text
            name = txtname.Text
            email = txtemail.Text
            password = "123"
            hp = txthp.Text
            position = LCase(cmbposition.Text)

            'cek email
            Try
                conn.Open()
                Dim query As String
                query = "SELECT * FROM tblemployee WHERE email = '" & email & "'"
                cmd = New SqlCommand(query, conn)
                reader = cmd.ExecuteReader
                reader.Read()
                If reader.HasRows Then
                    account_availability = True
                    MessageBox.Show("Email sudah terdaftar")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                conn.Close()
            End Try

            If account_availability = False Then
                Try
                    conn.Open()
                    Dim query As String
                    query = "INSERT INTO tblemployee(id_employee,name,email,password,handphone,position) 
                                VALUES ('" & id_employee & "','" & name & "','" & email & "',    
                                '" & password & "', '" & hp & "','" & position & "')"
                    cmd = New SqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Sukses")
                    txtid.Text = CStr(CInt(txtid.Text) + 1)
                    txtname.Clear()
                    txtemail.Clear()
                    txthp.Clear()
                    cmbposition.SelectedIndex = -1
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    conn.Close()
                End Try
                showEmployee()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim oldmail As String = ""
        dgvSelectedIndex = dgv.CurrentRow.Index
        If btnUpdate.Text = "Update" Then
            oldmail = dgv.Rows(dgvSelectedIndex).Cells(2).Value
            txtid.Text = dgv.Rows(dgvSelectedIndex).Cells(0).Value
            txtname.Text = dgv.Rows(dgvSelectedIndex).Cells(1).Value
            txtemail.Text = dgv.Rows(dgvSelectedIndex).Cells(2).Value
            txthp.Text = dgv.Rows(dgvSelectedIndex).Cells(3).Value
            Dim position As String = LCase(dgv.Rows(dgvSelectedIndex).Cells(4).Value)
            If position = "admin" Then
                cmbposition.SelectedIndex = 0
            ElseIf position = "chef" Then
                cmbposition.SelectedIndex = 1
            ElseIf position = "cashier" Then
                cmbposition.SelectedIndex = 2
            End If

            btnInsert.Visible = False
            btnUpdate.Text = "Save"
            btnDelete.Text = "Cancel"
        ElseIf btnUpdate.Text = "Save" Then
            Dim email_availability As Boolean = False

            If txtname.Text = "" Or txtname.Text = " " Or IsNothing(txtname.Text) Then
                MessageBox.Show("Isi nama terlebih dahulu")
            ElseIf txtemail.Text = "" Or txtemail.Text = " " Or IsNothing(txtemail.Text) Then
                MessageBox.Show("Isi email Terlebih dahulu")
            ElseIf txthp.Text = "" Or txthp.Text = " " Or IsNothing(txthp.Text) Then
                MessageBox.Show("Isikan nomor HP terlebih dahulu")
            ElseIf IsNumeric(txthp.Text) = False Then
                MessageBox.Show("Isikan nomor HP hanya dengan angka")
            ElseIf cmbposition.Text = "" Or cmbposition.Text = " " Then
                MessageBox.Show("Pilih position terlebih dahulu")
            Else
                If txtemail.Text <> oldmail Then
                    Try
                        conn.Open()
                        cmd = New SqlCommand("SELECT * FROM tblemployee WHERE email = '" & txtemail.Text & "'", conn)
                        reader = cmd.ExecuteReader
                        reader.Read()
                        If reader.HasRows Then
                            email_availability = True
                            MessageBox.Show("Email sudah terdaftar")
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    Finally
                        conn.Close()
                    End Try
                End If

                If email_availability = False Then
                    Dim id_employee, name, email, nohp, position As String
                    id_employee = txtid.Text
                    name = txtname.Text
                    email = txtemail.Text
                    nohp = txthp.Text
                    position = cmbposition.Text
                    Try
                        conn.Open()
                        Dim query As String
                        query = "UPDATE tblemployee SET
                                name = '" & name & "', email = '" & email & "', handphone = '" & nohp & "', 
                                position = '" & position & "' WHERE id_employee = '" & id_employee & "'"
                        cmd = New SqlCommand(query, conn)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Berhasil")
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    Finally
                        conn.Close()
                    End Try
                    btnDelete.PerformClick()
                    showEmployee()
                End If
            End If

        End If
        txtid.Text = newEmployeId()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "Delete" Then
            Dim id_employee, name As String
            id_employee = dgv.Rows(dgvSelectedIndex).Cells(0).Value
            name = dgv.Rows(dgvSelectedIndex).Cells(1).Value
            If MessageBox.Show("Yakin ingin menghapus user " & name & " ?", "Yakin?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    conn.Open()
                    cmd = New SqlCommand("DELETE FROM tblemployee WHERE id_employee = '" & id_employee & "'", conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Berhasil")
                    btnUpdate.Enabled = False
                    btnDelete.Enabled = False
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    conn.Close()
                End Try
                showEmployee()
            End If
        ElseIf btnDelete.Text = "Cancel" Then
            txtid.Text = newEmployeId()
            txtname.Clear()
            txtemail.Clear()
            txthp.Clear()
            cmbposition.SelectedIndex = -1
            btnInsert.Visible = True
            btnUpdate.Text = "Update"
            btnDelete.Text = "Delete"
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
        End If
        txtid.Text = newEmployeId()
    End Sub

    Private Sub dgv_Click(sender As Object, e As EventArgs) Handles dgv.Click
        dgvSelectedIndex = dgv.CurrentRow.Index
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub
End Class