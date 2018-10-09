'Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Module fees_sqlstatements
    Public Sub feesfindthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub LoadSingleResult(ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "student"
                    Do While dReader.Read = True
                        With Student_Reg
                            .txtReg.Text = dReader("regNumber")
                            .txtReg.Enabled = False
                            .txtFname.Text = dReader("name")
                            .txtSurname.Text = dReader("surname")
                            .txtDOB.Text = dReader("dateOfBirth")
                            .cboGender.Text = dReader("gender")
                            .txtNational.Text = dReader("nationality")
                            .cboClass.Text = dReader("class")
                            .cboTerm.Text = dReader("term")
                            .txtAddress.Text = dReader("address")
                            .txtFather.Text = dReader("fatherName")
                            .txtOcpy.Text = dReader("occupation")
                            .txtPhone.Text = dReader("phone")
                            .lblbanner.Text = "Update Student Details"
                            .Show()
                            .btnReg.Enabled = True
                            .btnReg.Text = "Update"
                            .btnExit.Text = "Delete student"
                            .btnExit.Visible = True
                            .btnView.Visible = True

                        End With
                    Loop
                Case "login"
                    Do While dReader.Read = True

                        ACCOUNT_NAME = dReader("fullName")
                        ACCOUNT_USERNAME = dReader("username")
                        ACCOUNT_TYPE = dReader("user_Type")
                        Main_Page.Show()
                        Main_Page.btnLogout.Text = ACCOUNT_NAME
                        Form1.Hide()
                    Loop
                Case "payNow"
                    Do While dReader.Read = True
                        With Fee_payement_Page
                            .txtRecept.Text = dReader("receiptNumber")
                            .txtRecept.Enabled = False
                            .txtReg.Text = dReader("regNumber")
                            .txtReg.Enabled = False
                            .txtFullN.Text = dReader("fullName")
                            .txtFullN.Enabled = False
                            .cboTerm.Text = dReader("term_paid")
                            .dpRegistered.Text = dReader("date_paid")
                            .dpRegistered.Enabled = False
                            .txtAmt.Text = dReader("fees_paid")
                            .txtBalance.Text = dReader("amount_left")
                            .cboStatus.Text = dReader("isFullyPaid")
                            .txtCashName.Text = dReader("Cashier")
                            .cboClass.Text = dReader("class")
                            .Show()
                            .lblbanner.Text = "Update Payment"
                            .btnFeePay.Enabled = True
                            .btnFeePay.Text = "Update Fees"
                            .btnExit.Text = "Delete Fees"
                            .btnExit.Visible = True

                        End With
                    Loop

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub


End Module
