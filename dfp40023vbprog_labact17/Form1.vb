Public Class Form1
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim MaxRows As Integer
    Dim inc As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AddressBookDataSet.tblContacts' table. You can move, or remove it, as needed.
        Me.TblContactsTableAdapter.Fill(Me.AddressBookDataSet.tblContacts)
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = C:\Users\User\Documents\AddressBook.accdb"

        con.ConnectionString = dbProvider & dbSource

        con.Open()

        sql = “SELECT * FROM tblContacts”
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "AddressBook")

        con.Close()

        MaxRows = ds.Tables("AddressBook").Rows.Count
        inc = -1
    End Sub

    Private Sub NavigateRecords()
        txtFirstName.Text = ds.Tables("AddressBook").Rows(inc).Item(1)
        txtSurname.Text = ds.Tables("AddressBook").Rows(inc).Item(2)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If inc <> MaxRows - 1 Then
            inc = inc + 1
            NavigateRecords()
        Else
            MsgBox("No More Rows")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If inc > 0 Then
            inc = inc - 1
            NavigateRecords()
        ElseIf inc = -1 Then
            MsgBox("No Records Yet")
        ElseIf inc = 0 Then
            MsgBox("First Record")
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        If inc <> MaxRows - 1 Then
            inc = MaxRows - 1
            NavigateRecords()
        End If

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If inc <> 0 Then
            inc = 0
            NavigateRecords()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        ds.Tables("AddressBook").Rows(inc).Item(1) = txtFirstName.Text
        ds.Tables("AddressBook").Rows(inc).Item(2) = txtSurname.Text
        da.Update(ds, "AddressBook")
        MsgBox("Data updated")
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        btnCommit.Enabled = True
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtFirstName.Clear()
        txtSurname.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnCommit.Enabled = False
        btnAddNew.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        inc = 0
        NavigateRecords()
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        If inc <> -1 Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("AddressBook").NewRow()
            dsNewRow.Item("FirstName") = txtFirstName.Text
            dsNewRow.Item("Surname") = txtSurname.Text
            ds.Tables("AddressBook").Rows.Add(dsNewRow)
            da.Update(ds, "AddressBook")
            MsgBox("New Record added to the Database")
            btnCommit.Enabled = False
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you really want to Delete this Record?",
                           "Delete", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Operation Cancelled")
            Exit Sub
        End If
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        ds.Tables("AddressBook").Rows(inc).Delete()
        MaxRows = MaxRows - 1
        inc = 0
        NavigateRecords()
        da.Update(ds, "AddressBook")
    End Sub

    Private Sub TblContactsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblContactsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblContactsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AddressBookDataSet)
    End Sub
End Class