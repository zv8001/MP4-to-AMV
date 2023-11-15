<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MIT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MIT))
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        MITLicenseToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 36)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(638, 399)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 441)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 29)
        Button1.TabIndex = 1
        Button1.Text = "Agree"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(658, 28)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MITLicenseToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' MITLicenseToolStripMenuItem
        ' 
        MITLicenseToolStripMenuItem.Name = "MITLicenseToolStripMenuItem"
        MITLicenseToolStripMenuItem.Size = New Size(169, 26)
        MITLicenseToolStripMenuItem.Text = "MIT License"
        ' 
        ' MIT
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(658, 475)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MaximumSize = New Size(676, 522)
        MinimizeBox = False
        MinimumSize = New Size(676, 522)
        Name = "MIT"
        StartPosition = FormStartPosition.CenterScreen
        Text = "License Agreement"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MITLicenseToolStripMenuItem As ToolStripMenuItem
End Class
