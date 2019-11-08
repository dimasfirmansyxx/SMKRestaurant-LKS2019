Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Public Class frmOrder

    Dim id_menu_selected As Integer
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

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        loadmenu()
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
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

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

    End Sub

    Private Sub cmbMember_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMember.SelectedIndexChanged

    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

    End Sub
End Class