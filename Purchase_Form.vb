Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic


Public Class Purchase_Form
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim cmd1, cmd2 As OleDbCommand
    Dim adp As OleDbDataAdapter
    Public Shared ds As DataSet ' whole data shared to access data from diffrent table n in d   
    Public Shared dv As DataView ' abstract data 
    Dim cm As CurrencyManager
    Dim myReader As OleDbDataReader
    Dim i As Integer


    Private Sub Purchase_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim datetoday As String
        'datetoday = Date.Now()
        
        Label17.Text = DateAndTime.Today
        cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")



        cmd = New OleDbCommand()
        cmd.Connection = cn 'oledbconnctn obj
       'oledbconnctn
        adp = New OleDbDataAdapter("select * from PurchaseHistory", cn)
        filldatasetanddataview()

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox3.Items.Clear()
        TextBox5.Text = ""

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()


        'cn.Open()
        'cmd = New OleDbCommand("Select gem_id,gemstone,stock from Gemmaster where stock < 10", cn)
        '......cmd.Connection = cn
        ' myReader = cmd.ExecuteReader
        ' Do
        '     While myReader.Read()
        '  Dim idstr = (myReader(0))
        ' Dim gemstr = (myReader(1))
        ' Dim stockstr = (myReader(2))
        '  MsgBox(idstr)
        '     End While
        '  Loop While myReader.NextResult()
        ' myReader.Close()

        ' cn.Close()
        cn.Open()
        cmd = New OleDbCommand("Select distinct (Gemstone) from Gemmaster", cn)
        '......cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox1.Items.Add(myReader(0))


            End While

        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
        Dim cmd1 As New OleDbCommand("DELETE * FROM CART", cn)
        cn.Open()
        cmd1.ExecuteNonQuery()
        cn.Close()
        cart.DataGridView1.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox3.Items.Clear()
        Label6.Text = 0

        cn.Open()
        cmd = New OleDbCommand("Select distinct (Gemstone) from Gemmaster", cn)
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




    Private Sub filldatasetanddataview()

        ds = New DataSet()
        adp.Fill(ds, "Purchasehistory")

        dv = New DataView(ds.Tables("Purchasehistory"))

        cm = CType(Me.BindingContext(dv), CurrencyManager)
        DataGridView1.DataSource = dv
        DataGridView1.Refresh()

    End Sub

    Private Sub temptable()
       

        Dim listlen = ListBox1.Items.Count
        Dim i = 0
        cmd1 = New OleDbCommand()
        cmd1.Connection = cn
        For i = 0 To listlen - 1

            cmd1.CommandText = "insert into cart values ('" & Label17.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "','" & ListBox6.Items.Item(i) & "','" & ListBox1.Items.Item(i) & "','" & ListBox2.Items.Item(i) & "','" & ListBox3.Items.Item(i) & "','" & ListBox4.Items.Item(i) & "','" & Label6.Text & "','" & ListBox5.Items.Item(i) & "','" & Label10.Text & "')"

            cn.Open()
            cmd1.ExecuteNonQuery()
            cn.Close()
            filldatasetanddataview()
            cart.DataGridView1.Refresh()

        Next
    End Sub
    Private Sub finaltable()
        Dim listlen = ListBox1.Items.Count
        Dim i = 0


        For i = 0 To listlen - 1

            cmd.CommandText = "insert into Purchasehistory values ('" & Label17.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "','" & ListBox6.Items.Item(i) & "','" & ListBox1.Items.Item(i) & "','" & ListBox2.Items.Item(i) & "','" & ListBox3.Items.Item(i) & "','" & ListBox4.Items.Item(i) & "','" & Label6.Text & "','" & ListBox5.Items.Item(i) & "')"
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            filldatasetanddataview()
            DataGridView1.Refresh()

        Next
    End Sub

    Private Sub updatestock()

        Dim stk1
        Dim str1 As String = ComboBox1.Text
        Dim str2 As String = ComboBox2.Text
        Dim str3 As String = ComboBox3.Text
        Dim str4 As String = ComboBox4.Text
        Dim listlen = ListBox1.Items.Count
        Dim i = 0

        cmd = New OleDbCommand()
        cmd.Connection = cn

        For i = 0 To listlen - 1
            Dim query As String = "Select stock from Gemmaster where Carat='" & ListBox4.Items.Item(i) & "' and Cut='" & ListBox3.Items.Item(i) & "' and Color='" & ListBox2.Items.Item(i) & "' and Gemstone='" & ListBox1.Items.Item(i) & "'"
            cn.Open()
            cmd2 = New OleDbCommand(query, cn)
            '......cmd.Connection = cn
            myReader = cmd2.ExecuteReader
            Do
                While myReader.Read()
                    stk1 = Val(myReader(0))
                    MsgBox(stk1)
                End While

            Loop While myReader.NextResult()
            myReader.Close()
            cn.Close()
            Dim updatedstk = stk1 - Val(ListBox5.Items.Item(i))
            'Dim i, ctr As Integer
            MsgBox(updatedstk)
            cmd2.CommandText = "update Gemmaster set stock='" & updatedstk & "' where Carat='" & str4 & "' and Cut='" & str3 & "' and Color='" & str2 & "' and Gemstone='" & str1 & "'"

            ' i = cm.Position = 1
            ' If (i >= 0) Then
            'cmd.Parameters.AddWithValue("@Name1", BindingContext(dv).Current("FirstName"))
            cn.Open()
            cmd2.ExecuteNonQuery()
            MessageBox.Show("    Record Updated    ")
            cn.Close()

        Next
    End Sub

    Private Sub chkstock()
        Dim i = 0
        Dim stk
        Dim total
        Dim str1 As String = ComboBox1.Text
        Dim str2 As String = ComboBox2.Text
        Dim str3 As String = ComboBox3.Text
        Dim str4 As String = ComboBox4.Text
        Dim query As String = "Select stock from Gemmaster where Carat='" & str4 & "' and Cut='" & str3 & "' and Color='" & str2 & "' and Gemstone='" & str1 & "'"
        cn.Open()
        cmd = New OleDbCommand(query, cn)
        '......cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                stk = Val(myReader(0))
                MsgBox(stk)
            End While

        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
        Dim updatedstk = stk - Val(TextBox5.Text)
        MsgBox(updatedstk)
        If (updatedstk < 0) Then
            MsgBox("Available stock is less than the required stock")
            TextBox5.Focus() 'Return Focus
            TextBox5.Clear() 'Clear TextBox
        Else
            ListBox1.Items.Add(ComboBox1.Text)
            ListBox2.Items.Add(ComboBox2.Text)
            ListBox3.Items.Add(ComboBox3.Text)
            ListBox4.Items.Add(ComboBox4.Text)
            ListBox5.Items.Add(TextBox5.Text)
            ListBox6.Items.Add(TextBox6.Text)

            total = Val(Label6.Text) * Val(TextBox5.Text)
            Label8.Text = Val(Label8.Text) + Val(TextBox5.Text)
            Label10.Text = Val(Label10.Text) + total
        End If

    End Sub

    Private Sub chkrights()
        Dim right
        Dim user = ""
        user = Login.tt.Text



      
        Dim query As String = "Select rights from users where username='" & user & "'"
        cn.Open()
        cmd = New OleDbCommand(query, cn)
        '......cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                right = myReader(0)
                MsgBox(right)
            End While

        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
        Dim msgres As MsgBoxResult
        If (right = "user") Then

            msgres = MsgBox("Login as Admin!!", MsgBoxStyle.YesNo)
            If msgres = MsgBoxResult.Yes Then
                Me.Hide()
                Login.Show()
            End If
        Else
            Me.Hide()
            Customer.Show()
        End If

        user = ""


    End Sub

    Private Sub Purchase_Form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Environment.Exit(0)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click


        If ComboBox1.Text = "" Then
            MsgBox("Select a Gemstone first! ")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Select a Gemstone color you require! ")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Select a Gemstone cut you require! ")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Select a  Gemstone carat you require! ")
        ElseIf TextBox5.Text = "" Then
            MsgBox("Enter a Gemstone quantity first! ")
        ElseIf Not Regex.Match(TextBox5.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only alphabets

            MsgBox("Please Enter Numbers Only!") 'Inform User

            TextBox5.Focus() 'Return Focus
            TextBox5.Clear() 'Clear TextBox

        Else
            chkstock()


        End If
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            ComboBox4.Items.Clear()
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox3.Text = ""
            ComboBox4.Text = ""

            TextBox5.Text = ""
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        i = ListBox1.SelectedIndex

        If ListBox1.Items.Count = 0 Then
            MsgBox("Cart is Empty")
        ElseIf i = -1 Then
            MsgBox("Select the Gemstone you want to delete")
        Else
            ListBox1.Items.RemoveAt(i)
            ListBox2.Items.RemoveAt(i)
            ListBox3.Items.RemoveAt(i)
            ListBox4.Items.RemoveAt(i)
            ListBox5.Items.RemoveAt(i)
        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        Label6.Text = 0
        Label8.Text = 0
        Label10.Text = 0
        TextBox5.Text = ""
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim submitres As MsgBoxResult
        ' ip = cm.Position
        cmd.Connection = cn 'oledbconnctn obj
        If ListBox1.Items.Count = 0 Then
            MsgBox("Cart is Empty!!!")
        Else
            submitres = MsgBox("Do you want to submit ??", MsgBoxStyle.YesNo)
            If submitres = MsgBoxResult.Yes Then
                ' customer_form.show()
                finaltable()
                temptable()
                updatestock()

                Me.Hide()
                cart.Show()
            End If





           

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label6.Text = 0
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox2.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox3.Items.Clear()

        Dim str1 As String = ComboBox1.Text
        Dim str2 As String = ComboBox2.Text
        Dim query As String = "Select distinct(Color) from Gemmaster where Gemstone='" & str1 & "'"
        'cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=G:\day7\Customer.accdb")
        cn.Open()
        cmd = New OleDbCommand(query, cn)
        'cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox2.Items.Add(myReader(0))


            End While

        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label6.Text = 0
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox4.Items.Clear()
        ComboBox3.Items.Clear()

        Dim str1 As String = ComboBox1.Text
        Dim str2 As String = ComboBox2.Text
        Dim str3 As String = ComboBox3.Text
        Dim query As String = "Select distinct(Cut) from Gemmaster where Color='" & str2 & "' and Gemstone='" & str1 & "'"
        'cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=G:\day7\Customer.accdb")
        cn.Open()
        cmd = New OleDbCommand(query, cn)
        'cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox3.Items.Add(myReader(0))


            End While

        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Label6.Text = 0
        ComboBox4.Text = ""
        ComboBox4.Items.Clear()
        Dim str1 As String = ComboBox1.Text
        Dim str2 As String = ComboBox2.Text
        Dim str3 As String = ComboBox3.Text
        Dim str4 As String = ComboBox4.Text
        Dim query As String = "Select distinct(Carat) from Gemmaster where Cut='" & str3 & "' and Color='" & str2 & "' and Gemstone='" & str1 & "'"
        cn.Open()
        cmd = New OleDbCommand(query, cn)
        'cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox4.Items.Add(myReader(0))

            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
    End Sub


    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Label6.Text = 0
        Dim str1 As String = ComboBox1.Text
        Dim str2 As String = ComboBox2.Text
        Dim str3 As String = ComboBox3.Text
        Dim str4 As String = ComboBox4.Text
        Dim query As String = "Select distinct(Price),gem_id from Gemmaster where Carat='" & str4 & "' and Cut='" & str3 & "' and Color='" & str2 & "' and Gemstone='" & str1 & "'"
        cn.Open()
        cmd = New OleDbCommand(query, cn)
        'cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                Label6.Text = (myReader(0))
                TextBox6.Text = (myReader(1))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Sub Button6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox3.Text = "" Then
            MsgBox("Enter Mobile Number first!")
        ElseIf TextBox3.Text.Count < 10 Then
            MsgBox("Invalid Mobile Number !")
            'ElseIf count = 0 Then
            ' MsgBox(" Mobile Number should contain only numbers ")
        ElseIf Not Regex.Match(TextBox3.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then 'Only numbers

            MessageBox.Show("Please Enter Numbers Only!") 'Inform User

            TextBox3.Focus() 'Return Focus
            TextBox3.Clear() 'Clear TextBox


        Else
            cn.Open()
            cmd.CommandText = "select fname,mname,lname from Customermaster where number=@number"
            cmd.Parameters.AddWithValue("@number", TextBox3.Text)

            myReader = cmd.ExecuteReader
            Do
                While myReader.Read()
                    TextBox1.Text = (myReader(0))
                    TextBox4.Text = (myReader(1))
                    TextBox2.Text = (myReader(2))
                End While
            Loop While myReader.NextResult()
            myReader.Close()
            cn.Close()
            Dim msgres As MsgBoxResult

            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Customer not registered")
                msgres = MsgBox("Register the Customer??", MsgBoxStyle.YesNo)
                If msgres = MsgBoxResult.Yes Then

                    chkrights()
                End If
            End If
        End If
    End Sub


End Class
