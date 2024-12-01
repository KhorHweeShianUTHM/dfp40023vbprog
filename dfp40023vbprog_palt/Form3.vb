Public Class Form3
    Dim con As New OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim sql As String
    Dim MaxRows As Integer
    Dim inc As Integer
    Dim dsNewRow As DataRow

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source=C:\Users\User\Documents\dbClub.accdb"

        con.ConnectionString = dbProvider & dbSource
        con.Open()

        sql = “SELECT * FROM tblMember”
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "dbClub")

        con.Close()

        MaxRows = ds.Tables("dbClub").Rows.Count
        inc = -1
    End Sub

    Private Sub Navigate()
        txtIC.Text = ds.Tables("dbClub").Rows(inc).Item(1)
        txtName.Text = ds.Tables("dbClub").Rows(inc).Item(2)
        txtPhone.Text = ds.Tables("dbClub").Rows(inc).Item(3)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If inc <> MaxRows - 1 Then
            inc = inc + 1
            Navigate()
        Else
            MessageBox.Show("No more last records", "Warning")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If inc > 0 Then
            inc = inc - 1
            Navigate()
        ElseIf inc = 0 Then
            MessageBox.Show("No more first records", "Warning")
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        If inc <> MaxRows - 1 Then
            inc = MaxRows - 1
            Navigate()
            MessageBox.Show("No more last records", "Warning")
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If inc <> 0 Then
            inc = 0
            Navigate()
            MessageBox.Show("No more first records", "Warning")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ds.Tables("dbClub").Rows(inc).Item(1) = txtIC.Text
        ds.Tables("dbClub").Rows(inc).Item(2) = txtName.Text
        ds.Tables("dbClub").Rows(inc).Item(3) = txtPhone.Text
        da.Update(ds, "dbClub")
        MessageBox.Show("Record is save Successfully.", "Warning")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If inc <> -1 Then
            dsNewRow = ds.Tables("dbClub").NewRow()
            dsNewRow.Item("IC_No") = txtIC.Text
            dsNewRow.Item("Name") = txtName.Text
            dsNewRow.Item("Phone_No") = txtPhone.Text
            ds.Tables("dbClub").Rows.Add(dsNewRow)
            da.Update(ds, "dbClub")
            MessageBox.Show("Record is add Successfully.", "Warning")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ds.Tables("dbClub").Rows(inc).Delete()
        MaxRows = MaxRows - 1
        inc = 0
        Navigate()
        da.Update(ds, "dbClub")
        MessageBox.Show("Record is delete Successfully.", "Warning")
    End Sub
End Class