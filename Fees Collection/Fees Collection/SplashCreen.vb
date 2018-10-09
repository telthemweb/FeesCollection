Public Class SplashCreen
    Private Sub SplashCreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashTimer.Enabled = True
        progy.Visible = True
        lblWait.Visible = True
    End Sub

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        progy.Increment(+1)
        If progy.Value = 100 Then
            SplashTimer.Stop()
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class