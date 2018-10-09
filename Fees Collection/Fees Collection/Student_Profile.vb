Public Class Student_Profile
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles feesGRED.CellContentClick

    End Sub

    Private Sub Student_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblReg.Text = Student_Reg.txtReg.Text
        lblName.Text = Student_Reg.txtFname.Text
        lblSur.Text = Student_Reg.txtSurname.Text
        lblDOB.Text = Student_Reg.txtDOB.Text
        lblGend.Text = Student_Reg.cboGender.Text
        lblClass.Text = Student_Reg.cboClass.Text

        feesfindthis("SELECT id,fees_paid,amount_left,term_paid FROM payment_fees WHERE isFullyPaid= 'NO' AND regNumber='" & Student_Reg.txtReg.Text & "'")
        LoadData(AreearGRED, "arrearsload")


    End Sub

    Private Sub Student_Profile_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        feesfindthis("SELECT * FROM tblbackup where  regNumber='" & Student_Reg.txtReg.Text & "' ")
        LoadData(feesGRED, "loadFeeslog")
    End Sub

    Private Sub AreearGRED_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AreearGRED.CellContentClick

    End Sub
End Class