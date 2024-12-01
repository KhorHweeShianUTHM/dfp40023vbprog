<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lstSifirBox = New System.Windows.Forms.ListBox()
        Me.btnKlikSifir = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSifirBox
        '
        Me.lstSifirBox.FormattingEnabled = True
        Me.lstSifirBox.IntegralHeight = False
        Me.lstSifirBox.ItemHeight = 16
        Me.lstSifirBox.Location = New System.Drawing.Point(283, 26)
        Me.lstSifirBox.Name = "lstSifirBox"
        Me.lstSifirBox.Size = New System.Drawing.Size(234, 196)
        Me.lstSifirBox.TabIndex = 23
        '
        'btnKlikSifir
        '
        Me.btnKlikSifir.Location = New System.Drawing.Point(283, 248)
        Me.btnKlikSifir.Name = "btnKlikSifir"
        Me.btnKlikSifir.Size = New System.Drawing.Size(234, 70)
        Me.btnKlikSifir.TabIndex = 22
        Me.btnKlikSifir.Text = "CLICK ME"
        Me.btnKlikSifir.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(12, 137)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 70)
        Me.btnPrevious.TabIndex = 21
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(713, 137)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 70)
        Me.btnNext.TabIndex = 20
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 345)
        Me.Controls.Add(Me.lstSifirBox)
        Me.Controls.Add(Me.btnKlikSifir)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "Form4"
        Me.Text = "ACTIVITY 10.4: DO WHILE - LOOP"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstSifirBox As ListBox
    Friend WithEvents btnKlikSifir As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
