Public Class StudentLists
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Student_Reg.Show()
        Me.Hide()
    End Sub

    Private Sub StudentLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        feesfindthis("SELECT `regNumber`, `name`,`surname`,`dateOfBirth`, `gender`, `nationality`, `class`, `term`, `address`, `fatherName`,`occupation`,`phone`,`date_registered` FROM `student_details`")
        LoadData(studentGrid, "STUDENTLIST")

    End Sub

    Private Sub studentGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentGrid.CellClick

        feesfindthis("SELECT * FROM `student_details` WHERE `regNumber`='" & studentGrid.CurrentRow.Cells(0).Value & "'")
            LoadSingleResult("student")


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try

            feesfindthis("SELECT * FROM `student_details` WHERE `regNumber`='" & txtSearch.Text & "' Or `name`='" & txtSearch.Text & "' Or `surname`='" & txtSearch.Text & "'")

            Dim kl = GetCount()
            If kl = 0 Then
                MsgBox("Record not found ", MsgBoxStyle.Critical)
                txtSearch.Text = ""
            Else
                LoadData(studentGrid, "payment")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub
End Class