Imports mp4toamv.Form1

Public Class Working
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Working_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function CON(in1, out1)
        MyUtilities.RunCommandCom("ffmpeg.dll -i """ & in1 & """ -c:v amv -c:a adpcm_ima_amv -pix_fmt yuvj420p -vstrict -1 -s 160x120 -ac 1 -ar 22050 -r 25 -block_size 882 """ & out1 & """", "/W", True, False)
        Return 0
    End Function
End Class