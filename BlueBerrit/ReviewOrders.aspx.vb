Imports BlueBerrit.ServiceClasses
Imports System.IO
Imports System.Net.Mail
Imports System.Web.Services

Public Class ReviewOrders
    Inherits System.Web.UI.Page
    Dim varsubtotal As Double, vartotalTAx As Double, varTotalAmount As Double, vartotalQuantity As Double, vartotalQuantityPaid As Double
    Dim CartMakerID As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            If Session("CustomerID") = "" Or Session("CustomerID") = Nothing Then
                Response.Redirect("index.aspx", True)
            Else


                ''''''PAID ORDERS
                udpopulatetab2()
            End If

        Else
            'If Session("CustomerID") = "" Or Session("CustomerID") = Nothing Then
            '    Response.Redirect("index.aspx", True)
            'Else


            '    ''''''PAID ORDERS
            '    udpopulatetab2()
            'End If


        End If
    End Sub

    Private Sub udpopulatetab2()
      

        Dim varobjBindAnimated As New SPDataService
        varobjBindAnimated.udfnSpcustomercartListing(Session("customerid"), "Delivered")

        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1

                image.Add(New clsImg() With { _
                          .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
                               .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                                            .lblmenuid = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid"), _
                                            .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
                 .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
                            .lnkmakerid = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("CustMAkerID"), _
                                                    .txtReview = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Review"), _
                                                  .ImgsingleAnimImag1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})

            Next
            ' pnlconfirmCart.Visible = True
        Else


            'lblfoodbagcountPaid.Text = "No Orders In Your Delivery List"
            Dim message As String = "you haven't taste our food to review"
            '   pnlconfirmCart.Visible = False



            mp3.Show()
            lblredirect.Text = "you haven't taste our food to review."


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
        Public Property txtReview() As String
            Get
                Return m_txtReview
            End Get
            Set(value As String)
                m_txtReview = value
            End Set
        End Property
        Private m_txtReview As String
        Public Property lblcategory() As String
            Get
                Return m_lblcategory
            End Get
            Set(value As String)
                m_lblcategory = value
            End Set
        End Property
        Private m_lblcategory As String
        Public Property lblcontains() As String
            Get
                Return m_lblcontains
            End Get
            Set(value As String)
                m_lblcontains = value
            End Set
        End Property
        Private m_lblcontains As String
        Public Property lblmenuid() As String
            Get
                Return m_lblmenuid
            End Get
            Set(value As String)
                m_lblmenuid = value
            End Set
        End Property
        Private m_lblmenuid As String
    End Class






    Private cart As New ArrayList()
    Protected Sub rptList_ItemCommand(sender As Object, e As RepeaterCommandEventArgs)


        If e.CommandName = "Review" Then
            Dim thisweekmenuid As String = e.CommandArgument.ToString()
            Dim confirmValue As String = Request.Form("confirm_value")
        

            Dim lblmenuid As String = CType(e.Item.FindControl("lblmenuid"), Label).Text
            Dim txtreview As String = CType(e.Item.FindControl("txtreview"), TextBox).Text
            Dim ObjInsSaleOrderDetails As New SPDataService
            Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "Reviews")
            ObjInsSaleOrderDetails.udfnExecuteQuery("insert into tblcustomerUserReviews (MenuID, Customername, Review, Rating, checkerid, status, customerID) values ('" & lblmenuid.ToString & "','" & Session("CustomerNAme").ToString & "','" & txtreview & "','5','" & varCustMakerID & "','Approved','" & Session("CustomerID").ToString & "') ")
            ObjInsSaleOrderDetails.CloseConnection()
            cart.Add(thisweekmenuid)

            udpopulatetab2()

        Else
            ClientScript.RegisterStartupScript(Me.[GetType](), "alert", "alert('You clicked NO!')", True)
        End If




        'End If
    End Sub
    Protected Sub RepeaterImagestab2_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab2.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim Review As String = CType(e.Item.FindControl("txtreview"), TextBox).Text
            If Review <> "" Then
                CType(e.Item.FindControl("linkPostReview"), LinkButton).Visible = False
                '  CType(e.Item.FindControl("linkPostReview"), LinkButton).Enabled = False
            Else
                CType(e.Item.FindControl("linkPostReview"), LinkButton).Visible = True
                '   CType(e.Item.FindControl("linkPostReview"), LinkButton).Enabled = False
            End If
        End If
    End Sub
    Private Sub BtnRedirect_Click(sender As Object, e As EventArgs) Handles BtnRedirect.Click
        Response.Redirect("default.aspx", True)
    End Sub
End Class