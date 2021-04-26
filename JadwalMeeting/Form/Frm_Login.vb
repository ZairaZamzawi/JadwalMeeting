Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Frm_Login

    Private Sub Frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        If File.Exists(Application.StartupPath & "\image\login.png") Then Panel1.BackgroundImage = Image.FromFile(Application.StartupPath & "\image\login.png")
        ' If File.Exists(Application.StartupPath & "\conf\image\logo.jpg") Then pbLogo.Image = Image.FromFile(Application.StartupPath & "\conf\image\logo.jpg")
        ' mStart = True
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.ForeColor = System.Drawing.Color.White
        btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        'Frm_Utama.pnlMenuUtama.SplitterDistance = 125
        NonUser()
        NonPass()
        newFont()
        TextBox1.Focus()
        txtUsername.Text = "USERNAME"
        txtPassword.Text = "PASSWORD"

    End Sub

    Private Sub Panel1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.DoubleClick
        End
    End Sub
    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If

    End Sub

    Sub NonPass()
        rsPass.Visible = False
        rsPass1.Visible = False
        rsPass2.Visible = False
    End Sub
    Sub Pass()
        rsPass.Visible = True
        rsPass1.Visible = True
        rsPass2.Visible = True
    End Sub
    Sub NonUser()
        rsUser.Visible = False
        rsUser1.Visible = False
        rsUser2.Visible = False
    End Sub
    Sub User()
        rsUser.Visible = True
        rsUser1.Visible = True
        rsUser2.Visible = True
    End Sub
    Private Sub txtUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        User()
        NonPass()
        lblStatus.Text = ""
        txtUsername.Clear()

    End Sub
    Sub newFont()
        Dim new_font As New Font("webdings", 11, FontStyle.Regular)
        txtPassword.Font = new_font
        txtPassword.PasswordChar = "="
    End Sub
    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        NonUser()
        Pass()
        newFont()
        lblStatus.Text = ""
        txtPassword.Clear()
    End Sub

    Private Sub btnLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If

        If txtUsername.Text = "" Then
            MsgBox("Silahkan Isi Username Anda...", MsgBoxStyle.Information, "Informasi  System")
            txtUsername.Focus()
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MsgBox("Silahkan Isi Password Anda...", MsgBoxStyle.Information, "Informasi  System")
            txtPassword.Focus()
            Exit Sub
        End If
        CMD = New OleDbCommand("Select * from Tbl_User where username = '" & txtUsername.Text & "' and password ='" & txtPassword.Text & "'", Conn)
        DR = CMD.ExecuteReader
        mpass = Mod_Global.CariDataGlobal(Me.txtUsername.Text, "password", "Tbl_User", "USERNAME")
        mUnit = Mod_Global.CariDataGlobal(Me.txtUsername.Text, "unit", "Tbl_User", "USERNAME")
        mUsername = Mod_Global.CariDataGlobal(Me.txtUsername.Text, "USERNAME", "Tbl_User", "USERNAME")
        If UCase(mUsername) <> txtUsername.Text Then
            lblStatus.Text = "User Login Tidak terdaftar !!!"
        ElseIf Trim(UCase((mpass))) <> Trim(UCase(txtPassword.Text)) Then
            If mlog < 3 Then
                lblStatus.Text = "Password Salah, silahkan coba lagi !!!"
                mlog = mlog + 1
                DR.Close()
                Exit Sub
            Else
                MsgBox("Anda Tidak Berhak Menggunakan System ini !!!", MsgBoxStyle.Critical, "Informasi")
                End
            End If

        Else
            mCurrUser = txtUsername.Text
            Me.Hide()
            With frmMain
                .Show()
                mStart = True
            End With
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown

    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        Button1.PerformClick()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub rsUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rsUser.Click

    End Sub

    Private Sub Panel1_Disposed(sender As Object, e As EventArgs) Handles Panel1.Disposed

    End Sub
End Class