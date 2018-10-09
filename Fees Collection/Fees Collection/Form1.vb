Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLog.Click
        If txtUser.Text = "" Then
            lblUser.Text = "*Username Required"
            lblUser.Visible = True
            lblPass.Visible = False
        ElseIf txtPass.Text = "" Then
            lblPass.Text = "* Password is Required"
            lblPass.Visible = True
            lblUser.Visible = False

        Else
            ' lblsuccess.Text = "You logged in Successfully"
            sql = "SELECT * FROM `admin` WHERE `username`='" & txtUser.Text & "' AND `password`='" & txtPass.Text & "' "
            feesfindthis(sql)
            If GetNumRows() = 1 Then
                MsgBox("You are Logged in Successfully", MsgBoxStyle.Information)
                LoadSingleResult("login")



            Else
                lblError.Text = "Username or Passwrord is not correct, Please try again!!"
                lblError.Visible = True

            End If



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExt.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        Timer1.Enabled = True
    End Sub
End Class
