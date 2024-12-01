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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECTFONTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SELECTFONTCOLORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FRISTPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.cmbJantina = New System.Windows.Forms.ComboBox()
        Me.lblJantina = New System.Windows.Forms.Label()
        Me.cmbDaerah = New System.Windows.Forms.ComboBox()
        Me.lblDaerah = New System.Windows.Forms.Label()
        Me.txtBandar = New System.Windows.Forms.TextBox()
        Me.lblBandar = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblEmailFormat = New System.Windows.Forms.Label()
        Me.btnEmailFormat = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Yellow
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.Blue
        Me.btnDisplay.Location = New System.Drawing.Point(21, 404)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(510, 62)
        Me.btnDisplay.TabIndex = 31
        Me.btnDisplay.Text = "DISPLAY INFORMATION"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(128, 223)
        Me.txtAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(381, 22)
        Me.txtAlamat.TabIndex = 22
        Me.txtAlamat.Tag = "_Alamat"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamat.Location = New System.Drawing.Point(17, 227)
        Me.lblAlamat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(81, 20)
        Me.lblAlamat.TabIndex = 21
        Me.lblAlamat.Text = "ALAMAT:"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(128, 108)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(381, 27)
        Me.txtNama.TabIndex = 19
        Me.txtNama.Tag = "_Nama"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(17, 111)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(67, 20)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "NAMA: "
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(87, 51)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(931, 31)
        Me.lblWelcome.TabIndex = 17
        Me.lblWelcome.Text = "REGISTRATION INFORMATION FOR STUDENT SMK SUNGAI LALANG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1105, 28)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SELECTFONTToolStripMenuItem, Me.SELECTFONTCOLORToolStripMenuItem, Me.SelectToolStripMenuItem, Me.ToolStripMenuItem1, Me.EXITToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.FileToolStripMenuItem.Text = "FILE"
        '
        'SELECTFONTToolStripMenuItem
        '
        Me.SELECTFONTToolStripMenuItem.Name = "SELECTFONTToolStripMenuItem"
        Me.SELECTFONTToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.SELECTFONTToolStripMenuItem.Text = "SELECT FONT"
        '
        'SELECTFONTCOLORToolStripMenuItem
        '
        Me.SELECTFONTCOLORToolStripMenuItem.Name = "SELECTFONTCOLORToolStripMenuItem"
        Me.SELECTFONTCOLORToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.SELECTFONTCOLORToolStripMenuItem.Text = "SELECT FONTCOLOR"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FRISTPAGEToolStripMenuItem})
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.SelectToolStripMenuItem.Text = "SELECT PAGE"
        '
        'FRISTPAGEToolStripMenuItem
        '
        Me.FRISTPAGEToolStripMenuItem.Name = "FRISTPAGEToolStripMenuItem"
        Me.FRISTPAGEToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.FRISTPAGEToolStripMenuItem.Text = "FIRST PAGE"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(223, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'cmbJantina
        '
        Me.cmbJantina.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJantina.FormattingEnabled = True
        Me.cmbJantina.Items.AddRange(New Object() {"Lelaki", "Perempuan"})
        Me.cmbJantina.Location = New System.Drawing.Point(128, 165)
        Me.cmbJantina.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbJantina.Name = "cmbJantina"
        Me.cmbJantina.Size = New System.Drawing.Size(218, 28)
        Me.cmbJantina.TabIndex = 39
        Me.cmbJantina.Tag = "_Jantina"
        '
        'lblJantina
        '
        Me.lblJantina.AutoSize = True
        Me.lblJantina.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJantina.Location = New System.Drawing.Point(17, 169)
        Me.lblJantina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJantina.Name = "lblJantina"
        Me.lblJantina.Size = New System.Drawing.Size(83, 20)
        Me.lblJantina.TabIndex = 38
        Me.lblJantina.Text = "JANTINA:"
        '
        'cmbDaerah
        '
        Me.cmbDaerah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDaerah.FormattingEnabled = True
        Me.cmbDaerah.Location = New System.Drawing.Point(128, 337)
        Me.cmbDaerah.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDaerah.Name = "cmbDaerah"
        Me.cmbDaerah.Size = New System.Drawing.Size(307, 28)
        Me.cmbDaerah.TabIndex = 41
        Me.cmbDaerah.Tag = "_Daerah"
        '
        'lblDaerah
        '
        Me.lblDaerah.AutoSize = True
        Me.lblDaerah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaerah.Location = New System.Drawing.Point(17, 343)
        Me.lblDaerah.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDaerah.Name = "lblDaerah"
        Me.lblDaerah.Size = New System.Drawing.Size(85, 20)
        Me.lblDaerah.TabIndex = 40
        Me.lblDaerah.Text = "DAERAH:"
        '
        'txtBandar
        '
        Me.txtBandar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBandar.Location = New System.Drawing.Point(128, 280)
        Me.txtBandar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBandar.Name = "txtBandar"
        Me.txtBandar.Size = New System.Drawing.Size(307, 27)
        Me.txtBandar.TabIndex = 47
        Me.txtBandar.Tag = "_Bandar"
        '
        'lblBandar
        '
        Me.lblBandar.AutoSize = True
        Me.lblBandar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBandar.Location = New System.Drawing.Point(17, 285)
        Me.lblBandar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBandar.Name = "lblBandar"
        Me.lblBandar.Size = New System.Drawing.Size(85, 20)
        Me.lblBandar.TabIndex = 46
        Me.lblBandar.Text = "BANDAR:"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Yellow
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.ForeColor = System.Drawing.Color.Blue
        Me.btnPrevious.Location = New System.Drawing.Point(663, 270)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(162, 46)
        Me.btnPrevious.TabIndex = 49
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Yellow
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Blue
        Me.btnNext.Location = New System.Drawing.Point(833, 271)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(162, 46)
        Me.btnNext.TabIndex = 50
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Yellow
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Blue
        Me.btnAdd.Location = New System.Drawing.Point(663, 325)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(162, 46)
        Me.btnAdd.TabIndex = 53
        Me.btnAdd.Text = "ADD RECORD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Blue
        Me.btnClear.Location = New System.Drawing.Point(833, 325)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(162, 46)
        Me.btnClear.TabIndex = 54
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(743, 112)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(335, 27)
        Me.txtEmail.TabIndex = 56
        Me.txtEmail.Tag = "_Email"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(537, 115)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(64, 20)
        Me.lblEmail.TabIndex = 55
        Me.lblEmail.Text = "EMAIL:"
        '
        'lblEmailFormat
        '
        Me.lblEmailFormat.AutoSize = True
        Me.lblEmailFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailFormat.Location = New System.Drawing.Point(537, 186)
        Me.lblEmailFormat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmailFormat.Name = "lblEmailFormat"
        Me.lblEmailFormat.Size = New System.Drawing.Size(272, 20)
        Me.lblEmailFormat.TabIndex = 57
        Me.lblEmailFormat.Text = "EMAIL FORMAT: VALID/INVALID?"
        '
        'btnEmailFormat
        '
        Me.btnEmailFormat.BackColor = System.Drawing.Color.Yellow
        Me.btnEmailFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmailFormat.ForeColor = System.Drawing.Color.Blue
        Me.btnEmailFormat.Location = New System.Drawing.Point(841, 177)
        Me.btnEmailFormat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEmailFormat.Name = "btnEmailFormat"
        Me.btnEmailFormat.Size = New System.Drawing.Size(237, 37)
        Me.btnEmailFormat.TabIndex = 58
        Me.btnEmailFormat.Text = "Validate"
        Me.btnEmailFormat.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Yellow
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Blue
        Me.btnReset.Location = New System.Drawing.Point(555, 404)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(523, 62)
        Me.btnReset.TabIndex = 59
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1105, 488)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEmailFormat)
        Me.Controls.Add(Me.lblEmailFormat)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtBandar)
        Me.Controls.Add(Me.lblBandar)
        Me.Controls.Add(Me.cmbDaerah)
        Me.Controls.Add(Me.lblDaerah)
        Me.Controls.Add(Me.cmbJantina)
        Me.Controls.Add(Me.lblJantina)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblWelcome)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form2"
        Me.Text = "SMK AMAN JAYA "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SELECTFONTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SELECTFONTCOLORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FRISTPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents cmbJantina As ComboBox
    Friend WithEvents lblJantina As Label
    Friend WithEvents cmbDaerah As ComboBox
    Friend WithEvents lblDaerah As Label
    Friend WithEvents txtBandar As TextBox
    Friend WithEvents lblBandar As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblEmailFormat As Label
    Friend WithEvents btnEmailFormat As Button
    Friend WithEvents btnReset As Button
End Class
