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
        Me.lbNum1 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMuiltiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbNum1
        '
        Me.lbNum1.AutoSize = True
        Me.lbNum1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbNum1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbNum1.Location = New System.Drawing.Point(53, 36)
        Me.lbNum1.Name = "lbNum1"
        Me.lbNum1.Size = New System.Drawing.Size(83, 24)
        Me.lbNum1.TabIndex = 0
        Me.lbNum1.Text = "Number 1"
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNum1.Location = New System.Drawing.Point(142, 33)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(125, 30)
        Me.txtNum1.TabIndex = 1
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNum2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNum2.Location = New System.Drawing.Point(53, 79)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(83, 24)
        Me.lblNum2.TabIndex = 2
        Me.lblNum2.Text = "Number 2"
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNum2.Location = New System.Drawing.Point(142, 76)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(125, 30)
        Me.txtNum2.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblResult.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblResult.Location = New System.Drawing.Point(53, 143)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(56, 24)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Result"
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtResult.Location = New System.Drawing.Point(142, 140)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(125, 30)
        Me.txtResult.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(361, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 67)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubtract.Location = New System.Drawing.Point(451, 32)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(84, 66)
        Me.btnSubtract.TabIndex = 7
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMuiltiply
        '
        Me.btnMuiltiply.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMuiltiply.Location = New System.Drawing.Point(541, 32)
        Me.btnMuiltiply.Name = "btnMuiltiply"
        Me.btnMuiltiply.Size = New System.Drawing.Size(84, 66)
        Me.btnMuiltiply.TabIndex = 8
        Me.btnMuiltiply.Text = "×"
        Me.btnMuiltiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDivide.Location = New System.Drawing.Point(631, 33)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(84, 66)
        Me.btnDivide.TabIndex = 9
        Me.btnDivide.Text = "÷"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(451, 104)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 66)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(541, 104)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 66)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(748, 206)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMuiltiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lbNum1)
        Me.Name = "Form1"
        Me.Text = "Mini Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNum1 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents lblNum2 As Label
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMuiltiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
