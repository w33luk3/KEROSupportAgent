<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ticketForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ticketForm))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.messageTextBox = New System.Windows.Forms.TextBox()
        Me.subjectTextBox = New System.Windows.Forms.TextBox()
        Me.fromTextBox = New System.Windows.Forms.TextBox()
        Me.sendButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.screenOnePictureBox = New System.Windows.Forms.PictureBox()
        Me.screenTwoPictureBox = New System.Windows.Forms.PictureBox()
        Me.screenThreePictureBox = New System.Windows.Forms.PictureBox()
        Me.screenFourPictureBox = New System.Windows.Forms.PictureBox()
        Me.screenFivePictureBox = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.screenOnePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.screenTwoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.screenThreePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.screenFourPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.screenFivePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Message:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Subject:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "E-Mail:"
        '
        'messageTextBox
        '
        Me.messageTextBox.ForeColor = System.Drawing.Color.Gray
        Me.messageTextBox.Location = New System.Drawing.Point(64, 41)
        Me.messageTextBox.Multiline = True
        Me.messageTextBox.Name = "messageTextBox"
        Me.messageTextBox.Size = New System.Drawing.Size(422, 107)
        Me.messageTextBox.TabIndex = 13
        Me.messageTextBox.Text = "Write about your problem here"
        '
        'subjectTextBox
        '
        Me.subjectTextBox.ForeColor = System.Drawing.Color.Gray
        Me.subjectTextBox.Location = New System.Drawing.Point(64, 12)
        Me.subjectTextBox.Name = "subjectTextBox"
        Me.subjectTextBox.Size = New System.Drawing.Size(422, 20)
        Me.subjectTextBox.TabIndex = 12
        Me.subjectTextBox.Text = "Subject of your request"
        '
        'fromTextBox
        '
        Me.fromTextBox.ForeColor = System.Drawing.Color.Gray
        Me.fromTextBox.Location = New System.Drawing.Point(64, 229)
        Me.fromTextBox.Name = "fromTextBox"
        Me.fromTextBox.Size = New System.Drawing.Size(422, 20)
        Me.fromTextBox.TabIndex = 10
        Me.fromTextBox.Text = "Enter your e-mail address here"
        '
        'sendButton
        '
        Me.sendButton.Location = New System.Drawing.Point(330, 287)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(75, 23)
        Me.sendButton.TabIndex = 9
        Me.sendButton.Text = "Send"
        Me.sendButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.screenOnePictureBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.screenTwoPictureBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.screenThreePictureBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.screenFourPictureBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.screenFivePictureBox)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(64, 159)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(422, 60)
        Me.FlowLayoutPanel1.TabIndex = 22
        '
        'screenOnePictureBox
        '
        Me.screenOnePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.screenOnePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.screenOnePictureBox.Image = Global.KEROSupportAgent.My.Resources.Resources.plus1
        Me.screenOnePictureBox.Location = New System.Drawing.Point(6, 9)
        Me.screenOnePictureBox.Margin = New System.Windows.Forms.Padding(6, 9, 3, 9)
        Me.screenOnePictureBox.Name = "screenOnePictureBox"
        Me.screenOnePictureBox.Size = New System.Drawing.Size(75, 42)
        Me.screenOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.screenOnePictureBox.TabIndex = 2
        Me.screenOnePictureBox.TabStop = False
        '
        'screenTwoPictureBox
        '
        Me.screenTwoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.screenTwoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.screenTwoPictureBox.Image = CType(resources.GetObject("screenTwoPictureBox.Image"), System.Drawing.Image)
        Me.screenTwoPictureBox.Location = New System.Drawing.Point(89, 9)
        Me.screenTwoPictureBox.Margin = New System.Windows.Forms.Padding(5, 9, 3, 9)
        Me.screenTwoPictureBox.Name = "screenTwoPictureBox"
        Me.screenTwoPictureBox.Size = New System.Drawing.Size(75, 42)
        Me.screenTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.screenTwoPictureBox.TabIndex = 4
        Me.screenTwoPictureBox.TabStop = False
        Me.screenTwoPictureBox.Visible = False
        '
        'screenThreePictureBox
        '
        Me.screenThreePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.screenThreePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.screenThreePictureBox.Image = CType(resources.GetObject("screenThreePictureBox.Image"), System.Drawing.Image)
        Me.screenThreePictureBox.Location = New System.Drawing.Point(172, 9)
        Me.screenThreePictureBox.Margin = New System.Windows.Forms.Padding(5, 9, 3, 9)
        Me.screenThreePictureBox.Name = "screenThreePictureBox"
        Me.screenThreePictureBox.Size = New System.Drawing.Size(75, 42)
        Me.screenThreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.screenThreePictureBox.TabIndex = 5
        Me.screenThreePictureBox.TabStop = False
        Me.screenThreePictureBox.Visible = False
        '
        'screenFourPictureBox
        '
        Me.screenFourPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.screenFourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.screenFourPictureBox.Image = CType(resources.GetObject("screenFourPictureBox.Image"), System.Drawing.Image)
        Me.screenFourPictureBox.Location = New System.Drawing.Point(255, 9)
        Me.screenFourPictureBox.Margin = New System.Windows.Forms.Padding(5, 9, 3, 9)
        Me.screenFourPictureBox.Name = "screenFourPictureBox"
        Me.screenFourPictureBox.Size = New System.Drawing.Size(75, 42)
        Me.screenFourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.screenFourPictureBox.TabIndex = 6
        Me.screenFourPictureBox.TabStop = False
        Me.screenFourPictureBox.Visible = False
        '
        'screenFivePictureBox
        '
        Me.screenFivePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.screenFivePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.screenFivePictureBox.Image = CType(resources.GetObject("screenFivePictureBox.Image"), System.Drawing.Image)
        Me.screenFivePictureBox.Location = New System.Drawing.Point(338, 9)
        Me.screenFivePictureBox.Margin = New System.Windows.Forms.Padding(5, 9, 3, 9)
        Me.screenFivePictureBox.Name = "screenFivePictureBox"
        Me.screenFivePictureBox.Size = New System.Drawing.Size(75, 42)
        Me.screenFivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.screenFivePictureBox.TabIndex = 7
        Me.screenFivePictureBox.TabStop = False
        Me.screenFivePictureBox.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Images:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Phone:"
        '
        'phoneTextBox
        '
        Me.phoneTextBox.ForeColor = System.Drawing.Color.Gray
        Me.phoneTextBox.Location = New System.Drawing.Point(64, 258)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(422, 20)
        Me.phoneTextBox.TabIndex = 24
        Me.phoneTextBox.Text = "Enter your phone number here"
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(411, 287)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 26
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'trayIcon
        '
        Me.trayIcon.Icon = CType(resources.GetObject("trayIcon.Icon"), System.Drawing.Icon)
        Me.trayIcon.Text = "NotifyIcon1"
        Me.trayIcon.Visible = True
        '
        'ticketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 314)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.phoneTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.messageTextBox)
        Me.Controls.Add(Me.subjectTextBox)
        Me.Controls.Add(Me.fromTextBox)
        Me.Controls.Add(Me.sendButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ticketForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send support request"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.screenOnePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.screenTwoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.screenThreePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.screenFourPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.screenFivePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents messageTextBox As TextBox
    Friend WithEvents subjectTextBox As TextBox
    Friend WithEvents fromTextBox As TextBox
    Friend WithEvents sendButton As Button
    Friend WithEvents screenOnePictureBox As PictureBox
    Friend WithEvents screenTwoPictureBox As PictureBox
    Friend WithEvents screenThreePictureBox As PictureBox
    Friend WithEvents screenFourPictureBox As PictureBox
    Friend WithEvents screenFivePictureBox As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents trayIcon As NotifyIcon
End Class
