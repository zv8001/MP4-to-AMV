<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        Label2 = New Label()
        ProgressBar1 = New ProgressBar()
        LBR_STAT = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Button4 = New Button()
        TextBox2 = New TextBox()
        CheckBox2 = New CheckBox()
        Button3 = New Button()
        TextBox1 = New TextBox()
        ListBox1 = New ListBox()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        TabPage3 = New TabPage()
        GroupBox5 = New GroupBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        Label17 = New Label()
        RichTextBox2 = New RichTextBox()
        LinkLabel3 = New LinkLabel()
        TextBox3 = New TextBox()
        CheckBox3 = New CheckBox()
        Label15 = New Label()
        CheckBox5 = New CheckBox()
        Label14 = New Label()
        ffmpegpath_txt = New TextBox()
        Label13 = New Label()
        Button5 = New Button()
        GroupBox4 = New GroupBox()
        CheckBox6 = New CheckBox()
        Label16 = New Label()
        TextBox4 = New TextBox()
        Label12 = New Label()
        ComboBox1 = New ComboBox()
        CheckBox4 = New CheckBox()
        Label11 = New Label()
        TabPage4 = New TabPage()
        TabControl2 = New TabControl()
        TabPage5 = New TabPage()
        ListBox2 = New ListBox()
        TabPage6 = New TabPage()
        RichTextBox3 = New RichTextBox()
        TabPage2 = New TabPage()
        GroupBox3 = New GroupBox()
        LinkLabel2 = New LinkLabel()
        RichTextBox1 = New RichTextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        LinkLabel1 = New LinkLabel()
        Label7 = New Label()
        Github_BTN = New Button()
        Timer1 = New Timer(components)
        MFS = New ComponentModel.BackgroundWorker()
        Timer2 = New Timer(components)
        GroupBox2 = New GroupBox()
        Timeer = New Timer(components)
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        DarkModeToolStripMenuItem = New ToolStripMenuItem()
        RunToolStripMenuItem = New ToolStripMenuItem()
        StartToolStripMenuItem = New ToolStripMenuItem()
        StopToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        FFMPEGToolStripMenuItem = New ToolStripMenuItem()
        MP4ToAmvToolStripMenuItem = New ToolStripMenuItem()
        Fullffmpegcmddechtime = New Timer(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        TabPage4.SuspendLayout()
        TabControl2.SuspendLayout()
        TabPage5.SuspendLayout()
        TabPage6.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' BackgroundWorker1
        ' 
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 29)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(456, 509)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Transparent
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(Button4)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(CheckBox2)
        TabPage1.Controls.Add(Button3)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(ListBox1)
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(CheckBox1)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(448, 476)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Converter"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(ProgressBar1)
        GroupBox1.Controls.Add(LBR_STAT)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(6, 307)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(435, 174)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        GroupBox1.Text = "Status"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(12, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 15)
        Label6.TabIndex = 17
        Label6.Text = "------------------------------"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 17)
        Label2.TabIndex = 10
        Label2.Text = "{0} Instances Running"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.ForeColor = Color.CornflowerBlue
        ProgressBar1.Location = New Point(12, 136)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(390, 21)
        ProgressBar1.TabIndex = 12
        ' 
        ' LBR_STAT
        ' 
        LBR_STAT.AutoSize = True
        LBR_STAT.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        LBR_STAT.ForeColor = Color.Green
        LBR_STAT.Location = New Point(12, 116)
        LBR_STAT.Name = "LBR_STAT"
        LBR_STAT.Size = New Size(144, 17)
        LBR_STAT.TabIndex = 16
        LBR_STAT.Text = "Checking for ffmpeg.dll"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(212, 17)
        Label3.TabIndex = 11
        Label3.Text = "{0} Instances Running (conhost.exe)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 83)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 17)
        Label5.TabIndex = 14
        Label5.Text = "{0} All Processes"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 17)
        Label4.TabIndex = 13
        Label4.Text = "{0} Instances Running (cmd.exe)"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(384, 247)
        Button4.Name = "Button4"
        Button4.Size = New Size(58, 29)
        Button4.TabIndex = 9
        Button4.Text = "..."
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(7, 247)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Save File Path"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(371, 27)
        TextBox2.TabIndex = 8
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Checked = True
        CheckBox2.CheckState = CheckState.Checked
        CheckBox2.Location = New Point(168, 183)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(97, 24)
        CheckBox2.TabIndex = 7
        CheckBox2.Text = "Single file"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(384, 211)
        Button3.Name = "Button3"
        Button3.Size = New Size(58, 29)
        Button3.TabIndex = 6
        Button3.Text = "..."
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(7, 213)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "File / Foloer name"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(371, 27)
        TextBox1.TabIndex = 5
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(3, 26)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(438, 144)
        ListBox1.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.Enabled = False
        Button2.Location = New Point(312, 277)
        Button2.Name = "Button2"
        Button2.Size = New Size(130, 29)
        Button2.TabIndex = 3
        Button2.Text = "Stop"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(4, 277)
        Button1.Name = "Button1"
        Button1.Size = New Size(302, 29)
        Button1.TabIndex = 2
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 1
        Label1.Text = "MP4 to AMV"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Enabled = False
        CheckBox1.Location = New Point(7, 183)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(143, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "CPU & Ram limiter"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(GroupBox5)
        TabPage3.Controls.Add(GroupBox4)
        TabPage3.Controls.Add(Label11)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(448, 476)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Settings"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(CheckBox9)
        GroupBox5.Controls.Add(CheckBox8)
        GroupBox5.Controls.Add(CheckBox7)
        GroupBox5.Controls.Add(Label17)
        GroupBox5.Controls.Add(RichTextBox2)
        GroupBox5.Controls.Add(LinkLabel3)
        GroupBox5.Controls.Add(TextBox3)
        GroupBox5.Controls.Add(CheckBox3)
        GroupBox5.Controls.Add(Label15)
        GroupBox5.Controls.Add(CheckBox5)
        GroupBox5.Controls.Add(Label14)
        GroupBox5.Controls.Add(ffmpegpath_txt)
        GroupBox5.Controls.Add(Label13)
        GroupBox5.Controls.Add(Button5)
        GroupBox5.Location = New Point(3, 164)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(442, 300)
        GroupBox5.TabIndex = 6
        GroupBox5.TabStop = False
        GroupBox5.Text = "FFMPEG Settings"
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Checked = True
        CheckBox9.CheckState = CheckState.Checked
        CheckBox9.Font = New Font("Segoe UI", 6.6F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox9.Location = New Point(331, 268)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(80, 17)
        CheckBox9.TabIndex = 27
        CheckBox9.Text = "Single file"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Checked = True
        CheckBox8.CheckState = CheckState.Checked
        CheckBox8.Enabled = False
        CheckBox8.Font = New Font("Segoe UI", 6.6F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox8.Location = New Point(164, 268)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(152, 17)
        CheckBox8.TabIndex = 26
        CheckBox8.Text = "Run all at the same time"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Checked = True
        CheckBox7.CheckState = CheckState.Checked
        CheckBox7.Enabled = False
        CheckBox7.Font = New Font("Segoe UI", 6.6F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox7.Location = New Point(9, 268)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(145, 17)
        CheckBox7.TabIndex = 25
        CheckBox7.Text = "Run in the backgound"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(9, 186)
        Label17.Name = "Label17"
        Label17.Size = New Size(145, 17)
        Label17.TabIndex = 24
        Label17.Text = "Full FFMPEG Command:"
        ' 
        ' RichTextBox2
        ' 
        RichTextBox2.Font = New Font("Segoe UI", 6.6F, FontStyle.Regular, GraphicsUnit.Point)
        RichTextBox2.Location = New Point(9, 206)
        RichTextBox2.Name = "RichTextBox2"
        RichTextBox2.ReadOnly = True
        RichTextBox2.Size = New Size(430, 56)
        RichTextBox2.TabIndex = 23
        RichTextBox2.Text = "ffmpeg.dll  -i ""inputfile.mp4"" -c:v amv -c:a adpcm_ima_amv -pix_fmt yuvj420p -vstrict -1 -s 160x120 -ac 1 -ar 22050 -r 25 -block_size 882 ""outputfile.amv"""
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel3.Location = New Point(274, 137)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(35, 17)
        LinkLabel3.TabIndex = 22
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Help"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.ForeColor = Color.Black
        TextBox3.Location = New Point(9, 157)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "-c:v amv -c:a adpcm_ima_amv -pix_fmt yuvj420p -vstrict -1 -s 160x120 -ac 1 -ar 22050 -r 25 -block_size 882"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(430, 25)
        TextBox3.TabIndex = 20
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI", 6.4F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox3.Location = New Point(109, 137)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(159, 17)
        CheckBox3.TabIndex = 21
        CheckBox3.Text = "Use custome ffmpeg args"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(9, 137)
        Label15.Name = "Label15"
        Label15.Size = New Size(94, 17)
        Label15.TabIndex = 8
        Label15.Text = "FFMPEG ARGS:"
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Segoe UI", 7.3F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox5.Location = New Point(6, 77)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(181, 21)
        CheckBox5.TabIndex = 6
        CheckBox5.Text = "Use custome ffmpeg path"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(6, 23)
        Label14.Name = "Label14"
        Label14.Size = New Size(436, 51)
        Label14.TabIndex = 6
        Label14.Text = "ffmpeg is a universal media converter. It can read a wide variety of inputs" & vbCrLf & " - including live grabbing/recording devices - filter, and" & vbCrLf & " transcode them into a plethora of output formats."
        ' 
        ' ffmpegpath_txt
        ' 
        ffmpegpath_txt.Location = New Point(144, 104)
        ffmpegpath_txt.Name = "ffmpegpath_txt"
        ffmpegpath_txt.ReadOnly = True
        ffmpegpath_txt.Size = New Size(292, 27)
        ffmpegpath_txt.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(193, 84)
        Label13.Name = "Label13"
        Label13.Size = New Size(91, 17)
        Label13.TabIndex = 1
        Label13.Text = "FFMPEG PATH:"
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(6, 102)
        Button5.Name = "Button5"
        Button5.Size = New Size(128, 29)
        Button5.TabIndex = 0
        Button5.Text = "reinstall ffmpeg"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(CheckBox6)
        GroupBox4.Controls.Add(Label16)
        GroupBox4.Controls.Add(TextBox4)
        GroupBox4.Controls.Add(Label12)
        GroupBox4.Controls.Add(ComboBox1)
        GroupBox4.Controls.Add(CheckBox4)
        GroupBox4.Location = New Point(3, 31)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(442, 127)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Mp4 to amv settings"
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Checked = True
        CheckBox6.CheckState = CheckState.Checked
        CheckBox6.Location = New Point(130, 26)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(193, 24)
        CheckBox6.TabIndex = 8
        CheckBox6.Text = "open log file when done"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(197, 61)
        Label16.Name = "Label16"
        Label16.Size = New Size(96, 20)
        Label16.TabIndex = 7
        Label16.Text = "Log file path:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(197, 84)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(239, 27)
        TextBox4.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(6, 61)
        Label12.Name = "Label12"
        Label12.Size = New Size(185, 20)
        Label12.TabIndex = 5
        Label12.Text = "When MP4 to amv is done:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Dont do anything", "Shutdown pc", "logout of pc", "restart pc"})
        ComboBox1.Location = New Point(6, 84)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(185, 28)
        ComboBox1.TabIndex = 4
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Checked = True
        CheckBox4.CheckState = CheckState.Checked
        CheckBox4.Location = New Point(6, 26)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(118, 24)
        CheckBox4.TabIndex = 2
        CheckBox4.Text = "Make log file"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(3, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(89, 28)
        Label11.TabIndex = 1
        Label11.Text = "Settings"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(TabControl2)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(448, 476)
        TabPage4.TabIndex = 3
        TabPage4.Text = "output"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TabControl2
        ' 
        TabControl2.Controls.Add(TabPage5)
        TabControl2.Controls.Add(TabPage6)
        TabControl2.Location = New Point(3, 3)
        TabControl2.Name = "TabControl2"
        TabControl2.SelectedIndex = 0
        TabControl2.Size = New Size(445, 461)
        TabControl2.TabIndex = 1
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(ListBox2)
        TabPage5.Location = New Point(4, 29)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(437, 428)
        TabPage5.TabIndex = 0
        TabPage5.Text = "List"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 20
        ListBox2.Location = New Point(6, 6)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(425, 404)
        ListBox2.TabIndex = 0
        ' 
        ' TabPage6
        ' 
        TabPage6.Controls.Add(RichTextBox3)
        TabPage6.Location = New Point(4, 29)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(437, 428)
        TabPage6.TabIndex = 1
        TabPage6.Text = "Text"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox3
        ' 
        RichTextBox3.Location = New Point(-1, -1)
        RichTextBox3.Name = "RichTextBox3"
        RichTextBox3.Size = New Size(439, 426)
        RichTextBox3.TabIndex = 0
        RichTextBox3.Text = ""
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(GroupBox3)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(448, 476)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Help"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(LinkLabel2)
        GroupBox3.Controls.Add(RichTextBox1)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Location = New Point(6, 6)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(436, 463)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "Info"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(6, 440)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(185, 20)
        LinkLabel2.TabIndex = 23
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "MIT License (c) zv800 2023"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(6, 262)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(424, 175)
        RichTextBox1.TabIndex = 22
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(6, 96)
        Label10.Name = "Label10"
        Label10.Size = New Size(310, 153)
        Label10.TabIndex = 21
        Label10.Text = resources.GetString("Label10.Text")
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(0, 51)
        Label9.Name = "Label9"
        Label9.Size = New Size(352, 80)
        Label9.TabIndex = 1
        Label9.Text = "MP4 to AMV to a conviter for any video file to amv. " & vbCrLf & "A format that mp3 / mp4 players use." & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(0, 23)
        Label8.Name = "Label8"
        Label8.Size = New Size(133, 28)
        Label8.TabIndex = 0
        Label8.Text = "MP4 to AMV"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(249, 23)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(158, 20)
        LinkLabel1.TabIndex = 20
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Discord Acc name: zv8"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(44, 23)
        Label7.Name = "Label7"
        Label7.Size = New Size(163, 20)
        Label7.TabIndex = 19
        Label7.Text = "©2023 zv800 / z3ck200"
        ' 
        ' Github_BTN
        ' 
        Github_BTN.BackgroundImage = My.Resources.Resources.GitHub_Mark_ea2971cee799
        Github_BTN.BackgroundImageLayout = ImageLayout.Stretch
        Github_BTN.FlatAppearance.BorderSize = 0
        Github_BTN.FlatStyle = FlatStyle.Flat
        Github_BTN.ImageAlign = ContentAlignment.MiddleLeft
        Github_BTN.Location = New Point(4, 16)
        Github_BTN.Name = "Github_BTN"
        Github_BTN.Size = New Size(37, 34)
        Github_BTN.TabIndex = 18
        Github_BTN.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1
        ' 
        ' MFS
        ' 
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(LinkLabel1)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Github_BTN)
        GroupBox2.Location = New Point(12, 528)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(456, 55)
        GroupBox2.TabIndex = 21
        GroupBox2.TabStop = False
        ' 
        ' Timeer
        ' 
        Timeer.Interval = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(475, 28)
        MenuStrip1.TabIndex = 22
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SettingsToolStripMenuItem, RunToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DarkModeToolStripMenuItem})
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(145, 26)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' DarkModeToolStripMenuItem
        ' 
        DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        DarkModeToolStripMenuItem.Size = New Size(210, 26)
        DarkModeToolStripMenuItem.Text = "DarkMode toggle"
        ' 
        ' RunToolStripMenuItem
        ' 
        RunToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StartToolStripMenuItem, StopToolStripMenuItem})
        RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        RunToolStripMenuItem.Size = New Size(145, 26)
        RunToolStripMenuItem.Text = "Run"
        ' 
        ' StartToolStripMenuItem
        ' 
        StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        StartToolStripMenuItem.Size = New Size(123, 26)
        StartToolStripMenuItem.Text = "Start"
        ' 
        ' StopToolStripMenuItem
        ' 
        StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        StopToolStripMenuItem.Size = New Size(123, 26)
        StopToolStripMenuItem.Text = "Stop"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FFMPEGToolStripMenuItem, MP4ToAmvToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' FFMPEGToolStripMenuItem
        ' 
        FFMPEGToolStripMenuItem.Name = "FFMPEGToolStripMenuItem"
        FFMPEGToolStripMenuItem.Size = New Size(171, 26)
        FFMPEGToolStripMenuItem.Text = "FFMPEG"
        ' 
        ' MP4ToAmvToolStripMenuItem
        ' 
        MP4ToAmvToolStripMenuItem.Name = "MP4ToAmvToolStripMenuItem"
        MP4ToAmvToolStripMenuItem.Size = New Size(171, 26)
        MP4ToAmvToolStripMenuItem.Text = "MP4 to amv"
        ' 
        ' Fullffmpegcmddechtime
        ' 
        Fullffmpegcmddechtime.Enabled = True
        Fullffmpegcmddechtime.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(475, 586)
        Controls.Add(GroupBox2)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        ForeColor = SystemColors.ControlText
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MaximumSize = New Size(493, 633)
        MinimizeBox = False
        MinimumSize = New Size(493, 633)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MP4 to AMV https://zv800.com"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabControl2.ResumeLayout(False)
        TabPage5.ResumeLayout(False)
        TabPage6.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MFS As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBR_STAT As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Github_BTN As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Timeer As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FFMPEGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MP4ToAmvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ffmpegpath_txt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label17 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents Fullffmpegcmddechtime As Timer
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents RichTextBox3 As RichTextBox
End Class
