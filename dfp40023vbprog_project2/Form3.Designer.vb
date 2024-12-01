<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.grbCustomer = New System.Windows.Forms.GroupBox()
        Me.txtCphone = New System.Windows.Forms.TextBox()
        Me.txtCemail = New System.Windows.Forms.TextBox()
        Me.txtCname = New System.Windows.Forms.TextBox()
        Me.lblCphone = New System.Windows.Forms.Label()
        Me.lblCemail = New System.Windows.Forms.Label()
        Me.lblCname = New System.Windows.Forms.Label()
        Me.grbProduct = New System.Windows.Forms.GroupBox()
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.txtPtotalprice = New System.Windows.Forms.TextBox()
        Me.txtPprice = New System.Windows.Forms.TextBox()
        Me.txtPquan = New System.Windows.Forms.TextBox()
        Me.lblPtotalprice = New System.Windows.Forms.Label()
        Me.lblPquan = New System.Windows.Forms.Label()
        Me.lblPprice = New System.Windows.Forms.Label()
        Me.lblPname = New System.Windows.Forms.Label()
        Me.grbMenu = New System.Windows.Forms.GroupBox()
        Me.lblS2 = New System.Windows.Forms.Label()
        Me.lblS2price = New System.Windows.Forms.Label()
        Me.lblS1price = New System.Windows.Forms.Label()
        Me.lblB2price = New System.Windows.Forms.Label()
        Me.lblB1price = New System.Windows.Forms.Label()
        Me.lblC2price = New System.Windows.Forms.Label()
        Me.lblC1price = New System.Windows.Forms.Label()
        Me.picS2 = New System.Windows.Forms.PictureBox()
        Me.picS1 = New System.Windows.Forms.PictureBox()
        Me.picB2 = New System.Windows.Forms.PictureBox()
        Me.picB1 = New System.Windows.Forms.PictureBox()
        Me.picC2 = New System.Windows.Forms.PictureBox()
        Me.picC1 = New System.Windows.Forms.PictureBox()
        Me.lblS1 = New System.Windows.Forms.Label()
        Me.lblB2 = New System.Windows.Forms.Label()
        Me.lblB1 = New System.Windows.Forms.Label()
        Me.lblC2 = New System.Windows.Forms.Label()
        Me.lblC1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.mnu2 = New System.Windows.Forms.MenuStrip()
        Me.mnuSelect = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTitle = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnView = New System.Windows.Forms.Button()
        Me.grbCustomer.SuspendLayout()
        Me.grbProduct.SuspendLayout()
        Me.grbMenu.SuspendLayout()
        CType(Me.picS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbCustomer
        '
        Me.grbCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbCustomer.Controls.Add(Me.txtCphone)
        Me.grbCustomer.Controls.Add(Me.txtCemail)
        Me.grbCustomer.Controls.Add(Me.txtCname)
        Me.grbCustomer.Controls.Add(Me.lblCphone)
        Me.grbCustomer.Controls.Add(Me.lblCemail)
        Me.grbCustomer.Controls.Add(Me.lblCname)
        Me.grbCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbCustomer.Location = New System.Drawing.Point(15, 43)
        Me.grbCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbCustomer.Name = "grbCustomer"
        Me.grbCustomer.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbCustomer.Size = New System.Drawing.Size(421, 196)
        Me.grbCustomer.TabIndex = 0
        Me.grbCustomer.TabStop = False
        Me.grbCustomer.Text = "Customer Details"
        '
        'txtCphone
        '
        Me.txtCphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCphone.Location = New System.Drawing.Point(95, 139)
        Me.txtCphone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCphone.Name = "txtCphone"
        Me.txtCphone.Size = New System.Drawing.Size(233, 27)
        Me.txtCphone.TabIndex = 5
        '
        'txtCemail
        '
        Me.txtCemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCemail.Location = New System.Drawing.Point(95, 87)
        Me.txtCemail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCemail.Name = "txtCemail"
        Me.txtCemail.Size = New System.Drawing.Size(233, 27)
        Me.txtCemail.TabIndex = 4
        '
        'txtCname
        '
        Me.txtCname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCname.Location = New System.Drawing.Point(95, 34)
        Me.txtCname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCname.Name = "txtCname"
        Me.txtCname.Size = New System.Drawing.Size(295, 27)
        Me.txtCname.TabIndex = 3
        '
        'lblCphone
        '
        Me.lblCphone.AutoSize = True
        Me.lblCphone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCphone.Location = New System.Drawing.Point(5, 146)
        Me.lblCphone.Name = "lblCphone"
        Me.lblCphone.Size = New System.Drawing.Size(56, 20)
        Me.lblCphone.TabIndex = 2
        Me.lblCphone.Text = "Phone"
        '
        'lblCemail
        '
        Me.lblCemail.AutoSize = True
        Me.lblCemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCemail.Location = New System.Drawing.Point(5, 92)
        Me.lblCemail.Name = "lblCemail"
        Me.lblCemail.Size = New System.Drawing.Size(51, 20)
        Me.lblCemail.TabIndex = 1
        Me.lblCemail.Text = "Email"
        '
        'lblCname
        '
        Me.lblCname.AutoSize = True
        Me.lblCname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCname.Location = New System.Drawing.Point(5, 38)
        Me.lblCname.Name = "lblCname"
        Me.lblCname.Size = New System.Drawing.Size(53, 20)
        Me.lblCname.TabIndex = 0
        Me.lblCname.Text = "Name"
        '
        'grbProduct
        '
        Me.grbProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbProduct.Controls.Add(Me.txtPname)
        Me.grbProduct.Controls.Add(Me.txtPtotalprice)
        Me.grbProduct.Controls.Add(Me.txtPprice)
        Me.grbProduct.Controls.Add(Me.txtPquan)
        Me.grbProduct.Controls.Add(Me.lblPtotalprice)
        Me.grbProduct.Controls.Add(Me.lblPquan)
        Me.grbProduct.Controls.Add(Me.lblPprice)
        Me.grbProduct.Controls.Add(Me.lblPname)
        Me.grbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbProduct.Location = New System.Drawing.Point(15, 251)
        Me.grbProduct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbProduct.Name = "grbProduct"
        Me.grbProduct.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbProduct.Size = New System.Drawing.Size(421, 271)
        Me.grbProduct.TabIndex = 1
        Me.grbProduct.TabStop = False
        Me.grbProduct.Text = "Product Details"
        '
        'txtPname
        '
        Me.txtPname.Location = New System.Drawing.Point(145, 37)
        Me.txtPname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.Size = New System.Drawing.Size(236, 30)
        Me.txtPname.TabIndex = 13
        '
        'txtPtotalprice
        '
        Me.txtPtotalprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtotalprice.Location = New System.Drawing.Point(145, 207)
        Me.txtPtotalprice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPtotalprice.Name = "txtPtotalprice"
        Me.txtPtotalprice.Size = New System.Drawing.Size(236, 27)
        Me.txtPtotalprice.TabIndex = 10
        '
        'txtPprice
        '
        Me.txtPprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPprice.Location = New System.Drawing.Point(145, 94)
        Me.txtPprice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPprice.Name = "txtPprice"
        Me.txtPprice.Size = New System.Drawing.Size(236, 27)
        Me.txtPprice.TabIndex = 9
        '
        'txtPquan
        '
        Me.txtPquan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPquan.Location = New System.Drawing.Point(145, 150)
        Me.txtPquan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPquan.Name = "txtPquan"
        Me.txtPquan.Size = New System.Drawing.Size(236, 27)
        Me.txtPquan.TabIndex = 8
        '
        'lblPtotalprice
        '
        Me.lblPtotalprice.AutoSize = True
        Me.lblPtotalprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtotalprice.Location = New System.Drawing.Point(11, 210)
        Me.lblPtotalprice.Name = "lblPtotalprice"
        Me.lblPtotalprice.Size = New System.Drawing.Size(90, 20)
        Me.lblPtotalprice.TabIndex = 7
        Me.lblPtotalprice.Text = "Total Price"
        '
        'lblPquan
        '
        Me.lblPquan.AutoSize = True
        Me.lblPquan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPquan.Location = New System.Drawing.Point(11, 153)
        Me.lblPquan.Name = "lblPquan"
        Me.lblPquan.Size = New System.Drawing.Size(71, 20)
        Me.lblPquan.TabIndex = 6
        Me.lblPquan.Text = "Quantity"
        '
        'lblPprice
        '
        Me.lblPprice.AutoSize = True
        Me.lblPprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPprice.Location = New System.Drawing.Point(11, 95)
        Me.lblPprice.Name = "lblPprice"
        Me.lblPprice.Size = New System.Drawing.Size(48, 20)
        Me.lblPprice.TabIndex = 5
        Me.lblPprice.Text = "Price"
        '
        'lblPname
        '
        Me.lblPname.AutoSize = True
        Me.lblPname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPname.Location = New System.Drawing.Point(11, 37)
        Me.lblPname.Name = "lblPname"
        Me.lblPname.Size = New System.Drawing.Size(53, 20)
        Me.lblPname.TabIndex = 3
        Me.lblPname.Text = "Name"
        '
        'grbMenu
        '
        Me.grbMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbMenu.Controls.Add(Me.lblS2)
        Me.grbMenu.Controls.Add(Me.lblS2price)
        Me.grbMenu.Controls.Add(Me.lblS1price)
        Me.grbMenu.Controls.Add(Me.lblB2price)
        Me.grbMenu.Controls.Add(Me.lblB1price)
        Me.grbMenu.Controls.Add(Me.lblC2price)
        Me.grbMenu.Controls.Add(Me.lblC1price)
        Me.grbMenu.Controls.Add(Me.picS2)
        Me.grbMenu.Controls.Add(Me.picS1)
        Me.grbMenu.Controls.Add(Me.picB2)
        Me.grbMenu.Controls.Add(Me.picB1)
        Me.grbMenu.Controls.Add(Me.picC2)
        Me.grbMenu.Controls.Add(Me.picC1)
        Me.grbMenu.Controls.Add(Me.lblS1)
        Me.grbMenu.Controls.Add(Me.lblB2)
        Me.grbMenu.Controls.Add(Me.lblB1)
        Me.grbMenu.Controls.Add(Me.lblC2)
        Me.grbMenu.Controls.Add(Me.lblC1)
        Me.grbMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbMenu.Location = New System.Drawing.Point(455, 43)
        Me.grbMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbMenu.Name = "grbMenu"
        Me.grbMenu.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grbMenu.Size = New System.Drawing.Size(1108, 295)
        Me.grbMenu.TabIndex = 2
        Me.grbMenu.TabStop = False
        Me.grbMenu.Text = "Menu"
        '
        'lblS2
        '
        Me.lblS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS2.Location = New System.Drawing.Point(923, 208)
        Me.lblS2.Name = "lblS2"
        Me.lblS2.Size = New System.Drawing.Size(167, 58)
        Me.lblS2.TabIndex = 26
        Me.lblS2.Text = "Grilled Chicken Sandwich"
        Me.lblS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblS2price
        '
        Me.lblS2price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS2price.Location = New System.Drawing.Point(923, 180)
        Me.lblS2price.Name = "lblS2price"
        Me.lblS2price.Size = New System.Drawing.Size(167, 21)
        Me.lblS2price.TabIndex = 25
        Me.lblS2price.Text = "RM 9"
        Me.lblS2price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblS1price
        '
        Me.lblS1price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS1price.Location = New System.Drawing.Point(740, 180)
        Me.lblS1price.Name = "lblS1price"
        Me.lblS1price.Size = New System.Drawing.Size(167, 21)
        Me.lblS1price.TabIndex = 24
        Me.lblS1price.Text = "RM 20"
        Me.lblS1price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB2price
        '
        Me.lblB2price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB2price.Location = New System.Drawing.Point(557, 180)
        Me.lblB2price.Name = "lblB2price"
        Me.lblB2price.Size = New System.Drawing.Size(167, 21)
        Me.lblB2price.TabIndex = 23
        Me.lblB2price.Text = "RM 3.50"
        Me.lblB2price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB1price
        '
        Me.lblB1price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB1price.Location = New System.Drawing.Point(375, 180)
        Me.lblB1price.Name = "lblB1price"
        Me.lblB1price.Size = New System.Drawing.Size(167, 21)
        Me.lblB1price.TabIndex = 22
        Me.lblB1price.Text = "RM 2.10"
        Me.lblB1price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC2price
        '
        Me.lblC2price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2price.Location = New System.Drawing.Point(199, 180)
        Me.lblC2price.Name = "lblC2price"
        Me.lblC2price.Size = New System.Drawing.Size(163, 21)
        Me.lblC2price.TabIndex = 21
        Me.lblC2price.Text = "RM 12"
        Me.lblC2price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC1price
        '
        Me.lblC1price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1price.Location = New System.Drawing.Point(17, 180)
        Me.lblC1price.Name = "lblC1price"
        Me.lblC1price.Size = New System.Drawing.Size(163, 21)
        Me.lblC1price.TabIndex = 20
        Me.lblC1price.Text = "RM 12"
        Me.lblC1price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picS2
        '
        Me.picS2.BackgroundImage = CType(resources.GetObject("picS2.BackgroundImage"), System.Drawing.Image)
        Me.picS2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS2.Location = New System.Drawing.Point(923, 27)
        Me.picS2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picS2.Name = "picS2"
        Me.picS2.Size = New System.Drawing.Size(167, 145)
        Me.picS2.TabIndex = 19
        Me.picS2.TabStop = False
        '
        'picS1
        '
        Me.picS1.BackgroundImage = CType(resources.GetObject("picS1.BackgroundImage"), System.Drawing.Image)
        Me.picS1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picS1.Location = New System.Drawing.Point(740, 28)
        Me.picS1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picS1.Name = "picS1"
        Me.picS1.Size = New System.Drawing.Size(167, 144)
        Me.picS1.TabIndex = 18
        Me.picS1.TabStop = False
        '
        'picB2
        '
        Me.picB2.BackgroundImage = CType(resources.GetObject("picB2.BackgroundImage"), System.Drawing.Image)
        Me.picB2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picB2.Location = New System.Drawing.Point(557, 28)
        Me.picB2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picB2.Name = "picB2"
        Me.picB2.Size = New System.Drawing.Size(167, 144)
        Me.picB2.TabIndex = 17
        Me.picB2.TabStop = False
        '
        'picB1
        '
        Me.picB1.BackgroundImage = CType(resources.GetObject("picB1.BackgroundImage"), System.Drawing.Image)
        Me.picB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picB1.Location = New System.Drawing.Point(375, 30)
        Me.picB1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picB1.Name = "picB1"
        Me.picB1.Size = New System.Drawing.Size(167, 144)
        Me.picB1.TabIndex = 16
        Me.picB1.TabStop = False
        '
        'picC2
        '
        Me.picC2.BackgroundImage = CType(resources.GetObject("picC2.BackgroundImage"), System.Drawing.Image)
        Me.picC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picC2.Location = New System.Drawing.Point(196, 30)
        Me.picC2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picC2.Name = "picC2"
        Me.picC2.Size = New System.Drawing.Size(163, 144)
        Me.picC2.TabIndex = 15
        Me.picC2.TabStop = False
        '
        'picC1
        '
        Me.picC1.BackgroundImage = CType(resources.GetObject("picC1.BackgroundImage"), System.Drawing.Image)
        Me.picC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picC1.Location = New System.Drawing.Point(17, 30)
        Me.picC1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picC1.Name = "picC1"
        Me.picC1.Size = New System.Drawing.Size(163, 144)
        Me.picC1.TabIndex = 14
        Me.picC1.TabStop = False
        '
        'lblS1
        '
        Me.lblS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS1.Location = New System.Drawing.Point(740, 208)
        Me.lblS1.Name = "lblS1"
        Me.lblS1.Size = New System.Drawing.Size(167, 58)
        Me.lblS1.TabIndex = 12
        Me.lblS1.Text = "Breakfast Grilled Cheese Sandwich"
        Me.lblS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB2
        '
        Me.lblB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB2.Location = New System.Drawing.Point(557, 226)
        Me.lblB2.Name = "lblB2"
        Me.lblB2.Size = New System.Drawing.Size(167, 21)
        Me.lblB2.TabIndex = 11
        Me.lblB2.Text = "Almond Kaya Bun"
        Me.lblB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB1
        '
        Me.lblB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB1.Location = New System.Drawing.Point(375, 226)
        Me.lblB1.Name = "lblB1"
        Me.lblB1.Size = New System.Drawing.Size(167, 21)
        Me.lblB1.TabIndex = 10
        Me.lblB1.Text = "Red Bean Bun"
        Me.lblB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC2
        '
        Me.lblC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2.Location = New System.Drawing.Point(196, 208)
        Me.lblC2.Name = "lblC2"
        Me.lblC2.Size = New System.Drawing.Size(163, 82)
        Me.lblC2.TabIndex = 9
        Me.lblC2.Text = "Chocolate Butterscotch Cake"
        Me.lblC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblC1
        '
        Me.lblC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1.Location = New System.Drawing.Point(17, 226)
        Me.lblC1.Name = "lblC1"
        Me.lblC1.Size = New System.Drawing.Size(163, 21)
        Me.lblC1.TabIndex = 8
        Me.lblC1.Text = "Banana Cake"
        Me.lblC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Orange
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(43, 550)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 43)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Orange
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(303, 550)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 43)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Orange
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(78, 613)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(145, 44)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Orange
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(251, 613)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(145, 44)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(455, 356)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1108, 330)
        Me.DataGridView1.TabIndex = 7
        '
        'mnu2
        '
        Me.mnu2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSelect})
        Me.mnu2.Location = New System.Drawing.Point(0, 0)
        Me.mnu2.Name = "mnu2"
        Me.mnu2.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.mnu2.Size = New System.Drawing.Size(1618, 28)
        Me.mnu2.TabIndex = 8
        Me.mnu2.Text = "mnu2"
        '
        'mnuSelect
        '
        Me.mnuSelect.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTitle, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.mnuSelect.Name = "mnuSelect"
        Me.mnuSelect.Size = New System.Drawing.Size(63, 24)
        Me.mnuSelect.Text = "&Select"
        '
        'mnuTitle
        '
        Me.mnuTitle.Name = "mnuTitle"
        Me.mnuTitle.Size = New System.Drawing.Size(224, 26)
        Me.mnuTitle.Text = "&Back to Title"
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
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Orange
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(171, 550)
        Me.btnView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(112, 43)
        Me.btnView.TabIndex = 9
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1618, 699)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.mnu2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grbMenu)
        Me.Controls.Add(Me.grbProduct)
        Me.Controls.Add(Me.grbCustomer)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3"
        Me.Text = "TEDBOY Bakery Shop"
        Me.grbCustomer.ResumeLayout(False)
        Me.grbCustomer.PerformLayout()
        Me.grbProduct.ResumeLayout(False)
        Me.grbProduct.PerformLayout()
        Me.grbMenu.ResumeLayout(False)
        CType(Me.picS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu2.ResumeLayout(False)
        Me.mnu2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbCustomer As GroupBox
    Friend WithEvents txtCphone As TextBox
    Friend WithEvents txtCemail As TextBox
    Friend WithEvents txtCname As TextBox
    Friend WithEvents lblCphone As Label
    Friend WithEvents lblCemail As Label
    Friend WithEvents lblCname As Label
    Friend WithEvents grbProduct As GroupBox
    Friend WithEvents txtPtotalprice As TextBox
    Friend WithEvents txtPprice As TextBox
    Friend WithEvents txtPquan As TextBox
    Friend WithEvents lblPtotalprice As Label
    Friend WithEvents lblPquan As Label
    Friend WithEvents lblPprice As Label
    Friend WithEvents lblPname As Label
    Friend WithEvents grbMenu As GroupBox
    Friend WithEvents picS2 As PictureBox
    Friend WithEvents picS1 As PictureBox
    Friend WithEvents picB2 As PictureBox
    Friend WithEvents picB1 As PictureBox
    Friend WithEvents picC2 As PictureBox
    Friend WithEvents picC1 As PictureBox
    Friend WithEvents lblS1 As Label
    Friend WithEvents lblB2 As Label
    Friend WithEvents lblB1 As Label
    Friend WithEvents lblC2 As Label
    Friend WithEvents lblC1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mnu2 As MenuStrip
    Friend WithEvents mnuSelect As ToolStripMenuItem
    Friend WithEvents mnuTitle As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblC1price As Label
    Friend WithEvents lblC2price As Label
    Friend WithEvents lblB1price As Label
    Friend WithEvents lblB2price As Label
    Friend WithEvents lblS2price As Label
    Friend WithEvents lblS1price As Label
    Friend WithEvents lblS2 As Label
    Friend WithEvents txtPname As TextBox
    Friend WithEvents btnView As Button
End Class
