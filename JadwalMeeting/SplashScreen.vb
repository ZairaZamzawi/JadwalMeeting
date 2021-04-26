Public Class SplashScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call Koneksi()
        ProgressBar1.Value += 2
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            frmMain.Show()
        End If
    End Sub
End Class