
Imports System.Data.SqlClient
Public Class Form1
    'creating database conn procedure

    Sub dbCon()
        Dim con As New SqlClient.SqlConnection
        con.ConnectionString = "Data Source="
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
