Imports System.Data.OleDb
Public Class Dashboard
    Dim con As New OleDb.OleDbConnection
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql1 As String
    Dim sql2 As String
    Dim sql3 As String
    Dim sql4 As String
    Dim un As String = ""
    Dim ps As String
    Dim username As String = ""
    Dim password As String
    Dim sql As String
    Dim dataset As DataSet
    Dim adapter As OleDbDataAdapter
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Staffs.Show()
        If Staffs.Visible Then
            Me.Hide()
        End If
    End Sub
    Private Sub userspb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        authenticate.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Agro_Management_System.accdb")
        sql1 = "SELECT ID FROM Staff WHERE ID = (select max (ID) FROM Staff)"

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd1 As New OleDbCommand(sql1, con)
        Dim reader = cmd1.ExecuteReader
        reader.Read()
        lblStaffNumber.Text = reader("ID")
        con.Close()

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql2 = "SELECT ID FROM Product WHERE ID = (select max (ID) FROM Product)"
        Dim cmd2 As New OleDbCommand(sql2, con)
        Dim reader2 = cmd2.ExecuteReader
        reader2.Read()
        lblProduct.Text = reader2("ID")
        con.Close()

        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        sql3 = "SELECT ID FROM MngmentPractices WHERE ID = (select max (ID) FROM MngmentPractices)"
        Dim cmd3 As New OleDbCommand(sql3, con)
        Dim reader3 = cmd3.ExecuteReader
        reader3.Read()
        lblMngmentPr.Text = reader3("ID")
        con.Close()

        If con.State = ConnectionState.Closed Then
            con.Open()

        End If
        sql4 = "SELECT ID FROM Users WHERE ID = (select max (ID) FROM Users)"
        Dim cmd4 As New OleDbCommand(sql4, con)
        Dim reader4 = cmd4.ExecuteReader
        reader4.Read()
        lblUsers.Text = reader4("ID")
        con.Close()
    End Sub

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs)
        Report.Show()

    End Sub


    Private Sub btnProduct_Click_1(sender As Object, e As EventArgs) Handles btnProduct.Click
        Product.Show()
        If Product.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnStaff_Click_1(sender As Object, e As EventArgs) Handles btnStaff.Click
        Staffs.Show()
        If Staffs.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnManagementPractices_Click_1(sender As Object, e As EventArgs) Handles btnManagementPractices.Click
        ManagementPractices.Show()
        If ManagementPractices.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnViewRecords_Click_1(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        Report.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        ManagementPractices.Show()
        If ManagementPractices.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Staffs.Show()
        If Staffs.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Product.Show()
        If Product.Visible Then
            Me.Hide()
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        authenticate.Show()
    End Sub

    Private Sub userspb_Click_1(sender As Object, e As EventArgs) Handles userspb.Click
        authenticate.Show()
    End Sub
End Class
