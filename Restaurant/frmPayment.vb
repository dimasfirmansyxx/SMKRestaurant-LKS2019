Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmPayment

    Dim userinfo() As String = Split(userlogin, "|")

    Sub get_order()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblorder WHERE payment = ''", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                cmbId.Items.Add(reader.Item("id_order"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        get_order()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim id_order, id_employee, payment, bank As String
        Dim total As Integer
        Dim is_success As Boolean = False
        id_order = cmbId.Text
        id_employee = userinfo(0)
        payment = cmbPayment.Text
        bank = cmbBank.Text
        total = lblTotal.Text

        Try
            conn.Open()
            Dim query As String
            query = "UPDATE tblorder SET id_employee = '" & id_employee & "', payment='" & payment & "',
                     bank = '" & bank & "',total = '" & total & "'"
            cmd = New SqlCommand(query, conn)
            Dim update = cmd.ExecuteNonQuery
            If update > 0 Then
                MessageBox.Show("Sukses")
                is_success = True
            Else
                MessageBox.Show("Gagal")
                is_success = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conn.Close()
        End Try

        If is_success = True Then
            dgv.Rows.Clear()
            cmbId.Items.Clear()
            get_order()
            cmbPayment.Enabled = False
            txtNumber.Enabled = False
            cmbBank.Enabled = False
            btnSave.Enabled = False
            cmbId.SelectedIndex = -1
            cmbPayment.SelectedIndex = -1
            txtNumber.Clear()
            cmbBank.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmbId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbId.SelectedIndexChanged
        If cmbId.Text = "" Then
            cmbPayment.Enabled = False
            txtNumber.Enabled = False
            cmbBank.Enabled = False
            btnSave.Enabled = False
        Else
            cmbPayment.Enabled = True
            txtNumber.Enabled = True
            cmbBank.Enabled = True
            btnSave.Enabled = True
        End If
        Try
            Dim id As String = cmbId.Text
            Dim total As Integer = 0
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblorderdetail WHERE id_order = '" & id & "'", conn)
            reader = cmd.ExecuteReader
            While reader.Read()
                Dim newrow As Integer = dgv.Rows.Add
                Dim subtotal As Integer = CInt(reader.Item("price")) * CInt(reader.Item("qty"))
                dgv.Rows(newrow).Cells(0).Value = reader.Item("id_menu")
                dgv.Rows(newrow).Cells(1).Value = reader.Item("price")
                dgv.Rows(newrow).Cells(2).Value = reader.Item("qty")
                dgv.Rows(newrow).Cells(3).Value = subtotal
                total = total + subtotal
            End While
            lblTotal.Text = total
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
End Class