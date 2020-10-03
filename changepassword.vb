Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class changepassword
    Dim cn As OleDbConnection
    Dim cmd, cmd1 As OleDbCommand
    Dim myReader As OleDbDataReader
    Dim pass, newpass, oldpass, user, rights
    Private Sub changepassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        cmd = New OleDbCommand()
        cmd.Connection = cn 'oledbconnctn obj
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Dim query As String = "Select username from users"
        cn.Open()
        cmd = New OleDbCommand(query, cn)
        '......cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox1.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
    End Sub
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If ComboBox1.Text = "" Then
            MsgBox("Enter the Username")
        ElseIf TextBox1.Text = "" Then
            MsgBox("Enter the Old Password")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter the New Password")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Confirm the New Password first")


        Else
            cn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
            cmd1 = New OleDbCommand()
            cmd1.Connection = cn 'oledbconnctn obj
            Dim query1 As String = "Select * from users where username='" & ComboBox1.Text & "'"
            cn.Open()
            cmd1 = New OleDbCommand(query1, cn)
            myReader = cmd1.ExecuteReader
            Do
                While myReader.Read()
                    user = myReader(0)
                    oldpass = myReader(1)
                    rights = myReader(2)
                End While
            Loop While myReader.NextResult()
            myReader.Close()
            cn.Close()
            MsgBox(oldpass)
            MsgBox(TextBox1.Text)
            cmd = New OleDbCommand()
            cmd.Connection = cn 'oledbconnctn obj
            If (TextBox1.Text = oldpass) Then
                If (TextBox2.Text = TextBox3.Text) Then
                    Dim cmd1 As New OleDbCommand("DELETE password FROM users where username='" & ComboBox1.Text & "'", cn)
                    cn.Open()
                    cmd1.ExecuteNonQuery()
                    cn.Close()
                    cmd.Connection = cn 'oledbconnctn obj
                    cmd.CommandText = "insert into users values ('" & user & "','" & TextBox3.Text & "','" & rights & "')"
                    cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Password successfully changed")
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    ComboBox1.Text = ""
                Else
                    Label4.Visible = True
                    Label5.Visible = True
                    Label6.Visible = True
                    TextBox3.Focus() 'Return Focus
                    TextBox3.Clear() 'Clear TextBox
                End If
            Else
                MsgBox("Incorrect password")
                TextBox3.Focus() 'Return Focus
                TextBox3.Clear() 'Clear TextBox
            End If

        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Controls.Clear()
        InitializeComponent()
        changepassword_Load(e, e)

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
End Class