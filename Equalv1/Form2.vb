Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Syncfusion.Windows.Forms

Public Class Form2
    Dim countR As Integer = 0
    '' Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection(My.Settings.equalhostDB)
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click

    End Sub

    Dim i As Integer = 0
    Private Sub makeInteger(myText As String)
        Dim myChars() As Char = myText.ToCharArray
        Dim news As String = ""
        For Each ch As Char In myChars
            If Char.IsDigit(ch) Then
                news = news + ch
            End If

        Next
        GunaLineTextBox6.Text = news
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.EditFlag = True Then
            GunaAdvenceButton2.Visible = False
            GunaAdvenceButton1.Visible = True
        Else
            GunaAdvenceButton2.Visible = True
            GunaAdvenceButton1.Visible = False
        End If
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        Me.TopMost = True
        Me.VerticalScroll.Visible = False
        GunaLineTextBox13.Text = GunaDateTimePicker1.Text
        GunaDateTimePicker1.Value = Date.Now

        '' Form1.Hide()
        ''Me.Location = New Point(Form1.Location.X + 40, 308)
        GunaAnimateWindow1.Start()

        'TODO: This line of code loads data into the 'Database1DataSet1.EqualDB' table. You can move, or remove it, as needed.
        Me.EqualDBTableAdapter.Fill(Me.Database1DataSet.EqualDB)

        'MsgBox(ApothikiItems.sfDataGrid1.ColumnCount.ToString)
        'TODO: This line of code loads data into the 'Database1DataSet.EqualDB' table. You can move, or remove it, as needed.
        ''Me.EqualDBTableAdapter.Fill(Me.Database1DataSet.EqualDB)
        Try
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()
            If Form1.EditFlag = True Then
                i = Convert.ToInt32(ApothikiItems.sfDataGrid1.SelectedItem(0))
            End If


            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from EqualDB where id=" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read

                GunaLineTextBox1.Text = dr.GetString(1).ToString()

                GunaLineTextBox2.Text = dr.GetString(2).ToString()
                DoubleTextBox1.Text = dr.GetString(3).ToString()
                DoubleTextBox2.Text = dr.GetValue(4).ToString()
                '' If GunaLineTextBox4.Text.Length <> 0 Then
                ''GunaLineTextBox4.Text = GunaLineTextBox4.Text.Substring(0, GunaLineTextBox4.Text.Length - 1)
                '' End If
                GunaLineTextBox5.Text = dr.GetValue(5).ToString()
                DoubleTextBox5.Text = dr.GetValue(6).ToString()
                '' If GunaLineTextBox6.Text.Length <> 0 Then
                ''GunaLineTextBox6.Text = GunaLineTextBox6.Text.Substring(0, GunaLineTextBox6.Text.Length - 1)
                ''End If
                DoubleTextBox3.Text = dr.GetValue(7).ToString()
                '' If GunaLineTextBox7.Text.Length <> 0 Then
                ''GunaLineTextBox7.Text = GunaLineTextBox7.Text.Substring(0, GunaLineTextBox7.Text.Length - 6)
                ''End If
                DoubleTextBox4.Text = dr.GetValue(8).ToString()
                ''If GunaLineTextBox8.Text.Length <> 0 Then
                ''GunaLineTextBox8.Text = GunaLineTextBox8.Text.Substring(0, GunaLineTextBox8.Text.Length - 1)
                '' End If
                GunaLineTextBox9.Text = dr.GetString(9).ToString
                GunaLineTextBox10.Text = dr.GetString(10).ToString
                GunaLineTextBox11.Text = dr.GetString(12).ToString
                GunaLineTextBox12.Text = dr.GetString(11).ToString

                GunaLineTextBox13.Text = dr.GetDateTime(13).ToString
                TextBox1.Text = dr.GetString(15).ToString
            End While
        Catch ex As Exception

        End Try
        If TextBox1.Text = "Πληρώθηκε" Then
            BunifuCheckBox1.Checked = True
        Else
            BunifuCheckBox1.Checked = False
        End If
        If GunaComboBox3.Items.Count > 0 Then
            GunaComboBox3.SelectedItem = GunaLineTextBox10.Text
        End If
        If GunaComboBox2.Items.Count > 0 Then
            GunaComboBox2.SelectedItem = GunaLineTextBox5.Text
        End If
        If GunaComboBox1.Items.Count > 0 Then
            ''GunaComboBox1.SelectedIndex = 1   ' The first item has index 0 '
            GunaComboBox1.SelectedItem = GunaLineTextBox11.Text
        End If

    End Sub



    Private Sub GunaComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox2.SelectedIndexChanged
        If GunaComboBox2.SelectedItem = "13%" Then
            ''GunaLineTextBox6.Text = GunaLineTextBox4.Text + GunaLineTextBox4.Text * 13 / 100
            GunaLineTextBox5.Text = "13%"
        End If
        If GunaComboBox2.SelectedItem = "24%" Then
            ''GunaLineTextBox6.Text = GunaLineTextBox4.Text + GunaLineTextBox4.Text * 24 / 100
            GunaLineTextBox5.Text = "24%"
        End If
    End Sub



    Private Sub GunaPictureBox2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox3.SelectedIndexChanged
        If GunaComboBox3.SelectedItem = "Γλυκά" Then

            GunaLineTextBox10.Text = "Γλυκά"
        End If
        If GunaComboBox3.SelectedItem = "Άρτος" Then

            GunaLineTextBox10.Text = "Άρτος"
        End If
        If GunaComboBox3.SelectedItem = "Καφές" Then

            GunaLineTextBox10.Text = "Καφές"
        End If
        If GunaComboBox3.SelectedItem = "Λοιπά Προιόντα" Then

            GunaLineTextBox10.Text = "Λοιπά Προιόντα"
        End If
        If GunaComboBox3.SelectedItem = "Ποτά" Then

            GunaLineTextBox10.Text = "Ποτά"
        End If
    End Sub

    Private Sub GunaComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GunaComboBox1.SelectedIndexChanged
        If GunaComboBox1.SelectedItem = "ΚΙΛΟ" Then
            GunaLineTextBox11.Text = "ΚΙΛΟ"
        End If
        If GunaComboBox1.SelectedItem = "TEM" Then
            GunaLineTextBox11.Text = "TEM"
        End If
        If GunaComboBox1.SelectedItem = "ΚΙΒ" Then
            GunaLineTextBox11.Text = "ΚΙΒ"
        End If
    End Sub

    Private Sub GunaLineTextBox12_TextChanged(sender As Object, e As EventArgs)
        ''Try
        ''naLineTextBox4.Text = GunaLineTextBox4.Text - GunaLineTextBox4.Text * GunaLineTextBox12.Text / 100
        '' Catch ex As Exception

        ''End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim k As Double = Convert.ToDouble(GunaLineTextBox8.Text)
        Decimal.Round(k, 2, MidpointRounding.AwayFromZero)
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE
        GunaAnimateWindow1.Start()
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        GunaAnimateWindow1.Start()
    End Sub

    Private Sub GunaButton1_MouseEnter(sender As Object, e As EventArgs) Handles GunaButton1.MouseEnter
        GunaButton1.Size = New Size(151, 37)
        GunaButton1.Text = "Καταχώρηση"
    End Sub

    Private Sub GunaButton1_MouseLeave(sender As Object, e As EventArgs) Handles GunaButton1.MouseLeave
        GunaButton1.Size = New Size(42, 37)
        GunaButton1.Text = ""
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click


    End Sub

    Private Sub GunaButton4_MouseEnter(sender As Object, e As EventArgs) Handles GunaButton4.MouseEnter
        GunaButton4.Size = New Size(151, 37)
        GunaButton4.Text = "Επεξεργασία"
    End Sub

    Private Sub GunaButton4_MouseLeave(sender As Object, e As EventArgs) Handles GunaButton4.MouseLeave
        GunaButton4.Size = New Size(42, 37)
        GunaButton4.Text = ""
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton5_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton5_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton6_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton6_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLineTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLineTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub GunaLineTextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLineTextBox6_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 44) Then
            e.Handled = False
        End If
    End Sub

    Private Sub GunaLineTextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLineTextBox7_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 44) Then
            e.Handled = False
        End If
    End Sub

    Private Sub GunaLineTextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLineTextBox4_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 44) Then
            e.Handled = False
        End If
    End Sub

    Private Sub GunaLineTextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLineTextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 44) Then
            e.Handled = False
        End If
    End Sub

    Private Sub GunaLineTextBox12_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 44) Then
            e.Handled = False
        End If
    End Sub

    Private Sub GunaDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles GunaDateTimePicker1.ValueChanged
        GunaLineTextBox13.Text = GunaDateTimePicker1.Text
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaLineTextBox2_TextChanged(sender As Object, e As EventArgs) Handles GunaLineTextBox2.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub GunaLineTextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles GunaLineTextBox1.TextChanged
        PictureBox1.BackgroundImage = Code128(GunaLineTextBox1.Text, "B")
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaPictureBox3_Click(sender As Object, e As EventArgs) Handles GunaPictureBox3.Click
        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = con
        mycommand.CommandText = "UPDATE EqualDB SET ID_Προιόντος = @ID, Κατηγορία = @kat, Προμηθευτής = @pro,Περιγραφή = @peri,Ποσότητα = @pos,ΜΜ = @MM,Κοστολόγιο = @kost,ΦΠΑ = @fpa,Τιμή = @timh,Τιμή_Πώλησης = @timhp,Κέρδος = @ke,ΕΚΠΤ = @ekpt,ΗΜ = @hm,picFlag = @picFlag,Paid = @Paid where Id=" & Form1.itemKey & ""
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        Using ms As New MemoryStream
            If CheckBox1.Checked = True Then
                PictureBox3.Image.Save(ms, PictureBox3.Image.RawFormat)
            Else
                PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
            End If
            If BunifuCheckBox1.Checked = True Then
                TextBox1.Text = "Πληρώθηκε"
            Else
                TextBox1.Text = "Απλήρωτο"
            End If
            Try
                mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = GunaLineTextBox1.Text
                mycommand.Parameters.Add("@peri", SqlDbType.NVarChar).Value = GunaLineTextBox2.Text
                mycommand.Parameters.Add("@kost", SqlDbType.Decimal).Value = DoubleTextBox2.Text
                mycommand.Parameters.Add("@pos", SqlDbType.NVarChar).Value = DoubleTextBox1.Text
                mycommand.Parameters.Add("@pro", SqlDbType.NVarChar).Value = GunaLineTextBox9.Text
                mycommand.Parameters.Add("@timh", SqlDbType.Decimal).Value = DoubleTextBox5.Text
                mycommand.Parameters.Add("@timhp", SqlDbType.Decimal).Value = DoubleTextBox3.Text
                mycommand.Parameters.Add("@ekpt", SqlDbType.NVarChar).Value = GunaLineTextBox12.Text
                mycommand.Parameters.Add("@ke", SqlDbType.Decimal).Value = DoubleTextBox4.Text
                mycommand.Parameters.Add("@kat", SqlDbType.NVarChar).Value = GunaLineTextBox10.Text
                mycommand.Parameters.Add("@hm", SqlDbType.Date).Value = GunaDateTimePicker1.Value
                mycommand.Parameters.Add("@MM", SqlDbType.NVarChar).Value = GunaLineTextBox11.Text
                mycommand.Parameters.Add("@fpa", SqlDbType.NVarChar).Value = GunaLineTextBox5.Text
                mycommand.Parameters.Add("@picFlag", SqlDbType.Image).Value = ms.ToArray()
                mycommand.Parameters.Add("@Paid", SqlDbType.NVarChar).Value = TextBox1.Text
                mycommand.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MessageBoxAdv.Show("Υπήρξε κάποιο τεχνικό πρόβλημα! Επικοινωνήστε με τον διαχειριστή", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        con.Close()

    End Sub

    Private Sub GunaPanel16_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel16.Paint

    End Sub

    Private Sub BunifuCheckBox1_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles BunifuCheckBox1.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private currentForm As Form = Nothing
    Public Sub openChildForm(childForm As Form)
        '' GunaTransition1.HideSync(currentForm)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel2.Controls.Add(childForm)
        Panel2.Tag = childForm
        childForm.BringToFront()
        ''childForm.Visible = False
        ''GunaTransition1.ShowSync(currentForm)
        childForm.Opacity = 85
        childForm.Show()
        ''GunaTransition1.ShowSync(childForm)
        ''childForm.Visible = True


    End Sub
    Private Sub GunaButton2_Click_1(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If Application.OpenForms().OfType(Of Form3).Any Then
            GunaTransition1.HideSync(Panel2)
            Form3.Close()


            ''GunaTransition1.ShowSync(GunaPanel15)
            'pn_excel.BringToFront()

        Else
            openChildForm(Form3)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'pn_excel.BringToFront()
            GunaTransition1.ShowSync(Panel2)
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        GunaTransition1.ShowSync(Panel2)
    End Sub

    Private Sub GunaButton40_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Form1.nav_home.PerformClick()
        'Form1.pn_home.BringToFront()
    End Sub

    Private Sub GunaButton41_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        MessageBoxAdv.Show("Για περισσότερες πληροφορίες επικοινωνήστε με τον προγραμματιστή", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        Try
            Dim result As DialogResult = MessageBoxAdv.Show("Θέλετε να γίνει αυτόματος υπολογισμός των τιμών;", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'GunaLabel1.Text = (GunaLineTextBox4.Text - GunaLineTextBox4.Text * GunaLineTextBox12.Text / 100)
                If GunaLineTextBox5.Text = "13%" Then
                    DoubleTextBox5.Text = DoubleTextBox2.Text + (DoubleTextBox2.Text * 0.13)
                    'GunaLineTextBox6.Text = GunaLabel1.Text + GunaLabel1.Text * 13 / 100
                Else
                    DoubleTextBox5.Text = DoubleTextBox2.Text + (DoubleTextBox2.Text * 0.24)
                End If
                GunaLabel1.Text = (DoubleTextBox1.Text * DoubleTextBox5.Text)
                DoubleTextBox3.Text = DoubleTextBox5.Text - DoubleTextBox5.Text * GunaLineTextBox12.Text / 100
                GunaTextBox1.Text = DoubleTextBox5.Text - DoubleTextBox5.Text * GunaLineTextBox12.Text / 100
                DoubleTextBox4.Text = GunaLabel1.Text - (GunaLabel1.Text * GunaLineTextBox12.Text / 100)
            End If

        Catch ex As Exception
            MessageBoxAdv.Show("Μη επιτρεπτές τιμές για υπολογισμό", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub GunaButton6_Click_1(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Dim result As DialogResult = MessageBoxAdv.Show("Θέλετε να γίνει καθαρισμός τον κελιών?", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            GunaLineTextBox1.Text = ""
            GunaLineTextBox2.Text = ""
            GunaLineTextBox9.Text = ""
            DoubleTextBox1.Text = ""
            DoubleTextBox2.Text = ""
            DoubleTextBox3.Text = ""
            DoubleTextBox4.Text = ""
            DoubleTextBox5.Text = ""
        End If
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = con
        mycommand.CommandText = "INSERT INTO EqualDB (ID_Προιόντος, Κατηγορία, Προμηθευτής,Περιγραφή,Ποσότητα,ΜΜ,Κοστολόγιο,ΦΠΑ,Τιμή,Τιμή_Πώλησης,Κέρδος,ΕΚΠΤ,ΗΜ,picFlag,Paid) VALUES (@ID, @kat, @pro, @peri, @pos, @MM,@kost,@fpa,@timh,@timhp,@ke,@ekpt,@hm,@picFlag,@Paid)"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        Using ms As New MemoryStream
            If CheckBox1.Checked = True Then
                PictureBox3.Image.Save(ms, PictureBox3.Image.RawFormat)
            Else
                PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
            End If
            If BunifuCheckBox1.Checked = True Then
                TextBox1.Text = "Πληρώθηκε"
            Else
                TextBox1.Text = "Απλήρωτο"
            End If
            Try
                mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = GunaLineTextBox1.Text
                mycommand.Parameters.Add("@peri", SqlDbType.NVarChar).Value = GunaLineTextBox2.Text
                mycommand.Parameters.Add("@kost", SqlDbType.Decimal).Value = DoubleTextBox2.Text
                mycommand.Parameters.Add("@pos", SqlDbType.NVarChar).Value = DoubleTextBox1.Text
                mycommand.Parameters.Add("@pro", SqlDbType.NVarChar).Value = GunaLineTextBox9.Text
                mycommand.Parameters.Add("@timh", SqlDbType.Decimal).Value = DoubleTextBox5.Text
                mycommand.Parameters.Add("@timhp", SqlDbType.Decimal).Value = DoubleTextBox3.Text
                mycommand.Parameters.Add("@ekpt", SqlDbType.NVarChar).Value = GunaLineTextBox12.Text
                mycommand.Parameters.Add("@ke", SqlDbType.Decimal).Value = DoubleTextBox4.Text
                mycommand.Parameters.Add("@kat", SqlDbType.NVarChar).Value = GunaLineTextBox10.Text
                mycommand.Parameters.Add("@hm", SqlDbType.Date).Value = GunaDateTimePicker1.Value
                mycommand.Parameters.Add("@MM", SqlDbType.NVarChar).Value = GunaLineTextBox11.Text
                mycommand.Parameters.Add("@fpa", SqlDbType.NVarChar).Value = GunaLineTextBox5.Text
                mycommand.Parameters.Add("@picFlag", SqlDbType.Image).Value = ms.ToArray()
                mycommand.Parameters.Add("@Paid", SqlDbType.NVarChar).Value = TextBox1.Text
                mycommand.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            End Try
            con.Close()


            Form1.up_deletedRows()
            Form1.up_deletedRows()
            Form1.countNew += 1
            Form1.countPosNEW += DoubleTextBox1.Text
            Form1.countKostNew += DoubleTextBox2.Text

            Form1.up_deletedRows()
        End Using
        Form1.Alert1("Επιτυχημένη Καταχώρηση εγγραφής! (" + GunaLineTextBox1.Text + ")", Alert.alertTypeEnum.Success)
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = con
        mycommand.CommandText = "UPDATE EqualDB SET ID_Προιόντος = @ID, Κατηγορία = @kat, Προμηθευτής = @pro,Περιγραφή = @peri,Ποσότητα = @pos,ΜΜ = @MM,Κοστολόγιο = @kost,ΦΠΑ = @fpa,Τιμή = @timh,Τιμή_Πώλησης = @timhp,Κέρδος = @ke,ΕΚΠΤ = @ekpt,ΗΜ = @hm,picFlag = @picFlag,Paid = @Paid where Id=" & Form1.itemKey & ""
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        Using ms As New MemoryStream
            If CheckBox1.Checked = True Then
                PictureBox3.Image.Save(ms, PictureBox3.Image.RawFormat)
            Else
                PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
            End If
            If BunifuCheckBox1.Checked = True Then
                TextBox1.Text = "Πληρώθηκε"
            Else
                TextBox1.Text = "Απλήρωτο"
            End If
            Try
                mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = GunaLineTextBox1.Text
                mycommand.Parameters.Add("@peri", SqlDbType.NVarChar).Value = GunaLineTextBox2.Text
                mycommand.Parameters.Add("@kost", SqlDbType.Decimal).Value = DoubleTextBox2.Text
                mycommand.Parameters.Add("@pos", SqlDbType.NVarChar).Value = DoubleTextBox1.Text
                mycommand.Parameters.Add("@pro", SqlDbType.NVarChar).Value = GunaLineTextBox9.Text
                mycommand.Parameters.Add("@timh", SqlDbType.Decimal).Value = DoubleTextBox5.Text
                mycommand.Parameters.Add("@timhp", SqlDbType.Decimal).Value = DoubleTextBox3.Text
                mycommand.Parameters.Add("@ekpt", SqlDbType.NVarChar).Value = GunaLineTextBox12.Text
                mycommand.Parameters.Add("@ke", SqlDbType.Decimal).Value = DoubleTextBox4.Text
                mycommand.Parameters.Add("@kat", SqlDbType.NVarChar).Value = GunaLineTextBox10.Text
                mycommand.Parameters.Add("@hm", SqlDbType.Date).Value = GunaDateTimePicker1.Value
                mycommand.Parameters.Add("@MM", SqlDbType.NVarChar).Value = GunaLineTextBox11.Text
                mycommand.Parameters.Add("@fpa", SqlDbType.NVarChar).Value = GunaLineTextBox5.Text
                mycommand.Parameters.Add("@picFlag", SqlDbType.Image).Value = ms.ToArray()
                mycommand.Parameters.Add("@Paid", SqlDbType.NVarChar).Value = TextBox1.Text
                mycommand.ExecuteNonQuery()

            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            End Try
        End Using
        con.Close()
        MsgBox("ΕΠΙΤΥΧΗΣ ΕΝΗΜΕΡΩΣΗ!")
    End Sub
End Class