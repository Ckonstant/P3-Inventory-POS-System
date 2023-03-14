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

Public Class dashMain
    Public userFlag As String = "Super Admin"
    Public EditFlag As Boolean = False
    Public countPosNEW As Integer = 0
    Dim countR As Integer = 0
    Public countNew As Integer = 0
    Public countKostNew As Double = 0.0
    Dim sum As Double = 0.0
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection(My.Settings.equalhostDB)
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
    Dim sumGlyka As Double = 0.0
    Dim sumKafes As Double = 0.0
    Dim sumArtos As Double = 0.0
    Dim sumLoipa As Double = 0.0
    Dim sumPota As Double = 0.0
    Dim sumola As Double = 0.0

    Private Sub dashMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EqualHostDataset.EqualDB' table. You can move, or remove it, as needed.
        Me.EqualDBTableAdapter.Fill(Me.EqualHostDataset.EqualDB)
        'TODO: This line of code loads data into the 'EqualHostDataset.timologio' table. You can move, or remove it, as needed.
        Me.TimologioTableAdapter.Fill(Me.EqualHostDataset.timologio)
        'TODO: This line of code loads data into the 'EqualHostDataset.timologio' table. You can move, or remove it, as needed.


        sumAplirota = 0
        For i As Integer = 0 To GunaDataGridView3.Rows.Count - 2
            If GunaDataGridView3.Rows(i).Cells(9).Value.ToString = "Απλήρωτο" Then
                sumAplirota += 1
            End If
        Next
        label13.Text = Convert.ToString(sumAplirota) + " Τιμολόγια Απλήρωτα"
        label14.Text = GunaDataGridView3.RowCount - 1
        countR = GunaDataGridView1.Rows.Count
        countNew = 0
        countPosNEW = 0
        countKostNew = 0.0
        ''Label10.Text = "Συνολικά Βρέθηκαν: " + GunaDataGridView1.Rows.Count.ToString + " Καταχωρήσεις προιόντων στο σύστημα."




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
        For i As Integer = 0 To GunaDataGridView1.Rows.Count - 2
            sumKostologio += GunaDataGridView1.Rows(i).Cells(10).Value.ToString
        Next
        For i As Integer = 0 To GunaDataGridView1.Rows.Count - 1
            If GunaDataGridView1.Rows(i).Cells(1).Value = "Γλυκά" Then
                sumGlyka = sumGlyka + 1
                sumglykaPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
                ''sumKost = sumKost + (GunaDataGridView1.Rows(i).Cells(7).Value)
            ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Ποτά" Then
                sumPota += 1
                sumPotaPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
            ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Καφές" Then
                sumKafes += 1
                sumKafePos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
            ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Άρτος" Then
                sumArtos += 1
                sumArtosPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
            ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Λοιπά Προιόντα" Then
                sumLoipa += 1
                sumLoipaPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
            End If
        Next
        sumola = sumGlyka + sumPota + sumArtos + sumKafes + sumLoipa



        sumolaPos = sumglykaPos + sumPotaPos + sumArtosPos + sumKafePos + sumLoipaPos
        Label19.Text = sumolaPos
        Label16.Text = sumKostologio.ToString("N2") + "$"
        Label22.Text = sumola
        chartcolum()
        chartPie()
    End Sub

    Private Sub GunaPanel9_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel9.Paint

    End Sub

    Private Sub pictureBox10_Click(sender As Object, e As EventArgs) Handles pictureBox10.Click

    End Sub
    Private Sub chartPie()
        Dim labelPoint As Func(Of ChartPoint, String) = Function(chartPoint) String.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation)
        PieChart1.LegendLocation = LegendLocation.Left
        'pieChartMain = New LiveCharts.WinForms.PieChart
        PieChart1.Series = New SeriesCollection From {
                New PieSeries With {
                .DataLabels = True,
                .LabelPoint = labelPoint,
                .Fill = Brushes.LightPink,
                    .Title = "Γλυκά",
                    .Values = New ChartValues(Of Integer) From {
                        sumGlyka
                    }
                }
            }
        PieChart1.Series.Add(New PieSeries With {
            .Fill = Brushes.CornflowerBlue,
            .Title = "Ποτά",
            .LabelPoint = labelPoint,
            .DataLabels = True,
            .Values = New ChartValues(Of Double) From {
                        sumPota
            }
        })
        PieChart1.Series.Add(New PieSeries With {
            .DataLabels = True,
            .LabelPoint = labelPoint,
            .Fill = Brushes.Brown,
            .Title = "Καφές",
            .Values = New ChartValues(Of Double) From {
                        sumKafes
            }
        })
        PieChart1.Series.Add(New PieSeries With {
            .DataLabels = True,
            .LabelPoint = labelPoint,
            .Fill = Brushes.Red,
            .Title = "Άρτος",
            .Values = New ChartValues(Of Double) From {
                        sumArtos
            }
        })
        PieChart1.Series.Add(New PieSeries With {
            .DataLabels = True,
            .LabelPoint = labelPoint,
            .Fill = Brushes.Orange,
            .Title = "Λοιπά Προιόντα",
            .Values = New ChartValues(Of Double) From {
                        sumLoipa
            }
        })



        PieChart1.AxisX.Add(New Axis With {
            .Title = "Κατηγορίες",
            .Labels = {"Σύνολο"}
        })
        PieChart1.AxisY.Add(New Axis With {
            .Title = "Προιόντα",
            .LabelFormatter = Function(value) value.ToString("N")
        })
    End Sub 'chart pitas gia thn arhiki me dedomena
    Private Sub chartcolum()



        CartesianChart2.Series = New SeriesCollection From {
                New ColumnSeries With {
                .DataLabels = True,
                .Fill = Brushes.DarkGreen,
                    .Title = "Κωδικοί",
                    .Values = New ChartValues(Of Integer) From {
                        sumGlyka,
                        sumPota,
                        sumKafes,
                        sumArtos,
                        sumLoipa,
                        sumola
                    }
                }
            }
        CartesianChart2.Series.Add(New ColumnSeries With {
            .DataLabels = True,
            .Fill = Brushes.Orange,
            .Title = "Ποσότητα",
            .Values = New ChartValues(Of Double) From {
                sumglykaPos,
                sumPotaPos,
                sumKafePos,
                  sumArtosPos,
                       sumLoipaPos,
                        sumolaPos
            }
        })
        '' CartesianChart2.Series(1).Values.Add(48.0R)
        CartesianChart2.AxisX.Add(New Axis With {
            .Title = "Κατηγορίες",
            .Labels = {"Γλυκα", "Ποτά", "Καφές", "Άρτος", "Λοιπά Προιόντα", "Σύνολο"}
        })
        CartesianChart2.AxisY.Add(New Axis With {
            .Title = "Προιόντα",
            .LabelFormatter = Function(value) value.ToString("N")
        })
    End Sub 'chart katheto me dedomena

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If

        con.Open()
        'disp_data()
        con.Close()
        CartesianChart2.AxisX.RemoveAt(0)
        CartesianChart2.AxisY.RemoveAt(0)
        PieChart1.AxisX.RemoveAt(0)
        PieChart1.AxisY.RemoveAt(0)
        'chartPie()

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

        For i As Integer = 0 To GunaDataGridView1.Rows.Count - 2
            sumKostologio += GunaDataGridView1.Rows(i).Cells(10).Value.ToString
        Next
        For i As Integer = 0 To GunaDataGridView1.Rows.Count - 1
            If GunaDataGridView1.Rows(i).Cells(1).Value = "Γλυκά" Then
                sumGlyka = sumGlyka + 1
                sumglykaPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
                ''sumKost = sumKost + (GunaDataGridView1.Rows(i).Cells(7).Value)

            ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Ποτά" Then
                sumPota += 1
                sumPotaPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString

            ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Καφές" Then
                sumKafes += 1
                sumKafePos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString

            ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Άρτος" Then
                sumArtos += 1
                sumArtosPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString

            ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Λοιπά Προιόντα" Then
                sumLoipa += 1
                sumLoipaPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString

            End If
        Next
        sumola = sumGlyka + sumPota + sumArtos + sumKafes + sumLoipa



        sumolaPos = sumglykaPos + sumPotaPos + sumArtosPos + sumKafePos + sumLoipaPos
        Label19.Text = sumolaPos

        Label16.Text = sumKostologio.ToString("N2") + "$"
        chartcolum()
        GunaTransition1.HideSync(GunaPanel7)
        GunaTransition1.ShowSync(GunaPanel7)
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        GunaTransition1.HideSync(PieChart1)
        GunaTransition1.ShowSync(PieChart1)
    End Sub

    Private Sub GunaDateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles GunaDateTimePicker4.ValueChanged
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

        For i As Integer = 0 To GunaDataGridView1.Rows.Count - 2
            If GunaDataGridView1.Rows(i).Cells(12).Value >= GunaDateTimePicker1.Value.Date And GunaDataGridView1.Rows(i).Cells(12).Value <= GunaDateTimePicker4.Value.Date Then
                If GunaDataGridView1.Rows(i).Cells(1).Value = "Γλυκά" Then
                    sumGlyka = sumGlyka + 1
                    sumglykaPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
                    ''sumKost = sumKost + (GunaDataGridView1.Rows(i).Cells(7).Value)
                ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Ποτά" Then
                    sumPota += 1
                    sumPotaPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
                ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Καφές" Then
                    sumKafes += 1
                    sumKafePos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
                ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Άρτος" Then
                    sumArtos += 1
                    sumArtosPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
                ElseIf GunaDataGridView1.Rows(i).Cells(1).Value = "Λοιπά Προιόντα" Then
                    sumLoipa += 1
                    sumLoipaPos += GunaDataGridView1.Rows(i).Cells(4).Value.ToString
                End If
            End If
        Next
        sumola = sumGlyka + sumPota + sumKafes + sumArtos + sumLoipa
        sumolaPos = sumglykaPos + sumPotaPos + sumKafePos + sumArtosPos + sumLoipaPos
        chartcolum()
        CartesianChart2.AxisX.RemoveAt(0)
        CartesianChart2.AxisY.RemoveAt(0)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub
End Class