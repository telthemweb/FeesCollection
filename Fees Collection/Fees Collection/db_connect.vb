'Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Module db_connect
    Dim MysqlConn As New OleDbConnection

    Public Function myconn() As OleDbConnection

        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\fees_collection.accdb;")

    End Function
End Module
