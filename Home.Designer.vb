<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AddAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManageStocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchaseHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.WholesellerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LowStockProductListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WholesellerReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchaseReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchaseGraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesGraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAccountToolStripMenuItem, Me.ProductToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(811, 24)
        Me.MenuStrip1.TabIndex = 56
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddAccountToolStripMenuItem
        '
        Me.AddAccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.DeleteUserToolStripMenuItem, Me.ExitToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.AddAccountToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAccountToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources.Register
        Me.AddAccountToolStripMenuItem.Name = "AddAccountToolStripMenuItem"
        Me.AddAccountToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.AddAccountToolStripMenuItem.Text = "&Account"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459087549_user_group
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459087737_block_user
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.DeleteUserToolStripMenuItem.Text = "Delete User"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459087865_application_pgp_signature
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ExitToolStripMenuItem.Text = "Change Password "
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources.logout__ios_7_interface_symbol_318_33643
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.Gemstone_Management.My.Resources.Resources._1459088068_Delete
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductToolStripMenuItem, Me.ManageStocksToolStripMenuItem})
        Me.ProductToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459086936_diamond
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.ProductToolStripMenuItem.Text = "&Product"
        '
        'AddProductToolStripMenuItem
        '
        Me.AddProductToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459088370_diamond_gem_ruby
        Me.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        Me.AddProductToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AddProductToolStripMenuItem.Text = "Sell a Gemstone"
        '
        'ManageStocksToolStripMenuItem
        '
        Me.ManageStocksToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459088436_stocks_ios7_ios_7
        Me.ManageStocksToolStripMenuItem.Name = "ManageStocksToolStripMenuItem"
        Me.ManageStocksToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ManageStocksToolStripMenuItem.Text = "Manage Stocks"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseHistoryToolStripMenuItem, Me.SalesDetailsToolStripMenuItem, Me.CustomerDetailsToolStripMenuItem1, Me.WholesellerDetailsToolStripMenuItem, Me.LowStockProductListToolStripMenuItem, Me.EmployeeDetailsToolStripMenuItem})
        Me.DetailsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459087233_client_account_template
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.DetailsToolStripMenuItem.Text = "&View"
        '
        'PurchaseHistoryToolStripMenuItem
        '
        Me.PurchaseHistoryToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459087017_application_view_detail
        Me.PurchaseHistoryToolStripMenuItem.Name = "PurchaseHistoryToolStripMenuItem"
        Me.PurchaseHistoryToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.PurchaseHistoryToolStripMenuItem.Text = "Purchase History"
        '
        'SalesDetailsToolStripMenuItem
        '
        Me.SalesDetailsToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources.chart_4_512
        Me.SalesDetailsToolStripMenuItem.Name = "SalesDetailsToolStripMenuItem"
        Me.SalesDetailsToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.SalesDetailsToolStripMenuItem.Text = "Sales History"
        '
        'CustomerDetailsToolStripMenuItem1
        '
        Me.CustomerDetailsToolStripMenuItem1.Image = Global.Gemstone_Management.My.Resources.Resources.contact_details__ios_7_interface_symbol_318_33582
        Me.CustomerDetailsToolStripMenuItem1.Name = "CustomerDetailsToolStripMenuItem1"
        Me.CustomerDetailsToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
        Me.CustomerDetailsToolStripMenuItem1.Text = "Customer Details"
        '
        'WholesellerDetailsToolStripMenuItem
        '
        Me.WholesellerDetailsToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources.tarjeta_de_identificacion_profesional_318_38534
        Me.WholesellerDetailsToolStripMenuItem.Name = "WholesellerDetailsToolStripMenuItem"
        Me.WholesellerDetailsToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.WholesellerDetailsToolStripMenuItem.Text = "Wholeseller Details"
        '
        'LowStockProductListToolStripMenuItem
        '
        Me.LowStockProductListToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources.warning_icon_hi
        Me.LowStockProductListToolStripMenuItem.Name = "LowStockProductListToolStripMenuItem"
        Me.LowStockProductListToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.LowStockProductListToolStripMenuItem.Text = "Low Stock Product list "
        '
        'EmployeeDetailsToolStripMenuItem
        '
        Me.EmployeeDetailsToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources.administrator
        Me.EmployeeDetailsToolStripMenuItem.Name = "EmployeeDetailsToolStripMenuItem"
        Me.EmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EmployeeDetailsToolStripMenuItem.Text = "Employee Details"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerReportsToolStripMenuItem, Me.WholesellerReportsToolStripMenuItem, Me.EmployeeReportsToolStripMenuItem, Me.PurchaseReportsToolStripMenuItem, Me.SalesReportsToolStripMenuItem, Me.PurchaseGraphToolStripMenuItem, Me.SalesGraphToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ReportsToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459640475_Bar_Chart
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports/Stats"
        '
        'CustomerReportsToolStripMenuItem
        '
        Me.CustomerReportsToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459636952_vector_65_01
        Me.CustomerReportsToolStripMenuItem.Name = "CustomerReportsToolStripMenuItem"
        Me.CustomerReportsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CustomerReportsToolStripMenuItem.Text = "Customer Reports"
        '
        'WholesellerReportsToolStripMenuItem
        '
        Me.WholesellerReportsToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459637439_Diagram
        Me.WholesellerReportsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WholesellerReportsToolStripMenuItem.Name = "WholesellerReportsToolStripMenuItem"
        Me.WholesellerReportsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.WholesellerReportsToolStripMenuItem.Text = "WholeSeller Reports"
        '
        'EmployeeReportsToolStripMenuItem
        '
        Me.EmployeeReportsToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459637597_Credit_report
        Me.EmployeeReportsToolStripMenuItem.Name = "EmployeeReportsToolStripMenuItem"
        Me.EmployeeReportsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.EmployeeReportsToolStripMenuItem.Text = "Employee Reports"
        '
        'PurchaseReportsToolStripMenuItem
        '
        Me.PurchaseReportsToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459637787_clipboard
        Me.PurchaseReportsToolStripMenuItem.Name = "PurchaseReportsToolStripMenuItem"
        Me.PurchaseReportsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.PurchaseReportsToolStripMenuItem.Text = "Purchase Reports"
        '
        'SalesReportsToolStripMenuItem
        '
        Me.SalesReportsToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459637960_document
        Me.SalesReportsToolStripMenuItem.Name = "SalesReportsToolStripMenuItem"
        Me.SalesReportsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SalesReportsToolStripMenuItem.Text = "Sales Reports"
        '
        'PurchaseGraphToolStripMenuItem
        '
        Me.PurchaseGraphToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459797628_chart
        Me.PurchaseGraphToolStripMenuItem.Name = "PurchaseGraphToolStripMenuItem"
        Me.PurchaseGraphToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.PurchaseGraphToolStripMenuItem.Text = "Purchase Graph"
        '
        'SalesGraphToolStripMenuItem
        '
        Me.SalesGraphToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459797713_device_board_presentation_content_chart_glyph
        Me.SalesGraphToolStripMenuItem.Name = "SalesGraphToolStripMenuItem"
        Me.SalesGraphToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SalesGraphToolStripMenuItem.Text = "Sales Graph"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459087451_json
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Gemstone_Management.My.Resources.Resources._1459087318_group
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(623, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "User Login :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(729, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Label2"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Image = Global.Gemstone_Management.My.Resources.Resources.output_RO3ecU
        Me.Label19.Location = New System.Drawing.Point(629, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(163, 19)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "-                                    -"
        Me.Label19.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = Global.Gemstone_Management.My.Resources.Resources.m___
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(811, 470)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageStocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WholesellerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LowStockProductListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WholesellerReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PurchaseGraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesGraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
