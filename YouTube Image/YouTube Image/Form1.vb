Public Class Form1


#Region "Variables"
    Dim VidURL As String
    Dim VidID As String
    Dim VersionN As String = "1.7.1"

    Dim URLl As String = "https://i1.ytimg.com/vi/"
    Dim DebugMode As Boolean

#End Region

#Region "Form Elements"


    Private Sub btn_VidID_Click(sender As System.Object, e As System.EventArgs) Handles btn_VidID.Click
        'VideoID Button
        VideoSplit()

    End Sub
    Private Sub btn_Thumbnail_Click(sender As System.Object, e As System.EventArgs) Handles btn_Thumbnail.Click
        'Default Button
        ThumbnailImage()

    End Sub

    Private Sub btn_HighQuality_Click(sender As System.Object, e As System.EventArgs) Handles btn_HighQuality.Click
        'High Quality Button
        HQImage()

    End Sub

    Private Sub btn_MaxRes_Click(sender As System.Object, e As System.EventArgs) Handles btn_MaxRes.Click
        'MaxRes Button
        MaxResImage()


    End Sub

    Private Sub btn_SDRes_Click(sender As System.Object, e As System.EventArgs) Handles btn_SDRes.Click
        'SDRes Button
        SDImage()

    End Sub

    Private Sub btn_PlayVid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_PlayVid.Click
        'Play Video Button
        PlayVideo()

    End Sub

    Private Sub btn_PasteURL_Click(sender As System.Object, e As System.EventArgs) Handles btn_PasteURL.Click
        'Paste Button
        tbVideoURL.Text = Clipboard.GetText
        VideoSplit()


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'ABOUT Link
        About()

    End Sub

    Private Sub cb_TopMost_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb_TopMost.CheckedChanged
        If cb_TopMost.Checked = True Then
            Me.TopMost = True
            My.Settings.TopMost = True

        Else
            Me.TopMost = False
            My.Settings.TopMost = False

        End If
    End Sub

#End Region

#Region "FormEvents"

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' https://i1.ytimg.com/vi/<insert-youtube-video-id-here>/default.jpg -   default
        ' https://i1.ytimg.com/vi/<insert-youtube-video-id-here>/hqdefault.jpg - high thumbnail
        ' https://i1.ytimg.com/vi/<insert-youtube-video-id-here>/maxresdefault.jpg - hd thumbnail

        ' https://www.youtube.com/watch?v=2F6d6crjRyU - Video
        ' https://www.youtube.com/watch?annotation_id=annotation_759940559&feature=iv&list=PLwwOk5fvpuuLW1SP8mfnsyQBgeQxJYXJ2&src_vid=3g6-ZMEexHI&v=B-IGa8qdYRU - Alternative Url Style


        'if Stay On Top checkbox is checked, set window to topmost
        cb_TopMost.Checked = My.Settings.TopMost

        'if path contains folder Debug then program is being debuged
        DebugMode = Application.ExecutablePath.Contains("Debug")

        'if debug mode is true (based on exe path) then
        If DebugMode = True Then
            btn_test.Visible = True 'display the test button
        Else
            btn_test.Visible = False 'hide the test button (for normal use)
        End If

    End Sub
#End Region

