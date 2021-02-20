<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbVideoURL = New System.Windows.Forms.TextBox()
        Me.btn_VidID = New System.Windows.Forms.Button()
        Me.tbVidID = New System.Windows.Forms.TextBox()
        Me.btn_Thumbnail = New System.Windows.Forms.Button()
        Me.btn_HighQuality = New System.Windows.Forms.Button()
        Me.btn_MaxRes = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.cbUseDefBrowser = New System.Windows.Forms.CheckBox()
        Me.btn_PasteURL = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_test = New System.Windows.Forms.Button()
        Me.btn_PlayVid = New System.Windows.Forms.Button()
        Me.btn_SDRes = New System.Windows.Forms.Button()
        Me.cb_TopMost = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Video URL"
        '
        'tbVideoURL
        '
        Me.tbVideoURL.Location = New System.Drawing.Point(69, 8)
        Me.tbVideoURL.Name = "tbVideoURL"
        Me.tbVideoURL.Size = New System.Drawing.Size(303, 20)
        Me.tbVideoURL.TabIndex = 1
        '
        'btn_VidID
        '
        Me.btn_VidID.Location = New System.Drawing.Point(6, 34)
        Me.btn_VidID.Name = "btn_VidID"
        Me.btn_VidID.Size = New System.Drawing.Size(75, 23)
        Me.btn_VidID.TabIndex = 2
        Me.btn_VidID.Text = "Video ID"
        Me.btn_VidID.UseVisualStyleBackColor = True
        '
        'tbVidID
        '
        Me.tbVidID.Enabled = False
        Me.tbVidID.Location = New System.Drawing.Point(87, 36)
        Me.tbVidID.Name = "tbVidID"
        Me.tbVidID.Size = New System.Drawing.Size(122, 20)
        Me.tbVidID.TabIndex = 3
        '
        'btn_Thumbnail
        '
        Me.btn_Thumbnail.Location = New System.Drawing.Point(24, 64)
        Me.btn_Thumbnail.Name = "btn_Thumbnail"
        Me.btn_Thumbnail.Size = New System.Drawing.Size(96, 23)
        Me.btn_Thumbnail.TabIndex = 4
        Me.btn_Thumbnail.Text = "Thumbnail"
        Me.btn_Thumbnail.UseVisualStyleBackColor = True
        '
        'btn_HighQuality
        '
        Me.btn_HighQuality.Location = New System.Drawing.Point(126, 64)
        Me.btn_HighQuality.Name = "btn_HighQuality"
        Me.btn_HighQuality.Size = New System.Drawing.Size(96, 23)
        Me.btn_HighQuality.TabIndex = 5
        Me.btn_HighQuality.Text = "High Quality"
        Me.btn_HighQuality.UseVisualStyleBackColor = True
        '
        'btn_MaxRes
        '
        Me.btn_MaxRes.Location = New System.Drawing.Point(330, 64)
        Me.btn_MaxRes.Name = "btn_MaxRes"
        Me.btn_MaxRes.Size = New System.Drawing.Size(96, 23)
        Me.btn_MaxRes.TabIndex = 6
        Me.btn_MaxRes.Text = "Max Res"
        Me.btn_MaxRes.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 93)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(547, 391)
        Me.WebBrowser1.TabIndex = 7
        '
        'cbUseDefBrowser
        '
        Me.cbUseDefBrowser.AutoSize = True
        Me.cbUseDefBrowser.Location = New System.Drawing.Point(215, 36)
        Me.cbUseDefBrowser.Name = "cbUseDefBrowser"
        Me.cbUseDefBrowser.Size = New System.Drawing.Size(123, 17)
        Me.cbUseDefBrowser.TabIndex = 8
        Me.cbUseDefBrowser.Text = "Use Default Browser"
        Me.cbUseDefBrowser.UseVisualStyleBackColor = True
        '
        'btn_PasteURL
        '
        Me.btn_PasteURL.Location = New System.Drawing.Point(378, 6)
        Me.btn_PasteURL.Name = "btn_PasteURL"
        Me.btn_PasteURL.Size = New System.Drawing.Size(75, 23)
        Me.btn_PasteURL.TabIndex = 9
        Me.btn_PasteURL.Text = "Paste URL"
        Me.btn_PasteURL.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_test)
        Me.Panel1.Controls.Add(Me.btn_PlayVid)
        Me.Panel1.Controls.Add(Me.btn_SDRes)
        Me.Panel1.Controls.Add(Me.cb_TopMost)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.WebBrowser1)
        Me.Panel1.Controls.Add(Me.btn_PasteURL)
        Me.Panel1.Controls.Add(Me.tbVideoURL)
        Me.Panel1.Controls.Add(Me.cbUseDefBrowser)
        Me.Panel1.Controls.Add(Me.btn_VidID)
        Me.Panel1.Controls.Add(Me.tbVidID)
        Me.Panel1.Controls.Add(Me.btn_MaxRes)
        Me.Panel1.Controls.Add(Me.btn_Thumbnail)
        Me.Panel1.Controls.Add(Me.btn_HighQuality)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 487)
        Me.Panel1.TabIndex = 10
        '
        'btn_test
        '
        Me.btn_test.Location = New System.Drawing.Point(498, 33)
        Me.btn_test.Name = "btn_test"
        Me.btn_test.Size = New System.Drawing.Size(43, 23)
        Me.btn_test.TabIndex = 14
        Me.btn_test.Text = "Test"
        Me.btn_test.UseVisualStyleBackColor = True
        '
        'btn_PlayVid
        '
        Me.btn_PlayVid.Location = New System.Drawing.Point(432, 64)
        Me.btn_PlayVid.Name = "btn_PlayVid"
        Me.btn_PlayVid.Size = New System.Drawing.Size(96, 23)
        Me.btn_PlayVid.TabIndex = 13
        Me.btn_PlayVid.Text = "Play Video"
        Me.btn_PlayVid.UseVisualStyleBackColor = True
        '
        'btn_SDRes
        '
        Me.btn_SDRes.Location = New System.Drawing.Point(228, 64)
        Me.btn_SDRes.Name = "btn_SDRes"
        Me.btn_SDRes.Size = New System.Drawing.Size(96, 23)
        Me.btn_SDRes.TabIndex = 12
        Me.btn_SDRes.Text = "SD Res"
        Me.btn_SDRes.UseVisualStyleBackColor = True
        '
        'cb_TopMost
        '
        Me.cb_TopMost.AutoSize = True
        Me.cb_TopMost.Location = New System.Drawing.Point(378, 36)
        Me.cb_TopMost.Name = "cb_TopMost"
        Me.cb_TopMost.Size = New System.Drawing.Size(86, 17)
        Me.cb_TopMost.TabIndex = 11
        Me.cb_TopMost.Text = "Stay On Top"
        Me.cb_TopMost.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(506, 11)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(35, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(550, 525)
        Me.Name = "Form1"
        Me.Text = "YouTube Image"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbVideoURL As System.Windows.Forms.TextBox
    Friend WithEvents btn_VidID As System.Windows.Forms.Button
    Friend WithEvents tbVidID As System.Windows.Forms.TextBox
    Friend WithEvents btn_Thumbnail As System.Windows.Forms.Button
    Friend WithEvents btn_HighQuality As System.Windows.Forms.Button
    Friend WithEvents btn_MaxRes As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents cbUseDefBrowser As System.Windows.Forms.CheckBox
    Friend WithEvents btn_PasteURL As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents cb_TopMost As System.Windows.Forms.CheckBox
    Friend WithEvents btn_SDRes As System.Windows.Forms.Button
    Friend WithEvents btn_PlayVid As System.Windows.Forms.Button
    Friend WithEvents btn_test As System.Windows.Forms.Button

End Class
