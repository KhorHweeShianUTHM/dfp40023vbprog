Imports MySql.Data.MySqlClient
Public Class Form3
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer
    Private Sub txtPname_TextChanged(sender As Object, e As EventArgs) Handles txtPname.TextChanged
        If txtPname.Text = "Banana Cake" Then
            txtPprice.Clear()
            txtPprice.Text = "12"
        ElseIf txtPname.Text = "Chocolate Butterscotch Cake" Then
            txtPprice.Clear()
            txtPprice.Text = "12"
        ElseIf txtPname.Text = "Red Bean Bun" Then
            txtPprice.Clear()
            txtPprice.Text = "2.10"
        ElseIf txtPname.Text = "Almond Kaya Bun" Then
            txtPprice.Clear()
            txtPprice.Text = "3.50"
        ElseIf txtPname.Text = "Breakfast Grilled Cheese Sandwich" Then
            txtPprice.Clear()
            txtPprice.Text = "20"
        ElseIf txtPname.Text = "Grilled Chicken Sandwich" Then
            txtPprice.Clear()
            txtPprice.Text = "9"
        End If
    End Sub

    Private Sub txtPquan_TextChanged(sender As Object, e As EventArgs) Handles txtPquan.TextChanged
        If txtPname.Text = "Banana Cake" Then
            txtPtotalprice.Text = 12 * Val(txtPquan.Text)
        ElseIf txtPname.Text = "Chocolate Butterscotch Cake" Then
            txtPtotalprice.Text = 12 * Val(txtPquan.Text)
        ElseIf txtPname.Text = "Red Bean Bun" Then
            txtPtotalprice.Text = 2.1 * Val(txtPquan.Text)
        ElseIf txtPname.Text = "Almond Kaya Bun" Then
            txtPtotalprice.Text = 3.5 * Val(txtPquan.Text)
        ElseIf txtPname.Text = "Breakfast Grilled Cheese Sandwich" Then
            txtPtotalprice.Text = 20 * Val(txtPquan.Text)
        ElseIf txtPname.Text = "Grilled Chicken Sandwich" Then
            txtPtotalprice.Text = 9 * Val(txtPquan.Text)
        End If
    End Sub

    Private Sub txtCname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCname.KeyPress
        Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz "
        If Not allowedchars.Contains(e.KeyChar.ToString.ToLower) Then
            MsgBox("Please enter a character!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtCemail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCemail.KeyPress
        Dim allowedchars As String = "abcdefghijklmnopqrstuvwxyz"
        Dim allowednos As String = "1234567890"
        Dim allowedsymbols As String = "@."
        If Not allowedchars.Contains(e.KeyChar.ToString) And Not allowednos.Contains(e.KeyChar.ToString) And Not allowedsymbols.Contains(e.KeyChar.ToString) Then
            MsgBox("Please enter a valid email!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtCphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCphone.KeyPress
        Dim allowednos As String = "1234567890"
        If Not allowednos.Contains(e.KeyChar.ToString) Then
            MsgBox("Please enter a number!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtPprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPprice.KeyPress
        Dim allowednos As String = "1234567890"
        If Not allowednos.Contains(e.KeyChar.ToString) Then
            MsgBox("Please enter a number!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Server=localhost;Database=tedboybakery;Uid=root;Pwd=''"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        disp_data()
    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM tblCustomer"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCname.Text = "" Then
            MsgBox("Please enter Customer Name!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf txtCemail.Text = "" Then
            MsgBox("Please enter Email!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf Not txtCemail.Text.Contains("@") Then
            MsgBox("Please enter a valid email address!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf Not txtCemail.Text.Contains(".") Then
            MsgBox("Please enter a valid email address!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf txtCphone.Text = "" Then
            MsgBox("Please enter Phone number!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf txtPname.Text = "" Then
            MsgBox("Please enter Product Name!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf txtPprice.Text = "" Then
            MsgBox("Please enter Product Price!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf txtPquan.Text = "" Then
            MsgBox("Please enter Product Quantity!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        ElseIf txtPtotalprice.Text = "" Then
            MsgBox("Please enter Product Total Price!!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Warning System")
        Else
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO tblCustomer VALUES(NULL,'" + txtCname.Text + "','" + txtCemail.Text +
                    "','" + txtCphone.Text + "','" + txtPname.Text + "','" + txtPprice.Text + "','" +
                    txtPquan.Text + "','" + txtPtotalprice.Text + "')"
            cmd.ExecuteNonQuery()

            txtCname.Text = ""
            txtCemail.Text = ""
            txtCphone.Text = ""
            txtPname.Text = ""
            txtPprice.Text = ""
            txtPquan.Text = ""
            txtPtotalprice.Text = ""

            disp_data()
            MessageBox.Show("Record Insert Successfully")
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        disp_data()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM tblCustomer WHERE Cname='" + txtCname.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        id = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM tblCustomer WHERE id=" & id & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            txtCname.Text = dr.GetString(1).ToString()
            txtCemail.Text = dr.GetString(2).ToString()
            txtCphone.Text = dr.GetString(3).ToString()
            txtPname.Text = dr.GetString(4).ToString()
            txtPprice.Text = dr.GetString(5).ToString()
            txtPquan.Text = dr.GetString(6).ToString()
            txtPtotalprice.Text = dr.GetString(7).ToString()
        End While
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE tblCustomer SET Cname='" + txtCname.Text + "',Cemail='" + txtCemail.Text + "',Cphone='" +
                txtCphone.Text + "',Pname='" + txtPname.Text + "',Pprice='" + txtPprice.Text + "',Pquan='" + txtPquan.Text +
                "',Ptotalprice='" + txtPtotalprice.Text + "' WHERE id=" & id & ""
            cmd.ExecuteNonQuery()

            txtCname.Text = ""
            txtCemail.Text = ""
            txtCphone.Text = ""
            txtPname.Text = ""
            txtPprice.Text = ""
            txtPquan.Text = ""
            txtPtotalprice.Text = ""

            disp_data()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM tblCustomer WHERE id=" & id & ""
            cmd.ExecuteNonQuery()

            txtCname.Text = ""
            txtCemail.Text = ""
            txtCphone.Text = ""
            txtPname.Text = ""
            txtPprice.Text = ""
            txtPquan.Text = ""
            txtPtotalprice.Text = ""

            disp_data()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub mnuTitle_Click(sender As Object, e As EventArgs) Handles mnuTitle.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class