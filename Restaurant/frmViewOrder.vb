Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmViewOrder

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

    'Function get_menu(id As String, show As String)
    '    Try
    '        conn.Open()
    '        cmd = New SqlCommand("SELECT * FROM tblmenu WHERE id_menu = '" & id & "'", conn)
    '        reader = cmd.ExecuteReader
    '        reader.Read()
    '        Return reader.Item(show)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    Finally
    '        conn.Close()
    '    End Try
    'End Function

    Private Sub frmViewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_order()
        Dim cmb As New DataGridViewComboBoxColumn
        cmb.Items.Add("Pending")
        cmb.Items.Add("Cooking")
        cmb.Items.Add("Deliver")

        dgv.Columns.Add(cmb)
        dgv.Columns(3).HeaderText = "Action"
    End Sub

    Private Sub cmbId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbId.SelectedIndexChanged
        Try
            Dim id As String = cmbId.Text
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblorderdetail WHERE id_order = '" & id & "'", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim newrow As Integer = dgv.Rows.Add
                dgv.Rows(newrow).Cells(0).Value = reader.Item("id_detail")
                dgv.Rows(newrow).Cells(1).Value = reader.Item("id_menu")
                dgv.Rows(newrow).Cells(2).Value = reader.Item("qty")

            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
End Class