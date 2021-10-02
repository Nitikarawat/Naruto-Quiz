Public Class Q4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If A4.Checked Then
            count = count + 1
        Else
            count = count + 0
        End If
        Me.Close()
        Q5.Show()
    End Sub
End Class