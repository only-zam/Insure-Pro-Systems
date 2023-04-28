Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.User = TextBox1.Text
        My.Settings.Pass = TextBox2.Text
        My.Settings.Save()
        MsgBox("create account", MsgBoxStyle.Information, "create")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class