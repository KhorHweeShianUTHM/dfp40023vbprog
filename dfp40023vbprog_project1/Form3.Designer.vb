<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm3
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
        Me.mnu3 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectForeColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFirstPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSecondPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuThirdPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFourthPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBunInfo = New System.Windows.Forms.Label()
        Me.lblBunCal = New System.Windows.Forms.Label()
        Me.lblBunName = New System.Windows.Forms.Label()
        Me.lblBunFlavor = New System.Windows.Forms.Label()
        Me.lblBunDescription = New System.Windows.Forms.Label()
        Me.txtBunName = New System.Windows.Forms.TextBox()
        Me.txtBunFlavor = New System.Windows.Forms.TextBox()
        Me.btnBunDescription = New System.Windows.Forms.Button()
        Me.lblBunNum1 = New System.Windows.Forms.Label()
        Me.lblBunNum2 = New System.Windows.Forms.Label()
        Me.lblBunResult = New System.Windows.Forms.Label()
        Me.txtBunNum1 = New System.Windows.Forms.TextBox()
        Me.txtBunNum2 = New System.Windows.Forms.TextBox()
        Me.txtBunResult = New System.Windows.Forms.TextBox()
        Me.btnBunAdd = New System.Windows.Forms.Button()
        Me.btnBunSub = New System.Windows.Forms.Button()
        Me.btnBunMulti = New System.Windows.Forms.Button()
        Me.btnBunDiv = New System.Windows.Forms.Button()
        Me.btnBunReset = New System.Windows.Forms.Button()
        Me.btnBunExit = New System.Windows.Forms.Button()
        Me.mnu3.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnu3
        '
        Me.mnu3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnu3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnu3.Location = New System.Drawing.Point(0, 0)
        Me.mnu3.Name = "mnu3"
        Me.mnu3.Size = New System.Drawing.Size(882, 28)
        Me.mnu3.TabIndex = 5
        Me.mnu3.Text = "mnu3"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.mnuSelectFont, Me.mnuSelectForeColor, Me.mnuSelectPage, Me.ToolStripMenuItem1, Me.mnuExit})
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
        'mnuSelectFont
        '
        Me.mnuSelectFont.Name = "mnuSelectFont"
        Me.mnuSelectFont.Size = New System.Drawing.Size(224, 26)
        Me.mnuSelectFont.Text = "Select Font"
        '
        'mnuSelectForeColor
        '
        Me.mnuSelectForeColor.Name = "mnuSelectForeColor"
        Me.mnuSelectForeColor.Size = New System.Drawing.Size(224, 26)
        Me.mnuSelectForeColor.Text = "Select ForeColor"
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
        'lblBunInfo
        '
        Me.lblBunInfo.AutoSize = True
        Me.lblBunInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblBunInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBunInfo.Location = New System.Drawing.Point(22, 56)
        Me.lblBunInfo.Name = "lblBunInfo"
        Me.lblBunInfo.Size = New System.Drawing.Size(262, 38)
        Me.lblBunInfo.TabIndex = 10
        Me.lblBunInfo.Text = "Buns Information"
        '
        'lblBunCal
        '
        Me.lblBunCal.AutoSize = True
        Me.lblBunCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblBunCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBunCal.Location = New System.Drawing.Point(22, 334)
        Me.lblBunCal.Name = "lblBunCal"
        Me.lblBunCal.Size = New System.Drawing.Size(316, 38)
        Me.lblBunCal.TabIndex = 11
        Me.lblBunCal.Text = "Buns Mini Calculator"
        '
        'lblBunName
        '
        Me.lblBunName.AutoSize = True
        Me.lblBunName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBunName.Location = New System.Drawing.Point(26, 122)
        Me.lblBunName.Name = "lblBunName"
        Me.lblBunName.Size = New System.Drawing.Size(64, 25)
        Me.lblBunName.TabIndex = 12
        Me.lblBunName.Text = "Name"
        '
        'lblBunFlavor
        '
        Me.lblBunFlavor.AutoSize = True
        Me.lblBunFlavor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBunFlavor.Location = New System.Drawing.Point(26, 176)
        Me.lblBunFlavor.Name = "lblBunFlavor"
        Me.lblBunFlavor.Size = New System.Drawing.Size(66, 25)
        Me.lblBunFlavor.TabIndex = 13
        Me.lblBunFlavor.Text = "Flavor"
        '
        'lblBunDescription
        '
        Me.lblBunDescription.AutoSize = True
        Me.lblBunDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBunDescription.Location = New System.Drawing.Point(24, 243)
        Me.lblBunDescription.Name = "lblBunDescription"
        Me.lblBunDescription.Size = New System.Drawing.Size(109, 25)
        Me.lblBunDescription.TabIndex = 14
        Me.lblBunDescription.Text = "Description"
        '
        'txtBunName
        '
        Me.txtBunName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBunName.Location = New System.Drawing.Point(173, 119)
        Me.txtBunName.Name = "txtBunName"
        Me.txtBunName.Size = New System.Drawing.Size(383, 30)
        Me.txtBunName.TabIndex = 15
        '
        'txtBunFlavor
        '
        Me.txtBunFlavor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBunFlavor.Location = New System.Drawing.Point(173, 173)
        Me.txtBunFlavor.Name = "txtBunFlavor"
        Me.txtBunFlavor.Size = New System.Drawing.Size(383, 30)
        Me.txtBunFlavor.TabIndex = 16
        '
        'btnBunDescription
        '
        Me.btnBunDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBunDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBunDescription.ForeColor = System.Drawing.Color.White
        Me.btnBunDescription.Location = New System.Drawing.Point(173, 231)
        Me.btnBunDescription.Name = "btnBunDescription"
        Me.btnBunDescription.Size = New System.Drawing.Size(136, 48)
        Me.btnBunDescription.TabIndex = 17
        Me.btnBunDescription.Text = "Click here"
        Me.btnBunDescription.UseVisualStyleBackColor = False
        '
        'lblBunNum1
        '
        Me.lblBunNum1.AutoSize = True
        Me.lblBunNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBunNum1.Location = New System.Drawing.Point(29, 405)
        Me.lblBunNum1.Name = "lblBunNum1"
        Me.lblBunNum1.Size = New System.Drawing.Size(63, 25)
        Me.lblBunNum1.TabIndex = 18
        Me.lblBunNum1.Text = "Bun 1"
        '
        'lblBunNum2
        '
        Me.lblBunNum2.AutoSize = True
        Me.lblBunNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBunNum2.Location = New System.Drawing.Point(29, 445)
        Me.lblBunNum2.Name = "lblBunNum2"
        Me.lblBunNum2.Size = New System.Drawing.Size(63, 25)
        Me.lblBunNum2.TabIndex = 19
        Me.lblBunNum2.Text = "Bun 2"
        '
        'lblBunResult
        '
        Me.lblBunResult.AutoSize = True
        Me.lblBunResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBunResult.Location = New System.Drawing.Point(29, 511)
        Me.lblBunResult.Name = "lblBunResult"
        Me.lblBunResult.Size = New System.Drawing.Size(66, 25)
        Me.lblBunResult.TabIndex = 20
        Me.lblBunResult.Text = "Result"
        '
        'txtBunNum1
        '
        Me.txtBunNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBunNum1.Location = New System.Drawing.Point(173, 402)
        Me.txtBunNum1.Name = "txtBunNum1"
        Me.txtBunNum1.Size = New System.Drawing.Size(214, 30)
        Me.txtBunNum1.TabIndex = 21
        '
        'txtBunNum2
        '
        Me.txtBunNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBunNum2.Location = New System.Drawing.Point(173, 442)
        Me.txtBunNum2.Name = "txtBunNum2"
        Me.txtBunNum2.Size = New System.Drawing.Size(214, 30)
        Me.txtBunNum2.TabIndex = 22
        '
        'txtBunResult
        '
        Me.txtBunResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBunResult.Location = New System.Drawing.Point(173, 508)
        Me.txtBunResult.Name = "txtBunResult"
        Me.txtBunResult.Size = New System.Drawing.Size(165, 30)
        Me.txtBunResult.TabIndex = 23
        '
        'btnBunAdd
        '
        Me.btnBunAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBunAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBunAdd.ForeColor = System.Drawing.Color.White
        Me.btnBunAdd.Location = New System.Drawing.Point(467, 405)
        Me.btnBunAdd.Name = "btnBunAdd"
        Me.btnBunAdd.Size = New System.Drawing.Size(89, 74)
        Me.btnBunAdd.TabIndex = 24
        Me.btnBunAdd.Text = "+"
        Me.btnBunAdd.UseVisualStyleBackColor = False
        '
        'btnBunSub
        '
        Me.btnBunSub.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBunSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBunSub.ForeColor = System.Drawing.Color.White
        Me.btnBunSub.Location = New System.Drawing.Point(562, 405)
        Me.btnBunSub.Name = "btnBunSub"
        Me.btnBunSub.Size = New System.Drawing.Size(89, 74)
        Me.btnBunSub.TabIndex = 25
        Me.btnBunSub.Text = "-"
        Me.btnBunSub.UseVisualStyleBackColor = False
        '
        'btnBunMulti
        '
        Me.btnBunMulti.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBunMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBunMulti.ForeColor = System.Drawing.Color.White
        Me.btnBunMulti.Location = New System.Drawing.Point(657, 405)
        Me.btnBunMulti.Name = "btnBunMulti"
        Me.btnBunMulti.Size = New System.Drawing.Size(89, 74)
        Me.btnBunMulti.TabIndex = 26
        Me.btnBunMulti.Text = "×"
        Me.btnBunMulti.UseVisualStyleBackColor = False
        '
        'btnBunDiv
        '
        Me.btnBunDiv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBunDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBunDiv.ForeColor = System.Drawing.Color.White
        Me.btnBunDiv.Location = New System.Drawing.Point(752, 405)
        Me.btnBunDiv.Name = "btnBunDiv"
        Me.btnBunDiv.Size = New System.Drawing.Size(89, 74)
        Me.btnBunDiv.TabIndex = 27
        Me.btnBunDiv.Text = "÷"
        Me.btnBunDiv.UseVisualStyleBackColor = False
        '
        'btnBunReset
        '
        Me.btnBunReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBunReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBunReset.ForeColor = System.Drawing.Color.White
        Me.btnBunReset.Location = New System.Drawing.Point(467, 485)
        Me.btnBunReset.Name = "btnBunReset"
        Me.btnBunReset.Size = New System.Drawing.Size(184, 74)
        Me.btnBunReset.TabIndex = 28
        Me.btnBunReset.Text = "Reset"
        Me.btnBunReset.UseVisualStyleBackColor = False
        '
        'btnBunExit
        '
        Me.btnBunExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBunExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBunExit.ForeColor = System.Drawing.Color.White
        Me.btnBunExit.Location = New System.Drawing.Point(657, 485)
        Me.btnBunExit.Name = "btnBunExit"
        Me.btnBunExit.Size = New System.Drawing.Size(184, 74)
        Me.btnBunExit.TabIndex = 29
        Me.btnBunExit.Text = "Exit"
        Me.btnBunExit.UseVisualStyleBackColor = False
        '
        'frm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 653)
        Me.Controls.Add(Me.btnBunExit)
        Me.Controls.Add(Me.btnBunReset)
        Me.Controls.Add(Me.btnBunDiv)
        Me.Controls.Add(Me.btnBunMulti)
        Me.Controls.Add(Me.btnBunSub)
        Me.Controls.Add(Me.btnBunAdd)
        Me.Controls.Add(Me.txtBunResult)
        Me.Controls.Add(Me.txtBunNum2)
        Me.Controls.Add(Me.txtBunNum1)
        Me.Controls.Add(Me.lblBunResult)
        Me.Controls.Add(Me.lblBunNum2)
        Me.Controls.Add(Me.lblBunNum1)
        Me.Controls.Add(Me.btnBunDescription)
        Me.Controls.Add(Me.txtBunFlavor)
        Me.Controls.Add(Me.txtBunName)
        Me.Controls.Add(Me.lblBunDescription)
        Me.Controls.Add(Me.lblBunFlavor)
        Me.Controls.Add(Me.lblBunName)
        Me.Controls.Add(Me.lblBunCal)
        Me.Controls.Add(Me.lblBunInfo)
        Me.Controls.Add(Me.mnu3)
        Me.Name = "frm3"
        Me.Text = "TEDBOY Bakery Shop"
        Me.mnu3.ResumeLayout(False)
        Me.mnu3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu3 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSelectPage As ToolStripMenuItem
    Friend WithEvents mnuFirstPage As ToolStripMenuItem
    Friend WithEvents mnuSecondPage As ToolStripMenuItem
    Friend WithEvents mnuThirdPage As ToolStripMenuItem
    Friend WithEvents mnuFourthPage As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblBunInfo As Label
    Friend WithEvents lblBunCal As Label
    Friend WithEvents lblBunName As Label
    Friend WithEvents lblBunFlavor As Label
    Friend WithEvents lblBunDescription As Label
    Friend WithEvents txtBunName As TextBox
    Friend WithEvents txtBunFlavor As TextBox
    Friend WithEvents btnBunDescription As Button
    Friend WithEvents lblBunNum1 As Label
    Friend WithEvents lblBunNum2 As Label
    Friend WithEvents lblBunResult As Label
    Friend WithEvents txtBunNum1 As TextBox
    Friend WithEvents txtBunNum2 As TextBox
    Friend WithEvents txtBunResult As TextBox
    Friend WithEvents btnBunAdd As Button
    Friend WithEvents btnBunSub As Button
    Friend WithEvents btnBunMulti As Button
    Friend WithEvents btnBunDiv As Button
    Friend WithEvents btnBunReset As Button
    Friend WithEvents btnBunExit As Button
    Friend WithEvents mnuSelectFont As ToolStripMenuItem
    Friend WithEvents mnuSelectForeColor As ToolStripMenuItem
End Class
