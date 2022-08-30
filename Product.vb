Imports System.Data.OleDb
Public Class Product
    Dim con As New OleDb.OleDbConnection
    Dim dataset As New DataSet
    Dim query As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim cmd As New OleDbCommand
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Agro_Management_SystemDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.Agro_Management_SystemDataSet.Product)
        Me.ProductTableAdapter.Fill(Me.Agro_Management_SystemDataSet.Product)
        Try
            con = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Agro_Management_System.accdb")
            con.Open()
            sql = "SELECT * FROM Product"
            query = New OleDb.OleDbDataAdapter(sql, con)
            query.Fill(dataset, "Agro_Management_System")
            con.Close()
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try

    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dashboard.Show()
        If Dashboard.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        Report.Show()
    End Sub

    Private Sub btnManagementPractices_Click_1(sender As Object, e As EventArgs) Handles btnManagementPractices.Click
        ManagementPractices.Show()
        If ManagementPractices.Visible Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Staffs.Show()
        If Staffs.Visible Then
            Me.Hide()
        End If
    End Sub

    Public Sub Add()
        sql = "INSERT INTO Product([ProductID],[Name],[ScientificName],[Breed],[Category],[Quantity],[Date],[Department]) VALUES (?,?,?,?,?,?,?,?)"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.Add(New OleDbParameter("ProductID", CType(ProductIDTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name", CType(NameTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ScientificName", CType(ScientificNameTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Breed", CType(BreedTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Category", CType(CategoryTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Quantity", CType(QuantityTextBox.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date", CType(DateDateTimePicker.Text, Date)))
        cmd.Parameters.Add(New OleDbParameter("Department", CType(DepartmentTextBox.Text, String)))
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        con.Open()
        Try
            Call Add()
            MessageBox.Show("New Product added")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            Me.Close()
        Catch EXP As Exception
            MsgBox(EXP.Message)
        End Try
        con.Close()
    End Sub

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        sql = " UPDATE Product set [ProductID]='" & ProductIDTextBox.Text & "',[Name]='" & NameTextBox.Text & "', _ [ScientificName]='" & ScientificNameTextBox.Text & "',[Breed]='" & BreedTextBox.Text & "',[Category]='" & CategoryTextBox.Text & "',[Quantity]='" & QuantityTextBox.Text & "',[Date]='" & DateDateTimePicker.Text & "',[Department]='" & DepartmentTextBox.Text & "'"
        cmd = New OleDbCommand(sql, con)
        MsgBox("Product has been Updated")
        Me.ProductDataGridView.Refresh()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        sql = " DELETE FROM Product WHERE [ProductID]='" & ProductIDTextBox.Text & "'"
        cmd = New OleDbCommand(sql, con)
        MsgBox("Product Deleted")
        Me.ProductDataGridView.Refresh()
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        ProductIDTextBox.Text = ""
        NameTextBox.Text = ""
        ScientificNameTextBox.Text = ""
        BreedTextBox.Text = ""
        CategoryTextBox.Text = ""
        DateDateTimePicker.Text = ""
        QuantityTextBox.Text = ""
        DepartmentTextBox.Text = ""
    End Sub
End Class