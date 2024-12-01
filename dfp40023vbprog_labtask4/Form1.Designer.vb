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
        Dim IDLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim PublisherLabel As System.Windows.Forms.Label
        Dim StatePublishLabel As System.Windows.Forms.Label
        Dim YearsLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DbLibraryDataSet = New prjLibrary.dbLibraryDataSet()
        Me.TblBookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblBookTableAdapter = New prjLibrary.dbLibraryDataSetTableAdapters.tblBookTableAdapter()
        Me.TableAdapterManager = New prjLibrary.dbLibraryDataSetTableAdapters.TableAdapterManager()
        Me.TblBookBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblBookBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.StatePublishTextBox = New System.Windows.Forms.TextBox()
        Me.YearsTextBox = New System.Windows.Forms.TextBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblLibrary = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        PublisherLabel = New System.Windows.Forms.Label()
        StatePublishLabel = New System.Windows.Forms.Label()
        YearsLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        CType(Me.DbLibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBookBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblBookBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.Yellow
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.Color.Blue
        IDLabel.Location = New System.Drawing.Point(29, 117)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(31, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.BackColor = System.Drawing.Color.Yellow
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.ForeColor = System.Drawing.Color.Blue
        TitleLabel.Location = New System.Drawing.Point(29, 150)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(46, 20)
        TitleLabel.TabIndex = 3
        TitleLabel.Text = "Title:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.BackColor = System.Drawing.Color.Yellow
        AuthorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AuthorLabel.ForeColor = System.Drawing.Color.Blue
        AuthorLabel.Location = New System.Drawing.Point(29, 183)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(63, 20)
        AuthorLabel.TabIndex = 5
        AuthorLabel.Text = "Author:"
        '
        'PublisherLabel
        '
        PublisherLabel.AutoSize = True
        PublisherLabel.BackColor = System.Drawing.Color.Yellow
        PublisherLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PublisherLabel.ForeColor = System.Drawing.Color.Blue
        PublisherLabel.Location = New System.Drawing.Point(29, 216)
        PublisherLabel.Name = "PublisherLabel"
        PublisherLabel.Size = New System.Drawing.Size(84, 20)
        PublisherLabel.TabIndex = 7
        PublisherLabel.Text = "Publisher:"
        '
        'StatePublishLabel
        '
        StatePublishLabel.AutoSize = True
        StatePublishLabel.BackColor = System.Drawing.Color.Yellow
        StatePublishLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatePublishLabel.ForeColor = System.Drawing.Color.Blue
        StatePublishLabel.Location = New System.Drawing.Point(29, 249)
        StatePublishLabel.Name = "StatePublishLabel"
        StatePublishLabel.Size = New System.Drawing.Size(113, 20)
        StatePublishLabel.TabIndex = 9
        StatePublishLabel.Text = "State Publish:"
        '
        'YearsLabel
        '
        YearsLabel.AutoSize = True
        YearsLabel.BackColor = System.Drawing.Color.Yellow
        YearsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YearsLabel.ForeColor = System.Drawing.Color.Blue
        YearsLabel.Location = New System.Drawing.Point(29, 282)
        YearsLabel.Name = "YearsLabel"
        YearsLabel.Size = New System.Drawing.Size(48, 20)
        YearsLabel.TabIndex = 11
        YearsLabel.Text = "Year:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.BackColor = System.Drawing.Color.Yellow
        ISBNLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ISBNLabel.ForeColor = System.Drawing.Color.Blue
        ISBNLabel.Location = New System.Drawing.Point(29, 315)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(53, 20)
        ISBNLabel.TabIndex = 13
        ISBNLabel.Text = "ISBN:"
        '
        'DbLibraryDataSet
        '
        Me.DbLibraryDataSet.DataSetName = "dbLibraryDataSet"
        Me.DbLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBookBindingSource
        '
        Me.TblBookBindingSource.DataMember = "tblBook"
        Me.TblBookBindingSource.DataSource = Me.DbLibraryDataSet
        '
        'TblBookTableAdapter
        '
        Me.TblBookTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBookTableAdapter = Me.TblBookTableAdapter
        Me.TableAdapterManager.UpdateOrder = prjLibrary.dbLibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblBookBindingNavigator
        '
        Me.TblBookBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblBookBindingNavigator.BindingSource = Me.TblBookBindingSource
        Me.TblBookBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblBookBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblBookBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TblBookBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblBookBindingNavigatorSaveItem})
        Me.TblBookBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblBookBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblBookBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblBookBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblBookBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblBookBindingNavigator.Name = "TblBookBindingNavigator"
        Me.TblBookBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblBookBindingNavigator.Size = New System.Drawing.Size(816, 31)
        Me.TblBookBindingNavigator.TabIndex = 0
        Me.TblBookBindingNavigator.Text = "BindingNavigator1"
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
        'TblBookBindingNavigatorSaveItem
        '
        Me.TblBookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblBookBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblBookBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblBookBindingNavigatorSaveItem.Name = "TblBookBindingNavigatorSaveItem"
        Me.TblBookBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.TblBookBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBookBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(173, 117)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 27)
        Me.IDTextBox.TabIndex = 2
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBookBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(173, 150)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(369, 27)
        Me.TitleTextBox.TabIndex = 4
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBookBindingSource, "Author", True))
        Me.AuthorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.Location = New System.Drawing.Point(173, 183)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(315, 27)
        Me.AuthorTextBox.TabIndex = 6
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBookBindingSource, "Publisher", True))
        Me.PublisherTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublisherTextBox.Location = New System.Drawing.Point(173, 216)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(315, 27)
        Me.PublisherTextBox.TabIndex = 8
        '
        'StatePublishTextBox
        '
        Me.StatePublishTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBookBindingSource, "StatePulish", True))
        Me.StatePublishTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatePublishTextBox.Location = New System.Drawing.Point(173, 249)
        Me.StatePublishTextBox.Name = "StatePublishTextBox"
        Me.StatePublishTextBox.Size = New System.Drawing.Size(100, 27)
        Me.StatePublishTextBox.TabIndex = 10
        '
        'YearsTextBox
        '
        Me.YearsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBookBindingSource, "Year", True))
        Me.YearsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearsTextBox.Location = New System.Drawing.Point(173, 282)
        Me.YearsTextBox.Name = "YearsTextBox"
        Me.YearsTextBox.Size = New System.Drawing.Size(100, 27)
        Me.YearsTextBox.TabIndex = 12
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBookBindingSource, "ISBN", True))
        Me.ISBNTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNTextBox.Location = New System.Drawing.Point(173, 315)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(241, 27)
        Me.ISBNTextBox.TabIndex = 14
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.Yellow
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Blue
        Me.btnAddNew.Location = New System.Drawing.Point(589, 117)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(202, 36)
        Me.btnAddNew.TabIndex = 15
        Me.btnAddNew.Text = "Add New Record"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'btnCommit
        '
        Me.btnCommit.BackColor = System.Drawing.Color.Yellow
        Me.btnCommit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCommit.ForeColor = System.Drawing.Color.Blue
        Me.btnCommit.Location = New System.Drawing.Point(589, 172)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(202, 36)
        Me.btnCommit.TabIndex = 16
        Me.btnCommit.Text = "Commit Changes"
        Me.btnCommit.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Blue
        Me.btnUpdate.Location = New System.Drawing.Point(589, 227)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(202, 36)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update Record"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblLibrary
        '
        Me.lblLibrary.AutoSize = True
        Me.lblLibrary.BackColor = System.Drawing.Color.Yellow
        Me.lblLibrary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibrary.ForeColor = System.Drawing.Color.Blue
        Me.lblLibrary.Location = New System.Drawing.Point(300, 52)
        Me.lblLibrary.Name = "lblLibrary"
        Me.lblLibrary.Size = New System.Drawing.Size(217, 25)
        Me.lblLibrary.TabIndex = 19
        Me.lblLibrary.Text = "MALAYSIA LIBRARY"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Yellow
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Blue
        Me.btnClear.Location = New System.Drawing.Point(589, 282)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(202, 36)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear/Cancel"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(816, 360)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblLibrary)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(PublisherLabel)
        Me.Controls.Add(Me.PublisherTextBox)
        Me.Controls.Add(StatePublishLabel)
        Me.Controls.Add(Me.StatePublishTextBox)
        Me.Controls.Add(YearsLabel)
        Me.Controls.Add(Me.YearsTextBox)
        Me.Controls.Add(ISBNLabel)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(Me.TblBookBindingNavigator)
        Me.Name = "Form1"
        Me.Text = " frmBook"
        CType(Me.DbLibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBookBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblBookBindingNavigator.ResumeLayout(False)
        Me.TblBookBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbLibraryDataSet As dbLibraryDataSet
    Friend WithEvents TblBookBindingSource As BindingSource
    Friend WithEvents TblBookTableAdapter As dbLibraryDataSetTableAdapters.tblBookTableAdapter
    Friend WithEvents TableAdapterManager As dbLibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblBookBindingNavigator As BindingNavigator
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
    Friend WithEvents TblBookBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents PublisherTextBox As TextBox
    Friend WithEvents StatePublishTextBox As TextBox
    Friend WithEvents YearsTextBox As TextBox
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblLibrary As Label
    Friend WithEvents btnClear As Button
End Class
