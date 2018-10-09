Public Class Student_Reg
    Public Property ErrorProvider1 As Object

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear all textbox for new student to be added
        txtReg.Clear()
        txtFname.Clear()
        txtSurname.Clear()
        txtDOB.ResetText()
        cboGender.ResetText()
        cboClass.ResetText()
        cboTerm.ResetText()
        txtNational.Clear()
        txtAddress.Clear()
        txtFather.Clear()
        txtOcpy.Clear()
        txtPhone.Clear()
    End Sub

    Private Sub btnExt_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Me.Close()
    End Sub

    Private Sub TimerCownd_Tick(sender As Object, e As EventArgs) Handles TimerCownd.Tick
        lblTime.Text = TimeOfDay
        TimerCownd.Enabled = True
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        If btnReg.Text = "Register" Then
            feesfindthis("SELECT COUNT(*) FROM `student_details` WHERE `regNumber`='" & txtReg.Text & "'")

            If GetCount() > 0 Then
                MsgBox("Student ID Number is already exist Please try something new!", MsgBoxStyle.Critical)
                lblError.Text = "No student has been added!"
                lblError.Visible = True
            Else

                If txtReg.Text = "" Then
                    MsgBox("Reg Number is Required!", MsgBoxStyle.Critical)
                ElseIf txtFname.Text = "" Then
                    MsgBox("Name is Required!", MsgBoxStyle.Critical)
                ElseIf txtSurname.Text = "" Then
                    MsgBox("Surname is Required!", MsgBoxStyle.Critical)
                ElseIf txtAddress.Text = "" Then
                    MsgBox("Address is Required!", MsgBoxStyle.Critical)
                ElseIf txtNational.Text = "" Then
                    MsgBox("Nationality is Required!", MsgBoxStyle.Critical)
                ElseIf txtFather.Text = "" Then
                    MsgBox("Father's name is Required!", MsgBoxStyle.Critical)
                ElseIf txtOcpy.Text = "" Then
                    MsgBox("Occupation is Required!", MsgBoxStyle.Critical)
                ElseIf txtDOB.Text = "" Then
                    MsgBox("Date of Birth is Required!", MsgBoxStyle.Critical)
                ElseIf txtPhone.Text = "" Then
                    MsgBox("Phone Number is Required!", MsgBoxStyle.Critical)
                ElseIf cboClass.Text = "" Then
                    MsgBox("Please select class!", MsgBoxStyle.Critical)
                ElseIf cboGender.Text = "" Then
                    MsgBox("Please select gender!", MsgBoxStyle.Critical)
                ElseIf cboTerm.Text = "" Then
                    MsgBox("Please select School Term!", MsgBoxStyle.Critical)

                Else
                    issucess = fees_insert("INSERT INTO `student_details` (`regNumber`, `name`, `surname`,`dateOfBirth`, " &
                           " `gender`, `nationality`, `class`, `term`, `address`, `fatherName`, `occupation`, `phone`,`date_registered`) " &
                           " VALUES ('" & txtReg.Text & "','" & txtFname.Text & "', '" & txtSurname.Text & "', '" & txtDOB.Text & "', '" & cboGender.Text & "', '" & txtNational.Text & "', " &
                           " '" & cboClass.Text & "', '" & cboTerm.Text & "', '" & txtAddress.Text & "', '" & txtFather.Text & "', '" & txtOcpy.Text & "', '" & txtPhone.Text & "','" & dpRegistered.Text & "');")
                    If issucess = True Then

                        MsgBox("New student has been added successfully!", MsgBoxStyle.Information)
                        Fee_payement_Page.Show()
                        Me.Hide()
                        Fee_payement_Page.txtReg.Text = txtReg.Text
                        Fee_payement_Page.txtFullN.Text = txtFname.Text & " " & txtSurname.Text
                        Fee_payement_Page.cboClass.Text = cboClass.Text
                        Fee_payement_Page.cboTerm.Text = cboTerm.Text
                        Fee_payement_Page.txtCashName.Text = Main_Page.btnLogout.Text


                        txtReg.Clear()
                        txtFname.Clear()
                        txtSurname.Clear()
                        txtDOB.ResetText()
                        cboGender.ResetText()
                        cboClass.ResetText()
                        cboTerm.ResetText()
                        txtNational.Clear()
                        txtAddress.Clear()
                        txtFather.Clear()
                        txtOcpy.Clear()
                        txtPhone.Clear()

                    Else
                        lblError.Text = "No student has been added!"
                        lblError.Visible = True

                        txtReg.Clear()
                        txtFname.Clear()
                        txtSurname.Clear()
                        txtDOB.ResetText()
                        cboGender.ResetText()
                        cboClass.ResetText()
                        cboTerm.ResetText()
                        txtNational.Clear()
                        txtAddress.Clear()
                        txtFather.Clear()
                        txtOcpy.Clear()
                        txtPhone.Clear()
                    End If

                End If
            End If

        ElseIf btnReg.Text = "Update" Then
            If txtReg.Text = "" Then
                MsgBox("Student ID Number is Required!", MsgBoxStyle.Critical)
            ElseIf txtFname.Text = "" Then
                MsgBox("Name is Required!", MsgBoxStyle.Critical)
            ElseIf txtSurname.Text = "" Then
                MsgBox("Surname is Required!", MsgBoxStyle.Critical)
            ElseIf txtAddress.Text = "" Then
                MsgBox("Address is Required!", MsgBoxStyle.Critical)
            ElseIf txtNational.Text = "" Then
                MsgBox("Nationality is Required!", MsgBoxStyle.Critical)
            ElseIf txtFather.Text = "" Then
                MsgBox("Father's name is Required!", MsgBoxStyle.Critical)
            ElseIf txtOcpy.Text = "" Then
                MsgBox("Occupation is Required!", MsgBoxStyle.Critical)
            ElseIf txtDOB.Text = "" Then
                MsgBox("Date of Birth is Required!", MsgBoxStyle.Critical)
            ElseIf txtPhone.Text = "" Then
                MsgBox("Phone Number is Required!", MsgBoxStyle.Critical)
            ElseIf cboClass.Text = "" Then
                MsgBox("Please select class!", MsgBoxStyle.Critical)
            ElseIf cboGender.Text = "" Then
                MsgBox("Please select gender!", MsgBoxStyle.Critical)
            ElseIf cboTerm.Text = "" Then
                MsgBox("Please select School Term!", MsgBoxStyle.Critical)
            Else
                issucess = fees_insert("UPDATE `student_details` SET `name`='" & txtFname.Text & "',`surname`= '" & txtSurname.Text & "',`dateOfBirth`='" & txtDOB.Text & "',`gender`= '" & cboGender.Text & "',`nationality`=  '" & txtNational.Text & "'," &
                                       "`class`='" & cboClass.Text & "',`term`= '" & cboTerm.Text & "',`address`='" & txtAddress.Text & "',`fatherName`=  '" & txtFather.Text & "', `occupation`='" & txtOcpy.Text & "',`phone`='" & txtPhone.Text & "',`date_registered`='" & dpRegistered.Text & "' WHERE `regNumber`='" & txtReg.Text & "'")
                If issucess = True Then
                    MsgBox("Student has been updated successfully!", MsgBoxStyle.Information)
                    'LoadData(StudentLists.studentGrid, "STUDENTLIST")
                    StudentLists.Show()
                    Me.Hide()
                    txtReg.Clear()
                    txtFname.Clear()
                    txtSurname.Clear()
                    txtDOB.ResetText()
                    cboGender.ResetText()
                    cboClass.ResetText()
                    cboTerm.ResetText()
                    txtNational.Clear()
                    txtAddress.Clear()
                    txtFather.Clear()
                    txtOcpy.Clear()
                    txtPhone.Clear()
                Else
                    lblError.Text = "No student has been updated!"
                    lblError.Visible = True

                    txtReg.Clear()
                    txtFname.Clear()
                    txtSurname.Clear()
                    txtDOB.ResetText()
                    cboGender.ResetText()
                    cboClass.ResetText()
                    cboTerm.ResetText()
                    txtNational.Clear()
                    txtAddress.Clear()
                    txtFather.Clear()
                    txtOcpy.Clear()
                    txtPhone.Clear()
                End If
            End If


        End If
    End Sub

    Private Sub Student_Reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        issucess = fees_delete("DELETE From student_details  Where regNumber='" & txtReg.Text & "'")
        If issucess = True Then
            MsgBox("New student has been deleted successfully!", MsgBoxStyle.Information)
            StudentLists.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Student_Profile.Show()
        Me.Hide()
    End Sub
End Class