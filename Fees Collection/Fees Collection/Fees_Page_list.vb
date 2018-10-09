Public Class Fees_Page_list
    Private Sub Fees_Page_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        feesfindthis("SELECT * FROM `payment_fees`")
        LoadData(FeesGrid, "payment")
        Dim kl = GetGrossTotal()
        lblTotal.Text = kl


    End Sub

    Private Sub FeesGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FeesGrid.CellClick

        feesfindthis("SELECT * FROM `payment_fees` WHERE `id`='" & FeesGrid.CurrentRow.Cells(0).Value & "'")
            LoadSingleResult("payNow")

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Fee_payement_Page.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            feesfindthis("SELECT * FROM `payment_fees` WHERE `regNumber`='" & txtSearch.Text & "' Or `fullName`='" & txtSearch.Text & "'")
            LoadData(FeesGrid, "payment")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub Fees_Page_list_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        feesfindthis("SELECT*FROM payment_fees WHERE isFullyPaid= 'NO'")
        Dim arr = GetTotalArrears()
        lblArrya.Text = arr
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class