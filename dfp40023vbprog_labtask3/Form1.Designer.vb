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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblMatricNum = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.txtMatricNum = New System.Windows.Forms.TextBox()
        Me.txtClass = New System.Windows.Forms.TextBox()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(101, 45)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(599, 38)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Area of Triangle Calculation"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(192, 378)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(138, 52)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next Page"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(24, 138)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(162, 138)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(220, 27)
        Me.txtName.TabIndex = 3
        '
        'lblMatricNum
        '
        Me.lblMatricNum.AutoSize = True
        Me.lblMatricNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricNum.Location = New System.Drawing.Point(24, 193)
        Me.lblMatricNum.Name = "lblMatricNum"
        Me.lblMatricNum.Size = New System.Drawing.Size(117, 20)
        Me.lblMatricNum.TabIndex = 4
        Me.lblMatricNum.Text = "Matric number"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(24, 242)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(98, 20)
        Me.lblClass.TabIndex = 5
        Me.lblClass.Text = "Class name"
        '
        'txtMatricNum
        '
        Me.txtMatricNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricNum.Location = New System.Drawing.Point(162, 190)
        Me.txtMatricNum.Name = "txtMatricNum"
        Me.txtMatricNum.Size = New System.Drawing.Size(165, 27)
        Me.txtMatricNum.TabIndex = 6
        '
        'txtClass
        '
        Me.txtClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClass.Location = New System.Drawing.Point(162, 242)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New System.Drawing.Size(165, 27)
        Me.txtClass.TabIndex = 7
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.BackColor = System.Drawing.Color.Yellow
        Me.lblAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns.Location = New System.Drawing.Point(402, 104)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(227, 20)
        Me.lblAns.TabIndex = 16
        Me.lblAns.Text = "Hello, I can Show Information"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(48, 378)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(138, 52)
        Me.btnShow.TabIndex = 17
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(406, 242)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(370, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.txtClass)
        Me.Controls.Add(Me.txtMatricNum)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblMatricNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "Form1"
        Me.Text = "Area of Triangle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblMatricNum As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents txtMatricNum As TextBox
    Friend WithEvents txtClass As TextBox
    Friend WithEvents lblAns As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
