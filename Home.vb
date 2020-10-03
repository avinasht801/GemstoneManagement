Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class Home
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim cmd1, cmd2 As OleDbCommand
    Dim adp As OleDbDataAdapter
    Public Shared ds As DataSet ' whole data shared to access data from diffrent table n in d   
    Public Shared dv As DataView ' abstract data 
    Dim cm As CurrencyManager
    Dim myReader As OleDbDataReader
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        End
    End Sub
    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        cmd = New OleDbCommand()
        cmd.Connection = cn 'oledbconnctn obj
        'oledbconnctn
        Label2.Text = Login.tt.Text
        lowstock()
        Timer1.Enabled = True
    End Sub
    Private Sub lowstock()
        Dim count = 0
        Dim stock
        Dim query As String
        query = "Select stock from Gemmaster"
        cn.Open()
        cmd = New OleDbCommand(query, cn)
        '......cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                stock = Val(myReader(0))
                If (stock < 10) Then
                    count = 1
                End If
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()

        If (count = 1) Then
            Label19.Visible = True
        End If
    End Sub
    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        adminsignup.Show()
        Me.Hide()
    End Sub
    Private Sub DeleteUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Click
        DeleteUser.Show()
        Me.Hide()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        changepassword.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.tt.Text = ""
        Login.tbpasswd.Text = ""
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub AddProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductToolStripMenuItem.Click
        Sales_Form.Show()
        Me.Hide()
        Me.Controls.Clear()
        InitializeComponent()
        Home_Load(e, e)
    End Sub
    Private Sub ManageStocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageStocksToolStripMenuItem.Click
        product.Show()
        Me.Hide()
        Me.Controls.Clear()
        InitializeComponent()
        Home_Load(e, e)
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim submitres As MsgBoxResult
        submitres = MsgBox("Are sure you want to Exit?", MsgBoxStyle.YesNo)
        If submitres = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
        Me.Hide()
    End Sub
    Private Sub CustomerDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDetailsToolStripMenuItem1.Click
        Customer.Show()
        Me.Hide()
    End Sub
    Private Sub WholesellerDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WholesellerDetailsToolStripMenuItem.Click
        Wholeseller.Show()
        Me.Hide()
    End Sub
    Private Sub LowStockProductListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowStockProductListToolStripMenuItem.Click
        low_stock.Show()
        Me.Hide()
    End Sub
    Private Sub EmployeeDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        Me.Hide()
        Employee.Show()
    End Sub
    Private Sub SalesDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesDetailsToolStripMenuItem.Click
        Me.Hide()
        sales_History.Show()
    End Sub
    Private Sub PurchaseHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseHistoryToolStripMenuItem.Click
        Purchase_History.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerReportsToolStripMenuItem.Click
        Dim reportdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdoc = New CustomerReport
        Report.CrystalReportViewer1.ReportSource = reportdoc
        Report.ShowDialog()
        Report.Dispose()
    End Sub

    Private Sub WholesellerReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WholesellerReportsToolStripMenuItem.Click
        Dim reportdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdoc = New WholeSellerReport
        Report.CrystalReportViewer1.ReportSource = reportdoc
        Report.ShowDialog()
        Report.Dispose()
    End Sub

    Private Sub EmployeeReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeReportsToolStripMenuItem.Click
        Dim reportdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdoc = New EmployeeReport
        Report.CrystalReportViewer1.ReportSource = reportdoc
        Report.ShowDialog()
        Report.Dispose()
    End Sub

    Private Sub PurchaseReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReportsToolStripMenuItem.Click
        Dim reportdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdoc = New PurchaseHistoryReport
        Report.CrystalReportViewer1.ReportSource = reportdoc
        Report.ShowDialog()
        Report.Dispose()
    End Sub

    Private Sub SalesReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesReportsToolStripMenuItem.Click
        Dim reportdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdoc = New SalesHistoryReport
        Report.CrystalReportViewer1.ReportSource = reportdoc
        Report.ShowDialog()
        Report.Dispose()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Controls.Clear()
        InitializeComponent()
        Home_Load(e, e)
    End Sub

    Private Sub PurchaseGraphToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseGraphToolStripMenuItem.Click
        Dim reportdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdoc = New PurchaseHistoryReport
        Report.CrystalReportViewer1.ReportSource = reportdoc
        Report.ShowDialog()
        Report.Dispose()
    End Sub

    Private Sub SalesGraphToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesGraphToolStripMenuItem.Click
        Dim reportdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportdoc = New SalesHistoryReport
        Report.CrystalReportViewer1.ReportSource = reportdoc
        Report.ShowDialog()
        Report.Dispose()
    End Sub
End Class