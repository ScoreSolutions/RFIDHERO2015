Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports ConnectDB

Partial Class SendData
    Inherits System.Web.UI.Page

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

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
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strMethod As String = Request.QueryString("method") & ""
        Dim strTagId As String = Request.QueryString("tagid") & ""
        Select Case strMethod.ToLower
            Case "save"
                If ChecktData(strTagId.Substring(0, 9)) Then
                    UpDateData(strTagId.Substring(0, 9))
                Else
                    saveData(strTagId.Substring(0, 9))
                End If

        End Select
    End Sub

    Private Sub saveData(TagId As String)
        Try
            'Connecttion string
            ' Dim strconstring As String = "Data Source=192.168.1.111;Initial Catalog=RFIDHERO2015;User ID=sa;Password=1qaz@WSX"
            'Create a Connection object.
            myConn = New SqlConnection(GetConnectionString)


            'Create a Command object.
            Dim strSql As String
            strSql = " insert into tb_greeting"
            strSql &= "          (id"
            strSql &= " ,tagid"
            strSql &= " ,isgreeting"
            strSql &= " ,create_on"
            strSql &= " ,create_by"
            strSql &= " )"
            strSql &= " select "
            strSql &= " isnull((select max(id)  from tb_greeting),0) +1 as maxid"
            strSql &= " ,'" & TagId & "'"
            strSql &= " ,'N'"
            strSql &= " ,getdate()"
            strSql &= " ,'Reader'"
            strSql &= " where '" + TagId + "' not in (select tagid from tb_greeting)"
            myCmd = myConn.CreateCommand
            myCmd.CommandText = strSql

            'Open the connection.
            myConn.Open()

            Dim ret As Integer = myCmd.ExecuteNonQuery

            'Close the reader and the database connection.
            myConn.Close()
            If ret <> -1 Then
                Response.Write("true")
            Else
                Response.Write("false")
            End If
        Catch ex As Exception
            Response.Write("false")
        End Try
    End Sub

    Private Sub UpDateData(TagId As String)
        Try
            'Connecttion string
            ' Dim strconstring As String = "Data Source=192.168.1.111;Initial Catalog=RFIDHERO2015;User ID=sa;Password=1qaz@WSX"
            'Create a Connection object.
            myConn = New SqlConnection(GetConnectionString)


            'Create a Command object.
            Dim strSql As String
            strSql = " update tb_greeting"
            strSql &= " set isgreeting='N',create_on = getdate()"
            strSql &= " where tagid = '" & TagId & "'"

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
            strSql &= "  g.id"
            strSql &= "  from TB_GREETING g "
            strSql &= "  where  g.tagid ='" & tagid & "'"
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
