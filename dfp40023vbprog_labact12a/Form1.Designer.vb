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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(523, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SQUARE ROOT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(271, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(236, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(523, 109)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(236, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "POWER"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(523, 187)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(236, 41)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "TEMPERATURE CONVERTER"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ACTIVITY 12.1: INVOKED SQRT METHOD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ACTIVITY 12.2: INVOKED POW METHOD"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(28, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(412, 46)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ACTIVITY 12.3: TEMPERATURE CONVERTER USING PRIVATE PROCEDURES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "lab12"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
