Imports System.IO
Imports System
Imports System.Data
Imports System.Data.OleDb
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared

Module Mod_Global
    Private Declare Function CreateRectRgn Lib "gdi32.dll" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
    Private Declare Function SetWindowRgn Lib "user32" (ByVal hwnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Boolean) As Integer
    Private Declare Function CreateSolidBrush Lib "gdi32.dll" (ByVal crColor As Integer) As Integer
    Private Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Integer) As Integer
    Private Declare Function FrameRgn Lib "gdi32.dll" (ByVal hdc As Integer, ByVal hRgn As Integer, ByVal hBrush As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer

    Public Conn As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public CMD As OleDbCommand
    Public DR As OleDbDataReader
    Public DGV As DataGridView

    Public GlbCari As String

    Public mCurrAppDate, mCurrDateNow As Date
    Public mHeight, mWidth, mStat, mAkun As Integer
    Public mPeriode, mpass, mCurrUser, mUnit, mUsername, mAwal, mAkhir, mBulan As String
    Public mflag, mlog, mTerm, mKlik, mJenisCust, mPeriod, mKasMasuk, mJenisPenjualan, mstatus, mTransmisi, mForm As Integer
    Public mStart As Boolean = False
    

    Public Sub Koneksi()
        Conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=JadwalMeeting.mdb")
        Conn.Open()
    End Sub
    Public Sub BukaMenu(ByVal form As Form, ByVal mKeterangan As String)

        Try
            form.TopLevel = False

            With frmMain
                .Panel2.Controls.Add(form)
            End With

            form.Show()
            form.BringToFront()

        Catch ex As Exception
            MsgBox("Anda tidak berhak melakukan transaksi ini.." & vbCrLf & "Silahkan hubungi administrator anda...", MsgBoxStyle.Critical, "Informasi  System")
            Exit Sub
        End Try
    End Sub
    Public Function CariDataGlobal(ByVal mSearch As String, ByVal mKriteria As String, ByVal mTableCari As String, ByVal mField As String)
        Dim myData As New DataSet
        Dim SqlCmd As New OleDbCommand
        Dim SqlDatAd As New OleDbDataAdapter

        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If

            SqlCmd.CommandText = "SELECT " & mKriteria & " FROM " & mTableCari & " WHERE " & mField & " = '" & mSearch & "'"

            SqlCmd.Connection = Conn
            SqlCmd.ExecuteNonQuery()
            SqlDatAd.SelectCommand = SqlCmd
            SqlDatAd.Fill(myData)
            If myData.Tables(0).Rows.Count > 0 Then
                CariDataGlobal = myData.Tables(0).Rows(0).Item(0)
            Else
                CariDataGlobal = ""
            End If
            Conn.Close()
            Return (CariDataGlobal)
        Catch ex As Exception
            Return (1)
        End Try
    End Function
End Module
