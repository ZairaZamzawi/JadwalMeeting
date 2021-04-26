Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Frm_GantiPass
    Sub button()
        btnCloseLog.FlatStyle = FlatStyle.Flat
        btnCloseLog.ForeColor = System.Drawing.Color.White
        btnCloseLog.FlatAppearance.BorderColor = System.Drawing.Color.White
        btnCloseLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue

        btnSimpanLog.FlatStyle = FlatStyle.Flat
        btnSimpanLog.ForeColor = System.Drawing.Color.White
        btnSimpanLog.FlatAppearance.BorderColor = System.Drawing.Color.White
        btnSimpanLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
    End Sub
   
    Sub UbahLog()
        Dim StringCMD As String
        Dim UpdatePass As DialogResult

        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If

        StringCMD = "UPDATE Tbl_User SET [password] = '" & txtPassBaru.Text & "' WHERE ucase([username]) = '" & txtUsername.Text & "'"
        CMD = New OleDbCommand(StringCMD, Conn)
        Try
            UpdatePass = MessageBox.Show("Anda Yakin akan Ubah Password ? . . . ", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If UpdatePass = vbYes Then
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil diubah...", MsgBoxStyle.Information, "Editing  System Success")
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub
    Private Sub GantiPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        If File.Exists(Application.StartupPath & "\image\log.png") Then PB.Image = Image.FromFile(Application.StartupPath & "\image\log.png")
        button()
        txtUsername.Text = mCurrUser
        Me.txtUsername.Enabled = False
    End Sub

    Private Sub btnSimpanLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpanLog.Click
        mpass = Mod_Global.CariDataGlobal(Me.txtUsername.Text, "password", "Tbl_User", "USERNAME")
        If txtPassword.Text = "" Then
            MsgBox("Silahkan Isi Password Anda...", MsgBoxStyle.Information, "Informasi  System")
            txtPassword.Focus()
            Exit Sub
        ElseIf txtPassBaru.Text <> txtPassKonfirm.Text Then
            MsgBox("Password Konfirmasi Tidak Sesuai...", MsgBoxStyle.Information, "Informasi  System")
            txtPassBaru.Clear()
            txtPassKonfirm.Clear()
            txtPassBaru.Focus()
            Exit Sub
        ElseIf Trim(UCase((mpass))) <> Trim(UCase((txtPassword.Text))) Then
            MsgBox("Password Lama Anda Tidak Sesuai...", MsgBoxStyle.Information, "Informasi  System")
            txtPassword.Focus()
            Exit Sub
        End If
        UbahLog()
    End Sub

    Private Sub btnCloseLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseLog.Click
        Me.Close()
    End Sub
End Class