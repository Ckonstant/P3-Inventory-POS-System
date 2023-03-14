Public Class loadForm
    Private Sub loadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Appeared As Boolean = False
        If Not Appeared Then
            Opacity += 0.1
            If Opacity >= 1.0 Then
                Appeared = True
                Timer1.Interval = 50000
            End If
        End If
        If Appeared Then

            Timer1.Stop()
            Timer2.Start()
            GunaProgressBar1.Visible = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        GunaProgressBar1.Increment(1)
        If GunaProgressBar1.Value = 1 Then
            Label2.Text = "Φόρτωση Βιβλιοθηκών..."

        End If
        If GunaProgressBar1.Value = 15 Then
            Label2.Text = "Σύνδεση στον SQL Server..."
        End If
        If GunaProgressBar1.Value = 40 Then
            Label2.Text = "Ανάλυση SQL dataset δεδομένων..."
        End If
        If GunaProgressBar1.Value = 75 Then
            Label2.Text = "Έλεγχος για ενημερώσεις..."
        End If
        If GunaProgressBar1.Value = 90 Then
            Label2.Text = "Πακέτα READY."
        End If
        If GunaProgressBar1.Value = 100 Then
            Timer2.Stop()
            userLogin.Show()
            Me.Close()
        End If
    End Sub
End Class