Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class low_stock
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter
    Public Shared ds As DataSet ' whole data shared to access data from diffrent table n in d   
    Public Shared dv As DataView ' abstract data 
    Dim cm As CurrencyManager
    Dim myReader As OleDbDataReader
    Dim count = 0
    Dim stock
    Dim listlen
    Dim i = 0
    Dim gid, gname, color, cut, carat, price, stk1, wnam
    Private Sub low_stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Visible = False
        ListBox2.Visible = False
        ListBox3.Visible = False
        cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        cmd = New OleDbCommand()
        cmd.Connection = cn 'oledbconnctn obj
        Dim cmd1 As New OleDbCommand("DELETE * FROM lowstock", cn)
        cn.Open()
        cmd1.ExecuteNonQuery()
        cn.Close()
        listlen = ListBox1.Items.Count
        cn.Open()
        cmd = New OleDbCommand("Select gem_id,stock from Gemmaster", cn)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ListBox1.Items.Add(myReader(0))
                ListBox2.Items.Add(myReader(1))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
        low()
        Dim listlen1 = ListBox3.Items.Count
        listlen = ListBox1.Items.Count
        cmd.Connection = cn 'oledbconnctn obj
        For j = 0 To listlen1 - 1
            cn.Open()
            cmd = New OleDbCommand("Select * from Gemmaster where gem_id='" & ListBox3.Items.Item(j) & "'", cn)
            myReader = cmd.ExecuteReader
            Do
                While myReader.Read()
                    gid = myReader(0)
                    gname = myReader(1)
                    color = myReader(2)
                    cut = myReader(3)
                    carat = myReader(4)
                    price = myReader(5)
                    stk1 = Val(myReader(6))
                    wnam = myReader(7)
                End While
            Loop While myReader.NextResult()
            myReader.Close()
            cn.Close()

            cmd.CommandText = "insert into lowstock values ('" & ListBox3.Items.Item(j) & "','" & gname & "','" & color & "','" & cut & "','" & carat & "','" & price & "','" & stk1 & "','" & wnam & "')"
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Next

        cn.Open()
        cmd = New OleDbCommand("Select distinct (gemstone) from lowstock", cn)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox1.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()

        cn.Open()
        cmd = New OleDbCommand("Select distinct (wname) from lowstock", cn)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox2.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()

        adp = New OleDbDataAdapter("select * from lowstock", cn)
        filldatasetanddataview()
    End Sub
    Private Sub filldatasetanddataview()
        ds = New DataSet()
        adp.Fill(ds, "lowstock")
        dv = New DataView(ds.Tables("lowstock"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)
        DataGridView1.DataSource = dv
        DataGridView1.Refresh()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Controls.Clear()
        InitializeComponent()
        low_stock_Load(e, e)

        Me.Hide()
        Home.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        ComboBox2.Text = ""
        Dim x As String
        x = Trim(ComboBox1.Text)
        dv.RowFilter = "gemstone like'" & x & "%'"
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox1.Text = ""
        Dim x As String
        x = Trim(ComboBox2.Text)
        dv.RowFilter = "wname like'" & x & "%'"
    End Sub
    Private Sub low()
        Dim j = 0
        listlen = ListBox1.Items.Count
        cn.Open()
        cmd = New OleDbCommand("Select gem_id,stock from Gemmaster", cn)
        '......cmd.Connection = cn


        myReader = cmd.ExecuteReader
        For j = 0 To listlen - 1

            Do
                While myReader.Read()
                    Dim strr = Val(myReader(1))

                    If strr < 10 Then


                        'ComboBox1.Items.Add(ListBox1.Items.Item(i))
                        ListBox3.Items.Add(myReader(0))
                    End If
                End While
            Loop While myReader.NextResult()

        Next
        myReader.Close()
        cn.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim submitres As MsgBoxResult
        submitres = MsgBox("Are sure you want to Exit?", MsgBoxStyle.YesNo)
        If submitres = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Controls.Clear()
        InitializeComponent()
        low_stock_Load(e, e)
    End Sub
End Class