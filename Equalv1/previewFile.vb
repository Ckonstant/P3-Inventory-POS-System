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
Public Class previewFile
    Private Sub previewFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim conn As OleDbConnection
            Dim dtr As OleDbDataReader
            Dim dta As OleDbDataAdapter
            Dim cmd As OleDbCommand
            Dim dts As DataSet
            Dim excel As String
            Dim OpenFileDialog As New OpenFileDialog






            excel = Label1.Text

            Dim strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & excel & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
            Dim conn1 As New OleDbConnection(strconn)

            conn1.Open()

            Dim dtSheets As DataTable = conn1.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim listSheet As New List(Of String)
            Dim drSheet As DataRow

            For Each drSheet In dtSheets.Rows
                listSheet.Add(drSheet("TABLE_NAME").ToString())
            Next


            ' For Each sheet As String In listSheet
            'TextBox1.Text = TextBox1.Text & sheet & vbNewLine
            ' Next

            conn1.Close()

            Label2.Text = listSheet(0).Replace("'", "")

            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
            dta = New OleDbDataAdapter("Select * From [" & Label2.Text & "]", conn)
            dts = New DataSet
            dta.Fill(dts, Label2.Text)
            sfDataGrid1.DataSource = dts
            'sfDataGrid1.DataMember = Label1.Text
            conn.Close()

            'GunaDataGridView1.Columns.Insert(0, checkboxcol)
            ' GunaDataGridView1.ColumnHeadersHeight = 42
            'lert1("Επιτυχημένη Φόρτωση Excel αρχείου.", Alert.alertTypeEnum.Success)

        Catch
            MsgBox("error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class