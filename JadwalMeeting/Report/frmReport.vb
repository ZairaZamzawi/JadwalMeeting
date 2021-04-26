Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class frmReport

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub LoadReports(ByVal Accs As String)
        Call Koneksi()
        Dim rptDS As ReportDataSource
        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Report\RPT_JadwalMeeting.rdlc"
                .DataSources.Clear()
            End With

            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
            DA.SelectCommand = New OleDbCommand(Accs, Conn)
            DA.Fill(DS.Tables("Tbl_JadwalMeeting"))
            Conn.Close()

            rptDS = New ReportDataSource("JadwalMeetingDataSet", DS.Tables("Tbl_JadwalMeeting"))
            ReportViewer1.RefreshReport()
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
        Catch ex As Exception
            Conn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class