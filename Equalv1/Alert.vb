Public Class Alert
    Enum alertTypeEnum
        Success
        Warning
        [Error]
        Info
    End Enum

    Dim x, y As Integer
    Private Sub Alert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' CenterToScreen()

        'Top = Form1.Top

    End Sub
    Public Sub setAlert(msg As String, type As alertTypeEnum)
        Me.Opacity = 0
        Me.StartPosition = FormStartPosition.Manual
        Dim fname As String
        For i As Integer = 1 To 10
            fname = "alert" & i.ToString
            Dim f As Alert = Application.OpenForms.Item(fname)
            If f Is Nothing Then
                Me.Name = fname
                ' x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width + 15
                x = 600
                ' y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height * i - 5 * i
                'y = 160 + (i * Me.Height + 10 * i)
                ' MsgBox(i * Me.Height + 10 * i)
                y = 92 + (i * Me.Height + 10 * i) '907
                Me.Location = New Point(x, y)
                Exit For
            End If
        Next
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5
        Select Case type
            Case alertTypeEnum.Error
                Me.GunaPictureBox1.Image = My.Resources.Error_28px
                Me.BackColor = Color.FromArgb(255, 121, 70)
            Case alertTypeEnum.Info
                Me.GunaPictureBox1.Image = My.Resources.Info_28px
                Me.BackColor = Color.FromArgb(71, 169, 248)
            Case alertTypeEnum.Success
                Me.GunaPictureBox1.Image = My.Resources.Checkmark_28px
                Me.BackColor = Color.FromArgb(42, 171, 160)
            Case alertTypeEnum.Warning
                Me.GunaPictureBox1.Image = My.Resources.Warning_28px
                Me.BackColor = Color.FromArgb(255, 179, 2)
        End Select
        GunaLabel2.Text = DateTime.Now.ToLongTimeString
        Me.GunaLabel1.Text = msg
        '  Me.TopMost = True
        '  Me.ShowIcon = False
        '  Me.ShowInTaskbar = False
        Me.Show()
        Me.Timer1.Interval = 1
        Me.Timer1.Start()
    End Sub

    Enum actionEnum
        wait
        start
        close
    End Enum

    Private action As actionEnum = actionEnum.start

    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaPictureBox2.Click
        Me.Timer1.Interval = 1
        action = actionEnum.close
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case action
            Case actionEnum.start
                Me.Timer1.Interval = 1
                Me.Opacity += 0.1
                If x < Me.Location.X Then
                    Me.Left -= 1
                Else
                    If Me.Opacity = 1 Then
                        action = actionEnum.wait
                    End If
                End If
            Case actionEnum.wait
                Timer1.Interval = 5000
                action = actionEnum.close
            Case actionEnum.close
                Timer1.Interval = 1
                Me.Opacity -= 0.1
                Me.Left -= 3
                If Me.Opacity = 0 Then
                    Close()
                End If
        End Select
    End Sub
End Class