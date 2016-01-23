
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace TABLE
    'Represents a transaction for QUESTION_CHOICE_CONFIG table Parameter.
    '[Create by  on October, 24 2011]

    <Table(Name:="QUESTION_CHOICE_CONFIG")>  _
    Public Class QuestionChoiceConfigPara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1,1,1)
        Dim _UPDATE_BY As  String  = ""
        Dim _UPDATE_ON As  System.Nullable(Of DateTime)  = New DateTime(1,1,1)
        Dim _QUESTIONNAIRE_QUESTION_ID As  System.Nullable(Of Long)  = 0
        Dim _CONFIG_NAME As  String  = ""
        Dim _CONFIG_VALUE As  String  = ""

        'Generate Field Property 
        <Column(Storage:="_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property ID() As Long
            Get
                Return _ID
            End Get
            Set(ByVal value As Long)
               _ID = value
            End Set
        End Property 
        <Column(Storage:="_CREATE_BY", DbType:="VarChar(50) NOT NULL ",CanBeNull:=false)>  _
        Public Property CREATE_BY() As String
            Get
                Return _CREATE_BY
            End Get
            Set(ByVal value As String)
               _CREATE_BY = value
            End Set
        End Property 
        <Column(Storage:="_CREATE_ON", DbType:="DateTime NOT NULL ",CanBeNull:=false)>  _
        Public Property CREATE_ON() As DateTime
            Get
                Return _CREATE_ON
            End Get
            Set(ByVal value As DateTime)
               _CREATE_ON = value
            End Set
        End Property 
        <Column(Storage:="_UPDATE_BY", DbType:="VarChar(50)")>  _
        Public Property UPDATE_BY() As  String 
            Get
                Return _UPDATE_BY
            End Get
            Set(ByVal value As  String )
               _UPDATE_BY = value
            End Set
        End Property 
        <Column(Storage:="_UPDATE_ON", DbType:="DateTime")>  _
        Public Property UPDATE_ON() As  System.Nullable(Of DateTime) 
            Get
                Return _UPDATE_ON
            End Get
            Set(ByVal value As  System.Nullable(Of DateTime) )
               _UPDATE_ON = value
            End Set
        End Property 
        <Column(Storage:="_QUESTIONNAIRE_QUESTION_ID", DbType:="BigInt")>  _
        Public Property QUESTIONNAIRE_QUESTION_ID() As  System.Nullable(Of Long) 
            Get
                Return _QUESTIONNAIRE_QUESTION_ID
            End Get
            Set(ByVal value As  System.Nullable(Of Long) )
               _QUESTIONNAIRE_QUESTION_ID = value
            End Set
        End Property 
        <Column(Storage:="_CONFIG_NAME", DbType:="VarChar(100)")>  _
        Public Property CONFIG_NAME() As  String 
            Get
                Return _CONFIG_NAME
            End Get
            Set(ByVal value As  String )
               _CONFIG_NAME = value
            End Set
        End Property 
        <Column(Storage:="_CONFIG_VALUE", DbType:="VarChar(100)")>  _
        Public Property CONFIG_VALUE() As  String 
            Get
                Return _CONFIG_VALUE
            End Get
            Set(ByVal value As  String )
               _CONFIG_VALUE = value
            End Set
        End Property 


    End Class
End Namespace
