Public Class frmTemplete2

    Dim dtData As DataTable
    Property setDtData() As DataTable
        Get
            Return dtData
        End Get
        Set(ByVal Value As DataTable)
            dtData = Value
        End Set
    End Property

    Private Sub PictureBoxBg_DoubleClick(sender As Object, e As EventArgs)
        frmMain.btnStart.Enabled = True
        frmMain.btnStart.Visible = True
        frmMain.Timer1.Stop()
        Me.Close()
    End Sub

    Private Sub frmTemplete2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Width = 1920
        Me.Height = 1080
    End Sub


    Public Sub ShowData()
        If dtData.Rows.Count <> 0 And dtData.Rows.Count <= 4 Then
            For i As Integer = 0 To dtData.Rows.Count - 1
                Select Case i + 1
                    Case 1
                        lblname1.Text = dtData.Rows(i)("fullname")
                        lbldetail1.Text = dtData.Rows(i)("company_name")




                        PictureBoxImageFront1.Image = getImage(dtData.Rows(i)("tagid") & "")
                        ' PictureBoxImageFront1.Location = New Point(168, 233)
                        ' PictureBoxImageFront1.Width = 280
                        ' PictureBoxImageFront1.Height = 305

                        'PictureBoxDetail1.Location = New Point(269, 477)
                        ' PictureBoxDetail1.Width = 418
                        ' PictureBoxDetail1.Height = 204
                    Case 2
                        lblname2.Text = dtData.Rows(i)("fullname")
                        lbldetail2.Text = dtData.Rows(i)("company_name")
                        PictureBoxImage2.Image = getImage(dtData.Rows(i)("tagid") & "")
                    Case 3
                        lblname3.Text = dtData.Rows(i)("fullname")
                        lbldetail3.Text = dtData.Rows(i)("company_name")
                        PictureBoxImage3.Image = getImage(dtData.Rows(i)("tagid") & "")
                    Case 4
                        lblname4.Text = dtData.Rows(i)("fullname")
                        lbldetail4.Text = dtData.Rows(i)("company_name")
                        PictureBoxImage4.Image = getImage(dtData.Rows(i)("tagid") & "")
                    Case 5
                        lblname5.Text = dtData.Rows(i)("fullname")
                        lbldetail5.Text = dtData.Rows(i)("company_name")
                        PictureBoxImage6.Image = getImage(dtData.Rows(i)("tagid") & "")
                    Case 6
                        lblname6.Text = dtData.Rows(i)("fullname")
                        lbldetail6.Text = dtData.Rows(i)("company_name")
                        PictureBoxImage6.Image = getImage(dtData.Rows(i)("tagid") & "")
                    Case 7
                        lblname7.Text = dtData.Rows(i)("fullname")
                        lbldetail7.Text = dtData.Rows(i)("company_name")
                        PictureBoxImage7.Image = getImage(dtData.Rows(i)("tagid") & "")
                    Case 8
                        lblname8.Text = dtData.Rows(i)("fullname")
                        lbldetail8.Text = dtData.Rows(i)("company_name")
                        PictureBoxImage8.Image = getImage(dtData.Rows(i)("tagid") & "")
                End Select
            Next
        End If
    End Sub

    Private Function getImage(id As String) As Image
        Dim ret As Image
        Try
            Dim strpath = "D:\GreetingImage"
            Dim image As Image = image.FromFile(strpath & "\" & id & ".jpg")
            ret = image
        Catch ex As Exception
            ret = ret
        End Try
        Return ret
    End Function

    Private Sub PictureBoxBg_Click(sender As Object, e As EventArgs)
        frmMain.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        frmMain.btnStart.Enabled = True
        frmMain.btnStart.Visible = True
        frmMain.Timer1.Stop()
        Me.Close()
    End Sub
End Class