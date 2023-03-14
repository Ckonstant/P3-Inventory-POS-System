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
Public Class expenses
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
    Private Sub expenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EqualHostDataset.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.EqualHostDataset.Sales)


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        BunifuPanel1.Hide()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        GunaAdvenceButton3.Visible = False
        GunaAdvenceButton2.Visible = True
        BunifuPanel1.Visible = True
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        Dim mycommand As SqlClient.SqlCommand = New SqlClient.SqlCommand()
        mycommand.Connection = con
        mycommand.CommandText = "INSERT INTO Sales (perigrafi,kathgoria,timh,posothta,eksoda,hmero) VALUES (@perigrafi,@tameio,@metrhta,@pos,@eksoda,@hmero)"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()

        Try
            mycommand.Parameters.Add("@perigrafi", SqlDbType.NVarChar).Value = GunaLineTextBox1.Text
            mycommand.Parameters.Add("@tameio", SqlDbType.Decimal).Value = DoubleTextBox4.Text
            mycommand.Parameters.Add("@metrhta", SqlDbType.Decimal).Value = DoubleTextBox2.Text
            mycommand.Parameters.Add("@pos", SqlDbType.Decimal).Value = DoubleTextBox3.Text
            mycommand.Parameters.Add("@eksoda", SqlDbType.Decimal).Value = DoubleTextBox1.Text

            mycommand.Parameters.Add("@hmero", SqlDbType.Date).Value = GunaDateTimePicker1.Value

            mycommand.ExecuteNonQuery()
            Form1.Alert1("Επιτυχημένη καταχώρηση Τιμολογίου.", Alert.alertTypeEnum.Success)
        Catch ex As Exception
            MsgBox(ex.Message)
            Form1.Alert1(ex.ToString, Alert.alertTypeEnum.Error)
        End Try
        con.Close()
        disp_data()
        BunifuPanel1.Hide()
    End Sub
    Public Sub disp_data()
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from Sales"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        ' GunaDataGridView1.DataSource = dt

        SfDataGrid1.DataSource = dt

        con.Close()
    End Sub
    Private Sub BunifuPanel1_Click(sender As Object, e As EventArgs) Handles BunifuPanel1.Click

    End Sub

    Private Sub DoubleTextBox4_TextChanged(sender As Object, e As EventArgs) Handles DoubleTextBox4.TextChanged

    End Sub

    Private Sub SfDataGrid1_Click(sender As Object, e As EventArgs) Handles SfDataGrid1.Click

    End Sub
End Class