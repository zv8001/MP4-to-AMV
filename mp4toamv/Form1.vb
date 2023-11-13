Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Made by zv800 © 2023 freeware tool. (works with mp3 players)", 64 + 0, "mp4toamv https://www.zv800.com")
        Dim ask As MsgBoxResult = MsgBox("Do you convert an entire directory?", MsgBoxStyle.YesNo)
        MsgBox("A lot of videos may increase CPU usage", 48 + 0, "mp4toamv https://www.zv800.com")
        If ask = MsgBoxResult.Yes Then
            If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
                If Not System.IO.Directory.Exists(FolderBrowserDialog1.SelectedPath & "\mp4toamv_output") Then
                    System.IO.Directory.CreateDirectory(FolderBrowserDialog1.SelectedPath & "\mp4toamv_output")
                End If
                Dim di As New DirectoryInfo(FolderBrowserDialog1.SelectedPath)
                Dim fiArr As FileInfo() = di.GetFiles()
                Dim fri As FileInfo

                For Each fri In fiArr
                    Try
                        If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv") Then
                            My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv")
                        End If
                        MyUtilities.RunCommandCom("ffmpeg.dll -i """ & fri.FullName & """ -c:v amv -c:a adpcm_ima_amv -pix_fmt yuvj420p -vstrict -1 -s 160x120 -ac 1 -ar 22050 -r 25 -block_size 882 """ & FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv""", "/W", False, True)
                    Catch ex As Exception

                    End Try
                Next fri
            End If
        End If
        OpenFileDialog1.Title = "Please select a mp4 file"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "mp4 Files|*.mp4"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            SaveFileDialog1.Filter = "amv Files (*.amv*)|*.amv"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
       Then
                MsgBox("Do not close the command window untill it is done.", 64 + 0, "mp4toamv https://www.zv800.com")
                MyUtilities.RunCommandCom("ffmpeg.dll -i """ & OpenFileDialog1.FileName & """ -c:v amv -c:a adpcm_ima_amv -pix_fmt yuvj420p -vstrict -1 -s 160x120 -ac 1 -ar 22050 -r 25 -block_size 882 """ & SaveFileDialog1.FileName & """", "/W", True, False)
                Me.Close()
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
    Public Class MyUtilities
        Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean, invis As Boolean)
            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command
            pi.FileName = "cmd.exe"
            If invis = True Then
                pi.WindowStyle = ProcessWindowStyle.Hidden
                pi.CreateNoWindow = True
                pi.UseShellExecute = False
            End If
            p.StartInfo = pi
            p.Start()
        End Sub
    End Class
End Class
