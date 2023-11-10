Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Made by zv800 © 2023 freeware tool. (works with mp3 players)", 64 + 0, "mp4toamv https://www.zv800.com")
        OpenFileDialog1.Title = "Please select a mp4 file"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "mp4 Files|*.mp4"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            SaveFileDialog1.Filter = "amv Files (*.amv*)|*.amv"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
       Then
                MsgBox("Do not close the command window untill it is done.", 64 + 0, "mp4toamv https://www.zv800.com")
                MyUtilities.RunCommandCom("ffmpeg.dll -i """ & OpenFileDialog1.FileName & """ -c:v amv -c:a adpcm_ima_amv -pix_fmt yuvj420p -vstrict -1 -s 160x120 -ac 1 -ar 22050 -r 25 -block_size 882 """ & SaveFileDialog1.FileName & """", "/W", True)
                Me.Close()
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub
    Public Class MyUtilities
        Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command
            pi.FileName = "cmd.exe"
            p.StartInfo = pi
            p.Start()
        End Sub
    End Class

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class
