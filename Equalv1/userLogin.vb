Imports Syncfusion.Windows.Forms

Public Class userLogin
    Private Sub GunaLineTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLineTextBox1_GotFocus(sender As Object, e As EventArgs)
        If GunaLineTextBox1.Text = "Ονομα Χρήστη.." Then
            GunaLineTextBox1.Text = ""
        End If
    End Sub

    Private Sub GunaLineTextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLineTextBox2_GotFocus(sender As Object, e As EventArgs)
        If GunaLineTextBox2.Text = "Κωδικός Χρήστη.." Then
            GunaLineTextBox2.Text = ""
        End If
    End Sub
    Public uFlag As String
    Private Sub GunaButton28_Click(sender As Object, e As EventArgs)
        If GunaLineTextBox1.Text = "admin" And GunaLineTextBox2.Text = "admin" Then
            uFlag = "Super Admin"
            Me.Hide()
            Form1.Show()
            Me.Close()

        ElseIf GunaLineTextBox1.Text = "chkonstant" And GunaLineTextBox2.Text = "12345" Then
            uFlag = "chkonstant"
            Me.Hide()
            Form1.Show()

            Me.Close()


        Else
            MsgBox("Λανθασμένα Στοιχεία (Username/Password)")
        End If

    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If GunaCheckBox1.Checked = True Then
            GunaLineTextBox2.PasswordChar = ""
        Else
            GunaLineTextBox2.PasswordChar = "●"
        End If
    End Sub
    Dim i As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        If i = 25 Then
            Timer1.Stop()
            GunaGradient2Panel1.Visible = False
            GunaGradient2Panel2.Visible = True
            '    GunaLabel2.ForeColor = Color.FromArgb(46, 204, 113)
            i = 0
            If GunaLineTextBox1.Text = "betatester" And GunaLineTextBox2.Text = "betatester" Then
                Form1.Show()
                Me.Close()
            Else
                MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
                MessageBoxAdv.Show("Λανθασμένο Συνθηματικό/Κωδικός!", "University of Ioannina", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub GunaLineTextBox2_LostFocus(sender As Object, e As EventArgs)
        If GunaLineTextBox2.Text = "" Then
            GunaLineTextBox2.Text = "Κωδικός Χρήστη.."
        End If
    End Sub

    Private Sub GunaLineTextBox1_LostFocus(sender As Object, e As EventArgs)
        If GunaLineTextBox1.Text = "" Then
            GunaLineTextBox1.Text = "Ονομα Χρήστη.."
        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click

        Application.Exit()
    End Sub

    Private Sub userLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaGradient2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaGradient2Panel2.Paint

    End Sub

    Private Sub GunaGradient2Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles GunaGradient2Panel2.MouseClick
        Try
            GunaGradient2Panel1.Visible = True
            GunaGradient2Panel2.Visible = False
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GunaLabel2_Click(sender As Object, e As EventArgs) Handles GunaLabel2.Click
        Try
            GunaGradient2Panel1.Visible = True
            GunaGradient2Panel2.Visible = False
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Try
            GunaGradient2Panel1.Visible = True
            GunaGradient2Panel2.Visible = False
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel1.LinkClicked
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("Όνομα Χρήστη : betatester" + vbNewLine + "Κωδικός Χρήστη : betatester", "System Management", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GunaLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GunaLinkLabel2.LinkClicked
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("Δεν είναι εφικτή η δημιουργία προφίλ στο Beta Testing.", "System Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class