Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class cart
    Dim cn As OleDbConnection
    Dim cmd, cmd1 As OleDbCommand
    Dim adp As OleDbDataAdapter
    Public Shared ds As DataSet ' whole data shared to access data from diffrent table n in d   
    Public Shared dv As DataView ' abstract data 
    Dim cm As CurrencyManager
    Private Sub cart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Private Sub readagain()
        cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        cmd = New OleDbCommand()
        cmd.Connection = cn 'oledbconnctn obj
        adp = New OleDbDataAdapter("select gem_id,gemstone,color,cut,carat,price,quantity,total,totalwithtax from cart", cn)
        filldatasetanddataview()
    End Sub
    Private Sub filldatasetanddataview()
        ds = New DataSet()
        adp.Fill(ds, "cart")
        dv = New DataView(ds.Tables("cart"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)
        DataGridView1.DataSource = dv
        DataGridView1.Refresh()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Controls.Clear()
        InitializeComponent()
        cart_Load(e, e)

        Me.Hide()
        Sales_Form.Show()
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click      
        Dim reportdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdoc = New Bill
        Report.CrystalReportViewer1.ReportSource = reportdoc
        Report.ShowDialog()
        Report.Dispose()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim submitres As MsgBoxResult
        submitres = MsgBox("Are sure you want to Exit?", MsgBoxStyle.YesNo)
        If submitres = MsgBoxResult.Yes Then
            End
        End If
    End Sub
End Class