<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentValidationData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentValidationData))
        Me.lblNoMatric = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblEmailFormat = New System.Windows.Forms.Label()
        Me.txtNoMatric = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnEmailFormat = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNoMatric
        '
        Me.lblNoMatric.AutoSize = True
        Me.lblNoMatric.BackColor = System.Drawing.Color.Yellow
        Me.lblNoMatric.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoMatric.ForeColor = System.Drawing.Color.Blue
        Me.lblNoMatric.Location = New System.Drawing.Point(29, 165)
        Me.lblNoMatric.Name = "lblNoMatric"
        Me.lblNoMatric.Size = New System.Drawing.Size(120, 20)
        Me.lblNoMatric.TabIndex = 0
        Me.lblNoMatric.Text = "Matric Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Yellow
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Blue
        Me.lblEmail.Location = New System.Drawing.Point(29, 218)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(51, 20)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Yellow
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Blue
        Me.lblName.Location = New System.Drawing.Point(29, 271)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Yellow
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Blue
        Me.lblAge.Location = New System.Drawing.Point(29, 324)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(38, 20)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age"
        '
        'lblEmailFormat
        '
        Me.lblEmailFormat.AutoSize = True
        Me.lblEmailFormat.BackColor = System.Drawing.Color.Yellow
        Me.lblEmailFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailFormat.ForeColor = System.Drawing.Color.Blue
        Me.lblEmailFormat.Location = New System.Drawing.Point(29, 381)
        Me.lblEmailFormat.Name = "lblEmailFormat"
        Me.lblEmailFormat.Size = New System.Drawing.Size(217, 20)
        Me.lblEmailFormat.TabIndex = 4
        Me.lblEmailFormat.Text = "Email Format: Valid/Invalid?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNoMatric
        '
        Me.txtNoMatric.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoMatric.Location = New System.Drawing.Point(232, 158)
        Me.txtNoMatric.Name = "txtNoMatric"
        Me.txtNoMatric.Size = New System.Drawing.Size(308, 27)
        Me.txtNoMatric.TabIndex = 5
        Me.txtNoMatric.Tag = "_NoMatric"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(232, 211)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(308, 27)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.Tag = "_Email"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(232, 264)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(308, 27)
        Me.txtName.TabIndex = 7
        Me.txtName.Tag = "_Name"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(232, 317)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(308, 27)
        Me.txtAge.TabIndex = 8
        Me.txtAge.Tag = "_Age"
        '
        'btnEmailFormat
        '
        Me.btnEmailFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmailFormat.Location = New System.Drawing.Point(316, 368)
        Me.btnEmailFormat.Name = "btnEmailFormat"
        Me.btnEmailFormat.Size = New System.Drawing.Size(224, 38)
        Me.btnEmailFormat.TabIndex = 9
        Me.btnEmailFormat.Text = "Validate"
        Me.btnEmailFormat.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(626, 149)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(216, 74)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(626, 246)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(216, 71)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(626, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(216, 74)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(291, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 38)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Validation Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(116, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(652, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "- DFP40023 VISUAL BASIC PRO. Labtask5 by Khor Hwee Shian -"
        '
        'frmStudentValidationData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 441)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnEmailFormat)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNoMatric)
        Me.Controls.Add(Me.lblEmailFormat)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblNoMatric)
        Me.Name = "frmStudentValidationData"
        Me.Text = "Validation Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNoMatric As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblEmailFormat As Label
    Friend WithEvents txtNoMatric As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnEmailFormat As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
