Imports System.Net.NetworkInformation
Public Class Form1
    Private Sub btnCheckInternt_Click(sender As Object, e As EventArgs) Handles btnCheckInternt.Click
        If NetworkInterface.GetIsNetworkAvailable() Then
            MessageBox.Show("Internet Connection is available", "Check Internet Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No Internet Connection", "Check Internet Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
