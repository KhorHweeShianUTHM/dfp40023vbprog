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
        Me.txtAlamat1 = New System.Windows.Forms.TextBox()
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
        Me.txtAlamat2 = New System.Windows.Forms.TextBox()
        Me.txtPoskod = New System.Windows.Forms.TextBox()
        Me.lblPoskod = New System.Windows.Forms.Label()
        Me.cmbKaum = New System.Windows.Forms.ComboBox()
        Me.lblKaum = New System.Windows.Forms.Label()
        Me.cmbJantina = New System.Windows.Forms.ComboBox()
        Me.lblJantina = New System.Windows.Forms.Label()
        Me.cmbDaerah = New System.Windows.Forms.ComboBox()
        Me.lblDaerah = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.lblUmur = New System.Windows.Forms.Label()
        Me.txtBandar = New System.Windows.Forms.TextBox()
        Me.lblBandar = New System.Windows.Forms.Label()
        Me.txtTelefon = New System.Windows.Forms.TextBox()
        Me.lblTelefon = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Yellow
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.Blue
        Me.btnDisplay.Location = New System.Drawing.Point(49, 512)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(969, 62)
        Me.btnDisplay.TabIndex = 31
        Me.btnDisplay.Text = "DISPLAY INFORMATION"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'txtAlamat1
        '
        Me.txtAlamat1.Location = New System.Drawing.Point(557, 141)
        Me.txtAlamat1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat1.Name = "txtAlamat1"
        Me.txtAlamat1.Size = New System.Drawing.Size(433, 22)
        Me.txtAlamat1.TabIndex = 22
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(557, 122)
        Me.lblAlamat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(63, 17)
        Me.lblAlamat.TabIndex = 21
        Me.lblAlamat.Text = "ALAMAT"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(64, 141)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(409, 22)
        Me.txtNama.TabIndex = 19
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(64, 122)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "NAMA "
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(68, 51)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
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
        'txtAlamat2
        '
        Me.txtAlamat2.Location = New System.Drawing.Point(557, 171)
        Me.txtAlamat2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlamat2.Name = "txtAlamat2"
        Me.txtAlamat2.Size = New System.Drawing.Size(433, 22)
        Me.txtAlamat2.TabIndex = 33
        '
        'txtPoskod
        '
        Me.txtPoskod.Location = New System.Drawing.Point(557, 236)
        Me.txtPoskod.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPoskod.Name = "txtPoskod"
        Me.txtPoskod.Size = New System.Drawing.Size(436, 22)
        Me.txtPoskod.TabIndex = 35
        '
        'lblPoskod
        '
        Me.lblPoskod.AutoSize = True
        Me.lblPoskod.Location = New System.Drawing.Point(557, 215)
        Me.lblPoskod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoskod.Name = "lblPoskod"
        Me.lblPoskod.Size = New System.Drawing.Size(67, 17)
        Me.lblPoskod.TabIndex = 34
        Me.lblPoskod.Text = "POSKOD"
        '
        'cmbKaum
        '
        Me.cmbKaum.FormattingEnabled = True
        Me.cmbKaum.Items.AddRange(New Object() {"MALAY", "CINA", "INDIA"})
        Me.cmbKaum.Location = New System.Drawing.Point(64, 450)
        Me.cmbKaum.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbKaum.Name = "cmbKaum"
        Me.cmbKaum.Size = New System.Drawing.Size(412, 24)
        Me.cmbKaum.TabIndex = 37
        '
        'lblKaum
        '
        Me.lblKaum.AutoSize = True
        Me.lblKaum.Location = New System.Drawing.Point(64, 430)
        Me.lblKaum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKaum.Name = "lblKaum"
        Me.lblKaum.Size = New System.Drawing.Size(47, 17)
        Me.lblKaum.TabIndex = 36
        Me.lblKaum.Text = "KAUM"
        '
        'cmbJantina
        '
        Me.cmbJantina.FormattingEnabled = True
        Me.cmbJantina.Items.AddRange(New Object() {"LELAKI", "PEREMPUAN"})
        Me.cmbJantina.Location = New System.Drawing.Point(64, 303)
        Me.cmbJantina.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbJantina.Name = "cmbJantina"
        Me.cmbJantina.Size = New System.Drawing.Size(409, 24)
        Me.cmbJantina.TabIndex = 39
        '
        'lblJantina
        '
        Me.lblJantina.AutoSize = True
        Me.lblJantina.Location = New System.Drawing.Point(64, 283)
        Me.lblJantina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJantina.Name = "lblJantina"
        Me.lblJantina.Size = New System.Drawing.Size(65, 17)
        Me.lblJantina.TabIndex = 38
        Me.lblJantina.Text = "JANTINA"
        '
        'cmbDaerah
        '
        Me.cmbDaerah.FormattingEnabled = True
        Me.cmbDaerah.Location = New System.Drawing.Point(557, 383)
        Me.cmbDaerah.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDaerah.Name = "cmbDaerah"
        Me.cmbDaerah.Size = New System.Drawing.Size(436, 24)
        Me.cmbDaerah.TabIndex = 41
        '
        'lblDaerah
        '
        Me.lblDaerah.AutoSize = True
        Me.lblDaerah.Location = New System.Drawing.Point(557, 362)
        Me.lblDaerah.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDaerah.Name = "lblDaerah"
        Me.lblDaerah.Size = New System.Drawing.Size(65, 17)
        Me.lblDaerah.TabIndex = 40
        Me.lblDaerah.Text = "DAERAH"
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Location = New System.Drawing.Point(64, 215)
        Me.lblIC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(127, 17)
        Me.lblIC.TabIndex = 42
        Me.lblIC.Text = "NO PENGENALAN"
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(64, 236)
        Me.txtIC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(406, 22)
        Me.txtIC.TabIndex = 43
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(64, 383)
        Me.txtUmur.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(409, 22)
        Me.txtUmur.TabIndex = 45
        '
        'lblUmur
        '
        Me.lblUmur.AutoSize = True
        Me.lblUmur.Location = New System.Drawing.Point(64, 362)
        Me.lblUmur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUmur.Name = "lblUmur"
        Me.lblUmur.Size = New System.Drawing.Size(49, 17)
        Me.lblUmur.TabIndex = 44
        Me.lblUmur.Text = "UMUR"
        '
        'txtBandar
        '
        Me.txtBandar.Location = New System.Drawing.Point(557, 305)
        Me.txtBandar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBandar.Name = "txtBandar"
        Me.txtBandar.Size = New System.Drawing.Size(436, 22)
        Me.txtBandar.TabIndex = 47
        '
        'lblBandar
        '
        Me.lblBandar.AutoSize = True
        Me.lblBandar.Location = New System.Drawing.Point(557, 283)
        Me.lblBandar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBandar.Name = "lblBandar"
        Me.lblBandar.Size = New System.Drawing.Size(65, 17)
        Me.lblBandar.TabIndex = 46
        Me.lblBandar.Text = "BANDAR"
        '
        'txtTelefon
        '
        Me.txtTelefon.Location = New System.Drawing.Point(557, 451)
        Me.txtTelefon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefon.Name = "txtTelefon"
        Me.txtTelefon.Size = New System.Drawing.Size(436, 22)
        Me.txtTelefon.TabIndex = 49
        '
        'lblTelefon
        '
        Me.lblTelefon.AutoSize = True
        Me.lblTelefon.Location = New System.Drawing.Point(557, 430)
        Me.lblTelefon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefon.Name = "lblTelefon"
        Me.lblTelefon.Size = New System.Drawing.Size(97, 17)
        Me.lblTelefon.TabIndex = 48
        Me.lblTelefon.Text = "NO TELEFON"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 582)
        Me.Controls.Add(Me.txtTelefon)
        Me.Controls.Add(Me.lblTelefon)
        Me.Controls.Add(Me.txtBandar)
        Me.Controls.Add(Me.lblBandar)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.lblUmur)
        Me.Controls.Add(Me.txtIC)
        Me.Controls.Add(Me.lblIC)
        Me.Controls.Add(Me.cmbDaerah)
        Me.Controls.Add(Me.lblDaerah)
        Me.Controls.Add(Me.cmbJantina)
        Me.Controls.Add(Me.lblJantina)
        Me.Controls.Add(Me.cmbKaum)
        Me.Controls.Add(Me.lblKaum)
        Me.Controls.Add(Me.txtPoskod)
        Me.Controls.Add(Me.lblPoskod)
        Me.Controls.Add(Me.txtAlamat2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtAlamat1)
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
    Friend WithEvents txtAlamat1 As TextBox
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
    Friend WithEvents txtAlamat2 As TextBox
    Friend WithEvents txtPoskod As TextBox
    Friend WithEvents lblPoskod As Label
    Friend WithEvents cmbKaum As ComboBox
    Friend WithEvents lblKaum As Label
    Friend WithEvents cmbJantina As ComboBox
    Friend WithEvents lblJantina As Label
    Friend WithEvents cmbDaerah As ComboBox
    Friend WithEvents lblDaerah As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents txtIC As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents lblUmur As Label
    Friend WithEvents txtBandar As TextBox
    Friend WithEvents lblBandar As Label
    Friend WithEvents txtTelefon As TextBox
    Friend WithEvents lblTelefon As Label
End Class
