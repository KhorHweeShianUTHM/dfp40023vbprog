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
        Me.mnuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNextPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMainPage = New System.Windows.Forms.Label()
        Me.lblIntro1 = New System.Windows.Forms.Label()
        Me.mnuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip1
        '
        Me.mnuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip1.Name = "mnuStrip1"
        Me.mnuStrip1.Size = New System.Drawing.Size(782, 30)
        Me.mnuStrip1.TabIndex = 0
        Me.mnuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuNextPage, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(49, 24)
        Me.mnuFile.Text = "&FILE"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(224, 26)
        Me.mnuAbout.Text = "&ABOUT"
        '
        'mnuNextPage
        '
        Me.mnuNextPage.Name = "mnuNextPage"
        Me.mnuNextPage.Size = New System.Drawing.Size(224, 26)
        Me.mnuNextPage.Text = "NEXT PAGE"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(224, 26)
        Me.mnuExit.Text = "EXIT"
        '
        'lblMainPage
        '
        Me.lblMainPage.AutoSize = True
        Me.lblMainPage.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainPage.Location = New System.Drawing.Point(276, 54)
        Me.lblMainPage.Name = "lblMainPage"
        Me.lblMainPage.Size = New System.Drawing.Size(249, 40)
        Me.lblMainPage.TabIndex = 1
        Me.lblMainPage.Text = "This is Main Page"
        '
        'lblIntro1
        '
        Me.lblIntro1.AutoSize = True
        Me.lblIntro1.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro1.Location = New System.Drawing.Point(222, 138)
        Me.lblIntro1.Name = "lblIntro1"
        Me.lblIntro1.Size = New System.Drawing.Size(356, 60)
        Me.lblIntro1.TabIndex = 2
        Me.lblIntro1.Text = "Hello ! My Name is Khor Hwee Shian. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I am POLIMAS IT Student. "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 453)
        Me.Controls.Add(Me.lblIntro1)
        Me.Controls.Add(Me.lblMainPage)
        Me.Controls.Add(Me.mnuStrip1)
        Me.MainMenuStrip = Me.mnuStrip1
        Me.Name = "Form1"
        Me.Text = "Main Page"
        Me.mnuStrip1.ResumeLayout(False)
        Me.mnuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuNextPage As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblMainPage As Label
    Friend WithEvents lblIntro1 As Label
End Class
