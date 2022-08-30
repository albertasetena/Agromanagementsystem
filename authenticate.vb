Imports System.Data.OleDb
Public Class authenticate
    Dim sql As String
    Dim dataset As DataSet
    Dim adapter As OleDbDataAdapter
    Dim connection As New OleDbConnection
    Private Sub authenticate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Agro_Management_System.accdb")
    End Sub
    Private Sub btnAuthenticate_Click(sender As Object, e As EventArgs) Handles btnAuthenticate.Click
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Enter credidentials")
        Else
            dataset = New DataSet
            sql = "select * from Users where Username= '" & txtusername.Text & "'and Password ='" & txtPassword.Text & " 'and Privilage ='Administrator';"
            adapter = New OleDbDataAdapter(sql, connection)
            adapter.Fill(dataset, "Users")
            connection.Open()
            If dataset.Tables("Users").Rows.Count > 0 Then
                MsgBox("Authenticated")
                AdminDashboard.Show()
                If AdminDashboard.Visible Then
                    Me.Hide()
                End If
            Else
                MsgBox("Authentication Failed, please input admin credentials again")
                txtusername.Clear()
                txtpassword.Clear()
            End If
            connection.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class