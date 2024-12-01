<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.mnu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFirstPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSecondPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuThirdPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFourthPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(184, 80)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(506, 153)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(634, 536)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(205, 69)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(51, 299)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(743, 150)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = resources.GetString("lblWelcome.Text")
        '
        'mnu1
        '
        Me.mnu1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnu1.Location = New System.Drawing.Point(0, 0)
        Me.mnu1.Name = "mnu1"
        Me.mnu1.Size = New System.Drawing.Size(882, 28)
        Me.mnu1.TabIndex = 3
        Me.mnu1.Text = "mnu1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.mnuSelectPage, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(168, 26)
        Me.mnuOpen.Text = "&Open"
        '
        'mnuSelectPage
        '
        Me.mnuSelectPage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFirstPage, Me.mnuSecondPage, Me.mnuThirdPage, Me.mnuFourthPage})
        Me.mnuSelectPage.Name = "mnuSelectPage"
        Me.mnuSelectPage.Size = New System.Drawing.Size(168, 26)
        Me.mnuSelectPage.Text = "Select Page"
        '
        'mnuFirstPage
        '
        Me.mnuFirstPage.Name = "mnuFirstPage"
        Me.mnuFirstPage.Size = New System.Drawing.Size(177, 26)
        Me.mnuFirstPage.Text = "First Page"
        '
        'mnuSecondPage
        '
        Me.mnuSecondPage.Name = "mnuSecondPage"
        Me.mnuSecondPage.Size = New System.Drawing.Size(177, 26)
        Me.mnuSecondPage.Text = "Second Page"
        '
        'mnuThirdPage
        '
        Me.mnuThirdPage.Name = "mnuThirdPage"
        Me.mnuThirdPage.Size = New System.Drawing.Size(177, 26)
        Me.mnuThirdPage.Text = "Third Page"
        '
        'mnuFourthPage
        '
        Me.mnuFourthPage.Name = "mnuFourthPage"
        Me.mnuFourthPage.Size = New System.Drawing.Size(177, 26)
        Me.mnuFourthPage.Text = "Fourth Page"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(168, 26)
        Me.mnuExit.Text = "E&xit"
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 653)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.mnu1)
        Me.MainMenuStrip = Me.mnu1
        Me.Name = "frm1"
        Me.Text = "TEDBOY Bakery Shop"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu1.ResumeLayout(False)
        Me.mnu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents mnu1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSelectPage As ToolStripMenuItem
    Friend WithEvents mnuFirstPage As ToolStripMenuItem
    Friend WithEvents mnuSecondPage As ToolStripMenuItem
    Friend WithEvents mnuThirdPage As ToolStripMenuItem
    Friend WithEvents mnuFourthPage As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
