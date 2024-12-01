Public Class Form1
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim inc As Integer
    Dim MaxRows As Integer
    Private Sub TblBookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblBookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblBookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbLibraryDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = C:\Users\User\Documents\dbLibrary.accdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()

        sql = “SELECT * FROM tblBook”
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "dbLibrary")

        con.Close()
    End Sub
    Private Sub NavigateRecords()
        IDTextBox.Text = ds.Tables("dbLibrary").Rows(inc).Item(0)
        TitleTextBox.Text = ds.Tables("dbLibrary").Rows(inc).Item(1)
        AuthorTextBox.Text = ds.Tables("dbLibrary").Rows(inc).Item(2)
        PublisherTextBox.Text = ds.Tables("dbLibrary").Rows(inc).Item(3)
        StatePublishTextBox.Text = ds.Tables("dbLibrary").Rows(inc).Item(4)
        YearsTextBox.Text = ds.Tables("dbLibrary").Rows(inc).Item(5)
        ISBNTextBox.Text = ds.Tables("dbLibrary").Rows(inc).Item(6)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        'ds.Tables("dbLibrary").Rows(inc).Item(0) = IDTextBox.Text
        ds.Tables("dbLibrary").Rows(inc).Item(1) = TitleTextBox.Text
        ds.Tables("dbLibrary").Rows(inc).Item(2) = AuthorTextBox.Text
        ds.Tables("dbLibrary").Rows(inc).Item(3) = PublisherTextBox.Text
        ds.Tables("dbLibrary").Rows(inc).Item(4) = StatePublishTextBox.Text
        ds.Tables("dbLibrary").Rows(inc).Item(5) = YearsTextBox.Text
        ds.Tables("dbLibrary").Rows(inc).Item(6) = ISBNTextBox.Text
        da.Update(ds, "dbLibrary")
        MsgBox("Data updated")
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        btnCommit.Enabled = True
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False

        IDTextBox.Clear()
        TitleTextBox.Clear()
        AuthorTextBox.Clear()
        PublisherTextBox.Clear()
        StatePublishTextBox.Clear()
        YearsTextBox.Clear()
        ISBNTextBox.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnCommit.Enabled = False
        btnAddNew.Enabled = True
        btnUpdate.Enabled = True

        inc = 0
        NavigateRecords()
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        If inc <> -1 Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("dbLibrary").NewRow()

            'dsNewRow.Item("ID") = IDTextBox.Text
            dsNewRow.Item("Title") = TitleTextBox.Text
            dsNewRow.Item("Author") = AuthorTextBox.Text
            dsNewRow.Item("Publisher") = PublisherTextBox.Text
            dsNewRow.Item("StatePublish") = StatePublishTextBox.Text
            dsNewRow.Item("Years") = YearsTextBox.Text
            dsNewRow.Item("ISBN") = ISBNTextBox.Text

            ds.Tables("dbLibrary").Rows.Add(dsNewRow)

            da.Update(ds, "dbLibrary")

            MsgBox("New Record added to the Database")

            btnCommit.Enabled = False
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True
        End If
    End Sub
End Class