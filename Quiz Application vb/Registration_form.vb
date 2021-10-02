Imports System.Data.SqlClient
Public Class Registration_form
    Private Sub Registration_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox2
        Label3.Parent = PictureBox2
        Label4.Parent = PictureBox2
        Label5.Parent = PictureBox2
        Label6.Parent = PictureBox2
        Label7.Parent = PictureBox2
        Label8.Parent = PictureBox2
        Label9.Parent = PictureBox2
        Label10.Parent = PictureBox2
        Label11.Parent = PictureBox2
        Label12.Parent = PictureBox2
        Label13.Parent = PictureBox2
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Try
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\SurAj\Documents\Visual Studio 2013\Projects\Quiz Application vb\Quiz Application vb\DB.mdf;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from register where mail='" & mail.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Email Id Already Registered", MsgBoxStyle.Critical, "Error: Try Again")
            con.Close()
            
            Else
                con.Close()
                con.Open()
            cmd = New SqlCommand("INSERT INTO register values('" & Fname.Text & "','" & Lname.Text & "','" & Uname.Text & "','" & mail.Text & "','" & gender.Text & "','" & country.Text & "','" & code.Text & "','" & phno.Text & "','" & Password.Text & "')", con)
            If (Fname.Text = String.Empty Or Lname.Text = String.Empty Or Uname.Text = String.Empty Or mail.Text = String.Empty Or gender.Text = String.Empty Or country.Text = String.Empty Or code.Text = String.Empty Or phno.Text = String.Empty Or Password.Text = String.Empty) Then
                MessageBox.Show("Please enter the details", "ERROR")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                Me.Hide()
                LOGIN.Show()
                Fname.Clear()
                Lname.Clear()
                Uname.Clear()
                mail.Clear()
                gender.Text = " "
                country.Text = " "
                code.Text = " "
                phno.Clear()
                Password.Clear()
            End If
            con.Close()
        End If
        con.Close()
        '        Catch ex As Exception
        'MsgBox("Error")
        'End Try
    End Sub
End Class