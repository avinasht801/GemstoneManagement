Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class Purchase_History
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter
    Public Shared ds As DataSet ' whole data shared to access data from diffrent table n in d   
    Public Shared dv As DataView ' abstract data 
    Dim cm As CurrencyManager
    Dim myReader As OleDbDataReader
    Private Sub Purchase_History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        'DataGridView1.Refresh()
        cmd = New OleDbCommand()
        cmd.Connection = cn 'oledbconnctn obj
        adp = New OleDbDataAdapter("select * from Gemmaster", cn)
        cn.Open()
        cmd = New OleDbCommand("Select distinct (gemstone) from Gemmaster", cn)
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
        cmd = New OleDbCommand("Select distinct(wname) from Gemmaster", cn)
        '......cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox2.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
        filldatasetanddataview()
    End Sub
    Private Sub filldatasetanddataview()
        ds = New DataSet()
        adp.Fill(ds, "Gemmaster")
        dv = New DataView(ds.Tables("Gemmaster"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)
        DataGridView1.DataSource = dv
        DataGridView1.Refresh()

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Controls.Clear()
        InitializeComponent()
        Purchase_History_Load(e, e)

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
        Purchase_History_Load(e, e)
    End Sub
End Class