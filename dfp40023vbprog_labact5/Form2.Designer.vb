<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirstPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Page2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Show Message"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(131, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Display Input Box"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(99, 257)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(217, 22)
        Me.txtDisplay.TabIndex = 2
        Me.txtDisplay.Text = "WELCOME TO MY PROJECT"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(423, 30)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstPageToolStripMenuItem, Me.Page2ToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(63, 26)
        Me.FileToolStripMenuItem.Text = "Select"
        '
        'FirstPageToolStripMenuItem
        '
        Me.FirstPageToolStripMenuItem.Name = "FirstPageToolStripMenuItem"
        Me.FirstPageToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FirstPageToolStripMenuItem.Text = "Page1"
        '
        'Page2ToolStripMenuItem
        '
        Me.Page2ToolStripMenuItem.Name = "Page2ToolStripMenuItem"
        Me.Page2ToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.Page2ToolStripMenuItem.Text = "Page2"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 374)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FirstPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Page2ToolStripMenuItem As ToolStripMenuItem
End Class
