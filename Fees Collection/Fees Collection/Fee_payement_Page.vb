Public Class Fee_payement_Page
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        ReceiptForm.Show()
            Me.Hide()
            ReceiptForm.lblReceipt.Text = txtRecept.Text
            ReceiptForm.txtFullN.Text = txtFullN.Text
            ReceiptForm.txtReg.Text = txtReg.Text
            ReceiptForm.txtClass.Text = cboClass.Text
            ReceiptForm.txtTerm.Text = cboTerm.Text
            ReceiptForm.txtFees.Text = txtAmt.Text
            ReceiptForm.txtBalance.Text = txtBalance.Text
            ReceiptForm.txtDate.Text = dpRegistered.Text
            ReceiptForm.lblCashier.Text = txtCashName.Text


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtReg.Clear()
        txtFullN.Clear()
        cboClass.ResetText()
        cboTerm.ResetText()
        txtAmt.Clear()
        txtBalance.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtBalance.Text = Val(txtfeeperTerm.Text - txtAmt.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFeePay.Click
        If btnFeePay.Text = "Pay Fees" Then
            'c1
            If txtAmt.Text = "" Then

                MsgBox("Please amount of fees paid is Required!", MsgBoxStyle.Critical)
            ElseIf txtRecept.Text = "" Then
                MsgBox("Please Receipt Number is Required!", MsgBoxStyle.Critical)
            ElseIf txtBalance.Text = "" Then
                MsgBox("Please make sure you have clicked button calculate fess before make payment", MsgBoxStyle.Critical)
            Else
                issucess = fees_insert("INSERT INTO `payment_fees` (`receiptNumber`,`regNumber`, `fullName`, `term_paid`,`date_paid`, " &
                               " `fees_paid`, `amount_left`, `class`, `isFullyPaid`,`Cashier`) " &
                               " VALUES ('" & txtRecept.Text & "','" & txtReg.Text & "','" & txtFullN.Text & "', '" & cboTerm.Text & "', '" & dpRegistered.Text & "', '" & txtAmt.Text & "', '" & txtBalance.Text & "','" & cboClass.Text & "', " &
                               " '" & cboStatus.Text & "','" & txtCashName.Text & "');")
                If issucess = True Then
                    fees_insert("INSERT INTO `tblbackup` (`receiptNumber`,`regNumber`, `fullName`, `term_paid`,`date_paid`, " &
                               " `fees_paid`, `amount_left`, `class`, `isFullyPaid`,`Cashier`) " &
                               " VALUES ('" & txtRecept.Text & "','" & txtReg.Text & "','" & txtFullN.Text & "', '" & cboTerm.Text & "', '" & dpRegistered.Text & "', '" & txtAmt.Text & "', '" & txtBalance.Text & "','" & cboClass.Text & "', " &
                               " '" & cboStatus.Text & "','" & txtCashName.Text & "');")

                    MsgBox("New student fees has been paid successfully, you may print receipt")
                Else
                    lblError.Text = "New student fees has not been paid successfully, Please make sure all details are correct!! "
                    lblError.Visible = True
                    txtReg.Clear()
                    txtFullN.Clear()
                    cboClass.ResetText()
                    cboTerm.ResetText()
                    txtAmt.Clear()
                    txtBalance.Clear()

                End If
            End If
            'end of c1

        ElseIf btnFeePay.Text = "Update Fees" Then

            If txtAmt.Text = "" Then
                MsgBox("Please amount of fees paid is Required!", MsgBoxStyle.Critical)
            ElseIf txtRecept.Text = "" Then
                MsgBox("Please Receipt Number is Required!", MsgBoxStyle.Critical)
            ElseIf txtBalance.Text = "" Then
                MsgBox("Please make sure you have clicked button calculate fess before make payment", MsgBoxStyle.Critical)

            Else

                issucess = fees_insert("UPDATE `payment_fees` SET `receiptNumber`='" & txtRecept.Text & "',`fullName`='" & txtFullN.Text & "',`term_paid`= '" & cboTerm.Text & "',`date_paid`=  '" & dpRegistered.Text & "'," &
                                       "`fees_paid`='" & txtAmt.Text & "',`amount_left`= '" & txtBalance.Text & "', `class`= '" & cboClass.Text & "',`isFullyPaid`='" & cboStatus.Text & "',`Cashier`=  '" & txtCashName.Text & "' WHERE `regNumber`='" & txtReg.Text & "'")
                If issucess = True Then
                    issucess = fees_insert("UPDATE `tblbackup` SET `receiptNumber`='" & txtRecept.Text & "',`fullName`='" & txtFullN.Text & "',`term_paid`= '" & cboTerm.Text & "',`date_paid`=  '" & dpRegistered.Text & "'," &
                                       "`fees_paid`='" & txtAmt.Text & "',`amount_left`= '" & txtBalance.Text & "', `class`= '" & cboClass.Text & "',`isFullyPaid`='" & cboStatus.Text & "',`Cashier`=  '" & txtCashName.Text & "' WHERE `regNumber`='" & txtReg.Text & "'")

                    MsgBox("Fees Payment has been updated successfully.You may print receipt!", MsgBoxStyle.Information)

                Else
                    lblError.Text = "No Payment has been updated!"
                    lblError.Visible = True
                    txtReg.Clear()
                    txtFullN.Clear()
                    cboClass.ResetText()
                    cboTerm.ResetText()
                    txtAmt.Clear()
                    txtBalance.Clear()
                End If
            End If
        Else
            MsgBox("Error!", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            feesfindthis("SELECT * FROM `student_details` WHERE `regNumber`='" & txtSearch.Text & "'")
            con.Open()
            dReader = cmd.ExecuteReader()
            While dReader.Read
                txtReg.Text = dReader("regNumber")
                txtFullN.Text = dReader("name") & " " & dReader("surname")
                cboClass.Text = dReader("class")
                cboTerm.Text = dReader("term")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try


    End Sub

    Private Sub Fee_payement_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCashName.Text = Main_Page.btnLogout.Text

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        issucess = fees_delete("DELETE  From payment_fees  Where regNumber ='" & txtReg.Text & "'")
        If issucess = True Then
            MsgBox("New student has been deleted successfully!")
            Fees_Page_list.Show()
            Me.Hide()
            '("delete from useraccounts where account_id = " & lblid.Text & "")

        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class