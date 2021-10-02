Imports System.Data.SqlClient
Public Class LOGIN

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
    End Sub

    Private Sub Uname_Enter(sender As Object, e As EventArgs) Handles Uname.Enter
        Dim users As String = Uname.Text
        If users.Trim().ToLower() = "username" Or users.Trim() = " " Then
            Uname.Text = " "
            Uname.ForeColor = Color.Black
        End If
    End Sub


    Private Sub Password_Enter(sender As Object, e As EventArgs) Handles Password.Enter
        Dim pass As String = Password.Text
        If pass.Trim().ToLower() = "0000000" Or pass.Trim() = " " Then
            Password.Text = ""
            Password.ForeColor = Color.Black
            Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SurAj\Documents\Visual Studio 2013\Projects\Quiz Application vb\Quiz Application vb\DB.mdf;Integrated Security=True"
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        'Try
        objcon = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SurAj\Documents\Visual Studio 2013\Projects\Quiz Application vb\Quiz Application vb\DB.mdf;Integrated Security=True")
        objcon.Open()
        Dim stmt As String = "select * from register where Uname ='" & Uname.Text & "' AND Password ='" & Password.Text & "' "
        objcmd = New SqlCommand(stmt, objcon)
        Dim reader As SqlDataReader = objcmd.ExecuteReader
        If reader.Read Then
            MessageBox.Show("Login successfully", "Login")
            Me.Hide()
            Q1.Show()
        Else
            MessageBox.Show("Invalid Login Please Check!", "Error")
            Me.Show()
            Uname.Clear()
            Password.Clear()

        End If
        ' Catch ex As Exception
        '    MsgBox("MSSQL ERROR")
        'End Try
    End Sub

End Class