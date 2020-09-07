Imports System.IO

Namespace ServiceClasses

    Public Class DataError
        Inherits System.Web.UI.Page
        Dim objStream As StreamWriter
        Dim strFileName As String
        Public Sub New()

            strFileName = Server.MapPath("./threats/") & Date.Today.ToLongDateString.ToString & ".html"  '' for local

            objStream = New StreamWriter(strFileName, True)

        End Sub

        Public Sub WriteFile(ByVal e As Exception)

            Dim strHTML As String

            strHTML = "<br><table name='errTab' border=1 bordercolor=Blue style='color:Purple;' cellpadding=0 cellspacing=0>"
            strHTML = strHTML & "<tr>"
            strHTML = strHTML & "<td style='font-weight:bold;'>Date And Time</td>"
            strHTML = strHTML & "<td>" & Date.Today.ToLongDateString & ", " & Date.Now.ToLongTimeString & "</td>"
            strHTML = strHTML & "</tr>"
            strHTML = strHTML & "<tr>"
            strHTML = strHTML & "<td style='font-weight:bold;'> Message </td>"
            strHTML = strHTML & "<td>" & e.Message & "</td>"
            strHTML = strHTML & "</tr>"
            strHTML = strHTML & "<tr>"
            strHTML = strHTML & "<td style='font-weight:bold;'> Source </td>"
            strHTML = strHTML & "<td>" & e.Source & "</td>"
            strHTML = strHTML & "</tr>"
            strHTML = strHTML & "<tr>"
            strHTML = strHTML & "<td style='font-weight:bold;'> Stack Trace </td>"
            strHTML = strHTML & "<td>" & e.StackTrace & "</td>"
            strHTML = strHTML & "</tr>"
            strHTML = strHTML & "</table>"


            If strHTML Is DBNull.Value Then

            Else
                objStream.Write(strHTML)
                objStream.Close()
                objStream = Nothing
            End If

        End Sub

    End Class

End Namespace


