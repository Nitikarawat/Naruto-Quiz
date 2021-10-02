Public Class Q1

    Private Sub Q1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome To Simple And Easy Quiz")
     
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If A1.Checked Then
            count = count + 1
        Else
            count = count + 0
        End If
        Me.Close()
        Q2.Show()
    End Sub
End Class