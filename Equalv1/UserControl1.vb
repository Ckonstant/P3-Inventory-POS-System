Imports Syncfusion.Windows.Forms

Public Class UserControl1
    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        Dim i As Integer = 0
        Dim finalIndex As Integer = 0
        For Each index In Form4.ListBox1.Items
            If index = Label1.Text Then
                finalIndex = i
            End If
            i += 1
        Next

        Form4.sumFiles = Form4.sumFiles - 1
        Form4.Label3.Text = "Συνολικά αρχεία = " + Form4.sumFiles.ToString
        Form4.totalFilesSize = Form4.totalFilesSize - Convert.ToDouble(GunaLabel4.Text)
        Form4.fileSizesum = Form4.fileSizesum - Convert.ToDouble(GunaLabel4.Text) * 1024 * 1024
        Form4.Label7.Text = Form4.totalFilesSize.ToString("N2") + " / 25 MB"
        Form4.GunaProgressBar1.Value = 100 * Form4.totalFilesSize / 25
        Form4.ListBox1.Items.RemoveAt(finalIndex)
        Form4.GradientPanel2.Controls.Remove(Me)
    End Sub

    Private Sub GunaPictureBox6_Click(sender As Object, e As EventArgs) Handles GunaPictureBox6.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

        Dim result As DialogResult
        Try

            result = MessageBoxAdv.Show("Θέλετε να γίνει προεπισκόπηση;", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                previewFile.Label1.Text = Label1.Text
                previewFile.Show()
            End If
        Catch
        End Try

    End Sub

    Private Sub GunaLinePanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaLinePanel1.Paint

    End Sub
End Class
