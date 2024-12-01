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
        Me.mnuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNextPage = New System.Windows.Forms.Label()
        Me.lblIntro2 = New System.Windows.Forms.Label()
        Me.mnuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip2
        '
        Me.mnuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip2.Name = "mnuStrip2"
        Me.mnuStrip2.Size = New System.Drawing.Size(782, 30)
        Me.mnuStrip2.TabIndex = 0
        Me.mnuStrip2.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainPage})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(49, 24)
        Me.mnuFile.Text = "&FILE"
        '
        'mnuMainPage
        '
        Me.mnuMainPage.Name = "mnuMainPage"
        Me.mnuMainPage.Size = New System.Drawing.Size(224, 26)
        Me.mnuMainPage.Text = "MAIN PAGE"
        '
        'lblNextPage
        '
        Me.lblNextPage.AutoSize = True
        Me.lblNextPage.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextPage.Location = New System.Drawing.Point(278, 72)
        Me.lblNextPage.Name = "lblNextPage"
        Me.lblNextPage.Size = New System.Drawing.Size(245, 40)
        Me.lblNextPage.TabIndex = 1
        Me.lblNextPage.Text = "This is Next Page"
        '
        'lblIntro2
        '
        Me.lblIntro2.AutoSize = True
        Me.lblIntro2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro2.Location = New System.Drawing.Point(181, 156)
        Me.lblIntro2.Name = "lblIntro2"
        Me.lblIntro2.Size = New System.Drawing.Size(439, 58)
        Me.lblIntro2.TabIndex = 2
        Me.lblIntro2.Text = "I am learn Visual Basic Programming." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I am doing the LabTask 2."
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 453)
        Me.Controls.Add(Me.lblIntro2)
        Me.Controls.Add(Me.lblNextPage)
        Me.Controls.Add(Me.mnuStrip2)
        Me.MainMenuStrip = Me.mnuStrip2
        Me.Name = "Form2"
        Me.Text = "Next Page"
        Me.mnuStrip2.ResumeLayout(False)
        Me.mnuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip2 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuMainPage As ToolStripMenuItem
    Friend WithEvents lblNextPage As Label
    Friend WithEvents lblIntro2 As Label
End Class
