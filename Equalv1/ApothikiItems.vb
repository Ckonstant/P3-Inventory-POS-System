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
Imports System.Configuration.ConfigurationManager
Public Class ApothikiItems
    Public EditFlag As Boolean = False
    Dim con As New SqlConnection(My.Settings.equalhostDB)
    Private currentForm As Form = Nothing
    Public userFlag As String = "Super Admin"

    Public countPosNEW As Integer = 0
    Dim countR As Integer = 0
    Public countNew As Integer = 0
    Public countKostNew As Double = 0.0
    Dim sum As Double = 0.0
    Dim cmd As New SqlCommand
    Dim sumAplirota As Integer
    Dim sumKathAksia As Double = 0.0
    Dim sumglykaPos As Double = 0.0
    Dim sumKafePos As Double = 0.0
    Dim sumPotaPos As Double = 0.0
    Dim sumArtosPos As Double = 0.0
    Dim sumLoipaPos As Double = 0.0
    Dim sumolaPos As Double = 0.0
    Dim sumKostologio As Double = 0.0
    Dim idproiont As String = "[ID Προιόντος]"
    Dim promitheyt As String = "[Προμηθευτής]"
    Dim kathgoria As String = "[Κατηγορία]"
    Dim fpasearch As String = "[ΦΠΑ]"
    Dim searchCode As String = ""
    Public sumKerdos As Double = 0.0
    Public sumKost As Double = 0.0
    Public sumPolisis As Double = 0.0
    Public sumFPAtimi As Double = 0.0
    Dim adapter As SqlDataAdapter
    Dim cmdBuilder As SqlCommandBuilder
    Dim ds As New DataSet
    Dim changes As DataSet
    Dim sql As String
    Dim popupFlag As Boolean = False
    Public hk As Integer = 0
    ' Public itemKey As Integer = 0
    Public Sub Alert1(msg As String, type As Alert.alertTypeEnum)
        Dim f As Alert = New Alert
        f.setAlert(msg, type)
    End Sub
    Private Sub ApothikiItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EqualHostDataset.EqualDB' table. You can move, or remove it, as needed.
        Me.EqualDBTableAdapter.Fill(Me.EqualHostDataset.EqualDB)
        Me.sfDataGrid1.ShowRowHeader = True

        Me.sfDataGrid1.ShowBusyIndicator = True
        Me.sfDataGrid1.SelectedIndex = 1
        Me.sfDataGrid1.Style.RowHeaderStyle.SelectionMarkerThickness = 4
        Me.sfDataGrid1.RecordContextMenu = New ContextMenuStrip()
        Me.sfDataGrid1.RecordContextMenu.Items.Add("Cut", Nothing, AddressOf OnCutClicked)
        Me.sfDataGrid1.RecordContextMenu.Items.Add("Copy", Nothing, AddressOf OnCopyClicked)
        Me.sfDataGrid1.RecordContextMenu.Items.Add("Paste", Nothing, AddressOf OnPasteClicked)
        summaryControl()
        Form1.itemKey = Convert.ToInt32(sfDataGrid1.SelectedItem(0))
    End Sub

    Private Sub OnCutClicked(ByVal sender As Object, ByVal e As EventArgs)
        Me.sfDataGrid1.ClipboardController.Cut()
    End Sub ' GIA COPY PASTE STO DATAGRID
    Private Sub OnCopyClicked(ByVal sender As Object, ByVal e As EventArgs)
        Me.sfDataGrid1.ClipboardController.Copy()
    End Sub
    Private Sub OnPasteClicked(ByVal sender As Object, ByVal e As EventArgs)
        Me.sfDataGrid1.ClipboardController.Paste()
    End Sub
    Private Sub SfDataGrid1_ToolTipOpening(ByVal sender As Object, ByVal e As ToolTipOpeningEventArgs)
        If String.IsNullOrEmpty(e.DisplayText) Then
            e.ToolTipInfo.Items(0).Text = "Το κελί ειναι άδειο!"
        End If
    End Sub ' GIA ADEIA KELIA sto grid
    Private Sub summaryControl()
        Dim tableSummaryRow1 As New GridTableSummaryRow()
        tableSummaryRow1.Name = "TableSummary"
        tableSummaryRow1.ShowSummaryInRow = True
        tableSummaryRow1.Title = "Συνολικές Καταχωρήσεις στο σύστημα : {countItems}                     Συνολική αξία Στόκ : {kerdos}                              Μέσος Όρος αξίας Προιόντων {averageKerdos}"
        tableSummaryRow1.Position = VerticalPosition.Bottom

        Dim summaryυColumn1 As New GridSummaryColumn()
        summaryυColumn1.Name = "kerdos"
        summaryυColumn1.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryυColumn1.Format = "{Sum:c}"
        summaryυColumn1.MappingName = "Κέρδος"

        Dim summaryυColumn2 As New GridSummaryColumn()
        summaryυColumn2.Name = "averageKerdos"
        summaryυColumn2.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryυColumn2.Format = "{Average:c}"
        summaryυColumn2.MappingName = "Κέρδος"

        Dim summaryυColumn3 As New GridSummaryColumn()
        summaryυColumn3.Name = "countItems"
        summaryυColumn3.SummaryType = Syncfusion.Data.SummaryType.CountAggregate
        summaryυColumn3.Format = "{Count:d}"
        summaryυColumn3.MappingName = "Κέρδος"

        tableSummaryRow1.SummaryColumns.Add(summaryυColumn1)
        tableSummaryRow1.SummaryColumns.Add(summaryυColumn2)
        tableSummaryRow1.SummaryColumns.Add(summaryυColumn3)
        Me.sfDataGrid1.TableSummaryRows.Add(tableSummaryRow1)

        ' Creates the GridSummaryRow.
        Dim groupSummaryRow1 As New GridSummaryRow()
        groupSummaryRow1.Name = "GroupSummary"
        groupSummaryRow1.ShowSummaryInRow = True
        groupSummaryRow1.Title = "Συνολικές Καταχωρήσεις στο σύστημα : {UnitPrice}                     Συνολική αξία Στόκ : {kerdos}                              Μέσος Όρος αξίας Προιόντων {averKer}"

        ' Creates the GridSummaryColumn.
        Dim summaryColumn1 As New GridSummaryColumn()
        summaryColumn1.Name = "UnitPrice"
        summaryColumn1.SummaryType = Syncfusion.Data.SummaryType.CountAggregate
        summaryColumn1.Format = "{Count:d}"
        summaryColumn1.MappingName = "Κοστολόγιο"

        Dim summaryColumn2 As New GridSummaryColumn()
        summaryColumn2.Name = "kerdos"
        summaryColumn2.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryColumn2.Format = "{Sum:c}"
        summaryColumn2.MappingName = "Κέρδος"

        Dim summaryColumn3 As New GridSummaryColumn()
        summaryColumn3.Name = "averKer"
        summaryColumn3.SummaryType = Syncfusion.Data.SummaryType.DoubleAggregate
        summaryColumn3.Format = "{Average:c}"
        summaryColumn3.MappingName = "Κέρδος"

        ' Adds the GridSummaryColumn in SummaryColumns collection.
        groupSummaryRow1.SummaryColumns.Add(summaryColumn1)
        groupSummaryRow1.SummaryColumns.Add(summaryColumn2)
        groupSummaryRow1.SummaryColumns.Add(summaryColumn3)
        ' Adds the summary row in the GroupSummaryRows collection.
        Me.sfDataGrid1.GroupSummaryRows.Add(groupSummaryRow1)
    End Sub ' Sinolika athroismata gia group kai datagrid kelia
    Public Sub disp_data()
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        sql = "select * from EqualDB"

        ds.Clear()

        adapter = New SqlDataAdapter(sql, con)
        adapter.Fill(ds)

        sfDataGrid1.DataSource = ds.Tables(0)


        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from EqualDB"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        GunaDataGridView1.DataSource = dt
        sfDataGrid1.DataSource = dt
        con.Close()

    End Sub ' Dihnei to data ths EqualDB kai kanei refresh 
    Public Sub openChildForm(childForm As Form)
        '' GunaTransition1.HideSync(currentForm)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Form1.pn_settings.Controls.Add(childForm)
        Form1.pn_settings.Tag = childForm
        childForm.BringToFront()
        ''childForm.Visible = False
        ''GunaTransition1.ShowSync(currentForm)
        childForm.Opacity = 85
        childForm.Show()
        ''GunaTransition1.ShowSync(childForm)
        ''childForm.Visible = True


    End Sub
    Private Sub sfDataGrid1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Delete) Then
            Dim result As DialogResult = MessageBox.Show("Θέλετε να διαγραψετε ID PRODUCT: " + sfDataGrid1.SelectedItem(1).ToString + " καταχώρηση?", "EqualDB", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()

                    End If
                    con.Open()

                    cmd = con.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "delete from EqualDB where Id='" + sfDataGrid1.SelectedItem(0).ToString + "'"
                    cmd.ExecuteNonQuery()

                    disp_data()
                    con.Close()
                    MsgBox("Επιτυχημένη διαγραφη στοιχείου!")
                Catch ex As Exception
                    MsgBox("Nothing to delete or faulty SQL connection")
                    con.Close()
                End Try
            ElseIf result = DialogResult.No Then

                con.Close()
            End If
        End If
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Form1.Button1.PerformClick()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        disp_data()
        Alert1("Έγινε ανανέωση του Grid με επιτυχία", Alert.alertTypeEnum.Info)
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim columnChooserPopup = New Syncfusion.WinForms.DataGrid.Interactivity.ColumnChooserPopup(sfDataGrid1)
        If popupFlag = False Then
            columnChooserPopup.Show()
            popupFlag = True
        Else
            columnChooserPopup.Close()
            popupFlag = False
        End If
    End Sub
    Private Sub SfDataGrid1_QueryCellStyle1(ByVal sender As Object, ByVal e As QueryCellStyleEventArgs)
        If e.Column.MappingName = "Paid" Then
            If e.DisplayText = "Πληρώθηκε" Then
                e.Style.BackColor = FromArgb(200, 46, 204, 113)
            Else
                e.Style.BackColor = IndianRed
            End If

            ' If e.DisplayText = "Απλήρωτο" Then
            'e.Style.BackColor = FromArgb(200, 230, 126, 34)

            ' If

        End If
        If e.Column.MappingName = "ΕΚΠΤ" Then
            If e.DisplayText > 0 Then
                e.Style.BackColor = DarkOrange
            End If
        End If
    End Sub
    Private Sub SfDataGrid1_QueryRowStyle(ByVal sender As Object, ByVal e As QueryRowStyleEventArgs)
        If e.RowType = RowType.DefaultRow Then
            Dim dataRowView = TryCast(e.RowData, DataRowView)
            If dataRowView IsNot Nothing Then
                Dim dataRow = dataRowView.Row
                Dim cellValue = dataRow("Κατηγορία").ToString

                If cellValue = "Καφές" Then
                    e.Style.BackColor = FromArgb(200, 164, 164, 164)

                End If
                If cellValue = "Άρτος" Then
                    e.Style.BackColor = FromArgb(200, 230, 126, 34)

                End If
                If cellValue = "Γλυκά" Then
                    e.Style.BackColor = FromArgb(200, 46, 204, 113)

                End If
                If cellValue = "Λοιπά Προιόντα" Then
                    e.Style.BackColor = FromArgb(200, 52, 152, 219)

                End If
                If cellValue = "Ποτά" Then
                    e.Style.BackColor = FromArgb(200, 66, 58, 170)

                End If
            End If
        End If
    End Sub
    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Try
            sfDataGrid1.ClearFilters()
            MessageBoxAdv.Show("Τα φίλτρα αφαιρέθηκαν με επιτυχία", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exc As Exception
            MessageBoxAdv.Show("Δεν ήταν δυνατόν να αφαιρεθούν τα φίλτρα.", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Try
            Dim result As DialogResult = MessageBoxAdv.Show("Θέλετε να διαγραψετε ID : " + sfDataGrid1.SelectedItem(1).ToString + " καταχώρηση?", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from EqualDB where Id='" + sfDataGrid1.SelectedItem(0).ToString + "'"
                cmd.ExecuteNonQuery()

                disp_data()
                con.Close()
                Alert1("Η διαγραφή του στοιχείου" + " πραγματοιποιήθηκε με επιτυχία.", Alert.alertTypeEnum.Info)
                sfDataGrid1.SelectedIndex = 1

            ElseIf result = DialogResult.No Then

                con.Close()
            End If
        Catch ex As Exception
            Alert1("Αποτυχημένη διαγραφή του στοιχείου.", Alert.alertTypeEnum.Error)
            con.Close()
        End Try
    End Sub

    Private Sub StatusBarAdvPanel1_Paint(sender As Object, e As PaintEventArgs) Handles StatusBarAdvPanel1.Paint

    End Sub

    Private Sub BunifuToggleSwitch1_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs) Handles BunifuToggleSwitch1.CheckedChanged
        If BunifuToggleSwitch1.Checked = True Then
            AddHandler sfDataGrid1.QueryCellStyle, AddressOf SfDataGrid1_QueryCellStyle1
            'AddHandler sfDataGrid1.DrawCell, AddressOf SfDataGrid1_DrawCell1
            'AddHandler sfDataGrid1.QueryRowStyle, AddressOf SfDataGrid1_QueryRowStyle
            sfDataGrid1.Refresh()
        Else
            RemoveHandler sfDataGrid1.QueryCellStyle, AddressOf SfDataGrid1_QueryCellStyle1
            sfDataGrid1.Refresh()
        End If
    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged

    End Sub

    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunaTextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            searchCode = "[ID_Προιόντος]"
            If con.State = ConnectionState.Open Then
                con.Close()

            End If

            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from EqualDB where" + searchCode + "='" + GunaTextBox1.Text + "'"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            sfDataGrid1.DataSource = dt
            con.Close()
            ' If GunaDataGridView1.Rows.Count > 0 Then
            'GunaButton8.PerformClick()
            MessageBoxAdv.Show("Επιτυχημενο Σκαναρισμα.Το στοιχείο βρέθηκε!!", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        End If
    End Sub

    Private Sub sfDataGrid1_DoubleClick(sender As Object, e As EventArgs) Handles sfDataGrid1.DoubleClick
        ' EditFlag = True
        'Form1.itemKey = Convert.ToInt32(sfDataGrid1.SelectedItem(0))
        'openChildForm(Form2)
        Form1.Button1.PerformClick()
    End Sub

    Private Sub sfDataGrid1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles sfDataGrid1.CellDoubleClick
        Form1.EditFlag = True
        'Form1.itemKey = Convert.ToInt32(Me.sfDataGrid1.SelectedItem(0))
        ' Form1.Button1.PerformClick()
        openChildForm(Form2)
    End Sub
End Class