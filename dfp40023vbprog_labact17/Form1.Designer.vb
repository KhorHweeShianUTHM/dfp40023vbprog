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
        Me.components = New System.ComponentModel.Container()
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.AddressBookDataSet = New Khor_DDT5D_Lab17.AddressBookDataSet()
        Me.TblContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblContactsTableAdapter = New Khor_DDT5D_Lab17.AddressBookDataSetTableAdapters.tblContactsTableAdapter()
        Me.TableAdapterManager = New Khor_DDT5D_Lab17.AddressBookDataSetTableAdapters.TableAdapterManager()
        Me.TblContactsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblContactsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        FirstNameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        CType(Me.AddressBookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblContactsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblContactsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(36, 74)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(80, 17)
        FirstNameLabel.TabIndex = 15
        FirstNameLabel.Text = "First Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.Location = New System.Drawing.Point(37, 117)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(69, 17)
        SurnameLabel.TabIndex = 17
        SurnameLabel.Text = "Surname:"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(246, 259)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 30)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(143, 261)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 30)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(40, 261)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 30)
        Me.btnFirst.TabIndex = 6
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(349, 259)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 30)
        Me.btnLast.TabIndex = 7
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(452, 54)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(146, 30)
        Me.btnAddNew.TabIndex = 8
        Me.btnAddNew.Text = "Add New Record"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        Me.btnCommit.Enabled = False
        Me.btnCommit.Location = New System.Drawing.Point(452, 105)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(146, 30)
        Me.btnCommit.TabIndex = 9
        Me.btnCommit.Text = "Commit Changes"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(452, 155)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(146, 30)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(452, 205)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(146, 30)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete Record"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(452, 259)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(146, 30)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear/Cancel"
        Me.btnClear.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.UpdateOrder = Khor_DDT5D_Lab17.AddressBookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.TblContactsBindingNavigator.Size = New System.Drawing.Size(623, 27)
        Me.TblContactsBindingNavigator.TabIndex = 13
        Me.TblContactsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TblContactsBindingNavigatorSaveItem
        '
        Me.TblContactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblContactsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblContactsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblContactsBindingNavigatorSaveItem.Name = "TblContactsBindingNavigatorSaveItem"
        Me.TblContactsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.TblContactsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "FirstName", True))
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(122, 74)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(160, 22)
        Me.txtFirstName.TabIndex = 16
        '
        'txtSurname
        '
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblContactsBindingSource, "Surname", True))
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(122, 117)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(160, 22)
        Me.txtSurname.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 322)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.TblContactsBindingNavigator)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "Form1"
        Me.Text = "lab17ab"
        CType(Me.AddressBookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblContactsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblContactsBindingNavigator.ResumeLayout(False)
        Me.TblContactsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
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
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtSurname As TextBox
End Class
