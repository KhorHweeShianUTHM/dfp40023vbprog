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
        Me.lblFirstPage = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirstPage
        '
        Me.lblFirstPage.AutoSize = True
        Me.lblFirstPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstPage.Location = New System.Drawing.Point(176, 44)
        Me.lblFirstPage.Name = "lblFirstPage"
        Me.lblFirstPage.Size = New System.Drawing.Size(162, 25)
        Me.lblFirstPage.TabIndex = 0
        Me.lblFirstPage.Text = "This is First Page"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(204, 95)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(107, 46)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(515, 177)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblFirstPage)
        Me.Name = "Form1"
        Me.Text = "First Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstPage As Label
    Friend WithEvents btnNext As Button
End Class
