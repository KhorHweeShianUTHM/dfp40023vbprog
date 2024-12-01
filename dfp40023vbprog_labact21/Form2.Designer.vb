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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNoMatric = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblEmailFormat = New System.Windows.Forms.Label()
        Me.txtNoMatric = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIRSTPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Information"
        '
        'lblNoMatric
        '
        Me.lblNoMatric.AutoSize = True
        Me.lblNoMatric.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoMatric.Location = New System.Drawing.Point(12, 130)
        Me.lblNoMatric.Name = "lblNoMatric"
        Me.lblNoMatric.Size = New System.Drawing.Size(120, 20)
        Me.lblNoMatric.TabIndex = 1
        Me.lblNoMatric.Tag = ""
        Me.lblNoMatric.Text = "Matric Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(12, 199)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(51, 20)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Tag = ""
        Me.lblEmail.Text = "Email"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 268)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(12, 337)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(38, 20)
        Me.lblAge.TabIndex = 4
        Me.lblAge.Tag = ""
        Me.lblAge.Text = "Age"
        '
        'lblEmailFormat
        '
        Me.lblEmailFormat.AutoSize = True
        Me.lblEmailFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailFormat.Location = New System.Drawing.Point(386, 130)
        Me.lblEmailFormat.Name = "lblEmailFormat"
        Me.lblEmailFormat.Size = New System.Drawing.Size(217, 20)
        Me.lblEmailFormat.TabIndex = 5
        Me.lblEmailFormat.Text = "Email Format: Valid/Invalid?"
        '
        'txtNoMatric
        '
        Me.txtNoMatric.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoMatric.Location = New System.Drawing.Point(172, 127)
        Me.txtNoMatric.Name = "txtNoMatric"
        Me.txtNoMatric.Size = New System.Drawing.Size(188, 27)
        Me.txtNoMatric.TabIndex = 6
        Me.txtNoMatric.Tag = "_Matric No"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(172, 196)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(188, 27)
        Me.txtEmail.TabIndex = 7
        Me.txtEmail.Tag = "_Email"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(172, 265)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(188, 27)
        Me.txtName.TabIndex = 8
        Me.txtName.Tag = "_Name"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(172, 334)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 27)
        Me.txtAge.TabIndex = 9
        Me.txtAge.Tag = "_Age"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(621, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 40)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Validate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(390, 199)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(398, 77)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(390, 309)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(398, 77)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PAGEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PAGEToolStripMenuItem
        '
        Me.PAGEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIRSTPAGEToolStripMenuItem})
        Me.PAGEToolStripMenuItem.Name = "PAGEToolStripMenuItem"
        Me.PAGEToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.PAGEToolStripMenuItem.Text = "PAGE"
        '
        'FIRSTPAGEToolStripMenuItem
        '
        Me.FIRSTPAGEToolStripMenuItem.Name = "FIRSTPAGEToolStripMenuItem"
        Me.FIRSTPAGEToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.FIRSTPAGEToolStripMenuItem.Text = "FIRST PAGE"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNoMatric)
        Me.Controls.Add(Me.lblEmailFormat)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblNoMatric)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblNoMatric As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblEmailFormat As Label
    Friend WithEvents txtNoMatric As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FIRSTPAGEToolStripMenuItem As ToolStripMenuItem
End Class
