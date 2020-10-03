Imports System.Data.OleDb
Public Class DeleteUser
    Dim myReader As OleDbDataReader
    Private Sub DeleteUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand("select * from users", cn)
        cn.Open()
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox1.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        cn.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn = New OleDbConnection("provider=Microsoft.Ace.OLEDB.12.0;data source=C:\Gemstone Management\Database\Gemstone.accdb")
        If ComboBox1.Text = "" Then
            MsgBox("Enter the Username first")
        Else
            Dim msgres As String
            If ComboBox1.Text = "" Then
                msgres = MsgBox("Select the user first!!")
            Else
                Dim ctr As Integer
                Dim cmd1 As OleDbCommand = New OleDbCommand("delete from users where Username='" & ComboBox1.Text & "'", cn)
                cn.Open()
                ctr = cmd1.ExecuteNonQuery()
                cn.Close()

                If (ctr = 0) Then
                    MsgBox("Record Not Found")
                Else
                    ComboBox1.Text = ""
                    MessageBox.Show("Record Deleted from Database")
                End If
            End If
        End If

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Controls.Clear()
        InitializeComponent()
        DeleteUser_Load(e, e)

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
End Class