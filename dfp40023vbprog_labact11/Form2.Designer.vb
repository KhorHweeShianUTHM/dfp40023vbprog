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
        Me.rbMan = New System.Windows.Forms.RadioButton()
        Me.rbDan = New System.Windows.Forms.RadioButton()
        Me.rbWan = New System.Windows.Forms.RadioButton()
        Me.rbLan = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblShow = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbMan
        '
        Me.rbMan.AutoSize = True
        Me.rbMan.Location = New System.Drawing.Point(79, 74)
        Me.rbMan.Name = "rbMan"
        Me.rbMan.Size = New System.Drawing.Size(56, 21)
        Me.rbMan.TabIndex = 0
        Me.rbMan.TabStop = True
        Me.rbMan.Text = "Man"
        Me.rbMan.UseVisualStyleBackColor = True
        '
        'rbDan
        '
        Me.rbDan.AutoSize = True
        Me.rbDan.Location = New System.Drawing.Point(79, 155)
        Me.rbDan.Name = "rbDan"
        Me.rbDan.Size = New System.Drawing.Size(55, 21)
        Me.rbDan.TabIndex = 1
        Me.rbDan.TabStop = True
        Me.rbDan.Text = "Dan"
        Me.rbDan.UseVisualStyleBackColor = True
        '
        'rbWan
        '
        Me.rbWan.AutoSize = True
        Me.rbWan.Location = New System.Drawing.Point(79, 128)
        Me.rbWan.Name = "rbWan"
        Me.rbWan.Size = New System.Drawing.Size(58, 21)
        Me.rbWan.TabIndex = 2
        Me.rbWan.TabStop = True
        Me.rbWan.Text = "Wan"
        Me.rbWan.UseVisualStyleBackColor = True
        '
        'rbLan
        '
        Me.rbLan.AutoSize = True
        Me.rbLan.Location = New System.Drawing.Point(79, 101)
        Me.rbLan.Name = "rbLan"
        Me.rbLan.Size = New System.Drawing.Size(53, 21)
        Me.rbLan.TabIndex = 3
        Me.rbLan.TabStop = True
        Me.rbLan.Text = "Lan"
        Me.rbLan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(57, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "My Friend are..."
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(330, 94)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(127, 35)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "Show Full name"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lblShow
        '
        Me.lblShow.AutoSize = True
        Me.lblShow.Location = New System.Drawing.Point(346, 155)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(0, 17)
        Me.lblShow.TabIndex = 6
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(579, 249)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 30)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 291)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblShow)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbLan)
        Me.Controls.Add(Me.rbWan)
        Me.Controls.Add(Me.rbDan)
        Me.Controls.Add(Me.rbMan)
        Me.Name = "Form2"
        Me.Text = "ACTIVITY 11.2:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbMan As RadioButton
    Friend WithEvents rbDan As RadioButton
    Friend WithEvents rbWan As RadioButton
    Friend WithEvents rbLan As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents lblShow As Label
    Friend WithEvents btnNext As Button
End Class
