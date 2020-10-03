Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class product
    Dim cn As OleDbConnection
    Dim cmd, cmd1 As OleDbCommand
    Dim adp As OleDbDataAdapter
    Public Shared ds As DataSet ' whole data shared to access data from diffrent table n in d   
    Public Shared dv As DataView ' abstract data 
    Dim cm As CurrencyManager
    Dim myReader As OleDbDataReader
    Dim choice
    Dim wname
    Dim counter = 0

    Private Sub product_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        cmd = New OleDbCommand()
        cmd.Connection = cn 'oledbconnctn obj
        adp = New OleDbDataAdapter("select * from Gemmaster", cn)
        filldatasetanddataview()
        bindingfields()
        DataGridView1.Visible = False
        TextBox8.Enabled = False
    End Sub
    Private Sub filldatasetanddataview()
        ds = New DataSet()
        adp.Fill(ds, "Gemmaster")
        dv = New DataView(ds.Tables("Gemmaster"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)
        DataGridView1.DataSource = dv
    End Sub
    Private Sub bindingfields()
        TextBox1.DataBindings.Clear()
        TextBox2.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        TextBox5.DataBindings.Clear()
        TextBox6.DataBindings.Clear()
        TextBox8.DataBindings.Clear()
        TextBox9.DataBindings.Clear()

        TextBox8.DataBindings.Add("text", dv, "gem_id")
        TextBox1.DataBindings.Add("text", dv, "gemstone")
        TextBox2.DataBindings.Add("text", dv, "color")
        TextBox3.DataBindings.Add("text", dv, "cut")
        TextBox4.DataBindings.Add("text", dv, "carat")
        TextBox5.DataBindings.Add("text", dv, "price")
        TextBox6.DataBindings.Add("text", dv, "stock")
        TextBox9.DataBindings.Add("text", dv, "wname")
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
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        choice = "GEMSTONE"
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        choice = "COLOUR"
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        choice = "CUT"
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        choice = "CARAT"
    End Sub
    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        choice = "STOCK"
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim intpos As Integer
        Select Case choice

            Case "GEMSTONE"
                dv.Sort = "gemstone"
                intpos = dv.Find(Trim(TextBox7.Text))
                If intpos = -1 Then
                    MessageBox.Show("Record Not Found")

                Else
                    cm.Position = intpos
                End If

            Case "COLOR"
                dv.Sort = "color"
                intpos = dv.Find(Trim(TextBox7.Text))
                If intpos = -1 Then
                    MessageBox.Show("Record Not Found")

                Else
                    cm.Position = intpos
                End If

            Case "CUT"
                dv.Sort = "cut"
                intpos = dv.Find(Trim(TextBox6.Text))
                If intpos = -1 Then
                    MessageBox.Show("Record Not Found")

                Else
                    cm.Position = intpos
                End If

            Case "CARAT"
                dv.Sort = "carat"
                intpos = dv.Find(Trim(TextBox7.Text))
                If intpos = -1 Then
                    MessageBox.Show("Record Not Found")

                Else
                    cm.Position = intpos
                End If

            Case "STOCK"
                dv.Sort = "stock"
                intpos = dv.Find(Trim(TextBox7.Text))
                If intpos = -1 Then
                    MessageBox.Show("Record Not Found")

                Else
                    cm.Position = intpos
                End If

        End Select
        TextBox7.Text = ""
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Select Case choice

            Case "GEMSTONE"
                dv.Sort = "gemstone"

            Case "COLOUR"
                dv.Sort = "color"

            Case "CUT"
                dv.Sort = "cut"

            Case "CARAT"
                dv.Sort = "carat"

            Case "STOCK"
                dv.Sort = "stock"

        End Select
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        
        If TextBox1.Text = "" Or TextBox8.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MessageBox.Show("Fields cannot be empty!") 'Inform User
        ElseIf Not Regex.Match(TextBox1.Text, "^[a-z,A-Z]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Name must contain Characters Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox8.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gem ID must contain Numbers Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox2.Text, "^[a-z,A-Z]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Color must contain Characters Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox3.Text, "^[a-z,A-Z]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Cut must contain Characters Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox4.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Carat must contain Numbers Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox5.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Carat must contain Numbers Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox6.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Carat must contain Numbers Only!") 'Inform User


        Else
            cmd.CommandText = "select wname from Wholesellermaster"
            cn.Open()
            myReader = cmd.ExecuteReader
            Do
                While myReader.Read()
                    wname = (myReader(0))
                    If (wname = TextBox9.Text) Then
                        counter = 0
                        Exit While
                    Else
                        counter = counter + 1
                    End If
                End While
            Loop While myReader.NextResult()
            myReader.Close()
            cn.Close()
            Dim counter1 = 0
            Dim ip As Integer
            If (counter = 0) Then
                ip = cm.Position
                cmd.Connection = cn 'oledbconnctn obj
                cmd.CommandText = "insert into Gemmaster values (@Gem_id,@Gemstone,@Color,@Cut,@Carat,@Price,@Stock,@wname)"
                cmd.Parameters.AddWithValue("@Gem_id", TextBox8.Text)
                cmd.Parameters.AddWithValue("@Gemstone", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Color", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Cut", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Carat", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Price", TextBox5.Text)
                cmd.Parameters.AddWithValue("@Stock", TextBox6.Text)
                cmd.Parameters.AddWithValue("@wname", TextBox9.Text)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                filldatasetanddataview()
                bindingfields()
                cm.Position = ip

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
            ElseIf counter1 = 0 Then
                Dim msgres As MsgBoxResult
                MsgBox("Wholeseller Organization not registered")
                msgres = MsgBox("Register the Wholeseller??", MsgBoxStyle.YesNo)
                If msgres = MsgBoxResult.Yes Then
                    Me.Hide()
                    Wholeseller.Show()
                End If
            End If
        End If
        Me.Controls.Clear()
        InitializeComponent()
        product_Load(e, e)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i, ctr As Integer
        Dim cmd As OleDbCommand = New OleDbCommand("delete from Gemmaster where Gem_id=@Gem_id,Gemstone=@Gemstone,Color=@Color,Cut=@Cut,Carat=@Carat,Price=@Price,Stock=@Stock,wname=@wname", cn)
        i = cm.Position
        If (i < 0) Then
            cmd.Parameters.AddWithValue("@Gemstone", BindingContext(dv).Current("Gemstone"))
            cn.Open()
            ctr = cmd.ExecuteNonQuery()
            cn.Close()
            filldatasetanddataview()
            bindingfields()
            If (ctr = 0) Then
                MsgBox("Record Not Found")
            Else
                MessageBox.Show("Record Deleted from Database")
            End If
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox1.Text = "" Or TextBox8.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MessageBox.Show("Fields cannot be empty!") 'Inform User
        ElseIf Not Regex.Match(TextBox1.Text, "^[a-z,A-Z]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Name must contain Characters Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox8.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gem ID must contain Numbers Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox2.Text, "^[a-z,A-Z]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Color must contain Characters Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox3.Text, "^[a-z,A-Z]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Cut must contain Characters Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox4.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Carat must contain Numbers Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox5.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Carat must contain Numbers Only!") 'Inform User
        ElseIf Not Regex.Match(TextBox6.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only number
            MessageBox.Show("Gemstone Carat must contain Numbers Only!") 'Inform User


        Else
            Dim cmd As OleDbCommand = New OleDbCommand("update Gemmaster set gem_id='" & TextBox8.Text & "',gemstone='" & TextBox1.Text & "',color='" & TextBox2.Text & "',cut='" & TextBox3.Text & "',carat='" & TextBox4.Text & "',price='" & TextBox5.Text & "',stock='" & TextBox6.Text & "',wname='" & TextBox9.Text & "'where gem_id='" & TextBox8.Text & "'", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            filldatasetanddataview()
            bindingfields()
            MessageBox.Show("    Record Updated    ")
        End If
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Controls.Clear()
        InitializeComponent()
        product_Load(e, e)
        Me.Hide()
        Home.Show()
        '  Home.ResetText()
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Controls.Clear()
        InitializeComponent()
        product_Load(e, e)
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""

        Dim id = 0, prid = 0
        cmd.CommandText = "select gem_id from Gemmaster"
        cn.Open()
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()

                id = Val(myReader(0))
                If (id > prid) Then
                    prid = id

                End If
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
        MsgBox(prid)
        TextBox8.Text = prid + 1
    End Sub
    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim submitres As MsgBoxResult
        submitres = MsgBox("Are sure you want to Exit?", MsgBoxStyle.YesNo)
        If submitres = MsgBoxResult.Yes Then
            End
        End If
    End Sub


End Class