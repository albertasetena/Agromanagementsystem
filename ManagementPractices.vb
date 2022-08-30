Imports System.Data.OleDb
Public Class ManagementPractices
    Dim conn As New OleDb.OleDbConnection
    Dim sql As String
    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader
    Private Sub ManagementPractices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Agro_Management_SystemDataSet.MngmentPractices' table. You can move, or remove it, as needed.
        Me.MngmentPracticesTableAdapter.Fill(Me.Agro_Management_SystemDataSet.MngmentPractices)

    End Sub

    Private Sub btnDashboard_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        If Dashboard.Visible Then
            Me.Hide()
        End If
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

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        Report.Show()
    End Sub

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Try
            Me.Validate()
            Me.MngmentPracticesBindingSource.EndEdit()
            Me.MngmentPrTableAdapterManager.UpdateAll(Me.Agro_Management_SystemDataSet)
            MessageBox.Show("Staff Updated")
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try
    End Sub

    Public Sub Add()
        sql = "INSERT INTO MngmentPractices([Crops],[Livestock]) VALUES (?,?)"
        cmd = New OleDbCommand(Sql, conn)
        cmd.Parameters.Add(New OleDbParameter("Crops", CType(CropsTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Livestock", CType(LiveStockTextBox.Text, String)))
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        conn.Open()
        Try
            Call Add()
            MessageBox.Show("New Practice added")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            Me.Close()
        Catch EXP As Exception
            MsgBox(EXP.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        IdTextBox.Text = ""
        CropsTextBox.Text = ""
        LiveStockTextBox.Text = ""
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        sql = " DELETE FROM MngmentPractices WHERE [Id]='" & IdTextBox.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        MsgBox("Practice Deleted")
        Me.DataGridView1.Refresh()
    End Sub
End Class