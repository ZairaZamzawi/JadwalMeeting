Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Frm_InputJadwal
    Private NomorOto As String = ""


    Sub TampilGrid()
        'Menampilkan Data ke Data Grid
        DA = New OleDbDataAdapter("SELECT * FROM Tbl_JadwalMeeting ORDER BY Nomor DESC", Conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Tbl_JadwalMeeting")
        dgvJadwal.DataSource = DS.Tables("Tbl_JadwalMeeting")
        dgvJadwal.ReadOnly = True
    End Sub

    Private Sub nomorJadwal()
        Try
            CMD = New OleDbCommand("SELECT TOP 1 RIGHT(Nomor,5) + 1 AS Nomor FROM Tbl_JadwalMeeting ORDER BY Nomor DESC", Conn)
            DR = CMD.ExecuteReader
            If DR.Read Then
                Select Case DR!Nomor
                    Case Is <= 9
                        NomorOto = "MET" & "0000" & DR!Nomor
                    Case Is <= 99
                        NomorOto = "MET" & "000" & DR!Nomor
                    Case Is <= 999
                        NomorOto = "MET" & "00" & DR!Nomor
                    Case Is <= 9999
                        NomorOto = "MET" & "0" & DR!Nomor
                End Select
            Else
                NomorOto = "MET" & "00001"
            End If
            Me.txtNomor.Text = NomorOto
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub isiText()
        Me.txtPIC.Text = mCurrUser
        Me.txtUnit.Text = mUnit
        Me.cbBagian.Text = ""
    End Sub
    Sub button()
        btnCloseLog.FlatStyle = FlatStyle.Flat
        btnCloseLog.ForeColor = System.Drawing.Color.White
        btnCloseLog.FlatAppearance.BorderColor = System.Drawing.Color.White
        btnCloseLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue

        btnUpdateLog.FlatStyle = FlatStyle.Flat
        btnUpdateLog.ForeColor = System.Drawing.Color.White
        btnUpdateLog.FlatAppearance.BorderColor = System.Drawing.Color.White
        btnUpdateLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue

        btnSimpanLog.FlatStyle = FlatStyle.Flat
        btnSimpanLog.ForeColor = System.Drawing.Color.White
        btnSimpanLog.FlatAppearance.BorderColor = System.Drawing.Color.White
        btnSimpanLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue

        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.ForeColor = System.Drawing.Color.White
        btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
    End Sub
    Private Sub Frm_InputJadwal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        If File.Exists(Application.StartupPath & "\image\key.png") Then PB.Image = Image.FromFile(Application.StartupPath & "\image\key.png")
        button()
        nomorJadwal()
        isiText()
    End Sub
    Sub UbahLog()
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If

        CMD = New OleDbCommand("UPDATE Tbl_User SET password = '' WHERE username = '" & txtNomor.Text & "'", Conn)
        Try
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil diubah...", MsgBoxStyle.Information, "Editing  System Success")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub btnUpdateLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateLog.Click
        If cbBagian.Text = "" Then
            MsgBox("Silahkan Isi Ruangan Untuk Meeting...", MsgBoxStyle.Information, "Informasi  System")
            cbBagian.Focus()
            Exit Sub
        End If
        UbahLog()
    End Sub
    Sub SimpanLog()
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If

        CMD = New OleDbCommand("INSERT INTO Tbl_JadwalMeeting VALUES ('" & txtNomor.Text & "','" & dtMulai.Text & " " & dtJamMulai.Text & "','" & dtSelesai.Text & " " & dtJamSelesai.Text & "','" & txtUnit.Text & "','" & cbBagian.Text & "','" & txtPIC.Text & "')", Conn)
        Try
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan...", MsgBoxStyle.Information, "Editing  System Success")
            Call TampilGrid()
            button()
            nomorJadwal()
            isiText()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub
    Private Sub btnSimpanLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpanLog.Click
        If txtNomor.Text = "" Or cbBagian.Text = "" Then
            MsgBox("Silahkan isi data dengan lengkap...", MsgBoxStyle.Critical, "Informasi System")
            Exit Sub
        End If
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
        DR.Close()
        If Format(dtMulai.Value, "ddMMyyyy") <> Format(dtSelesai.Value, "ddMMyyyy") Then
            MsgBox("Tanggal Tidak Sesuai...", MsgBoxStyle.Critical, "Informasi  System")
            Exit Sub
        ElseIf Format(dtMulai.Value, "yyyyMMdd") < Format(Now, "yyyyMMdd") Then
            MsgBox("Tanggal Mulai Tidak Boleh Lebih Kecil dari Tanggal Hari ini...", MsgBoxStyle.Critical, "Informasi  System")
            Exit Sub
        ElseIf Format(dtSelesai.Value, "yyyyMMdd") < Format(Now, "yyyyMMdd") Then
            MsgBox("Tanggal Selesai Tidak Boleh Lebih Kecil dari Tanggal Hari ini...", MsgBoxStyle.Critical, "Informasi  System")
            Exit Sub
        ElseIf Format(dtMulai.Value, "yyyyMMdd") = Format(Now, "yyyyMMdd") Then
            If Format(dtJamMulai.Value, "hhmm") < Format(Now, "hhmm") Then
                MsgBox("Jam Mulai Tidak Boleh Lebih Kecil dari Jam Hari ini...", MsgBoxStyle.Critical, "Informasi  System")
                Exit Sub
            End If
        ElseIf Format(dtSelesai.Value, "yyyyMMdd") = Format(Now, "yyyyMMdd") Then
            If Format(dtJamSelesai.Text, "hhmm") < Format(Now, "hhmm") Then
                MsgBox("Jam Selesai Tidak Boleh Lebih Kecil dari Jam Hari ini...", MsgBoxStyle.Critical, "Informasi  System")
                Exit Sub
            End If
        End If

        'Cek Nomor Sudah Ada Atau Belum
        CMD = New OleDbCommand("Select * from Tbl_JadwalMeeting where Nomor = '" & txtNomor.Text & "'", Conn)
        DR = CMD.ExecuteReader
        If DR.HasRows Then
            MsgBox("Nomor Sudah Terdaftar, Silahkan Klik Tombol NEW untuk Input Baru ...", MsgBoxStyle.Critical, "Informasi  System")
            Exit Sub
            DR.Close()
        Else
            DR.Close()
        End If

        'Cek Ruangan sedang Dipakai Atau tidak
        CMD = New OleDbCommand("Select * from Tbl_JadwalMeeting where TglMulai > #" & Format(dtMulai.Value, "MM/dd/yyyy") & "# AND Ruangan = '" & cbBagian.Text & "' ", Conn)
        DR = CMD.ExecuteReader
        If DR.HasRows Then
            DR.Close()
            CMD = New OleDbCommand("Select * from Tbl_JadwalMeeting where TglMulai >= #" & dtJamMulai.Value & "# and TglSelesai <= #" & dtJamSelesai.Value & "# ", Conn)
            DR = CMD.ExecuteReader
            If DR.HasRows Then
                MsgBox("Ruangan untuk Jam ini Sudah Terpakai ...", MsgBoxStyle.Critical, "Informasi  System")
                Exit Sub
                DR.Close()
            End If
        Else
            DR.Close()
        End If

        SimpanLog()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call Koneksi()
        Call TampilGrid()
        button()
        nomorJadwal()
        isiText()
    End Sub

    Private Sub btnCloseLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseLog.Click
        Me.Close()
    End Sub

    Private Sub txtCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCari.KeyPress
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If

        If e.KeyChar = Chr(13) Then
            CMD = New OleDbCommand("SELECT * FROM Tbl_JadwalMeeting WHERE Nomor LIKE '%" & txtCari.Text & "%' or TglMulai LIKE '%" & txtCari.Text & "%' or TglSelesai LIKE '%" & txtCari.Text & "%' or Unit LIKE '%" & txtCari.Text & "%' or Ruangan LIKE '%" & txtCari.Text & "%' or PIC LIKE '%" & txtCari.Text & "%' ", Conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                DA = New OleDbDataAdapter("SELECT * FROM Tbl_JadwalMeeting WHERE Nomor LIKE '%" & txtCari.Text & "%' or TglMulai LIKE '%" & txtCari.Text & "%' or TglSelesai LIKE '%" & txtCari.Text & "%' or Unit LIKE '%" & txtCari.Text & "%' or Ruangan LIKE '%" & txtCari.Text & "%' or PIC LIKE '%" & txtCari.Text & "%' ", Conn)
                DS = New DataSet
                DA.Fill(DS, "Tbl_JadwalMeeting")
                dgvJadwal.DataSource = DS.Tables("Tbl_JadwalMeeting")
                dgvJadwal.ReadOnly = True
                Me.txtNomor.Text = DR.Item(0)
                Me.txtUnit.Text = DR.Item(3)
                Me.cbBagian.Text = DR.Item(4)
                Me.txtPIC.Text = DR.Item(5)
            Else
                MsgBox("Data Tidak Ada", MsgBoxStyle.Critical, "Informasi  System")
            End If
        End If
    End Sub
End Class