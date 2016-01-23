Imports System.IO
Imports System.Data.SqlClient

Public Class frmMain

    Private Shared ReadOnly Property GetConnectionString() As String
        Get
            Try
                Dim DBServerName As String = "MAX\SQL2015"
                Dim DBDatabaseName As String = "RFIDHERO2015"
                Dim DBDbUserID As String = "sa"
                Dim DBDbPwd As String = "1qaz@WSX"

                Dim ret As String = "Data Source=" & DBServerName & ";Initial Catalog=" & DBDatabaseName & ";User ID=" & DBDbUserID & ";Password=" & DBDbPwd

                Return ret
            Catch ex As Exception
                Throw New ApplicationException("GetConnectionString", ex)
            End Try
        End Get
    End Property

    'Create ADO.NET objects.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        pb.Image = Image.FromFile(GetFile("Pleasect An Image File", , "JPEG (*.jpg)|*.jpg"))
    End Sub

    Public Function GetFile(ByVal Title As String, Optional ByVal InitialDir As String = "C:\", Optional ByVal Filter As String = "") As String

        'Opens a file dialog and returns the selected file


        Dim ofd As OpenFileDialog = OpenFileDialog1


        Try

            ofd.CheckFileExists = False

            ofd.ShowReadOnly = True


            ofd.Title = Title

            ofd.InitialDirectory = InitialDir

            If Filter.Length > 0 Then Filter += "|"

            Filter += "All Files (*.*)|*.*"

            ofd.Filter = Filter


            If ofd.ShowDialog = DialogResult.OK Then

                Return ofd.FileName

            Else

                Return InitialDir

            End If

        Catch ex As Exception

            Throw New Exception(ex.Message)

        Finally

            ofd.Dispose()

        End Try


    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim randomnumber As New Random
        Dim strtestid As String = randomnumber.Next

        'Convert image to base64
        Dim image As Image = image.FromFile(OpenFileDialog1.FileName)
        Dim m As New MemoryStream
        image.Save(m, image.RawFormat)
        Dim imageBytes As Byte() = m.ToArray
        'Dim base64String As String = Convert.ToBase64String(imageBytes)
        'Send to webservice
        Dim ws As New WebServiceImage.WebServiceSoapClient
        Dim ret As Boolean = ws.SendImage(strtestid, imageBytes)

        If ret Then
            MessageBox.Show("Send image completed")
        Else
            MessageBox.Show("Send image fail")
        End If
    End Sub

    'Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    getData()
    'End Sub


    Private Sub getData()
        Try
            'Connecttion string
            Dim strconstring As String = "Data Source=MAX\SQL2012;Initial Catalog=RFIDHERO2015;User ID=sa;Password=1qaz@WSX"
            'Create a Connection object.
            myConn = New SqlConnection(strconstring)


            'Create a Command object.
            Dim strSql As String
            strSql = " select  "
            strSql &= "  c.id"
            strSql &= "  ,tagid"
            strSql &= "  ,c.title_name + first_name + ' ' + last_name as fullname"
            strSql &= "  ,position_name"
            strSql &= "  ,company_name"
            strSql &= "  ,telno"
            strSql &= "  from TB_GREETING g "
            strSql &= "  inner join ERM_TS_PERSONAL_INFO c"
            strSql &= "  on g.tagid = c.member_no"
            strSql &= "  where isgreeting='N' order by g.create_on"
            myCmd = myConn.CreateCommand
            myCmd.CommandText = strSql

            'Open the connection.
            myConn.Open()


            myReader = myCmd.ExecuteReader()

            Dim dt As DataTable = New DataTable()
            dt.Load(myReader)

            'Close the reader and the database connection.
            myReader.Close()
            myConn.Close()

            If dt.Rows.Count <> 0 And dt.Rows.Count <= 4 Then

                Dim frm As New frmTemplete2_New
                ' frm.WindowState = FormWindowState.Maximized
                ' frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                ' frm.Location = New Point(0, 0)
                ' frm.Size = SystemInformation.PrimaryMonitorSize
                ' frm.Width = 1920
                'frm.Width = 1080

                frm.setDtData = dt
                ' frm.Timer1.Start()
                frm.ShowData()
                ShowForm(frm)
                ' frm.Show()
                ' frm.MdiParent = Me
                ' Me.Visible = False
                ' Me.MdiParent = frm

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ShowForm(ByVal frm As Form)
        CloseAllForm()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CloseAllForm()
        For Each fm In Me.MdiChildren
            Application.DoEvents()
            fm.Close()
            fm.Dispose()

        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CloseAllForm()
        getData()
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Application.DoEvents()
        'System.Threading.Thread.Sleep(1000)
        btnStart.Enabled = False
        btnStart.Visible = False
        getData()
        Me.Timer1.Start()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        btnStart.Enabled = True
        btnStart.Visible = True
        Me.Timer1.Stop()

    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class
