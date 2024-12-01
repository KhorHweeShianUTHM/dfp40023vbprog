<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPage2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPage2))
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.lstDisplayName = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.Gold
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.Blue
        Me.btnInsert.Location = New System.Drawing.Point(34, 52)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(178, 50)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.Text = "Insert Name"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'lstDisplayName
        '
        Me.lstDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplayName.ForeColor = System.Drawing.Color.Blue
        Me.lstDisplayName.FormattingEnabled = True
        Me.lstDisplayName.ItemHeight = 20
        Me.lstDisplayName.Location = New System.Drawing.Point(273, 52)
        Me.lstDisplayName.Name = "lstDisplayName"
        Me.lstDisplayName.Size = New System.Drawing.Size(341, 304)
        Me.lstDisplayName.TabIndex = 1
        '
        'frmPage2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(643, 389)
        Me.Controls.Add(Me.lstDisplayName)
        Me.Controls.Add(Me.btnInsert)
        Me.Name = "frmPage2"
        Me.Text = "Page 2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInsert As Button
    Friend WithEvents lstDisplayName As ListBox
End Class
