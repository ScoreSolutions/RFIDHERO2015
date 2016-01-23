Imports System.Data
Imports System.Data.SqlClient
Imports AMS
Imports System.IO
Public Class frmRegister

    Dim conn As New SqlConnection
    Dim _id As String
    Dim _MemberNo As String = ""
    Private ConfigINI As Profile.Ini
    Public Property ID() As String
        Get
            ID = _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property
    Public Property MemberNo As String
        Get
            Return _MemberNo.Trim
        End Get
        Set(value As String)
            _MemberNo = value
        End Set
    End Property

    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ConfigINI = New Profile.Ini(Application.StartupPath & "\kiosk.ini")
        Dim servername, Fromdatabasename, dbUserid, dbUserPassword, strconn As String
        servername = ConfigINI.GetValue("Database", "ServerName", "")
        dbUserid = ConfigINI.GetValue("Database", "Username", "")
        dbUserPassword = ConfigINI.GetValue("Database", "Password", "")
        Fromdatabasename = ConfigINI.GetValue("Database", "Database", "")
        strconn = "Data Source=" & servername & _
                      ";Persist Security Info=True;Password=" & dbUserPassword & _
                      ";User ID=" & dbUserid & ";Initial Catalog=" & Fromdatabasename

        conn = New SqlConnection(strconn)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Timer1.Enabled = False
    '    Dim IsFinish As Boolean = False
    '    Do While IsFinish = False

    '        Try
    '            Dim savepath As String = ConfigINI.GetValue("CaptureImage", "savepath", "")
    '            Dim di As New DirectoryInfo(savepath & "Logo")
    '            For Each fri As FileInfo In di.GetFiles()
    '                Dim filename As String = Replace(fri.Name, fri.Extension, "")
    '                Dim webserviceurl As String
    '                webserviceurl = ConfigINI.GetValue("Setting", "webserviceurl")
    '                Dim ws As New RFIDHERO2014WebServiceAPI.RFIDHERO2014WebServiceAPI
    '                ws.Url = webserviceurl
    '                Dim buffer_logo As Byte() = File.ReadAllBytes(fri.FullName)
    '                Dim buffer_nologo As Byte() = File.ReadAllBytes(fri.Directory.Parent.FullName & "\NoLogo\" & filename & "_nologo.jpg")
    '                If ws.SaveImageFile(filename, buffer_logo, buffer_nologo) Then
    '                    File.Delete(fri.FullName)
    '                    File.Delete(fri.Directory.Parent.FullName & "\NoLogo\" & filename & "_nologo.jpg")
    '                End If
    '            Next fri
    '        Catch ex As Exception
    '            'MessageBox.Show(ex.ToString())
    '            'Timer1.Enabled = False
    '            'Exit Sub
    '        End Try

    '        Application.DoEvents()
    '        IsFinish = True
    '    Loop
    '    Timer1.Enabled = True
    'End Sub

    Private Function GetDataTable(sql As String) As DataTable
        Dim dt As New DataTable
        Try
            Dim iniReader1 As New Org.Mentalis.Files.IniReader(Application.StartupPath & "\kiosk.ini")
            Dim servername, Fromdatabasename, dbUserid, dbUserPassword, strconn As String
            servername = iniReader1.ReadString("Database", "ServerName")
            dbUserid = iniReader1.ReadString("Database", "Username")
            dbUserPassword = iniReader1.ReadString("Database", "Password")
            Fromdatabasename = iniReader1.ReadString("Database", "Database")
            strconn = "Data Source=" & servername & _
                          ";Persist Security Info=True;Password=" & dbUserPassword & _
                          ";User ID=" & dbUserid & ";Initial Catalog=" & Fromdatabasename
            conn = New SqlConnection(strconn)
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim myadapter As New SqlDataAdapter(sql, conn)
            myadapter.Fill(dt)

        Catch ex As Exception
            dt = New DataTable
        End Try
        Return dt
    End Function

    Function GetInfo(ByVal Number As String) As DataTable
        Dim sql As String = "Select * from ERM_TS_PERSONAL_INFO "
        sql += " Where (ID='" & Number & "' or  replace(mobile_no,'-','') ='" & Number & "') "
        sql += " and member_no is not null"
        Dim dt As DataTable = GetDataTable(sql)
        If dt.Rows.Count > 0 Then
            _id = dt.Rows(0).Item("ID").ToString

            If Convert.IsDBNull(dt.Rows(0)("member_no")) = False Then
                _MemberNo = dt.Rows(0)("member_no").ToString
            End If
        Else
            _id = 0
            _MemberNo = ""
        End If
        conn.Close()
        Return dt
    End Function

    Sub OK()
        Try
            Dim dt As New DataTable
            dt = GetInfo(txtNumber.Text)
            If dt.Rows.Count > 0 Then
                frmKiosCapture.Show()
                txtNumber.Text = ""
                Dim player As New System.Media.SoundPlayer(Application.StartupPath & "\sound.wav")
                player.Play()

            Else
                frmDialogMsg.lblText.Text = "ไม่พบข้อมูล กรุณาลงทะเบียนก่อนค่ะ"
                frmDialogMsg.ShowDialog()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#Region "btnNumberClick"
    Dim k_len As Integer = 10

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "1"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "2"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "3"
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "4"
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "5"
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "6"
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "7"
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "8"
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "9"
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OK.Click
        OK()
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        If txtNumber.Text.Length = 10 Then Exit Sub
        txtNumber.Text = txtNumber.Text & "0"
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If txtNumber.Text <> "" Then txtNumber.Text = txtNumber.Text.Substring(0, (txtNumber.Text.Length - 1))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OK()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
#End Region

    Private Sub TimerSentImage_Tick(sender As Object, e As EventArgs) Handles TimerSentImage.Tick
        TimerSentImage.Enabled = False
        SentImage()
        TimerSentImage.Enabled = True
    End Sub

    Private Sub SentImage()
        Try
            Dim ini As New Org.Mentalis.Files.IniReader(Application.StartupPath & "\kiosk.ini")
            ini.Section = "CaptureImage"
            Dim ImgPath As String = ini.ReadString("savepath")
            If Directory.Exists(ImgPath) = True Then
                Dim fWs As New FacebookWebService.WebService
                fWs.Url = GetCfSysconfig("FacebookWebServiceURL")
                fWs.Timeout = 2000   '2 วินาที
                For Each f As String In Directory.GetFiles(ImgPath)
                    Try
                        Dim fInfo As New FileInfo(f)
                        Dim fName As String = Split(fInfo.Name, ".")(0)
                        Dim FileByte() As Byte = File.ReadAllBytes(f)

                        'ส่งรูปไปยังเครื่อง Facebook
                        Dim ret As Boolean = False
                        ret = fWs.SendImage(fName, FileByte, "Facebook")

                        If ret = True Then
                            'ถ้าส่งสำเร็จทั้งสองที่ ก็ลบไฟล์เลย
                            Try
                                File.SetAttributes(f, FileAttributes.Normal)
                                File.Delete(f)
                            Catch ex As Exception

                            End Try
                        End If
                    Catch ex As Exception

                    End Try
                Next
                fWs.Dispose()
            End If
            ini = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetCfSysconfig(ConfigName As String) As String
        Dim ret As String = ""
        Try
            Dim sql As String = "select config_value "
            Sql += " from cf_sysconfig "
            sql += " where config_name ='" + ConfigName + "'"
            Dim dt As DataTable = GetDataTable(sql)
            If dt.Rows.Count > 0 Then
                If IsDBNull(dt.Rows(0)("config_value")) = False Then
                    ret = dt.Rows(0)("config_value")
                End If
            End If
            dt.Dispose()
        Catch ex As Exception
            ret = ""
        End Try
        Return ret
    End Function

End Class