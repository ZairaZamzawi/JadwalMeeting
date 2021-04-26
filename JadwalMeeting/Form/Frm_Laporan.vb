Imports System.Windows.Forms
Imports System.IO
Imports System.Data.SqlClient
Public Class Frm_Laporan
    Public mNomor As String
    Sub gbPeriodTrue()
        gbPeriode.Visible = True
        gbBulanan.Visible = False
    End Sub
    Sub gbBulanTrue()
        gbPeriode.Visible = False
        gbBulanan.Visible = True
    End Sub
    Sub gbFalse()
        gbPeriode.Visible = False
        gbBulanan.Visible = False
    End Sub
    Sub gbForm()
        gbPeriode.Visible = False
        gbBulanan.Visible = False
    End Sub
    Sub GB()
        gbPeriode.Visible = True
        gbBulanan.Visible = False
    End Sub
    Sub fals()
        gbPeriode.Visible = False
        gbBulanan.Visible = False
    End Sub
    Private Sub Laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        If File.Exists(Application.StartupPath & "\image\LAP.png") Then PB.Image = Image.FromFile(Application.StartupPath & "\image\LAP.png")
        gbPeriode.Visible = False
        gbBulanan.Visible = False
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.ForeColor = System.Drawing.Color.White
        btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue

        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.ForeColor = System.Drawing.Color.White
        btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue

        Laporan()
    End Sub

    Sub Laporan()
        Select Case mKlik
            Case 1
                lbNama.Items.Clear()
                lbNama.Items.Add("JADWAL MEETING")
        End Select
    End Sub
    Private Sub lbNama_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbNama.Click
        Select Case Me.lbNama.SelectedItem
            Case "JADWAL MEETING"
                gbPeriodTrue()
        End Select
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim mLaporan As String = lbNama.Text
        mAwal = dtAwal.Value.ToString("yyyyMMdd")
        mAkhir = dtAkhir.Value.ToString("yyyyMMdd")
        mBulan = dtBulan.Value.ToString("yyyyMM")
        If mAwal > mAkhir And gbPeriode.Visible = True Then
            MsgBox("Tanggal awal harus lebih kecil dari tanggal akhir...", MsgBoxStyle.Critical, "Informasi  System")
            Exit Sub
        End If
        Select Case lbNama.SelectedItem
            '========================================================================================================
            'PENJUALAN
            '=======================================================================================================
            Case "JADWAL MEETING"
                With frmReport
                    .LoadReports("Select * from Tbl_JadwalMeeting where TglMulai >= #" & dtAwal.Value.ToShortDateString & "# and TglMulai < #" & dtAkhir.Value.ToShortDateString & "#")
                    .ShowDialog()
                End With          '========================================================================================================
                'END HERE
                '=======================================================================================================
            Case Else
                MsgBox("Silahkan Pilih Nama Laporan..", MsgBoxStyle.Critical, "Informasi  System")
        End Select
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class