<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnForNextLoop = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.ItemHeight = 16
        Me.lstData.Location = New System.Drawing.Point(283, 26)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(234, 196)
        Me.lstData.TabIndex = 19
        '
        'btnForNextLoop
        '
        Me.btnForNextLoop.Location = New System.Drawing.Point(283, 248)
        Me.btnForNextLoop.Name = "btnForNextLoop"
        Me.btnForNextLoop.Size = New System.Drawing.Size(234, 70)
        Me.btnForNextLoop.TabIndex = 18
        Me.btnForNextLoop.Text = "ForNext Loop"
        Me.btnForNextLoop.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(12, 137)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 70)
        Me.btnPrevious.TabIndex = 17
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(713, 137)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 70)
        Me.btnNext.TabIndex = 16
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 345)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.btnForNextLoop)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "Form3"
        Me.Text = "ACTIVITY 10.3: THE FOR-NEXT LOOP"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstData As ListBox
    Friend WithEvents btnForNextLoop As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
