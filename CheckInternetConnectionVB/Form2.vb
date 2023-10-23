Imports System.Net.NetworkInformation
Public Class Form2
    Private Sub btnCheckInternt_Click(sender As Object, e As EventArgs) Handles btnCheckInternt.Click
        CheckConnection()
    End Sub

    Private Sub CheckConnection()
        If NetworkInterface.GetIsNetworkAvailable() Then
            MessageBox.Show("Internet Connection is available", "Check Internet Connection in VB.NET", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No Internet Connection available", "Check Internet Connection in VB.NET", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class