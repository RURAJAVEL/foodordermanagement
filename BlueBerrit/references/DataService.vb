Imports System.Configuration
Imports System.Data.SqlClient

Namespace ServiceClasses

    Public Class DataService

        Public ObjConn As SqlClient.SqlConnection
        Public objCmd As SqlClient.SqlCommand
        Public objDReader As SqlClient.SqlDataReader
        Public objDA As SqlClient.SqlDataAdapter
        Public objCB As SqlClient.SqlCommandBuilder
        Public objDS As DataSet
        Public ObjDT As DataTable
        Public objDR As DataRow
        Public objDRC() As DataRow

        Dim strQuery As String

        Dim objError As DataError

        Public Sub New()

            Try
                '  ObjConn = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnStr"))

                Dim strcon As String = ConfigurationManager.ConnectionStrings("ConnStr").ConnectionString

                ObjConn = New SqlConnection(strcon)

                If ObjConn.State = ConnectionState.Closed Then ObjConn.Open()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub
        Public Function blnFindRecord(ByVal strTableName As String, ByVal strCondition As String) As Boolean
            Dim blnString As Boolean
            Try
                strQuery = "select count(*) from " & strTableName & " where " & strCondition
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                If objCmd.ExecuteScalar() <> 0 Then
                    blnString = True
                Else
                    blnString = False
                End If

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
            Return blnString
        End Function
        'blnCheckCustID
        Public Function blnCheckCustID(ByVal strTableName As String, ByVal strCondition As String) As Boolean
            Dim blnString As Boolean
            Try
                strQuery = "select count(*) from " & strTableName & " where " & strCondition
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                If objCmd.ExecuteScalar() > 0 Then
                    blnString = True
                Else
                    blnString = False
                End If

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
            Return blnString
        End Function
        Public Function FunExecuteScalar(ByVal strTableName As String, ByVal strCondition As String) As Long

            Try
                If strCondition = "Nothing" Then
                    strQuery = "select count(*) from " & strTableName
                Else
                    strQuery = "select count(*) from " & strTableName & " where " & strCondition
                End If
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)


            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
            Return objCmd.ExecuteScalar()
        End Function

        Public Function FunExecuteSUM(ByVal strTableName As String, ByVal strCondition As String, ByVal strSumField As String) As Long

            Try
                If strCondition = "Nothing" Then
                    strQuery = "select count(" & strSumField & ") from " & strTableName
                Else
                    strQuery = "select count(" & strSumField & ") from " & strTableName & " where " & strCondition
                End If
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)


            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
            Return objCmd.ExecuteScalar()
        End Function
        Public Function blnCheckAuthenticate(ByVal strUName As String, ByVal strUPwd As String) As Boolean

            Dim blnString As Boolean

            Try
                If strUName = "" Or strUPwd = "" Then
                    blnString = False
                Else
                    blnString = True
                End If


            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
            Return blnString

        End Function


        Public Sub FillDataSetQuery(ByVal strquery As String, ByVal tablename As String)


            'Try
            '    ' strquery = "select * from " & strTableName
            '    objCmd = New SqlClient.SqlCommand(strquery, objConn)
            '    objDA = New SqlClient.SqlDataAdapter(objCmd)
            '    'objCB = New SqlClient.SqlCommandBuilder(objDA)
            '    'objDA.InsertCommand = objCB.GetInsertCommand
            '    'objDA.UpdateCommand = objCB.GetUpdateCommand
            '    objDS = New DataSet
            '    objDA.Fill(objDS)
            '    objDT = objDS.Tables(tablename)
            'Catch ex As Exception
            '    objError = New DataError
            '    objError.WriteFile(ex)
            'End Try
            Try
                'strquery = "select " & SelectFields & " from " & strTableName & " where " & strCondition
                objCmd = New SqlClient.SqlCommand(strquery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strquery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, tablename)
                ObjDT = objDS.Tables(tablename)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub
        Public Sub FillDataSetQueryJoin(ByVal strquery As String)
            Try
                objCmd = New SqlClient.SqlCommand(strquery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strquery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS)
                ObjDT = objDS.Tables(0)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
        End Sub
        Public Sub FillDataSet(ByVal strTableName As String)
            Try
                strQuery = "select * from " & strTableName
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objCB = New SqlClient.SqlCommandBuilder(objDA)
                objDA.InsertCommand = objCB.GetInsertCommand
                objDA.UpdateCommand = objCB.GetUpdateCommand
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)
                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
        End Sub
        Public Sub FillDataSet(ByVal strTableName As String, ByVal strCondition As String)
            Try
                strQuery = "select * from " & strTableName & " where " & strCondition

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)

                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
        End Sub

        Public Sub FillDataSetUnion(ByVal strTableName As String, ByVal strtablename1 As String, ByVal strCondition As String, ByVal strcondition1 As String, ByVal strfield As String, ByVal strfield1 As String)
            Try
                strQuery = "select " & strfield & " from (select " & strfield & " as " & strfield & " from " & strTableName & " where " & strCondition & " union select " & strfield1 & " as " & strfield & " from " & strtablename1 & " where " & strcondition1 & " ) as " & strfield & " "

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)

                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
        End Sub
        Public Sub FillDataSetUniontrifield(ByVal strTableName As String, ByVal strtablename1 As String, ByVal strtableName2 As String, ByVal strCondition As String, ByVal strcondition1 As String, ByVal strcondition2 As String, ByVal strfield As String, ByVal strfield1 As String, ByVal strfield2 As String)
            Try
                strQuery = "select " & strfield & " from (select " & strfield & " as " & strfield & " from " & strTableName & " where " & strCondition & " union select " & strfield1 & " as " & strfield & " from " & strtablename1 & " where " & strcondition1 & "  union select " & strfield2 & " as " & strfield & " from " & strtableName2 & " where " & strcondition2 & " ) as " & strfield & " "

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)

                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
        End Sub
        Public Sub FillDataSetspl(ByVal strTableName As String, ByVal strCondition As String, ByVal strOrder As String, ByVal strSelect As String)

            Try
                strQuery = "select " & strSelect & " from " & strTableName & " where " & strCondition & " " & strOrder

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)

                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
        End Sub
        Public Sub FillDataSetOrderBy(ByVal strTableName As String, ByVal strCondition As String, ByVal strOrderBy As String)

            Try
                strQuery = "select * from " & strTableName & " where " & strCondition & " order by " & strOrderBy

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)

                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub
        Public Sub FillDataSetDistinct(ByVal strTableName As String, ByVal strCondition As String, ByVal strDistinct As String)

            Try
                strQuery = "select distinct " & strDistinct & " from " & strTableName & " where " & strCondition

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)

                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub
        Public Sub FillDataSetTree(ByVal strTableName As String, ByVal strCondition As String)

            Try
                strQuery = "select * from " & strTableName & " where " & strCondition & " order by memtreename"

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)

                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub
        Public Sub FillDataSetProductcode(ByVal strTableName As String, ByVal strCondition As String)

            Try
                strQuery = "select DISTINCT productcode from " & strTableName & " where " & strCondition

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)
                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub
        Public Sub FillDataSetDup(ByVal strTableName As String, ByVal strCondition As String)

            Try
                strQuery = "select DISTINCT productcode from " & strTableName & " where " & strCondition

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)
                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub

        Public Sub FillDataSet0002(ByVal strTableName As String, ByVal strCondition As String)

            Try
                strQuery = "select subjectname as title,sid as autonum,subjectcode,usercategory,(select count(*) from chapterdetails where subjectcategory=subjectdetails.subjectcode) as chaptercount  from " & strTableName & " where " & strCondition

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)
                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub
        Public Sub FillDataSet0003(ByVal strTableName As String, ByVal strCondition As String)

            Try
                strQuery = "select chaptertitle as title,sid as autonum,subjectcategory,(select count(*) from videodetails where subjectcategory=chapterdetails.subjectcategory)  as chaptercount  from " & strTableName & " where " & strCondition

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)
                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub


        Public Sub FillDataSet0004(ByVal strTableName As String, ByVal strCondition As String)

            Try
                strQuery = "select videoname as title,sid as autonum,chaptercategory,subjectcategory, 0 as chaptercount  from " & strTableName & " where " & strCondition

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)
                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub


        Public Function lngGetMaxValue(ByVal strFldName As String, ByVal strTableName As String) As Integer

            Dim lngValue As Long

            Try
                strQuery = "select max(" & strFldName & ") from " & strTableName
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                If IsDBNull(objCmd.ExecuteScalar()) Then
                    lngValue = 0
                Else
                    lngValue = objCmd.ExecuteScalar()
                End If

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

            Return lngValue
        End Function

        Public Sub ExecuteQueryConnected(ByVal strQry As String)

            Try
                objCmd = New SqlClient.SqlCommand(strQry, ObjConn)
                objCmd.ExecuteNonQuery()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub

        Public Sub InsertRecords(ByVal strTableName As String, ByVal strInputValues As String, ByVal intStartwith As Integer)

            Dim arrInputValues() As String
            Dim intI As Integer

            Try
                arrInputValues = Split(strInputValues, "~")
                Call FillDataSet(strTableName)
                objDR = ObjDT.NewRow

                For intI = 0 To UBound(arrInputValues)
                    If ReplaceQuotes(arrInputValues(intI).Trim) <> Nothing Then
                        objDR(intStartwith) = ReplaceQuotes(arrInputValues(intI).Trim)
                    Else
                        objDR(intStartwith) = ""
                    End If
                    intStartwith = intStartwith + 1
                Next

                ObjDT.Rows.Add(objDR)
                objDA.Update(ObjDT)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                ObjDT = Nothing
                objDS = Nothing
                objDA = Nothing
            End Try

        End Sub

        Public Sub InsertRecords1(ByVal strTableName As String, ByVal strFieldNames As String, ByVal ParamArray Values() As String)

            Dim arrFieldNames() As String
            Dim intI As Integer

            Try
                arrFieldNames = Split(strFieldNames, "~")
                Call FillDataSet(strTableName)
                objDR = ObjDT.NewRow

                For intI = 0 To UBound(arrFieldNames)
                    'If ReplaceQuotes(arrInputValues(intI).Trim) <> Nothing Then
                    '    objDR(intStartwith) = ReplaceQuotes(arrInputValues(intI).Trim)
                    'Else
                    '    objDR(intStartwith) = ""
                    'End If
                    'intStartwith = intStartwith + 1
                    If ReplaceQuotes(Values(intI).Trim) <> "" Then
                        objDR(arrFieldNames(intI)) = ReplaceQuotes(Values(intI).Trim)
                    Else
                        objDR(arrFieldNames(intI)) = ""
                    End If
                Next

                ObjDT.Rows.Add(objDR)
                objDA.Update(ObjDT)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                ObjDT = Nothing
                objDS = Nothing
                objDA = Nothing
            End Try

        End Sub

        Public Sub UpdateRecords(ByVal strTableName As String, ByVal strCondition As String, ByVal strInputValues As String, ByVal intStartwith As Integer)

            Dim arrInputValues() As String
            Dim intI As Integer

            Try
                Call FillDataSet(strTableName)
                objDRC = ObjDT.Select(strCondition)
                objDR = objDRC(0)
                arrInputValues = Split(strInputValues, "~")

                For intI = 0 To UBound(arrInputValues)
                    If ReplaceQuotes(arrInputValues(intI).Trim) <> Nothing Then
                        objDR(intStartwith) = ReplaceQuotes(arrInputValues(intI).Trim)
                    Else
                        objDR(intStartwith) = ""
                    End If
                    'objDR(intStartwith) = ReplaceQuotes(arrInputValues(intI).Trim)
                    intStartwith = intStartwith + 1
                Next

                objDA.Update(ObjDT)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                ObjDT = Nothing
                objDS = Nothing
                objDA = Nothing
            End Try

        End Sub

        Public Sub UpdateRecords1(ByVal strTableName As String, ByVal strCondition As String, ByVal strFieldNames As String, ByVal ParamArray Values() As String)

            Dim arrFieldNames() As String
            Dim intI As Integer

            Try
                Call FillDataSet(strTableName)
                objDRC = ObjDT.Select(strCondition)
                objDR = objDRC(0)
                arrFieldNames = Split(strFieldNames, "~")

                For intI = 0 To UBound(arrFieldNames)
                    If ReplaceQuotes(Values(intI).Trim) <> "" Then
                        objDR(arrFieldNames(intI)) = ReplaceQuotes(Values(intI).Trim)
                    Else
                        objDR(arrFieldNames(intI)) = ""
                    End If
                Next

                objDA.Update(ObjDT)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                ObjDT = Nothing
                objDS = Nothing
                objDA = Nothing
            End Try

        End Sub

        Public Sub GetRowCollection(ByVal strTableName As String, ByVal strCondition As String)

            Try
                Call FillDataSet(strTableName, strCondition)
                objDRC = ObjDT.Select(strCondition)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub

        Public Sub GetRowCollectionspl(ByVal strTableName As String, ByVal strCondition As String, ByVal strOrder As String, ByVal strSelect As String)

            Try
                Call FillDataSetspl(strTableName, strCondition, strOrder, strSelect)
                objDRC = ObjDT.Select(strCondition)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub

        Public Sub GetRowCollectionOrderBy(ByVal strTableName As String, ByVal strCondition As String, ByVal strOrderBy As String)

            Try
                Call FillDataSetOrderBy(strTableName, strCondition, strOrderBy)
                objDRC = ObjDT.Select(strCondition)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub

        Public Sub GetRowCollectionDistinct(ByVal strTableName As String, ByVal strCondition As String, ByVal strDistinct As String)

            Try
                Call FillDataSetDistinct(strTableName, strCondition, strDistinct)
                objDRC = ObjDT.Select(strCondition)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub
        Public Sub GetRowCollectionTree(ByVal strTableName As String, ByVal strCondition As String)

            Try
                Call FillDataSetTree(strTableName, strCondition)
                objDRC = ObjDT.Select(strCondition)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub


        Public Sub GetRowCollection0002(ByVal strTableName As String, ByVal strCondition As String)

            Try
                Call FillDataSet0002(strTableName, strCondition)
                objDRC = ObjDT.Select(strCondition)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub
        Public Sub GetRowCollection0003(ByVal strTableName As String, ByVal strCondition As String)

            Try
                Call FillDataSet0003(strTableName, strCondition)
                objDRC = ObjDT.Select(strCondition)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub

        Public Sub GetRowCollection0004(ByVal strTableName As String, ByVal strCondition As String)

            Try
                Call FillDataSet0004(strTableName, strCondition)
                objDRC = ObjDT.Select(strCondition)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub

        Public Sub GetSingleRow(ByVal strTableName As String, ByVal strCondition As String)
            Try
                If strCondition <> "Nothing" Then
                    strQuery = "select * from " & strTableName & " where " & strCondition
                Else
                    strQuery = "select * from " & strTableName
                End If

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDReader = objCmd.ExecuteReader
                objDReader.Read()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
        End Sub

        Public Sub GetSingleRowSelectField(ByVal strTableName As String, ByVal strcondition1 As String, ByVal strCondition As String)
            Try
                If strCondition <> "Nothing" Then
                    strQuery = "select " & strcondition1 & " from " & strTableName & " where " & strCondition
                Else
                    strQuery = "select * from " & strTableName
                End If

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDReader = objCmd.ExecuteReader
                objDReader.Read()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
        End Sub
        Public Function blnFindRecord01(ByVal strTableName As String, ByVal strCondition As String) As Boolean
            Dim blnString As Boolean
            Try
                If strCondition <> "Nothing" Then
                    strQuery = "select count(*) from " & strTableName & " where " & strCondition
                Else
                    strQuery = "select count(*) from " & strTableName
                End If

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                If objCmd.ExecuteScalar() = 0 Then
                    blnString = True
                Else
                    blnString = False
                End If

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
            Return blnString
        End Function
        Public Function RowCount(ByVal strTableName As String, ByVal strCondition As String) As Integer
            Dim varRowCount As Integer
            Try
                If strCondition <> "Nothing" Then
                    strQuery = "select count(*) from " & strTableName & " where " & strCondition
                Else
                    strQuery = "select count(*) from " & strTableName
                End If

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                varRowCount = objCmd.ExecuteScalar()
                'blnString = True
                'Else
                'blnString = False
                'End If

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
            Return varRowCount
        End Function
        Public Function GetMinVal(ByVal strField As String, ByVal strTableName As String, ByVal strCondition As String) As Long
            Dim varRowCount As Integer
            Try
                strQuery = "select min(" & strField & ") from " & strTableName & " where " & strCondition
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                If (IsDBNull(objCmd.ExecuteScalar)) Then
                    varRowCount = 0
                Else
                    varRowCount = objCmd.ExecuteScalar
                End If

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
            Return varRowCount
        End Function


        Public Function ReplaceQuotes(ByVal strValue As String) As String

            strValue = Replace(Replace(strValue, """", Chr(34)), "'", "''")

            Return strValue

        End Function

        Public Sub CloseConnection()

            If IsNothing(ObjConn) = True Then Exit Sub
            If ObjConn.State = ConnectionState.Open Then ObjConn.Close()

            ObjConn = Nothing
            objCmd = Nothing
            objCB = Nothing
            objDS = Nothing
            ObjDT = Nothing

        End Sub

        Public Sub FillDataSetSelect(ByVal strTableName As String, ByVal strCondition As String, ByVal SelectFields As String)

            Try
                strQuery = "select " & SelectFields & " from " & strTableName & " where " & strCondition
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)
                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub

        Public Sub FillDataSetSelectPaging(ByVal strTableName As String, ByVal strCondition As String, ByVal SelectFields As String, ByVal StartRec As Integer, ByVal MaxRec As Integer)

            Try
                strQuery = "select " & SelectFields & " from " & strTableName & " where " & strCondition
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, StartRec, MaxRec, strTableName)
                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub


        Public Function displaydata(ByVal strQuery As String) As String
            Try
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
            Return objCmd.ExecuteScalar()
            'objConn.Close()

        End Function

        Public Sub ExecuteQuery(ByVal strSQL As String)

            'Dim con As New SqlConnection("Data Source=192.168.1.52;Initial Catalog=ssinventory;Uid=sa;pwd=12345")
            If ObjConn.State = ConnectionState.Closed Then ObjConn.Open()
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = ObjConn
            cmd.CommandText = strSQL
            cmd.ExecuteNonQuery()
        End Sub

        Public Sub FillDataSetSelectedField(ByVal strTableName As String, ByVal strCondition As String, ByVal strCondition2 As String)

            Try
                strQuery = "select " & strCondition2 & " from " & strTableName & " where " & strCondition

                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)
                objDA = New SqlClient.SqlDataAdapter(strQuery, ObjConn)
                objDS = New DataSet
                objDA.Fill(objDS, strTableName)

                ObjDT = objDS.Tables(strTableName)
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
        End Sub

        Public Function GetDataset(ByVal strSQL As String) As DataSet
            objCmd = New SqlClient.SqlCommand(strSQL, ObjConn)
            objCmd.CommandText = strSQL
            Dim objDS = New DataSet
            Dim objDA = New SqlClient.SqlDataAdapter(strSQL, ObjConn)
            objDA.Fill(objDS)
            GetDataset = Nothing
            GetDataset = objDS
        End Function
        Public Function FunExecuteScalarColumn(ByVal strTableName As String, ByVal strColumn As String, ByVal strCondition As String)

            Try
                If strCondition = "Nothing" Then
                    strQuery = "select " & strColumn & " from " & strTableName
                Else
                    strQuery = "select " & strColumn & " from " & strTableName & " where " & strCondition
                End If
                objCmd = New SqlClient.SqlCommand(strQuery, ObjConn)


            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try
            Return objCmd.ExecuteScalar()
        End Function

        Public Function subDateconvert(ByVal vardate As String, ByVal varinformat As String, ByVal varoutformat As String) As String
            Dim strdate As String = vardate
            If strdate <> "" Then
                Dim datetimeformatterprovider As System.Globalization.DateTimeFormatInfo = TryCast(System.Globalization.DateTimeFormatInfo.CurrentInfo.Clone(), System.Globalization.DateTimeFormatInfo)
                datetimeformatterprovider.ShortDatePattern = varinformat
                Dim vardatetime As DateTime = Date.Parse(strdate, datetimeformatterprovider)
                Return vardatetime.ToString(varoutformat)
            Else
                strdate = "NULL"
                Return strdate
            End If
        End Function
        Public Function ExecuteQueryReturn(ByVal strSQL As String)
            Dim returnValue As Integer
            'Dim con As New SqlConnection("Data Source=192.168.1.52;Initial Catalog=ssinventory;Uid=sa;pwd=12345")
            If ObjConn.State = ConnectionState.Closed Then ObjConn.Open()
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = ObjConn
            cmd.CommandText = strSQL
            returnValue = cmd.ExecuteNonQuery()
            Return returnValue
        End Function
    End Class

End Namespace

