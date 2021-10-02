Public Class goodbye

    Private Sub goodbye_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As Integer
        Label2.Text = count
        Label2.ForeColor = Color.Firebrick
        r = count
        Select Case r
            Case 1
                Label3.Text = "You don't love Naruto Series?"
            Case 2
                Label3.Text = "Aleast you didn't scored 1 or 0 :)"
            Case 3
                Label3.Text = "You almost had it :("
            Case 4
                Label3.Text = "Oops but not bad you had it :))"
            Case 5
                Label3.Text = "Congo!!!!!!! you are indeed Narutard (^O^)"
            Case Else
                MessageBox.Show("WHATS SOMETHINGS WRONG", "???")
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Believe It", "BYE FAM")
        Me.Close()
    End Sub
End Class