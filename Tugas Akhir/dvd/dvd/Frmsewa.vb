Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Net
Public Class Frmsewa

    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim kode_sewa As String = txtkodesewa.Text
        Dim kode_dvd As String = txtkodedvd.Text
        Dim tanggal_sewa As String = tglsewa.Text
        Dim tanggal_kembali As String = tglkembali.Text
        Dim harga As String = txtharga.Text
        Dim nama_penyewa As String = txtpenyewa.Text

        Dim postData As String = $"kode_sewa={kode_sewa}&kode_dvd={kode_dvd}&tanggal_sewa={tanggal_sewa}&tanggal_kembali={tanggal_kembali}&harga={harga}&nama_penyewa={nama_penyewa}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(sewa_api, "POST", byteArray)

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
        Dim kode_sewa As String = txtkodesewa.Text
        Dim kode_dvd As String = txtkodedvd.Text
        Dim tanggal_sewa As String = tglsewa.Text
        Dim tanggal_kembali As String = tglkembali.Text
        Dim harga As String = txtharga.Text
        Dim nama_penyewa As String = txtpenyewa.Text

        Dim postData As String = $"kode_sewa={kode_sewa}&kode_dvd={kode_dvd}&tanggal_sewa={tanggal_sewa}&tanggal_kembali={tanggal_kembali}&harga={harga}&nama_penyewa={nama_penyewa}"


        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(sewa_api & "?kode_sewa=" & txtkodesewa.Text, "PUT", byteArray)

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
        Dim kode_sewa As String = txtkodesewa.Text
        Dim kode_dvd As String = txtkodedvd.Text
        Dim tanggal_sewa As String = tglsewa.Text
        Dim tanggal_kembali As String = tglkembali.Text
        Dim harga As String = txtharga.Text
        Dim nama_penyewa As String = txtpenyewa.Text

        Dim postData As String = $"kode_sewa={kode_sewa}&kode_dvd={kode_dvd}&tanggal_sewa={tanggal_sewa}&tanggal_kembali={tanggal_kembali}&harga={harga}&nama_penyewa={nama_penyewa}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(sewa_api & "?kode_sewa=" & txtkodesewa.Text, "DELETE", byteArray)

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

    Private Sub GetClear()
        txtkodesewa.Clear()
        txtkodedvd.Clear()
        txtjuduldvd.Clear()
        tglsewa.Clear()
        tglkembali.Clear()
        txtharga.Clear()
        txtpenyewa.Clear()
        Reloaded()
        ReloadedDvd()
        txtkodesewa.Focus()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(sewa_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Sewa) = JsonConvert.DeserializeObject(Of List(Of Sewa))(response)

        ' Bind the data to the DataGridView
        sewaData.DataSource = data
    End Sub

    Private Sub ReloadedDvd()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(dvd_api)

        ' Deserialize the JSON response into a list of objects
        Dim data2 As List(Of Dvd) = JsonConvert.DeserializeObject(Of List(Of Dvd))(response)

        ' Bind the data to the DataGridView
        dvdData.DataSource = data2
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(sewa_api & "?kode_sewa=" & txtkodesewa.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        sewa_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        sewa_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (sewa_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Sewa) = JsonConvert.DeserializeObject(Of List(Of Sewa))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Sewa In data
                            txtkodesewa.Text = mydata.kode_sewa
                            txtkodedvd.Text = mydata.kode_dvd
                            txtjuduldvd.Text = mydata.judul_dvd
                            tglsewa.Text = mydata.tanggal_sewa
                            tglkembali.Text = mydata.tanggal_kembali
                            txtharga.Text = mydata.harga
                            txtpenyewa.Text = mydata.nama_penyewa
                        Next
                    End If
                End Try
            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub

    Private Sub GetDvd()
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
                        Dim data As List(Of Dvd) = JsonConvert.DeserializeObject(Of List(Of Dvd))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata2 As Dvd In data
                            txtkodedvd.Text = mydata2.kode_dvd
                            txtjuduldvd.Text = mydata2.judul_dvd
                        Next
                    End If
                End Try
            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub

    Private Sub tglsewa_TextChanged(sender As Object, e As EventArgs) Handles tglsewa.TextChanged

    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        TambahData()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If (sewa_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub


    Private Sub cmbjudul_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_keydown(sender As Object, e As KeyEventArgs) Handles txtkodesewa.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub txt_keykodedvd(sender As Object, e As KeyEventArgs) Handles txtkodedvd.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetDvd()
        End If
    End Sub

    Private Sub Frmsewa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
        ReloadedDvd()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Frmdvd.Show()
        Me.Hide()
    End Sub

    Private Sub DataSewaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataDvdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDvdToolStripMenuItem.Click
        Frmdvd.Show()
        Me.Hide()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        UpdateData()
    End Sub
End Class