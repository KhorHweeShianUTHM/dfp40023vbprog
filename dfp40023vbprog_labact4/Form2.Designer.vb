<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(408, 115)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 40)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(320, 115)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(82, 40)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(408, 69)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(82, 40)
        Me.btnDiv.TabIndex = 21
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(320, 69)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(82, 40)
        Me.btnMulti.TabIndex = 20
        Me.btnMulti.Text = "*"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(408, 21)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(82, 42)
        Me.btnSub.TabIndex = 19
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(320, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 42)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(134, 117)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(101, 30)
        Me.txtResult.TabIndex = 17
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(134, 63)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(159, 30)
        Me.txtNum2.TabIndex = 16
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(134, 27)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(159, 30)
        Me.txtNum1.TabIndex = 15
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(25, 120)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(66, 25)
        Me.lblResult.TabIndex = 14
        Me.lblResult.Text = "Result"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.Location = New System.Drawing.Point(25, 63)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(103, 25)
        Me.lblNum2.TabIndex = 13
        Me.lblNum2.Text = "Number 2:"
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.Location = New System.Drawing.Point(25, 27)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(103, 25)
        Me.lblNum1.TabIndex = 12
        Me.lblNum1.Text = "Number 1:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(515, 177)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Name = "Form2"
        Me.Text = "MINI CALCULATOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblNum1 As Label
End Class
