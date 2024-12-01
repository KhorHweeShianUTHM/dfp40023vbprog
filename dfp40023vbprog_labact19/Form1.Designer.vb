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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.btnEmail = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(112, 31)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(225, 23)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "REGISTRATION FORM"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(26, 84)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(67, 22)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "NAME"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(26, 137)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(75, 22)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "PHONE"
        '
        'btnEmail
        '
        Me.btnEmail.AutoSize = True
        Me.btnEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmail.Location = New System.Drawing.Point(26, 190)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(70, 22)
        Me.btnEmail.TabIndex = 3
        Me.btnEmail.Text = "EMAIL"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(26, 243)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(114, 22)
        Me.lblPass.TabIndex = 4
        Me.lblPass.Text = "PASSWORD"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(166, 84)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(254, 30)
        Me.txtName.TabIndex = 5
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(166, 135)
        Me.txtPhone.MaxLength = 10
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(254, 30)
        Me.txtPhone.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(166, 186)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(254, 30)
        Me.txtEmail.TabIndex = 7
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(166, 237)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(254, 30)
        Me.txtPass.TabIndex = 8
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(110, 320)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(229, 40)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 400)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents btnEmail As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnRegister As Button
End Class
