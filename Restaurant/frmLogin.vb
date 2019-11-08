Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim logged As Boolean = False

        If txtEmail.Text = "" Or txtEmail.Text = " " Or IsNothing(txtEmail.Text) Then
            MessageBox.Show("Isikan email terlebih dahulu")
        ElseIf txtPassword.Text = "" Or txtPassword.Text = " " Or IsNothing(txtPassword.Text) Then
            MessageBox.Show("Isikan password terlebih dahulu")
        Else
            konek()
            Try
                Dim emailCheck As String = txtEmail.Text
                Dim passwordCheck As String = txtPassword.Text
                Dim sql As String = "SELECT * FROM tblemployee WHERE email = '" & emailCheck & "'"
                conn.Open()
                cmd = New SqlCommand(sql, conn)
                reader = cmd.ExecuteReader
                reader.Read()
                If reader.HasRows Then
                    If reader.Item("password") = passwordCheck Then
                        If reader.Item("position") = "admin" Then
                            Dim adminForm = New frmAdminNav
                            adminForm.lblAdminName.Text = reader.Item("name")
                            adminForm.Show()
                        ElseIf reader.Item("position") = "chef" Then
                            Dim chefForm = New frmChefNav
                            chefForm.lblChefName.Text = reader.Item("name")
                            chefForm.Show()
                        ElseIf reader.Item("position") = "cashier" Then
                            Dim cashierForm = New frmCashierNav
                            cashierForm.lblCashierName.Text = reader.Item("name")
                            cashierForm.Show()
                        End If
                        Dim id_employee, name, email, password, handphone, position As String
                        id_employee = reader.Item("id_employee")
                        name = reader.Item("name")
                        email = reader.Item("email")
                        password = reader.Item("password")
                        handphone = reader.Item("handphone")
                        position = reader.Item("position")
                        mdlKoneksi.userlogin = id_employee + "|" + name + "|" + email + "|" + password + "|" + handphone + "|" + position
                        logged = True
                        Me.Close()
                    Else
                        MessageBox.Show("Password Salah")
                    End If
                Else
                    logged = False
                End If
            Catch ex As Exception
                MessageBox.Show("Error. " & ex.ToString())
            Finally
                conn.Close()
            End Try
            'MessageBox.Show("Email tidak terdaftar")
            If logged = False Then
                Try
                    Dim emailCheck As String = txtEmail.Text
                    Dim passwordCheck As String = txtPassword.Text
                    Dim sql As String = "SELECT * FROM tblmember WHERE email = '" & emailCheck & "'"
                    conn.Open()
                    cmd = New SqlCommand(sql, conn)
                    reader = cmd.ExecuteReader
                    reader.Read()
                    If reader.HasRows Then
                        If reader.Item("password") = passwordCheck Then
                            Dim orderform As New frmOrder
                            orderform.Show()
                            Dim id_member, name, email, password, joindate As String
                            id_member = reader.Item("id_member")
                            name = reader.Item("name")
                            email = reader.Item("email")
                            password = reader.Item("password")
                            joindate = reader.Item("joindate")
                            mdlKoneksi.userlogin = id_member + "|" + name + "|" + email + "|" + password + "|" + joindate
                            logged = True
                            Me.Close()
                        Else
                            MessageBox.Show("Password Salah")
                        End If
                    Else
                        MessageBox.Show("Email tidak terdaftar")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    conn.Close()
                End Try

            End If

        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