#Region "CODE"

    Sub VideoSplit()
        'Quick Check of Video URL
        If tbVideoURL.Text.Contains("youtube.com/watch?v=") Then
            'passes check
            'Program will continue

            Try
                VidURL = tbVideoURL.Text
                VidID = VidURL.Split("=")(1)

                tbVidID.Text = VidID

                RemoveAfterID(VidID)

            Catch
                ErrorMSG()

            End Try

        ElseIf tbVideoURL.Text.Contains("watch?annotation_id=") Then
            'passes check
            'Program will continue

            Try
                VidURL = tbVideoURL.Text
                VidID = VidURL.Split("=")(5)
                tbVidID.Text = VidID
                RemoveAfterID(VidID)

            Catch ex As Exception
                ErrorMSG()

            End Try

        ElseIf tbVideoURL.Text.Contains("youtu.be") Then
            'passes check
            'Program will continue

            Try
                VidURL = tbVideoURL.Text
                VidID = VidURL.Split("/")(3)
                tbVidID.Text = VidID
                RemoveAfterID(VidID)

            Catch ex As Exception
                ErrorMSG()

            End Try
        Else
            ErrorMSG()

        End If


    End Sub

    Sub RemoveAfterID(VideoID As String)
        Try
            Dim str As String = VideoID
            Dim strArr() As String
            strArr = str.Split("&")

            VidID = strArr(0)
            tbVidID.Text = VidID

        Catch ex As Exception
            'nothing went wrong, url just didn't have any playlist info in it 
        End Try

    End Sub

    Sub ErrorMSG()
        'failes url check
        'Program Will not go forward, user can reenter url and attempt again
        MsgBox("The URL you entered appears to not be a YouTube URL." & Environment.NewLine &
               "The URL should look like 'www.youtube.com/watch?v=X0X0X0X0XX0'" & Environment.NewLine
               )
        'Clear the text box after message
        tbVideoURL.Text = ""
    End Sub

    Sub ThumbnailImage()
        'Default image (thumbnail)
        Dim VidID As String = tbVidID.Text
        Dim URLr As String = "/default.jpg"
        Dim URL As String = URLl & VidID & URLr


        'Check if Use Default Browser check box is checked
        If cbUseDefBrowser.CheckState = CheckState.Checked Then
            'if checked use defalt browser
            Process.Start(URL)
        Else
            'if not checked use internal browser
            WebBrowser1.Navigate(URL)
        End If
    End Sub

    Sub HQImage()
        Dim VidID As String = tbVidID.Text
        Dim URLr As String = "/hqdefault.jpg"
        Dim URL As String = URLl & VidID & URLr


        'Check if Use Default Browser check box is checked
        If cbUseDefBrowser.CheckState = CheckState.Checked Then
            'if checked use defalt browser
            Process.Start(URL)
        Else
            'if not checked use internal browser
            WebBrowser1.Navigate(URL)
        End If

    End Sub

    Sub SDImage()
        Dim VidID As String = tbVidID.Text
        Dim URLr As String = "/sddefault.jpg"
        Dim URL As String = URLl & VidID & URLr


        'Check if Use Default Browser check box is checked
        If cbUseDefBrowser.CheckState = CheckState.Checked Then
            'if checked use defalt browser
            Process.Start(URL)
        Else
            'if not checked use internal browser
            WebBrowser1.Navigate(URL)
        End If

    End Sub

    Sub MaxResImage()
        'Max Res Button
        Dim VidID As String = tbVidID.Text
        Dim URLr As String = "/maxresdefault.jpg"
        Dim URL As String = URLl & VidID & URLr


        'Check if Use Default Browser check box is checked
        If cbUseDefBrowser.CheckState = CheckState.Checked Then
            'if checked use defalt browser
            Process.Start(URL)
        Else
            'if not checked use internal browser
            WebBrowser1.Navigate(URL)
        End If

    End Sub

    Sub PlayVideo()
        'Play Video Button
        Dim VidID As String = tbVidID.Text
        Dim URLr As String = VidID
        Dim URL As String = My.Settings.YTBaseURL & VidID


        'Check if Use Default Browser check box is checked
        If cbUseDefBrowser.CheckState = CheckState.Checked Then
            'if checked use defalt browser
            Process.Start(URL)
        Else
            'if not checked use internal browser
            WebBrowser1.Navigate(URL)
        End If

    End Sub

    Sub AboutOld()
        MsgBox("Current Version " & VersionN & "." & Environment.NewLine & Environment.NewLine &
            "Version History" & Environment.NewLine &
            "Version 1.0 - Worked as planned" & Environment.NewLine &
            "Version 1.1 - Added multiple resolution options" & Environment.NewLine &
            "Version 1.2 - Fixed issue with browser window not growing with program window" & Environment.NewLine &
            "Version 1.3 - Added support for urls including playlists and other unused code" & Environment.NewLine &
            "Version 1.5 - Cleaned up the code and did some usability cleanup" & Environment.NewLine &
            " " & Environment.NewLine &
            " " & Environment.NewLine
           )
    End Sub

    Sub About()
        'AboutOld()
        Try
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("VersionInfo.txt",
               System.Text.Encoding.UTF8)
            MsgBox("Current Version " & VersionN & "." & Environment.NewLine & Environment.NewLine & Environment.NewLine &
                   fileReader, , "Version History")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Testing"
    Private Sub btn_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_test.Click
        Dim URL As String = "https://www.youtube.com/v/fVl0k-WA78s"
        'Application.ExecutablePath.Replace("YouTube Image.EXE", "") & "page.html"
        MsgBox(URL)
        WebBrowser1.Navigate(URL)
    End Sub
#End Region
   


End Class
