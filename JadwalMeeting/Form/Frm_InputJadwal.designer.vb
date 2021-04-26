<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InputJadwal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PB = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbBagian = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPIC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvJadwal = New System.Windows.Forms.DataGridView()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCloseLog = New System.Windows.Forms.Button()
        Me.btnUpdateLog = New System.Windows.Forms.Button()
        Me.btnSimpanLog = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dtMulai = New System.Windows.Forms.DateTimePicker()
        Me.dtSelesai = New System.Windows.Forms.DateTimePicker()
        Me.dtJamMulai = New System.Windows.Forms.DateTimePicker()
        Me.dtJamSelesai = New System.Windows.Forms.DateTimePicker()
        Me.txtCari = New System.Windows.Forms.TextBox()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(8, 2)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(46, 38)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB.TabIndex = 86
        Me.PB.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 33)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Input Jadwal Meeting"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Location = New System.Drawing.Point(1, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 17)
        Me.Panel1.TabIndex = 84
        '
        'cbBagian
        '
        Me.cbBagian.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbBagian.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbBagian.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBagian.FormattingEnabled = True
        Me.cbBagian.Items.AddRange(New Object() {"Ruang Rakor", "Ruang Auditorium"})
        Me.cbBagian.Location = New System.Drawing.Point(119, 177)
        Me.cbBagian.Name = "cbBagian"
        Me.cbBagian.Size = New System.Drawing.Size(278, 31)
        Me.cbBagian.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 23)
        Me.Label14.TabIndex = 112
        Me.Label14.Text = "Ruangan"
        '
        'txtNomor
        '
        Me.txtNomor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNomor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNomor.Enabled = False
        Me.txtNomor.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomor.Location = New System.Drawing.Point(119, 88)
        Me.txtNomor.MaxLength = 20
        Me.txtNomor.Multiline = True
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(199, 25)
        Me.txtNomor.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 23)
        Me.Label16.TabIndex = 108
        Me.Label16.Text = "Nomor"
        '
        'txtPIC
        '
        Me.txtPIC.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPIC.Enabled = False
        Me.txtPIC.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIC.Location = New System.Drawing.Point(119, 116)
        Me.txtPIC.MaxLength = 20
        Me.txtPIC.Multiline = True
        Me.txtPIC.Name = "txtPIC"
        Me.txtPIC.Size = New System.Drawing.Size(199, 25)
        Me.txtPIC.TabIndex = 115
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 23)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "PIC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(437, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 23)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Cari"
        '
        'dgvJadwal
        '
        Me.dgvJadwal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJadwal.Location = New System.Drawing.Point(8, 288)
        Me.dgvJadwal.Name = "dgvJadwal"
        Me.dgvJadwal.RowTemplate.Height = 24
        Me.dgvJadwal.Size = New System.Drawing.Size(656, 209)
        Me.dgvJadwal.TabIndex = 119
        '
        'txtUnit
        '
        Me.txtUnit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnit.Enabled = False
        Me.txtUnit.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(120, 147)
        Me.txtUnit.MaxLength = 20
        Me.txtUnit.Multiline = True
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(199, 25)
        Me.txtUnit.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 23)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 23)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Mulai"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 23)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Selesai"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCloseLog)
        Me.GroupBox3.Controls.Add(Me.btnUpdateLog)
        Me.GroupBox3.Controls.Add(Me.btnSimpanLog)
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Location = New System.Drawing.Point(343, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(191, 89)
        Me.GroupBox3.TabIndex = 129
        Me.GroupBox3.TabStop = False
        '
        'btnCloseLog
        '
        Me.btnCloseLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCloseLog.BackColor = System.Drawing.Color.Gray
        Me.btnCloseLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseLog.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseLog.Location = New System.Drawing.Point(98, 8)
        Me.btnCloseLog.Name = "btnCloseLog"
        Me.btnCloseLog.Size = New System.Drawing.Size(84, 33)
        Me.btnCloseLog.TabIndex = 117
        Me.btnCloseLog.Text = "&Close"
        Me.btnCloseLog.UseVisualStyleBackColor = False
        '
        'btnUpdateLog
        '
        Me.btnUpdateLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateLog.BackColor = System.Drawing.Color.Gray
        Me.btnUpdateLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateLog.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateLog.Location = New System.Drawing.Point(98, 47)
        Me.btnUpdateLog.Name = "btnUpdateLog"
        Me.btnUpdateLog.Size = New System.Drawing.Size(84, 33)
        Me.btnUpdateLog.TabIndex = 118
        Me.btnUpdateLog.Text = "&Update"
        Me.btnUpdateLog.UseVisualStyleBackColor = False
        Me.btnUpdateLog.Visible = False
        '
        'btnSimpanLog
        '
        Me.btnSimpanLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpanLog.BackColor = System.Drawing.Color.Gray
        Me.btnSimpanLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanLog.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpanLog.Location = New System.Drawing.Point(8, 47)
        Me.btnSimpanLog.Name = "btnSimpanLog"
        Me.btnSimpanLog.Size = New System.Drawing.Size(84, 33)
        Me.btnSimpanLog.TabIndex = 115
        Me.btnSimpanLog.Text = "&Save"
        Me.btnSimpanLog.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(8, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 33)
        Me.btnCancel.TabIndex = 116
        Me.btnCancel.Text = "&New"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'dtMulai
        '
        Me.dtMulai.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.dtMulai.CustomFormat = "dd MMM yyyy"
        Me.dtMulai.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtMulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtMulai.Location = New System.Drawing.Point(120, 224)
        Me.dtMulai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtMulai.Name = "dtMulai"
        Me.dtMulai.Size = New System.Drawing.Size(148, 27)
        Me.dtMulai.TabIndex = 130
        '
        'dtSelesai
        '
        Me.dtSelesai.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.dtSelesai.CustomFormat = "dd MMM yyyy"
        Me.dtSelesai.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtSelesai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSelesai.Location = New System.Drawing.Point(120, 258)
        Me.dtSelesai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtSelesai.Name = "dtSelesai"
        Me.dtSelesai.Size = New System.Drawing.Size(148, 27)
        Me.dtSelesai.TabIndex = 131
        '
        'dtJamMulai
        '
        Me.dtJamMulai.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.dtJamMulai.CustomFormat = "hh : mm"
        Me.dtJamMulai.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtJamMulai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtJamMulai.Location = New System.Drawing.Point(276, 225)
        Me.dtJamMulai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtJamMulai.Name = "dtJamMulai"
        Me.dtJamMulai.Size = New System.Drawing.Size(148, 27)
        Me.dtJamMulai.TabIndex = 132
        '
        'dtJamSelesai
        '
        Me.dtJamSelesai.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.dtJamSelesai.CustomFormat = "hh : mm"
        Me.dtJamSelesai.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtJamSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtJamSelesai.Location = New System.Drawing.Point(276, 258)
        Me.dtJamSelesai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtJamSelesai.Name = "dtJamSelesai"
        Me.dtJamSelesai.Size = New System.Drawing.Size(148, 27)
        Me.dtJamSelesai.TabIndex = 133
        '
        'txtCari
        '
        Me.txtCari.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCari.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(441, 258)
        Me.txtCari.MaxLength = 20
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(199, 30)
        Me.txtCari.TabIndex = 134
        '
        'Frm_InputJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 663)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.dtJamSelesai)
        Me.Controls.Add(Me.dtJamMulai)
        Me.Controls.Add(Me.dtSelesai)
        Me.Controls.Add(Me.dtMulai)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvJadwal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPIC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBagian)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNomor)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_InputJadwal"
        Me.Text = "Pengguna"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PB As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbBagian As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPIC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvJadwal As System.Windows.Forms.DataGridView
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCloseLog As System.Windows.Forms.Button
    Friend WithEvents btnUpdateLog As System.Windows.Forms.Button
    Friend WithEvents btnSimpanLog As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dtMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtJamMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtJamSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
End Class
