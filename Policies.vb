Public Class Policies
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Claims.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        New_Client.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        datagrid.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AgentProfile.Show()
        Me.Hide()
    End Sub



    Private Sub PoliciesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PoliciesBindingNavigatorSaveItem.Click, PoliciesBindingNavigatorSaveItem.Click, PoliciesBindingNavigatorSaveItem.Click, PoliciesBindingNavigatorSaveItem.Click, PoliciesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PoliciesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub

    Private Sub Policies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InsuranceDBDataSet.Policies' table. You can move, or remove it, as needed.
        Me.PoliciesTableAdapter.Fill(Me.InsuranceDBDataSet.Policies)
        'TODO: This line of code loads data into the 'InsuranceDBDataSet.Policies' table. You can move, or remove it, as needed.
        Me.PoliciesTableAdapter.Fill(Me.InsuranceDBDataSet.Policies)
        If ComboBox1.Text = Nothing Then
            Try
                PoliciesBindingSource.AddNew()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            PoliciesBindingSource.AddNew()
            Policy_CodeTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            PoliciesBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            PoliciesBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Select Case MsgBox("Are you sure you want to delete this client?", MsgBoxStyle.YesNo, "Are you sure")
            Case MsgBoxResult.Yes
                Try
                    PoliciesBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case MsgBoxResult.No
                ''nothing
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Me.Validate()
            Me.PoliciesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)
            Me.PoliciesTableAdapter.Fill(Me.InsuranceDBDataSet.Policies)
            MessageBox.Show("the data has been saved", "information", MessageBoxButtons.OK)
            PoliciesBindingSource.AddNew()
            Policy_CodeTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PoliciesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles PoliciesBindingNavigatorSaveItem.Click, PoliciesBindingNavigatorSaveItem.Click, PoliciesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PoliciesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub
End Class