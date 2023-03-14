Imports System.ComponentModel
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
Public Class pointOfSale
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection(My.Settings.Database1ConnectionString)
    Private Sub pointOfSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.pointOS' table. You can move, or remove it, as needed.
        Me.PointOSTableAdapter.Fill(Me.Database1DataSet.pointOS)
        'TODO: This line of code loads data into the 'Database1DataSet.PrintTable' table. You can move, or remove it, as needed.
        Me.PrintTableTableAdapter.Fill(Me.Database1DataSet.PrintTable)
        SfDataGrid1.Visible = False
        SfDataGrid1.AllowDeleting = True
        Dim tableSummaryRow1 As New GridTableSummaryRow()
        tableSummaryRow1.Name = "TableSummary"
        tableSummaryRow1.ShowSummaryInRow = True
        tableSummaryRow1.Title = " Συνολικές Καταχωρήσεις : {items}            Συνολίκα Προιόντα : {posotita}                                                                                             Συνολίκη Αξία (Τζίρος): {TotalProduct} "
        tableSummaryRow1.Position = VerticalPosition.Bottom

        Dim summaryυColumn1 As New GridSummaryColumn()
        summaryυColumn1.Name = "TotalProduct"
        summaryυColumn1.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryυColumn1.Format = "{Sum:c}"
        summaryυColumn1.MappingName = "Τιμή_Πώλησης"

        Dim summaryυColumn2 As New GridSummaryColumn()
        summaryυColumn2.Name = "items"
        summaryυColumn2.SummaryType = Syncfusion.Data.SummaryType.CountAggregate
        summaryυColumn2.Format = "{Count:d}"
        summaryυColumn2.MappingName = "Τιμή_Πώλησης"

        Dim summaryυColumn3 As New GridSummaryColumn()
        summaryυColumn3.Name = "posotita"
        summaryυColumn3.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryυColumn3.Format = "{Sum}"
        summaryυColumn3.MappingName = "Ποσότητα"

        tableSummaryRow1.SummaryColumns.Add(summaryυColumn1)
        tableSummaryRow1.SummaryColumns.Add(summaryυColumn2)
        tableSummaryRow1.SummaryColumns.Add(summaryυColumn3)
        Me.SfDataGrid1.TableSummaryRows.Add(tableSummaryRow1)

        ' Creates the GridSummaryRow.
        Dim groupSummaryRow1 As New GridSummaryRow()
        groupSummaryRow1.Name = "GroupSummary"
        groupSummaryRow1.ShowSummaryInRow = True
        groupSummaryRow1.Title = "Συνολικός ΤΖΙΡΟΣ (ΑΝΑ ΚΑΤΗΓΟΡΙΑ)  : {UnitPrice}"

        ' Creates the GridSummaryColumn.
        Dim summaryColumn1 As New GridSummaryColumn()
        summaryColumn1.Name = "UnitPrice"
        summaryColumn1.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryColumn1.Format = "{Sum:c}"
        summaryColumn1.MappingName = "Τιμή_Πώλησης"

        ' Adds the GridSummaryColumn in SummaryColumns collection.
        groupSummaryRow1.SummaryColumns.Add(summaryColumn1)

        ' Adds the summary row in the GroupSummaryRows collection.
        Me.SfDataGrid1.GroupSummaryRows.Add(groupSummaryRow1)

    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click

        If Panel3.Visible = True Then
            GunaTransition2.HideSync(Panel3)
        End If
        If Panel5.Visible = True Then
            GunaTransition2.HideSync(Panel5)
        End If
        If Panel4.Visible = True Then
            GunaTransition1.HideSync(Panel4)

        End If
        If Panel7.Visible = True Then
            GunaTransition2.HideSync(Panel7)
        End If
        If Panel6.Visible = True Then
            GunaTransition1.HideSync(Panel6)
        End If
        If Panel9.Visible = True Then
            GunaTransition2.HideSync(Panel9)
        End If
        If Panel8.Visible = True Then
            GunaTransition1.HideSync(Panel8)
        End If
        GunaTransition1.ShowSync(Panel2)
    End Sub
    Public Sub disp_data()
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from pointOS"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        SfDataGrid1.DataSource = dt



    End Sub
    Dim idPar As String
    Dim periPar As String
    Dim kostPar As Decimal
    Dim posPar As String
    Dim timhpPar As Decimal
    Dim katPar As String
    Dim hmPar As Date
    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        Panel3.Location = New Point(37, 21)
        GunaTransition2.ShowSync(Panel3)
        fixValue = 1.5
        idPar = "1"
        periPar = "Freddo Espresso (Double)"
        kostPar = 1
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar

    End Sub
    Dim fixValue As Decimal
    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        GunaTextBox1.Text = (Convert.ToDecimal(GunaTextBox1.Text) + 1).ToString
        GunaTextBox2.Text = (fixValue * Convert.ToDecimal(GunaTextBox1.Text)).ToString
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        If GunaTextBox1.Text = "0" Then
            MsgBox("Δεν μπορει να εχει το πεδιο αρνητικη τιμη!!")
        Else
            GunaTextBox1.Text = (Convert.ToDecimal(GunaTextBox1.Text) - 1).ToString
            GunaTextBox2.Text = (Convert.ToDecimal(GunaTextBox2.Text) - fixValue).ToString
        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub BunifuTileButton20_Click(sender As Object, e As EventArgs) Handles BunifuTileButton20.Click
        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = con
        mycommand.CommandText = "INSERT INTO pointOS (ID_Προιόντος, Κατηγορία,Περιγραφή,Ποσότητα,Κοστολόγιο,Τιμή_Πώλησης,ΗΜ) VALUES (@ID, @kat, @peri, @pos,@kost,@timhp,@hm)"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        Try
            mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = idPar
            mycommand.Parameters.Add("@peri", SqlDbType.NVarChar).Value = periPar
            mycommand.Parameters.Add("@kost", SqlDbType.Decimal).Value = kostPar
            mycommand.Parameters.Add("@pos", SqlDbType.Decimal).Value = GunaTextBox1.Text
            mycommand.Parameters.Add("@timhp", SqlDbType.Decimal).Value = Convert.ToDecimal(GunaTextBox2.Text)
            mycommand.Parameters.Add("@kat", SqlDbType.NVarChar).Value = katPar
            mycommand.Parameters.Add("@hm", SqlDbType.Date).Value = Date.Now
            mycommand.ExecuteNonQuery()

            GunaTransition2.HideSync(Panel3)
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
        con.Close()
        disp_data()
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        'GunaTransition1.ShowSync(Panel2)
        Panel4.Location = New Point(9, 275)
        If Panel3.Visible = True Then
            GunaTransition2.HideSync(Panel3)
        End If
        If Panel2.Visible = True Then
            GunaTransition1.HideSync(Panel2)
        End If
        If Panel5.Visible = True Then
            GunaTransition2.HideSync(Panel5)
        End If
        If Panel7.Visible = True Then
            GunaTransition2.HideSync(Panel7)
        End If
        If Panel6.Visible = True Then
            GunaTransition1.HideSync(Panel6)
        End If
        If Panel9.Visible = True Then
            GunaTransition2.HideSync(Panel9)
        End If
        If Panel8.Visible = True Then
            GunaTransition1.HideSync(Panel8)
        End If
        GunaTransition1.ShowSync(Panel4)
    End Sub

    Private Sub BunifuTileButton35_Click(sender As Object, e As EventArgs) Handles BunifuTileButton35.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.5
        idPar = "15"
        periPar = "Ψωμί"
        kostPar = 1.0
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,5"
        GunaTextBox4.Text = "1"


    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        Panel6.Location = New Point(9, 275)
        If Panel3.Visible = True Then
            GunaTransition2.HideSync(Panel3)
        End If
        If Panel2.Visible = True Then
            GunaTransition1.HideSync(Panel2)
        End If
        If Panel5.Visible = True Then
            GunaTransition2.HideSync(Panel5)
        End If
        If Panel4.Visible = True Then
            GunaTransition1.HideSync(Panel4)
        End If
        If Panel7.Visible = True Then
            GunaTransition2.HideSync(Panel7)
        End If
        If Panel9.Visible = True Then
            GunaTransition2.HideSync(Panel9)
        End If
        If Panel8.Visible = True Then
            GunaTransition1.HideSync(Panel8)
        End If
        GunaTransition1.ShowSync(Panel6)
    End Sub

    Private Sub BunifuTileButton56_Click(sender As Object, e As EventArgs) Handles BunifuTileButton56.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 15
        idPar = "32"
        periPar = "Τούρτα (Διάφορα)"
        kostPar = 12
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "15,0"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton74_Click(sender As Object, e As EventArgs) Handles BunifuTileButton74.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 0.5
        idPar = "49"
        periPar = "Νερό"
        kostPar = 0.2
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "0,50"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        Panel8.Location = New Point(9, 275)
        If Panel3.Visible = True Then
            GunaTransition2.HideSync(Panel3)
        End If
        If Panel2.Visible = True Then
            GunaTransition1.HideSync(Panel2)
        End If
        If Panel5.Visible = True Then
            GunaTransition2.HideSync(Panel5)
        End If
        If Panel4.Visible = True Then
            GunaTransition1.HideSync(Panel4)
        End If
        If Panel7.Visible = True Then
            GunaTransition2.HideSync(Panel7)
        End If
        If Panel6.Visible = True Then
            GunaTransition1.HideSync(Panel6)
        End If
        If Panel9.Visible = True Then
            GunaTransition2.HideSync(Panel9)
        End If
        GunaTransition1.ShowSync(Panel8)
    End Sub

    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 1.8
        idPar = "2"
        periPar = "Freddo Cappuccino (Double)"
        kostPar = 1.2
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "1,8"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton7_Click(sender As Object, e As EventArgs) Handles BunifuTileButton7.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 1.3
        idPar = "3"
        periPar = "Espresso"
        kostPar = 1.0
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "1,3"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton8_Click(sender As Object, e As EventArgs) Handles BunifuTileButton8.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 1.5
        idPar = "4"
        periPar = "Espresso (Double)"
        kostPar = 1.0
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "1,5"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton9_Click(sender As Object, e As EventArgs) Handles BunifuTileButton9.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 2
        idPar = "5"
        periPar = "Freddo Cappuccino (Φυτική)"
        kostPar = 1.3
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "2"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton10_Click(sender As Object, e As EventArgs) Handles BunifuTileButton10.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 1.8
        idPar = "6"
        periPar = "Cappuccino"
        kostPar = 1.4
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "1,8"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton11_Click(sender As Object, e As EventArgs) Handles BunifuTileButton11.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 2
        idPar = "7"
        periPar = "Σοκολάτα (Απλή)"
        kostPar = 1.4
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "2"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton12_Click(sender As Object, e As EventArgs) Handles BunifuTileButton12.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 2
        idPar = "8"
        periPar = "Σοκολάτα (Γέυσεις)"
        kostPar = 1.4
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "2"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton13_Click(sender As Object, e As EventArgs) Handles BunifuTileButton13.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 1.2
        idPar = "9"
        periPar = "ΝΕΣ / Φραπέ"
        kostPar = 0.6
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "1,2"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton14_Click(sender As Object, e As EventArgs) Handles BunifuTileButton14.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 1.2
        idPar = "10"
        periPar = "Φίλτρου"
        kostPar = 0.7
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "1,2"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton15_Click(sender As Object, e As EventArgs) Handles BunifuTileButton15.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 1.2
        idPar = "11"
        periPar = "Ελληνικός"
        kostPar = 0.5
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "1,2"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton16_Click(sender As Object, e As EventArgs) Handles BunifuTileButton16.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 1.5
        idPar = "12"
        periPar = "Τσάι Ζεστό"
        kostPar = 1.2
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "1,5"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton17_Click(sender As Object, e As EventArgs) Handles BunifuTileButton17.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 2.5
        idPar = "13"
        periPar = "Γιαγιά Μας (Νερό)"
        kostPar = 2
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "2,5"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton18_Click(sender As Object, e As EventArgs) Handles BunifuTileButton18.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 3
        idPar = "14"
        periPar = "Γιαγιά Μας (Σόδα)"
        kostPar = 2.5
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "3"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub BunifuTileButton19_Click(sender As Object, e As EventArgs) Handles BunifuTileButton19.Click
        GunaTransition2.ShowSync(Panel3)
        fixValue = 1.8
        idPar = "15"
        periPar = "Κακάο"
        kostPar = 1.2
        katPar = "Καφές"
        Label6.Text = katPar
        Label7.Text = kostPar.ToString
        Label8.Text = periPar
        GunaTextBox2.Text = "1,8"
        GunaTextBox1.Text = "1"
    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
        SfDataGrid1.Visible = True
        BunifuButton1.Visible = True
        BunifuButton2.Visible = True
        BunifuButton3.Visible = True
        GunaAdvenceButton12.Visible = True
        GunaButton5.Visible = True
        GunaTextBox9.Visible = True
        GunaVSeparator2.Visible = True
        Label33.Visible = False
    End Sub

    Private Sub GunaAdvenceButton9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SfDataGrid1_Click(sender As Object, e As EventArgs) Handles SfDataGrid1.Click

    End Sub

    Private Sub GunaAdvenceButton10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Dim searchCode As String
    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        searchCode = "[ID_Προιόντος]"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from pointOS where" + searchCode + "='" + GunaTextBox9.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        SfDataGrid1.DataSource = dt
        con.Close()
    End Sub

    Private Sub GunaAdvenceButton12_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton12.Click
        Dim result As DialogResult = MessageBoxAdv.Show("Θέλετε να διαγράψετε ΟΛΕΣ τις καταχωρήσεις?", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from pointOS "
                cmd.ExecuteNonQuery()

                disp_data()
                con.Close()
                MessageBoxAdv.Show("Η διαγραφή όλων των εγγραφών έγινε με επιτυχία.", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch
                MessageBoxAdv.Show("Αποτυχία διαγραφής εγγραφών", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
            End Try
        Else

        End If
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        disp_data()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim columnChooser = New Syncfusion.WinForms.DataGrid.Interactivity.ColumnChooser(SfDataGrid1)

        columnChooser.Location = New Point(5, 5)
        'this.panel1.Controls.Add(columnChooser);
        Dim columnChooserPopup = New Syncfusion.WinForms.DataGrid.Interactivity.ColumnChooserPopup(SfDataGrid1)
        columnChooserPopup.Show()
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Try
            SfDataGrid1.ClearFilters()
            MessageBoxAdv.Show("Τα φίλτρα αφαιρέθηκαν με επιτυχία", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exc As Exception
            MessageBoxAdv.Show("Δεν ήταν δυνατόν να αφαιρεθούν τα φίλτρα.", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GunaTextBox9_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox9.TextChanged

    End Sub

    Private Sub GunaTextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox9.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            searchCode = "[ID_Προιόντος]"
            If con.State = ConnectionState.Open Then
                con.Close()

            End If

            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from pointOS where" + searchCode + "='" + GunaTextBox9.Text + "'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            SfDataGrid1.DataSource = dt
            con.Close()
            ' If GunaDataGridView1.Rows.Count > 0 Then
            'GunaButton8.PerformClick()

            MessageBoxAdv.Show("Η εγγραφή βρέθηκε", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)


            'End If
        End If
    End Sub

    Private Sub GunaTextBox9_LostFocus(sender As Object, e As EventArgs) Handles GunaTextBox9.LostFocus
        GunaTextBox9.Text = "Αναζήτηση Καταχώρησης"
    End Sub

    Private Sub GunaTextBox9_GotFocus(sender As Object, e As EventArgs) Handles GunaTextBox9.GotFocus
        GunaTextBox9.Text = ""
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        GunaTextBox4.Text = (Convert.ToDecimal(GunaTextBox4.Text) + 1).ToString
        GunaTextBox3.Text = (fixValue * Convert.ToDecimal(GunaTextBox4.Text)).ToString
    End Sub

    Private Sub GunaTextBox4_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox4.TextChanged

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        If GunaTextBox4.Text = "0" Then
            MsgBox("Δεν μπορει να εχει το πεδιο αρνητικη τιμη!!")
        Else
            GunaTextBox4.Text = (Convert.ToDecimal(GunaTextBox4.Text) - 1).ToString
            GunaTextBox3.Text = (Convert.ToDecimal(GunaTextBox3.Text) - fixValue).ToString
        End If
    End Sub

    Private Sub BunifuTileButton38_Click(sender As Object, e As EventArgs) Handles BunifuTileButton38.Click
        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = con
        mycommand.CommandText = "INSERT INTO pointOS (ID_Προιόντος, Κατηγορία,Περιγραφή,Ποσότητα,Κοστολόγιο,Τιμή_Πώλησης,ΗΜ) VALUES (@ID, @kat, @peri, @pos,@kost,@timhp,@hm)"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        Try
            mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = idPar
            mycommand.Parameters.Add("@peri", SqlDbType.NVarChar).Value = periPar
            mycommand.Parameters.Add("@kost", SqlDbType.Decimal).Value = kostPar
            mycommand.Parameters.Add("@pos", SqlDbType.Decimal).Value = GunaTextBox4.Text
            mycommand.Parameters.Add("@timhp", SqlDbType.Decimal).Value = Convert.ToDecimal(GunaTextBox3.Text)
            mycommand.Parameters.Add("@kat", SqlDbType.NVarChar).Value = katPar
            mycommand.Parameters.Add("@hm", SqlDbType.Date).Value = Date.Now
            mycommand.ExecuteNonQuery()

            GunaTransition2.HideSync(Panel5)
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
        con.Close()
        disp_data()
    End Sub

    Private Sub BunifuTileButton34_Click(sender As Object, e As EventArgs) Handles BunifuTileButton34.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 0.5
        idPar = "16"
        periPar = "Κουλούρι"
        kostPar = 0.2
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "0,5"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton33_Click(sender As Object, e As EventArgs) Handles BunifuTileButton33.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.5
        idPar = "17"
        periPar = "Τυρόψωμο"
        kostPar = 1.0
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,5"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton32_Click(sender As Object, e As EventArgs) Handles BunifuTileButton32.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.5
        idPar = "18"
        periPar = "Ζαμπόν -Κασέρι"
        kostPar = 1
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,5"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton31_Click(sender As Object, e As EventArgs) Handles BunifuTileButton31.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.4
        idPar = "19"
        periPar = "Χειροποίητες Πίτες(ΤΕΜ)"
        kostPar = 1
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,4"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton30_Click(sender As Object, e As EventArgs) Handles BunifuTileButton30.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 9
        idPar = "20"
        periPar = "Χειροποίητες Πίτες (ΚΙΛΟ)"
        kostPar = 7
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "9,0"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton29_Click(sender As Object, e As EventArgs) Handles BunifuTileButton29.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.5
        idPar = "21"
        periPar = "Λουκανόπιτα"
        kostPar = 1
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,5"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton28_Click(sender As Object, e As EventArgs) Handles BunifuTileButton28.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.4
        idPar = "22"
        periPar = "Τυρόπιτα Καλαβρύτων"
        kostPar = 0.9
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,4"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton36_Click(sender As Object, e As EventArgs) Handles BunifuTileButton36.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 2.2
        idPar = "23"
        periPar = "Σάντουιτς (Μικρό)"
        kostPar = 1.8
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "2,2"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton27_Click(sender As Object, e As EventArgs) Handles BunifuTileButton27.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.5
        idPar = "24"
        periPar = "Τυρόπιτα (Στριφτή)"
        kostPar = 1
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,5"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton26_Click(sender As Object, e As EventArgs) Handles BunifuTileButton26.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.5
        idPar = "25"
        periPar = "Πίτσα (Κομμάτι)"
        kostPar = 1
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,5"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton25_Click(sender As Object, e As EventArgs) Handles BunifuTileButton25.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.6
        idPar = "26"
        periPar = "Μεσογειακό"
        kostPar = 1.3
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,6"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton24_Click(sender As Object, e As EventArgs) Handles BunifuTileButton24.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 2
        idPar = "27"
        periPar = "Μπουγάτσα(Κρέμα,Τυρί,Σπανάκι)"
        kostPar = 1.5
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "2,0"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton23_Click(sender As Object, e As EventArgs) Handles BunifuTileButton23.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.5
        idPar = "28"
        periPar = "Τυροκούλουρο (Φιλαδέλφεια)"
        kostPar = 1
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,5"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton22_Click(sender As Object, e As EventArgs) Handles BunifuTileButton22.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 1.8
        idPar = "29"
        periPar = "Καπνιστή Μπριζόλα"
        kostPar = 1.5
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "1,8"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton21_Click(sender As Object, e As EventArgs) Handles BunifuTileButton21.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 2
        idPar = "30"
        periPar = "Πεινιρλί"
        kostPar = 1.5
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "2,0"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub BunifuTileButton37_Click(sender As Object, e As EventArgs) Handles BunifuTileButton37.Click
        GunaTransition2.ShowSync(Panel5)
        fixValue = 2.5
        idPar = "31"
        periPar = "Σάντουιτς (Μεγάλο)"
        kostPar = 2
        katPar = "Άρτος"
        Label11.Text = katPar
        Label10.Text = kostPar.ToString
        Label9.Text = periPar
        GunaTextBox3.Text = "2,5"
        GunaTextBox4.Text = "1"
    End Sub

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        GunaTextBox6.Text = (Convert.ToDecimal(GunaTextBox6.Text) + 1).ToString
        GunaTextBox5.Text = (fixValue * Convert.ToDecimal(GunaTextBox6.Text)).ToString
    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        If GunaTextBox6.Text = "0" Then
            MsgBox("Δεν μπορει να εχει το πεδιο αρνητικη τιμη!!")
        Else
            GunaTextBox6.Text = (Convert.ToDecimal(GunaTextBox6.Text) - 1).ToString
            GunaTextBox5.Text = (Convert.ToDecimal(GunaTextBox5.Text) - fixValue).ToString
        End If
    End Sub

    Private Sub BunifuTileButton39_Click(sender As Object, e As EventArgs) Handles BunifuTileButton39.Click
        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = con
        mycommand.CommandText = "INSERT INTO pointOS (ID_Προιόντος, Κατηγορία,Περιγραφή,Ποσότητα,Κοστολόγιο,Τιμή_Πώλησης,ΗΜ) VALUES (@ID, @kat, @peri, @pos,@kost,@timhp,@hm)"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        Try
            mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = idPar
            mycommand.Parameters.Add("@peri", SqlDbType.NVarChar).Value = periPar
            mycommand.Parameters.Add("@kost", SqlDbType.Decimal).Value = kostPar
            mycommand.Parameters.Add("@pos", SqlDbType.Decimal).Value = GunaTextBox6.Text
            mycommand.Parameters.Add("@timhp", SqlDbType.Decimal).Value = Convert.ToDecimal(GunaTextBox5.Text)
            mycommand.Parameters.Add("@kat", SqlDbType.NVarChar).Value = katPar
            mycommand.Parameters.Add("@hm", SqlDbType.Date).Value = Date.Now
            mycommand.ExecuteNonQuery()

            GunaTransition2.HideSync(Panel7)
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
        con.Close()
        disp_data()
    End Sub

    Private Sub BunifuTileButton55_Click(sender As Object, e As EventArgs) Handles BunifuTileButton55.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 13
        idPar = "33"
        periPar = "Παγωτίνια (ΚΙΛΟ)"
        kostPar = 10
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "13,0"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton54_Click(sender As Object, e As EventArgs) Handles BunifuTileButton54.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 3
        idPar = "34"
        periPar = "Παγωτό (ΜΠΟΥΖΙ)"
        kostPar = 2
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "3,0"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton53_Click(sender As Object, e As EventArgs) Handles BunifuTileButton53.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 1.2
        idPar = "35"
        periPar = "Παγωτό (ΧΥΜΑ)"
        kostPar = 1
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "1,2"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton52_Click(sender As Object, e As EventArgs) Handles BunifuTileButton52.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 10.8
        idPar = "36"
        periPar = "ΜΠΙΣΚΟΤΑ (COOKIE MAN)"
        kostPar = 10
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "10,80"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton51_Click(sender As Object, e As EventArgs) Handles BunifuTileButton51.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 10.8
        idPar = "37"
        periPar = "Κριτσίνια (Διάφορα) (ΚΙΛΟ)"
        kostPar = 10
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "10,80"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton50_Click(sender As Object, e As EventArgs) Handles BunifuTileButton50.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 2.5
        idPar = "38"
        periPar = "Πάστες (ΤΕΜ)"
        kostPar = 2
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "2,50"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton49_Click(sender As Object, e As EventArgs) Handles BunifuTileButton49.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 15
        idPar = "39"
        periPar = "Παστάκια (ΚΙΛΟ)"
        kostPar = 12
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "15,0"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton41_Click(sender As Object, e As EventArgs) Handles BunifuTileButton41.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 13.8
        idPar = "40"
        periPar = "Σοκολατάκια (ΚΙΛΟ)"
        kostPar = 10
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "13,80"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton48_Click(sender As Object, e As EventArgs) Handles BunifuTileButton48.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 2.5
        idPar = "41"
        periPar = "Κομμάτι Τούρτα (ΤΕΜ)"
        kostPar = 2
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "2,50"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton47_Click(sender As Object, e As EventArgs) Handles BunifuTileButton47.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 2
        idPar = "42"
        periPar = "Κρουασάν (ΜΕΓΑΛΟ)"
        kostPar = 1.5
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "2,0"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton46_Click(sender As Object, e As EventArgs) Handles BunifuTileButton46.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 1.5
        idPar = "43"
        periPar = "Ντόνατς"
        kostPar = 1
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "1,50"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton45_Click(sender As Object, e As EventArgs) Handles BunifuTileButton45.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 0.5
        idPar = "44"
        periPar = "Κρουασάν (Μικρό)"
        kostPar = 10
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "0,50"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton44_Click(sender As Object, e As EventArgs) Handles BunifuTileButton44.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 1.7
        idPar = "45"
        periPar = "Γιαούρτι"
        kostPar = 1
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "1,70"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton43_Click(sender As Object, e As EventArgs) Handles BunifuTileButton43.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 1.7
        idPar = "46"
        periPar = "Ρυζόγαλο"
        kostPar = 1
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "1,70"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton42_Click(sender As Object, e As EventArgs) Handles BunifuTileButton42.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 1.7
        idPar = "47"
        periPar = "Κρέμα"
        kostPar = 1
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "1,70"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub BunifuTileButton40_Click(sender As Object, e As EventArgs) Handles BunifuTileButton40.Click
        GunaTransition2.ShowSync(Panel7)
        fixValue = 4
        idPar = "48"
        periPar = "Συσκευασμένα"
        kostPar = 3
        katPar = "Γλυκά"
        Label19.Text = katPar
        Label18.Text = kostPar.ToString
        Label17.Text = periPar
        GunaTextBox5.Text = "4,0"
        GunaTextBox6.Text = "1"
    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click
        GunaTextBox8.Text = (Convert.ToDecimal(GunaTextBox8.Text) + 1).ToString
        GunaTextBox7.Text = (fixValue * Convert.ToDecimal(GunaTextBox8.Text)).ToString
    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        If GunaTextBox8.Text = "0" Then
            MsgBox("Δεν μπορει να εχει το πεδιο αρνητικη τιμη!!")
        Else
            GunaTextBox8.Text = (Convert.ToDecimal(GunaTextBox8.Text) - 1).ToString
            GunaTextBox7.Text = (Convert.ToDecimal(GunaTextBox7.Text) - fixValue).ToString
        End If
    End Sub

    Private Sub BunifuTileButton57_Click(sender As Object, e As EventArgs) Handles BunifuTileButton57.Click
        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = con
        mycommand.CommandText = "INSERT INTO pointOS (ID_Προιόντος, Κατηγορία,Περιγραφή,Ποσότητα,Κοστολόγιο,Τιμή_Πώλησης,ΗΜ) VALUES (@ID, @kat, @peri, @pos,@kost,@timhp,@hm)"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        Try
            mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = idPar
            mycommand.Parameters.Add("@peri", SqlDbType.NVarChar).Value = periPar
            mycommand.Parameters.Add("@kost", SqlDbType.Decimal).Value = kostPar
            mycommand.Parameters.Add("@pos", SqlDbType.Decimal).Value = GunaTextBox8.Text
            mycommand.Parameters.Add("@timhp", SqlDbType.Decimal).Value = Convert.ToDecimal(GunaTextBox7.Text)
            mycommand.Parameters.Add("@kat", SqlDbType.NVarChar).Value = katPar
            mycommand.Parameters.Add("@hm", SqlDbType.Date).Value = Date.Now
            mycommand.ExecuteNonQuery()

            GunaTransition2.HideSync(Panel9)
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
        con.Close()
        disp_data()
    End Sub

    Private Sub BunifuTileButton73_Click(sender As Object, e As EventArgs) Handles BunifuTileButton73.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 1.5
        idPar = "50"
        periPar = "Χυμοί"
        kostPar = 1
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "1,50"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton72_Click(sender As Object, e As EventArgs) Handles BunifuTileButton72.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 2
        idPar = "51"
        periPar = "Μόνστερ"
        kostPar = 1.5
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "2,0"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton71_Click(sender As Object, e As EventArgs) Handles BunifuTileButton71.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 1.2
        idPar = "52"
        periPar = "Αναψυκτικά (Κουτάκι)"
        kostPar = 1
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "1,20"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton70_Click(sender As Object, e As EventArgs) Handles BunifuTileButton70.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 1.5
        idPar = "53"
        periPar = "Αναψυκτικά (500 ml)"
        kostPar = 1
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "1,50"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton69_Click(sender As Object, e As EventArgs) Handles BunifuTileButton69.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 1.5
        idPar = "54"
        periPar = "Sweepes"
        kostPar = 1
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "1,50"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton68_Click(sender As Object, e As EventArgs) Handles BunifuTileButton68.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 1
        idPar = "55"
        periPar = "Σόδα"
        kostPar = 0.5
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "1,00"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton67_Click(sender As Object, e As EventArgs) Handles BunifuTileButton67.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 1.7
        idPar = "56"
        periPar = "Μίλκο (Χαρτί)"
        kostPar = 1.2
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "1,70"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton59_Click(sender As Object, e As EventArgs) Handles BunifuTileButton59.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 2
        idPar = "57"
        periPar = "Μίλκο (Μεγάλο)"
        kostPar = 1
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "2,00"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton66_Click(sender As Object, e As EventArgs) Handles BunifuTileButton66.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 1.4
        idPar = "58"
        periPar = "Μίλκο (Μικρό)"
        kostPar = 1
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "1,40"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton65_Click(sender As Object, e As EventArgs) Handles BunifuTileButton65.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 1
        idPar = "59"
        periPar = "Ζαχαρωτά (Διάφορα)"
        kostPar = 1
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "1"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton64_Click(sender As Object, e As EventArgs) Handles BunifuTileButton64.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 1
        idPar = "60"
        periPar = "Κρουασάν (Συσκευασμένο)"
        kostPar = 0.8
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "1"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub BunifuTileButton63_Click(sender As Object, e As EventArgs) Handles BunifuTileButton63.Click
        GunaTransition2.ShowSync(Panel9)
        fixValue = 1
        idPar = "61"
        periPar = "Νερό (1,5 Λίτρο)"
        kostPar = 0.6
        katPar = "Λοιπά Προιόντα"
        Label27.Text = katPar
        Label26.Text = kostPar.ToString
        Label25.Text = periPar
        GunaTextBox7.Text = "1"
        GunaTextBox8.Text = "1"
    End Sub

    Private Sub GunaAdvenceButton9_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton9.Click
        If GunaTextBox10.Text = "admin12345" Then
            SfDataGrid1.Visible = True
            Panel10.Visible = False
        Else
            MsgBox("Λάθος Συνθηματικό")
        End If

    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Try
            Dim result As DialogResult = MessageBoxAdv.Show("Θέλετε να διαγραψετε ID : " + SfDataGrid1.SelectedItem(1).ToString + " καταχώρηση?", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()

                    End If
                    con.Open()

                    cmd = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "delete from pointOS where Id='" + SfDataGrid1.SelectedItem(0).ToString + "'"
                    cmd.ExecuteNonQuery()

                    disp_data()
                    con.Close()
                    MessageBoxAdv.Show("Η διαγραφή της εγγραφής έγινε με επιτυχία.", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch

                    con.Close()
                End Try
            ElseIf result = DialogResult.No Then

                con.Close()
            End If
        Catch
            MessageBoxAdv.Show("Αποτυχία διαγραφής  εγγραφής", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class