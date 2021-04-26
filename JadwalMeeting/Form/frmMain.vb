Imports System.IO
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class frmMain
    Sub tampil()
        Panel2.Enabled = True
        Panel2.Show()
    End Sub
    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        pnlOnButtonPosition.Height = btnFoods.Height
        pnlOnButtonPosition.Top = btnFoods.Top
        Panel2.Visible = True
        tampil()
        BukaMenu(Frm_InputJadwal, "")
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlOnButtonPosition.Height = btnDrinks.Height
        pnlOnButtonPosition.Top = btnDrinks.Top
        Panel2.Visible = True
        tampil()
        BukaMenu(Frm_GantiPass, "")
    End Sub

    Private Sub btnDeserts_Click(sender As Object, e As EventArgs) Handles btnDeserts.Click
        pnlOnButtonPosition.Height = btnDeserts.Height
        pnlOnButtonPosition.Top = btnDeserts.Top
        Panel2.Visible = True
        Frm_Laporan.Dispose()
        mKlik = 1
        tampil()
        Frm_Laporan.lblLaporan.Text = "JADWAL MEETING"
        BukaMenu(Frm_Laporan, "")
    End Sub


    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pnlOnButtonPosition.Height = btnAboutUs.Height
        pnlOnButtonPosition.Top = btnAboutUs.Top
        Panel2.Visible = False
        tampil()
        BukaMenu(Frm_About, "")
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        If MsgBox("Anda yakin akan keluar program ??", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit  System") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        tampil()
        If mStart = False Then
            Frm_Login.ShowDialog()
        End If
    End Sub
End Class
