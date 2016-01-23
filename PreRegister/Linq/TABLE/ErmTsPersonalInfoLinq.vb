Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports DB = Linq.Common.Utilities.SqlDB
Imports Para.TABLE
Imports Para.Common.Utilities

Namespace TABLE
    'Represents a transaction for ERM_TS_PERSONAL_INFO table LinqDB.
    '[Create by  on September, 12 2015]
    Public Class ErmTsPersonalInfoLinq
        Public Sub ErmTsPersonalInfoLinq()

        End Sub
        ' ERM_TS_PERSONAL_INFO
        Const _tableName As String = "ERM_TS_PERSONAL_INFO"
        Dim _deletedRow As Int16 = 0

        'Set Common Property
        Dim _error As String = ""
        Dim _information As String = ""
        Dim _haveData As Boolean = False

        Public ReadOnly Property TableName As String
            Get
                Return _tableName
            End Get
        End Property
        Public ReadOnly Property ErrorMessage As String
            Get
                Return _error
            End Get
        End Property
        Public ReadOnly Property InfoMessage As String
            Get
                Return _information
            End Get
        End Property
        Public ReadOnly Property HaveData As Boolean
            Get
                Return _haveData
            End Get
        End Property


        'Generate Field List
        Dim _ID As Long = 0
        Dim _CREATE_BY As String = ""
        Dim _CREATE_ON As DateTime = New DateTime(1, 1, 1)
        Dim _UPDATE_BY As String = ""
        Dim _UPDATE_ON As System.Nullable(Of DateTime) = New DateTime(1, 1, 1)
        Dim _IDCARD_NO As String = ""
        Dim _TITLE_NAME As String = ""
        Dim _FIRST_NAME As String = ""
        Dim _MIDDLE_NAME As String = ""
        Dim _LAST_NAME As String = ""
        Dim _POSITION_NAME As String = ""
        Dim _COMPANY_NAME As String = ""
        Dim _ADDRESS As String = ""
        Dim _CITY As String = ""
        Dim _STATE As String = ""
        Dim _COUNTRY As String = ""
        Dim _ZIPCODE As String = ""
        Dim _TELNO As String = ""
        Dim _FAXNO As String = ""
        Dim _EMAIL As String = ""
        Dim _WEBSITE As String = ""
        Dim _REGISTERED_CAPITAL As System.Nullable(Of Double) = 0
        Dim _ANNUAL_SALE_VALUE_YEAR As System.Nullable(Of Long) = 0
        Dim _ANNUAL_SALE_VALUE_VOLUMNS As String = ""
        Dim _DIVISION As String = ""
        Dim _MOBILE_NO As String = ""
        Dim _REGISPERIOD As String = ""
        Dim _IS_SEND_MAIL As String = "N"
        Dim _MEMBER_NO As String = ""
        Dim _MEMBER_TYPE As System.Nullable(Of Char) = ""
        Dim _VALID_DATE As System.Nullable(Of DateTime) = New DateTime(1, 1, 1)
        Dim _EXPIRE_DATE As System.Nullable(Of DateTime) = New DateTime(1, 1, 1)

        'Generate Field Property 
        <Column(Storage:="_ID", DbType:="BigInt NOT NULL ", CanBeNull:=False)> _
        Public Property ID() As Long
            Get
                Return _ID
            End Get
            Set(ByVal value As Long)
                _ID = value
            End Set
        End Property
        <Column(Storage:="_CREATE_BY", DbType:="VarChar(100) NOT NULL ", CanBeNull:=False)> _
        Public Property CREATE_BY() As String
            Get
                Return _CREATE_BY
            End Get
            Set(ByVal value As String)
                _CREATE_BY = value
            End Set
        End Property
        <Column(Storage:="_CREATE_ON", DbType:="DateTime NOT NULL ", CanBeNull:=False)> _
        Public Property CREATE_ON() As DateTime
            Get
                Return _CREATE_ON
            End Get
            Set(ByVal value As DateTime)
                _CREATE_ON = value
            End Set
        End Property
        <Column(Storage:="_UPDATE_BY", DbType:="VarChar(100)")> _
        Public Property UPDATE_BY() As String
            Get
                Return _UPDATE_BY
            End Get
            Set(ByVal value As String)
                _UPDATE_BY = value
            End Set
        End Property
        <Column(Storage:="_UPDATE_ON", DbType:="DateTime")> _
        Public Property UPDATE_ON() As System.Nullable(Of DateTime)
            Get
                Return _UPDATE_ON
            End Get
            Set(ByVal value As System.Nullable(Of DateTime))
                _UPDATE_ON = value
            End Set
        End Property
        <Column(Storage:="_IDCARD_NO", DbType:="VarChar(13)")> _
        Public Property IDCARD_NO() As String
            Get
                Return _IDCARD_NO
            End Get
            Set(ByVal value As String)
                _IDCARD_NO = value
            End Set
        End Property
        <Column(Storage:="_TITLE_NAME", DbType:="VarChar(255)")> _
        Public Property TITLE_NAME() As String
            Get
                Return _TITLE_NAME
            End Get
            Set(ByVal value As String)
                _TITLE_NAME = value
            End Set
        End Property
        <Column(Storage:="_FIRST_NAME", DbType:="VarChar(255)")> _
        Public Property FIRST_NAME() As String
            Get
                Return _FIRST_NAME
            End Get
            Set(ByVal value As String)
                _FIRST_NAME = value
            End Set
        End Property
        <Column(Storage:="_MIDDLE_NAME", DbType:="VarChar(255)")> _
        Public Property MIDDLE_NAME() As String
            Get
                Return _MIDDLE_NAME
            End Get
            Set(ByVal value As String)
                _MIDDLE_NAME = value
            End Set
        End Property
        <Column(Storage:="_LAST_NAME", DbType:="VarChar(255)")> _
        Public Property LAST_NAME() As String
            Get
                Return _LAST_NAME
            End Get
            Set(ByVal value As String)
                _LAST_NAME = value
            End Set
        End Property
        <Column(Storage:="_POSITION_NAME", DbType:="VarChar(255)")> _
        Public Property POSITION_NAME() As String
            Get
                Return _POSITION_NAME
            End Get
            Set(ByVal value As String)
                _POSITION_NAME = value
            End Set
        End Property
        <Column(Storage:="_COMPANY_NAME", DbType:="VarChar(255)")> _
        Public Property COMPANY_NAME() As String
            Get
                Return _COMPANY_NAME
            End Get
            Set(ByVal value As String)
                _COMPANY_NAME = value
            End Set
        End Property
        <Column(Storage:="_ADDRESS", DbType:="VarChar(255)")> _
        Public Property ADDRESS() As String
            Get
                Return _ADDRESS
            End Get
            Set(ByVal value As String)
                _ADDRESS = value
            End Set
        End Property
        <Column(Storage:="_CITY", DbType:="VarChar(255)")> _
        Public Property CITY() As String
            Get
                Return _CITY
            End Get
            Set(ByVal value As String)
                _CITY = value
            End Set
        End Property
        <Column(Storage:="_STATE", DbType:="VarChar(255)")> _
        Public Property STATE() As String
            Get
                Return _STATE
            End Get
            Set(ByVal value As String)
                _STATE = value
            End Set
        End Property
        <Column(Storage:="_COUNTRY", DbType:="VarChar(255)")> _
        Public Property COUNTRY() As String
            Get
                Return _COUNTRY
            End Get
            Set(ByVal value As String)
                _COUNTRY = value
            End Set
        End Property
        <Column(Storage:="_ZIPCODE", DbType:="VarChar(50)")> _
        Public Property ZIPCODE() As String
            Get
                Return _ZIPCODE
            End Get
            Set(ByVal value As String)
                _ZIPCODE = value
            End Set
        End Property
        <Column(Storage:="_TELNO", DbType:="VarChar(255)")> _
        Public Property TELNO() As String
            Get
                Return _TELNO
            End Get
            Set(ByVal value As String)
                _TELNO = value
            End Set
        End Property
        <Column(Storage:="_FAXNO", DbType:="VarChar(255)")> _
        Public Property FAXNO() As String
            Get
                Return _FAXNO
            End Get
            Set(ByVal value As String)
                _FAXNO = value
            End Set
        End Property
        <Column(Storage:="_EMAIL", DbType:="VarChar(255)")> _
        Public Property EMAIL() As String
            Get
                Return _EMAIL
            End Get
            Set(ByVal value As String)
                _EMAIL = value
            End Set
        End Property
        <Column(Storage:="_WEBSITE", DbType:="VarChar(255)")> _
        Public Property WEBSITE() As String
            Get
                Return _WEBSITE
            End Get
            Set(ByVal value As String)
                _WEBSITE = value
            End Set
        End Property
        <Column(Storage:="_REGISTERED_CAPITAL", DbType:="Double")> _
        Public Property REGISTERED_CAPITAL() As System.Nullable(Of Double)
            Get
                Return _REGISTERED_CAPITAL
            End Get
            Set(ByVal value As System.Nullable(Of Double))
                _REGISTERED_CAPITAL = value
            End Set
        End Property
        <Column(Storage:="_ANNUAL_SALE_VALUE_YEAR", DbType:="Int")> _
        Public Property ANNUAL_SALE_VALUE_YEAR() As System.Nullable(Of Long)
            Get
                Return _ANNUAL_SALE_VALUE_YEAR
            End Get
            Set(ByVal value As System.Nullable(Of Long))
                _ANNUAL_SALE_VALUE_YEAR = value
            End Set
        End Property
        <Column(Storage:="_ANNUAL_SALE_VALUE_VOLUMNS", DbType:="VarChar(50)")> _
        Public Property ANNUAL_SALE_VALUE_VOLUMNS() As String
            Get
                Return _ANNUAL_SALE_VALUE_VOLUMNS
            End Get
            Set(ByVal value As String)
                _ANNUAL_SALE_VALUE_VOLUMNS = value
            End Set
        End Property
        <Column(Storage:="_DIVISION", DbType:="VarChar(255)")> _
        Public Property DIVISION() As String
            Get
                Return _DIVISION
            End Get
            Set(ByVal value As String)
                _DIVISION = value
            End Set
        End Property
        <Column(Storage:="_MOBILE_NO", DbType:="VarChar(255)")> _
        Public Property MOBILE_NO() As String
            Get
                Return _MOBILE_NO
            End Get
            Set(ByVal value As String)
                _MOBILE_NO = value
            End Set
        End Property
        <Column(Storage:="_REGISPERIOD", DbType:="VarChar(1)")> _
        Public Property REGISPERIOD() As String
            Get
                Return _REGISPERIOD
            End Get
            Set(ByVal value As String)
                _REGISPERIOD = value
            End Set
        End Property
        <Column(Storage:="_IS_SEND_MAIL", DbType:="VarChar(1) NOT NULL ", CanBeNull:=False)> _
        Public Property IS_SEND_MAIL() As String
            Get
                Return _IS_SEND_MAIL
            End Get
            Set(ByVal value As String)
                _IS_SEND_MAIL = value
            End Set
        End Property
        <Column(Storage:="_MEMBER_NO", DbType:="VarChar(50)")> _
        Public Property MEMBER_NO() As String
            Get
                Return _MEMBER_NO
            End Get
            Set(ByVal value As String)
                _MEMBER_NO = value
            End Set
        End Property
        <Column(Storage:="_MEMBER_TYPE", DbType:="Char(1)")> _
        Public Property MEMBER_TYPE() As System.Nullable(Of Char)
            Get
                Return _MEMBER_TYPE
            End Get
            Set(ByVal value As System.Nullable(Of Char))
                _MEMBER_TYPE = value
            End Set
        End Property
        <Column(Storage:="_VALID_DATE", DbType:="DateTime")> _
        Public Property VALID_DATE() As System.Nullable(Of DateTime)
            Get
                Return _VALID_DATE
            End Get
            Set(ByVal value As System.Nullable(Of DateTime))
                _VALID_DATE = value
            End Set
        End Property
        <Column(Storage:="_EXPIRE_DATE", DbType:="DateTime")> _
        Public Property EXPIRE_DATE() As System.Nullable(Of DateTime)
            Get
                Return _EXPIRE_DATE
            End Get
            Set(ByVal value As System.Nullable(Of DateTime))
                _EXPIRE_DATE = value
            End Set
        End Property


        'Clear All Data
        Private Sub ClearData()
            _ID = 0
            _CREATE_BY = ""
            _CREATE_ON = New DateTime(1, 1, 1)
            _UPDATE_BY = ""
            _UPDATE_ON = New DateTime(1, 1, 1)
            _IDCARD_NO = ""
            _TITLE_NAME = ""
            _FIRST_NAME = ""
            _MIDDLE_NAME = ""
            _LAST_NAME = ""
            _POSITION_NAME = ""
            _COMPANY_NAME = ""
            _ADDRESS = ""
            _CITY = ""
            _STATE = ""
            _COUNTRY = ""
            _ZIPCODE = ""
            _TELNO = ""
            _FAXNO = ""
            _EMAIL = ""
            _WEBSITE = ""
            _REGISTERED_CAPITAL = 0
            _ANNUAL_SALE_VALUE_YEAR = 0
            _ANNUAL_SALE_VALUE_VOLUMNS = ""
            _DIVISION = ""
            _MOBILE_NO = ""
            _REGISPERIOD = ""
            _IS_SEND_MAIL = "N"
            _MEMBER_NO = ""
            _MEMBER_TYPE = ""
            _VALID_DATE = New DateTime(1, 1, 1)
            _EXPIRE_DATE = New DateTime(1, 1, 1)
        End Sub

        'Define Public Method 
        'Execute the select statement with the specified condition and return a System.Data.DataTable.
        '/// <param name=whereClause>The condition for execute select statement.</param>
        '/// <param name=orderBy>The fields for sort data.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>The System.Data.DataTable object for specified condition.</returns>
        Public Function GetDataList(ByVal whClause As String, ByVal orderBy As String, ByVal trans As SQLTransaction) As DataTable
            Return DB.ExecuteTable(SqlSelect & IIf(whClause = "", "", " WHERE " & whClause) & IIf(orderBy = "", "", " ORDER BY  " & orderBy), trans)
        End Function


        'Execute the select statement with the specified condition and return a System.Data.DataTable.
        '/// <param name=whereClause>The condition for execute select statement.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>The System.Data.DataTable object for specified condition.</returns>
        Public Function GetListBySql(ByVal Sql As String, ByVal trans As SQLTransaction) As DataTable
            Return DB.ExecuteTable(Sql, trans)
        End Function


        '/// Returns an indication whether the current data is inserted into ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Public Function InsertData(LoginName As String, trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then
                _ID = DB.GetNextID("ID", TableName, trans)
                _CREATE_BY = LoginName
                _CREATE_ON = DateTime.Now
                Return doInsert(trans)
            Else
                _error = "Transaction Is not null"
                Return False
            End If
        End Function


        '/// Returns an indication whether the current data is updated to ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=userID>The current user.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateByPK(ByVal LoginName As String, ByVal trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then
                _UPDATE_BY = LoginName
                _UPDATE_ON = DateTime.Now
                Return doUpdate("ID = " & DB.SetDouble(_ID), trans)
            Else
                _error = "Transaction Is not null"
                Return False
            End If
        End Function


        '/// Returns an indication whether the current data is updated to ERM_TS_PERSONAL_INFO table successfully.
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Public Function UpdateBySql(ByVal Sql As String, ByVal trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then
                Return DB.ExecuteNonQuery(Sql, trans)
            Else
                _error = "Transaction Is not null"
                Return False
            End If
        End Function


        '/// Returns an indication whether the current data is deleted from ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Public Function DeleteByPK(ByVal cID As Long, ByVal trans As SQLTransaction) As Boolean
            If trans IsNot Nothing Then
                Return doDelete("ID = " & DB.SetDouble(cID), trans)
            Else
                _error = "Transaction Is not null"
                Return False
            End If
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByPK(ByVal cID As Long, ByVal trans As SQLTransaction) As Boolean
            Return doChkData("ID = " & DB.SetDouble(cID), trans)
        End Function


        '/// Returns an indication whether the record and Mapping field to Data Class of ERM_TS_PERSONAL_INFO by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetDataByPK(ByVal cID As Long, ByVal trans As SQLTransaction) As ErmTsPersonalInfoLinq
            Return doGetData("ID = " & DB.SetDouble(cID), trans)
        End Function


        '/// Returns an indication whether the record and Mapping field to Para Class of ERM_TS_PERSONAL_INFO by specified id key is retrieved successfully.
        '/// <param name=cid>The id key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function GetParameter(ByVal cID As Long, ByVal trans As SQLTransaction) As ErmTsPersonalInfoPara
            Return doMappingParameter("ID = " & DB.SetDouble(cID), trans)
        End Function
        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified IDCARD_NO key is retrieved successfully.
        '/// <param name=cIDCARD_NO>The IDCARD_NO key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByIDCARD_NO(ByVal cIDCARD_NO As String, ByVal trans As SQLTransaction) As Boolean
            Return doChkData("IDCARD_NO = " & DB.SetString(cIDCARD_NO) & " ", trans)
        End Function

        '/// Returns an duplicate data record of ERM_TS_PERSONAL_INFO by specified IDCARD_NO key is retrieved successfully.
        '/// <param name=cIDCARD_NO>The IDCARD_NO key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDuplicateByIDCARD_NO(ByVal cIDCARD_NO As String, ByVal cid As Long, ByVal trans As SQLTransaction) As Boolean
            Return doChkData("IDCARD_NO = " & DB.SetString(cIDCARD_NO) & " " & " And id <> " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified FIRST_NAME key is retrieved successfully.
        '/// <param name=cFIRST_NAME>The FIRST_NAME key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByFIRST_NAME(cFIRST_NAME As String, trans As SQLTransaction) As Boolean
            Return doChkData("FIRST_NAME = " & DB.SetString(cFIRST_NAME) & " ", trans)
        End Function

        '/// Returns an duplicate data record of ERM_TS_PERSONAL_INFO by specified FIRST_NAME key is retrieved successfully.
        '/// <param name=cFIRST_NAME>The FIRST_NAME key.</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDuplicateByFIRST_NAME(cFIRST_NAME As String, cid As Long, trans As SQLTransaction) As Boolean
            Return doChkData("FIRST_NAME = " & DB.SetString(cFIRST_NAME) & " " & " And id <> " & DB.SetDouble(cid) & " ", trans)
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Public Function ChkDataByWhere(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Return doChkData(whText, trans)
        End Function



        '/// Returns an indication whether the current data is inserted into ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if insert data successfully; otherwise, false.</returns>
        Private Function doInsert(ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            If _haveData = False Then
                Try

                    ret = (DB.ExecuteNonQuery(SqlInsert, trans) > 0)
                    If ret = False Then
                        _error = DB.ErrorMessage
                    Else
                        _haveData = True
                    End If
                    _information = MessageResources.MSGIN001
                Catch ex As ApplicationException
                    ret = False
                    _error = ex.Message & "ApplicationException :" & ex.ToString() & "### SQL:" & SqlInsert
                Catch ex As Exception
                    ret = False
                    _error = MessageResources.MSGEC101 & " Exception :" & ex.ToString() & "### SQL: " & SqlInsert
                End Try
            Else
                ret = False
                _error = MessageResources.MSGEN002 & "### SQL: " & SqlInsert
            End If

            Return ret
        End Function


        '/// Returns an indication whether the current data is updated to ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=whText>The condition specify the updating record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if update data successfully; otherwise, false.</returns>
        Private Function doUpdate(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            Dim tmpWhere As String = " Where " & whText
            If _haveData = True Then
                If whText.Trim() <> "" Then
                    Try

                        ret = (DB.ExecuteNonQuery(SqlUpdate & tmpWhere, trans) > 0)
                        If ret = False Then
                            _error = DB.ErrorMessage
                        End If
                        _information = MessageResources.MSGIU001
                    Catch ex As ApplicationException
                        ret = False
                        _error = ex.Message & "ApplicationException :" & ex.ToString() & "### SQL:" & SqlUpdate & tmpWhere
                    Catch ex As Exception
                        ret = False
                        _error = MessageResources.MSGEC102 & " Exception :" & ex.ToString() & "### SQL: " & SqlUpdate & tmpWhere
                    End Try
                Else
                    ret = False
                    _error = MessageResources.MSGEU003 & "### SQL: " & SqlUpdate & tmpWhere
                End If
            Else
                ret = False
                _error = MessageResources.MSGEU002 & "### SQL: " & SqlUpdate & tmpWhere
            End If

            Return ret
        End Function


        '/// Returns an indication whether the current data is deleted from ERM_TS_PERSONAL_INFO table successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if delete data successfully; otherwise, false.</returns>
        Private Function doDelete(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            Dim tmpWhere As String = " Where " & whText
            If doChkData(whText, trans) = True Then
                If whText.Trim() <> "" Then
                    Try
                        ret = (DB.ExecuteNonQuery(SqlDelete & tmpWhere, trans) > 0)
                        If ret = False Then
                            _error = MessageResources.MSGED001
                        End If
                        _information = MessageResources.MSGID001
                    Catch ex As ApplicationException
                        ret = False
                        _error = ex.Message & "ApplicationException :" & ex.ToString() & "### SQL:" & SqlDelete & tmpWhere
                    Catch ex As Exception
                        ret = False
                        _error = MessageResources.MSGEC103 & " Exception :" & ex.ToString() & "### SQL: " & SqlDelete & tmpWhere
                    End Try
                Else
                    ret = False
                    _error = MessageResources.MSGED003 & "### SQL: " & SqlDelete & tmpWhere
                End If
            Else
                ret = False
                _error = MessageResources.MSGEU002 & "### SQL: " & SqlDelete & tmpWhere
            End If

            Return ret
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doChkData(ByVal whText As String, ByVal trans As SQLTransaction) As Boolean
            Dim ret As Boolean = True
            Dim tmpWhere As String = " WHERE " & whText
            ClearData()
            _haveData = False
            If whText.Trim() <> "" Then
                Dim Rdr As SqlDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("id")) = False Then _ID = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("create_by")) = False Then _CREATE_BY = Rdr("create_by").ToString()
                        If Convert.IsDBNull(Rdr("create_on")) = False Then _CREATE_ON = Convert.ToDateTime(Rdr("create_on"))
                        If Convert.IsDBNull(Rdr("update_by")) = False Then _UPDATE_BY = Rdr("update_by").ToString()
                        If Convert.IsDBNull(Rdr("update_on")) = False Then _UPDATE_ON = Convert.ToDateTime(Rdr("update_on"))
                        If Convert.IsDBNull(Rdr("idcard_no")) = False Then _IDCARD_NO = Rdr("idcard_no").ToString()
                        If Convert.IsDBNull(Rdr("title_name")) = False Then _TITLE_NAME = Rdr("title_name").ToString()
                        If Convert.IsDBNull(Rdr("first_name")) = False Then _FIRST_NAME = Rdr("first_name").ToString()
                        If Convert.IsDBNull(Rdr("middle_name")) = False Then _MIDDLE_NAME = Rdr("middle_name").ToString()
                        If Convert.IsDBNull(Rdr("last_name")) = False Then _LAST_NAME = Rdr("last_name").ToString()
                        If Convert.IsDBNull(Rdr("position_name")) = False Then _POSITION_NAME = Rdr("position_name").ToString()
                        If Convert.IsDBNull(Rdr("company_name")) = False Then _COMPANY_NAME = Rdr("company_name").ToString()
                        If Convert.IsDBNull(Rdr("address")) = False Then _ADDRESS = Rdr("address").ToString()
                        If Convert.IsDBNull(Rdr("city")) = False Then _CITY = Rdr("city").ToString()
                        If Convert.IsDBNull(Rdr("state")) = False Then _STATE = Rdr("state").ToString()
                        If Convert.IsDBNull(Rdr("country")) = False Then _COUNTRY = Rdr("country").ToString()
                        If Convert.IsDBNull(Rdr("zipcode")) = False Then _ZIPCODE = Rdr("zipcode").ToString()
                        If Convert.IsDBNull(Rdr("telno")) = False Then _TELNO = Rdr("telno").ToString()
                        If Convert.IsDBNull(Rdr("faxno")) = False Then _FAXNO = Rdr("faxno").ToString()
                        If Convert.IsDBNull(Rdr("email")) = False Then _EMAIL = Rdr("email").ToString()
                        If Convert.IsDBNull(Rdr("website")) = False Then _WEBSITE = Rdr("website").ToString()
                        If Convert.IsDBNull(Rdr("registered_capital")) = False Then _REGISTERED_CAPITAL = Convert.ToDouble(Rdr("registered_capital"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_year")) = False Then _ANNUAL_SALE_VALUE_YEAR = Convert.ToInt32(Rdr("annual_sale_value_year"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_volumns")) = False Then _ANNUAL_SALE_VALUE_VOLUMNS = Rdr("annual_sale_value_volumns").ToString()
                        If Convert.IsDBNull(Rdr("division")) = False Then _DIVISION = Rdr("division").ToString()
                        If Convert.IsDBNull(Rdr("mobile_no")) = False Then _MOBILE_NO = Rdr("mobile_no").ToString()
                        If Convert.IsDBNull(Rdr("regisperiod")) = False Then _REGISPERIOD = Rdr("regisperiod").ToString()
                        If Convert.IsDBNull(Rdr("is_send_mail")) = False Then _IS_SEND_MAIL = Rdr("is_send_mail").ToString()
                        If Convert.IsDBNull(Rdr("member_no")) = False Then _MEMBER_NO = Rdr("member_no").ToString()
                        If Convert.IsDBNull(Rdr("member_type")) = False Then _MEMBER_TYPE = Rdr("member_type").ToString()
                        If Convert.IsDBNull(Rdr("valid_date")) = False Then _VALID_DATE = Convert.ToDateTime(Rdr("valid_date"))
                        If Convert.IsDBNull(Rdr("expire_date")) = False Then _EXPIRE_DATE = Convert.ToDateTime(Rdr("expire_date"))
                    Else
                        ret = False
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    ret = False
                    _error = MessageResources.MSGEC104 & " #### " & ex.ToString()
                End Try
            Else
                ret = False
                _error = MessageResources.MSGEV001
            End If

            Return ret
        End Function


        '/// Returns an indication whether the record of ERM_TS_PERSONAL_INFO by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doGetData(ByVal whText As String, ByVal trans As SQLTransaction) As ErmTsPersonalInfoLinq
            ClearData()
            _haveData = False
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SqlDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("id")) = False Then _ID = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("create_by")) = False Then _CREATE_BY = Rdr("create_by").ToString()
                        If Convert.IsDBNull(Rdr("create_on")) = False Then _CREATE_ON = Convert.ToDateTime(Rdr("create_on"))
                        If Convert.IsDBNull(Rdr("update_by")) = False Then _UPDATE_BY = Rdr("update_by").ToString()
                        If Convert.IsDBNull(Rdr("update_on")) = False Then _UPDATE_ON = Convert.ToDateTime(Rdr("update_on"))
                        If Convert.IsDBNull(Rdr("idcard_no")) = False Then _IDCARD_NO = Rdr("idcard_no").ToString()
                        If Convert.IsDBNull(Rdr("title_name")) = False Then _TITLE_NAME = Rdr("title_name").ToString()
                        If Convert.IsDBNull(Rdr("first_name")) = False Then _FIRST_NAME = Rdr("first_name").ToString()
                        If Convert.IsDBNull(Rdr("middle_name")) = False Then _MIDDLE_NAME = Rdr("middle_name").ToString()
                        If Convert.IsDBNull(Rdr("last_name")) = False Then _LAST_NAME = Rdr("last_name").ToString()
                        If Convert.IsDBNull(Rdr("position_name")) = False Then _POSITION_NAME = Rdr("position_name").ToString()
                        If Convert.IsDBNull(Rdr("company_name")) = False Then _COMPANY_NAME = Rdr("company_name").ToString()
                        If Convert.IsDBNull(Rdr("address")) = False Then _ADDRESS = Rdr("address").ToString()
                        If Convert.IsDBNull(Rdr("city")) = False Then _CITY = Rdr("city").ToString()
                        If Convert.IsDBNull(Rdr("state")) = False Then _STATE = Rdr("state").ToString()
                        If Convert.IsDBNull(Rdr("country")) = False Then _COUNTRY = Rdr("country").ToString()
                        If Convert.IsDBNull(Rdr("zipcode")) = False Then _ZIPCODE = Rdr("zipcode").ToString()
                        If Convert.IsDBNull(Rdr("telno")) = False Then _TELNO = Rdr("telno").ToString()
                        If Convert.IsDBNull(Rdr("faxno")) = False Then _FAXNO = Rdr("faxno").ToString()
                        If Convert.IsDBNull(Rdr("email")) = False Then _EMAIL = Rdr("email").ToString()
                        If Convert.IsDBNull(Rdr("website")) = False Then _WEBSITE = Rdr("website").ToString()
                        If Convert.IsDBNull(Rdr("registered_capital")) = False Then _REGISTERED_CAPITAL = Convert.ToDouble(Rdr("registered_capital"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_year")) = False Then _ANNUAL_SALE_VALUE_YEAR = Convert.ToInt32(Rdr("annual_sale_value_year"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_volumns")) = False Then _ANNUAL_SALE_VALUE_VOLUMNS = Rdr("annual_sale_value_volumns").ToString()
                        If Convert.IsDBNull(Rdr("division")) = False Then _DIVISION = Rdr("division").ToString()
                        If Convert.IsDBNull(Rdr("mobile_no")) = False Then _MOBILE_NO = Rdr("mobile_no").ToString()
                        If Convert.IsDBNull(Rdr("regisperiod")) = False Then _REGISPERIOD = Rdr("regisperiod").ToString()
                        If Convert.IsDBNull(Rdr("is_send_mail")) = False Then _IS_SEND_MAIL = Rdr("is_send_mail").ToString()
                        If Convert.IsDBNull(Rdr("member_no")) = False Then _MEMBER_NO = Rdr("member_no").ToString()
                        If Convert.IsDBNull(Rdr("member_type")) = False Then _MEMBER_TYPE = Rdr("member_type").ToString()
                        If Convert.IsDBNull(Rdr("valid_date")) = False Then _VALID_DATE = Convert.ToDateTime(Rdr("valid_date"))
                        If Convert.IsDBNull(Rdr("expire_date")) = False Then _EXPIRE_DATE = Convert.ToDateTime(Rdr("expire_date"))
                    Else
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    _error = MessageResources.MSGEC104 & " #### " & ex.ToString()
                End Try
            Else
                _error = MessageResources.MSGEV001
            End If
            Return Me
        End Function


        '/// Returns an indication whether the Class Data of ERM_TS_PERSONAL_INFO by specified condition is retrieved successfully.
        '/// <param name=whText>The condition specify the deleting record(s).</param>
        '/// <param name=trans>The System.Data.SQLClient.SQLTransaction used by this System.Data.SQLClient.SQLCommand.</param>
        '/// <returns>true if data is retrieved successfully; otherwise, false.</returns>
        Private Function doMappingParameter(ByVal whText As String, ByVal trans As SQLTransaction) As ErmTsPersonalInfoPara
            ClearData()
            _haveData = False
            Dim ret As New ErmTsPersonalInfoPara
            If whText.Trim() <> "" Then
                Dim tmpWhere As String = " WHERE " & whText
                Dim Rdr As SqlDataReader
                Try
                    Rdr = DB.ExecuteReader(SqlSelect() & tmpWhere, trans)
                    If Rdr.Read() Then
                        _haveData = True
                        If Convert.IsDBNull(Rdr("id")) = False Then ret.ID = Convert.ToInt64(Rdr("id"))
                        If Convert.IsDBNull(Rdr("create_by")) = False Then ret.CREATE_BY = Rdr("create_by").ToString()
                        If Convert.IsDBNull(Rdr("create_on")) = False Then ret.CREATE_ON = Convert.ToDateTime(Rdr("create_on"))
                        If Convert.IsDBNull(Rdr("update_by")) = False Then ret.UPDATE_BY = Rdr("update_by").ToString()
                        If Convert.IsDBNull(Rdr("update_on")) = False Then ret.UPDATE_ON = Convert.ToDateTime(Rdr("update_on"))
                        If Convert.IsDBNull(Rdr("idcard_no")) = False Then ret.IDCARD_NO = Rdr("idcard_no").ToString()
                        If Convert.IsDBNull(Rdr("title_name")) = False Then ret.TITLE_NAME = Rdr("title_name").ToString()
                        If Convert.IsDBNull(Rdr("first_name")) = False Then ret.FIRST_NAME = Rdr("first_name").ToString()
                        If Convert.IsDBNull(Rdr("middle_name")) = False Then ret.MIDDLE_NAME = Rdr("middle_name").ToString()
                        If Convert.IsDBNull(Rdr("last_name")) = False Then ret.LAST_NAME = Rdr("last_name").ToString()
                        If Convert.IsDBNull(Rdr("position_name")) = False Then ret.POSITION_NAME = Rdr("position_name").ToString()
                        If Convert.IsDBNull(Rdr("company_name")) = False Then ret.COMPANY_NAME = Rdr("company_name").ToString()
                        If Convert.IsDBNull(Rdr("address")) = False Then ret.ADDRESS = Rdr("address").ToString()
                        If Convert.IsDBNull(Rdr("city")) = False Then ret.CITY = Rdr("city").ToString()
                        If Convert.IsDBNull(Rdr("state")) = False Then ret.STATE = Rdr("state").ToString()
                        If Convert.IsDBNull(Rdr("country")) = False Then ret.COUNTRY = Rdr("country").ToString()
                        If Convert.IsDBNull(Rdr("zipcode")) = False Then ret.ZIPCODE = Rdr("zipcode").ToString()
                        If Convert.IsDBNull(Rdr("telno")) = False Then ret.TELNO = Rdr("telno").ToString()
                        If Convert.IsDBNull(Rdr("faxno")) = False Then ret.FAXNO = Rdr("faxno").ToString()
                        If Convert.IsDBNull(Rdr("email")) = False Then ret.EMAIL = Rdr("email").ToString()
                        If Convert.IsDBNull(Rdr("website")) = False Then ret.WEBSITE = Rdr("website").ToString()
                        If Convert.IsDBNull(Rdr("registered_capital")) = False Then ret.REGISTERED_CAPITAL = Convert.ToDouble(Rdr("registered_capital"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_year")) = False Then ret.ANNUAL_SALE_VALUE_YEAR = Convert.ToInt32(Rdr("annual_sale_value_year"))
                        If Convert.IsDBNull(Rdr("annual_sale_value_volumns")) = False Then ret.ANNUAL_SALE_VALUE_VOLUMNS = Rdr("annual_sale_value_volumns").ToString()
                        If Convert.IsDBNull(Rdr("division")) = False Then ret.DIVISION = Rdr("division").ToString()
                        If Convert.IsDBNull(Rdr("mobile_no")) = False Then ret.DIVISION = Rdr("division").ToString()
                        If Convert.IsDBNull(Rdr("regisperiod")) = False Then ret.MOBILE_NO = Rdr("mobile_no").ToString()
                        If Convert.IsDBNull(Rdr("is_send_mail")) = False Then ret.IS_SEND_MAIL = Rdr("is_send_mail").ToString()
                        If Convert.IsDBNull(Rdr("member_no")) = False Then ret.MEMBER_NO = Rdr("member_no").ToString()
                        If Convert.IsDBNull(Rdr("member_type")) = False Then ret.MEMBER_TYPE = Rdr("member_type").ToString()
                        If Convert.IsDBNull(Rdr("valid_date")) = False Then ret.VALID_DATE = Convert.ToDateTime(Rdr("valid_date"))
                        If Convert.IsDBNull(Rdr("expire_date")) = False Then ret.EXPIRE_DATE = Convert.ToDateTime(Rdr("expire_date"))
                    Else
                        _error = MessageResources.MSGEV002
                    End If

                    Rdr.Close()
                Catch ex As Exception
                    ex.ToString()
                    _error = MessageResources.MSGEC104 & " #### " & ex.ToString()
                End Try
            Else
                _error = MessageResources.MSGEV001
            End If
            Return ret
        End Function
        ' SQL Statements


        'Get Insert Statement for table ERM_TS_PERSONAL_INFO
        Private ReadOnly Property SqlInsert() As String
            Get
                Dim Sql As String = ""
                Sql += "INSERT INTO " & TableName & " (ID, CREATE_BY, CREATE_ON, UPDATE_BY, UPDATE_ON, IDCARD_NO, TITLE_NAME, FIRST_NAME, MIDDLE_NAME, LAST_NAME, POSITION_NAME, COMPANY_NAME, ADDRESS, CITY, STATE, COUNTRY, ZIPCODE, TELNO, FAXNO, EMAIL, WEBSITE, REGISTERED_CAPITAL, ANNUAL_SALE_VALUE_YEAR, ANNUAL_SALE_VALUE_VOLUMNS, DIVISION, MOBILE_NO, REGISPERIOD, IS_SEND_MAIL, MEMBER_NO, MEMBER_TYPE, VALID_DATE, EXPIRE_DATE)"
                Sql += " VALUES("
                Sql += DB.SetDouble(_ID) & ", "
                Sql += DB.SetString(_CREATE_BY) & ", "
                Sql += DB.SetDateTime(_CREATE_ON) & ", "
                Sql += DB.SetString(_UPDATE_BY) & ", "
                Sql += DB.SetDateTime(_UPDATE_ON) & ", "
                Sql += DB.SetString(_IDCARD_NO) & ", "
                Sql += DB.SetString(_TITLE_NAME) & ", "
                Sql += DB.SetString(_FIRST_NAME) & ", "
                Sql += DB.SetString(_MIDDLE_NAME) & ", "
                Sql += DB.SetString(_LAST_NAME) & ", "
                Sql += DB.SetString(_POSITION_NAME) & ", "
                Sql += DB.SetString(_COMPANY_NAME) & ", "
                Sql += DB.SetString(_ADDRESS) & ", "
                Sql += DB.SetString(_CITY) & ", "
                Sql += DB.SetString(_STATE) & ", "
                Sql += DB.SetString(_COUNTRY) & ", "
                Sql += DB.SetString(_ZIPCODE) & ", "
                Sql += DB.SetString(_TELNO) & ", "
                Sql += DB.SetString(_FAXNO) & ", "
                Sql += DB.SetString(_EMAIL) & ", "
                Sql += DB.SetString(_WEBSITE) & ", "
                Sql += DB.SetDouble(_REGISTERED_CAPITAL) & ", "
                Sql += DB.SetDouble(_ANNUAL_SALE_VALUE_YEAR) & ", "
                Sql += DB.SetString(_ANNUAL_SALE_VALUE_VOLUMNS) & ", "
                Sql += DB.SetString(_DIVISION) & ", "
                Sql += DB.SetString(_MOBILE_NO) & ", "
                Sql += DB.SetString(_REGISPERIOD) & ", "
                Sql += DB.SetString(_IS_SEND_MAIL) & ", "
                Sql += DB.SetString(_MEMBER_NO) & ", "
                Sql += DB.SetString(_MEMBER_TYPE) & ", "
                Sql += DB.SetDateTime(_VALID_DATE) & ", "
                Sql += DB.SetDateTime(_EXPIRE_DATE)
                Sql += ")"
                Return Sql
            End Get
        End Property


        'Get update statement form table ERM_TS_PERSONAL_INFO
        Private ReadOnly Property SqlUpdate() As String
            Get
                Dim Sql As String = ""
                Sql += "UPDATE " & TableName & " SET "
                Sql += "CREATE_BY = " & DB.SetString(_CREATE_BY) & ", "
                Sql += "CREATE_ON = " & DB.SetDateTime(_CREATE_ON) & ", "
                Sql += "UPDATE_BY = " & DB.SetString(_UPDATE_BY) & ", "
                Sql += "UPDATE_ON = " & DB.SetDateTime(_UPDATE_ON) & ", "
                Sql += "IDCARD_NO = " & DB.SetString(_IDCARD_NO) & ", "
                Sql += "TITLE_NAME = " & DB.SetString(_TITLE_NAME) & ", "
                Sql += "FIRST_NAME = " & DB.SetString(_FIRST_NAME) & ", "
                Sql += "MIDDLE_NAME = " & DB.SetString(_MIDDLE_NAME) & ", "
                Sql += "LAST_NAME = " & DB.SetString(_LAST_NAME) & ", "
                Sql += "POSITION_NAME = " & DB.SetString(_POSITION_NAME) & ", "
                Sql += "COMPANY_NAME = " & DB.SetString(_COMPANY_NAME) & ", "
                Sql += "ADDRESS = " & DB.SetString(_ADDRESS) & ", "
                Sql += "CITY = " & DB.SetString(_CITY) & ", "
                Sql += "STATE = " & DB.SetString(_STATE) & ", "
                Sql += "COUNTRY = " & DB.SetString(_COUNTRY) & ", "
                Sql += "ZIPCODE = " & DB.SetString(_ZIPCODE) & ", "
                Sql += "TELNO = " & DB.SetString(_TELNO) & ", "
                Sql += "FAXNO = " & DB.SetString(_FAXNO) & ", "
                Sql += "EMAIL = " & DB.SetString(_EMAIL) & ", "
                Sql += "WEBSITE = " & DB.SetString(_WEBSITE) & ", "
                Sql += "REGISTERED_CAPITAL = " & DB.SetDouble(_REGISTERED_CAPITAL) & ", "
                Sql += "ANNUAL_SALE_VALUE_YEAR = " & DB.SetDouble(_ANNUAL_SALE_VALUE_YEAR) & ", "
                Sql += "ANNUAL_SALE_VALUE_VOLUMNS = " & DB.SetString(_ANNUAL_SALE_VALUE_VOLUMNS) & ", "
                Sql += "DIVISION = " & DB.SetString(_DIVISION) & ", "
                Sql += "MOBILE_NO = " & DB.SetString(_MOBILE_NO) & ", "
                Sql += "REGISPERIOD = " & DB.SetString(_REGISPERIOD) & ", "
                Sql += "IS_SEND_MAIL = " & DB.SetString(_IS_SEND_MAIL) & ", "
                Sql += "MEMBER_NO = " & DB.SetString(_MEMBER_NO) & ", "
                Sql += "MEMBER_TYPE = " & DB.SetString(_MEMBER_TYPE) & ", "
                Sql += "VALID_DATE = " & DB.SetDateTime(_VALID_DATE) & ", "
                Sql += "EXPIRE_DATE = " & DB.SetDateTime(_EXPIRE_DATE) + ""
                Return Sql
            End Get
        End Property


        'Get Delete Record in table ERM_TS_PERSONAL_INFO
        Private ReadOnly Property SqlDelete() As String
            Get
                Dim Sql As String = "DELETE FROM " & TableName
                Return Sql
            End Get
        End Property


        'Get Select Statement for table ERM_TS_PERSONAL_INFO
        Private ReadOnly Property SqlSelect() As String
            Get
                Dim Sql As String = "SELECT ID, CREATE_BY, CREATE_ON, UPDATE_BY, UPDATE_ON, IDCARD_NO, TITLE_NAME, FIRST_NAME, MIDDLE_NAME, LAST_NAME, POSITION_NAME, COMPANY_NAME, ADDRESS, CITY, STATE, COUNTRY, ZIPCODE, TELNO, FAXNO, EMAIL, WEBSITE, REGISTERED_CAPITAL, ANNUAL_SALE_VALUE_YEAR, ANNUAL_SALE_VALUE_VOLUMNS, DIVISION, MOBILE_NO, REGISPERIOD, IS_SEND_MAIL, MEMBER_NO, MEMBER_TYPE, VALID_DATE, EXPIRE_DATE FROM " & TableName
                Return Sql
            End Get
        End Property

    End Class
End Namespace
