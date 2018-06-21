Imports System.Net
Imports System.Net.Mail
Imports System.IO
Imports System.ComponentModel

Public Class ticketForm

    Dim boolScreenShot = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '///////save images from PictureBox
        'If Me.PictureBox1.Image IsNot Nothing Then
        '    Me.PictureBox1.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyPictures, "TestFile.jpg"))
        'End If
    End Sub


    Private Sub sendButton_Click(sender As Object, e As EventArgs) Handles sendButton.Click
        Try
            Dim client As New SmtpClient
            Dim message As New MailMessage

            client.UseDefaultCredentials = True
            client.Credentials = New NetworkCredential("support@keepingitsimple.it", "gn)J9Eq_")
            client.Port = 25
            client.EnableSsl = False
            client.Host = "smtp.myexchangeonline.co.uk"



            message = New MailMessage
            message.From = New MailAddress("support@keepingitsimple.it", Me.fromTextBox.Text)
            message.To.Add("helpdesk@keepingitsimple.it")
            message.ReplyToList.Add(fromTextBox.Text)
            message.Subject = Me.subjectTextBox.Text
            message.IsBodyHtml = False
            message.Body = Me.messageTextBox.Text
            'message.Attachments.Add("Dir + Filename .jpg")
            client.Send(message)
            MsgBox("Mail Sent", MsgBoxStyle.ApplicationModal, Nothing)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.ApplicationModal, Nothing)
        End Try
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        'Me.Hide()
        'Me.WindowState = FormWindowState.Minimized
        'trayIcon.Visible = True
        screenOnePictureBox.Image = Nothing

        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen1.jpg") Then

            File.Delete((My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen1.jpg"))
            boolScreenShot = 1
        Else
            boolScreenShot = 0
        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen2.jpg") Then

            File.Delete((My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen2.jpg"))

        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen3.jpg") Then

            File.Delete((My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen3.jpg"))

        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen4.jpg") Then

            File.Delete((My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen4.jpg"))

        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen5.jpg") Then

            File.Delete((My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen5.jpg"))

        End If


    End Sub

    Private Sub screenOnePictureBox_Click(sender As Object, e As EventArgs) Handles screenOnePictureBox.Click
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        screenOnePictureBox.Image = screenshot
        Me.Opacity = 100
        Me.ShowInTaskbar = True
        screenTwoPictureBox.Visible = True

        If Me.screenOnePictureBox.Image IsNot Nothing Then
            Me.screenOnePictureBox.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "TempScreen1.jpg"))
        End If

    End Sub

    Private Sub screenTwoPictureBox_Click(sender As Object, e As EventArgs) Handles screenTwoPictureBox.Click
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        screenTwoPictureBox.Image = screenshot
        Me.Opacity = 100
        Me.ShowInTaskbar = True
        screenThreePictureBox.Visible = True
        If Me.screenTwoPictureBox.Image IsNot Nothing Then
            Me.screenTwoPictureBox.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "TempScreen2.jpg"))
        End If
    End Sub

    Private Sub screenThreePictureBox_Click(sender As Object, e As EventArgs) Handles screenThreePictureBox.Click
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        screenThreePictureBox.Image = screenshot
        Me.Opacity = 100
        Me.ShowInTaskbar = True
        screenFourPictureBox.Visible = True
        If Me.screenThreePictureBox.Image IsNot Nothing Then
            Me.screenThreePictureBox.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "TempScreen3.jpg"))
        End If
    End Sub

    Private Sub screenFourPictureBox_Click(sender As Object, e As EventArgs) Handles screenFourPictureBox.Click
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        screenFourPictureBox.Image = screenshot
        Me.Opacity = 100
        Me.ShowInTaskbar = True
        screenFivePictureBox.Visible = True
        If Me.screenFourPictureBox.Image IsNot Nothing Then
            Me.screenFourPictureBox.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "TempScreen4.jpg"))
        End If
    End Sub

    Private Sub screenFivePictureBox_Click(sender As Object, e As EventArgs) Handles screenFivePictureBox.Click
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        screenFivePictureBox.Image = screenshot
        Me.Opacity = 100
        Me.ShowInTaskbar = True
        If Me.screenFivePictureBox.Image IsNot Nothing Then
            Me.screenFivePictureBox.Image.Save(IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "TempScreen5.jpg"))
        End If
    End Sub

    Private Sub ticketForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen1.jpg") Then

            File.Delete((My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen1.jpg"))

        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen2.jpg") Then

            File.Delete((My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen2.jpg"))

        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen3.jpg") Then

            File.Delete((My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen3.jpg"))

        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen4.jpg") Then

            File.Delete((My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen4.jpg"))

        End If
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen5.jpg") Then

            File.Delete((My.Computer.FileSystem.SpecialDirectories.Temp & "\TempScreen5.jpg"))

        End If
    End Sub

    Private Sub subjectTextBox_TextChanged(sender As Object, e As EventArgs) Handles subjectTextBox.TextChanged
        If subjectTextBox.Text = "" Then
            subjectTextBox.Text = "Subject of your request"
        End If
    End Sub

    Private Sub subjectTextBox_GotFocus(sender As Object, e As EventArgs) Handles subjectTextBox.GotFocus

    End Sub

    Private Sub subjectTextBox_Enter(sender As Object, e As EventArgs) Handles subjectTextBox.Enter
        SendKeys.Send("+{HOME}")
    End Sub
End Class
