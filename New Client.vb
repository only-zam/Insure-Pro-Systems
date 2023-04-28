
Imports System.Data.OleDb
Imports System.IO



Public Class New_Client

    Dim Imgname As String
    Dim daImage As OleDbDataAdapter
    Dim dsImage As DataSet
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Show()
    End Sub

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
        AgentProfile.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Client_dataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub

    Private Sub Client_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InsuranceDBDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.InsuranceDBDataSet.Clients)
        'TODO: This line of code loads data into the 'InsuranceDBDataSet1.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.InsuranceDBDataSet.Clients)
        'TODO: This line of code loads data into the 'InsuranceDBDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.InsuranceDBDataSet.Clients)
        'TODO: This line of code loads data into the 'InsuranceDBDataSet.Clients' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.InsuranceDBDataSet.Clients)
        Me.WindowState = FormWindowState.Normal
        'TODO: This line of code loads data into the 'Core_DatabaseDataSet.Client_data' table. You can move, or remove it, as needed.
        Me.ClientsTableAdapter.Fill(Me.InsuranceDBDataSet.Clients)
        If ComboBox1.Text = Nothing Then
            Try
                ClientsBindingSource.AddNew()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            ClientsBindingSource.AddNew()
            First_NameTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If First_NameTextBox.Text = Nothing Then
            First_NameTextBox.Text = "Unknown"
        End If
        If Last_NameTextBox.Text = Nothing Then
            Last_NameTextBox.Text = "Unknown"
        End If
        If MobileTextBox.Text = Nothing Then
            MobileTextBox.Text = "Unknown"
        End If
        If AddressTextBox.Text = Nothing Then
            AddressTextBox.Text = "Unknown"
        End If
        If CityTextBox.Text = Nothing Then
            CityTextBox.Text = "Unknown"
        End If

        If Policy_valueTextBox.Text = Nothing Then
            Policy_valueTextBox.Text = "Unknown"
        End If
        If Policy_duration_months_TextBox.Text = Nothing Then
            Policy_duration_months_TextBox.Text = "Unknown"
        End If
        If Monthly_PremiumTextBox.Text = Nothing Then
            Monthly_PremiumTextBox.Text = "Unknown"
        End If
        If Amount_dueTextBox.Text = Nothing Then
            Amount_dueTextBox.Text = "Unknown"
        End If
        Try
            Me.Validate()
            Me.ClientsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)
            Me.ClientsTableAdapter.Fill(Me.InsuranceDBDataSet.Clients)
            MessageBox.Show("the data has been saved", "information", MessageBoxButtons.OK)
            ClientsBindingSource.AddNew()
            First_NameTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Select Case MsgBox("Are you sure you want to delete this client?", MsgBoxStyle.YesNo, "Are you sure")
            Case MsgBoxResult.Yes
                Try
                    ClientsBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case MsgBoxResult.No
                ''nothing
        End Select
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            ClientsBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            ClientsBindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub ClientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Try
            Dim dlgImage As FileDialog = New OpenFileDialog
            dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If dlgImage.ShowDialog() = DialogResult.OK Then
                Imgname = dlgImage.FileName

                Dim newimg As New Bitmap(Imgname)

                Client_photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                Client_photoPictureBox.Image = DirectCast(newimg, Image)
            End If

            dlgImage = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClientsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub

    Private Sub ClientsBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles ClientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub

    Private Sub ClientsBindingNavigatorSaveItem_Click_3(sender As Object, e As EventArgs) Handles ClientsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InsuranceDBDataSet)

    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            Dim dlgImage As FileDialog = New OpenFileDialog
            dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

            If dlgImage.ShowDialog() = DialogResult.OK Then
                Imgname = dlgImage.FileName

                Dim newimg As New Bitmap(Imgname)

                Client_photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
                Client_photoPictureBox.Image = DirectCast(newimg, Image)
            End If

            dlgImage = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim value As Integer
        Dim duration As Integer
        Dim premium As Integer
        value = Policy_valueTextBox.Text
        duration = Policy_duration_months_TextBox.Text
        premium = value / duration
        Monthly_premiumTextBox.Text = premium
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim premium As Integer
        Dim duration As Integer
        Dim premium_no As Integer
        Dim amountDUE As Integer
        premium = Monthly_premiumTextBox.Text
        duration = Policy_duration_months_TextBox.Text
        premium_no = Premium_NoTextBox.Text
        amountDUE = (duration - premium_no) * premium
        Amount_dueTextBox.Text = amountDUE

    End Sub
End Class