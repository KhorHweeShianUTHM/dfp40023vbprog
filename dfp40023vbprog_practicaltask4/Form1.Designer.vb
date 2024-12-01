<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SECONDPAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picSMK2 = New System.Windows.Forms.PictureBox()
        Me.lblTittle = New System.Windows.Forms.Label()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.picSMK1 = New System.Windows.Forms.PictureBox()
        Me.picSMK3 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picSMK2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSMK1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSMK3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(993, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem, Me.ToolStripMenuItem1, Me.EXITToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.FileToolStripMenuItem.Text = "FILE"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SECONDPAGEToolStripMenuItem})
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.SelectToolStripMenuItem.Text = "SELECT PAGE"
        '
        'SECONDPAGEToolStripMenuItem
        '
        Me.SECONDPAGEToolStripMenuItem.Name = "SECONDPAGEToolStripMenuItem"
        Me.SECONDPAGEToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.SECONDPAGEToolStripMenuItem.Text = "SECOND PAGE"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'picSMK2
        '
        Me.picSMK2.Image = CType(resources.GetObject("picSMK2.Image"), System.Drawing.Image)
        Me.picSMK2.Location = New System.Drawing.Point(12, 317)
        Me.picSMK2.Name = "picSMK2"
        Me.picSMK2.Size = New System.Drawing.Size(196, 159)
        Me.picSMK2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSMK2.TabIndex = 1
        Me.picSMK2.TabStop = False
        '
        'lblTittle
        '
        Me.lblTittle.AutoSize = True
        Me.lblTittle.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTittle.Location = New System.Drawing.Point(279, 343)
        Me.lblTittle.Name = "lblTittle"
        Me.lblTittle.Size = New System.Drawing.Size(434, 40)
        Me.lblTittle.TabIndex = 2
        Me.lblTittle.Text = "WELCOME TO SMK AMAN JAYA"
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.Yellow
        Me.btnClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.ForeColor = System.Drawing.Color.Blue
        Me.btnClick.Location = New System.Drawing.Point(374, 407)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(245, 56)
        Me.btnClick.TabIndex = 3
        Me.btnClick.Text = "CLICK ME"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'picSMK1
        '
        Me.picSMK1.Image = CType(resources.GetObject("picSMK1.Image"), System.Drawing.Image)
        Me.picSMK1.Location = New System.Drawing.Point(12, 35)
        Me.picSMK1.Name = "picSMK1"
        Me.picSMK1.Size = New System.Drawing.Size(978, 276)
        Me.picSMK1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSMK1.TabIndex = 5
        Me.picSMK1.TabStop = False
        '
        'picSMK3
        '
        Me.picSMK3.Image = CType(resources.GetObject("picSMK3.Image"), System.Drawing.Image)
        Me.picSMK3.Location = New System.Drawing.Point(760, 317)
        Me.picSMK3.Name = "picSMK3"
        Me.picSMK3.Size = New System.Drawing.Size(221, 159)
        Me.picSMK3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSMK3.TabIndex = 6
        Me.picSMK3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 488)
        Me.Controls.Add(Me.picSMK3)
        Me.Controls.Add(Me.picSMK1)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.lblTittle)
        Me.Controls.Add(Me.picSMK2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "SMK AMAN JAYA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picSMK2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSMK1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSMK3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SECONDPAGEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picSMK2 As PictureBox
    Friend WithEvents lblTittle As Label
    Friend WithEvents btnClick As Button
    Friend WithEvents picSMK1 As PictureBox
    Friend WithEvents picSMK3 As PictureBox
End Class
