Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=localhost;userid=root;password=;database=vbnet"
        con.Open()
        MsgBox("Database is now open")
        con.Close()
        MsgBox("Database is now Closed")
        disp_data()
    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM table1"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO table1 VALUES(NULL,'" + TextBox1.Text + "','" + TextBox2.Text +
            "','" + TextBox3.Text + "')"
        cmd.ExecuteNonQuery()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        disp_data()
        MessageBox.Show("Record Insert Successfully")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        disp_data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM table1 WHERE firstname='" + TextBox1.Text + "'"
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
        Try
            id = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM table1 WHERE id=" & id & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            TextBox1.Text = dr.GetString(1).ToString()
            TextBox2.Text = dr.GetString(2).ToString()
            TextBox3.Text = dr.GetString(3).ToString()
            End While

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE table1 SET firstname='" + TextBox1.Text + "',lastname='" +
                TextBox2.Text + "',city='" + TextBox3.Text + "' WHERE id=" & id & ""
            cmd.ExecuteNonQuery()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

            disp_data()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM table1 WHERE id=" & id & ""
            cmd.ExecuteNonQuery()

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""

            disp_data()

        Catch ex As Exception

        End Try
    End Sub
End Class
