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
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCategories = New System.Windows.Forms.Label()
        Me.lblFlavor = New System.Windows.Forms.Label()
        Me.txtCategories = New System.Windows.Forms.TextBox()
        Me.txtFlavor = New System.Windows.Forms.TextBox()
        Me.lblCalculator = New System.Windows.Forms.Label()
        Me.lblCake1 = New System.Windows.Forms.Label()
        Me.lblCake2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtCake1 = New System.Windows.Forms.TextBox()
        Me.txtCake2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDetail
        '
        Me.lblDetail.AutoSize = True
        Me.lblDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDetail.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDetail.Location = New System.Drawing.Point(35, 27)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(145, 24)
        Me.lblDetail.TabIndex = 1
        Me.lblDetail.Text = "Customer Detail"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(153, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(574, 32)
        Me.txtName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(35, 75)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 24)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblCategories
        '
        Me.lblCategories.AutoSize = True
        Me.lblCategories.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCategories.Location = New System.Drawing.Point(35, 120)
        Me.lblCategories.Name = "lblCategories"
        Me.lblCategories.Size = New System.Drawing.Size(98, 24)
        Me.lblCategories.TabIndex = 4
        Me.lblCategories.Text = "Categories"
        '
        'lblFlavor
        '
        Me.lblFlavor.AutoSize = True
        Me.lblFlavor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFlavor.Location = New System.Drawing.Point(35, 164)
        Me.lblFlavor.Name = "lblFlavor"
        Me.lblFlavor.Size = New System.Drawing.Size(61, 24)
        Me.lblFlavor.TabIndex = 5
        Me.lblFlavor.Text = "Flavor"
        '
        'txtCategories
        '
        Me.txtCategories.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCategories.Location = New System.Drawing.Point(153, 120)
        Me.txtCategories.Name = "txtCategories"
        Me.txtCategories.Size = New System.Drawing.Size(574, 32)
        Me.txtCategories.TabIndex = 6
        '
        'txtFlavor
        '
        Me.txtFlavor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFlavor.Location = New System.Drawing.Point(153, 164)
        Me.txtFlavor.Name = "txtFlavor"
        Me.txtFlavor.Size = New System.Drawing.Size(574, 32)
        Me.txtFlavor.TabIndex = 7
        '
        'lblCalculator
        '
        Me.lblCalculator.AutoSize = True
        Me.lblCalculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCalculator.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCalculator.Location = New System.Drawing.Point(35, 231)
        Me.lblCalculator.Name = "lblCalculator"
        Me.lblCalculator.Size = New System.Drawing.Size(138, 24)
        Me.lblCalculator.TabIndex = 8
        Me.lblCalculator.Text = "Mini Calculator"
        '
        'lblCake1
        '
        Me.lblCake1.AutoSize = True
        Me.lblCake1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCake1.Location = New System.Drawing.Point(35, 288)
        Me.lblCake1.Name = "lblCake1"
        Me.lblCake1.Size = New System.Drawing.Size(59, 24)
        Me.lblCake1.TabIndex = 9
        Me.lblCake1.Text = "Cake1"
        '
        'lblCake2
        '
        Me.lblCake2.AutoSize = True
        Me.lblCake2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCake2.Location = New System.Drawing.Point(35, 328)
        Me.lblCake2.Name = "lblCake2"
        Me.lblCake2.Size = New System.Drawing.Size(59, 24)
        Me.lblCake2.TabIndex = 10
        Me.lblCake2.Text = "Cake2"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblResult.Location = New System.Drawing.Point(35, 371)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(62, 24)
        Me.lblResult.TabIndex = 11
        Me.lblResult.Text = "Result"
        '
        'txtCake1
        '
        Me.txtCake1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCake1.Location = New System.Drawing.Point(153, 285)
        Me.txtCake1.Name = "txtCake1"
        Me.txtCake1.Size = New System.Drawing.Size(272, 32)
        Me.txtCake1.TabIndex = 12
        '
        'txtCake2
        '
        Me.txtCake2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCake2.Location = New System.Drawing.Point(153, 328)
        Me.txtCake2.Name = "txtCake2"
        Me.txtCake2.Size = New System.Drawing.Size(272, 32)
        Me.txtCake2.TabIndex = 13
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtResult.Location = New System.Drawing.Point(153, 371)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(272, 32)
        Me.txtResult.TabIndex = 14
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(477, 288)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 47)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSub.Location = New System.Drawing.Point(541, 288)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(58, 47)
        Me.btnSub.TabIndex = 16
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMulti.Location = New System.Drawing.Point(605, 288)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(58, 47)
        Me.btnMulti.TabIndex = 17
        Me.btnMulti.Text = "×"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDiv.Location = New System.Drawing.Point(669, 288)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(58, 47)
        Me.btnDiv.TabIndex = 18
        Me.btnDiv.Text = "÷"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(477, 341)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(122, 47)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(605, 341)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 47)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtCake2)
        Me.Controls.Add(Me.txtCake1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblCake2)
        Me.Controls.Add(Me.lblCake1)
        Me.Controls.Add(Me.lblCalculator)
        Me.Controls.Add(Me.txtFlavor)
        Me.Controls.Add(Me.txtCategories)
        Me.Controls.Add(Me.lblFlavor)
        Me.Controls.Add(Me.lblCategories)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblDetail)
        Me.Name = "Form2"
        Me.Text = "Lavender Bakery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDetail As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblCategories As Label
    Friend WithEvents lblFlavor As Label
    Friend WithEvents txtCategories As TextBox
    Friend WithEvents txtFlavor As TextBox
    Friend WithEvents lblCalculator As Label
    Friend WithEvents lblCake1 As Label
    Friend WithEvents lblCake2 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtCake1 As TextBox
    Friend WithEvents txtCake2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
