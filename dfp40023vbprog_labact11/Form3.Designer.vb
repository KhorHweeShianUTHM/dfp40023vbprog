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
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnClickArray = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(579, 249)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 30)
        Me.btnFinish.TabIndex = 15
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(197, 79)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(283, 100)
        Me.lstDisplay.TabIndex = 16
        '
        'btnClickArray
        '
        Me.btnClickArray.Location = New System.Drawing.Point(302, 195)
        Me.btnClickArray.Name = "btnClickArray"
        Me.btnClickArray.Size = New System.Drawing.Size(75, 23)
        Me.btnClickArray.TabIndex = 17
        Me.btnClickArray.Text = "Click Me!"
        Me.btnClickArray.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 291)
        Me.Controls.Add(Me.btnClickArray)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnFinish)
        Me.Name = "Form3"
        Me.Text = "ACTIVITY 11.3:"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFinish As Button
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents btnClickArray As Button
End Class
