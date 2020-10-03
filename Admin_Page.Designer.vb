<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Page
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(84, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 32)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Pick a Task..."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(16, 285)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 73)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "View Purchase History"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Location = New System.Drawing.Point(233, 185)
        Me.Button3.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(193, 73)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "Purchase a Gemstone "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Navy
        Me.Button4.Location = New System.Drawing.Point(16, 185)
        Me.Button4.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(193, 73)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "Manage Gemstones"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Navy
        Me.Button5.Location = New System.Drawing.Point(233, 285)
        Me.Button5.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(193, 73)
        Me.Button5.TabIndex = 54
        Me.Button5.Text = "Log out"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Image = Global.Gemstone_Management.My.Resources.Resources.delete_user
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(233, 86)
        Me.Button2.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(193, 73)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "       Delete user"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Navy
        Me.Button6.Image = Global.Gemstone_Management.My.Resources.Resources.new_user1
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(16, 86)
        Me.Button6.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(193, 73)
        Me.Button6.TabIndex = 55
        Me.Button6.Text = "          Add admin/user"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Admin_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(535, 406)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Admin_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
