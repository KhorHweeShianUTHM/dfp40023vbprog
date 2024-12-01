Public Class Form2
    Dim inc As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim MaxRows As Integer
    Private Sub SELECTFONTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTFONTToolStripMenuItem.Click
        Dim digFontDialog As FontDialog = New FontDialog
        Dim result As DialogResult
        result = digFontDialog.ShowDialog
        txtNama.Font = digFontDialog.Font
        cmbJantina.Font = digFontDialog.Font
        txtAlamat.Font = digFontDialog.Font
        txtBandar.Font = digFontDialog.Font
        cmbDaerah.Font = digFontDialog.Font
    End Sub
    Private Sub SELECTFONTCOLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTFONTCOLORToolStripMenuItem.Click
        Dim digColorDialog As ColorDialog = New ColorDialog
        Dim result As DialogResult
        result = digColorDialog.ShowDialog
        txtNama.ForeColor = digColorDialog.Color
        cmbJantina.ForeColor = digColorDialog.Color
        txtAlamat.ForeColor = digColorDialog.Color
        txtBandar.ForeColor = digColorDialog.Color
        cmbDaerah.ForeColor = digColorDialog.Color
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim Student As New Display1
        Dim Pelajar As New Display2
        Student.Nama = txtNama.Text
        Student.Jantina = cmbJantina.Text
        Pelajar.Alamat = txtAlamat.Text
        Pelajar.Bandar = txtBandar.Text
        Pelajar.Daerah = cmbDaerah.Text
        If txtNama.Text = "" Then
            MessageBox.Show("Please enter NAME", "Warning")
        ElseIf cmbJantina.Text = "" Then
            MessageBox.Show("Please enter JANTINA", "Warning")
        ElseIf txtAlamat.Text = "" Then
            MessageBox.Show("Please enter ALAMAT", "Warning")
        ElseIf txtBandar.Text = "" Then
            MessageBox.Show("Please enter BANDAR", "Warning")
        ElseIf cmbDaerah.Text = "" Then
            MessageBox.Show("Please enter DAERAH", "Warning")
        Else
            MsgBox("=== DISPLAY INFORMATION ===" & vbCrLf & "NAMA: " & Student.Nama & vbCrLf & "JANTINA: " & Student.Jantina & vbCrLf & "ALAMAT: " & Pelajar.Alamat & vbCrLf & "BANDAR: " & Pelajar.Bandar & vbCrLf & "PELAJAR: " & Pelajar.Daerah & vbCrLf & "=====================")
        End If
    End Sub

    Private Sub FRISTPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FRISTPAGEToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer
        a = 1

        While (a < 4)
            MsgBox("Click 3 times to continues: " & a)
            a = a + 1
        End While

        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = C:\Users\User\Documents\StudInfo.accdb"
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        sql = "SELECT * FROM tblInfo"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "StudInfo")
        con.Close()
        MaxRows = ds.Tables("StudInfo").Rows.Count
        inc = -1
    End Sub

    Private Sub NavigateRecords()
        txtNama.Text = ds.Tables("StudInfo").Rows(inc).Item(1)
        cmbJantina.Text = ds.Tables("StudInfo").Rows(inc).Item(2)
        txtAlamat.Text = ds.Tables("StudInfo").Rows(inc).Item(3)
        txtBandar.Text = ds.Tables("StudInfo").Rows(inc).Item(4)
        cmbDaerah.Text = ds.Tables("StudInfo").Rows(inc).Item(5)
    End Sub

    Private Sub txtBandar_TextChanged(sender As Object, e As EventArgs) Handles txtBandar.TextChanged
        If txtBandar.Text = "Johor" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Batu Pahat")
            cmbDaerah.Items.Add("Johor Bahru")
            cmbDaerah.Items.Add("Kluang")

        ElseIf txtBandar.Text = "Kedah" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Sungai Petani")
            cmbDaerah.Items.Add("Alor Setar")
            cmbDaerah.Items.Add("Kulim")
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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If inc <> MaxRows - 1 Then
            inc = inc + 1
            NavigateRecords()
        Else
            MsgBox("No More Rows")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        inc = 0
        NavigateRecords()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If inc <> -1 Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("StudInfo").NewRow()
            dsNewRow.Item("NAMA") = txtNama.Text
            dsNewRow.Item("JANTINA") = cmbJantina.Text
            dsNewRow.Item("ALAMAT") = txtAlamat.Text
            dsNewRow.Item("BANDAR") = txtBandar.Text
            dsNewRow.Item("DAERAH") = cmbDaerah.Text

            ds.Tables("StudInfo").Rows.Add(dsNewRow)
            da.Update(ds, "StudInfo")
            MsgBox("New Record added to the Database")
        End If
    End Sub
End Class