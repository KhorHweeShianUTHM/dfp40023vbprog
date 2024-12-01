<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm2))
        Me.mnu2 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFirstPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSecondPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuThirdPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFourthPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.picBun = New System.Windows.Forms.PictureBox()
        Me.picCake = New System.Windows.Forms.PictureBox()
        Me.btnBun = New System.Windows.Forms.Button()
        Me.btnCake = New System.Windows.Forms.Button()
        Me.lblCategories = New System.Windows.Forms.Label()
        Me.mnu2.SuspendLayout()
        CType(Me.picBun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCake, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnu2
        '
        Me.mnu2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnu2.Location = New System.Drawing.Point(0, 0)
        Me.mnu2.Name = "mnu2"
        Me.mnu2.Size = New System.Drawing.Size(882, 28)
        Me.mnu2.TabIndex = 4
        Me.mnu2.Text = "mnu2"
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
        Me.mnuOpen.Size = New System.Drawing.Size(224, 26)
        Me.mnuOpen.Text = "&Open"
        '
        'mnuSelectPage
        '
        Me.mnuSelectPage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFirstPage, Me.mnuSecondPage, Me.mnuThirdPage, Me.mnuFourthPage})
        Me.mnuSelectPage.Name = "mnuSelectPage"
        Me.mnuSelectPage.Size = New System.Drawing.Size(224, 26)
        Me.mnuSelectPage.Text = "Select Page"
        '
        'mnuFirstPage
        '
        Me.mnuFirstPage.Name = "mnuFirstPage"
        Me.mnuFirstPage.Size = New System.Drawing.Size(224, 26)
        Me.mnuFirstPage.Text = "First Page"
        '
        'mnuSecondPage
        '
        Me.mnuSecondPage.Name = "mnuSecondPage"
        Me.mnuSecondPage.Size = New System.Drawing.Size(224, 26)
        Me.mnuSecondPage.Text = "Second Page"
        '
        'mnuThirdPage
        '
        Me.mnuThirdPage.Name = "mnuThirdPage"
        Me.mnuThirdPage.Size = New System.Drawing.Size(224, 26)
        Me.mnuThirdPage.Text = "Third Page"
        '
        'mnuFourthPage
        '
        Me.mnuFourthPage.Name = "mnuFourthPage"
        Me.mnuFourthPage.Size = New System.Drawing.Size(224, 26)
        Me.mnuFourthPage.Text = "Fourth Page"
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
        Me.mnuExit.Text = "E&xit"
        '
        'picBun
        '
        Me.picBun.Image = CType(resources.GetObject("picBun.Image"), System.Drawing.Image)
        Me.picBun.Location = New System.Drawing.Point(47, 148)
        Me.picBun.Name = "picBun"
        Me.picBun.Size = New System.Drawing.Size(340, 323)
        Me.picBun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBun.TabIndex = 5
        Me.picBun.TabStop = False
        '
        'picCake
        '
        Me.picCake.Image = CType(resources.GetObject("picCake.Image"), System.Drawing.Image)
        Me.picCake.Location = New System.Drawing.Point(492, 148)
        Me.picCake.Name = "picCake"
        Me.picCake.Size = New System.Drawing.Size(343, 323)
        Me.picCake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCake.TabIndex = 6
        Me.picCake.TabStop = False
        '
        'btnBun
        '
        Me.btnBun.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBun.ForeColor = System.Drawing.Color.White
        Me.btnBun.Location = New System.Drawing.Point(126, 503)
        Me.btnBun.Name = "btnBun"
        Me.btnBun.Size = New System.Drawing.Size(184, 66)
        Me.btnBun.TabIndex = 7
        Me.btnBun.Text = "BUNS"
        Me.btnBun.UseVisualStyleBackColor = False
        '
        'btnCake
        '
        Me.btnCake.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCake.ForeColor = System.Drawing.Color.White
        Me.btnCake.Location = New System.Drawing.Point(574, 503)
        Me.btnCake.Name = "btnCake"
        Me.btnCake.Size = New System.Drawing.Size(184, 66)
        Me.btnCake.TabIndex = 8
        Me.btnCake.Text = "WHOLE CAKES"
        Me.btnCake.UseVisualStyleBackColor = False
        '
        'lblCategories
        '
        Me.lblCategories.AutoSize = True
        Me.lblCategories.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategories.Location = New System.Drawing.Point(349, 86)
        Me.lblCategories.Name = "lblCategories"
        Me.lblCategories.Size = New System.Drawing.Size(175, 38)
        Me.lblCategories.TabIndex = 9
        Me.lblCategories.Text = "Categories"
        '
        'frm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 653)
        Me.Controls.Add(Me.lblCategories)
        Me.Controls.Add(Me.btnCake)
        Me.Controls.Add(Me.btnBun)
        Me.Controls.Add(Me.picCake)
        Me.Controls.Add(Me.picBun)
        Me.Controls.Add(Me.mnu2)
        Me.Name = "frm2"
        Me.Text = "TEDBOY Bakery Shop"
        Me.mnu2.ResumeLayout(False)
        Me.mnu2.PerformLayout()
        CType(Me.picBun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCake, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu2 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSelectPage As ToolStripMenuItem
    Friend WithEvents mnuFirstPage As ToolStripMenuItem
    Friend WithEvents mnuSecondPage As ToolStripMenuItem
    Friend WithEvents mnuThirdPage As ToolStripMenuItem
    Friend WithEvents mnuFourthPage As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents picBun As PictureBox
    Friend WithEvents picCake As PictureBox
    Friend WithEvents btnBun As Button
    Friend WithEvents btnCake As Button
    Friend WithEvents lblCategories As Label
End Class
