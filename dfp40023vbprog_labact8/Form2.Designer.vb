﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CultureDateEcho = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ACTIVITY 8.2: ToString METHODS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Date"
        '
        'CultureDateEcho
        '
        Me.CultureDateEcho.AutoSize = True
        Me.CultureDateEcho.Location = New System.Drawing.Point(234, 63)
        Me.CultureDateEcho.Name = "CultureDateEcho"
        Me.CultureDateEcho.Size = New System.Drawing.Size(0, 17)
        Me.CultureDateEcho.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(171, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 50)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "NEXT ACTIVITY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 182)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CultureDateEcho)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form2"
        Me.Text = "Lab Activity 8 (KhorF1118)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CultureDateEcho As Label
    Friend WithEvents Button2 As Button
End Class