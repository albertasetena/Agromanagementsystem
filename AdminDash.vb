Imports System.Data.OleDb
Public Class AdminDashboard
    Dim conn As New OleDb.OleDbConnection
    Dim sql As String
    Dim cmd As New OleDbCommand
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Agro_Management_SystemDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter1.Fill(Me.Agro_Management_SystemDataSet.Staff)
        'TODO: This line of code loads data into the 'Agro_Management_SystemDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Agro_Management_SystemDataSet.Users)
        conn = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Agro_Management_System.accdb")
        conn.Open()
        conn.Close()
    End Sub
    Public Sub AddUser()
        sql = "INSERT INTO Users([Username],[Password],[Privilage]) VALUES (?,?,?)"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.Add(New OleDbParameter("Username", CType(txtusername.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtpassword.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Privilage", CType(txtPrivilage.Text, String)))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        txtusername.Text = ""
        txtpassword.Text = ""
        txtPrivilage.Text = ""
    End Sub

    Public Sub Add()
        sql = "INSERT INTO Staff([StaffID],[Fname],[Lname],[Gender],[DateOfBirth],[Email],[Address],[Tel],[Department]) VALUES (?,?,?,?,?,?,?,?,?)"
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.Add(New OleDbParameter("StaffID", CType(StaffIDTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Fname", CType(FnameTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Lname", CType(LnameTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(GenderTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DateOfBirth", CType(DateOfBirthDateTimePicker.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("Email", CType(EmailTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(AddressTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Tel", CType(TelTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Department", CType(DepartmentTextBox.Text, String)))
    End Sub

    Private Sub btnAddStaff_Click(ByVal sender As Object, ByVal e As EventArgs)
        conn.Open()
        Try
            Call Add()
            MessageBox.Show("New Staff added")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            Me.Close()
        Catch EXP As Exception
            MsgBox(EXP.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub btnAddus_Click(ByVal sender As Object, ByVal e As EventArgs)
        conn.Open()
        Try
            Call AddUser()
            MessageBox.Show("New User added")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
        Catch EXP As Exception
            MsgBox(EXP.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
        StaffIDTextBox.Text = ""
        FnameTextBox.Text = ""
        LnameTextBox.Text = ""
        GenderTextBox.Text = ""
        DateOfBirthDateTimePicker.Text = ""
        EmailTextBox.Text = ""
        AddressTextBox.Text = ""
        TelTextBox.Text = ""
        DepartmentTextBox.Text = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        sql = " DELETE FROM Staff WHERE [StaffID]='" & StaffIDTextBox.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        MsgBox("Staff Deleted")
        Me.StaffDataGridView.Refresh()
    End Sub

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        If Dashboard.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduct.Click
        Product.Show()
        If Product.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStaff.Click
        Staffs.Show()
        If Staffs.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnManagementPractices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManagementPractices.Click
        ManagementPractices.Show()
        If ManagementPractices.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnViewRecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewRecords.Click
        Report.Show()
    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        sql = " DELETE FROM Staff WHERE [StaffID]='" & StaffIDTextBox.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        MsgBox("Staff Deleted")
        Me.StaffDataGridView.Refresh()
    End Sub
End Class