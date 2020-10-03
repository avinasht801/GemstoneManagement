Imports System.Data.OleDb
Public Class Forgotpassword
    Dim myReader As OleDbDataReader
    Dim user, pin, pass
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        If TextBox1.Text = "" Then
            MsgBox("Enter the Username")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter the Backup Pin")
        Else
            Dim cmd As OleDbCommand = New OleDbCommand("select * from users where username='" & TextBox1.Text & "' and pin='" & TextBox2.Text & "'", cn)
            cn.Open()
            myReader = cmd.ExecuteReader
            Do
                While myReader.Read()
                    user = (myReader(0))
                    pass = myReader(1)
                    pin = myReader(3)
                End While
            Loop While myReader.NextResult()
            myReader.Close()
            cn.Close()
            If user = TextBox1.Text And pin = TextBox2.Text Then
                MsgBox("Your Password is  ' " & pass & " '")
            Else
                MsgBox("Invalid username or Pin")
            End If
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Controls.Clear()
        InitializeComponent()
        Forgotpassword_Load(e, e)

        Me.Hide()
        Home.Show()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim submitres As MsgBoxResult
        submitres = MsgBox("Are sure you want to Exit?", MsgBoxStyle.YesNo)
        If submitres = MsgBoxResult.Yes Then
            End
        End If
    End Sub


    Private Sub Forgotpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class