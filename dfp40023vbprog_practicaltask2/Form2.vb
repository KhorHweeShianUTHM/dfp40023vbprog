Public Class Form2
    Private Sub SELECTFONTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTFONTToolStripMenuItem.Click
        Dim digFontDialog As FontDialog = New FontDialog
        Dim result As DialogResult
        result = digFontDialog.ShowDialog
        txtNama.Font = digFontDialog.Font
        txtIC.Font = digFontDialog.Font
        cmbJantina.Font = digFontDialog.Font
        txtUmur.Font = digFontDialog.Font
        cmbKaum.Font = digFontDialog.Font

        txtAlamat1.Font = digFontDialog.Font
        txtAlamat2.Font = digFontDialog.Font
        txtPoskod.Font = digFontDialog.Font
        txtBandar.Font = digFontDialog.Font
        cmbDaerah.Font = digFontDialog.Font
        txtTelefon.Font = digFontDialog.Font
    End Sub

    Private Sub SELECTFONTCOLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SELECTFONTCOLORToolStripMenuItem.Click
        Dim digColorDialog As ColorDialog = New ColorDialog
        Dim result As DialogResult
        result = digColorDialog.ShowDialog
        txtNama.ForeColor = digColorDialog.Color
        txtIC.ForeColor = digColorDialog.Color
        cmbJantina.ForeColor = digColorDialog.Color
        txtUmur.ForeColor = digColorDialog.Color
        cmbKaum.ForeColor = digColorDialog.Color

        txtAlamat1.ForeColor = digColorDialog.Color
        txtAlamat2.ForeColor = digColorDialog.Color
        txtPoskod.ForeColor = digColorDialog.Color
        txtBandar.ForeColor = digColorDialog.Color
        cmbDaerah.ForeColor = digColorDialog.Color
        txtTelefon.ForeColor = digColorDialog.Color
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim Student As New Display1
        Dim Pelajar As New Display2

        Student.Nama = txtNama.Text
        Student.Pendaftaran = txtIC.Text
        Student.Jantina = cmbJantina.Text
        Student.Umur = txtUmur.Text
        Student.Kaum = cmbKaum.Text

        Pelajar.Alamat = txtAlamat1.Text & " " & txtAlamat2.Text
        Pelajar.Poskod = txtPoskod.Text
        Pelajar.Bandar = txtBandar.Text
        Pelajar.Daerah = cmbDaerah.Text
        Pelajar.Telefon = txtTelefon.Text

        If txtNama.Text = "" Then
            MessageBox.Show("Please enter NAME", "Warning")
        ElseIf txtIC.Text = "" Then
            MessageBox.Show("Please enter NO PENDAFTARAN", "Warning")
        ElseIf cmbJantina.Text = "" Then
            MessageBox.Show("Please enter JANTINA", "Warning")
        ElseIf txtUmur.Text = "" Then
            MessageBox.Show("Please enter UMUR", "Warning")
        ElseIf cmbKaum.Text = "" Then
            MessageBox.Show("Please enter KAUM", "Warning")
        ElseIf txtAlamat1.Text = "" Then
            MessageBox.Show("Please enter ALAMAT", "Warning")
        ElseIf txtPoskod.Text = "" Then
            MessageBox.Show("Please enter POSKOD", "Warning")
        ElseIf txtBandar.Text = "" Then
            MessageBox.Show("Please enter BANDAR", "Warning")
        ElseIf cmbDaerah.Text = "" Then
            MessageBox.Show("Please enter DAERAH", "Warning")
        ElseIf txtTelefon.Text = "" Then
            MessageBox.Show("Please enter NO TELEFON", "Warning")
        Else
            MsgBox("=== DISPLAY INFORMATION ===" & vbCrLf &
                   "NAMA: " & Student.Nama & vbCrLf &
                   "NO PENDAFTARAN: " & Student.Pendaftaran & vbCrLf &
                   "JANTINA: " & Student.Jantina & vbCrLf &
                   "UMUR: " & Student.Umur & vbCrLf &
                   "KAUM: " & Student.Kaum & vbCrLf &
                   "ALAMAT: " & Pelajar.Alamat & vbCrLf &
                   "POSKOD: " & Pelajar.Poskod & vbCrLf &
                   "BANDAR: " & Pelajar.Bandar & vbCrLf &
                   "PELAJAR: " & Pelajar.Daerah & vbCrLf &
                   "NO TELEFON: " & Pelajar.Telefon & vbCrLf &
                   "=====================")
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
    End Sub

    Private Sub txtBandar_TextChanged(sender As Object, e As EventArgs) Handles txtBandar.TextChanged

        If txtBandar.Text = "JOHOR" Or txtBandar.Text = "johor" Or txtBandar.Text = "Johor" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Batu Pahat")
            cmbDaerah.Items.Add("Johor Bahru")
            cmbDaerah.Items.Add("Kluang")
            cmbDaerah.Items.Add("Kota Tinggi")
            cmbDaerah.Items.Add("Kulai")
            cmbDaerah.Items.Add("Mersing")
            cmbDaerah.Items.Add("Muar")
            cmbDaerah.Items.Add("Pontian")
            cmbDaerah.Items.Add("Segamat")
            cmbDaerah.Items.Add("Tangkak")

        ElseIf txtBandar.Text = "KEDAH" Or txtBandar.Text = "kedah" Or txtBandar.Text = "Kedah" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Sungai Petani")
            cmbDaerah.Items.Add("Alor Setar")
            cmbDaerah.Items.Add("Kulim")
            cmbDaerah.Items.Add("Kubang Pasu")
            cmbDaerah.Items.Add("Baling")
            cmbDaerah.Items.Add("Pendang")
            cmbDaerah.Items.Add("Langkawi")
            cmbDaerah.Items.Add("Yan")
            cmbDaerah.Items.Add("Sik")
            cmbDaerah.Items.Add("Padang Terap")
            cmbDaerah.Items.Add("Pokok Sena")
            cmbDaerah.Items.Add("Bandar Baharu")

        ElseIf txtBandar.Text = "KELANTAN" Or txtBandar.Text = "kelantan" Or txtBandar.Text = "Kelantan" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Bachok")
            cmbDaerah.Items.Add("Gua Musang")
            cmbDaerah.Items.Add("Jeli")
            cmbDaerah.Items.Add("Kota Bharu")
            cmbDaerah.Items.Add("Kuala Krai")
            cmbDaerah.Items.Add("Machang")
            cmbDaerah.Items.Add("Pasir Mas")
            cmbDaerah.Items.Add("Pasir Puteh")
            cmbDaerah.Items.Add("Tanah Merah")
            cmbDaerah.Items.Add("Tumpat")
            cmbDaerah.Items.Add("Lojing")

        ElseIf txtBandar.Text = "MELAKA" Or txtBandar.Text = "melaka" Or txtBandar.Text = "Melaka" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Alor Gajah")
            cmbDaerah.Items.Add("Melaka Tengah")
            cmbDaerah.Items.Add("Jasin")

        ElseIf txtBandar.Text = "NEGERI SEMBILAN" Or txtBandar.Text = "negeri sembilan" Or txtBandar.Text = "Negeri Sembilan" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Jelebu")
            cmbDaerah.Items.Add("Jempol")
            cmbDaerah.Items.Add("Kuala Pilah")
            cmbDaerah.Items.Add("Port Dickson")
            cmbDaerah.Items.Add("Rembau")
            cmbDaerah.Items.Add("Seremban")
            cmbDaerah.Items.Add("Tampin")

        ElseIf txtBandar.Text = "PAHANG" Or txtBandar.Text = "pahang" Or txtBandar.Text = "Pahang" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Bentong")
            cmbDaerah.Items.Add("Bera")
            cmbDaerah.Items.Add("Cameron Highland")
            cmbDaerah.Items.Add("Jerantut")
            cmbDaerah.Items.Add("Kuantan")
            cmbDaerah.Items.Add("Lipis")
            cmbDaerah.Items.Add("Maran")
            cmbDaerah.Items.Add("Pekan")
            cmbDaerah.Items.Add("Raub")
            cmbDaerah.Items.Add("Rompin")
            cmbDaerah.Items.Add("Temerloh")

        ElseIf txtBandar.Text = "PERAK" Or txtBandar.Text = "perak" Or txtBandar.Text = "Perak" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Batang Padang")
            cmbDaerah.Items.Add("Hilir Perak")
            cmbDaerah.Items.Add("Hulu Perak")
            cmbDaerah.Items.Add("Kampar")
            cmbDaerah.Items.Add("Kerian")
            cmbDaerah.Items.Add("Kinta")
            cmbDaerah.Items.Add("Kuala Kangsar")
            cmbDaerah.Items.Add("Larut, Matang dan Selama")
            cmbDaerah.Items.Add("Manjung")
            cmbDaerah.Items.Add("Muallim")
            cmbDaerah.Items.Add("Perak Tengah")
            cmbDaerah.Items.Add("Bagan Datuk")

        ElseIf txtBandar.Text = "PERLIS" Or txtBandar.Text = "perlis" Or txtBandar.Text = "Perlis" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Perlis")

        ElseIf txtBandar.Text = "PULAU PINANG" Or txtBandar.Text = "pulau pinang" Or txtBandar.Text = "Pulau Pinang" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Timur Laut Pulau Pinang")
            cmbDaerah.Items.Add("Barat Daya Pulau Pinang")
            cmbDaerah.Items.Add("Seberang Perai Utara")
            cmbDaerah.Items.Add("Seberang Perai Tengah")
            cmbDaerah.Items.Add("Seberang Perai Selatan")

        ElseIf txtBandar.Text = "SABAH" Or txtBandar.Text = "sabah" Or txtBandar.Text = "Sabah" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Kota Kinabalu")
            cmbDaerah.Items.Add("Tawau")
            cmbDaerah.Items.Add("Sandakan")
            cmbDaerah.Items.Add("Lahad Datu")
            cmbDaerah.Items.Add("Keningau")
            cmbDaerah.Items.Add("Kinabatangan")
            cmbDaerah.Items.Add("Semporna")
            cmbDaerah.Items.Add("Papar")
            cmbDaerah.Items.Add("Penampang")
            cmbDaerah.Items.Add("Beluran")
            cmbDaerah.Items.Add("Tuaran")
            cmbDaerah.Items.Add("Ranau")
            cmbDaerah.Items.Add("Kota Belud")
            cmbDaerah.Items.Add("Kudat")
            cmbDaerah.Items.Add("Kota Marudu")
            cmbDaerah.Items.Add("Beaufort")
            cmbDaerah.Items.Add("Kunak")
            cmbDaerah.Items.Add("Tenom")
            cmbDaerah.Items.Add("Putatan")
            cmbDaerah.Items.Add("Pitas")
            cmbDaerah.Items.Add("Tambunan")
            cmbDaerah.Items.Add("Tongod")
            cmbDaerah.Items.Add("Sipitang")
            cmbDaerah.Items.Add("Nabawan")
            cmbDaerah.Items.Add("Kuala Penyu")

        ElseIf txtBandar.Text = "SARAWAK" Or txtBandar.Text = "sarawak" Or txtBandar.Text = "Sarawak" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Kuching")
            cmbDaerah.Items.Add("Miri")
            cmbDaerah.Items.Add("Sibu")
            cmbDaerah.Items.Add("Bintulu")
            cmbDaerah.Items.Add("Serian")
            cmbDaerah.Items.Add("Kota Samarahan")
            cmbDaerah.Items.Add("Sri Aman")
            cmbDaerah.Items.Add("Marudi")
            cmbDaerah.Items.Add("Betong")
            cmbDaerah.Items.Add("Sarikei")
            cmbDaerah.Items.Add("Kapit")
            cmbDaerah.Items.Add("Bau")
            cmbDaerah.Items.Add("Limbang")
            cmbDaerah.Items.Add("Saratok")
            cmbDaerah.Items.Add("Mukah")
            cmbDaerah.Items.Add("Simunjan")
            cmbDaerah.Items.Add("Lawas")
            cmbDaerah.Items.Add("Belaga")
            cmbDaerah.Items.Add("Lundu")
            cmbDaerah.Items.Add("Asajaya")
            cmbDaerah.Items.Add("Daro")
            cmbDaerah.Items.Add("Tatau")
            cmbDaerah.Items.Add("Maradong")
            cmbDaerah.Items.Add("Kanowit")
            cmbDaerah.Items.Add("Lubok Antu")
            cmbDaerah.Items.Add("Selangau")
            cmbDaerah.Items.Add("Song")
            cmbDaerah.Items.Add("Dalat")
            cmbDaerah.Items.Add("Matu")
            cmbDaerah.Items.Add("Julau")
            cmbDaerah.Items.Add("Pakan")
            cmbDaerah.Items.Add("Tanjung Manis")
            cmbDaerah.Items.Add("Bukit Mabong")
            cmbDaerah.Items.Add("Telang Usan")
            cmbDaerah.Items.Add("Tebedu")
            cmbDaerah.Items.Add("Subis")
            cmbDaerah.Items.Add("Sebauh")
            cmbDaerah.Items.Add("Beluru")
            cmbDaerah.Items.Add("Kabong")

        ElseIf txtBandar.Text = "SELANGOR" Or txtBandar.Text = "selangor" Or txtBandar.Text = "Selangor" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Gombak")
            cmbDaerah.Items.Add("Hulu Langat")
            cmbDaerah.Items.Add("Hulu Selangor")
            cmbDaerah.Items.Add("Klang")
            cmbDaerah.Items.Add("Kuala Langat")
            cmbDaerah.Items.Add("Kuala Selangor")
            cmbDaerah.Items.Add("Petaling")
            cmbDaerah.Items.Add("Sabak Bernam")
            cmbDaerah.Items.Add("Sepang")

        ElseIf txtBandar.Text = "TERENGGANU" Or txtBandar.Text = "terengganu" Or txtBandar.Text = "Terengganu" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Besut")
            cmbDaerah.Items.Add("Dungun")
            cmbDaerah.Items.Add("Hulu Terengganu")
            cmbDaerah.Items.Add("Kemaman")
            cmbDaerah.Items.Add("Kuala Terengganu")
            cmbDaerah.Items.Add("Marang")
            cmbDaerah.Items.Add("Setiu")
            cmbDaerah.Items.Add("Kuala Nerus")

        ElseIf txtBandar.Text = "WILAYAH PERSEKUTUAN" Or txtBandar.Text = "wilayah persekutuan" Or txtBandar.Text = "Wilayah Persekutuan" Then
            cmbDaerah.Items.Clear()
            cmbDaerah.Items.Add("Kuala Lumpur")
            cmbDaerah.Items.Add("Labuan")
            cmbDaerah.Items.Add("Putrajaya")
        Else
            MessageBox.Show("Please enter BANDAR again", "Warning")
        End If
    End Sub
End Class