Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Security.Cryptography
Imports System.Net.WebRequestMethods
Imports System.Diagnostics
Imports System.Reflection.Emit
Imports System.Text

Public Class Form1

    Dim Time As Integer = 1
    Dim args As Boolean = False
    Dim MainIn As Integer = 0
    Dim FullProRUnCalc = 0
    Dim MaininstanceCount = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\ffmpeg.dll") Then

            Dim result As DialogResult = MessageBox.Show("FFMPEG.DLL NOT FOUND. Do you want to download ffmpeg.dll?", "mp4toamv https://www.zv800.com", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    My.Computer.Network.DownloadFile("https://mp4toamv.netlify.app/mp4toamv/bin/Debug/net6.0-windows/ffmpeg.dll",
                               Application.StartupPath & "\ffmpeg.dll", "", "", True, 500, True)
                Catch ex As Exception
                    MsgBox("error My.Computer.Network.DownloadFile line 26", 16 + 0)
                    ListBox1.Items.Add("ERR: ffmpeg.dll not found")
                    Status("ERR: ffmpeg.dll not found", 2)
                    Timer1.Enabled = False
                    Button1.Enabled = False
                End Try
            ElseIf result = DialogResult.No Then
                ListBox1.Items.Add("ERR: ffmpeg.dll not found")
                Status("ERR: ffmpeg.dll not found", 2)
                Timer1.Enabled = False
                Button1.Enabled = False
            End If
        Else
            Threading.Thread.Sleep(300)
            ListBox1.Items.Add("OK: ffmpeg.dll found")
            Status("OK: ffmpeg.dll found", 0)
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



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckBox2.Checked = False Then
            If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
                TextBox1.Text = FolderBrowserDialog1.SelectedPath

            End If
        Else
            OpenFileDialog1.Title = "Please select a mp4 file"
            OpenFileDialog1.InitialDirectory = "C:\"
            OpenFileDialog1.Filter = "mp4 Files|*.mp4"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then


                TextBox1.Text = OpenFileDialog1.FileName
            End If
        End If
    End Sub
    Dim safkj As String
    Dim sdfihul As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Time = 0
        If CheckBox2.Checked = True Then

            If TextBox2.Text = "" Then
                MsgBox("ERROR: Selcect an output file", 16 + 0, "mp4toamv https://www.zv800.com")
            Else
                ListBox1.Items.Add("calculating... ")
                Status("Calculating..", 1)
                If My.Computer.FileSystem.FileExists(TextBox2.Text) Then
                    Status("Removeing: " & TextBox2.Text, 1)
                    ListBox1.Items.Add("Removeing: " & TextBox2.Text)
                    Try
                        My.Computer.FileSystem.DeleteFile(TextBox2.Text)
                    Catch ex As Exception

                    End Try

                End If
                Status("Starting... " & TextBox1.Text, 1)
                ListBox1.Items.Add("Starting... " & TextBox1.Text)

                If args = True Then
                    MyUtilities.RunCommandCom("ffmpeg.dll -i """ & TextBox1.Text & """ " & TextBox3.Text & " """ & SaveFileDialog1.FileName & """", "/W", False, True)
                Else
                    MyUtilities.RunCommandCom("ffmpeg.dll -i """ & TextBox1.Text & """ -c:v amv -c:a adpcm_ima_amv -pix_fmt yuvj420p -vstrict -1 -s 160x120 -ac 1 -ar 22050 -r 25 -block_size 882 """ & SaveFileDialog1.FileName & """", "/W", False, True)
                End If

                Threading.Thread.Sleep(3000)
                Timer1.Start()
            End If
        Else
            Button1.Enabled = False
            Button2.Enabled = True
            Dim di As New DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            Dim fiArr As FileInfo() = di.GetFiles()
            Dim fri As FileInfo

            ListBox1.Items.Add("Starting... " & FolderBrowserDialog1.SelectedPath)
            ListBox1.Items.Add("calculating... ")
            For Each fri In fiArr
                Wait(0.5)
                Status("Calculating: " & fri.FullName, 2)
                ListBox1.Items.Add("Calculating: " & fri.FullName)
                FullProRUnCalc = FullProRUnCalc + 1
            Next fri
            FullProRUnCalc = FullProRUnCalc * 2
            Status(FullProRUnCalc & " processes needed", 2)
            ListBox1.Items.Add("Starting")

            Dim files As Integer = 0

            Timer1.Start()
            For Each fri In fiArr
                Try

                    Button1.Enabled = False
                    Button2.Enabled = True
                    ListBox1.Items.Add("Checking if " & FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv Exists")

                    If My.Computer.FileSystem.FileExists(FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv") Then
                        ListBox1.Items.Add("Deleteing: " & FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv")

                        My.Computer.FileSystem.DeleteFile(FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv")
                    End If
                    Status("Starting FFMPEG.EXE", 0)
                    ListBox1.Items.Add("Starting FFMPEG.EXE")
                    If args = True Then
                        ListBox1.Items.Add("Useing Args (MODED): " & "ffmpeg.dll -i """ & fri.FullName & """" & TextBox3.Text & """" & FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv""")
                    Else
                        ListBox1.Items.Add("Useing Args: " & "ffmpeg.dll -i """ & fri.FullName & """ -c:v amv -c:a adpcm_ima_amv -pix_fmt yuvj420p -vstrict -1 -s 160x120 -ac 1 -ar 22050 -r 25 -block_size 882 """ & FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv""")
                    End If
                    ListBox1.Items.Add("Converting: """ & fri.FullName & """ >>>Useing ffmpeg<<<")
                    If args = True Then
                        MyUtilities.RunCommandCom("ffmpeg.dll -i """ & fri.FullName & """ " & TextBox3.Text & " """ & FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv""", "/W", False, True)
                    Else

                        MyUtilities.RunCommandCom("ffmpeg.dll -i """ & fri.FullName & """ -c:v amv -c:a adpcm_ima_amv -pix_fmt yuvj420p -vstrict -1 -s 160x120 -ac 1 -ar 22050 -r 25 -block_size 882 """ & FolderBrowserDialog1.SelectedPath & "\mp4toamv_output\" & fri.Name & ".amv""", "/W", False, True)
                    End If
                    If CheckBox1.Checked = True Then
                        'While Process.GetProcessesByName("ffmpeg.dll").Count() > 5
                        'Wait
                        '   End While
                    End If

                Catch ex As Exception

                End Try
            Next fri

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        TextBox1.Text = ""
        Dim FileNameBackup
        If CheckBox2.Checked = False Then

            TextBox2.Text = ""
            Button4.Enabled = False
        Else

            Try
                TextBox2.Text = FileNameBackup
            Catch ex As Exception
            End Try
            FileNameBackup = TextBox2.Text
            Button4.Enabled = True

        End If
    End Sub
    Dim lastintc As Integer
    Dim cpu As New PerformanceCounter()
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timeer.Start()
        'SET THE PERFORMANCE VALUE OF THE RAM AND CPU TO THE PROGESSBAR



        Dim instanceCount As Integer = Process.GetProcessesByName("ffmpeg.dll").Count()
        MaininstanceCount = instanceCount
        ' MsgBox(instanceCount)
        Label2.Text = String.Format("{0} Instances Running (FFMPEG)", instanceCount.ToString())
        Dim instanceCount2 As Integer = Process.GetProcessesByName("conhost").Count()
        Label3.Text = String.Format("{0} Instances (conhost)", instanceCount2.ToString())
        Dim instanceCount3 As Integer = Process.GetProcessesByName("cmd").Count()
        Label4.Text = String.Format("{0} Instances (cmd.exe)", instanceCount3.ToString())
        Label5.Text = instanceCount + instanceCount2 + instanceCount3 & " Instances"
        If instanceCount = 0 Then
            ProgressBar1.Value = 0
            Button1.Enabled = True
            Button2.Enabled = False
            If Time < 30 Then
                ListBox1.Items.Add("ERR: FFMPEG Crash (small files may cause a false Crash msg)")
                Status("ERR: FFMPEG Crash (small files may cause a false Crash msg)", 2)
            Else
                ListBox1.Items.Add("OK: Prosses Finished")
                Status("OK: Prosses Finished", 0)
            End If

            lastintc = 0
            instanceCount = 0
            instanceCount2 = 0
            instanceCount3 = 0
            MainIn = 0
            FullProRUnCalc = 0
            Process.Start("taskkill.exe", "/im ffmpeg.dll /t /f")
            Timeer.Stop()
            Timer1.Stop()
        End If
        If instanceCount > lastintc Then
            MainIn = instanceCount
            ProgressBar1.Maximum = MainIn

        End If
        If instanceCount < MainIn And instanceCount < lastintc Then
            If Not ProgressBar1.Value = ProgressBar1.Maximum And Not ProgressBar1.Value = instanceCount Then
                Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

                Dim sb As New StringBuilder()
                Dim rand As New Random()
                For i As Integer = 1 To 10
                    Dim idx As Integer = rand.Next(0, validchars.Length)
                    Dim randomChar As Char = validchars(idx)
                    sb.Append(randomChar)
                Next i
                Dim randomString = sb.ToString()
                ListBox1.Items.Add("Finished converting: File\" & randomString) 'Random String so thay done all look the same.
                Status("Finished converting: File\" & randomString, 0)
                Try
                    ProgressBar1.Value = ProgressBar1.Value + 1
                Catch ex As Exception

                End Try
                If ProgressBar1.Value = ProgressBar1.Maximum Then
                    Button1.Enabled = True
                    Button2.Enabled = False
                End If
            End If
        End If
        lastintc = instanceCount
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveFileDialog1.Filter = "amv Files (*.amv*)|*.amv"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            TextBox2.Text = SaveFileDialog1.FileName

        End If
    End Sub

    Private Sub MFS_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles MFS.DoWork

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Process.Start("taskkill.exe", "/im ffmpeg.dll /t /f")
        ProgressBar1.Value = 0
        Button1.Enabled = True
        Button2.Enabled = False
        ListBox1.Items.Add("ERR: Prosses stoped by user")
        Status("ERR: Prosses stoped by user", 2)
    End Sub
    Function Status(Text1 As String, stat As Integer)
        LBR_STAT.Text = Text1
        If stat = 1 Then
            LBR_STAT.ForeColor = Color.Goldenrod
        ElseIf stat = 2 Then
            LBR_STAT.ForeColor = Color.Red
        ElseIf stat = 0 Then
            LBR_STAT.ForeColor = Color.Green
        End If

    End Function
    Private Sub Wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            Me.ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex + 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
        Process.Start("taskkill.exe", "/im ffmpeg.dll /t /f")
        ProgressBar1.Value = 0
        Button1.Enabled = True
        Button2.Enabled = False
        ListBox1.Items.Add("ERR: Prosses stoped by user")
        Status("ERR: Prosses stoped by user", 2)

    End Sub

    Private Sub Github_BTN_Click(sender As Object, e As EventArgs) Handles Github_BTN.Click
        Try
            Process.Start("https://github.com/zv8001/MP4-to-AMV")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Dim result As DialogResult = MessageBox.Show("WARNING: Do not mess with this setting unless you know what you are doing and know how to use ffmpeg. Do you still want to change this?", "mp4toamv https://www.zv800.com", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                args = True
                TextBox3.ReadOnly = False
                TextBox3.Text = "-c:v amv -c:a adpcm_ima_amv -pix_fmt yuvj420p -vstrict -1 -s 160x120 -ac 1 -ar 22050 -r 25 -block_size 882"
                CheckBox3.Checked = True
            ElseIf result = DialogResult.No Then
                args = False
                TextBox3.ReadOnly = True
                TextBox3.Text = ""
                CheckBox3.Checked = False
            End If
        Else
            TextBox3.ReadOnly = True
            args = False
            TextBox3.Text = ""
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub Timeer_Tick(sender As Object, e As EventArgs) Handles Timeer.Tick
        Time = Time + 1
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
