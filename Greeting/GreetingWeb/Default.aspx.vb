Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports ConnectDB

Partial Class _Default
    Inherits System.Web.UI.Page


    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader


    Protected ReadOnly Property INIFileName() As IniReader
        Get
            Dim INIFlie As String = "C:\Windows\RFIDHERO2015.ini"
            Dim ini As New IniReader(INIFlie)
            ini.Section = "DbSetting"
            Return ini
        End Get
    End Property
    Private ReadOnly Property GetConnectionString() As String
        Get
            Try
                Dim ini As IniReader = INIFileName
                Dim DBServerName As String = ini.ReadString("DBServerName")
                Dim DBDatabaseName As String = ini.ReadString("DBDatabaseName")
                Dim DBDbUserID As String = ini.ReadString("DBDbUserID")
                Dim DBDbPwd As String = ini.ReadString("DBDbPwd")
                ini = Nothing

                Dim ret As String = "Data Source=" & DBServerName & ";Initial Catalog=" & DBDatabaseName & ";User ID=" & DBDbUserID & ";Password=" & DBDbPwd

                Return ret
            Catch ex As Exception
                Throw New ApplicationException("GetConnectionString Error", ex)
            End Try
        End Get
    End Property

    Protected ReadOnly Property intervaltime As String
        Get
            Dim INIFlie As String = "C:\Windows\RFIDHERO2015.ini"
            Dim ini As New IniReader(INIFlie)
            ini.Section = "DbSetting"
            Return ini.ReadString("intervaltime")
        End Get
    End Property

    Protected ReadOnly Property IpGreeting As String
        Get
            Dim INIFlie As String = "C:\Windows\RFIDHERO2015.ini"
            Dim ini As New IniReader(INIFlie)
            ini.Section = "DbSetting"
            Return ini.ReadString("IpGreeting")
        End Get
    End Property

    Private Sub getData()
        Try
            'Connecttion string
            ' Dim strconstring As String = "Data Source=192.168.1.111;Initial Catalog=RFIDHERO2015;User ID=sa;Password=1qaz@WSX"
            'Create a Connection object.
            myConn = New SqlConnection(GetConnectionString)


            'Create a Command object.
            Dim strSql As String
            strSql = " select  "
            strSql &= "  c.id"
            strSql &= "  ,tagid"
            strSql &= "  ,'คุณ ' + c.first_name as fullname"
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
                table1.Style.Add("display", "")
                table2.Style.Add("display", "none")
                ShowDataType1(dt)
            Else
                table1.Style.Add("display", "none")
                table2.Style.Add("display", "")
                ShowDataType2(dt)
            End If
        Catch ex As Exception
            ' ex.Message.ToString)
        End Try
    End Sub
    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Interval = Val(intervaltime) * 1000
        getData()
    End Sub
    Public Sub ShowDataType1(dt As DataTable)
        table_sub1_Type1.Style.Add("display", "none")
        table_sub2_Type1.Style.Add("display", "none")
        table_sub3_Type1.Style.Add("display", "none")
        table_sub4_Type1.Style.Add("display", "none")

        For i As Integer = 0 To dt.Rows.Count - 1
            'Dim PictureBoxImage As Image = Me.FindControl("PictureBoxImage" + i + 1 + "_Type2")
            'Dim lblname As Label = Me.FindControl("lblname" + i + 1 + "_Type2")
            'Dim lbldetail As Label = Me.FindControl("lblname" + i + 1 + "_Type2")
            'lblname.Text = dt.Rows(i)("fullname")
            'lbldetail.Text = dt.Rows(i)("company_name")
            Dim strpath = "http://" & IpGreeting & "/GreetingImage" & "/" & dt.Rows(i)("tagid") & "" & ".jpg"

            'PictureBoxImage.ImageUrl = strpath

            Select Case i + 1
                Case 1
                    lblname1_type1.Text = dt.Rows(i)("fullname")
                    lbldetail1_type1.Text = dt.Rows(i)("company_name")
                    PictureBoxImage1_Type1.ImageUrl = strpath
                    table_sub1_Type1.Style.Add("display", "")

                Case 2
                    lblname2_type1.Text = dt.Rows(i)("fullname")
                    lbldetail2_type1.Text = dt.Rows(i)("company_name")
                    PictureBoxImage2_Type1.ImageUrl = strpath
                    table_sub2_Type1.Style.Add("display", "")
                Case 3
                    lblname3_type1.Text = dt.Rows(i)("fullname")
                    lbldetail3_type1.Text = dt.Rows(i)("company_name")
                    PictureBoxImage3_Type1.ImageUrl = strpath
                    table_sub3_Type1.Style.Add("display", "")
                Case 4
                    lblname4_type1.Text = dt.Rows(i)("fullname")
                    lbldetail4_type1.Text = dt.Rows(i)("company_name")
                    PictureBoxImage4_Type1.ImageUrl = strpath
                    table_sub4_Type1.Style.Add("display", "")

            End Select
        Next
    End Sub
    Public Sub ShowDataType2(dt As DataTable)
        Dim strTagall As String = ""
        Dim strTagacount As Integer = 0
        table_sub1_Type2.Style.Add("display", "none")
        table_sub2_Type2.Style.Add("display", "none")
        table_sub3_Type2.Style.Add("display", "none")
        table_sub4_Type2.Style.Add("display", "none")
        table_sub5_Type2.Style.Add("display", "none")
        table_sub6_Type2.Style.Add("display", "none")
        table_sub7_Type2.Style.Add("display", "none")
        table_sub8_Type2.Style.Add("display", "none")
        For i As Integer = 0 To dt.Rows.Count - 1
            'Dim PictureBoxImage As Image = Me.FindControl("PictureBoxImage" + i + 1 + "_Type2")
            'Dim lblname As Label = Me.FindControl("lblname" + i + 1 + "_Type2")
            'Dim lbldetail As Label = Me.FindControl("lblname" + i + 1 + "_Type2")
            'lblname.Text = dt.Rows(i)("fullname")
            'lbldetail.Text = dt.Rows(i)("company_name")
            Dim strpath = "http://" & IpGreeting & "/GreetingImage" & "/" & dt.Rows(i)("tagid") & "" & ".jpg"

            'PictureBoxImage.ImageUrl = strpath

            Select Case i + 1
                Case 1
                    lblname1_type2.Text = dt.Rows(i)("fullname")
                    lbldetail1_type2.Text = setString(dt.Rows(i)("company_name"))
                    PictureBoxImage1_Type2.ImageUrl = strpath
                    table_sub1_Type2.Style.Add("display", "")
                    strTagall = "'" & dt.Rows(i)("tagid") & "'"
                    strTagacount += 1
                Case 2
                    lblname2_type2.Text = dt.Rows(i)("fullname")
                    lbldetail2_type2.Text = setString(dt.Rows(i)("company_name"))
                    PictureBoxImage2_Type2.ImageUrl = strpath
                    table_sub2_Type2.Style.Add("display", "")
                    strTagall &= ",'" & dt.Rows(i)("tagid") & "'"
                    strTagacount += 1
                Case 3
                    lblname3_type2.Text = dt.Rows(i)("fullname")
                    lbldetail3_type2.Text = setString(dt.Rows(i)("company_name"))
                    PictureBoxImage3_Type2.ImageUrl = strpath
                    table_sub3_Type2.Style.Add("display", "")
                    strTagall &= ",'" & dt.Rows(i)("tagid") & "'"
                    strTagacount += 1
                Case 4
                    lblname4_type2.Text = dt.Rows(i)("fullname")
                    lbldetail4_type2.Text = setString(dt.Rows(i)("company_name"))
                    PictureBoxImage4_Type2.ImageUrl = strpath
                    table_sub4_Type2.Style.Add("display", "")
                    strTagall &= ",'" & dt.Rows(i)("tagid") & "'"
                    strTagacount += 1
                Case 5
                    lblname5_type2.Text = dt.Rows(i)("fullname")
                    lbldetail5_type2.Text = setString(dt.Rows(i)("company_name"))
                    PictureBoxImage5_Type2.ImageUrl = strpath
                    table_sub5_Type2.Style.Add("display", "")
                    strTagall &= ",'" & dt.Rows(i)("tagid") & "'"
                    strTagacount += 1
                Case 6
                    lblname6_type2.Text = dt.Rows(i)("fullname")
                    lbldetail6_type2.Text = setString(dt.Rows(i)("company_name"))
                    PictureBoxImage6_Type2.ImageUrl = strpath
                    table_sub6_Type2.Style.Add("display", "")
                    strTagall &= ",'" & dt.Rows(i)("tagid") & "'"
                    strTagacount += 1
                Case 7
                    lblname7_type2.Text = dt.Rows(i)("fullname")
                    lbldetail7_type2.Text = setString(dt.Rows(i)("company_name"))
                    PictureBoxImage7_Type2.ImageUrl = strpath
                    table_sub7_Type2.Style.Add("display", "")
                    strTagall &= ",'" & dt.Rows(i)("tagid") & "'"
                    strTagacount += 1
                Case 8
                    lblname8_type2.Text = dt.Rows(i)("fullname")
                    lbldetail8_type2.Text = setString(dt.Rows(i)("company_name"))
                    PictureBoxImage8_Type2.ImageUrl = strpath
                    table_sub8_Type2.Style.Add("display", "")
                    strTagall &= ",'" & dt.Rows(i)("tagid") & "'"
                    strTagacount += 1
            End Select
        Next

        If strTagacount = 8 Then
            If strTagall <> "" Then
                If ChecktData(strTagall) = True Then
                    UpDateData(strTagall)
                End If

            End If
        End If
    End Sub

    Private Function setString(str As String) As String

        If str.Length > 25 Then
            Return str.Substring(0, 35) & ".."
        Else
            Return str
        End If
    End Function

    Private Sub UpDateData(TagIdall As String)
        Try
            'Connecttion string
            ' Dim strconstring As String = "Data Source=192.168.1.111;Initial Catalog=RFIDHERO2015;User ID=sa;Password=1qaz@WSX"
            'Create a Connection object.
            myConn = New SqlConnection(GetConnectionString)


            'Create a Command object.
            Dim strSql As String
            strSql = " update tb_greeting"
            strSql &= " set isgreeting='Y'"
            strSql &= " where tagid in (" & TagIdall & ")"
         
            myCmd = myConn.CreateCommand
            myCmd.CommandText = strSql

            'Open the connection.
            myConn.Open()

            Dim ret As Integer = myCmd.ExecuteNonQuery

            'Close the reader and the database connection.
            myConn.Close()
            
        Catch ex As Exception

        End Try
    End Sub

    Private Function ChecktData(tagid As String) As Boolean
        Try
            'Connecttion string
            ' Dim strconstring As String = "Data Source=192.168.1.111;Initial Catalog=RFIDHERO2015;User ID=sa;Password=1qaz@WSX"
            'Create a Connection object.
            myConn = New SqlConnection(GetConnectionString)


            'Create a Command object.
            Dim strSql As String
            strSql = " select  "
            strSql &= "  c.id"
            strSql &= "  from TB_GREETING g "
            strSql &= "  inner join ERM_TS_PERSONAL_INFO c"
            strSql &= "  on g.tagid = c.member_no"
            strSql &= "  where isgreeting='N' and tagid not in(" & tagid & ")"
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

            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
