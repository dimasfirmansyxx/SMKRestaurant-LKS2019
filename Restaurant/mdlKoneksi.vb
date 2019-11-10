Imports System.Data.Sql
Imports System.Data.SqlClient
Module mdlKoneksi
    Public conn As New SqlConnection
    Public reader As SqlDataReader
    Public cmd As New SqlCommand
    Public str As String = "Data Source=DIMAS\SQLEXPRESS;Initial Catalog=dbresto;Persist Security Info=true;UID=sa;PWD=123"
    Public userlogin As String

    Public Sub konek()
        conn = New SqlConnection(str)
    End Sub

End Module

'New System.Windows.Forms.DataGridViewTextBoxColumn()