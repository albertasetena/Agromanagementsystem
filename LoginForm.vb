Imports System.Data.OleDb
Public Class LoginForm
    Dim un As String = ""
    Dim ps As String
    Dim username As String = ""
    Dim password As String
    Dim sql As String
    Dim dataset As DataSet
    Dim adapter As OleDbDataAdapter
    Dim connection As New OleDbConnection
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Agro_Management_System.accdb")

    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        If txtusername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter credidentials")
        Else

            DataSet = New DataSet
            sql = "select * from Users where Username= '" & txtusername.Text & "'and Password ='" & txtPassword.Text & "';"
            adapter = New OleDbDataAdapter(sql, connection)
            adapter.Fill(DataSet, "Users")
            connection.Open()
            If DataSet.Tables("Users").Rows.Count > 0 Then
                MsgBox("Login successfully")
                Dashboard.Show()
                If Dashboard.Visible Then
                    Me.Hide()
                End If
            Else
                MsgBox("Login Failed, Incorrect credentials")
                txtusername.Clear()
                txtPassword.Clear()
            End If
            connection.Close()
        End If

    End Sub
End Class