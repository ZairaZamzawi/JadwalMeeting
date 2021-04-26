<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Laporan
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
        Me.dtAwal = New System.Windows.Forms.DateTimePicker()
        Me.dtAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbPeriode = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PB = New System.Windows.Forms.PictureBox()
        Me.lblLaporan = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbBulanan = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtBulan = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbNama = New System.Windows.Forms.ListBox()
        Me.gbPeriode.SuspendLayout()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBulanan.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtAwal
        '
        Me.dtAwal.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.dtAwal.CustomFormat = "dd MMM yyyy"
        Me.dtAwal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAwal.Location = New System.Drawing.Point(88, 27)
        Me.dtAwal.Margin = New System.Windows.Forms.Padding(4)
        Me.dtAwal.Name = "dtAwal"
        Me.dtAwal.Size = New System.Drawing.Size(148, 27)
        Me.dtAwal.TabIndex = 0
        Me.dtAwal.Visible = False
        '
        'dtAkhir
        '
        Me.dtAkhir.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.dtAkhir.CalendarTrailingForeColor = System.Drawing.Color.LightYellow
        Me.dtAkhir.CustomFormat = "dd MMM yyyy"
        Me.dtAkhir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAkhir.Location = New System.Drawing.Point(348, 27)
        Me.dtAkhir.Margin = New System.Windows.Forms.Padding(4)
        Me.dtAkhir.Name = "dtAkhir"
        Me.dtAkhir.Size = New System.Drawing.Size(148, 27)
        Me.dtAkhir.TabIndex = 1
        Me.dtAkhir.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(267, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sampai"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Dari"
        Me.Label3.Visible = False
        '
        'gbPeriode
        '
        Me.gbPeriode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbPeriode.Controls.Add(Me.btnCancel)
        Me.gbPeriode.Controls.Add(Me.btnPrint)
        Me.gbPeriode.Controls.Add(Me.Label4)
        Me.gbPeriode.Controls.Add(Me.Label3)
        Me.gbPeriode.Controls.Add(Me.dtAkhir)
        Me.gbPeriode.Controls.Add(Me.dtAwal)
        Me.gbPeriode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPeriode.Location = New System.Drawing.Point(88, 318)
        Me.gbPeriode.Margin = New System.Windows.Forms.Padding(4)
        Me.gbPeriode.Name = "gbPeriode"
        Me.gbPeriode.Padding = New System.Windows.Forms.Padding(4)
        Me.gbPeriode.Size = New System.Drawing.Size(543, 119)
        Me.gbPeriode.TabIndex = 2
        Me.gbPeriode.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(263, 62)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 41)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrint.BackColor = System.Drawing.Color.Gray
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(151, 62)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 41)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(9, 4)
        Me.PB.Margin = New System.Windows.Forms.Padding(4)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(61, 47)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB.TabIndex = 86
        Me.PB.TabStop = False
        '
        'lblLaporan
        '
        Me.lblLaporan.AutoSize = True
        Me.lblLaporan.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLaporan.Location = New System.Drawing.Point(72, 12)
        Me.lblLaporan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLaporan.Name = "lblLaporan"
        Me.lblLaporan.Size = New System.Drawing.Size(125, 33)
        Me.lblLaporan.TabIndex = 85
        Me.lblLaporan.Text = "Laporan"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Location = New System.Drawing.Point(0, 53)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 15)
        Me.Panel1.TabIndex = 84
        '
        'gbBulanan
        '
        Me.gbBulanan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbBulanan.Controls.Add(Me.Label6)
        Me.gbBulanan.Controls.Add(Me.dtBulan)
        Me.gbBulanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBulanan.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBulanan.Location = New System.Drawing.Point(88, 479)
        Me.gbBulanan.Margin = New System.Windows.Forms.Padding(4)
        Me.gbBulanan.Name = "gbBulanan"
        Me.gbBulanan.Padding = New System.Windows.Forms.Padding(4)
        Me.gbBulanan.Size = New System.Drawing.Size(241, 69)
        Me.gbBulanan.TabIndex = 4
        Me.gbBulanan.TabStop = False
        Me.gbBulanan.Text = "Periode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Bulan"
        '
        'dtBulan
        '
        Me.dtBulan.CalendarMonthBackground = System.Drawing.Color.LightYellow
        Me.dtBulan.CalendarTrailingForeColor = System.Drawing.Color.LightYellow
        Me.dtBulan.CustomFormat = "MMM yyyy"
        Me.dtBulan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBulan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBulan.Location = New System.Drawing.Point(77, 27)
        Me.dtBulan.Margin = New System.Windows.Forms.Padding(4)
        Me.dtBulan.Name = "dtBulan"
        Me.dtBulan.Size = New System.Drawing.Size(132, 27)
        Me.dtBulan.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.lbNama)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 128)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(699, 185)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nama Laporan"
        '
        'lbNama
        '
        Me.lbNama.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbNama.BackColor = System.Drawing.Color.White
        Me.lbNama.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNama.FormattingEnabled = True
        Me.lbNama.ItemHeight = 23
        Me.lbNama.Location = New System.Drawing.Point(80, 31)
        Me.lbNama.Margin = New System.Windows.Forms.Padding(4)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(541, 142)
        Me.lbNama.TabIndex = 2
        '
        'Frm_Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 663)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbPeriode)
        Me.Controls.Add(Me.gbBulanan)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.lblLaporan)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Laporan"
        Me.Text = "Laporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbPeriode.ResumeLayout(False)
        Me.gbPeriode.PerformLayout()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBulanan.ResumeLayout(False)
        Me.gbBulanan.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbPeriode As System.Windows.Forms.GroupBox
    Friend WithEvents PB As System.Windows.Forms.PictureBox
    Friend WithEvents lblLaporan As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gbBulanan As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtBulan As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbNama As ListBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint As Button
End Class
