<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim Address1Label As System.Windows.Forms.Label
        Dim Address2Label As System.Windows.Forms.Label
        Dim Address3Label As System.Windows.Forms.Label
        Dim PostcodeLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Me.AddressBookDataSet = New Khor_DDT5D_Lab16.AddressBookDataSet()
        Me.TblContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblContactsTableAdapter = New Khor_DDT5D_Lab16.AddressBookDataSetTableAdapters.tblContactsTableAdapter()
        Me.TableAdapterManager = New Khor_DDT5D_Lab16.AddressBookDataSetTableAdapters.TableAdapterManager()
        Me.TblContactsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblContactsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.Address1TextBox = New System.Windows.Forms.TextBox()
        Me.Address2TextBox = New System.Windows.Forms.TextBox()
        Me.Address3TextBox = New System.Windows.Forms.TextBox()
        Me.PostcodeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        Address1Label = New System.Windows.Forms.Label()
        Address2Label = New System.Windows.Forms.Label()
        Address3Label = New System.Windows.Forms.Label()
        PostcodeLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        CType(Me.AddressBookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblContactsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddressBookDataSet
        '
        Me.AddressBookDataSet.DataSetName = "AddressBookDataSet"
        Me.AddressBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblContactsBindingSource
        '
        Me.TblContactsBindingSource.DataMember = "tblContacts"
        Me.TblContactsBindingSource.DataSource = Me.AddressBookDataSet
        '
        'TblContactsTableAdapter
        '
        Me.TblContactsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblContactsTableAdapter = Me.TblContactsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Khor_DDT5D_Lab16.AddressBookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblContactsBindingNavigator
        '
        Me.TblContactsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblContactsBindingNavigator.BindingSource = Me.TblContactsBindingSource
        Me.TblContactsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblContactsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblContactsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TblContactsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblContactsBindingNavigatorSaveItem})
        Me.TblContactsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblContactsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblContactsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblContactsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblContactsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblContactsBindingNavigator.Name = "TblContactsBindingNavigator"
        Me.TblContactsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblContactsBindingNavigator.Size = New System.Drawing.Size(800, 31)
        Me.TblContactsBindingNavigator.TabIndex = 0
        Me.TblContactsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblContactsBindingNavigatorSaveItem
        '
        Me.TblContactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblContactsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblContactsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblContactsBindingNavigatorSaveItem.Name = "TblContactsBindingNavigatorSaveItem"
        Me.TblContactsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.TblContactsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(39, 72)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(31, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(142, 69)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 27)
        Me.IDTextBox.TabIndex = 2
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(39, 123)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(97, 20)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(142, 120)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(232, 27)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.Location = New System.Drawing.Point(39, 174)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(96, 20)
        SurnameLabel.TabIndex = 5
        SurnameLabel.Text = "Last Name:"
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "Surname", True))
        Me.SurnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameTextBox.Location = New System.Drawing.Point(142, 171)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(232, 27)
        Me.SurnameTextBox.TabIndex = 6
        '
        'Address1Label
        '
        Address1Label.AutoSize = True
        Address1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address1Label.Location = New System.Drawing.Point(419, 72)
        Address1Label.Name = "Address1Label"
        Address1Label.Size = New System.Drawing.Size(85, 20)
        Address1Label.TabIndex = 7
        Address1Label.Text = "Address1:"
        '
        'Address1TextBox
        '
        Me.Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "Address1", True))
        Me.Address1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address1TextBox.Location = New System.Drawing.Point(538, 69)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(221, 27)
        Me.Address1TextBox.TabIndex = 8
        '
        'Address2Label
        '
        Address2Label.AutoSize = True
        Address2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address2Label.Location = New System.Drawing.Point(419, 126)
        Address2Label.Name = "Address2Label"
        Address2Label.Size = New System.Drawing.Size(85, 20)
        Address2Label.TabIndex = 9
        Address2Label.Text = "Address2:"
        '
        'Address2TextBox
        '
        Me.Address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "Address2", True))
        Me.Address2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address2TextBox.Location = New System.Drawing.Point(538, 123)
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.Size = New System.Drawing.Size(221, 27)
        Me.Address2TextBox.TabIndex = 10
        '
        'Address3Label
        '
        Address3Label.AutoSize = True
        Address3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address3Label.Location = New System.Drawing.Point(419, 180)
        Address3Label.Name = "Address3Label"
        Address3Label.Size = New System.Drawing.Size(85, 20)
        Address3Label.TabIndex = 11
        Address3Label.Text = "Address3:"
        '
        'Address3TextBox
        '
        Me.Address3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "Address3", True))
        Me.Address3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address3TextBox.Location = New System.Drawing.Point(538, 177)
        Me.Address3TextBox.Name = "Address3TextBox"
        Me.Address3TextBox.Size = New System.Drawing.Size(221, 27)
        Me.Address3TextBox.TabIndex = 12
        '
        'PostcodeLabel
        '
        PostcodeLabel.AutoSize = True
        PostcodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PostcodeLabel.Location = New System.Drawing.Point(419, 234)
        PostcodeLabel.Name = "PostcodeLabel"
        PostcodeLabel.Size = New System.Drawing.Size(84, 20)
        PostcodeLabel.TabIndex = 13
        PostcodeLabel.Text = "Postcode:"
        '
        'PostcodeTextBox
        '
        Me.PostcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "Postcode", True))
        Me.PostcodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostcodeTextBox.Location = New System.Drawing.Point(538, 231)
        Me.PostcodeTextBox.Name = "PostcodeTextBox"
        Me.PostcodeTextBox.Size = New System.Drawing.Size(110, 27)
        Me.PostcodeTextBox.TabIndex = 14
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(419, 288)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(61, 20)
        PhoneLabel.TabIndex = 15
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(538, 285)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(131, 27)
        Me.PhoneTextBox.TabIndex = 16
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(39, 225)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(56, 20)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "Email:"
        AddHandler EmailLabel.Click, AddressOf Me.EmailLabel_Click
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(142, 222)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(232, 27)
        Me.EmailTextBox.TabIndex = 18
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotesLabel.Location = New System.Drawing.Point(39, 276)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(58, 20)
        NotesLabel.TabIndex = 19
        NotesLabel.Text = "Notes:"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "Notes", True))
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesTextBox.Location = New System.Drawing.Point(142, 273)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(232, 87)
        Me.NotesTextBox.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(PostcodeLabel)
        Me.Controls.Add(Me.PostcodeTextBox)
        Me.Controls.Add(Address3Label)
        Me.Controls.Add(Me.Address3TextBox)
        Me.Controls.Add(Address2Label)
        Me.Controls.Add(Me.Address2TextBox)
        Me.Controls.Add(Address1Label)
        Me.Controls.Add(Me.Address1TextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.TblContactsBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "lab16"
        CType(Me.AddressBookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblContactsBindingNavigator.ResumeLayout(False)
        Me.TblContactsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddressBookDataSet As AddressBookDataSet
    Friend WithEvents TblContactsBindingSource As BindingSource
    Friend WithEvents TblContactsTableAdapter As AddressBookDataSetTableAdapters.tblContactsTableAdapter
    Friend WithEvents TableAdapterManager As AddressBookDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblContactsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblContactsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents Address1TextBox As TextBox
    Friend WithEvents Address2TextBox As TextBox
    Friend WithEvents Address3TextBox As TextBox
    Friend WithEvents PostcodeTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
End Class
