'Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Module SaveModule
    Public Function fees_insert(ByVal sql As String) As Boolean

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try
        Return Nothing
    End Function

    Public Function fees_update(ByVal sql As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then

                    Return False
                Else
                    Return True

                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try
        Return Nothing
    End Function

    Public Function fees_delete(ByVal sql As String) As Boolean
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Return False
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            con.Close()

        End Try
        Return Nothing
    End Function

    Public Sub fees_save(ByVal sql As String)

        With cmd
            .Connection = con
            .CommandText = sql

            Dim result As Integer

            result = .ExecuteNonQuery
            If result > 0 Then
                MsgBox("data has been saved!")
            Else
                MsgBox("No data has been saved!")
            End If
        End With
    End Sub
    Public Sub count_lable(ByVal sql As String)

        With cmd
            .Connection = con
            .CommandText = sql

            Dim result As Integer

            result = .ExecuteNonQuery
            da.Fill(dt)
            Arrears.GreedFull.DataSource = dt
            Dim TotalMoto = 0
            Dim TotalSales = 0
            For Each Row As DataRow In dt.Rows
                TotalSales += Val(Row.Item("fees_paid"))
            Next
            Arrears.lblTotall.Text = TotalSales

        End With
    End Sub

End Module
