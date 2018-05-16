<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpThẻĐọcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpThẻĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpThẻToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LậpThẻĐộcGiảToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LậpThẻĐọcGiảToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LậpThẻĐọcGiảToolStripMenuItem
        '
        Me.LậpThẻĐọcGiảToolStripMenuItem.Name = "LậpThẻĐọcGiảToolStripMenuItem"
        Me.LậpThẻĐọcGiảToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.LậpThẻĐọcGiảToolStripMenuItem.Text = "exit"
        '
        'LậpThẻĐộcGiảToolStripMenuItem
        '
        Me.LậpThẻĐộcGiảToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LậpThẻToolStripMenuItem})
        Me.LậpThẻĐộcGiảToolStripMenuItem.Name = "LậpThẻĐộcGiảToolStripMenuItem"
        Me.LậpThẻĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.LậpThẻĐộcGiảToolStripMenuItem.Text = "độc giả"
        '
        'LậpThẻToolStripMenuItem
        '
        Me.LậpThẻToolStripMenuItem.Name = "LậpThẻToolStripMenuItem"
        Me.LậpThẻToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.LậpThẻToolStripMenuItem.Text = "lập thẻ"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.Text = "Quản lý thư viện"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpThẻĐọcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpThẻĐộcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpThẻToolStripMenuItem As ToolStripMenuItem
End Class
