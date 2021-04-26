<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlLeftSide = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlOnButtonPosition = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnDeserts = New System.Windows.Forms.Button()
        Me.btnFoods = New System.Windows.Forms.Button()
        Me.picMaximize = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlLeftSide.SuspendLayout()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeftSide
        '
        Me.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlLeftSide.Controls.Add(Me.Panel1)
        Me.pnlLeftSide.Controls.Add(Me.Label1)
        Me.pnlLeftSide.Controls.Add(Me.pnlOnButtonPosition)
        Me.pnlLeftSide.Controls.Add(Me.Label19)
        Me.pnlLeftSide.Controls.Add(Me.Label16)
        Me.pnlLeftSide.Controls.Add(Me.btnAboutUs)
        Me.pnlLeftSide.Controls.Add(Me.btnDrinks)
        Me.pnlLeftSide.Controls.Add(Me.btnDeserts)
        Me.pnlLeftSide.Controls.Add(Me.btnFoods)
        Me.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftSide.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlLeftSide.Name = "pnlLeftSide"
        Me.pnlLeftSide.Size = New System.Drawing.Size(267, 613)
        Me.pnlLeftSide.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Location = New System.Drawing.Point(0, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 3)
        Me.Panel1.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(4, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Sistem Informasi Untuk Input Jadwal Meeting"
        '
        'pnlOnButtonPosition
        '
        Me.pnlOnButtonPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlOnButtonPosition.Location = New System.Drawing.Point(0, 98)
        Me.pnlOnButtonPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOnButtonPosition.Name = "pnlOnButtonPosition"
        Me.pnlOnButtonPosition.Size = New System.Drawing.Size(13, 46)
        Me.pnlOnButtonPosition.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(128, 10)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 36)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "e-Jm"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(1, 10)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 36)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Aplikasi"
        '
        'btnAboutUs
        '
        Me.btnAboutUs.FlatAppearance.BorderSize = 0
        Me.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutUs.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAboutUs.Image = CType(resources.GetObject("btnAboutUs.Image"), System.Drawing.Image)
        Me.btnAboutUs.Location = New System.Drawing.Point(0, 310)
        Me.btnAboutUs.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(267, 46)
        Me.btnAboutUs.TabIndex = 8
        Me.btnAboutUs.Text = "        About     "
        Me.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAboutUs.UseVisualStyleBackColor = True
        '
        'btnDrinks
        '
        Me.btnDrinks.FlatAppearance.BorderSize = 0
        Me.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDrinks.Image = CType(resources.GetObject("btnDrinks.Image"), System.Drawing.Image)
        Me.btnDrinks.Location = New System.Drawing.Point(0, 165)
        Me.btnDrinks.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(267, 46)
        Me.btnDrinks.TabIndex = 4
        Me.btnDrinks.Text = "  Ganti Password"
        Me.btnDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'btnDeserts
        '
        Me.btnDeserts.FlatAppearance.BorderSize = 0
        Me.btnDeserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeserts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeserts.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeserts.Image = CType(resources.GetObject("btnDeserts.Image"), System.Drawing.Image)
        Me.btnDeserts.Location = New System.Drawing.Point(0, 237)
        Me.btnDeserts.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeserts.Name = "btnDeserts"
        Me.btnDeserts.Size = New System.Drawing.Size(267, 46)
        Me.btnDeserts.TabIndex = 2
        Me.btnDeserts.Text = "        Laporan      "
        Me.btnDeserts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeserts.UseVisualStyleBackColor = True
        '
        'btnFoods
        '
        Me.btnFoods.FlatAppearance.BorderSize = 0
        Me.btnFoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoods.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoods.ForeColor = System.Drawing.SystemColors.Control
        Me.btnFoods.Image = CType(resources.GetObject("btnFoods.Image"), System.Drawing.Image)
        Me.btnFoods.Location = New System.Drawing.Point(0, 98)
        Me.btnFoods.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFoods.Name = "btnFoods"
        Me.btnFoods.Size = New System.Drawing.Size(267, 46)
        Me.btnFoods.TabIndex = 0
        Me.btnFoods.Text = "   Input Jadwal"
        Me.btnFoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFoods.UseVisualStyleBackColor = True
        '
        'picMaximize
        '
        Me.picMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMaximize.Image = CType(resources.GetObject("picMaximize.Image"), System.Drawing.Image)
        Me.picMaximize.Location = New System.Drawing.Point(731, 4)
        Me.picMaximize.Margin = New System.Windows.Forms.Padding(4)
        Me.picMaximize.Name = "picMaximize"
        Me.picMaximize.Size = New System.Drawing.Size(24, 22)
        Me.picMaximize.TabIndex = 14
        Me.picMaximize.TabStop = False
        Me.picMaximize.Visible = False
        '
        'picMinimize
        '
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize.Image = CType(resources.GetObject("picMinimize.Image"), System.Drawing.Image)
        Me.picMinimize.Location = New System.Drawing.Point(846, 4)
        Me.picMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(24, 22)
        Me.picMinimize.TabIndex = 13
        Me.picMinimize.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(873, 4)
        Me.picClose.Margin = New System.Windows.Forms.Padding(4)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(24, 22)
        Me.picClose.TabIndex = 12
        Me.picClose.TabStop = False
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.pnlTopSide.Controls.Add(Me.picMaximize)
        Me.pnlTopSide.Controls.Add(Me.picClose)
        Me.pnlTopSide.Controls.Add(Me.picMinimize)
        Me.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopSide.Location = New System.Drawing.Point(267, 0)
        Me.pnlTopSide.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(910, 36)
        Me.pnlTopSide.TabIndex = 1
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.pnlTopSide
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(267, 43)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(911, 570)
        Me.Panel2.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 613)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlTopSide)
        Me.Controls.Add(Me.pnlLeftSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlLeftSide.ResumeLayout(False)
        Me.pnlLeftSide.PerformLayout()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLeftSide As Panel
    Friend WithEvents pnlOnButtonPosition As Panel
    Friend WithEvents btnFoods As Button
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnDeserts As Button
    Friend WithEvents picClose As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picMaximize As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
