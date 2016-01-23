Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.IO

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class WebService
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function SendImage(id As String, image As Byte(), imgSourse As String) As Boolean
        Try
            ' Dim strImage As String = image
            Dim strImageext As String = "jpg"
            Dim strId As String = id
            Dim strtagid As String = ""

            Dim strpath As String = ""
            If imgSourse = "Greeting" Then
                strpath = "D:\GreetingImage"
            Else
                strpath = "D:\RFIDHERO2015\FacebookImage"
            End If

            If (Not System.IO.Directory.Exists(strpath)) Then
                System.IO.Directory.CreateDirectory(strpath)
            End If
            ' Dim bytesimage As Byte()
            ' bytesimage = Convert.FromBase64String(strImage)
            Dim ms1 As New MemoryStream(image)
            'write to file
            Dim file1 As New FileStream(strpath & "\" & strId & "." & strImageext, FileMode.Create, FileAccess.Write)
            ms1.WriteTo(file1)
            file1.Close()
            ms1.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class