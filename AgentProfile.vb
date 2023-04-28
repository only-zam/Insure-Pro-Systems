
Imports System.Data.OleDb
Imports System.IO



Public Class AgentProfile

    Dim Imgname As String
    Dim daImage As OleDbDataAdapter
    Dim dsImage As DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        datagrid.Show()
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Show()
    End Sub

    Private Sub Agent_profilesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Agent_profilesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub

    Private Sub AgentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InsuranceDBDataSet.Agent_profiles' table. You can move, or remove it, as needed.
        Me.Agent_profilesTableAdapter.Fill(Me.InsuranceDBDataSet.Agent_profiles)
        'TODO: This line of code loads data into the 'InsuranceDBDataSet.Clients' table. You can move, or remove it, as needed.
        Me.Agent_profilesTableAdapter.Fill(Me.InsuranceDBDataSet.Agent_profiles)
        'TODO: This line of code loads data into the 'InsuranceDBDataSet.Agent_profiles' table. You can move, or remove it, as needed.
        Me.Agent_profilesTableAdapter.Fill(Me.InsuranceDBDataSet.Agent_profiles)
        If ComboBox1.Text = Nothing Then
            Try
                Agent_profilesBindingSource.AddNew()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Agent_profilesBindingSource.AddNew()
            First_NameTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Agent_CodeTextBox.Text = Nothing Then
            Agent_CodeTextBox.Text = "Unknown"
        End If
        If First_NameTextBox.Text = Nothing Then
            First_NameTextBox.Text = "Unknown"
        End If
        If Last_NameTextBox.Text = Nothing Then
            Last_NameTextBox.Text = "Unknown"
        End If
        If LocationTextBox.Text = Nothing Then
            LocationTextBox.Text = "Unknown"
        End If
        If Agent_addressTextBox.Text = Nothing Then
            Agent_addressTextBox.Text = "Unknown"
        End If
        If LocationTextBox.Text = Nothing Then
            LocationTextBox.Text = "Unknown"
        End If
        If Agent_MobileTextBox.Text = Nothing Then
            Agent_MobileTextBox.Text = "Unknown"
        End If
        If Agent_statusTextBox.Text = Nothing Then
            Agent_statusTextBox.Text = "Unknown"
        End If
        If About_agentTextBox.Text = Nothing Then
            About_agentTextBox.Text = "Nothing to show"
        End If
        Try
            Me.Validate()
            Me.Agent_profilesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)
            Me.Agent_profilesTableAdapter.Fill(Me.InsuranceDBDataSet.Agent_profiles)
            MessageBox.Show("the data has been saved", "information", MessageBoxButtons.OK)
            Agent_profilesBindingSource.AddNew()
            Agent_CodeTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Select Case MsgBox("Are you sure you want to delete this client?", MsgBoxStyle.YesNo, "Are you sure")
            Case MsgBoxResult.Yes
                Try
                    Agent_profilesBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case MsgBoxResult.No
                ''nothing
        End Select
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            Agent_profilesBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Agent_profilesBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ClientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Agent_profilesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub

    Private Sub Agent_profilesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Agent_profilesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Agent_profilesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            Dim dlgImage As FileDialog = New OpenFileDialog
            dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If dlgImage.ShowDialog() = DialogResult.OK Then
                Imgname = dlgImage.FileName

                Dim newimg As New Bitmap(Imgname)

                Agent_photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                Agent_photoPictureBox.Image = DirectCast(newimg, Image)
            End If

            dlgImage = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        New_Client.Show()
        Me.Hide()
    End Sub
End Class