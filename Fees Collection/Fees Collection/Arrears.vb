Public Class Arrears

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            feesfindthis("SELECT * FROM `payment_fees` WHERE `regNumber`='" & txtSearch.Text & "' Or `fullName`='" & txtSearch.Text & "'")

            Dim kl = GetCount()
            If kl = 0 Then
                MsgBox("Record not found ", MsgBoxStyle.Critical)
                txtSearch.Text = ""
            Else
                LoadData(GreedFull, "payment")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub Arrears_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        feesfindthis("SELECT*FROM payment_fees WHERE isFullyPaid= 'YES'")
        LoadData(GreedFull, "payment")
        Dim kl = GetTotal()
        lblTotall.Text = kl


    End Sub

    Private Sub Arrears_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        feesfindthis("SELECT*FROM payment_fees WHERE isFullyPaid= 'NO'")
        LoadData(DataArrears, "payment")
        Dim kl = GetTotalArrears()
        lblTotal.Text = kl

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            feesfindthis("SELECT * FROM `payment_fees` WHERE `regNumber`='" & txtSearch.Text & "' Or `fullName`='" & txtSearch.Text & "'")
            LoadData(DataArrears, "payment")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class