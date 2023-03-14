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
'Imports Syncfusion.WinForms.DataGridConverter
Public Class Form1
    Public itemKey As Int32 = 0
    Public userFlag As String = "Super Admin"
    Public EditFlag As Boolean = False
    Public countPosNEW As Integer = 0
    Dim countR As Integer = 0
    Public countNew As Integer = 0
    Public countKostNew As Double = 0.0
    Dim sum As Double = 0.0
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection(My.Settings.Database1ConnectionString)
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

    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http: //www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function ' CHECK INTERNET CONNECTION 


    Private Sub SfDataGrid1_ToolTipOpening(ByVal sender As Object, ByVal e As ToolTipOpeningEventArgs)
        If String.IsNullOrEmpty(e.DisplayText) Then
            e.ToolTipInfo.Items(0).Text = "Το κελί ειναι άδειο!"
        End If
    End Sub ' GIA ADEIA KELIA sto grid


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        Me.TimologioTableAdapter.Fill(Me.Database1DataSet.timologio)

        If userLogin.uFlag = "chkonstant" Then
            nav_settings.Enabled = False
            nav_home.Enabled = False
            GunaAdvenceButton3.PerformClick()
            GunaPictureBox4.Visible = True
            GunaPictureBox3.Visible = False
            GunaAdvenceButton1.Enabled = False
            'StatusBarAdvPanel1.Text = "Συνδεδεμένος Χρήστης -> chkonstant"
        Else
            GunaPictureBox4.Visible = False
            GunaPictureBox3.Visible = True
            nav_settings.Enabled = True
            nav_home.Enabled = True
            GunaAdvenceButton1.Enabled = True
            'nav_settings.PerformClick()
            'StatusBarAdvPanel1.Text = "Συνδεδεμένος Χρήστης -> Διαχειριστής Συστήματος"
        End If
        'TODO: This line of code loads data into the 'Database1DataSet.EqualDB' table. You can move, or remove it, as needed.
        Me.EqualDBTableAdapter.Fill(Me.Database1DataSet.EqualDB)

        up_deletedRows()
        'TODO: This line of code loads data into the 'Database1DataSet.EqualDB' table. You can move, or remove it, as needed.
        Me.EqualDBTableAdapter.Fill(Me.Database1DataSet.EqualDB)
        'TODO: This line of code loads data into the 'Database1DataSet.EqualDB' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Database1DataSet.EqualDB' table. You can move, or remove it, as needed.
        Me.EqualDBTableAdapter.Fill(Me.Database1DataSet.EqualDB)
        ' disp_data()

        If CheckForInternetConnection() = True Then
            'StatusBarAdvPanel2.Text = "Connected"
        Else
            ' StatusBarAdvPanel2.Text = "No connection to server"
        End If
        'TODO: This line of code loads data into the 'Database1DataSet1.PrintTable' table. You can move, or remove it, as needed.
        ' Me.PrintTableTableAdapter.Fill(Me.Database1DataSet1.PrintTable)
        'TODO: This line of code loads data into the 'Database1DataSet.PrintTable' table. You can move, or remove it, as needed.
        Me.PrintTableTableAdapter.Fill(Me.Database1DataSet.PrintTable)


        'TODO: This line of code loads data into the 'Database1DataSet.EqualDB' table. You can move, or remove it, as needed.
        ' Me.EqualDBTableAdapter.Fill(Me.Database1DataSet.EqualDB)



        Timer1.Start()



        '' Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        '' Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnBody, Brushes.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        '' con.ConnectionString = " Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Akuaku\source\repos\Equalv1\Equalv1\Database1.mdf;Integrated Security=True;character set = utf8;"

        ''Label10.Text = "Συνολικά Βρέθηκαν: " + GunaDataGridView1.Rows.Count.ToString + " Καταχωρήσεις προιόντων στο σύστημα."


        openChildForm10(dashMain)








    End Sub






    ' Dihnei to data ths EqualDB kai kanei refresh 





    Dim i As Integer







    Private Sub nav_profile_Click_1(sender As Object, e As EventArgs) Handles nav_profile.Click
        If Application.OpenForms().OfType(Of ApothikiItems).Any Or Application.OpenForms().OfType(Of Form2).Any Then
            ' itemKey = Convert.ToInt32(ApothikiItems.sfDataGrid1.SelectedItem(0))
            ApothikiItems.Close()
            Form2.Close()
            openChildForm10(expenses)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        Else
            openChildForm10(expenses)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        End If

    End Sub ' 


    Private Sub nav_home_Click_1(sender As Object, e As EventArgs) Handles nav_home.Click
        If nav_home.Checked Then
            If Application.OpenForms().OfType(Of ApothikiItems).Any Or Application.OpenForms().OfType(Of Form2).Any Then
                ' itemKey = Convert.ToInt32(ApothikiItems.sfDataGrid1.SelectedItem(0))
                ApothikiItems.Close()
                Form2.Close()
                openChildForm10(ApothikiItems)
                ''GunaTransition1.ShowSync(GunaPanel15)
                'GunaPanel13.BringToFront()
            Else
                openChildForm10(ApothikiItems)
                ''GunaTransition1.ShowSync(GunaPanel15)
                'GunaPanel13.BringToFront()
            End If
        End If
    End Sub '  Open apothiki tab



    Private Sub nav_history_Click_1(sender As Object, e As EventArgs) Handles nav_history.Click
        sumKathAksia = 0.0
        If Application.OpenForms().OfType(Of ApothikiItems).Any Or Application.OpenForms().OfType(Of dashMain).Any Or Application.OpenForms().OfType(Of Form2).Any Or Application.OpenForms().OfType(Of Form6).Any Or Application.OpenForms().OfType(Of Form4).Any Or Application.OpenForms().OfType(Of gridViewer).Any Then
            ' itemKey = Convert.ToInt32(ApothikiItems.sfDataGrid1.SelectedItem(0))
            ApothikiItems.Close()
            Form2.Close()
            dashMain.Close()
            Form6.Close()
            Form4.Close()
            gridViewer.Close()
            openChildForm10(gridViewer)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        Else
            openChildForm10(gridViewer)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        End If
        '' For i As Integer = 0 To GunaDataGridView1.Rows.Count - 1
        ''sumKathAksia += GunaDataGridView1.Rows(i).Cells(10).Value
        '' Next
        '' Label33.Text = sumKathAksia.ToString("N2")
    End Sub



    Public Sub disp_dataTimologia()
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

        GunaDataGridView3.DataSource = dt

        con.Close()
    End Sub 'refresh data gia timologia



    Private Sub nav_settings_Click_1(sender As Object, e As EventArgs) Handles nav_settings.Click
        If Application.OpenForms().OfType(Of ApothikiItems).Any Or Application.OpenForms().OfType(Of Form2).Any Or Application.OpenForms().OfType(Of dashMain).Any Then
            ' itemKey = Convert.ToInt32(ApothikiItems.sfDataGrid1.SelectedItem(0))
            ApothikiItems.Close()
            Form2.Close()
            dashMain.Close()
            openChildForm10(dashMain)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        Else
            openChildForm10(dashMain)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        End If
    End Sub ' anoigei thn arhiki kartela kai fortonei ta dedomena sta charts





    Private Sub GunaDataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)

        EditFlag = True

        Form2.Show()

    End Sub





    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs)

    End Sub






    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString()
    End Sub





    Private Sub GunaDataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs)

    End Sub




    Private Sub GunaButton12_Click(sender As Object, e As EventArgs)

    End Sub
    Dim filenameEXCEL As String
    Private Sub GunaButton10_Click(sender As Object, e As EventArgs)

    End Sub




    Private currentForm As Form = Nothing





    Private Sub HelloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelloToolStripMenuItem.Click

    End Sub


    Dim searchflag As Boolean = True












    Dim sumGlyka As Double = 0.0
    Dim sumKafes As Double = 0.0
    Dim sumArtos As Double = 0.0
    Dim sumLoipa As Double = 0.0
    Dim sumPota As Double = 0.0
    Dim sumola As Double = 0.0






    Private Sub GunaButton23_Click(sender As Object, e As EventArgs) Handles GunaButton23.Click
        'GunaPanel8.Size = New Size(187, 668)
        ' GunaPanel9.Size = New Size(1169, 643)
        ''  GunaPanel4.Size = New Size(1360, 609)
        ''GunaDataGridView1.Size = New Size(1162, 557)
        ''Label11.Visible = True
        '' GunaPictureBox3.Visible = True
        '' GunaPictureBox4.Visible = False
        GunaButton23.Visible = False
        GunaButton22.Visible = True
        ' GunaButton14.Visible = False
        'GunaButton15.Visible = True
        GunaPanel8.Visible = False
        GunaPanel8.Width = 187
        GunaTransition2.ShowSync(GunaPanel8)
    End Sub ' gia to menu sta aristera

    Private Sub GunaButton22_Click(sender As Object, e As EventArgs) Handles GunaButton22.Click
        'GunaPanel8.Size = New Size(40, 668)
        'GunaPanel9.Size = New Size(1300, 643)
        ''  GunaPanel4.Size = New Size(1360, 609)
        ''GunaDataGridView1.Size = New Size(1162, 557)
        '' Label11.Visible = True
        '' GunaPictureBox3.Visible = True
        '' GunaPictureBox4.Visible = False
        GunaButton22.Visible = False
        GunaButton23.Visible = True
        GunaPanel8.Visible = False
        GunaPanel8.Width = 40
        GunaTransition2.ShowSync(GunaPanel8)
    End Sub ' gia to menu sta aristera



    Private Sub GunaButton31_Click(sender As Object, e As EventArgs) Handles GunaButton31.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro

        Dim result As DialogResult
        Try

            result = MessageBoxAdv.Show("Θέλετε να αποσυνδεθείτε;", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                userLogin.Show()
                Me.Close()
            End If
        Catch
        End Try

    End Sub 'aposindesi hristi


    Dim countDays As Integer = 0


    Private Sub GunaDateTimePicker4_ValueChanged(sender As Object, e As EventArgs)
        sumglykaPos = 0.0
        sumKafePos = 0.0
        sumPotaPos = 0.0
        sumLoipaPos = 0.0
        sumArtosPos = 0.0
        sumolaPos = 0.0
        sumGlyka = 0.0
        sumKafes = 0.0
        sumPota = 0.0
        sumLoipa = 0.0
        sumArtos = 0.0
        sumola = 0.0
        sumKostologio = 0.0


        sumola = sumGlyka + sumPota + sumKafes + sumArtos + sumLoipa
        sumolaPos = sumglykaPos + sumPotaPos + sumKafePos + sumArtosPos + sumLoipaPos


    End Sub ' gunadatetimepicker allagi range gia na doume sta chart
    Dim selectedRowCount As Int32
    Dim valueee As String = "5"



    Public Sub Save(ByVal viewer As ReportViewer, ByVal savePath As String)
        Dim Bytes() As Byte = viewer.LocalReport.Render("PDF", "", Nothing, Nothing, Nothing, Nothing, Nothing)

        Using Stream As New FileStream(savePath, FileMode.Create)
            Stream.Write(Bytes, 0, Bytes.Length)
        End Using
    End Sub














    Dim dat As DataTable


    Dim existsItem As Boolean = False
    Dim saleAmount As String = "2"
    Dim valuetel As String = ""










    Dim colorFlag As Boolean = False





    Private Sub DATAGRIDVIEW_TO_EXCEL(ByVal DGV As DataGridView)
        SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim sheetIndex As Integer
            Dim Ex As Object
            Dim Wb As Object
            Dim Ws As Object
            Ex = CreateObject("Excel.Application")
            Wb = Ex.workbooks.add

            ' Copy each DataTable as a new Sheet

            'On Error Resume Next
            Dim col, row As Integer
            ' Copy the DataTable to an object array
            Dim rawData(DGV.Rows.Count, DGV.Columns.Count - 1) As Object

            ' Copy the column names to the first row of the object array

            For col = 0 To DGV.Columns.Count - 1
                rawData(0, col) = DGV.Columns(col).HeaderText.ToUpper

            Next

            For col = 0 To DGV.Columns.Count - 1
                For row = 0 To DGV.Rows.Count - 1
                    rawData(row + 1, col) = DGV.Rows(row).Cells(col).Value

                Next
            Next
            ' Calculate the final column letter
            Dim finalColLetter As String = String.Empty
            finalColLetter = ExcelColName(DGV.Columns.Count) 'Generate Excel Column Name (Column ID)


            sheetIndex += 1
            Ws = Wb.Worksheets(sheetIndex)
            'Ws.name = "Test10"
            Dim excelRange As String = String.Format("A1:{0}{1}", finalColLetter, DGV.Rows.Count + 1)

            Ws.Range(excelRange, Type.Missing).Value2 = rawData
            Ws = Nothing


            Wb.SaveAs(SaveFileDialog1.FileName)
            Wb = Nothing
            ' Release the Application object
            Ex.Quit()
            Ex = Nothing
            ' Collect the unreferenced objects
            GC.Collect()
            MsgBox("Exported Successfully.", MsgBoxStyle.Information)
        End If
    End Sub
    Public Function ExcelColName(ByVal Col As Integer) As String
        If Col < 0 And Col > 256 Then
            MsgBox("Invalid Argument", MsgBoxStyle.Critical)
            Return Nothing
            Exit Function
        End If
        Dim i As Int16
        Dim r As Int16
        Dim S As String
        If Col <= 26 Then
            S = Chr(Col + 64)
        Else
            r = Col Mod 26
            i = System.Math.Floor(Col / 26)
            If r = 0 Then
                r = 26
                i = i - 1
            End If
            S = Chr(i + 64) & Chr(r + 64)
        End If
        ExcelColName = S
    End Function
    Private Sub GunaButton11_Click(sender As Object, e As EventArgs)
        'DATAGRIDVIEW_TO_EXCEL(GunaDataGridView1)
        'MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro



        MessageBoxAdv.Show("Δεν μπορείτε να κλειδώσετε την καρτέλα αυτήν την στιγμή", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub















    Private Sub GunaTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub




    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click


    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub



    Private Sub GunaAdvenceButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        If Application.OpenForms().OfType(Of ApothikiItems).Any Or Application.OpenForms().OfType(Of dashMain).Any Or Application.OpenForms().OfType(Of Form2).Any Or Application.OpenForms().OfType(Of Form6).Any Or Application.OpenForms().OfType(Of Form4).Any Then
            ' itemKey = Convert.ToInt32(ApothikiItems.sfDataGrid1.SelectedItem(0))
            ApothikiItems.Close()
            Form2.Close()
            dashMain.Close()
            Form6.Close()
            openChildForm10(Form6)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        Else
            openChildForm10(Form6)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        End If
    End Sub 'kartela timologia form6
    Public Sub openChildForm2(childForm As Form)
        '' GunaTransition1.HideSync(currentForm)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pn_settings.Controls.Add(childForm)
        pn_settings.Tag = childForm
        childForm.BringToFront()
        ''childForm.Visible = False
        ''GunaTransition1.ShowSync(currentForm)
        childForm.Opacity = 85
        childForm.Show()
        ''GunaTransition1.ShowSync(childForm)
        ''childForm.Visible = True


    End Sub

    Public Sub openChildForm3(childForm As Form)
        '' GunaTransition1.HideSync(currentForm)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pn_settings.Controls.Add(childForm)
        pn_settings.Tag = childForm
        childForm.BringToFront()
        ''childForm.Visible = False
        ''GunaTransition1.ShowSync(currentForm)
        childForm.Opacity = 85
        childForm.Show()
        ''GunaTransition1.ShowSync(childForm)
        ''childForm.Visible = True


    End Sub




    Public Sub Alert1(msg As String, type As Alert.alertTypeEnum)
        Dim f As Alert = New Alert
        f.setAlert(msg, type)
    End Sub

    Dim adapter As SqlDataAdapter
    Dim cmdBuilder As SqlCommandBuilder
    Dim ds As New DataSet
    Dim changes As DataSet
    Dim sql As String











    Dim popupFlag As Boolean = False





    Private Sub sfDataGrid1_QueryImageCellStyle(sender As Object, e As QueryImageCellStyleEventArgs)
        If (e.Column.MappingName = "Trustworthiness") Then


        End If
    End Sub
    Private cellValue As String


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub



    Private Sub SplitButton3_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub StatusBarAdvPanel2_Click(sender As Object, e As EventArgs)
        'StatusBarAdvPanel2.Icon = New Icon("C:\Users\Akuaku\Downloads\Equalv1_16_7\Equalv1\Equalv1\Resources\icons8-without-internet-100.ico")
    End Sub
    Private Sub GetData(ByVal selectCommand As String)

        Try
            ' Specify a connection string. Replace the given value with a  
            ' valid connection string for a Northwind SQL Server sample 
            ' database accessible to your system. 
            Dim connectionString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nate\documents\visual studio 2012\Projects\WindowsApplication9\WindowsApplication9\Database1.mdf;Integrated Security=True"


            ' Create a new data adapter based on the specified query. 
            Dim dataAdapter = New SqlDataAdapter(selectCommand, con)

            ' Create a command builder to generate SQL update, insert, and 
            ' delete commands based on selectCommand. These are used to 
            ' update the database. 
            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)

            ' Populate a new data table and bind it to the BindingSource. 
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            dataAdapter.Fill(table)
            EqualDBBindingSource.DataSource = table

            ' Resize the DataGridView columns to fit the newly loaded content. 
            ' Me.DataGridView1.AutoResizeColumns( _
            '  DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As SqlException
            MessageBox.Show("To run this example, replace the value of the " +
            "connectionString variable with a connection string that is " +
            "valid for your system.")
        End Try

    End Sub

    Private Sub sfDataGrid1_CellDoubleClick(sender As Object, e As CellClickEventArgs)
        EditFlag = True

    End Sub

    Private Sub GunaAdvenceButton3_Click_2(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click

    End Sub

    Private Sub GunaButton2_Click_2(sender As Object, e As EventArgs)

    End Sub















    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs)

    End Sub


    Private Function GetFormImage(ByVal include_borders As Boolean) As Bitmap
        ' Make the bitmap.
        Dim wid As Integer = Me.Width
        Dim hgt As Integer = Me.Height
        Dim bm As New Bitmap(wid, hgt)
        ' Draw the form onto the bitmap.
        Me.DrawToBitmap(bm, New Rectangle(0, 0, wid, hgt))
        ' Make a smaller bitmap without borders.
        wid = Me.ClientSize.Width
        hgt = Me.ClientSize.Height
        Dim bm2 As New Bitmap(wid, hgt)
        ' Get the offset from the window's corner to its client
        ' area's corner.
        Dim pt As New Point(0, 0)
        pt = PointToScreen(pt)
        Dim dx As Integer = pt.X - Me.Left
        Dim dy As Integer = pt.Y - Me.Top
        ' Copy the part of the original bitmap that we want
        ' into the bitmap.
        Dim gr As Graphics = Graphics.FromImage(bm2)
        gr.DrawImage(bm, 0, 0, New Rectangle(dx, dy, wid, hgt), GraphicsUnit.Pixel)
        Return bm
    End Function


    Private Sub BunifuButton5_Click_1(sender As Object, e As EventArgs)



    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton27_Click(sender As Object, e As EventArgs) Handles GunaButton27.Click
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("Δημιουργός προγράμματος Χρήστος Κωνσταντινίδης", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub up_deletedRows()

        sql = "Select * from EqualDB"
        Try
            ds.Clear()
            con.Open()
            adapter = New SqlDataAdapter(sql, con)
            adapter.Fill(ds)

            ' sfDataGrid1.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub SfDataGrid1_QueryCellStyle(ByVal sender As Object, ByVal e As QueryCellStyleEventArgs)
        If e.Column.MappingName = "Κατηγορία" Then
            If e.DisplayText = "Καφές" Then
                e.Style.BackColor = FromArgb(200, 164, 164, 164)

            End If
            If e.DisplayText = "Άρτος" Then
                e.Style.BackColor = FromArgb(200, 230, 126, 34)

            End If
            If e.DisplayText = "Γλυκά" Then
                e.Style.BackColor = FromArgb(200, 46, 204, 113)

            End If
            If e.DisplayText = "Λοιπά Προιόντα" Then
                e.Style.BackColor = FromArgb(200, 52, 152, 219)

            End If
            If e.DisplayText = "Ποτά" Then
                e.Style.BackColor = FromArgb(200, 66, 58, 170)

            End If
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



    Private Sub BunifuToggleSwitch1_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs)
        ' If 'BunifuToggleSwitch1.Checked = True Then
        'AddHandler sfDataGrid1.QueryCellStyle, AddressOf SfDataGrid1_QueryCellStyle1
        'Handler sfDataGrid1.DrawCell, AddressOf SfDataGrid1_DrawCell1
        'AddHandler sfDataGrid1.QueryRowStyle, AddressOf SfDataGrid1_QueryRowStyle
        'sfDataGrid1.Refresh()
        'Else
        'R'emoveHandler sfDataGrid1.QueryCellStyle, AddressOf SfDataGrid1_QueryCellStyle1
        'sfDataGrid1.Refresh()
        'End If

    End Sub ' xromatismow keliwn



    Private Sub GunaButton6_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaButton20_Click_1(sender As Object, e As EventArgs)
        Form6.GunaAdvenceButton1.PerformClick()

    End Sub

    Private Sub GunaButton4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton30_Click_2(sender As Object, e As EventArgs)
        'MessageBoxAdv.Office2016Theme = Office2016Theme.DarkGray
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("updating...", "Windows Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GunaButton21_Click_1(sender As Object, e As EventArgs)
        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        Dim Result = MessageBoxAdv.Show("Είστε σίγουρος πως θέλετε να αποσυνδεθείτε?", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            userLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub GunaButton18_Click_1(sender As Object, e As EventArgs)
        Try
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

            con.Close()
            'filenameEXCEL =
            filenameEXCEL = FormatDateTime(Now, DateFormat.ShortDate).Replace("/", "_")
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx", .FileName = filenameEXCEL}
                If sfd.ShowDialog = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook()
                            workbook.Worksheets.Add(dt, "timologio")
                            workbook.SaveAs(sfd.FileName)

                        End Using
                        Alert1("Επιτυχημένη εξαγωγή του αρχείου (.xlsx)", Alert.alertTypeEnum.Success)
                    Catch ex As Exception
                        Alert1("Δεν ήταν εφικτή η εξαγωγή του αρχείου.", Alert.alertTypeEnum.Error)
                    End Try
                End If
            End Using
        Catch
            MessageBoxAdv.Show("Δεν ήταν δυνατόν να πραγματοποιηθεί η εξαγωγή σε Excel", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub GunaButton7_Click_1(sender As Object, e As EventArgs)
        If Form6.SfDataGrid1.SelectedIndex > 0 Then
            Form6.GunaButton2.PerformClick()
            Form6.GunaAdvenceButton3.Visible = True
            Form6.GunaAdvenceButton2.Visible = False
            Form6.GunaTransition1.HideSync(Form6.SfDataGrid1)
            Form6.GunaTransition1.ShowSync(Form6.BunifuPanel1)
        Else
            Alert1("Παρακαλώ επιλέξτε πρώτα μια εγγραφή για τροποποίηση", Alert.alertTypeEnum.Warning)
        End If

    End Sub

    Private Sub GunaButton19_Click_1(sender As Object, e As EventArgs)
        Dim result As DialogResult
        Try
            result = MessageBoxAdv.Show("Θέλετε να διαγραψετε ID : " + Form6.SfDataGrid1.SelectedItem(1).ToString + " καταχώρηση?", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
                con.Open()

                cmd = con.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "delete from timologio where Id='" + Form6.SfDataGrid1.SelectedItem(0).ToString + "'"
                cmd.ExecuteNonQuery()

                Form6.disp_data()
                con.Close()
                Alert1("Η διαγραφή του στοιχείου" + " πραγματοιποιήθηκε με επιτυχία.", Alert.alertTypeEnum.Success)
                Form6.SfDataGrid1.SelectedIndex = 1


            ElseIf result = DialogResult.No Then

                con.Close()
            End If
        Catch
            Alert1("Αποτυχημένη διαγραφή του στοιχείου.", Alert.alertTypeEnum.Error)
            con.Close()
        End Try
    End Sub

    Private Sub GunaButton16_Click_1(sender As Object, e As EventArgs)

        MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro
        MessageBoxAdv.Show("Δεν υπάρχουν παραμετροποιησεις για τις άδειες χρήσης!", "Σύστημα Διαχείρησης Επιχειρήσεων - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



    Private Sub GunaButton24_Click(sender As Object, e As EventArgs) Handles GunaButton24.Click

    End Sub

    Private Sub GunaButton32_Click(sender As Object, e As EventArgs) Handles GunaButton32.Click

    End Sub

    Private Sub GunaPanel18_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaButton29_Click(sender As Object, e As EventArgs) Handles GunaButton29.Click
        If Application.OpenForms().OfType(Of ApothikiItems).Any Or Application.OpenForms().OfType(Of Form2).Any Or Application.OpenForms().OfType(Of dashMain).Any Or Application.OpenForms().OfType(Of Form4).Any Then
            ' itemKey = Convert.ToInt32(ApothikiItems.sfDataGrid1.SelectedItem(0))
            ApothikiItems.Close()
            Form2.Close()
            dashMain.Close()
            Form4.Close()
            openChildForm10(Form4)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        Else
            openChildForm10(Form4)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        End If
    End Sub

    Private Sub GunaButton28_Click(sender As Object, e As EventArgs) Handles GunaButton28.Click


    End Sub

    Private Sub GunaButton26_Click(sender As Object, e As EventArgs) Handles GunaButton26.Click


    End Sub

    Private Sub GunaButton25_Click(sender As Object, e As EventArgs) Handles GunaButton25.Click
        If Application.OpenForms().OfType(Of ApothikiItems).Any Or Application.OpenForms().OfType(Of Form2).Any Or Application.OpenForms().OfType(Of dashMain).Any Or Application.OpenForms().OfType(Of Form4).Any Or Application.OpenForms().OfType(Of Form6).Any Or Application.OpenForms().OfType(Of ExcelReader).Any Then
            ' itemKey = Convert.ToInt32(ApothikiItems.sfDataGrid1.SelectedItem(0))
            ApothikiItems.Close()
            Form2.Close()
            dashMain.Close()
            Form4.Close()
            Form6.Close()
            ExcelReader.Close()
            openChildForm10(ExcelReader)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        Else
            openChildForm10(ExcelReader)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        End If
    End Sub

    Private Sub pn_home_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub sfDataGrid1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel2.Paint

    End Sub

    Private Sub GunaPanel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Dim mystringcon As String
    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click
        ''mystringcon = System.Configuration.ConfigurationManager.ConnectionStrings("Equalv1.My.MySettings.Database1ConnectionString").ConnectionString
        ' mystringcon = Environment.CurrentDirectory
        'MsgBox(mystringcon)
        openChildForm10(ApothikiItems)
    End Sub

    Private Sub GunaControlBox2_Click(sender As Object, e As EventArgs) Handles GunaControlBox2.Click
        Application.Exit()
    End Sub

    Private Sub pn_settings_Paint(sender As Object, e As PaintEventArgs) Handles pn_settings.Paint

    End Sub

    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click

    End Sub

    Private Sub GunaPanel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaPanel9_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaPictureBox4_Click(sender As Object, e As EventArgs) Handles GunaPictureBox4.Click
        dashMain.Show()
    End Sub
    Public Sub openChildForm10(childForm As Form)
        '' GunaTransition1.HideSync(currentForm)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pn_settings.Controls.Add(childForm)
        pn_settings.Tag = childForm
        childForm.BringToFront()
        ''childForm.Visible = False
        ''GunaTransition1.ShowSync(currentForm)
        childForm.Opacity = 85
        childForm.Show()
        ''GunaTransition1.ShowSync(childForm)
        ''childForm.Visible = True


    End Sub
    Private Sub GunaPictureBox3_Click(sender As Object, e As EventArgs) Handles GunaPictureBox3.Click
        openChildForm10(dashMain)
    End Sub

    Private Sub GunaDateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaTextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        EditFlag = False
        If Application.OpenForms().OfType(Of ApothikiItems).Any Or Application.OpenForms().OfType(Of Form2).Any Then
            ' itemKey = Convert.ToInt32(ApothikiItems.sfDataGrid1.SelectedItem(0))
            ApothikiItems.Close()
            Form2.Close()
            openChildForm10(Form2)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        Else

            openChildForm10(Form2)
            ''GunaTransition1.ShowSync(GunaPanel15)
            'GunaPanel13.BringToFront()
        End If
    End Sub

    Private Sub pn_profile_Paint(sender As Object, e As PaintEventArgs) Handles pn_profile.Paint

    End Sub

    Private Sub StatusBarAdvPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaButton13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
