Imports System.Configuration
Imports System.Data.SqlClient

Namespace ServiceClasses
    Public Class SPCall
        Public objConn As SqlClient.SqlConnection
        Public Sub New()

            Try
                Dim strcon As String = ConfigurationManager.ConnectionStrings("ConnStr").ConnectionString

                objConn = New SqlConnection(strcon)
                If objConn.State = ConnectionState.Closed Then objConn.Open()
            Catch ex As Exception

            End Try


        End Sub
        Public Sub CloseConnection()

            If IsNothing(objConn) = True Then Exit Sub
            If objConn.State = ConnectionState.Open Then objConn.Close()

            objConn = Nothing

        End Sub

    End Class
End Namespace