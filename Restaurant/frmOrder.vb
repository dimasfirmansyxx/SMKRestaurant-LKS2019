Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Public Class frmOrder

    Dim id_menu_selected As Integer
    Dim row_selected As Integer
    Dim userinfo() As String
    'New System.Windows.Forms.DataGridViewTextBoxColumn()

    Sub loadmenu()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblmenu", conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim newrow As Integer = dgvMenu.Rows.Add
                dgvMenu.Rows(newrow).Cells(0).Value = reader.Item("id_menu")
                dgvMenu.Rows(newrow).Cells(1).Value = reader.Item("name")
                dgvMenu.Rows(newrow).Cells(2).Value = reader.Item("price")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            conn.Close()
        End Try
    End Sub

    Function get_id_detail()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblorderdetail ORDER BY id_detail DESC", conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                Return CStr(CInt(reader.Item("id_detail") + 1))
            Else
                Return 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Function

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        loadmenu()
        userinfo = Split(userlogin, "|")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim id, menu, price, qty, total As String
        Dim menu_availability As Boolean = False
        id = id_menu_selected
        menu = txtName.Text
        price = txtPrice.Text
        qty = txtQty.Text
        total = CStr(CInt(price * qty))

        Dim counting As Integer = dgvorder.RowCount
        Dim index As Integer = 0

        While index < counting
            If dgvorder.Rows(index).Cells(0).Value = id Then
                Dim oldqty, newqty, oldtotal As String
                oldqty = dgvorder.Rows(index).Cells(3).Value
                newqty = CStr(CInt(oldqty) + CInt(qty))
                oldtotal = dgvorder.Rows(index).Cells(4).Value

                dgvorder.Rows(index).Cells(4).Value = CStr(CInt(price) * CInt(newqty))
                dgvorder.Rows(index).Cells(3).Value = newqty

                lbltotal.Text = CStr((CInt(lbltotal.Text) - CInt(oldtotal)) + (CInt(price) * CInt(newqty)))

                menu_availability = True
            End If
            index += 1
        End While

        If menu_availability = False Then
            Dim newrow As Integer = dgvorder.Rows.Add
            dgvorder.Rows(newrow).Cells(0).Value = id
            dgvorder.Rows(newrow).Cells(1).Value = menu
            dgvorder.Rows(newrow).Cells(2).Value = price
            dgvorder.Rows(newrow).Cells(3).Value = qty
            dgvorder.Rows(newrow).Cells(4).Value = total

            lbltotal.Text = CStr(CInt(lbltotal.Text) + CInt(total))
        End If

        id_menu_selected = 0
        txtName.Clear()
        txtPrice.Clear()
        txtQty.Clear()
        txtQty.Enabled = False
        btnAdd.Enabled = False
        boxPicture.BackgroundImage = Nothing

        If CInt(lbltotal.Text) > 0 Then
            btnOrder.Enabled = True
        Else
            btnOrder.Enabled = False
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim menu As String = dgvorder.Rows(row_selected).Cells(1).Value
        Dim total As Integer = dgvorder.Rows(row_selected).Cells(4).Value
        If MessageBox.Show("Yakin ingin menghapus " & menu & " ?", "Yakin?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            lbltotal.Text = CStr(CInt(lbltotal.Text) - CInt(total))
            dgvorder.Rows.RemoveAt(row_selected)
        End If
        btnRemove.Enabled = False
        If CInt(lbltotal.Text) > 0 Then
            btnOrder.Enabled = True
        Else
            btnOrder.Enabled = False
        End If
    End Sub

    Private Sub dgvMenu_Click(sender As Object, e As EventArgs) Handles dgvMenu.Click
        Dim rowselect As Integer = dgvMenu.CurrentRow.Index
        txtName.Text = dgvMenu.Rows(rowselect).Cells(1).Value
        txtPrice.Text = dgvMenu.Rows(rowselect).Cells(2).Value
        id_menu_selected = dgvMenu.Rows(rowselect).Cells(0).Value

        btnAdd.Enabled = True
        txtQty.Enabled = True
        txtQty.Text = 1

        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tblmenu WHERE id_menu = '" & id_menu_selected & "'", conn)
            reader = cmd.ExecuteReader
            reader.Read()

            Dim img As Byte() = reader.Item("photo")
            Dim ms As New MemoryStream(img)
            boxPicture.BackgroundImage = Image.FromStream(ms)
            boxPicture.BackgroundImageLayout = ImageLayout.Zoom

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub dgvorder_Click(sender As Object, e As EventArgs) Handles dgvorder.Click
        row_selected = dgvorder.CurrentRow.Index
        btnRemove.Enabled = True
    End Sub


    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Dim tblorder As Boolean
        Dim id_order, id_employee, id_member, tanggal, payment, bank As String

        'add to tblorder
        id_order = Format(Now, "yyyyMMddHHmmss")
        id_employee = "1"
        id_member = userinfo(0)
        tanggal = Format(Now, "dd/MM/yyyy")
        payment = ""
        bank = ""

        Try
            conn.Open()
            cmd = New SqlCommand("INSERT INTO tblorder VALUES 
                                  ('" & id_order & "','" & id_employee & "','" & id_member & "','" & tanggal & "',
                                   '" & payment & "','" & bank & "')", conn)
            Dim insert = cmd.ExecuteNonQuery
            If insert > 0 Then
                tblorder = True
            Else
                tblorder = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            conn.Close()
        End Try

        'add to tblorderdetail
        Dim count As Integer = dgvorder.RowCount
        Dim index As Integer = 0
        While index < count
            Dim id_detail, id_menu, qty, price, message As String
            id_detail = get_id_detail()
            id_menu = dgvorder.Rows(index).Cells(0).Value
            qty = dgvorder.Rows(index).Cells(3).Value
            price = dgvorder.Rows(index).Cells(2).Value
            message = ""

            Try
                conn.Open()
                cmd = New SqlCommand("SET IDENTITY_INSERT tblorderdetail ON
                                      INSERT INTO tblorderdetail(id_detail,id_order,id_menu,qty,price,message) VALUES 
                                      ('" & id_detail & "','" & id_order & "','" & id_menu & "',
                                       '" & qty & "','" & price & "','" & message & "')", conn)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            Finally
                conn.Close()
            End Try

            index += 1
        End While

        If tblorder = True Then
            MessageBox.Show("Nomor order anda " & id_order & " berhasil")
        Else
            MessageBox.Show("Gagal")
        End If

        id_menu_selected = 0
        txtName.Clear()
        txtPrice.Clear()
        txtQty.Clear()
        txtQty.Enabled = False
        btnAdd.Enabled = False
        boxPicture.BackgroundImage = Nothing
        dgvorder.Rows.Clear()
    End Sub
End Class