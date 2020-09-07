Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Security.Cryptography
Imports System.Text
Imports BlueBerrit.ServiceClasses
Imports System.IO
Imports System.Net.Mail

Public Class ResponseHandling
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            Dim merc_hash_vars_seq As String()
            Dim merc_hash_string As String = String.Empty
            Dim merc_hash As String = String.Empty
            Dim order_id As String = String.Empty
            Dim hash_seq As String = "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10"

            If Request.Form("status") = "success" Then

                merc_hash_vars_seq = hash_seq.Split("|"c)
                Array.Reverse(merc_hash_vars_seq)
                merc_hash_string = ConfigurationManager.AppSettings("SALT") + "|" & Request.Form("status")


                For Each merc_hash_var As String In merc_hash_vars_seq
                    merc_hash_string += "|"

                    merc_hash_string = merc_hash_string & (If(Request.Form(merc_hash_var) IsNot Nothing, Request.Form(merc_hash_var), ""))
                Next
                merc_hash = Generatehash512(merc_hash_string).ToLower()



                If merc_hash <> Request.Form("hash") Then

                    Response.Write("Hash value did not matched")
                Else
                    order_id = Request.Form("txnid")


                    'Hash value did not matched
                    Response.Write("value matched")

                    Dim txnid As String = Request.Form("txnid")
                    Session("customerid") = Request.Form("udf1")



                    Dim objdataChkServVerifiedornot As New DataService
                    objdataChkServVerifiedornot.GetSingleRowSelectField("tblcustomeruserprofile INNER JOIN tblcityProfile ON SUBSTRING(tblcustomeruserprofile.CustomerID, 1, 6) = tblcityProfile.Citycode INNER JOIN tblLocationProfile ON SUBSTRING(tblcustomeruserprofile.CustomerID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN tblofficeProfile ON SUBSTRING(tblcustomeruserprofile.CustomerID, 1, 14) = tblofficeProfile.Officecode", " tblcustomeruserprofile.Status, tblcustomeruserprofile.CustomerID, tblcustomeruserprofile.CustomerName, tblcustomeruserprofile.Firstname, tblcustomeruserprofile.PhoneNumber, tblcityprofile.City, tblLocationprofile.LocationName, tblofficeprofile.OfficeName, tblcustomeruserprofile.MailID,tblofficeprofile.DeliveryAddress,tblcityprofile.state ", " tblcustomeruserprofile.customerid='" & Session("customerid") & "'  and tblcustomeruserprofile.status='Verified'  ")
                    If objdataChkServVerifiedornot.objDReader.HasRows Then


                        Session("StrUserIPAddress") = "::1"

                        Session("CustomerID") = objdataChkServVerifiedornot.objDReader("CustomerID")

                        Session("CustFirstName") = objdataChkServVerifiedornot.objDReader("Firstname")
                        Session("CustomerNAme") = objdataChkServVerifiedornot.objDReader("CustomerName")
                        Session("custmailid") = objdataChkServVerifiedornot.objDReader("MailID")
                        Session("custPhone") = objdataChkServVerifiedornot.objDReader("PhoneNumber")
                        Session("CustCityID") = Session("CustomerID").ToString.Substring(0, 6)
                        Session("CustLocationID") = Session("CustomerID").ToString.Substring(0, 10)
                        Session("OfficeID") = Session("CustomerID").ToString.Substring(0, 14)
                        Session("custCity") = objdataChkServVerifiedornot.objDReader("city")
                        Session("custLocationName") = objdataChkServVerifiedornot.objDReader("LocationName")
                        Session("custOfficeName") = objdataChkServVerifiedornot.objDReader("Officename")
                        Session("custDeliveryAddress") = objdataChkServVerifiedornot.objDReader("DeliveryAddress")
                        Session("custstate") = objdataChkServVerifiedornot.objDReader("state")

                        Dim objdataChkServVerifiedOFFICE As New DataService
                        objdataChkServVerifiedOFFICE.GetSingleRow("tblofficeprofile", "officecode = '" & Session("OfficeID") & "'   ")
                        If objdataChkServVerifiedOFFICE.objDReader.HasRows Then
                            If IsDBNull(objdataChkServVerifiedOFFICE.objDReader("Noofemployees")) Then Session("officeemployeelimit") = "1" Else Session("officeemployeelimit") = objdataChkServVerifiedOFFICE.objDReader("Noofemployees")
                            Session("officeDiocode") = objdataChkServVerifiedOFFICE.objDReader("Diocode")
                            objdataChkServVerifiedOFFICE.CloseConnection()
                        Else
                            objdataChkServVerifiedOFFICE.CloseConnection()
                        End If
                        objdataChkServVerifiedOFFICE.CloseConnection()


                        Dim ChennaiUTCTime As DateTime = Date.UtcNow.AddHours(5.5)
                        Session("workingDate") = ChennaiUTCTime

                     

                        objdataChkServVerifiedornot.CloseConnection()
                

                    End If
                    objdataChkServVerifiedornot.CloseConnection()





                    If txnid <> "" Then
                        udfnpayment(txnid, Session("customerid"))






                    End If



                End If
            Else


                ' osc_redirect(osc_href_link(FILENAME_CHECKOUT, 'payment' , 'SSL', null, null,true));

                Response.Write("Hash value did not matched")
            End If

        Catch ex As Exception

            Response.Write("<span style='color:red'>" & ex.Message & "</span>")
        End Try
    End Sub

    Public Function Generatehash512(text As String) As String

        Dim message As Byte() = Encoding.UTF8.GetBytes(text)

        Dim UE As New UnicodeEncoding()
        Dim hashValue As Byte()
        Dim hashString As New SHA512Managed()
        Dim hex As String = ""
        hashValue = hashString.ComputeHash(message)
        For Each x As Byte In hashValue
            hex += [String].Format("{0:x2}", x)
        Next
        Return hex

    End Function


    Private Sub udfnpayment(ByVal txnid As String, ByVal customerid As String)
        Dim ObjInsSaleOrderDetails As New SPDataService
        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
        ObjInsSaleOrderDetails.CloseConnection()

        Session("OrderConfirmationPaymentID") = varCustMakerID
        Session("customerid") = Request.Form("udf1")





        Dim ObjInsSaleOrderpaymentDetails As New SPDataService
        ObjInsSaleOrderpaymentDetails.udfnExecuteQuery("update   tblMenuOrderDetails set paymenttype='BANK PAYMENT',PaymentStatus='PAID',paymentid='" & varCustMakerID & "',diocode='" & Session("officeDiocode") & "'  where  txnid='" & txnid.ToString & "' and paymentstatus IS NULL ")
        ObjInsSaleOrderpaymentDetails.CloseConnection()

        sendconfirmationmail(varCustMakerID)
        Response.Redirect("OrderConfirmation.aspx", True)
    End Sub
    Private Sub sendconfirmationmail(ByVal varCustMakerID As String)
        Dim reader As New StreamReader(Server.MapPath("~/mailing/OrderPlacedBank.html"))
        Dim readfile As String = reader.ReadToEnd()
        Dim mystring As String = ""
        mystring = readfile
        mystring = mystring.Replace("$$name$$", Session("custfirstname"))
        mystring = mystring.Replace("$$ORDERID$$ ", varCustMakerID)
        mystring = mystring.Replace("$$ORDERDATE$$", Date.UtcNow.AddHours(5.5))
        mystring = mystring.Replace("$$city$$", Session("custcity"))
        mystring = mystring.Replace("$$state$$", Session("custstate"))
        mystring = mystring.Replace("$$deliveryAddress$$", Session("custdeliveryaddress"))
        mystring = mystring.Replace("$$OfficeName$$", Session("custOfficeName"))

        mystring = mystring.Replace("$$mobileno$$", Session("custphone"))


        Dim vartotalAmount As Double
        Dim varobjdatabindorder As New DataService
        varobjdatabindorder.FillDataSetQueryJoin("select menuname,rate,tax,quantity,convert(nvarchar(15),menudate,6) as menudate from tblmenuorderdetails where paymentid='" & varCustMakerID & "' ")
        If varobjdatabindorder.objDS.Tables(0).Rows.Count <> 0 Then
            For j = 0 To varobjdatabindorder.objDS.Tables(0).Rows.Count - 1
                mystring = mystring.Replace("$$quantity$$", varobjdatabindorder.objDS.Tables(0).Rows(j).Item("quantity"))
                mystring = mystring.Replace("$$ItemName$$", varobjdatabindorder.objDS.Tables(0).Rows(j).Item("menuname"))
                mystring = mystring.Replace("$$DeliveryDate$$", varobjdatabindorder.objDS.Tables(0).Rows(j).Item("menudate"))
                mystring = mystring.Replace("$$Price$$", varobjdatabindorder.objDS.Tables(0).Rows(j).Item("rate"))
                mystring = mystring.Replace("$$Tax$$", varobjdatabindorder.objDS.Tables(0).Rows(j).Item("tax"))

                vartotalAmount += (Double.Parse(varobjdatabindorder.objDS.Tables(0).Rows(j).Item("rate")) + Double.Parse(varobjdatabindorder.objDS.Tables(0).Rows(j).Item("tax"))) * Double.Parse(varobjdatabindorder.objDS.Tables(0).Rows(j).Item("quantity"))

            Next
        End If
        varobjdatabindorder.CloseConnection()


        mystring = mystring.Replace("$$TA$$", "Rs." & vartotalAmount)

        Dim msg As New System.Net.Mail.MailMessage
        msg.From = New System.Net.Mail.MailAddress("sales@blueberrit.com")
        msg.[To].Add(New MailAddress(Session("custmailid")))
        msg.Subject = "order confirmation - blueberrit"
        msg.Body = mystring.ToString()
        msg.IsBodyHtml = True
        Dim smtp As New System.Net.Mail.SmtpClient
        smtp.EnableSsl = True
        smtp.Send(msg)
        smtp.Dispose()
        reader.Dispose()









    End Sub

End Class