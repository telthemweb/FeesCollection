Public Class Fees_calc
    Private Sub Fees_calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        feesfindthis("SELECT COUNT(*) FROM `student_details` ORDER BY `regNumber`")
        Dim kl = GetCount()
        lblNst.Text = kl
    End Sub

    Private Sub Fees_calc_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        lblTotalPaid.Text = Fees_Page_list.lblTotal.Text
        feesfindthis("SELECT COUNT(*) FROM payment_fees WHERE isFullyPaid= 'NO'")
        Dim arrear = GetCount()
        lblArrear.Text = arrear
        lblGrossFees.Text = Val(lblNst.Text * lblFees.Text)
    End Sub
End Class