Imports BlueBerrit.ServiceClasses
Imports System.IO
Imports System.Net.Mail
Imports System.Security.Cryptography

Public Class cart
    Inherits System.Web.UI.Page
    Dim varsubtotal As Double, vartotalTAx As Double, varTotalAmount As Double, vartotalQuantity As Double, vartotalQuantityPaid As Double
    Dim CartMakerID As String
    Public action1 As String = String.Empty
    Public hash1 As String = String.Empty
    Public txnid1 As String = String.Empty
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            If Session("CustomerID") = "" Or Session("CustomerID") = Nothing Then
                Response.Redirect("index.aspx", True)
            Else

                ''''''UNPAID ORDERS
                udpopulatetab1()
                ''''''PAID ORDERS
                udpopulatetab2()
            End If
        End If
    End Sub
    Private Sub udpopulatetab1()
        Dim varobjBindAnimated As New SPDataService
        varobjBindAnimated.udfnSpcustomercartListing(Session("customerid"), "NOT PAID")

        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1

                image.Add(New clsImg() With { _
                          .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Rate"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                .lblquantity = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("quantity"), _
                  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                          .lblmenuDate = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuDate"), _
                             .lnkmakerid = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("CustMAkerID"), _
                          .lblmakerid = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("makerID"), _
                          .lblpaymentstatus = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("paymentstatus"), _
                                                  .ImgsingleAnimImag1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})

            Next
        Else

            lblsubtotal.Text = "0.00"
            lbltaxAmount.Text = "0.00"
            lbltotalAmount.Text = "0.00"
            lblfoodbagcount.Text = "You have no orders to proceed Payment"
            Pnlawaitingorder.Visible = False
            pnlAddpayment.Visible = False

        End If







        varobjBindAnimated.CloseConnection()
        RepeaterImagestab1.DataSource = image
        RepeaterImagestab1.DataBind()

    End Sub
    Private Sub udpopulatetab2()
        Dim varobjBindAnimated As New SPDataService
        varobjBindAnimated.udfnSpcustomercartListing(Session("customerid"), "PAID")

        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1

                image.Add(New clsImg() With { _
                          .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Rate"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                .lblquantity = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("quantity"), _
                  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                          .lblmenuDate = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuDate"), _
                          .lblconfirmcartGrandTotal = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("grandtotal"), _
                            .lnkmakerid = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("CustMAkerID"), _
                                                       .lblpaidstatus = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("paidstatus"), _
                          .lblprocessstatus = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("processstatus"), _
                          .lblshipmentstatus = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("shipmentstatus"), _
                          .lbldespatchstatus = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("DESPATCHSTATUS"), _
                                                  .ImgsingleAnimImag1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})

            Next
            pnlconfirmCart.Visible = True
        Else


            lblfoodbagcountPaid.Text = " You have no orders in your Cart."
            lblunabletoProcess.Text = "Order Canceled."""
            Dim message As String = "Your Food basket is Empty."
            pnlconfirmCart.Visible = False

            If lbltotalAmount.Text = "0.00" Then
                mp3.Show()
                lblredirect.Text = "Your Cart is Empty."

            End If

        End If







        varobjBindAnimated.CloseConnection()
        RepeaterImagestab2.DataSource = image
        RepeaterImagestab2.DataBind()

    End Sub
    Public Class clsImg

        Public Property lblRestaurantLoc() As String
            Get
                Return m_lblRestaurantLoc
            End Get
            Set(value As String)
                m_lblRestaurantLoc = value
            End Set
        End Property
        Private m_lblRestaurantLoc As String
        Public Property lblmakerid() As String
            Get
                Return m_lblmakerid
            End Get
            Set(value As String)
                m_lblmakerid = value
            End Set
        End Property
        Private m_lblmakerid As String
        Public Property lblprice() As String
            Get
                Return m_lblprice
            End Get
            Set(value As String)
                m_lblprice = value
            End Set
        End Property
        Private m_lblprice As String
        Public Property lblmenutax() As String
            Get
                Return m_lblmenutax
            End Get
            Set(value As String)
                m_lblmenutax = value
            End Set
        End Property
        Private m_lblmenutax As String
        Public Property lblquantity() As String
            Get
                Return m_lblquantity
            End Get
            Set(value As String)
                m_lblquantity = value
            End Set
        End Property
        Private m_lblquantity As String

        Public Property lblmenu() As String
            Get
                Return m_lblmenu
            End Get
            Set(value As String)
                m_lblmenu = value
            End Set
        End Property
        Private m_lblmenu As String
        Public Property ImgsingleAnimImag1() As String
            Get
                Return m_ImgsingleAnimImag1
            End Get
            Set(value As String)
                m_ImgsingleAnimImag1 = value
            End Set
        End Property
        Private m_ImgsingleAnimImag1 As String
        Public Property lblmenuDate() As String
            Get
                Return m_lblmenuDate
            End Get
            Set(value As String)
                m_lblmenuDate = value
            End Set
        End Property
        Private m_lblmenuDate As String
        Public Property lnkmakerid() As String
            Get
                Return m_lnkmakerid
            End Get
            Set(value As String)
                m_lnkmakerid = value
            End Set
        End Property
        Private m_lnkmakerid As String
        Public Property lblpaymentstatus() As String
            Get
                Return m_lblpaymentstatus
            End Get
            Set(value As String)
                m_lblpaymentstatus = value
            End Set
        End Property
        Private m_lblpaymentstatus As String
        Public Property lblconfirmcartGrandTotal() As String
            Get
                Return m_lblconfirmcartGrandTotal
            End Get
            Set(value As String)
                m_lblconfirmcartGrandTotal = value
            End Set
        End Property
        Private m_lblconfirmcartGrandTotal As String

        Public Property lblpaidstatus() As String
            Get
                Return m_lblpaidstatus
            End Get
            Set(value As String)
                m_lblpaidstatus = value
            End Set
        End Property
        Private m_lblpaidstatus As String
        Public Property lblprocessstatus() As String
            Get
                Return m_lblprocessstatus
            End Get
            Set(value As String)
                m_lblprocessstatus = value
            End Set
        End Property
        Private m_lblprocessstatus As String
        Public Property lblshipmentstatus() As String
            Get
                Return m_lblshipmentstatus
            End Get
            Set(value As String)
                m_lblshipmentstatus = value
            End Set
        End Property
        Private m_lblshipmentstatus As String
        Public Property lbldespatchstatus() As String
            Get
                Return m_lbldespatchstatus
            End Get
            Set(value As String)
                m_lbldespatchstatus = value
            End Set
        End Property
        Private m_lbldespatchstatus As String
    End Class

    '''unpaid orders row databound

    Protected Sub RepeaterImagestab1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab1.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim lblprice As String = CType(e.Item.FindControl("lblPrice"), Label).Text
            Dim lbltax As String = CType(e.Item.FindControl("lblMenuTax"), Label).Text
            Dim lblquantity As String = CType(e.Item.FindControl("quantity"), Label).Text
            Session("cartmakerid") = CType(e.Item.FindControl("linkcancelcart"), LinkButton).CommandArgument
            Dim lblpaymentstatus As String = CType(e.Item.FindControl("lblpaymentstatus"), Label).Text

            Dim price As String() = lblprice.ToString.Split(".")

            If price(1) <> "" And lblpaymentstatus <> "PAID" Then

                varsubtotal += Double.Parse(price(1).ToString) * Double.Parse(lblquantity.ToString)
                lblsubtotal.Text = varsubtotal
                vartotalTAx += Double.Parse(lbltax.ToString) * Double.Parse(lblquantity.ToString)
                lbltaxAmount.Text = vartotalTAx

                lbltotalAmount.Text = Double.Parse(lblsubtotal.Text) + Double.Parse(lbltaxAmount.Text)

                vartotalQuantity += Double.Parse(lblquantity.ToString)
                lblfoodbagcount.Text = vartotalQuantity

                lblsubtotal.Text = "Rs. " & lblsubtotal.Text
                lbltaxAmount.Text = "Rs. " & lbltaxAmount.Text
                lbltotalAmount.Text = "Rs. " & lbltotalAmount.Text
            Else
                lblsubtotal.Text = "0.00"
                lbltaxAmount.Text = "0.00"
                lbltotalAmount.Text = "0.00"
                lblfoodbagcount.Text = "0"
                CType(e.Item.FindControl("linkCancelCart"), LinkButton).Enabled = False
                CType(e.Item.FindControl("linkCancelCart"), LinkButton).OnClientClick = False
            End If
        End If

    End Sub


    '''paid orders row databound

    Protected Sub RepeaterImagestab2_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab2.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim lblprice As String = CType(e.Item.FindControl("lblPrice"), Label).Text
            Dim lbltax As String = CType(e.Item.FindControl("lblMenuTax"), Label).Text
            Dim lblquantity As String = CType(e.Item.FindControl("quantity"), Label).Text



            Dim price As String() = lblprice.ToString.Split(".")

            If price(1) <> "" Then
                vartotalQuantityPaid += Double.Parse(lblquantity.ToString)
                lblfoodbagcountPaid.Text = vartotalQuantityPaid
            Else
                lblfoodbagcountPaid.Text = "0"

            End If



        End If

    End Sub

    Protected Sub rptList_ItemCommand(sender As Object, e As RepeaterCommandEventArgs)


        If e.CommandName = "CancelCart" Then

            'Dim confirmValue As String = Request.Form("confirm_value")
            'If confirmValue = "Yes" Then
            ' ClientScript.RegisterStartupScript(Me.[GetType](), "alert", "alert('Order cancelled.')", True)

            Dim lblpaymentstatus As String = CType(e.Item.FindControl("lblpaymentstatus"), Label).Text
            Dim lblmakerid As String = CType(e.Item.FindControl("lblmakerid"), Label).Text

            If lblpaymentstatus <> "PAID" Then

                Dim ObjInsSaleOrderDetails As New SPDataService
                ObjInsSaleOrderDetails.udfnExecuteQuery("delete  from tblMenuOrderDetails where  custmakerid='" & lblmakerid.ToString & "'")
                ObjInsSaleOrderDetails.CloseConnection()

            Else
                CType(e.Item.FindControl("linkCancelCart"), LinkButton).OnClientClick = False
            End If


            udpopulatetab1()
            udpopulatetab2()
            mp2.Show()
            lblunabletoProcess.Text = "Order Canceled."
        ElseIf e.CommandName = "ProceedPayment" Then
            Dim ObjInsSaleOrderDetails As New SPDataService
            Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
            ObjInsSaleOrderDetails.CloseConnection()

            Session("OrderConfirmationPaymentID") = varCustMakerID


            Dim lblmakerid As String = CType(e.Item.FindControl("lblmakerid"), Label).Text



            Dim ObjInsSaleOrderpaymentDetails As New SPDataService
            ObjInsSaleOrderpaymentDetails.udfnExecuteQuery("update   tblMenuOrderDetails set paymenttype='COD',PaymentStatus='PAID',paymentid='" & varCustMakerID & "',diocode='" & Session("officeDiocode") & "',txnid=NULL  where  custmakerid='" & lblmakerid.ToString & "' and paymentstatus IS NULL ")
            ObjInsSaleOrderpaymentDetails.CloseConnection()

            sendconfirmationmail(varCustMakerID)
            Response.Redirect("OrderConfirmation.aspx", True)


        ElseIf e.CommandName = "ProceedOnlinePayment" Then



       
            Dim lblmakerid As String = CType(e.Item.FindControl("lblmakerid"), Label).Text
            Dim lblWeekmenu As String
            lblWeekmenu = CType(e.Item.FindControl("lblmenu"), Label).Text
            Dim lblweekprice As String()
            lblweekprice = CType(e.Item.FindControl("lblprice"), Label).Text.Split(".")
            Dim lblweekMenuTax As String
            lblweekMenuTax = CType(e.Item.FindControl("lblmenutax"), Label).Text
            Dim lblweekMenuQty As String
            lblweekMenuQty = CType(e.Item.FindControl("quantity"), Label).Text


            BankPaymentPageLoad()
            Dim amount As Double = (Double.Parse(lblweekprice(1).ToString) + Double.Parse(lblweekMenuTax.ToString)) * Double.Parse(lblweekMenuQty.ToString)
            Dim txnid As String = BankPaymentButtonClick(amount, Session("CustFirstName"), Session("custmailid"), Session("custPhone"), lblWeekmenu.ToString, "https://Blueberrit.com/ResponseHandling.aspx", "https://Blueberrit.com/ResponseHandling.aspx", "", "", "", "", "", "", "", "", Session("customerid"), "", "", "", "", "", "", "", "", "", "")
            '    Dim txnid As String = BankPaymentButtonClick(amount, Session("CustFirstName"), Session("custmailid"), Session("custPhone"), lblWeekmenu.ToString, "http://localhost:1422/ResponseHandling.aspx", "http://localhost:1422/ResponseHandling.aspx", "", "", "", "", "", "", "", "", Session("customerid"), "", "", "", "", "", "", "", "", "", "")
            Dim ObjInsSaleOrderDetails As New SPDataService
            Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
            ObjInsSaleOrderDetails.udfnExecuteQuery("update   tblMenuOrderDetails set txnid='" & txnid.ToString & "'  where  custmakerid='" & lblmakerid.ToString & "' and paymentstatus IS NULL ")
            ObjInsSaleOrderDetails.CloseConnection()


        Else
            mp2.Show()
            lblunabletoProcess.Text = "You Clicked No."
        End If



        'End If
    End Sub

    Protected Sub linkProceedPayment_click(sender As Object, e As EventArgs)


        Dim ObjInsSaleOrderDetails As New SPDataService
        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
        ObjInsSaleOrderDetails.CloseConnection()

        Session("OrderConfirmationPaymentID") = varCustMakerID

        Dim cmakerid As String() = Session("cartmakerid").ToString.Split(",")


        For Each maker As String In cmakerid
            Dim ObjInsSaleOrderpaymentDetails As New SPDataService
            ObjInsSaleOrderpaymentDetails.udfnExecuteQuery("update   tblMenuOrderDetails set paymenttype='COD',PaymentStatus='PAID',paymentid='" & varCustMakerID & "',diocode='" & Session("officeDiocode") & "'  where  custmakerid='" & maker & "' and paymentstatus IS NULL ")
            ObjInsSaleOrderpaymentDetails.CloseConnection()
        Next
        sendconfirmationmail(varCustMakerID)



        lblsubtotal.Text = "0.00"
        lbltaxAmount.Text = "0.00"
        lbltotalAmount.Text = "0.00"
        lblfoodbagcount.Text = "0"
        Response.Redirect("OrderConfirmation.aspx", True)

    End Sub

    Private Sub sendconfirmationmail(ByVal varCustMakerID As String)
        Dim reader As New StreamReader(Server.MapPath("~/mailing/orderplaced.html"))
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
        '   mystring = mystring.Replace("$$ta$$", lbltotalAmount.Text)

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




    Private Sub BtnRedirect_Click(sender As Object, e As EventArgs) Handles BtnRedirect.Click
        Response.Redirect("default.aspx", True)
    End Sub
    Private Sub BankPaymentPageLoad()
        Try



            key.Value = ConfigurationManager.AppSettings("MERCHANT_KEY")

            'If Not IsPostBack Then
            '    ' error form
            '    frmError.Visible = False
            '    'frmError.Visible = true;
            'Else
            'End If
            If String.IsNullOrEmpty(Request.Form("hash")) Then

            Else


            End If
        Catch ex As Exception

            Response.Write("<span style='color:red'>" + ex.Message + "</span>")
        End Try
    End Sub
    Public Function BankPaymentButtonClick(ByVal amount As String, ByVal firstname As String, ByVal email As String, ByVal phone As String, ByVal productinfo As String, ByVal surl As String, ByVal furl As String, ByVal lastname As String, ByVal curl As String, ByVal address1 As String, ByVal address2 As String, ByVal city As String, ByVal state As String, ByVal country As String, ByVal zipcode As String, ByVal udf1 As String, ByVal udf2 As String, ByVal udf3 As String, ByVal udf4 As String, ByVal udf5 As String, ByVal pg As String, ByVal udf6 As String, ByVal udf7 As String, ByVal udf8 As String, ByVal udf9 As String, ByVal udf10 As String) As String
        Try

            Dim hashVarsSeq As String()
            Dim hash_string As String = String.Empty

            Dim MerchatKey As String = ConfigurationManager.AppSettings("MERCHANT_KEY")

            If String.IsNullOrEmpty(Request.Form("txnid")) Then
                ' generating txnid
                Dim rnd As New Random()
                Dim strHash As String = Generatehash512(rnd.ToString() + DateTime.Now)

                txnid1 = strHash.ToString().Substring(0, 20)
            Else
                txnid1 = Request.Form("txnid")
            End If
            If String.IsNullOrEmpty(Request.Form("hash")) Then
                ' generating hash value
                If String.IsNullOrEmpty(ConfigurationManager.AppSettings("MERCHANT_KEY")) Then
                    'error

                    '   frmError.Visible = True
                    Return txnid1
                Else

                    '   frmError.Visible = False
                    hashVarsSeq = ConfigurationManager.AppSettings("hashSequence").Split("|"c)
                    ' spliting hash sequence from config
                    hash_string = ""
                    For Each hash_var As String In hashVarsSeq
                        If hash_var = "key" Then
                            hash_string = hash_string + ConfigurationManager.AppSettings("MERCHANT_KEY")
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "txnid" Then
                            hash_string = hash_string & txnid1
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "amount" Then
                            hash_string = hash_string & Convert.ToDecimal(amount).ToString("g29")
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "productinfo" Then
                            hash_string = hash_string & productinfo
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "firstname" Then
                            hash_string = hash_string & firstname
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "email" Then
                            hash_string = hash_string & email
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "udf1" Then
                            hash_string = hash_string & udf1
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "udf2" Then
                            hash_string = hash_string & udf2
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "udf4" Then
                            hash_string = hash_string & udf4
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "udf5" Then
                            hash_string = hash_string & udf5
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "udf6" Then
                            hash_string = hash_string & udf6
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "udf7" Then
                            hash_string = hash_string & udf7
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "udf8" Then
                            hash_string = hash_string & udf8
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "udf9" Then
                            hash_string = hash_string & udf9
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "udf10" Then
                            hash_string = hash_string & udf10
                            hash_string = hash_string & Convert.ToString("|"c)
                        ElseIf hash_var = "udf3" Then
                            hash_string = hash_string & udf3
                            hash_string = hash_string & Convert.ToString("|"c)

                        End If
                    Next

                    hash_string += ConfigurationManager.AppSettings("SALT")
                    ' appending SALT
                    hash1 = Generatehash512(hash_string).ToLower()
                    'generating hash
                    ' setting URL
                    action1 = ConfigurationManager.AppSettings("PAYU_BASE_URL") + "/_payment"


                End If

            ElseIf Not String.IsNullOrEmpty(Request.Form("hash")) Then
                hash1 = Request.Form("hash")

                action1 = ConfigurationManager.AppSettings("PAYU_BASE_URL") + "/_payment"
            End If




            If Not String.IsNullOrEmpty(hash1) Then
                hash.Value = hash1
                txnid.Value = txnid1

                Dim data As New System.Collections.Hashtable()
                ' adding values in gash table for data post
                data.Add("hash", hash.Value)
                data.Add("txnid", txnid.Value)
                data.Add("key", MerchatKey.ToString)
                Dim AmountForm As String = Convert.ToDecimal(amount.ToString).ToString("g29")
                ' eliminating trailing zeros
                '  amount.Text = AmountForm
                data.Add("amount", AmountForm)
                data.Add("firstname", firstname.ToString)
                data.Add("email", email.ToString)
                data.Add("phone", phone.ToString)
                data.Add("productinfo", productinfo.ToString)
                data.Add("surl", surl.ToString)
                data.Add("furl", furl.ToString)
                data.Add("lastname", lastname.ToString)
                data.Add("curl", curl.ToString)
                data.Add("address1", address1.ToString)
                data.Add("address2", address2.ToString)
                data.Add("city", city.ToString)
                data.Add("state", state.ToString)
                data.Add("country", country.ToString)
                data.Add("zipcode", zipcode.ToString)
                data.Add("udf1", udf1.ToString)
                data.Add("udf2", udf2.ToString)
                data.Add("udf3", udf3.ToString)
                data.Add("udf4", udf4.ToString)
                data.Add("udf5", udf5.ToString)
                data.Add("pg", pg.ToString)


                Dim strForm As String = PreparePOSTForm(action1, data)

                Page.Controls.Add(New LiteralControl(strForm))
            Else
                'no hash



            End If

        Catch ex As Exception


            Response.Write("<span style='color:red'>" + ex.Message + "</span>")
        End Try

        Return txnid1
    End Function
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
    Private Function PreparePOSTForm(url As String, data As System.Collections.Hashtable) As String
        ' post form
        'Set a name for the form
        Dim formID As String = "PostForm"
        'Build the form using the specified data to be posted.
        Dim strForm As New StringBuilder()
        strForm.Append((Convert.ToString((Convert.ToString((Convert.ToString("<form id=""") & formID) + """ name=""") & formID) + """ action=""") & url) + """ method=""POST"">")

        For Each key As System.Collections.DictionaryEntry In data

            strForm.Append("<input type=""hidden"" name=""" + key.Key + """ value=""" + key.Value + """>")
        Next


        strForm.Append("</form>")
        'Build the JavaScript which will do the Posting operation.
        Dim strScript As New StringBuilder()
        strScript.Append("<script language='javascript'>")
        strScript.Append((Convert.ToString((Convert.ToString("var v") & formID) + " = document.") & formID) + ";")
        strScript.Append((Convert.ToString("v") & formID) + ".submit();")
        strScript.Append("</script>")
        'Return the form and the script concatenated.
        '(The order is important, Form then JavaScript)
        Return strForm.ToString() + strScript.ToString()
    End Function
End Class