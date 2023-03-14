Imports System.IO
Imports ExcelDataReader
Imports System.Data.OleDb
Imports System.Linq
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports Microsoft.Office
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports ClosedXML.Excel


Public Class ExcelReader
    Public Sub Alert1(msg As String, type As Alert.alertTypeEnum)
        Dim f As Alert = New Alert
        f.setAlert(msg, type)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Dim path As String = "C:\Users\Akuaku\Downloads\testing.xlsx"

    Private Sub DataGridViewCheckBoxColumn_Uncheck()

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim cell As DataGridViewCheckBoxCell = GunaDataGridView1.Rows(e.RowIndex).Cells(0)


        cell.Value = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub DataTableToExcel(dt As DataTable, ws As Excel.Worksheet, TabName As String)
        Dim arr(dt.Rows.Count, dt.Columns.Count) As Object
        Dim r As Int32, c As Int32
        'copy the datatable to an array
        For r = 0 To dt.Rows.Count - 1
            For c = 0 To dt.Columns.Count - 1
                arr(r, c) = dt.Rows(r).Item(c)
            Next
        Next

        ws.Name = TabName   'name the worksheet
        'add the column headers starting in A1
        c = 0
        For Each column As DataColumn In dt.Columns
            ws.Cells(1, c + 1) = column.ColumnName
            c += 1
        Next
        'add the data starting in cell A2
        ws.Range(ws.Cells(2, 1), ws.Cells(dt.Rows.Count, dt.Columns.Count)).Value = arr
    End Sub
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub ExcelReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.TEST' table. You can move, or remove it, as needed.
        Me.TESTTableAdapter.Fill(Me.DataSet1.TEST)

    End Sub
    Dim filenameEXCEL As String
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Akuaku\Downloads\My Portfolio\My Portfolio\1_9_equal\1_9_equal\Equalv1_24_7\Equalv1_16_7\Equalv1\Equalv1\Database1.mdf;Integrated Security=True")
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
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


    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaButton1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub sfDataGrid_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuPictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        sfDataGrid1.ClipboardController.Cut()

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Try
            Dim conn As OleDbConnection
            Dim dtr As OleDbDataReader
            Dim dta As OleDbDataAdapter
            Dim cmd As OleDbCommand
            Dim dts As DataSet
            Dim excel As String
            Dim OpenFileDialog As New OpenFileDialog

            OpenFileDialog1.FileName = ""
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

            If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                ' GunaDataGridView1.Columns.Clear()

                Dim fi As New FileInfo(OpenFileDialog1.FileName)
                Dim FileName As String = OpenFileDialog1.FileName

                excel = fi.FullName
                Dim strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & excel & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
                Dim conn1 As New OleDbConnection(strconn)

                conn1.Open()

                Dim dtSheets As DataTable =
                  conn1.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                Dim listSheet As New List(Of String)
                Dim drSheet As DataRow

                For Each drSheet In dtSheets.Rows
                    listSheet.Add(drSheet("TABLE_NAME").ToString())
                Next


                ' For Each sheet As String In listSheet
                'TextBox1.Text = TextBox1.Text & sheet & vbNewLine
                ' Next

                conn1.Close()

                Label1.Text = listSheet(0).Replace("'", "")

                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
                dta = New OleDbDataAdapter("Select * From [" & Label1.Text & "]", conn)
                dts = New DataSet
                dta.Fill(dts, Label1.Text)
                sfDataGrid1.DataSource = dts
                sfDataGrid1.DataMember = Label1.Text
                conn.Close()
                Dim checkboxcol As New DataGridViewCheckBoxColumn
                checkboxcol.Width = 40
                checkboxcol.Name = "checkboxcol"
                checkboxcol.HeaderText = ""
                GunaDataGridView1.Columns.Insert(0, checkboxcol)
                GunaDataGridView1.ColumnHeadersHeight = 42
                Alert1("Επιτυχημένη Φόρτωση Excel αρχείου.", Alert.alertTypeEnum.Success)
            End If
        Catch
            Alert1("Παρουσιάστηκε Σφάλμα προσπαθήστε ξανά!", Alert.alertTypeEnum.Warning)
        End Try
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
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
                        'Alert1("Δεν ήταν εφικτή η εξαγωγή του αρχείου.", Alert.alertTypeEnum.Error)
                    End Try
                End If

            End Using
        Catch
            Alert1("Παρουσιάστηκε Σφάλμα προσπαθήστε ξανά!", Alert.alertTypeEnum.Warning)
        End Try
    End Sub
End Class