Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Value + 2

        ElseIf ProgressBar1.Value = ProgressBar1.Maximum Then


            Timer1.Stop()
            Me.Hide()
            Login.Show()

        End If
    End Sub

    Private Sub SplashScreen1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End

    End Sub
End Class
