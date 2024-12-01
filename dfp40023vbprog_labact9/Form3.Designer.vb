<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.THIRDPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOURTHPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.FIRSTPAGEToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.FIRSTPAGEToolStripMenuItem.Text = "FIRST PAGE"
        '
        'SECONDPAGEToolStripMenuItem
        '
        Me.SECONDPAGEToolStripMenuItem.Name = "SECONDPAGEToolStripMenuItem"
        Me.SECONDPAGEToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.SECONDPAGEToolStripMenuItem.Text = "SECOND PAGE"
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(122, 95)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(118, 17)
        Me.lblEnter.TabIndex = 4
        Me.lblEnter.Text = "Enter the number"
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(141, 132)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(80, 50)
        Me.btnInput.TabIndex = 3
        Me.btnInput.Text = "INPUT BOX"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'THIRDPAGEToolStripMenuItem
        '
        Me.THIRDPAGEToolStripMenuItem.Name = "THIRDPAGEToolStripMenuItem"
        Me.THIRDPAGEToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.THIRDPAGEToolStripMenuItem.Text = "THIRD PAGE"
        '
        'FOURTHPAGEToolStripMenuItem
        '
        Me.FOURTHPAGEToolStripMenuItem.Name = "FOURTHPAGEToolStripMenuItem"
        Me.FOURTHPAGEToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FOURTHPAGEToolStripMenuItem.Text = "FOURTH PAGE"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 277)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "ACTIVITY 9.3: CONTROL STRUCTURE (CASE SELECTION)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIRSTPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SECONDPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblEnter As Label
    Friend WithEvents btnInput As Button
    Friend WithEvents THIRDPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FOURTHPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
End Class
