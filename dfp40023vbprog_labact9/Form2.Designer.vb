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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIRSTPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SECONDPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.THIRDPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOURTHPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAnotherIf = New System.Windows.Forms.Button()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PAGEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(362, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PAGEToolStripMenuItem
        '
        Me.PAGEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIRSTPAGEToolStripMenuItem, Me.SECONDPAGEToolStripMenuItem, Me.THIRDPAGEToolStripMenuItem, Me.FOURTHPAGEToolStripMenuItem, Me.ToolStripMenuItem1, Me.EXITToolStripMenuItem})
        Me.PAGEToolStripMenuItem.Name = "PAGEToolStripMenuItem"
        Me.PAGEToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.PAGEToolStripMenuItem.Text = "PAGE"
        '
        'FIRSTPAGEToolStripMenuItem
        '
        Me.FIRSTPAGEToolStripMenuItem.Name = "FIRSTPAGEToolStripMenuItem"
        Me.FIRSTPAGEToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.FIRSTPAGEToolStripMenuItem.Text = "FIRST PAGE"
        '
        'SECONDPAGEToolStripMenuItem
        '
        Me.SECONDPAGEToolStripMenuItem.Name = "SECONDPAGEToolStripMenuItem"
        Me.SECONDPAGEToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.SECONDPAGEToolStripMenuItem.Text = "SECOND PAGE "
        '
        'THIRDPAGEToolStripMenuItem
        '
        Me.THIRDPAGEToolStripMenuItem.Name = "THIRDPAGEToolStripMenuItem"
        Me.THIRDPAGEToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.THIRDPAGEToolStripMenuItem.Text = "THIRD PAGE"
        '
        'FOURTHPAGEToolStripMenuItem
        '
        Me.FOURTHPAGEToolStripMenuItem.Name = "FOURTHPAGEToolStripMenuItem"
        Me.FOURTHPAGEToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.FOURTHPAGEToolStripMenuItem.Text = "FOURTH PAGE"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(190, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'btnAnotherIf
        '
        Me.btnAnotherIf.Location = New System.Drawing.Point(134, 197)
        Me.btnAnotherIf.Name = "btnAnotherIf"
        Me.btnAnotherIf.Size = New System.Drawing.Size(93, 27)
        Me.btnAnotherIf.TabIndex = 1
        Me.btnAnotherIf.Text = "CLICK ME"
        Me.btnAnotherIf.UseVisualStyleBackColor = True
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Location = New System.Drawing.Point(119, 99)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(125, 17)
        Me.lblGuess.TabIndex = 2
        Me.lblGuess.Text = "Guess the number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 141)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 277)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.btnAnotherIf)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "ACTIVITY 9.2: ALLOWING MULTIPLE ALTERNATIVES WITH ELSEIF"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIRSTPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAnotherIf As Button
    Friend WithEvents lblGuess As Label
    Friend WithEvents THIRDPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SECONDPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FOURTHPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
End Class
