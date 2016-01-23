Imports System.Data
Imports System.IO

Public Class frmTemplete1


    Dim dtData As DataTable
    Property setDtData() As DataTable
        Get
            Return dtData
        End Get
        Set(ByVal Value As DataTable)
            dtData = Value
        End Set
    End Property

    Private Sub frmTemplete1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
    End Sub

    Private Sub PictureBoxBg_DoubleClick(sender As Object, e As EventArgs) Handles PictureBoxBg.DoubleClick
        Me.Close()
    End Sub

    Public Sub ShowData()
        If dtData.Rows.Count <> 0 And dtData.Rows.Count <= 4 Then
            For i As Integer = 0 To dtData.Rows.Count - 1
                Select Case i + 1
                    Case 1
                        lblname1.Text = dtData.Rows(i)("fullname")
                        lbldetail1.Text = dtData.Rows(i)("company_name")
                        PictureBoxImage1.Image = getImage(dtData.Rows(i)("tagid") & "")
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

End Class