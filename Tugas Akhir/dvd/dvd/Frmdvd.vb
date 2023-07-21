Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net
Public Class Frmdvd
    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim kode_dvd As String = txtkodedvd.Text
        Dim judul_dvd As String = txtjudul.Text
        Dim kategori_dvd As String = txtkategori.Text

        Dim postData As String = $"kode_dvd={kode_dvd}&judul_dvd={judul_dvd}&kategori_dvd={kategori_dvd}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(dvd_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim kode_dvd As String = txtkodedvd.Text
        Dim judul_dvd As String = txtjudul.Text
        Dim kategori_dvd As String = txtkategori.Text

        Dim postData As String = $"kode_dvd={kode_dvd}&judul_dvd={judul_dvd}&kategori_dvd={kategori_dvd}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(dvd_api & "?kode_dvd=" & txtkodedvd.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim kode_dvd As String = txtkodedvd.Text
        Dim judul_dvd As String = txtjudul.Text
        Dim kategori_dvd As String = txtkategori.Text

        Dim postData As String = $"kode_dvd={kode_dvd}&judul_dvd={judul_dvd}&kategori_dvd={kategori_dvd}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(dvd_api & "?kode_dvd=" & txtkodedvd.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(dvd_api & "?kode_dvd=" & txtkodedvd.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        dvd_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        dvd_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (dvd_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of dvd) = JsonConvert.DeserializeObject(Of List(Of dvd))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As dvd In data
                            txtkodedvd.Text = mydata.kode_dvd
                            txtjudul.Text = mydata.judul_dvd
                            txtkategori.Text = mydata.kategori_dvd
                        Next
                    End If
                End Try
            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub

    Private Sub GetClear()
        txtkodedvd.Clear()
        txtjudul.Clear()
        txtkategori.Clear()
        Reloaded()
        txtkodedvd.Focus()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(dvd_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of dvd) = JsonConvert.DeserializeObject(Of List(Of dvd))(response)

        ' Bind the data to the DataGridView
        dvdData.DataSource = data
    End Sub

    Private Sub Frmdvd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        TambahData()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If (dvd_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub txtkodedvd_TextChanged(sender As Object, e As EventArgs) Handles txtkodedvd.TextChanged

    End Sub

    Private Sub txt_keydown(sender As Object, e As KeyEventArgs) Handles txtkodedvd.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub DataDvdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDvdToolStripMenuItem.Click

    End Sub

    Private Sub DataSewaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSewaToolStripMenuItem.Click
        Frmsewa.Show()
        Me.Hide()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        UpdateData()
    End Sub
End Class
