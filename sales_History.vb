Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class sales_History
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter
    Public Shared ds As DataSet ' whole data shared to access data from diffrent table n in d   
    Public Shared dv As DataView ' abstract data 
    Dim cm As CurrencyManager
    Dim myReader As OleDbDataReader

    Private Sub filldatasetanddataview()

        ds = New DataSet()
        adp.Fill(ds, "SalesHistory")

        dv = New DataView(ds.Tables("SalesHistory"))

        cm = CType(Me.BindingContext(dv), CurrencyManager)
        DataGridView1.DataSource = dv
        DataGridView1.Refresh()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        Dim x As String
        x = Trim(ComboBox1.Text)
        dv.RowFilter = "purchase_date like'" & x & "%'"
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox1.Text = ""
        ComboBox2.Text = ""

        Dim x As String
        x = Trim(ComboBox3.Text)
        dv.RowFilter = "fname like'" & x & "%'"
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox1.Text = ""

        ComboBox3.Text = ""
        Dim x As String
        x = Trim(ComboBox2.Text)
        dv.RowFilter = "gemstone like'" & x & "%'"
    End Sub





    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Controls.Clear()
        InitializeComponent()
        sales_History_Load(e, e)

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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Controls.Clear()
        InitializeComponent()
        sales_History_Load(e, e)
    End Sub
    Private Sub sales_History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        'DataGridView1.Refresh()
        cmd = New OleDbCommand()
        cmd.Connection = cn 'oledbconnctn obj
        adp = New OleDbDataAdapter("select * from SalesHistory", cn)
        cn.Open()
        cmd = New OleDbCommand("Select distinct (purchase_date) from SalesHistory", cn)
        '......cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox1.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()


        cn.Open()
        cmd = New OleDbCommand("Select distinct (gemstone) from SalesHistory", cn)
        '......cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox2.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()


        cn.Open()
        cmd = New OleDbCommand("Select distinct (fname) from SalesHistory", cn)
        '......cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox3.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
        filldatasetanddataview()
    End Sub
End Class