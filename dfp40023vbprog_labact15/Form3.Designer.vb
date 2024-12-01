<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoly
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
        Me.lblSum = New System.Windows.Forms.Label()
        Me.btnOutput = New System.Windows.Forms.Button()
        Me.lblQues = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIRSTPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SECONDPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.THIRDPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(264, 104)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(0, 17)
        Me.lblSum.TabIndex = 9
        '
        'btnOutput
        '
        Me.btnOutput.Location = New System.Drawing.Point(102, 309)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(235, 28)
        Me.btnOutput.TabIndex = 8
        Me.btnOutput.Text = "RESULT"
        Me.btnOutput.UseVisualStyleBackColor = True
        '
        'lblQues
        '
        Me.lblQues.AutoSize = True
        Me.lblQues.BackColor = System.Drawing.Color.Yellow
        Me.lblQues.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblQues.Location = New System.Drawing.Point(178, 87)
        Me.lblQues.Name = "lblQues"
        Me.lblQues.Size = New System.Drawing.Size(109, 17)
        Me.lblQues.TabIndex = 7
        Me.lblQues.Text = "i=10, j=20, k=30"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(167, 50)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(134, 17)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Basic Polymorphism"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PAGEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(449, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PAGEToolStripMenuItem
        '
        Me.PAGEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIRSTPAGEToolStripMenuItem, Me.SECONDPAGEToolStripMenuItem, Me.THIRDPAGEToolStripMenuItem})
        Me.PAGEToolStripMenuItem.Name = "PAGEToolStripMenuItem"
        Me.PAGEToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.PAGEToolStripMenuItem.Text = "&PAGE"
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
        'THIRDPAGEToolStripMenuItem
        '
        Me.THIRDPAGEToolStripMenuItem.Name = "THIRDPAGEToolStripMenuItem"
        Me.THIRDPAGEToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.THIRDPAGEToolStripMenuItem.Text = "THIRD PAGE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Label3"
        '
        'frmPoly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 364)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.btnOutput)
        Me.Controls.Add(Me.lblQues)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmPoly"
        Me.Text = "lab15.2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSum As Label
    Friend WithEvents btnOutput As Button
    Friend WithEvents lblQues As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIRSTPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SECONDPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents THIRDPAGEToolStripMenuItem As ToolStripMenuItem
End Class
