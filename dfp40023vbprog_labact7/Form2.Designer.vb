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
        Me.lblInvest = New System.Windows.Forms.Label()
        Me.lblFunction = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtInvest = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SelectPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIRSTPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFuture = New System.Windows.Forms.Label()
        Me.txtFuture = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInvest
        '
        Me.lblInvest.AutoSize = True
        Me.lblInvest.Location = New System.Drawing.Point(37, 84)
        Me.lblInvest.Name = "lblInvest"
        Me.lblInvest.Size = New System.Drawing.Size(166, 17)
        Me.lblInvest.TabIndex = 0
        Me.lblInvest.Text = "Investment amount (RM) "
        '
        'lblFunction
        '
        Me.lblFunction.AutoSize = True
        Me.lblFunction.Location = New System.Drawing.Point(37, 47)
        Me.lblFunction.Name = "lblFunction"
        Me.lblFunction.Size = New System.Drawing.Size(413, 17)
        Me.lblFunction.TabIndex = 1
        Me.lblFunction.Text = "(Future value = investment amount * (1 + interest rate ) ^ years )"
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Location = New System.Drawing.Point(37, 121)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(84, 17)
        Me.lblInterest.TabIndex = 3
        Me.lblInterest.Text = "Interest rate"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(37, 158)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(45, 17)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "Years"
        '
        'txtInvest
        '
        Me.txtInvest.Location = New System.Drawing.Point(232, 81)
        Me.txtInvest.Name = "txtInvest"
        Me.txtInvest.Size = New System.Drawing.Size(159, 22)
        Me.txtInvest.TabIndex = 5
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(232, 121)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(159, 22)
        Me.txtInterest.TabIndex = 6
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(232, 161)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(159, 22)
        Me.txtYear.TabIndex = 7
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(469, 120)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(82, 55)
        Me.btnCal.TabIndex = 8
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(566, 121)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(82, 55)
        Me.btnClr.TabIndex = 9
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(663, 121)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 55)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectPageToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 28)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SelectPageToolStripMenuItem
        '
        Me.SelectPageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIRSTPAGEToolStripMenuItem})
        Me.SelectPageToolStripMenuItem.Name = "SelectPageToolStripMenuItem"
        Me.SelectPageToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.SelectPageToolStripMenuItem.Text = "Select Page"
        '
        'FIRSTPAGEToolStripMenuItem
        '
        Me.FIRSTPAGEToolStripMenuItem.Name = "FIRSTPAGEToolStripMenuItem"
        Me.FIRSTPAGEToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.FIRSTPAGEToolStripMenuItem.Text = "FIRST PAGE"
        '
        'lblFuture
        '
        Me.lblFuture.AutoSize = True
        Me.lblFuture.Location = New System.Drawing.Point(37, 195)
        Me.lblFuture.Name = "lblFuture"
        Me.lblFuture.Size = New System.Drawing.Size(87, 17)
        Me.lblFuture.TabIndex = 21
        Me.lblFuture.Text = "Future value"
        '
        'txtFuture
        '
        Me.txtFuture.Location = New System.Drawing.Point(232, 201)
        Me.txtFuture.Name = "txtFuture"
        Me.txtFuture.Size = New System.Drawing.Size(100, 22)
        Me.txtFuture.TabIndex = 22
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(782, 253)
        Me.Controls.Add(Me.txtFuture)
        Me.Controls.Add(Me.lblFuture)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtInvest)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblInterest)
        Me.Controls.Add(Me.lblFunction)
        Me.Controls.Add(Me.lblInvest)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInvest As Label
    Friend WithEvents lblFunction As Label
    Friend WithEvents lblInterest As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents txtInvest As TextBox
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnCal As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SelectPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIRSTPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblFuture As Label
    Friend WithEvents txtFuture As TextBox
End Class
