Imports BlueBerrit.ServiceClasses
Imports System.IO
Imports System.Net.Mail

Public Class orderconfirmation
    Inherits System.Web.UI.Page
    Dim varsubtotal As Double, vartotalTAx As Double, varTotalAmount As Double, vartotalQuantity As Double, vartotalQuantityPaid As Double
    Dim CartMakerID As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Session("customerid") = "" Or Session("customerid") = Nothing Then
                Response.Redirect("index.aspx", True)
            Else
                ''''''PAID ORDERS
                udpopulatetab2()
            End If
        End If
    End Sub
    
    Private Sub udpopulatetab2()
        Dim varobjBindAnimated As New SPDataService
        varobjBindAnimated.udfnOrderConfirmationcartListing(Session("customerid"), Session("OrderConfirmationPaymentID"))

        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1

                image.Add(New clsImg() With { _
                          .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Rate"), _
              .lblmenutax = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                .lblquantity = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("quantity"), _
                  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                          .lblmenuDate = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuDate"), _
                          .lblconfirmcartGrandTotal = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("grandtotal"), _
                            .lnkmakerid = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("CustMAkerID"), _
                                                       .lblpaymentstatus = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("paymentstatus"), _
                           .lblOfficeName = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename"), _
                          .lblOfficeAddress = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("OfficeAddress"), _
                           .lblDeliveryAddress = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("DeliveryAddress"), _
                          .lblBuildingNAme = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("BuildingLocation"), _
                                                                          .ImgsingleAnimImag1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})

            Next
            pnlconfirmCart.Visible = True
        Else


            lblfoodbagcountPaid.Text = "No Orders In Your Delivery List"
            Dim message As String = "Your Food basket is Empty."
            pnlconfirmCart.Visible = False

          

        End If
        txtNotificationEmail.text = Session("custmailid")
        txtNotificationMobileNo.text = Session("custPhone")






        varobjBindAnimated.CloseConnection()
        RepeaterImagestab2.DataSource = image
        RepeaterImagestab2.DataBind()

    End Sub
    Protected Sub linkchangeNotification_click(sender As Object, e As EventArgs)

     
      



        Dim ObjInsSaleOrderpaymentDetails As New SPDataService
        ObjInsSaleOrderpaymentDetails.udfnExecuteQuery("update   tblMenuOrderDetails set NotificationMail='" & txtNotificationEmail.Text & "',NotificationMobile='" & txtNotificationMobileNo.Text & "'  where  paymentID='" & Session("OrderConfirmationPaymentID") & "'  ")
        ObjInsSaleOrderpaymentDetails.CloseConnection()

        mp3.Show()
        lblredirect.Text = "Notification Contact Changed."

     
    End Sub
    Private Sub BtnRedirect_Click(sender As Object, e As EventArgs) Handles BtnRedirect.Click
        Response.Redirect("default.aspx", True)
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
        Public Property lblOfficeName() As String
            Get
                Return m_lblOfficeName
            End Get
            Set(value As String)
                m_lblOfficeName = value
            End Set
        End Property
        Private m_lblOfficeName As String
        Public Property lblOfficeAddress() As String
            Get
                Return m_lblOfficeAddress
            End Get
            Set(value As String)
                m_lblOfficeAddress = value
            End Set
        End Property
        Private m_lblOfficeAddress As String
        Public Property lblDeliveryAddress() As String
            Get
                Return m_lblDeliveryAddress
            End Get
            Set(value As String)
                m_lblDeliveryAddress = value
            End Set
        End Property
        Private m_lblDeliveryAddress As String
        Public Property lblBuildingNAme() As String
            Get
                Return m_lblBuildingNAme
            End Get
            Set(value As String)
                m_lblBuildingNAme = value
            End Set
        End Property
        Private m_lblBuildingNAme As String
        Public Property txtNotificationEmail() As String
            Get
                Return m_txtNotificationEmail
            End Get
            Set(value As String)
                m_txtNotificationEmail = value
            End Set
        End Property
        Private m_txtNotificationEmail As String
        Public Property txtNotificationMobileNo() As String
            Get
                Return m_txtNotificationMobileNo
            End Get
            Set(value As String)
                m_txtNotificationMobileNo = value
            End Set
        End Property
        Private m_txtNotificationMobileNo As String
    End Class

  

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
End Class