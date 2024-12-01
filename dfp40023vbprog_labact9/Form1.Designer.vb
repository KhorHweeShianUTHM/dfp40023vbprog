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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SECONDPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.THIRDPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIRSTPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOURTHPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MINI CALCULATOR"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(49, 78)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(87, 17)
        Me.lblFirst.TabIndex = 1
        Me.lblFirst.Text = "First number"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(49, 116)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(108, 17)
        Me.lblSecond.TabIndex = 2
        Me.lblSecond.Text = "Second number"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(49, 153)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(48, 17)
        Me.lblResult.TabIndex = 3
        Me.lblResult.Text = "Result"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(180, 78)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(123, 22)
        Me.txtFirst.TabIndex = 4
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(180, 113)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(123, 22)
        Me.txtSecond.TabIndex = 5
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(203, 153)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 22)
        Me.txtResult.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(28, 210)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(57, 49)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(110, 210)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(57, 49)
        Me.btnSubtract.TabIndex = 8
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Location = New System.Drawing.Point(190, 210)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(57, 49)
        Me.btnTimes.TabIndex = 9
        Me.btnTimes.Text = "*"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(270, 210)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(57, 49)
        Me.btnDivide.TabIndex = 10
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PAGEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(362, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PAGEToolStripMenuItem
        '
        Me.PAGEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIRSTPAGEToolStripMenuItem, Me.SECONDPAGEToolStripMenuItem, Me.THIRDPAGEToolStripMenuItem, Me.FOURTHPAGEToolStripMenuItem, Me.ToolStripMenuItem1, Me.EXITToolStripMenuItem})
        Me.PAGEToolStripMenuItem.Name = "PAGEToolStripMenuItem"
        Me.PAGEToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.PAGEToolStripMenuItem.Text = "PAGE"
        '
        'SECONDPAGEToolStripMenuItem
        '
        Me.SECONDPAGEToolStripMenuItem.Name = "SECONDPAGEToolStripMenuItem"
        Me.SECONDPAGEToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SECONDPAGEToolStripMenuItem.Text = "SECOND PAGE"
        '
        'THIRDPAGEToolStripMenuItem
        '
        Me.THIRDPAGEToolStripMenuItem.Name = "THIRDPAGEToolStripMenuItem"
        Me.THIRDPAGEToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.THIRDPAGEToolStripMenuItem.Text = "THIRD PAGE"
        '
        'FIRSTPAGEToolStripMenuItem
        '
        Me.FIRSTPAGEToolStripMenuItem.Name = "FIRSTPAGEToolStripMenuItem"
        Me.FIRSTPAGEToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FIRSTPAGEToolStripMenuItem.Text = "FIRST PAGE"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 277)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "ACTIVITY 9.1: CONTROL STRUCTURE (If SELECTION)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnTimes As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SECONDPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents THIRDPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIRSTPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FOURTHPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
End Class
