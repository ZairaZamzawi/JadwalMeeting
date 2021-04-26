<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rsUser = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rsUser2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.rsUser1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.rsPass2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.rsPass1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.rsPass = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 307)
        Me.Panel1.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Gray
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(164, 259)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 37)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 262)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 20)
        Me.TextBox1.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.LightYellow
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(113, 245)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 16)
        Me.lblStatus.TabIndex = 9
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.LightYellow
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.Location = New System.Drawing.Point(205, 208)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(132, 19)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = "PASSWORD"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.LightYellow
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Location = New System.Drawing.Point(207, 161)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(132, 19)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.Text = "USERNAME"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rsUser, Me.rsUser2, Me.rsUser1, Me.rsPass2, Me.rsPass1, Me.rsPass})
        Me.ShapeContainer1.Size = New System.Drawing.Size(428, 307)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'rsUser
        '
        Me.rsUser.BorderColor = System.Drawing.Color.Red
        Me.rsUser.BorderWidth = 3
        Me.rsUser.Location = New System.Drawing.Point(116, 151)
        Me.rsUser.Name = "rsUser"
        Me.rsUser.Size = New System.Drawing.Size(228, 39)
        '
        'rsUser2
        '
        Me.rsUser2.BorderColor = System.Drawing.Color.Red
        Me.rsUser2.BorderWidth = 3
        Me.rsUser2.Name = "rsUser2"
        Me.rsUser2.X1 = 200
        Me.rsUser2.X2 = 180
        Me.rsUser2.Y1 = 168
        Me.rsUser2.Y2 = 189
        '
        'rsUser1
        '
        Me.rsUser1.BorderColor = System.Drawing.Color.Red
        Me.rsUser1.BorderWidth = 3
        Me.rsUser1.Name = "rsUser1"
        Me.rsUser1.X1 = 179
        Me.rsUser1.X2 = 200
        Me.rsUser1.Y1 = 150
        Me.rsUser1.Y2 = 170
        '
        'rsPass2
        '
        Me.rsPass2.BorderColor = System.Drawing.Color.Red
        Me.rsPass2.BorderWidth = 3
        Me.rsPass2.Name = "rsPass2"
        Me.rsPass2.X1 = 199
        Me.rsPass2.X2 = 180
        Me.rsPass2.Y1 = 217
        Me.rsPass2.Y2 = 236
        '
        'rsPass1
        '
        Me.rsPass1.BorderColor = System.Drawing.Color.Red
        Me.rsPass1.BorderWidth = 3
        Me.rsPass1.Name = "rsPass1"
        Me.rsPass1.X1 = 179
        Me.rsPass1.X2 = 200
        Me.rsPass1.Y1 = 198
        Me.rsPass1.Y2 = 218
        '
        'rsPass
        '
        Me.rsPass.BorderColor = System.Drawing.Color.Red
        Me.rsPass.BorderWidth = 3
        Me.rsPass.Location = New System.Drawing.Point(116, 199)
        Me.rsPass.Name = "rsPass"
        Me.rsPass.Size = New System.Drawing.Size(229, 38)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 10)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "btn1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(428, 307)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Opacity = 0.7R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rsPass As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents rsPass2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents rsPass1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents rsUser2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents rsUser1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents rsUser As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
