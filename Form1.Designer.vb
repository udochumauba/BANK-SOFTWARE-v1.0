<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CREATEACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEPOSITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSFERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WITHDRAWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERPROFILESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSACTIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.DEPOSITToolStripMenuItem, Me.TRANSFERToolStripMenuItem, Me.WITHDRAWToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CREATEACCOUNTToolStripMenuItem})
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'CREATEACCOUNTToolStripMenuItem
        '
        Me.CREATEACCOUNTToolStripMenuItem.Name = "CREATEACCOUNTToolStripMenuItem"
        Me.CREATEACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CREATEACCOUNTToolStripMenuItem.Text = "CREATE ACCOUNT"
        '
        'DEPOSITToolStripMenuItem
        '
        Me.DEPOSITToolStripMenuItem.Name = "DEPOSITToolStripMenuItem"
        Me.DEPOSITToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.DEPOSITToolStripMenuItem.Text = "DEPOSIT"
        '
        'TRANSFERToolStripMenuItem
        '
        Me.TRANSFERToolStripMenuItem.Name = "TRANSFERToolStripMenuItem"
        Me.TRANSFERToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.TRANSFERToolStripMenuItem.Text = "TRANSFER"
        '
        'WITHDRAWToolStripMenuItem
        '
        Me.WITHDRAWToolStripMenuItem.Name = "WITHDRAWToolStripMenuItem"
        Me.WITHDRAWToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.WITHDRAWToolStripMenuItem.Text = "WITHDRAW"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERPROFILESToolStripMenuItem, Me.TRANSACTIONSToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'USERPROFILESToolStripMenuItem
        '
        Me.USERPROFILESToolStripMenuItem.Name = "USERPROFILESToolStripMenuItem"
        Me.USERPROFILESToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.USERPROFILESToolStripMenuItem.Text = "USER PROFILES"
        '
        'TRANSACTIONSToolStripMenuItem
        '
        Me.TRANSACTIONSToolStripMenuItem.Name = "TRANSACTIONSToolStripMenuItem"
        Me.TRANSACTIONSToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.TRANSACTIONSToolStripMenuItem.Text = "TRANSACTIONS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(579, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 31)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "BETTER BANK"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(859, 640)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Bank System Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DEPOSITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSFERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WITHDRAWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERPROFILESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSACTIONSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CREATEACCOUNTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
