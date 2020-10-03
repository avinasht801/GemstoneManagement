<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbpasswd = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnlogin = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.tt = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(104, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(104, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 24)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Password:"
        '
        'tbpasswd
        '
        Me.tbpasswd.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpasswd.Location = New System.Drawing.Point(252, 189)
        Me.tbpasswd.Name = "tbpasswd"
        Me.tbpasswd.Size = New System.Drawing.Size(231, 38)
        Me.tbpasswd.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.tbpasswd, "Enter your password")
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Navy
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 388)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(10, 10)
        Me.ProgressBar1.TabIndex = 52
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = Global.Gemstone_Management.My.Resources.Resources.Delete_5
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(334, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 51)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "  &Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(101, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(448, 80)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "LOGIN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.White
        Me.btnlogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Navy
        Me.btnlogin.Image = Global.Gemstone_Management.My.Resources.Resources.oAccess
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogin.Location = New System.Drawing.Point(161, 269)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(149, 51)
        Me.btnlogin.TabIndex = 50
        Me.btnlogin.Text = "  &Login"
        Me.ToolTip1.SetToolTip(Me.btnlogin, "Click to Login")
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(489, 204)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(99, 17)
        Me.CheckBox1.TabIndex = 55
        Me.CheckBox1.Text = "show password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'tt
        '
        Me.tt.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tt.Location = New System.Drawing.Point(252, 99)
        Me.tt.Name = "tt"
        Me.tt.Size = New System.Drawing.Size(231, 41)
        Me.tt.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.tt, "Enter your Username")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!)
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Red
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(444, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(141, 17)
        Me.LinkLabel1.TabIndex = 57
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password?"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Click to recover your Password")
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Red
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Info"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(597, 396)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.tbpasswd)
        Me.Controls.Add(Me.tt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbpasswd As System.Windows.Forms.TextBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents tt As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
