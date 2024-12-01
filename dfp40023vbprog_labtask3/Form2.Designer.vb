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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.lblCalculate = New System.Windows.Forms.Label()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBase
        '
        Me.txtBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBase.Location = New System.Drawing.Point(126, 193)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(193, 27)
        Me.txtBase.TabIndex = 14
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(24, 190)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(48, 20)
        Me.lblBase.TabIndex = 12
        Me.lblBase.Text = "Base"
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(126, 122)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(193, 27)
        Me.txtHeight.TabIndex = 11
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(24, 125)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(58, 20)
        Me.lblHeight.TabIndex = 10
        Me.lblHeight.Text = "Height"
        '
        'btnCal
        '
        Me.btnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCal.Location = New System.Drawing.Point(105, 335)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(138, 52)
        Me.btnCal.TabIndex = 9
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'lblCalculate
        '
        Me.lblCalculate.AutoSize = True
        Me.lblCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculate.Location = New System.Drawing.Point(177, 45)
        Me.lblCalculate.Name = "lblCalculate"
        Me.lblCalculate.Size = New System.Drawing.Size(447, 38)
        Me.lblCalculate.TabIndex = 8
        Me.lblCalculate.Text = "Calculate the Area of Triangle"
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAns.Location = New System.Drawing.Point(121, 264)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(0, 20)
        Me.lblAns.TabIndex = 15
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(24, 255)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(65, 20)
        Me.lblAnswer.TabIndex = 16
        Me.lblAnswer.Text = "Answer"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(342, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(446, 334)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblCalculate)
        Me.Name = "Form2"
        Me.Text = "Area of Triangle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBase As TextBox
    Friend WithEvents lblBase As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents lblCalculate As Label
    Friend WithEvents lblAns As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
