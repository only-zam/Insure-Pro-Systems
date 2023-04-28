Public Class datagrid
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        New_Client.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Policies.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Claims.Show()
        Me.Hide()
    End Sub

    Private Sub datagrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InsuranceDBDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.InsuranceDBDataSet.Clients)
        'TODO: This line of code loads data into the 'InsuranceDBDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.InsuranceDBDataSet.Clients)
        'TODO: This line of code loads data into the 'Core_DatabaseDataSet.Client_data' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.InsuranceDBDataSet.Clients)
        'TODO: This line of code loads data into the 'INSURANCE_MANAGEMENT_SYSTEMDataSet.Insurance_management_system' table. You can move, or remove it, as needed.
        If ComboBox1.Text = Nothing Then
            Try
                ClientsBindingSource.AddNew()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AgentProfile.Show()
        Me.Hide()
    End Sub





    Private Sub ClientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub

    Private Sub ClientsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ClientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub
End Class