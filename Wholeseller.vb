﻿Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class Wholeseller

    Dim cn As OleDbConnection
    Dim cmd, cmd1 As OleDbCommand
    Dim adp As OleDbDataAdapter
    Public Shared ds As DataSet ' whole data shared to access data from diffrent table n in d   
    Public Shared dv As DataView ' abstract data 
    Dim cm As CurrencyManager
    Dim myReader As OleDbDataReader
    Dim choice As Integer


    Private Sub Wholeseller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        cmd = New OleDbCommand()
        cmd.Connection = cn 'oledbconnctn obj
        adp = New OleDbDataAdapter("select * from Wholesellermaster", cn)
        filldatasetanddataview()
        bindingfields()
        DataGridView1.Visible = False

    End Sub
    Private Sub filldatasetanddataview()
        ds = New DataSet()
        adp.Fill(ds, "Wholesellermaster")
        dv = New DataView(ds.Tables("Wholesellermaster"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)
        DataGridView1.DataSource = dv
        ' DataGridView1.Refresh()
    End Sub
    Private Sub bindingfields()
        TextBox1.DataBindings.Clear()
        TextBox2.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()


        TextBox1.DataBindings.Add("text", dv, "wname")
        TextBox2.DataBindings.Add("text", dv, "number")
        TextBox3.DataBindings.Add("text", dv, "city")
        TextBox4.DataBindings.Add("text", dv, "pincode")


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cm.Position = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cm.Position -= 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cm.Position += 1
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cm.Position = cm.Count - 1
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim str As String = TextBox5.Text
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Fields cannot be empty!") 'Inform User
        ElseIf Not Regex.Match(TextBox1.Text, "^[a-z,A-Z]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Wholeseller Org. Name must contain Characters Only!") 'Inform User
        ElseIf TextBox2.Text.Count < 10 Or TextBox2.Text.Count > 10 Then
            MsgBox("Invalid Mobile Number !")
        ElseIf Not Regex.Match(TextBox2.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Please Enter Numbers Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox3.Text, "^[a-z,A-Z]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("City Name must contain Characters Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox4.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Pincode must contain Numbers Only!") 'Inform User
        Else
            cmd.CommandText = "select * from Wholesellermaster where number='" & str & "'"
            cmd.Parameters.AddWithValue("@number", TextBox4.Text)
            cn.Open()
            myReader = cmd.ExecuteReader
            Do
                While myReader.Read()
                    TextBox1.Text = (myReader(0))
                    TextBox2.Text = (myReader(1))
                    TextBox3.Text = (myReader(2))
                    TextBox4.Text = (myReader(3))
                End While
            Loop While myReader.NextResult()
            myReader.Close()
            cn.Close()

            If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Customer not registered")
            End If
        End If

    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Fields cannot be empty!") 'Inform User
        ElseIf Not Regex.Match(TextBox1.Text, "^[a-z,A-Z]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Wholeseller Org. Name must contain Characters Only!") 'Inform User
        ElseIf TextBox2.Text.Count < 10 Or TextBox2.Text.Count > 10 Then
            MsgBox("Invalid Mobile Number !")
        ElseIf Not Regex.Match(TextBox2.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Please Enter Numbers Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox3.Text, "^[a-z,A-Z]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("City Name must contain Characters Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox4.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Pincode must contain Numbers Only!") 'Inform User
        Else
            Dim ip As Integer
            ip = cm.Position
            cmd.Connection = cn 'oledbconnctn obj
            cmd.CommandText = "insert into Wholesellermaster values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            filldatasetanddataview()
            bindingfields()
            cm.Position = ip
            MsgBox("Record added in Database")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click


        Dim cmd1 As New OleDbCommand("DELETE * FROM Wholesellermaster where number='" & TextBox2.Text & "'", cn)
        cn.Open()
        cmd1.ExecuteNonQuery()
        MsgBox("deleted")
        cn.Close()

        cmd.Connection = cn 'oledbconnctn obj
        cmd.CommandText = "insert into Wholesellermaster values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i, ctr As Integer
        Dim cmd As OleDbCommand = New OleDbCommand("delete from Wholesellermaster where wname=@wname,number=@number,city=@city,pincode=@pincode", cn)
        i = cm.Position
        If (i < 0) Then
            cmd.Parameters.AddWithValue("@wname", BindingContext(dv).Current("wname"))
            cn.Open()
            ctr = cmd.ExecuteNonQuery()
            cn.Close()
            filldatasetanddataview()
            bindingfields()

            If (ctr = 0) Then
                MsgBox("Record Not Found")
            Else
                MsgBox("Record Deleted from Database")
            End If
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub








    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Controls.Clear()
        InitializeComponent()
        Wholeseller_Load(e, e)

        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim submitres As MsgBoxResult
        submitres = MsgBox("Are sure you want to Exit?", MsgBoxStyle.YesNo)
        If submitres = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox5.Text = ""
    End Sub
End Class