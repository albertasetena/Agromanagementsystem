Imports System.Data.OleDb
Public Class Staffs
    Dim conn As New OleDb.OleDbConnection
    Dim sql As String
    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader

    Private Sub Staffs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Agro_Management_SystemDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.Agro_Management_SystemDataSet.Staff)

    End Sub
    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        Product.Show()
        If Product.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnManagementPractices_Click(sender As Object, e As EventArgs) Handles btnManagementPractices.Click
        ManagementPractices.Show()
        If ManagementPractices.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        If Dashboard.Visible Then
            Me.Hide()
        End If
    End Sub
End Class