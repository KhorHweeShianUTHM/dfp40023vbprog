<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.mnu2 = New System.Windows.Forms.MenuStrip()
        Me.mnuSelect = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackcolor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuForecolor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblIntro2 = New System.Windows.Forms.Label()
        Me.lblIntro4 = New System.Windows.Forms.Label()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mnu2.SuspendLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu2
        '
        Me.mnu2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSelect})
        Me.mnu2.Location = New System.Drawing.Point(0, 0)
        Me.mnu2.Name = "mnu2"
        Me.mnu2.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.mnu2.Size = New System.Drawing.Size(980, 28)
        Me.mnu2.TabIndex = 4
        Me.mnu2.Text = "mnu2"
        '
        'mnuSelect
        '
        Me.mnuSelect.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTitle, Me.mnuFont, Me.mnuBackcolor, Me.mnuForecolor, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.mnuSelect.Name = "mnuSelect"
        Me.mnuSelect.Size = New System.Drawing.Size(63, 24)
        Me.mnuSelect.Text = "&Select"
        '
        'mnuTitle
        '
        Me.mnuTitle.Name = "mnuTitle"
        Me.mnuTitle.Size = New System.Drawing.Size(201, 26)
        Me.mnuTitle.Text = "&Back to Title"
        '
        'mnuFont
        '
        Me.mnuFont.Name = "mnuFont"
        Me.mnuFont.Size = New System.Drawing.Size(201, 26)
        Me.mnuFont.Text = "Select Font"
        '
        'mnuBackcolor
        '
        Me.mnuBackcolor.Name = "mnuBackcolor"
        Me.mnuBackcolor.Size = New System.Drawing.Size(201, 26)
        Me.mnuBackcolor.Text = "Select Backcolor"
        '
        'mnuForecolor
        '
        Me.mnuForecolor.Name = "mnuForecolor"
        Me.mnuForecolor.Size = New System.Drawing.Size(201, 26)
        Me.mnuForecolor.Text = "Select Forecolor"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(198, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(201, 26)
        Me.mnuExit.Text = "E&xit"
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.BackColor = System.Drawing.Color.Orange
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.ForeColor = System.Drawing.Color.White
        Me.lblAbout.Location = New System.Drawing.Point(356, 46)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(249, 51)
        Me.lblAbout.TabIndex = 9
        Me.lblAbout.Text = "ABOUT US"
        '
        'lblIntro2
        '
        Me.lblIntro2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro2.Location = New System.Drawing.Point(6, 37)
        Me.lblIntro2.Name = "lblIntro2"
        Me.lblIntro2.Size = New System.Drawing.Size(376, 122)
        Me.lblIntro2.TabIndex = 12
        Me.lblIntro2.Text = "We are Tedboy. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "We are determine, highly passionate group of foodies and bakers," &
    " who just loves not just good but great baked breads. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblIntro4
        '
        Me.lblIntro4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro4.Location = New System.Drawing.Point(6, 37)
        Me.lblIntro4.Name = "lblIntro4"
        Me.lblIntro4.Size = New System.Drawing.Size(376, 193)
        Me.lblIntro4.TabIndex = 15
        Me.lblIntro4.Text = resources.GetString("lblIntro4.Text")
        '
        'pic2
        '
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(429, 305)
        Me.pic2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(367, 233)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 16
        Me.pic2.TabStop = False
        '
        'pic3
        '
        Me.pic3.Image = CType(resources.GetObject("pic3.Image"), System.Drawing.Image)
        Me.pic3.Location = New System.Drawing.Point(684, 368)
        Me.pic3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(259, 206)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 17
        Me.pic3.TabStop = False
        '
        'pic1
        '
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(17, 110)
        Me.pic1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(548, 178)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 18
        Me.pic1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblIntro2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(571, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 162)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Who We Are"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblIntro4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 233)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "What We Stand For"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(980, 597)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.mnu2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.Text = "TEDBOY Bakery Shop"
        Me.mnu2.ResumeLayout(False)
        Me.mnu2.PerformLayout()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu2 As MenuStrip
    Friend WithEvents mnuSelect As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblIntro2 As Label
    Friend WithEvents lblIntro4 As Label
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents mnuFont As ToolStripMenuItem
    Friend WithEvents mnuBackcolor As ToolStripMenuItem
    Friend WithEvents mnuForecolor As ToolStripMenuItem
    Friend WithEvents mnuTitle As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
