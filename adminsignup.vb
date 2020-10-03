Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class adminsignup
    Dim myReader As OleDbDataReader
    Dim user = ""
    Private Sub adminsignup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = ""
        ComboBox1.Items.Add("admin")
        ComboBox1.Items.Add("user")      
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        If TextBox1.Text = "" Then
            MsgBox("Enter the Username")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Enter the Password")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Enter the Backup Pin")
        ElseIf Not Regex.Match(TextBox3.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("PIN must contain Numbers Only!") 'Inform User
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Select the Access Rights")

        Else
            Dim cmd As OleDbCommand = New OleDbCommand("select * from users where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", cn)
            cn.Open()
            myReader = cmd.ExecuteReader
            Do
                While myReader.Read()
                    user = (myReader(0))
                End While
            Loop While myReader.NextResult()
            myReader.Close()
            cn.Close()
            If user = TextBox1.Text Then
                MsgBox("Employee already exists!!")
            Else
                cn.Open()
                Dim cmd1 As OleDbCommand = New OleDbCommand("insert into users values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "')", cn)
                cmd1.ExecuteNonQuery()
                cn.Close()
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                ComboBox1.Text = ""
                MsgBox("User Added")
            End If
        End If
       
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Controls.Clear()
        InitializeComponent()
        adminsignup_Load(e, e)

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

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class