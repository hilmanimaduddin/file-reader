Imports System.IO

Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ' Membuat dialog pemilihan file
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Menampilkan jalur file yang dipilih di TextBox
            txtFilePath.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
        ' Membaca dan menampilkan isi file teks di ListBox
        Dim filePath As String = txtFilePath.Text
        If File.Exists(filePath) Then
            Dim lines() As String = File.ReadAllLines(filePath)
            lstFileContent.Items.Clear()
            For Each line As String In lines
                lstFileContent.Items.Add(line)
            Next
        Else
            MessageBox.Show("File tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClearListBox_Click(sender As Object, e As EventArgs) Handles btnClearListBox.Click
        ' Menghapus semua item dari ListBox
        lstFileContent.Items.Clear()
        MessageBox.Show("ListBox telah dikosongkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
