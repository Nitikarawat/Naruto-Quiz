Public Class Q5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If A5.Checked Then
            count = count + 1
        Else
            count = count + 0
        End If
        MessageBox.Show("Your Score :" & count & " ", "Result")
        Me.Close()
        goodbye.Show()
    End Sub

End Class