Public Class Q3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If A3.Checked Then
            count = count + 1
        Else
            count = count + 0
        End If
        Me.Close()
        Q4.Show()
    End Sub
End Class