Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmReport
    Sub get_tgl(bulan As String)
        Dim tahun, tglakhir As String
        tahun = Format(Now, "yyyy")

        If bulan = "February" Then
            If tahun Mod 400 = 0 Then
                tglakhir = "29"
            Else
                tglakhir = "28"
            End If
        Else
            Select Case bulan
                Case "January"
                    tglakhir = "31"
                Case "March"
                    tglakhir = "31"
                Case "April"
                    tglakhir = "30"
                Case "May"
                    tglakhir = "31"
                Case "June"
            End Select
        End If
    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim awal, akhir As String
        awal = "01/" & cmbFrom.Text & "/" & Format(Now, "yyyy")
        akhir = "31/" & cmbTo.Text & "/" & Format(Now, "yyyy")
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
    End Sub
End Class