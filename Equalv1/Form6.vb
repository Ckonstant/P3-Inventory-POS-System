Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Linq ' need to add 
Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Imports System.Windows.Media
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Drawing.Color
Imports Syncfusion.WinForms.DataGrid.Events
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Styles
Imports System.Windows.Forms
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.Windows.Forms
Imports System.Web
Imports System.Net.NetworkInformation
Imports System.Net
Imports ClosedXML.Excel.XLWorkbook
Imports ClosedXML.Excel

Public Class Form6
    Private Sub summaryControl()
        Dim tableSummaryRow1 As New GridTableSummaryRow()
        tableSummaryRow1.Name = "TableSummary"
        tableSummaryRow1.ShowSummaryInRow = True
        tableSummaryRow1.Title = "Συνολικές Καταχωρήσεις στο σύστημα : {countItems}                     Συνολική αξία Τιμολογίων : {kerdos}                              Μέσος Όρος Τιμής ανα Τιμολόγιο {averageKerdos}"
        tableSummaryRow1.Position = VerticalPosition.Bottom

        Dim summaryυColumn1 As New GridSummaryColumn()
        summaryυColumn1.Name = "kerdos"
        summaryυColumn1.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryυColumn1.Format = "{Sum:c}"
        summaryυColumn1.MappingName = "teliki_aksia"

        Dim summaryυColumn2 As New GridSummaryColumn()
        summaryυColumn2.Name = "averageKerdos"
        summaryυColumn2.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryυColumn2.Format = "{Average:c}"
        summaryυColumn2.MappingName = "teliki_aksia"

        Dim summaryυColumn3 As New GridSummaryColumn()
        summaryυColumn3.Name = "countItems"
        summaryυColumn3.SummaryType = Syncfusion.Data.SummaryType.CountAggregate
        summaryυColumn3.Format = "{Count:d}"
        summaryυColumn3.MappingName = "teliki_aksia"

        tableSummaryRow1.SummaryColumns.Add(summaryυColumn1)
        tableSummaryRow1.SummaryColumns.Add(summaryυColumn2)
        tableSummaryRow1.SummaryColumns.Add(summaryυColumn3)
        Me.SfDataGrid1.TableSummaryRows.Add(tableSummaryRow1)

        ' Creates the GridSummaryRow.
        Dim groupSummaryRow1 As New GridSummaryRow()
        groupSummaryRow1.Name = "GroupSummary"
        groupSummaryRow1.ShowSummaryInRow = True
        groupSummaryRow1.Title = "Συνολικά Τιμολόγια : {UnitPrice}    Συνολική αξία Τιμολογίων : {kerdos}  Μέσος όρος ανά Τιμολόγιο : {averKer}"

        ' Creates the GridSummaryColumn.
        Dim summaryColumn1 As New GridSummaryColumn()
        summaryColumn1.Name = "UnitPrice"
        summaryColumn1.SummaryType = Syncfusion.Data.SummaryType.CountAggregate
        summaryColumn1.Format = "{Count:d}"
        summaryColumn1.MappingName = "teliki_aksia"

        Dim summaryColumn2 As New GridSummaryColumn()
        summaryColumn2.Name = "kerdos"
        summaryColumn2.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryColumn2.Format = "{Sum:c}"
        summaryColumn2.MappingName = "teliki_aksia"

        Dim summaryColumn3 As New GridSummaryColumn()
        summaryColumn3.Name = "averKer"
        summaryColumn3.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryColumn3.Format = "{Average:c}"
        summaryColumn3.MappingName = "teliki_aksia"

        ' Adds the GridSummaryColumn in SummaryColumns collection.
        groupSummaryRow1.SummaryColumns.Add(summaryColumn1)
        groupSummaryRow1.SummaryColumns.Add(summaryColumn2)
        groupSummaryRow1.SummaryColumns.Add(summaryColumn3)
        ' Adds the summary row in the GroupSummaryRows collection.
        Me.SfDataGrid1.GroupSummaryRows.Add(groupSummaryRow1)
    End Sub 'a
    Dim editFlag As Boolean = False
    Dim i As Integer
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection(My.Settings.equalhostDB)
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EqualHostDataset.timologio' table. You can move, or remove it, as needed.
        Me.TimologioTableAdapter.Fill(Me.EqualHostDataset.timologio)


        'TODO: This line of code loads data into the 'Database1DataSet.timologio' table. You can move, or remove it, as needed.
        SfDataGrid1.ShowBusyIndicator = True
        Me.TimologioTableAdapter.Fill(Me.EqualHostDataset.timologio)
        summaryControl()
        'TODO: This line of code loads data into the 'DataSet1.TEST' table. You can move, or remove it, as needed.
        disp_data()


        'TODO: This line of code loads data into the 'DataSet1.test2' table. You can move, or remove it, as needed.


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = con
        mycommand.CommandText = "INSERT INTO timologio (Id_timologiou, seller,sale_type,kathari_aksia,sum_ekptosi,sum_fpa,teliki_aksia,hmero,paidFlag) VALUES (@ID, @sell, @sale, @k_aksia,@s_ekpt,@s_fpa,@te_aksia,@hm,@paid)"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        If BunifuCheckBox1.Checked = True Then
            paidFlag = "Πληρωμένο"
        Else
            paidFlag = "Απλήρωτο"
        End If
        con.Open()

        Try
            mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = GunaLineTextBox1.Text
            mycommand.Parameters.Add("@sell", SqlDbType.NVarChar).Value = GunaLineTextBox2.Text
            mycommand.Parameters.Add("@sale", SqlDbType.NVarChar).Value = GunaComboBox3.SelectedItem.ToString
            mycommand.Parameters.Add("@k_aksia", SqlDbType.Decimal).Value = DoubleTextBox1.Text
            mycommand.Parameters.Add("@s_ekpt", SqlDbType.Decimal).Value = DoubleTextBox2.Text
            mycommand.Parameters.Add("@s_fpa", SqlDbType.Decimal).Value = DoubleTextBox3.Text
            mycommand.Parameters.Add("@te_aksia", SqlDbType.Decimal).Value = DoubleTextBox4.Text
            mycommand.Parameters.Add("@hm", SqlDbType.Date).Value = GunaDateTimePicker1.Value
            mycommand.Parameters.Add("@paid", SqlDbType.NVarChar).Value = paidFlag
            mycommand.ExecuteNonQuery()
            Form1.Alert1("Επιτυχημένη καταχώρηση Τιμολογίου.", Alert.alertTypeEnum.Success)
        Catch
            Form1.Alert1("Αποτυχημένη καταχώρηση στοιχείου.", Alert.alertTypeEnum.Error)
        End Try
        con.Close()
        disp_data()
        GunaTransition1.HideSync(BunifuPanel1)
        GunaTransition1.ShowSync(SfDataGrid1)
    End Sub
    Public Sub disp_data()
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from timologio"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        ' GunaDataGridView1.DataSource = dt

        SfDataGrid1.DataSource = dt

        con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs)

    End Sub
    Dim paidFlag As String = ""


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        GunaLineTextBox1.Text = GunaComboBox3.SelectedItem.ToString
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        GunaTransition1.HideSync(BunifuPanel1)
        GunaTransition1.ShowSync(SfDataGrid1)
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        GunaAdvenceButton3.Visible = False
        GunaAdvenceButton2.Visible = True
        GunaTransition1.HideSync(SfDataGrid1)
        GunaTransition1.ShowSync(BunifuPanel1)
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        MsgBox("1 και 1 κανουν 2.", MsgBoxStyle.Information)
    End Sub

    Private Sub BunifuPanel1_Click(sender As Object, e As EventArgs) Handles BunifuPanel1.Click

    End Sub
    Private Sub SfDataGrid1_QueryCellStyle1(ByVal sender As Object, ByVal e As QueryCellStyleEventArgs)
        If e.Column.MappingName = "paidFlag" Then
            If e.DisplayText = "Πληρωμένο" Then
                e.Style.BackColor = FromArgb(200, 46, 204, 113)
            Else
                e.Style.BackColor = IndianRed
            End If

            ' If e.DisplayText = "Απλήρωτο" Then
            'e.Style.BackColor = FromArgb(200, 230, 126, 34)

            ' If

        End If
        '  If e.Column.MappingName = "ΕΚΠΤ" Then
        'If e.DisplayText > 0 Then
        'e.BackColor = DarkOrange
        'End If
        'End If
    End Sub
    Private Sub BunifuToggleSwitch1_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs)

    End Sub

    Private Sub BunifuToggleSwitch3_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs) Handles BunifuToggleSwitch3.CheckedChanged
        If BunifuToggleSwitch3.Checked = True Then
            AddHandler SfDataGrid1.QueryCellStyle, AddressOf SfDataGrid1_QueryCellStyle1
            'AddHandler sfDataGrid1.DrawCell, AddressOf SfDataGrid1_DrawCell1
            'AddHandler sfDataGrid1.QueryRowStyle, AddressOf SfDataGrid1_QueryRowStyle
            SfDataGrid1.Refresh()
        Else
            RemoveHandler SfDataGrid1.QueryCellStyle, AddressOf SfDataGrid1_QueryCellStyle1
            SfDataGrid1.Refresh()
        End If
    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        disp_data()
        Form1.Alert1("Έγινε ανανέωση του Grid με επιτυχία", Alert.alertTypeEnum.Info)
    End Sub
    Dim popupflag As Boolean = False
    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim columnChooserPopup = New Syncfusion.WinForms.DataGrid.Interactivity.ColumnChooserPopup(SfDataGrid1)
        If popupFlag = False Then
            columnChooserPopup.Show()
            popupFlag = True
        Else
            columnChooserPopup.Close()
            popupFlag = False
        End If
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Try
            SfDataGrid1.ClearFilters()
            MessageBoxAdv.Show("Τα φίλτρα αφαιρέθηκαν με επιτυχία", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exc As Exception
            Form1.Alert1("Αποτυχία αφαίρεσης Φίλτρων στο Grid.", Alert.alertTypeEnum.Error)
        End Try
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim result As DialogResult
        Try
            result = MessageBoxAdv.Show("Θέλετε να διαγραψετε ID : " + SfDataGrid1.SelectedItem(1).ToString + " καταχώρηση?", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from timologio where Id='" + SfDataGrid1.SelectedItem(0).ToString + "'"
                cmd.ExecuteNonQuery()

                disp_data()
                con.Close()
                Form1.Alert1("Η διαγραφή του στοιχείου" + " πραγματοιποιήθηκε με επιτυχία.", Alert.alertTypeEnum.Info)
                SfDataGrid1.SelectedIndex = 1


            ElseIf result = DialogResult.No Then

                con.Close()
            End If
        Catch
            Form1.Alert1("Αποτυχημένη διαγραφή του στοιχείου.", Alert.alertTypeEnum.Error)
            con.Close()
        End Try
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Try
            Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            mycommand.Connection = con
            mycommand.CommandText = "UPDATE timologio SET Id_Timologiou = @ID, seller = @sell, sale_type = @sale,kathari_aksia = @k_aksia,sum_ekptosi = @s_ekpt,sum_fpa = @s_fpa,teliki_aksia = @te_aksia,hmero = @hm,paidFlag = @paid  where Id=" & SfDataGrid1.SelectedItem(0).ToString & ""
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            If BunifuCheckBox1.Checked = True Then
                paidFlag = "Πληρωμένο"
            Else
                paidFlag = "Απλήρωτο"
            End If
            con.Open()

            Try
                mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = GunaLineTextBox1.Text
                mycommand.Parameters.Add("@sell", SqlDbType.NVarChar).Value = GunaLineTextBox2.Text
                mycommand.Parameters.Add("@sale", SqlDbType.NVarChar).Value = GunaComboBox3.SelectedItem.ToString
                mycommand.Parameters.Add("@k_aksia", SqlDbType.Decimal).Value = DoubleTextBox1.Text
                mycommand.Parameters.Add("@s_ekpt", SqlDbType.Decimal).Value = DoubleTextBox2.Text
                mycommand.Parameters.Add("@s_fpa", SqlDbType.Decimal).Value = DoubleTextBox3.Text
                mycommand.Parameters.Add("@te_aksia", SqlDbType.Decimal).Value = DoubleTextBox4.Text
                mycommand.Parameters.Add("@hm", SqlDbType.Date).Value = GunaDateTimePicker1.Value
                mycommand.Parameters.Add("@paid", SqlDbType.NVarChar).Value = paidFlag
                mycommand.ExecuteNonQuery()
                Form1.Alert1("Επιτυχημένη ενημέρωση Τιμολογίου.", Alert.alertTypeEnum.Success)
            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            End Try
            con.Close()
            disp_data()
            GunaTransition1.HideSync(BunifuPanel1)
            GunaTransition1.ShowSync(SfDataGrid1)
        Catch
            Form1.Alert1("FIALED", Alert.alertTypeEnum.Error)
        End Try
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()
            If Form1.EditFlag = False Then
                i = Convert.ToInt32(SfDataGrid1.SelectedItem(0))
            End If


            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from timologio where id=" & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read

                GunaLineTextBox1.Text = dr.GetString(1).ToString()

                GunaLineTextBox2.Text = dr.GetString(2).ToString()
                GunaComboBox3.SelectedItem = dr.GetString(3).ToString
                DoubleTextBox1.Text = dr.GetValue(4).ToString
                DoubleTextBox2.Text = dr.GetValue(5).ToString
                DoubleTextBox3.Text = dr.GetValue(6).ToString
                DoubleTextBox4.Text = dr.GetValue(7).ToString
                GunaDateTimePicker1.Value = dr.GetDateTime(8)
                If dr.GetString(9).ToString = "Πληρωμένο" Then
                    BunifuCheckBox1.Checked = True
                Else
                    BunifuCheckBox1.Checked = False
                End If
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SfDataGrid1_Click(sender As Object, e As EventArgs) Handles SfDataGrid1.Click

    End Sub

    Private Sub SfDataGrid1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles SfDataGrid1.CellDoubleClick
        GunaButton2.PerformClick()
        GunaAdvenceButton3.Visible = True
        GunaAdvenceButton2.Visible = False
        GunaTransition1.HideSync(SfDataGrid1)
        GunaTransition1.ShowSync(BunifuPanel1)

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
    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        If Application.OpenForms().OfType(Of Form3).Any Then
            GunaTransition1.HideSync(Panel2)
            Form3.Close()



        Else
            openChildForm(Form3)

            GunaTransition1.ShowSync(Panel2)
        End If
    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs)

    End Sub
    Dim timologiaSUM = 0
    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        timologiaSUM = 0
        For i As Integer = 0 To GunaDataGridView2.Rows.Count - 1
            timologiaSUM += i
        Next
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            Dim result As DialogResult = MessageBoxAdv.Show("Θέλετε να γίνει αυτόματος υπολογισμός των τιμών;", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DoubleTextBox4.Text = DoubleTextBox1.DoubleValue - DoubleTextBox2.DoubleValue + DoubleTextBox3.DoubleValue
            End If
        Catch
            MessageBoxAdv.Show("Πρόβλημα υπολογισμού τιμών.Ελέγξτε τις τιμές", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub GunaTextBox9_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox9.TextChanged

    End Sub

    Private Sub GunaTextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox9.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' searchCode = "[ID_Προιόντος]"
            If con.State = ConnectionState.Open Then
                con.Close()

            End If

            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from timologio where" + "[Id_Timologiou]" + "='" + GunaTextBox9.Text + "'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            SfDataGrid1.DataSource = dt
            con.Close()
            ' If GunaDataGridView1.Rows.Count > 0 Then
            'GunaButton8.PerformClick()
            MessageBoxAdv.Show("Επιτυχημενο Σκαναρισμα.Το στοιχείο βρέθηκε!!", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        End If
    End Sub

    Private Sub GunaTextBox9_KeyUp(sender As Object, e As KeyEventArgs) Handles GunaTextBox9.KeyUp
        SfDataGrid1.SearchController.SearchColumns.Add("Id_Timologiou")
        SfDataGrid1.SearchController.SearchColor = DarkSeaGreen
        SfDataGrid1.SearchController.Search(GunaTextBox9.Text)
        SfDataGrid1.SearchController.AllowFiltering = True
    End Sub

    Private Sub GunaTextBox9_LostFocus(sender As Object, e As EventArgs) Handles GunaTextBox9.LostFocus
        GunaTextBox9.Text = "ΑΝΑΖΗΤΗΣΗ ΚΑΤΑΧΩΡΗΣΗΣ"
    End Sub

    Private Sub GunaTextBox9_GotFocus(sender As Object, e As EventArgs) Handles GunaTextBox9.GotFocus
        GunaTextBox9.Text = ""
    End Sub

    Private Sub SplitButton1_Click(sender As Object, e As EventArgs) Handles SplitButton1.Click

    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click

    End Sub
End Class