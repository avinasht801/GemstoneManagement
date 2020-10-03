Imports CrystalDecisions.CrystalReports.Engine
Public Class Report
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cryRpt As New ReportDocument
        cryRpt.Load("D:\Gemstone Management\Code\Gemstone Management\Gemstone Management\Bill.rpt")
        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class
