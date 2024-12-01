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
        Me.btnArrayElement = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnArrayElement
        '
        Me.btnArrayElement.Location = New System.Drawing.Point(229, 116)
        Me.btnArrayElement.Name = "btnArrayElement"
        Me.btnArrayElement.Size = New System.Drawing.Size(208, 58)
        Me.btnArrayElement.TabIndex = 0
        Me.btnArrayElement.Text = "Array Element"
        Me.btnArrayElement.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(579, 249)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 30)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 291)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnArrayElement)
        Me.Name = "Form1"
        Me.Text = "ACTIVITY 11.1:"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnArrayElement As Button
    Friend WithEvents btnNext As Button
End Class
