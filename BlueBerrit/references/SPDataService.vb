Imports System.Data.SqlClient
Imports System.Configuration

Namespace ServiceClasses
    Public Class SPDataService
        Dim objError As DataError
        Dim tmpspcall As SPCall

        Public objConn As SqlClient.SqlConnection
        Public objCmd As SqlClient.SqlCommand
        Public objDReader As SqlClient.SqlDataReader
        Public objDA As SqlClient.SqlDataAdapter
        Public objCB As SqlClient.SqlCommandBuilder
        Public objDS As DataSet
        Public objDT As DataTable
        Public objDR As DataRow
        Public objDRC() As DataRow

        Dim strQuery As String


        Public Sub New()
            Try
                Dim strcon As String = ConfigurationManager.ConnectionStrings("ConnStr").ConnectionString

                objConn = New SqlConnection(strcon)
                If objConn.State = ConnectionState.Closed Then objConn.Open()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            End Try

        End Sub
        Public Sub CloseConnection()

            If IsNothing(objConn) = True Then Exit Sub
            If objConn.State = ConnectionState.Open Then objConn.Close()

        End Sub

        Public Function udfnExecuteQuery(ByVal paraConnectedQuery As String) As String
            Dim udfn As Integer
            Try

                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("SpExecuteQuery", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@connectedQuery", paraConnectedQuery)
                varSqlCommand.CommandTimeout = 0
                varSqlCommand.ExecuteScalar()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try
            Return udfn
        End Function

        Public Function udfnExecuteQuery2Parameter(ByVal paraConnectedQuery1 As String, ByVal paraConnectedQuery2 As String) As String
            Dim udfn As Integer
            Try

                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("SpExecuteQuery2Parameter", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@connectedQuery", paraConnectedQuery1)
                varSqlCommand.Parameters.AddWithValue("@connectedQuery1", paraConnectedQuery2)
                varSqlCommand.CommandTimeout = 0
                varSqlCommand.ExecuteScalar()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try
            Return udfn
        End Function


        Public Function ReplaceQuotes(ByVal strValue As String) As String

            strValue = Replace(Replace(strValue, """", Chr(34)), "'", "''")

            Return strValue

        End Function
        Public Function udfnExecuteQuery3Parameter(ByVal paraConnectedQuery1 As String, ByVal paraConnectedQuery2 As String, ByVal paraConnectedQuery3 As String) As String
            Dim udfn As Integer
            Try

                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("SpExecuteQuery3Parameter", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@connectedQuery1", paraConnectedQuery1)
                varSqlCommand.Parameters.AddWithValue("@connectedQuery2", paraConnectedQuery2)
                varSqlCommand.Parameters.AddWithValue("@connectedQuery3", paraConnectedQuery3)
                varSqlCommand.CommandTimeout = 0
                varSqlCommand.ExecuteScalar()
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try
            Return udfn
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
        Public Function subDateconvert1(ByVal vardate As String, ByVal varinformat As String, ByVal varoutformat As String) As Date
            Dim strdate As String = vardate
            If strdate <> "" Then
                Dim datetimeformatterprovider As System.Globalization.DateTimeFormatInfo = TryCast(System.Globalization.DateTimeFormatInfo.CurrentInfo.Clone(), System.Globalization.DateTimeFormatInfo)
                datetimeformatterprovider.ShortDatePattern = varinformat
                Dim vardatetime As DateTime = Date.Parse(strdate, datetimeformatterprovider)
                Return vardatetime
            End If

        End Function
        Public Function udfnGenerateCode(ByVal parastrTableName As String, ByVal parastrTablecolumn As String)
            Dim udfn As New Integer
            Try
                tmpspcall = New SPCall

                Dim paraconnectedquery As String = "select Max(" & parastrTablecolumn & ") As " & parastrTablecolumn & " from (select Cast(" & parastrTablecolumn & " as int) as " & parastrTablecolumn & " from " & parastrTableName & " ) as " & parastrTablecolumn & ""

                Dim varSqlCommand As New SqlCommand("SpExecuteQuery", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@connectedQuery", paraconnectedquery)
                varSqlCommand.CommandTimeout = 0
                objDReader = varSqlCommand.ExecuteReader
                objDReader.Read()
                Dim count As String = ""
                If Not IsDBNull(objDReader(0)) Then count = objDReader(0).ToString Else count = 0

                If count <> 0 Then Integer.TryParse(count, udfn)
                udfn = udfn + 1
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally

            End Try
            Return udfn
        End Function
        Public Function udfnGenerateCodecustomer(ByVal parastrTableName As String, ByVal parastrTablecolumn As String, ByVal strcondition As String) As String
            Dim udfn As String = ""
            Try
                tmpspcall = New SPCall

                Dim paraconnectedquery As String = "select cast(max(substring(" & parastrTablecolumn & ",15,4)) as int) As " & parastrTablecolumn & " from  " & parastrTableName & " where " & strcondition & " "

                Dim varSqlCommand As New SqlCommand("SpExecuteQuery", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@connectedQuery", paraconnectedquery)
                varSqlCommand.CommandTimeout = 0
                objDReader = varSqlCommand.ExecuteReader
                objDReader.Read()
                Dim count As String = ""
                If Not IsDBNull(objDReader(0)) Then count = objDReader(0).ToString Else count = 0

                Dim cnt As Integer
                If count <> 0 Then cnt = Integer.Parse(count)
                cnt = cnt + 1
                If Len(count) = "1" Then
                    udfn = "000" & cnt.ToString
                ElseIf Len(count) = "2" Then
                    udfn = "00" & cnt.ToString
                ElseIf Len(count) = "3" Then
                    udfn = "0" & cnt.ToString
                ElseIf Len(count) = "4" Then
                    udfn = cnt.ToString
                End If

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally

            End Try
            Return udfn
        End Function
        Public Function udfnGenerateCodelcoation(ByVal parastrTableName As String, ByVal parastrTablecolumn As String, ByVal strcondition As String)
            Dim udfn As New Integer
            Try
                tmpspcall = New SPCall

                Dim paraconnectedquery As String = "select cast(max(substring(" & parastrTablecolumn & ",7,4)) as int) As " & parastrTablecolumn & " from  " & parastrTableName & " where " & strcondition & " "

                Dim varSqlCommand As New SqlCommand("SpExecuteQuery", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@connectedQuery", paraconnectedquery)
                varSqlCommand.CommandTimeout = 0
                objDReader = varSqlCommand.ExecuteReader
                objDReader.Read()
                Dim count As String = ""
                If Not IsDBNull(objDReader(0)) Then count = objDReader(0).ToString Else count = 0

                If count <> 0 Then Integer.TryParse(count, udfn)
                udfn = udfn + 1
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally

            End Try
            Return udfn
        End Function
        Public Function udfnGenerateCodeoffice(ByVal parastrTableName As String, ByVal parastrTablecolumn As String, ByVal strcondition As String)
            Dim udfn As New Integer
            Try
                tmpspcall = New SPCall

                Dim paraconnectedquery As String = "select cast(max(substring(" & parastrTablecolumn & ",11,4)) as int) As " & parastrTablecolumn & " from  " & parastrTableName & " where " & strcondition & " "

                Dim varSqlCommand As New SqlCommand("SpExecuteQuery", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@connectedQuery", paraconnectedquery)
                varSqlCommand.CommandTimeout = 0
                objDReader = varSqlCommand.ExecuteReader
                objDReader.Read()
                Dim count As String = ""
                If Not IsDBNull(objDReader(0)) Then count = objDReader(0).ToString Else count = 0

                If count <> 0 Then Integer.TryParse(count, udfn)
                udfn = udfn + 1
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally

            End Try
            Return udfn
        End Function





        Public Function udfngeneratecodemenu(ByVal parastrTableName As String, ByVal parastrTablecolumn As String, ByVal strcondition As String)

            Dim udfn As New Integer
            Try
                tmpspcall = New SPCall

                Dim paraconnectedquery As String = "select cast(max(substring(" & parastrTablecolumn & ",9,4)) as int) As " & parastrTablecolumn & " from  " & parastrTableName & " where " & strcondition & " "

                Dim varSqlCommand As New SqlCommand("SpExecuteQuery", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@connectedQuery", paraconnectedquery)
                varSqlCommand.CommandTimeout = 0
                objDReader = varSqlCommand.ExecuteReader
                objDReader.Read()
                Dim count As String = ""
                If Not IsDBNull(objDReader(0)) Then count = objDReader(0).ToString Else count = 0

                If count <> 0 Then Integer.TryParse(count, udfn)
                udfn = udfn + 1
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally

            End Try
            Return udfn
        End Function



        Public Function udfngeneratecoderestaurant(ByVal parastrTableName As String, ByVal parastrTablecolumn As String, ByVal strcondition As String)

            Dim udfn As New Integer
            Try
                tmpspcall = New SPCall

                Dim paraconnectedquery As String = "select cast(max(substring(" & parastrTablecolumn & ",7,2)) as int) As " & parastrTablecolumn & " from  " & parastrTableName & " where " & strcondition & " "

                Dim varSqlCommand As New SqlCommand("SpExecuteQuery", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@connectedQuery", paraconnectedquery)
                varSqlCommand.CommandTimeout = 0
                objDReader = varSqlCommand.ExecuteReader
                objDReader.Read()
                Dim count As String = ""
                If Not IsDBNull(objDReader(0)) Then count = objDReader(0).ToString Else count = 0

                If count <> 0 Then Integer.TryParse(count, udfn)
                udfn = udfn + 1
            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally

            End Try
            Return udfn
        End Function
        Public Function udfnActivityLog(ByVal paraUserName As String, ByVal paraUserIPAddress As String, ByVal paraLogDate As Date, ByVal paraOrginator As String) As String
            Dim varActivityID As Integer
            Try

                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("spActivityLog", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@UserName", paraUserName)
                varSqlCommand.Parameters.AddWithValue("@UserIPAddress", paraUserIPAddress)
                varSqlCommand.Parameters.AddWithValue("@LogDate", paraLogDate)
                varSqlCommand.Parameters.AddWithValue("@Orginator", paraOrginator)
                varSqlCommand.Parameters.Add("@LogID", SqlDbType.Int)
                varSqlCommand.Parameters("@LogID").Direction = ParameterDirection.Output
                varSqlCommand.CommandTimeout = 0
                varSqlCommand.ExecuteScalar()
                varActivityID = varSqlCommand.Parameters("@LogID").Value

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try
            Return varActivityID
        End Function
        Public Function udfnCustActivityLog(ByVal paraUserName As String, ByVal paraUserIPAddress As String, ByVal paraLogDate As Date, ByVal paraOrginator As String) As String
            Dim varActivityID As Integer
            Try

                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("spCustActivityLog", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@customerid", paraUserName)
                varSqlCommand.Parameters.AddWithValue("@UserIPAddress", paraUserIPAddress)
                varSqlCommand.Parameters.AddWithValue("@LogDate", paraLogDate)
                varSqlCommand.Parameters.AddWithValue("@Orginator", paraOrginator)
                varSqlCommand.Parameters.Add("@LogID", SqlDbType.Int)
                varSqlCommand.Parameters("@LogID").Direction = ParameterDirection.Output
                varSqlCommand.CommandTimeout = 0
                varSqlCommand.ExecuteScalar()
                varActivityID = varSqlCommand.Parameters("@LogID").Value

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try
            Return varActivityID
        End Function

        ''''''''   Autonum, CustomerID, MenuDate, MenuID, MenuName, Rate, Tax, Grandtotal, Quantity, OrderDate, OrderStatus
        Public Function udfnCartSalesOrderEntry(ByVal customerID As String, ByVal menudate As Date, ByVal menuid As String, ByVal quantity As Double, ByVal orderdate As Date, ByVal OrderStatus As String, ByVal custmakerID As Integer)

            Try
                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("SpCartSalesOrderEntry", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@customerID", customerID)
                varSqlCommand.Parameters.AddWithValue("@menudate", menudate)
                varSqlCommand.Parameters.AddWithValue("@menuID", menuid)
                varSqlCommand.Parameters.AddWithValue("@quantity", quantity)
                varSqlCommand.Parameters.AddWithValue("@orderdate", orderdate)
                varSqlCommand.Parameters.AddWithValue("@OrderStatus", OrderStatus)
                varSqlCommand.Parameters.AddWithValue("@custmakerID", custmakerID)

                varSqlCommand.ExecuteReader()
                varSqlCommand.CommandTimeout = 0

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try

        End Function

        Public Function udfnCartSalesOrderBankEntry(ByVal customerID As String, ByVal menudate As Date, ByVal menuid As String, ByVal quantity As Double, ByVal orderdate As Date, ByVal OrderStatus As String, ByVal custmakerID As Integer, ByVal txnid As String)

            Try
                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("SpCartSalesOrderBankEntry", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@customerID", customerID)
                varSqlCommand.Parameters.AddWithValue("@menudate", menudate)
                varSqlCommand.Parameters.AddWithValue("@menuID", menuid)
                varSqlCommand.Parameters.AddWithValue("@quantity", quantity)
                varSqlCommand.Parameters.AddWithValue("@orderdate", orderdate)
                varSqlCommand.Parameters.AddWithValue("@OrderStatus", OrderStatus)
                varSqlCommand.Parameters.AddWithValue("@custmakerID", custmakerID)
                varSqlCommand.Parameters.AddWithValue("@txnid", txnid)
                varSqlCommand.ExecuteReader()
                varSqlCommand.CommandTimeout = 0

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try

        End Function






        Public Function udfnOfficeMaster(ByVal citycode As String, ByVal createddate As Date, ByVal Locationcode As String, ByVal Location As String, ByVal Officecode As String, ByVal Officename As String, ByVal DIOCODE As String, ByVal makerid As Integer, ByVal OfficeAddress As String, ByVal BuildingLocation As String, ByVal DeliveryAddress As String, ByVal Noofemployees As Double)

            Try
                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("SpOfficeMaster", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@citycode", citycode)
                varSqlCommand.Parameters.AddWithValue("@createddate", createddate)
                varSqlCommand.Parameters.AddWithValue("@Location", Location)
                varSqlCommand.Parameters.AddWithValue("@Locationcode", Locationcode)
                varSqlCommand.Parameters.AddWithValue("@Officecode", Officecode)
                varSqlCommand.Parameters.AddWithValue("@Officename", Officename)
                varSqlCommand.Parameters.AddWithValue("@DIOCODE", DIOCODE)
                varSqlCommand.Parameters.AddWithValue("@makerid", makerid)
                varSqlCommand.Parameters.AddWithValue("@OfficeAddress", OfficeAddress)
                varSqlCommand.Parameters.AddWithValue("@BuildingLocation", BuildingLocation)
                varSqlCommand.Parameters.AddWithValue("@DeliveryAddress", DeliveryAddress)
                varSqlCommand.Parameters.AddWithValue("@Noofemployees", Noofemployees)
                varSqlCommand.ExecuteReader()
                varSqlCommand.CommandTimeout = 0

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try

        End Function





        Public Function udfnPasswordchange(ByVal customerID As String, ByVal password As String)

            Try
                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("Sppasswordchange", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@customerID", customerID)
                varSqlCommand.Parameters.AddWithValue("@password", password)
                varSqlCommand.ExecuteReader()
                varSqlCommand.CommandTimeout = 0

            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try

        End Function


        Public Function udfnSpcustomercartListing(ByVal paracustomerid As String, ByVal STATUS As String) As DataTable
            Dim udfn As String
            Try

                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("SpcustomercartListing", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@CustomerID", paracustomerid)
                varSqlCommand.Parameters.AddWithValue("@STATUS", STATUS)
                varSqlCommand.CommandTimeout = 0
                'ctlDataList.DataSource = varSqlCommand.ExecuteReader()
                'ctlDataList.DataBind()

                objDA = New SqlClient.SqlDataAdapter(varSqlCommand)
                objDS = New DataSet
                objDA.Fill(objDS)
                objDT = objDS.Tables(0)


            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try
            Return objDT
        End Function
        Public Function udfnOrderConfirmationcartListing(ByVal paracustomerid As String, ByVal OrderPaymentID As Integer) As DataTable
            Dim udfn As String
            Try

                tmpspcall = New SPCall
                Dim varSqlCommand As New SqlCommand("OrderConfirmationcartListing", tmpspcall.objConn)
                varSqlCommand.CommandType = CommandType.StoredProcedure
                varSqlCommand.Parameters.AddWithValue("@CustomerID", paracustomerid)
                varSqlCommand.Parameters.AddWithValue("@OrderPaymentID", OrderPaymentID)
                varSqlCommand.CommandTimeout = 0
                'ctlDataList.DataSource = varSqlCommand.ExecuteReader()
                'ctlDataList.DataBind()

                objDA = New SqlClient.SqlDataAdapter(varSqlCommand)
                objDS = New DataSet
                objDA.Fill(objDS)
                objDT = objDS.Tables(0)


            Catch ex As Exception
                objError = New DataError
                objError.WriteFile(ex)
            Finally
                tmpspcall.CloseConnection()
            End Try
            Return objDT
        End Function
    End Class
   
End Namespace
