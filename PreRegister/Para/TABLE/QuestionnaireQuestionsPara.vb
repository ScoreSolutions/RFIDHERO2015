
Imports System.Data.Linq 
Imports System.Data.Linq.Mapping 
Imports System.Linq 
Imports System.Linq.Expressions 

Namespace TABLE
    'Represents a transaction for QUESTIONNAIRE_QUESTIONS table Parameter.
    '[Create by  on October, 24 2011]

    <Table(Name:="QUESTIONNAIRE_QUESTIONS")>  _
    Public Class QuestionnaireQuestionsPara

        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1,1,1)
        Dim _UPDATE_BY As  String  = ""
        Dim _UPDATE_ON As  System.Nullable(Of DateTime)  = New DateTime(1,1,1)
        Dim _QUESTIONNAIRE_SECTION_ID As Long = 0
        Dim _QUESTION_NAME As String = ""
        Dim _CHOICE_TYPE_ID As Long = 0
        Dim _QUESTION_POINT As Double = 0
        Dim _IS_REQUIRE As Char = ""

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
        <Column(Storage:="_QUESTIONNAIRE_SECTION_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTIONNAIRE_SECTION_ID() As Long
            Get
                Return _QUESTIONNAIRE_SECTION_ID
            End Get
            Set(ByVal value As Long)
               _QUESTIONNAIRE_SECTION_ID = value
            End Set
        End Property 
        <Column(Storage:="_QUESTION_NAME", DbType:="VarChar(255) NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTION_NAME() As String
            Get
                Return _QUESTION_NAME
            End Get
            Set(ByVal value As String)
               _QUESTION_NAME = value
            End Set
        End Property 
        <Column(Storage:="_CHOICE_TYPE_ID", DbType:="BigInt NOT NULL ",CanBeNull:=false)>  _
        Public Property CHOICE_TYPE_ID() As Long
            Get
                Return _CHOICE_TYPE_ID
            End Get
            Set(ByVal value As Long)
               _CHOICE_TYPE_ID = value
            End Set
        End Property 
        <Column(Storage:="_QUESTION_POINT", DbType:="Double NOT NULL ",CanBeNull:=false)>  _
        Public Property QUESTION_POINT() As Double
            Get
                Return _QUESTION_POINT
            End Get
            Set(ByVal value As Double)
               _QUESTION_POINT = value
            End Set
        End Property 
        <Column(Storage:="_IS_REQUIRE", DbType:="Char(1) NOT NULL ",CanBeNull:=false)>  _
        Public Property IS_REQUIRE() As Char
            Get
                Return _IS_REQUIRE
            End Get
            Set(ByVal value As Char)
               _IS_REQUIRE = value
            End Set
        End Property 


            'Define Child Table 

       Dim _ANSWER_RESULT_questionnaire_question_id As DataTable
       Dim _QUESTION_CHOICE_CONFIG_questionnaire_question_id As DataTable
       Dim _QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id As DataTable

       Public Property CHILD_ANSWER_RESULT_questionnaire_question_id() As DataTable
           Get
               Return _ANSWER_RESULT_questionnaire_question_id
           End Get
           Set(ByVal value As DataTable)
               _ANSWER_RESULT_questionnaire_question_id = value
           End Set
       End Property
       Public Property CHILD_QUESTION_CHOICE_CONFIG_questionnaire_question_id() As DataTable
           Get
               Return _QUESTION_CHOICE_CONFIG_questionnaire_question_id
           End Get
           Set(ByVal value As DataTable)
               _QUESTION_CHOICE_CONFIG_questionnaire_question_id = value
           End Set
       End Property
       Public Property CHILD_QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id() As DataTable
           Get
               Return _QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id
           End Get
           Set(ByVal value As DataTable)
               _QUESTIONNAIRE_QUESTIONS_CHOICE_questionnaire_questions_id = value
           End Set
       End Property
    End Class
End Namespace
