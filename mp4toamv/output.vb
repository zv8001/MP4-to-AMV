Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class output
    Private Sub output_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub save()
        SaveFileDialog1.Filter = "log Files|*.log"
        Try
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                My.Computer.FileSystem.CopyFile(Form1.TextBox4.Text, SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox("Failed to save", 16 + 0)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        save()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        save()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        save()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            RichTextBox1.LoadFile(Form1.TextBox4.Text,
         RichTextBoxStreamType.RichText)
            Me.Text = "output - " & Form1.TextBox4.Text
        Catch ex As Exception
            RichTextBox1.Text = "Failed to load: " & Form1.TextBox4.Text
        End Try
    End Sub
End Class