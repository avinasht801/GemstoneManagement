Imports System.Data.OleDb
Public Class Login
    Dim tm As Integer = 0
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter
    Dim myReader As OleDbDataReader
    Dim cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=D:\Project Work\Gemstone Management\Database\Gemstone.accdb")
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim txtuser = tt.Text
        Dim txtpass = tbpasswd.Text
        Dim user = "", pass = "", rights = ""
        Dim cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand("select * from [users] where username = '" & txtuser & "' AND password = '" & txtpass & "'", cn)
        cn.Open()
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                user = (myReader(0))
                pass = (myReader(1))
                rights = (myReader(2))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()

        If tt.Text = "" Or tbpasswd.Text = "" Then
            MsgBox("Fields cannot be empty")
        ElseIf tt.Text = user And tbpasswd.Text = pass And rights = "admin" Then
            ProgressBar1.Visible = True
            ProgressBar1.Increment(1000)
            Timer1.Start()
            Me.Hide()
            

            Home.Show()
            Home.AddUserToolStripMenuItem.Enabled = True
            Home.DeleteUserToolStripMenuItem.Enabled = True
            Home.PurchaseHistoryToolStripMenuItem.Enabled = True
            Home.SalesDetailsToolStripMenuItem.Enabled = True
            Home.EmployeeDetailsToolStripMenuItem.Enabled = True
            ' Home.CustomerReportsToolStripMenuItem.Enabled = True
            Home.WholesellerReportsToolStripMenuItem.Enabled = True
            ' Home.WholesellerReportsToolStripMenuItem.Enabled = True
            Home.PurchaseReportsToolStripMenuItem.Enabled = True
            Home.SalesReportsToolStripMenuItem.Enabled = True
        ElseIf tt.Text = user And tbpasswd.Text = pass And rights = "user" Then
            ProgressBar1.Visible = True
            ProgressBar1.Increment(1000)
            Timer1.Start()
            Me.Hide()
            Home.Label2.Text = txtuser
            Home.Show()
            Home.AddUserToolStripMenuItem.Enabled = False
            Home.DeleteUserToolStripMenuItem.Enabled = False
            Home.PurchaseHistoryToolStripMenuItem.Enabled = False
            Home.SalesDetailsToolStripMenuItem.Enabled = False
            Home.EmployeeReportsToolStripMenuItem.Enabled = False
            Home.PurchaseReportsToolStripMenuItem.Enabled = False
            Home.SalesReportsToolStripMenuItem.Enabled = False
        Else
            MsgBox("Invalid Username or Password")
        End If
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
        Me.Controls.Clear()
        InitializeComponent()
        Login_Load(e, e)
    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbpasswd.UseSystemPasswordChar = True
        ProgressBar1.Visible = False
        tt.Text = ""
        tbpasswd.Text = ""
        tt.Focus()

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tm = tm + 1
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim submitres As MsgBoxResult
        submitres = MsgBox("Are sure you want to Exit?", MsgBoxStyle.YesNo)
        If submitres = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            tbpasswd.UseSystemPasswordChar = False
        Else
            tbpasswd.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Forgotpassword.Show()
    End Sub


End Class