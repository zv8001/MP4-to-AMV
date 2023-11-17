
Public Class MIT

    Dim OK = False
    Private Sub MIT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If OK = False Then
            Form1.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OK = True
        Me.Close()
    End Sub

    Private Sub MITLicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MITLicenseToolStripMenuItem.Click
        Try
            Process.Start("https://github.com/zv8001/MP4-to-AMV/blob/main/LICENSE")
        Catch ex As Exception
            Try
                Process.Start("C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", "https://github.com/zv8001/MP4-to-AMV/blob/main/LICENSE")
            Catch ex1 As Exception
            End Try
        End Try

    End Sub

    Private Sub MIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class