Public Class Q2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If A2.Checked Then
            count = count + 1
        Else
            count = count + 0
        End If
        Me.Close()
        Q3.Show()
    End Sub
End Class