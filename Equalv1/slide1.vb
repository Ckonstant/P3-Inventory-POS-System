Public Class slide1
    Private Sub slide1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
        Top = Form1.Top
        GunaAnimateWindow1.Start()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Interval = 3000 Then
            Me.Close()
        End If
    End Sub

    Private Sub slide1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim fadeout As Double
        For fadeout = 1.1 To 0.0 Step -0.1
            Me.Opacity = fadeout
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next

    End Sub
End Class