Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class frmCapture
    Private ConfigINI As IniReader
    Private webcam As WebCam
    Dim _Number As String
    Dim _IsCapture As Boolean = False
    Dim CamIndex As Integer = 0


    Private Sub frmCapture_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConfigINI = New IniReader(Application.StartupPath & "\Config.ini")
        ConfigINI.Section = "CaptureImage"
        pbImage.BringToFront()

        Try
            webcam = New WebCam()
            webcam.InitializeWebCam(pbImage)
            webcam.Start(CamIndex)

            'Dim FormWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            'Dim FormHeight As Integer = Screen.PrimaryScreen.Bounds.Height
            Dim CaptureHeight As Integer = ConfigINI.ReadString("CaptureHeight")
            Dim CaptureWidth As Integer = ConfigINI.ReadString("CaptureWidth")
            'Me.Size = New Size(FormWidth, FormHeight)
            'pbReCapture.Location = New Point(pbDisplay.Location)
            'pbClose.Location = New Point(FormWidth - 40, 12)

            webcam.CaptureHeight(CaptureHeight)
            webcam.CaptureWidth(CaptureWidth)

            'pbDisplay.BringToFront()

        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub pbReCapture_Click(sender As Object, e As EventArgs) Handles pbReCapture.Click
        ReCapture()
    End Sub

    Private Sub pcCapture_Click(sender As Object, e As EventArgs) Handles pcCapture.Click
        CaptureEvent()
    End Sub

    Private Sub pbSave_Click(sender As Object, e As EventArgs) Handles pbSave.Click
        Save()
    End Sub



#Region "Sub&Function"

    Sub CaptureEvent()
        pcCapture.Visible = False
        pbSave.Visible = True
        
        Panel1.BringToFront()
        CaptureImage(txtMemberNo.Text)
        pbImage.Visible = False
        pbDisplay.Visible = True
        webcam.Stop()

        CombineImage(txtMemberNo.Text)

        _IsCapture = True
    End Sub

    Sub CaptureImage(ByVal id As String)
        Dim FileName As String = id & ".jpg"
        Dim Path As String = ConfigINI.ReadString("path")
        If Directory.Exists(Path) = False Then
            Directory.CreateDirectory(Path)
        End If
        Dim Path1 As String = Path & FileName
        pbImage.Image.Save(Path1, System.Drawing.Imaging.ImageFormat.Jpeg)

        Threading.Thread.Sleep(1000)
        Dim bipimag As New MemoryStream(File.ReadAllBytes(Path1))
        Dim imag As Image = New Bitmap(bipimag)
        pbDisplay.BackgroundImageLayout = ImageLayout.Stretch
        pbDisplay.Image = imag
    End Sub

    Private Sub CombineImage(ByVal MemberNo As String)
        Dim FileName As String = MemberNo & ".jpg"
        'Dim FileNameNologo As String = id & "_nologo.jpg"

        Dim Path As String = ConfigINI.ReadString("path")
        Using character As Image = pbDisplay.Image
            Using bg As Image = New Bitmap(pcBG.Image)

                Using newImage As New Bitmap(640, 480)
                    Using canvas As System.Drawing.Graphics = Graphics.FromImage(newImage)
                        canvas.InterpolationMode = InterpolationMode.HighQualityBicubic
                        canvas.DrawImage(character, New Rectangle(0, 0, 800, pbDisplay.Size.Height), New Rectangle(0, 0, 800, character.Height), GraphicsUnit.Pixel)


                        canvas.DrawImage(bg, New Rectangle(430, 300, pcBG.Size.Width, pcBG.Size.Height), New Rectangle(0, 0, pcBG.Width, pcBG.Height), GraphicsUnit.Pixel)
                        canvas.Save()
                        If Not System.IO.Directory.Exists(Path) Then
                            System.IO.Directory.CreateDirectory(Path)
                        End If

                        newImage.Save(Path & FileName, ImageFormat.Png)
                        'pbDisplay.Image.Save(Path & FileNameNologo, ImageFormat.Png)
                        canvas.Dispose()
                    End Using
                End Using
            End Using
        End Using

        Dim bipimag As New MemoryStream(File.ReadAllBytes(Path & FileName))
        Dim imag2 As Image = New Bitmap(bipimag)
        pbDisplay.BackgroundImageLayout = ImageLayout.Stretch
        pbDisplay.Image = imag2

    End Sub

    Public Function CaptureScreen() As Bitmap
        Dim Width As Integer = 640
        Dim Height As Integer = 480
        Dim x As Integer = 74
        Dim y As Integer = 418

        Dim tempBmp As New Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        Dim grp As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(tempBmp)
        grp.CopyFromScreen(x, y, 0, 0, Screen.PrimaryScreen.Bounds.Size, System.Drawing.CopyPixelOperation.SourceCopy)

        Return tempBmp
    End Function

    Sub ReCapture()
        webcam.Start(CamIndex)
        pbDisplay.Visible = False
        pcCapture.Visible = True
        pbSave.Visible = False

        pbImage.Visible = True
        pbImage.BringToFront()
        'pbDisplay.BringToFront()

        Dim FileName As String = txtMemberNo.Text & ".jpg"
        Dim FileNameNologo As String = txtMemberNo.Text & "_nologo.jpg"
        Dim Path As String = ConfigINI.ReadString("path")
        File.Delete(Path & FileName)
        File.Delete(Path & FileNameNologo)
    End Sub

    Sub Save()
        'บันทึกรูปเก็บใน Folder เพื่อรอให้ Timmer มากวาดส่งเข้า WebService
        If _IsCapture = False Then
            Exit Sub
        End If

        Try
            Dim FileName As String = txtMemberNo.Text & ".jpg"
            'Dim FileNameNologo As String = txtID.Text & "_nologo.jpg"
            Dim Path As String = ConfigINI.ReadString("path")
            Dim savepath As String = ConfigINI.ReadString("savepath")

            Try
                If Directory.Exists(savepath) = False Then
                    Directory.CreateDirectory(savepath)
                End If
                If File.Exists(savepath & FileName) = True Then
                    File.Delete(savepath & FileName)
                End If
                File.Copy(Path & FileName, savepath & FileName)
                File.Delete(Path & FileName)



                'If Directory.Exists(savepath & "Logo") = False Then
                '    Directory.CreateDirectory(savepath & "Logo")
                'End If
                'If Directory.Exists(savepath & "NoLogo") = False Then
                '    Directory.CreateDirectory(savepath & "NoLogo")
                'End If

                'If File.Exists(savepath & "Logo\" & FileName) = True Then
                '    File.Delete(savepath & "Logo\" & FileName)
                'End If
                'File.Copy(Path & FileName, savepath & "Logo\" & FileName)
                'File.Delete(Path & FileName)

                'If File.Exists(savepath & "NoLogo\" & FileNameNologo) = True Then
                '    File.Delete(savepath & "NoLogo\" & FileNameNologo)
                'End If
                'File.Copy(Path & FileNameNologo, savepath & "NoLogo\" & FileNameNologo)
                'File.Delete(Path & FileNameNologo)
            Catch ex As Exception

            End Try

            _IsCapture = False
            pbReCapture.Visible = False
            pbDisplay.Visible = True
            pbSave.Visible = False

            ''== print and close form
            'If GetStatusForPrint() = 0 Then
            '    Dim IsPrintFinish As Boolean = False
            '    While IsPrintFinish = False
            '        PrintInterest()
            '        Application.DoEvents()
            '        IsPrintFinish = True
            '    End While
            'End If

            'frmRegister.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


#End Region

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        webcam.Stop()
        Me.Close()
    End Sub
End Class