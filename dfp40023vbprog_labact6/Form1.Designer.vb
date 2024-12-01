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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FuleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectForeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectBackColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FuleToolStripMenuItem
        '
        Me.FuleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SveToolStripMenuItem, Me.SelectFontToolStripMenuItem, Me.SelectForeColorToolStripMenuItem, Me.SelectBackColorToolStripMenuItem})
        Me.FuleToolStripMenuItem.Name = "FuleToolStripMenuItem"
        Me.FuleToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FuleToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SveToolStripMenuItem
        '
        Me.SveToolStripMenuItem.Name = "SveToolStripMenuItem"
        Me.SveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SveToolStripMenuItem.Text = "Save"
        '
        'SelectFontToolStripMenuItem
        '
        Me.SelectFontToolStripMenuItem.Name = "SelectFontToolStripMenuItem"
        Me.SelectFontToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SelectFontToolStripMenuItem.Text = "Font"
        '
        'SelectForeColorToolStripMenuItem
        '
        Me.SelectForeColorToolStripMenuItem.Name = "SelectForeColorToolStripMenuItem"
        Me.SelectForeColorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SelectForeColorToolStripMenuItem.Text = "ForeColor"
        '
        'SelectBackColorToolStripMenuItem
        '
        Me.SelectBackColorToolStripMenuItem.Name = "SelectBackColorToolStripMenuItem"
        Me.SelectBackColorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SelectBackColorToolStripMenuItem.Text = "BackColor"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dialog Boxes Demo"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(212, 198)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(376, 30)
        Me.txtName.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 353)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FuleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectForeColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectBackColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
End Class
