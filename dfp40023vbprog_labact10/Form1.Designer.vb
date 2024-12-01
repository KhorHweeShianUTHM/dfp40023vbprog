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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(713, 137)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 70)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 16
        Me.lstBox.Location = New System.Drawing.Point(283, 26)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(234, 196)
        Me.lstBox.TabIndex = 13
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(283, 248)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(234, 70)
        Me.btnClick.TabIndex = 12
        Me.btnClick.Text = "CLICK ME"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 345)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "Form1"
        Me.Text = "ACTIVITY 10.1: FOR - NEXT"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnClick As Button
End Class
