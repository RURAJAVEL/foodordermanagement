Imports System.Net.Mail
Imports System.IO
Imports System.Configuration
Imports System.Data
Imports BlueBerrit.ServiceClasses
Imports AjaxControlToolkit
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net

Public Class _default
    Inherits System.Web.UI.Page

    Public action1 As String = String.Empty
    Public hash1 As String = String.Empty
    Public txnid1 As String = String.Empty
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ChennaiUTCTime As DateTime = Date.UtcNow.AddHours(5.5)

        If Not SM1.IsInAsyncPostBack Then
            Session("timeout") = (((11 * 60) + 30) - ((Double.Parse(ChennaiUTCTime.Hour) * 60) + ChennaiUTCTime.Minute)).ToString
        End If
        If Not IsPostBack Then
            If Session("CustomerID") = "" Or Session("CustomerID") = Nothing Then
                Response.Redirect("index.aspx", True)
            Else

                If Double.Parse(ChennaiUTCTime.Hour * 60 + ChennaiUTCTime.Minute) > 690 Then
                    Session("TodayExpiryTime") = "closed"
                Else
                    Session("TodayExpiryTime") = "Active"
                End If

                '''''''''' TIMER
                ''   Session("timeout") = (((11 * 60) + 30) - ((Double.Parse(ChennaiUTCTime.Hour) * 60) + ChennaiUTCTime.Minute)).ToString




                lbluser.Text = "hi," & Session("CustFirstName") & "<br/> Welcome to BlueBerrIT.<br/>Currently you have no special features available."
                ''''THIS WEEK MENU
                udpopulatetab1()
                udpopulatetab2()
                udpopulatetab3()
                udpopulatetab4()
                udpopulatetab5()
                udpopulatetab6()

                ''''''TODAY MENU
                udpopulatetab7()
                udpopulatetab8()
                udpopulatetab9()

            End If

        Else
            If Double.Parse(ChennaiUTCTime.Hour * 60 + ChennaiUTCTime.Minute) > 690 Then
                Session("TodayExpiryTime") = "closed"
            Else
                Session("TodayExpiryTime") = "Active"
            End If




        End If
       
    End Sub

    Protected Sub timer1_tick(sender As Object, e As EventArgs)
        Dim ChennaiUTCTime As DateTime = Date.UtcNow.AddHours(5.5)
        If ((11 * 60) + 30) - ((Double.Parse(ChennaiUTCTime.Hour) * 60) + ChennaiUTCTime.Minute) > 0 Then
            lblTimer.Text = (((11 * 60) + 30) - ((Double.Parse(ChennaiUTCTime.Hour) * 60) + ChennaiUTCTime.Minute)).ToString + "  Minutes  " + (60 - ChennaiUTCTime.Second).ToString + "  seconds left to place today order.  "
            lbltimertodayveg.Text = "Ordering ends at 11:30 <br/>" + (((11 * 60) + 30) - ((Double.Parse(ChennaiUTCTime.Hour) * 60) + ChennaiUTCTime.Minute)).ToString + "  Minutes  " + (60 - ChennaiUTCTime.Second).ToString + "  seconds left to place today order.  "
            lbltimertodayNonveg.Text = "Ordering ends at 11:30 <br/>" + (((11 * 60) + 30) - ((Double.Parse(ChennaiUTCTime.Hour) * 60) + ChennaiUTCTime.Minute)).ToString + "  Minutes  " + (60 - ChennaiUTCTime.Second).ToString + "  seconds left to place today order.  "
            lbltimertodayLite.Text = "Ordering ends at 11:30 <br/>" + (((11 * 60) + 30) - ((Double.Parse(ChennaiUTCTime.Hour) * 60) + ChennaiUTCTime.Minute)).ToString + "  Minutes  " + (60 - ChennaiUTCTime.Second).ToString + "  seconds left to place today order.  "
        Else
            lblTimer.Text = "Today order closed"
            lbltimertodayveg.Text = "Today order closed"
            lbltimertodayNonveg.Text = "Today order closed"
            lbltimertodayLite.Text = "Today order closed"
        End If
    End Sub
    Private Sub udpopulatetab7()
        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.GetSingleRowSelectField("tblweekMenu INNER JOIN   tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN   tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID", "(SELECT isnull(sum(quantity),0) FROM  tblmenuorderdetails WHERE CONVERT(nvarchar(11), tblmenuorderdetails.menudate, 101) = CONVERT(nvarchar(11), tblweekMenu.menudate, 101) AND menuid = tblweekMenu.menuid) AS orderqty,(SELECT isnull(sum(quantity),0) FROM  tblmenuorderdetails WHERE CONVERT(nvarchar(11), tblmenuorderdetails.menudate, 101) = CONVERT(nvarchar(11), tblweekMenu.menudate, 101) AND menuid = tblweekMenu.menuid) AS orderqty,*,convert(nvarchar(11),menudate,6) as orderdate", " tblweekmenu.officeid='" & Session("OfficeID") & "' and tblweekmenu.category='veg' and convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101) and tblweekmenu.status='Approved'  ")
        If varobjBindAnimated.objDReader.HasRows Then
            ImgsingleAnimImag.ImageUrl = varobjBindAnimated.objDReader("productlocation") & "/" & varobjBindAnimated.objDReader("menuid") & ".jpg"

            lblRestaurantnameToday.Text = "Today " & varobjBindAnimated.objDReader("orderdate") & " At " & varobjBindAnimated.objDReader("officename") & " , " & varobjBindAnimated.objDReader("locationname") & " "
            lblRestaurantLoc.Text = varobjBindAnimated.objDReader("restaurantname")
            lblprice.Text = varobjBindAnimated.objDReader("price")
            lblMenuTax.Text = varobjBindAnimated.objDReader("tax")
            lblcategory.Text = varobjBindAnimated.objDReader("category")
            lblmenu.Text = varobjBindAnimated.objDReader("menuname")
            lbldescription.Text = varobjBindAnimated.objDReader("Description")
            lblmenuid.Text = varobjBindAnimated.objDReader("menuid")
            lblcontains.Text = varobjBindAnimated.objDReader("contain")


            Dim strOrderqtymsg As String = ""
            If varobjBindAnimated.objDReader("orderqty") <> 0 Then
                strOrderqtymsg = "Already you have ordered this dish  " & varobjBindAnimated.objDReader("orderqty") & " Nos.<br /> still you want to proceed "
            ElseIf varobjBindAnimated.objDReader("orderqty") = 0 Then
                strOrderqtymsg = ""
            End If
            lbltodayvOrderedQty.text = strOrderqtymsg




            Image1.ImageUrl = varobjBindAnimated.objDReader("productlocation") & "/" & varobjBindAnimated.objDReader("menuid") & ".jpg"

            lblOrderDatetv.Text = varobjBindAnimated.objDReader("orderDate")
            lblRestaurantLocModal.Text = varobjBindAnimated.objDReader("restaurantname")
            lblpriceModal.Text = varobjBindAnimated.objDReader("price")
            lblMenuTaxModal.Text = varobjBindAnimated.objDReader("tax")
            lblmenuModal.Text = varobjBindAnimated.objDReader("menuname")
            lbldescriptionmodal.Text = varobjBindAnimated.objDReader("Description")
            lblcontainsModal.Text = varobjBindAnimated.objDReader("contain")




            If Session("TodayExpiryTime") = "closed" Then

                txttodayQtyveg.Enabled = False
                linkCartTodayVeg.Text = "Order closed"
                linkCartTodayVeg.Enabled = False
                linkCartTodayVeg.OnClientClick = False
                '  cbe0.Enabled = False
                mpe0.Enabled = False
            Else

                linkCartTodayVeg.Text = "Add to cart"
                linkCartTodayVeg.Enabled = False
            End If

        Else
            tab54.Visible = False
            litodayveg.Visible = False
            tab55.Visible = True


        End If
        varobjBindAnimated.CloseConnection()

        If lblmenuid.Text = "" Then lblmenuid.Text = ""
        Dim varobjBindAnimatedReview As New DataService
        varobjBindAnimatedReview.FillDataSetQueryJoin("select top(3) * from tblcustomerUserReviews where menuid='" & lblmenuid.Text & "' and checkerid is not null  order by autonum desc   ")
        If varobjBindAnimatedReview.objDS.Tables(0).Rows.Count <> 0 Then
            For j = 0 To varobjBindAnimatedReview.objDS.Tables(0).Rows.Count - 1
                If j = 0 Then
                    lbltodayvegReview1.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Review")
                    lbltodayvegUser1.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Customername")
                ElseIf j = 1 Then
                    lbltodayvegReview2.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Review")
                    lbltodayvegUser2.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Customername")
                Else
                    lbltodayvegReview3.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Review")
                    lbltodayvegUser3.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Customername")
                End If
            Next
        Else

            lbltodayvegReview1.Text = "Looks like there are no reviews for this dish yet. If you order now you can change all that. "
            lbltodayvegUser1.Text = ""

            lbltodayvegReview2.Text = "Looks like there are no reviews for this dish yet. If you order now you can change all that. "
            lbltodayvegUser2.Text = ""

            lbltodayvegReview3.Text = "Looks like there are no reviews for this dish yet. If you order now you can change all that. "
            lbltodayvegUser3.Text = ""


        End If
        varobjBindAnimatedReview.CloseConnection()


    End Sub
    Private Sub udpopulatetab8()
        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.GetSingleRowSelectField("tblweekMenu INNER JOIN   tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN   tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID", "(SELECT isnull(sum(quantity),0) FROM  tblmenuorderdetails WHERE CONVERT(nvarchar(11), tblmenuorderdetails.menudate, 101) = CONVERT(nvarchar(11), tblweekMenu.menudate, 101) AND menuid = tblweekMenu.menuid) AS orderqty,*,convert(nvarchar(11),menudate,6) as orderdate", " tblweekmenu.officeid='" & Session("OfficeID") & "' and tblweekmenu.category='nonveg' and convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101) and tblweekmenu.status='Approved'  ")
        If varobjBindAnimated.objDReader.HasRows Then
            ImgsingleAnimImag2.ImageUrl = varobjBindAnimated.objDReader("productlocation") & "/" & varobjBindAnimated.objDReader("menuid") & ".jpg"

            lblRestaurantname2.Text = "Today " & varobjBindAnimated.objDReader("orderdate") & " At " & varobjBindAnimated.objDReader("officename") & " , " & varobjBindAnimated.objDReader("locationname") & " "
            lblRestaurantLoc2.Text = varobjBindAnimated.objDReader("restaurantname")
            lblprice2.Text = varobjBindAnimated.objDReader("price")
            lblMenuTax2.Text = varobjBindAnimated.objDReader("tax")
            lblcategory2.Text = varobjBindAnimated.objDReader("category")
            lblmenu2.Text = varobjBindAnimated.objDReader("menuname")
            lbldescription2.Text = varobjBindAnimated.objDReader("Description")
            lblmenuid2.Text = varobjBindAnimated.objDReader("menuid")
            lblcontains2.Text = varobjBindAnimated.objDReader("contain")

           

            Dim strOrderqtymsg As String = ""
            If varobjBindAnimated.objDReader("orderqty") <> 0 Then
                strOrderqtymsg = "Already you have ordered this dish  " & varobjBindAnimated.objDReader("orderqty") & " Nos.<br /> still you want to proceed "
            ElseIf varobjBindAnimated.objDReader("orderqty") = 0 Then
                strOrderqtymsg = ""
            End If
            lbltodayNvOrderedQty.text = strOrderqtymsg







            Image2.ImageUrl = varobjBindAnimated.objDReader("productlocation") & "/" & varobjBindAnimated.objDReader("menuid") & ".jpg"
            lblorderdatetnv.Text = varobjBindAnimated.objDReader("orderDate")
            lblRestaurantLocModal1.Text = varobjBindAnimated.objDReader("restaurantname")
            lblpriceModal1.Text = varobjBindAnimated.objDReader("price")
            lblMenuTaxModal1.Text = varobjBindAnimated.objDReader("tax")
            lblmenuModal1.Text = varobjBindAnimated.objDReader("menuname")
            lbldescriptionmodal1.Text = varobjBindAnimated.objDReader("Description")
            lblcontainsModal1.Text = varobjBindAnimated.objDReader("contain")






            If Session("TodayExpiryTime") = "closed" Then
                txttodayQtyNonveg.Enabled = False
                lnkcarttodaynonveg.Text = "Order closed"
                lnkcarttodaynonveg.Enabled = False
                lnkcarttodaynonveg.OnClientClick = False
                '  cbe1.Enabled = False
                mpe1.Enabled = False
            Else

                lnkcarttodaynonveg.Text = "Add to cart"
                lnkcarttodaynonveg.Enabled = False
            End If
        Else

            tab55.Visible = False
            litodaynonveg.Visible = False
        End If
        varobjBindAnimated.CloseConnection()

        If lblmenuid2.Text = "" Then lblmenuid2.Text = ""
        Dim varobjBindAnimatedReview As New DataService
        varobjBindAnimatedReview.FillDataSetQueryJoin("select top(3) * from tblcustomerUserReviews where menuid='" & lblmenuid2.Text & "' and checkerid is not null  order by autonum desc   ")
        If varobjBindAnimatedReview.objDS.Tables(0).Rows.Count <> 0 Then
            For j = 0 To varobjBindAnimatedReview.objDS.Tables(0).Rows.Count - 1
                If j = 0 Then
                    lbltodaynonvegReview1.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Review")
                    lbltodaynonveguser1.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Customername")
                ElseIf j = 1 Then
                    lbltodaynonvegReview2.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Review")
                    lbltodaynonveguser2.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Customername")
                Else
                    lbltodaynonvegReview3.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Review")
                    lbltodaynonveguser3.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Customername")
                End If
            Next
        Else

            lbltodaynonvegReview1.Text = "Looks like there are no reviews for this dish yet. If you order now you can change all that. "
            lbltodaynonveguser1.Text = ""

            lbltodaynonvegReview2.Text = "Looks like there are no reviews for this dish yet. If you order now you can change all that. "
            lbltodaynonveguser2.Text = ""

            lbltodaynonvegReview1.Text = "Looks like there are no reviews for this dish yet. If you order now you can change all that. "
            lbltodaynonveguser3.Text = ""


        End If
        varobjBindAnimatedReview.CloseConnection()
    End Sub
    Private Sub udpopulatetab9()
        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.GetSingleRowSelectField("tblweekMenu INNER JOIN   tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN   tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID", "(SELECT isnull(sum(quantity),0) FROM  tblmenuorderdetails WHERE CONVERT(nvarchar(11), tblmenuorderdetails.menudate, 101) = CONVERT(nvarchar(11), tblweekMenu.menudate, 101) AND menuid = tblweekMenu.menuid) AS orderqty,*,convert(nvarchar(11),menudate,6) as orderdate", " tblweekmenu.officeid='" & Session("OfficeID") & "' and tblweekmenu.category='lite' and convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101) and tblweekmenu.status='Approved'  ")
        If varobjBindAnimated.objDReader.HasRows Then
            ImgsingleAnimImag3.ImageUrl = varobjBindAnimated.objDReader("productlocation") & "/" & varobjBindAnimated.objDReader("menuid") & ".jpg"

            lblRestaurantname3.Text = "Today " & varobjBindAnimated.objDReader("orderdate") & " At " & varobjBindAnimated.objDReader("officename") & " , " & varobjBindAnimated.objDReader("locationname") & " "
            lblRestaurantLoc3.Text = varobjBindAnimated.objDReader("restaurantname")
            lblprice3.Text = varobjBindAnimated.objDReader("price")
            lblMenuTax3.Text = varobjBindAnimated.objDReader("tax")
            lblcategory3.Text = varobjBindAnimated.objDReader("category")
            lblmenu3.Text = varobjBindAnimated.objDReader("menuname")
            lblmenuid3.Text = varobjBindAnimated.objDReader("menuid")
            lbldescription3.Text = varobjBindAnimated.objDReader("Description")
            lblcontains3.Text = varobjBindAnimated.objDReader("contain")


            Dim strOrderqtymsg As String = ""
            If varobjBindAnimated.objDReader("orderqty") <> 0 Then
                strOrderqtymsg = "Already you have ordered this dish  " & varobjBindAnimated.objDReader("orderqty") & " Nos.<br /> still you want to proceed "
            ElseIf varobjBindAnimated.objDReader("orderqty") = 0 Then
                strOrderqtymsg = ""
            End If
            lbltodayLOrderedQty.text = strOrderqtymsg



            Image3.ImageUrl = varobjBindAnimated.objDReader("productlocation") & "/" & varobjBindAnimated.objDReader("menuid") & ".jpg"
            lblOrderdatetl.Text = varobjBindAnimated.objDReader("orderDate")
            lblRestaurantLocModal2.Text = varobjBindAnimated.objDReader("restaurantname")
            lblpriceModal2.Text = varobjBindAnimated.objDReader("price")
            lblMenuTaxModal2.Text = varobjBindAnimated.objDReader("tax")
            lblmenuModal2.Text = varobjBindAnimated.objDReader("menuname")
            lbldescriptionmodal2.Text = varobjBindAnimated.objDReader("Description")
            lblcontainsModal2.Text = varobjBindAnimated.objDReader("contain")


            If Session("TodayExpiryTime") = "closed" Then
                txttodayQtyLite.Enabled = False
                lnkcarttodayLite.Text = "Order closed"
                lnkcarttodayLite.Enabled = False
                lnkcarttodayLite.OnClientClick = False
                '  cbe2.Enabled = False
                mpe2.Enabled = False
            Else

                lnkcarttodayLite.Text = "Add to cart"
                lnkcarttodayLite.Enabled = False
            End If
        Else
            tab56.Visible = False
            litodayLite.Visible = False
            If litodayveg.Visible = False And litodaynonveg.Visible = False Then
                todayvegnoorders.Visible = True
                lbltodayvegnoorders.Visible = True
                lbltodayvegnoorders.Text = "orders not processed on sunday"
                SundayclosedOrder.Visible = False
            End If


        End If
        varobjBindAnimated.CloseConnection()

        If lblmenuid3.Text = "" Then lblmenuid3.Text = ""
        Dim varobjBindAnimatedReview As New DataService
        varobjBindAnimatedReview.FillDataSetQueryJoin("select top(3) * from tblcustomerUserReviews where menuid='" & lblmenuid3.Text & "' and checkerid is not null  order by autonum desc   ")
        If varobjBindAnimatedReview.objDS.Tables(0).Rows.Count <> 0 Then
            For j = 0 To varobjBindAnimatedReview.objDS.Tables(0).Rows.Count - 1
                If j = 0 Then
                    lbltodayLiteReview1.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Review")
                    lbltodayLiteuser1.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Customername")
                ElseIf j = 1 Then
                    lbltodayLiteReview2.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Review")
                    lbltodayLiteuser2.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Customername")
                Else
                    lbltodayLiteReview3.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Review")
                    lbltodayLiteuser3.Text = varobjBindAnimatedReview.objDS.Tables(0).Rows(j).Item("Customername")
                End If
            Next
        Else

            lbltodayLiteReview1.Text = "Looks like there are no reviews for this dish yet. If you order now you can change all that. "
            lbltodayLiteuser1.Text = ""

            lbltodayLiteReview2.Text = "Looks like there are no reviews for this dish yet. If you order now you can change all that. "
            lbltodayLiteuser2.Text = ""

            lbltodayLiteReview3.Text = "Looks like there are no reviews for this dish yet. If you order now you can change all that. "
            lbltodayLiteuser3.Text = ""


        End If
        varobjBindAnimatedReview.CloseConnection()

    End Sub
    Private Sub udpopulatetab1()

        liMonveg.Visible = False
        liMonNonveg.Visible = False
        liMonLite.Visible = False

        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select   (SELECT isnull(sum(quantity),0) FROM  tblmenuorderdetails WHERE CONVERT(nvarchar(11), tblmenuorderdetails.menudate, 101) = CONVERT(nvarchar(11), tblweekMenu.menudate, 101) AND menuid = tblweekMenu.menuid) AS orderqty, tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,convert(nvarchar(11),menudate,6) as orderdate,case when category='Veg' then 'tab1' else case when category='nonveg' then 'tab2' else 'tab3' end end as categoryy,case when category='Veg' then 'tab-grid1' else case when category='nonveg' then 'tab-grid2' else 'tab-grid3' end end as categoryyy,                                                                       CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThismondayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThismondaynv'                                                                         ELSE 'testimonialsThismondayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '" & Session("officeid") & "') AND (tblweekMenu.Weekday = 'Monday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnameMonday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30"
                '.lblRestaurantname = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30", _
                image.Add(New clsImg() With { _
                          .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "RS." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                .lblorderdate = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate"), _
                .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                  .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
            .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                .lblorderQty = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderqty"), _
                            .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                           .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
               .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
                .elblMenuID = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid"), _
                  .elblMenuDAte = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menudate"), _
                .lnkThisweekText = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuDate"), _
                  .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
                                                 .ImgsingleAnimImag = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg", _
            .ImgsingleAnimImag1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})
            Next
        End If







        varobjBindAnimated.CloseConnection()
        RepeaterImagestab1.DataSource = image
        RepeaterImagestab1.DataBind()

    End Sub


    Private Sub udpopulatetab2()

        liTueveg.Visible = False
        liTueNonveg.Visible = False
        liTueLite.Visible = False


        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select   (SELECT isnull(sum(quantity),0) FROM  tblmenuorderdetails WHERE CONVERT(nvarchar(11), tblmenuorderdetails.menudate, 101) = CONVERT(nvarchar(11), tblweekMenu.menudate, 101) AND menuid = tblweekMenu.menuid) AS orderqty,tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,convert(nvarchar(11),menudate,6) as orderdate,case when category='Veg' then 'tab4' else case when category='nonveg' then 'tab5' else 'tab6' end end as categoryy,case when category='Veg' then 'tab-grid4' else case when category='nonveg' then 'tab-grid5' else 'tab-grid6' end end as categoryyy,                                                                       CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThistuesdayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThistuesdaynv'                                                                         ELSE 'testimonialsThistuesdayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '" & Session("officeid") & "') AND (tblweekMenu.Weekday = 'tuesday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnameTuesday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30"
                '.lblRestaurantname = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30", _
                image.Add(New clsImg() With { _
                         .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "RS." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                 .lblorderdate = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate"), _
                .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                  .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
            .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                          .lblorderQty = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderqty"), _
                          .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                          .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
               .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
                  .elblMenuID = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid"), _
                 .elblMenuDAte = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menudate"), _
                 .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
  .lnkThisweekText = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuDate"), _
      .ImgsingleAnimImag = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg", _
            .ImgsingleAnimImag1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})


            Next
        End If







        varobjBindAnimated.CloseConnection()
        RepeaterImagestab2.DataSource = image
        RepeaterImagestab2.DataBind()

    End Sub
    Private Sub udpopulatetab3()

        liWedveg.Visible = False
        liWedNonveg.Visible = False
        liWedLite.Visible = False

        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select  (SELECT isnull(sum(quantity),0) FROM  tblmenuorderdetails WHERE CONVERT(nvarchar(11), tblmenuorderdetails.menudate, 101) = CONVERT(nvarchar(11), tblweekMenu.menudate, 101) AND menuid = tblweekMenu.menuid) AS orderqty, tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,convert(nvarchar(11),menudate,6) as orderdate,case when category='Veg' then 'tab7' else case when category='nonveg' then 'tab8' else 'tab9' end end as categoryy,case when category='Veg' then 'tab-grid7' else case when category='nonveg' then 'tab-grid8' else 'tab-grid9' end end as categoryyy,                                                                      CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThiswednesdayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThiswednesdaynv'                                                                         ELSE 'testimonialsThiswednesdayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '" & Session("officeid") & "') AND (tblweekMenu.Weekday = 'wednesday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnameWednesday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30"
                '.lblRestaurantname = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30", _
                image.Add(New clsImg() With { _
                      .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "RS." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
             .lblorderdate = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate"), _
                .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                  .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
            .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                       .lblorderQty = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderqty"), _
                       .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                       .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
               .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
                .elblMenuID = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid"), _
               .elblMenuDAte = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menudate"), _
  .lnkThisweekText = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuDate"), _
               .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
    .ImgsingleAnimImag = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg", _
            .ImgsingleAnimImag1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})


            Next
        End If







        varobjBindAnimated.CloseConnection()
        RepeaterImagestab3.DataSource = image
        RepeaterImagestab3.DataBind()

    End Sub

    Private Sub udpopulatetab4()

        lithuLite.Visible = False
        lithuNonveg.Visible = False
        lithuveg.Visible = False


        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select (SELECT isnull(sum(quantity),0) FROM  tblmenuorderdetails WHERE CONVERT(nvarchar(11), tblmenuorderdetails.menudate, 101) = CONVERT(nvarchar(11), tblweekMenu.menudate, 101) AND menuid = tblweekMenu.menuid) AS orderqty,tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,convert(nvarchar(11),menudate,6) as orderdate,case when category='Veg' then 'tab10' else case when category='nonveg' then 'tab11' else 'tab12' end end as categoryy,case when category='Veg' then 'tab-grid10' else case when category='nonveg' then 'tab-grid11' else 'tab-grid12' end end as categoryyy,                                                                      CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThisthursdayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThisthursdaynv'                                                                         ELSE 'testimonialsThisthursdayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '" & Session("officeid") & "') AND (tblweekMenu.Weekday = 'thursday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)
        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnamethursday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30"
                '.lblRestaurantname = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30", _
                image.Add(New clsImg() With { _
                   .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "RS." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
          .lblorderdate = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate"), _
                .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                  .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
            .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                    .lblorderQty = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderqty"), _
                    .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                    .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
               .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
             .elblMenuID = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid"), _
            .elblMenuDAte = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menudate"), _
  .lnkThisweekText = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuDate"), _
            .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
        .ImgsingleAnimImag = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg", _
            .ImgsingleAnimImag1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})


            Next
        End If







        varobjBindAnimated.CloseConnection()
        RepeaterImagestab4.DataSource = image
        RepeaterImagestab4.DataBind()

    End Sub




    Private Sub udpopulatetab5()


        liFriveg.Visible = False
        liFriNonveg.Visible = False
        liFriLite.Visible = False

        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select  (SELECT isnull(sum(quantity),0) FROM  tblmenuorderdetails WHERE CONVERT(nvarchar(11), tblmenuorderdetails.menudate, 101) = CONVERT(nvarchar(11), tblweekMenu.menudate, 101) AND menuid = tblweekMenu.menuid) AS orderqty,tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,convert(nvarchar(11),menudate,6) as orderdate,case when category='Veg' then 'tab13' else case when category='nonveg' then 'tab14' else 'tab15' end end as categoryy,case when category='Veg' then 'tab-grid13' else case when category='nonveg' then 'tab-grid14' else 'tab-grid15' end end as categoryyy,                                                                      CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThisfridayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThisfridaynv'                                                                         ELSE 'testimonialsThisfridayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '" & Session("officeid") & "') AND (tblweekMenu.Weekday = 'friday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnameFriday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30"
                '.lblRestaurantname = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30", _
                image.Add(New clsImg() With { _
                     .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "RS." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
          .lblorderdate = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate"), _
                .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                  .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
            .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
 .lblorderQty = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderqty"), _
                      .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                      .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
          .elblMenuID = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid"), _
            .elblMenuDAte = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menudate"), _
               .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
  .lnkThisweekText = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuDate"), _
            .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
    .ImgsingleAnimImag = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg", _
            .ImgsingleAnimImag1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})


            Next
        End If







        varobjBindAnimated.CloseConnection()
        RepeaterImagestab5.DataSource = image
        RepeaterImagestab5.DataBind()

    End Sub


    Private Sub udpopulatetab6()


        lisatLite.Visible = False
        lisatNonveg.Visible = False
        lisatveg.Visible = False

        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select (SELECT isnull(sum(quantity),0) FROM  tblmenuorderdetails WHERE CONVERT(nvarchar(11), tblmenuorderdetails.menudate, 101) = CONVERT(nvarchar(11), tblweekMenu.menudate, 101) AND menuid = tblweekMenu.menuid) AS orderqty, tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,convert(nvarchar(11),menudate,6) as orderdate,case when category='Veg' then 'tab16' else case when category='nonveg' then 'tab17' else 'tab18' end end as categoryy,case when category='Veg' then 'tab-grid16' else case when category='nonveg' then 'tab-grid17' else 'tab-grid18' end end as categoryyy,                                                                      CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThissaturdayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThissaturdaynv'                                                                         ELSE 'testimonialsThissaturdayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '" & Session("officeid") & "') AND (tblweekMenu.Weekday = 'saturday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnamesaturday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30"
                '.lblRestaurantname = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("weekday") & "  " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate") & " AT " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname") & "<br/> Ordering ends at 11:30", _
                image.Add(New clsImg() With { _
                 .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "RS." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
        .lblorderdate = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderdate"), _
                .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                  .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
            .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                  .lblorderQty = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("orderqty"), _
                  .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                  .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
               .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
        .elblMenuID = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid"), _
        .elblMenuDAte = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menudate"), _
          .lnkThisweekText = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuDate"), _
          .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
        .ImgsingleAnimImag = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg", _
            .ImgsingleAnimImag1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})


            Next
        End If







        varobjBindAnimated.CloseConnection()
        RepeaterImagestab6.DataSource = image
        RepeaterImagestab6.DataBind()

    End Sub

    Public Class clsImg

        Public Property lblorderQty() As String
            Get
                If m_lblorderqty <> Nothing Then
                    Dim strOrderqtymsg As String = ""
                    If m_lblorderqty <> 0 Then
                        strOrderqtymsg = "Already you have ordered this dish  " & m_lblorderqty & " Nos.<br /> still you want to proceed "
                    ElseIf m_lblorderqty = 0 Then
                        strOrderqtymsg = ""
                    End If
                    m_lblorderqty = strOrderqtymsg

                End If


                Return m_lblorderqty

            End Get
            Set(value As String)

                m_lblorderqty = value
            End Set
        End Property
        Private m_lblorderqty As String


        Public Property lnkThisweekText() As String
            Get
                If m_lnkThisweekText <> Nothing Then
                    Dim varMenudate As Date = Date.Parse(m_lnkThisweekText)
                    'If m_lnkThisweekText < Now.Date Then
                    If m_lnkThisweekText < Date.UtcNow.AddHours(5.5).Date Then
                        m_lnkThisweekText = "Order closed"
                    ElseIf m_lnkThisweekText = Date.UtcNow.AddHours(5.5).Date Then
                        Dim ChennaiUTCTimeThisWeek As DateTime = Date.UtcNow.AddHours(5.5)
                        If Double.Parse(ChennaiUTCTimeThisWeek.Hour * 60 + ChennaiUTCTimeThisWeek.Minute) > 690 Then
                            m_lnkThisweekText = "Order closed"
                        Else
                            m_lnkThisweekText = "Add to cart"
                        End If
                    Else
                        m_lnkThisweekText = "Add to cart"

                    End If
                End If


                Return m_lnkThisweekText

            End Get
            Set(value As String)

                m_lnkThisweekText = value
            End Set
        End Property
        Private m_lnkThisweekText As String

     
        Public Property lblRestaurantname() As String
            Get
                Return m_lblRestaurantname
            End Get
            Set(value As String)
                m_lblRestaurantname = value
            End Set
        End Property
        Private m_lblRestaurantname As String
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
        Public Property lblorderdate() As String
            Get
                Return m_lblorderdate
            End Get
            Set(value As String)
                m_lblorderdate = value
            End Set
        End Property
        Private m_lblorderdate As String
        Public Property lblcategory() As String
            Get
                Return m_lblcategory
            End Get
            Set(value As String)
                m_lblcategory = value
            End Set
        End Property
        Private m_lblcategory As String
        Public Property lblcategoryy() As String
            Get
                Return m_lblcategoryy
            End Get
            Set(value As String)
                m_lblcategoryy = value
            End Set
        End Property
        Private m_lblcategoryy As String
        Public Property lblcategoryyy() As String
            Get
                Return m_lblcategoryyy
            End Get
            Set(value As String)
                m_lblcategoryyy = value
            End Set
        End Property
        Private m_lblcategoryyy As String
        Public Property lblmenu() As String
            Get
                Return m_lblmenu
            End Get
            Set(value As String)
                m_lblmenu = value
            End Set
        End Property
        Private m_lblmenu As String
        Public Property lbldescription() As String
            Get
                Return m_lbldescription
            End Get
            Set(value As String)
                m_lbldescription = value
            End Set
        End Property
        Private m_lbldescription As String
        Public Property ImgsingleAnimImag() As String
            Get
                Return m_ImgsingleAnimImag
            End Get
            Set(value As String)
                m_ImgsingleAnimImag = value
            End Set
        End Property
        Private m_ImgsingleAnimImag As String
        Public Property ImgsingleAnimImag1() As String
            Get
                Return m_ImgsingleAnimImag1
            End Get
            Set(value As String)
                m_ImgsingleAnimImag1 = value
            End Set
        End Property
        Private m_ImgsingleAnimImag1 As String
        Public Property elblMenuDAte() As String
            Get
                Return m_elblMenuDAte
            End Get
            Set(value As String)
                m_elblMenuDAte = value
            End Set
        End Property
        Private m_elblMenuDAte As String
        Public Property elblMenuID() As String
            Get
                Return m_elblMenuID
            End Get
            Set(value As String)
                m_elblMenuID = value
            End Set
        End Property
        Private m_elblMenuID As String
        Public Property lblcontains() As String
            Get
                Return m_lblcontains
            End Get
            Set(value As String)
                m_lblcontains = value
            End Set
        End Property
        Private m_lblcontains As String
        Public Property lblTestimonial() As String
            Get
                Return m_lblTestimonial
            End Get
            Set(value As String)
                m_lblTestimonial = value
            End Set
        End Property
        Private m_lblTestimonial As String
        Public Property lbl1() As String
            Get
                Return m_lbl1
            End Get
            Set(value As String)
                Dim lbl As String() = value.ToString.Split("`")
                m_lbl1 = lbl(1).ToString
            End Set
        End Property
        Private m_lbl1 As String
        Public Property lbl2() As String
            Get
                Return m_lbl2
            End Get
            Set(value As String)
                Dim lbl As String() = value.ToString.Split("`")
                m_lbl2 = lbl(1).ToString
            End Set
        End Property
        Private m_lbl2 As String
        Public Property lbl3() As String
            Get
                Return m_lbl3
            End Get
            Set(value As String)
                Dim lbl As String() = value.ToString.Split("`")
                m_lbl3 = lbl(1).ToString
            End Set
        End Property
        Private m_lbl3 As String




        Public Property lbl4() As String
            Get
                Return m_lbl4
            End Get
            Set(value As String)
                Dim lbl As String() = value.ToString.Split("`")
                m_lbl4 = lbl(0).ToString
            End Set
        End Property
        Private m_lbl4 As String
        Public Property lbl5() As String
            Get
                Return m_lbl5
            End Get
            Set(value As String)
                Dim lbl As String() = value.ToString.Split("`")
                m_lbl5 = lbl(0).ToString
            End Set
        End Property
        Private m_lbl5 As String
        Public Property lbl6() As String
            Get
                Return m_lbl6
            End Get
            Set(value As String)
                Dim lbl As String() = value.ToString.Split("`")
                m_lbl6 = lbl(0).ToString
            End Set
        End Property
        Private m_lbl6 As String



    End Class


    ''' <summary>
    ''' '''''TODAY COD
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>



    Protected Sub lnkTodayVeg_click(sender As Object, e As EventArgs)
        If lblTimer.Text <> "Today order closed" Then

            Dim varGettotalqty As New DataService
            Dim vartotalqty As Integer = varGettotalqty.displaydata("select isnull(sum(quantity),0) as qty from tblmenuorderdetails where convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101)")
            varGettotalqty.CloseConnection()

            If vartotalqty + Integer.Parse(txttodayQtyveg.Text) <= 9 Then


                Dim qty As Double
                If Double.TryParse(txttodayQtyveg.Text, qty) Then
                    If qty < "10" Then
                        Dim ObjInsSaleOrderDetails As New SPDataService
                        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
                        ObjInsSaleOrderDetails.udfnCartSalesOrderEntry(Session("CustomerID"), Session("workingDate"), lblmenuid.Text, qty, Session("workingDate"), "Order Placed", varCustMakerID)
                        ObjInsSaleOrderDetails.CloseConnection()
                        Session("ProcessCartMakerID") = varCustMakerID

                        udfnpayment()

                        'mp1.Show()
                        'Dim deliverydate As DateTime = Session("workingDate")
                        'lblDeliveryDate.Text = "Please select Payment mode COD OR BANK PAYMENT? <br/>  Delivery date : " & deliverydate.ToString("dd/MM/yyyy") & " "
                    Else
                        mp2.Show()
                        lblunabletoProcess.Text = "Order Exceeds Maximum value ,Please contact Our sales Team."
                    End If
                Else
                    mp2.Show()
                    lblunabletoProcess.Text = "Invalid Qty."
                End If
            Else
                mp2.Show()
                lblunabletoProcess.Text = "Unable to exceed the maximum order quantity 9. "
            End If
        Else
            mp5.Show()
            lblorderclosed.Text = "Order time expired"

        End If



    End Sub
    Protected Sub lnkTodayNonVeg_click(sender As Object, e As EventArgs)
        If lblTimer.Text <> "Today order closed" Then


            Dim varGettotalqty As New DataService
            Dim vartotalqty As Integer = varGettotalqty.displaydata("select isnull(sum(quantity),0) as qty from tblmenuorderdetails where convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101)")
            varGettotalqty.CloseConnection()

            If vartotalqty + Integer.Parse(txttodayQtyNonveg.Text) <= 9 Then


                Dim qty As Double
                If Double.TryParse(txttodayQtyNonveg.Text, qty) Then
                    If qty < "10" Then
                        Dim ObjInsSaleOrderDetails As New SPDataService
                        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
                        ObjInsSaleOrderDetails.udfnCartSalesOrderEntry(Session("CustomerID"), Session("workingDate"), lblmenuid2.Text, qty, Session("workingDate"), "Order Placed", varCustMakerID)
                        ObjInsSaleOrderDetails.CloseConnection()
                        Session("ProcessCartMakerID") = varCustMakerID

                        udfnpayment()


                      
                     
                    Else
                        mp2.Show()
                        lblunabletoProcess.Text = "Order Exceeds Maximum value ,Please contact Our sales Team."
                    End If
                Else
                    mp2.Show()
                    lblunabletoProcess.Text = "Invalid Qty."
                End If
            Else
                mp2.Show()
                lblunabletoProcess.Text = "Unable to exceed the maximum order quantity 9. "
            End If
        Else
            mp5.Show()
            lblorderclosed.Text = "Order time expired"

        End If
    End Sub
    Protected Sub lnkTodayLite_click(sender As Object, e As EventArgs)
        If lblTimer.Text <> "Today order closed" Then

            Dim varGettotalqty As New DataService
            Dim vartotalqty As Integer = varGettotalqty.displaydata("select isnull(sum(quantity),0) as qty from tblmenuorderdetails where convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101)")
            varGettotalqty.CloseConnection()

            If vartotalqty + Integer.Parse(txttodayQtyLite.Text) <= 9 Then
                Dim qty As Double
                If Double.TryParse(txttodayQtyLite.Text, qty) Then
                    If qty < "10" Then
                        Dim ObjInsSaleOrderDetails As New SPDataService
                        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
                        ObjInsSaleOrderDetails.udfnCartSalesOrderEntry(Session("CustomerID"), Session("workingDate"), lblmenuid3.Text, qty, Session("workingDate"), "Order Placed", varCustMakerID)
                        ObjInsSaleOrderDetails.CloseConnection()
                        cart.Add(lblmenu.Text)
                        Session("ProcessCartMakerID") = varCustMakerID


                        udfnpayment()

                        'mp1.Show()
                        'Dim deliverydate As DateTime = Session("workingDate")
                        'lblDeliveryDate.Text = "Please select Payment mode COD OR BANK PAYMENT? <br/>  Delivery date : " & deliverydate.ToString("dd/MM/yyyy") & " "

                    Else
                        mp2.Show()
                        lblunabletoProcess.Text = "Order Exceeds Maximum value ,Please contact Our sales Team."
                    End If
                Else
                    mp2.Show()
                    lblunabletoProcess.Text = "Unable to exceed the maximum order quantity 9. "
                End If
            Else
                mp2.Show()
                lblunabletoProcess.Text = "Unable to exceed the maximum order quantity 9. "
            End If
        Else
            mp5.Show()
            lblorderclosed.Text = "Order time expired"

        End If
    End Sub


    ''' <summary>
    ''' '''''TODAY ONLINE PAY
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Protected Sub onlinelnkTodayVeg_click(sender As Object, e As EventArgs)
        If lblTimer.Text <> "Today order closed" Then

            Dim varGettotalqty As New DataService
            Dim vartotalqty As Integer = varGettotalqty.displaydata("select isnull(sum(quantity),0) as qty from tblmenuorderdetails where convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101)")
            varGettotalqty.CloseConnection()

            If vartotalqty + Integer.Parse(txttodayQtyveg.Text) <= 9 Then


                Dim qty As Double
                If Double.TryParse(txttodayQtyveg.Text, qty) Then
                    If qty < "10" Then

                        Session("thisweekmenuid") = lblmenuid.Text
                        Session("thisweekqty") = qty
                        Dim menudate As DateTime = Session("workingDate")
                        Session("thisweekmenudate") = menudate
                        '    Response.Redirect("OrderConfirmationBankPay.aspx", True)



                    



                        BankPaymentPageLoad()
                        Dim amount As Double = (Double.Parse(lblprice.Text) + Double.Parse(lblMenuTax.Text)) * qty
                        Dim txnid As String = BankPaymentButtonClick(amount, Session("CustFirstName"), Session("custmailid"), Session("custPhone"), lblmenu.Text, "https://Blueberrit.com/ResponseHandling.aspx", "https://Blueberrit.com/ResponseHandling.aspx", "", "", "", "", "", "", "", "", Session("customerid"), "", "", "", "", "", "", "", "", "", "")
                        '    Dim txnid As String = BankPaymentButtonClick(amount, Session("CustFirstName"), Session("custmailid"), Session("custPhone"), lblmenu.Text, "http://localhost:1422/ResponseHandling.aspx", "http://localhost:1422/ResponseHandling.aspx", "", "", "", "", "", "", "", "", Session("customerid"), "", "", "", "", "", "", "", "", "", "")
                        Dim ObjInsSaleOrderDetails As New SPDataService
                        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
                        ObjInsSaleOrderDetails.udfnCartSalesOrderBankEntry(Session("CustomerID"), Session("workingDate"), lblmenuid.Text, qty, Session("workingDate"), "Order Placed", varCustMakerID, txnid)
                        ObjInsSaleOrderDetails.CloseConnection()


                    Else
                        mp2.Show()
                        lblunabletoProcess.Text = "Order Exceeds Maximum value ,Please contact Our sales Team."
                    End If
                Else
                    mp2.Show()
                    lblunabletoProcess.Text = "Invalid Qty."
                End If
            Else
                mp2.Show()
                lblunabletoProcess.Text = "Unable to exceed the maximum order quantity 9. "
            End If
        Else
            mp5.Show()
            lblorderclosed.Text = "Order time expired"

        End If



    End Sub
    Protected Sub onlinelnkTodayNonVeg_click(sender As Object, e As EventArgs)
        If lblTimer.Text <> "Today order closed" Then


            Dim varGettotalqty As New DataService
            Dim vartotalqty As Integer = varGettotalqty.displaydata("select isnull(sum(quantity),0) as qty from tblmenuorderdetails where convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101)")
            varGettotalqty.CloseConnection()

            If vartotalqty + Integer.Parse(txttodayQtyNonveg.Text) <= 9 Then


                Dim qty As Double
                If Double.TryParse(txttodayQtyNonveg.Text, qty) Then
                    If qty < "10" Then

                        Session("thisweekmenuid") = lblmenuid2.Text
                        Session("thisweekqty") = qty
                        Dim menudate As DateTime = Session("workingDate")
                        Session("thisweekmenudate") = menudate
                        '   Response.Redirect("OrderConfirmationBankPay.aspx", True)
                     
                        BankPaymentPageLoad()
                        Dim amount As Double = (Double.Parse(lblprice2.Text) + Double.Parse(lblMenuTax2.Text)) * qty
                        Dim txnid As String = BankPaymentButtonClick(amount, Session("CustFirstName"), Session("custmailid"), Session("custPhone"), lblmenu2.Text, "https://Blueberrit.com/ResponseHandling.aspx", "https://Blueberrit.com/ResponseHandling.aspx", "", "", "", "", "", "", "", "", Session("customerid"), "", "", "", "", "", "", "", "", "", "")
                        '        Dim txnid As String = BankPaymentButtonClick(amount, Session("CustFirstName"), Session("custmailid"), Session("custPhone"), lblmenu2.Text, "http://localhost:1422/ResponseHandling.aspx", "http://localhost:1422/ResponseHandling.aspx", "", "", "", "", "", "", "", "", Session("customerid"), "", "", "", "", "", "", "", "", "", "")
                        Dim ObjInsSaleOrderDetails As New SPDataService
                        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
                        ObjInsSaleOrderDetails.udfnCartSalesOrderBankEntry(Session("CustomerID"), Session("workingDate"), lblmenuid2.Text, qty, Session("workingDate"), "Order Placed", varCustMakerID, txnid)
                        ObjInsSaleOrderDetails.CloseConnection()

                    Else
                        mp2.Show()
                        lblunabletoProcess.Text = "Order Exceeds Maximum value ,Please contact Our sales Team."
                    End If
                Else
                    mp2.Show()
                    lblunabletoProcess.Text = "Invalid Qty."
                End If
            Else
                mp2.Show()
                lblunabletoProcess.Text = "Unable to exceed the maximum order quantity 9. "
            End If
        Else
            mp5.Show()
            lblorderclosed.Text = "Order time expired"

        End If
    End Sub
    Protected Sub onlinelnkTodayLite_click(sender As Object, e As EventArgs)
        If lblTimer.Text <> "Today order closed" Then

            Dim varGettotalqty As New DataService
            Dim vartotalqty As Integer = varGettotalqty.displaydata("select isnull(sum(quantity),0) as qty from tblmenuorderdetails where convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101)")
            varGettotalqty.CloseConnection()

            If vartotalqty + Integer.Parse(txttodayQtyLite.Text) <= 9 Then
                Dim qty As Double
                If Double.TryParse(txttodayQtyLite.Text, qty) Then
                    If qty < "10" Then


                        Session("thisweekmenuid") = lblmenuid3.Text
                        Session("thisweekqty") = qty
                        Dim menudate As DateTime = Session("workingDate")
                        Session("thisweekmenudate") = menudate

                        '    Response.Redirect("OrderConfirmationBankPay.aspx", True)
                      

                        BankPaymentPageLoad()
                        Dim amount As Double = (Double.Parse(lblprice3.Text) + Double.Parse(lblMenuTax3.Text)) * qty
                        Dim txnid As String = BankPaymentButtonClick(amount, Session("CustFirstName"), Session("custmailid"), Session("custPhone"), lblmenu3.Text, "https://Blueberrit.com/ResponseHandling.aspx", "https://Blueberrit.com/ResponseHandling.aspx", "", "", "", "", "", "", "", "", Session("customerid"), "", "", "", "", "", "", "", "", "", "")
                        '  Dim txnid As String = BankPaymentButtonClick(amount, Session("CustFirstName"), Session("custmailid"), Session("custPhone"), lblmenu3.Text, "http://localhost:1422/ResponseHandling.aspx", "http://localhost:1422/ResponseHandling.aspx", "", "", "", "", "", "", "", "", Session("customerid"), "", "", "", "", "", "", "", "", "", "")
                        Dim ObjInsSaleOrderDetails As New SPDataService
                        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
                        ObjInsSaleOrderDetails.udfnCartSalesOrderBankEntry(Session("CustomerID"), Session("workingDate"), lblmenuid3.Text, qty, Session("workingDate"), "Order Placed", varCustMakerID, txnid)
                        ObjInsSaleOrderDetails.CloseConnection()


                    Else
                        mp2.Show()
                        lblunabletoProcess.Text = "Order Exceeds Maximum value ,Please contact Our sales Team."
                    End If
                Else
                    mp2.Show()
                    lblunabletoProcess.Text = "Unable to exceed the maximum order quantity 9. "
                End If
            Else
                mp2.Show()
                lblunabletoProcess.Text = "Unable to exceed the maximum order quantity 9. "
            End If
        Else
            mp5.Show()
            lblorderclosed.Text = "Order time expired"

        End If
    End Sub





    Private cart As New ArrayList()
    Protected Sub rptList_ItemCommand(sender As Object, e As RepeaterCommandEventArgs)



        If e.CommandName = "AddToCart" Then
            Dim thisweekmenuid As String = e.CommandArgument.ToString()
            Dim confirmValue As String = Request.Form("confirm_value")

            Dim menudatee As DateTime = CType(e.Item.FindControl("elblMenuDAte"), Label).Text

            Dim varGettotalqty As New DataService
            Dim vartotalqty As Double = varGettotalqty.displaydata("select isnull(sum(quantity),0) as qty from tblmenuorderdetails where convert(datetime,menudate)=convert(datetime,'" & menudatee & "')")
            varGettotalqty.CloseConnection()
            Dim thisqty As Double = Double.Parse(CType(e.Item.FindControl("txtthisweekQty"), TextBox).Text)
            If vartotalqty + thisqty <= 9 Then

                Dim qty As Double ' = Double.Parse(CType(e.Item.FindControl("txtthisweekQty"), TextBox).Text)
                If Double.TryParse(CType(e.Item.FindControl("txtthisweekQty"), TextBox).Text, qty) Then

                    If qty < "10" Then
                        Dim menudate As DateTime = CType(e.Item.FindControl("elblMenuDAte"), Label).Text
                        Dim ObjInsSaleOrderDetails As New SPDataService
                        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
                        ObjInsSaleOrderDetails.udfnCartSalesOrderEntry(Session("CustomerID"), menudate, thisweekmenuid, qty, Session("workingDate"), "Order Placed", varCustMakerID)
                        ObjInsSaleOrderDetails.CloseConnection()
                        cart.Add(thisweekmenuid)
                        Session("ProcessCartMakerID") = varCustMakerID

                        udfnpayment()

                        'mp1.Show()
                        'lblDeliveryDate.Text = "Please select Payment mode COD OR BANK PAYMENT? <br/>  Delivery date : " & menudate.ToString("dd/MM/yyyy") & " "


                    Else
                        mp2.Show()
                        lblunabletoProcess.Text = "Order Exceeds Maximum value ,Please contact Our sales Team."
                    End If
                Else
                    mp2.Show()
                    lblunabletoProcess.Text = "Invalid Qty."
                End If
            Else
                mp2.Show()
                lblunabletoProcess.Text = "Unable to exceed the maximum order quantity 9. "
            End If


        ElseIf e.CommandName = "AddToCartBank" Then






            Dim thisweekmenuid As String = e.CommandArgument.ToString()
            Dim confirmValue As String = Request.Form("confirm_value")

            Dim menudatee As DateTime = CType(e.Item.FindControl("elblMenuDAte"), Label).Text

            Dim varGettotalqty As New DataService
            Dim vartotalqty As Double = varGettotalqty.displaydata("select isnull(sum(quantity),0) as qty from tblmenuorderdetails where convert(datetime,menudate)=convert(datetime,'" & menudatee & "')")
            varGettotalqty.CloseConnection()
            Dim thisqty As Double = Double.Parse(CType(e.Item.FindControl("txtthisweekQty"), TextBox).Text)
            If vartotalqty + thisqty <= 9 Then

                Dim qty As Double ' = Double.Parse(CType(e.Item.FindControl("txtthisweekQty"), TextBox).Text)
                If Double.TryParse(CType(e.Item.FindControl("txtthisweekQty"), TextBox).Text, qty) Then

                    If qty < "10" Then


                        Session("thisweekmenuid") = thisweekmenuid
                        Session("thisweekqty") = qty
                        Dim menudate As DateTime = CType(e.Item.FindControl("elblMenuDAte"), Label).Text
                        Session("thisweekmenudate") = menudate
                        '   Response.Redirect("OrderConfirmationBankPay.aspx", True)

                        Dim lblWeekmenu As String
                        lblWeekmenu = CType(e.Item.FindControl("lblmenu"), Label).Text
                        Dim lblweekprice As String()
                        lblweekprice = CType(e.Item.FindControl("lblprice"), Label).Text.Split(".")
                        Dim lblweekMenuTax As String
                        lblweekMenuTax = CType(e.Item.FindControl("lblmenutax"), Label).Text

                        BankPaymentPageLoad()
                        Dim amount As Double = (Double.Parse(lblweekprice(1).ToString) + Double.Parse(lblweekMenuTax)) * qty
                        Dim txnid As String = BankPaymentButtonClick(amount, Session("CustFirstName"), Session("custmailid"), Session("custPhone"), lblWeekmenu, "https://Blueberrit.com/ResponseHandling.aspx", "https://Blueberrit.com/ResponseHandling.aspx", "", "", "", "", "", "", "", "", Session("customerid"), "", "", "", "", "", "", "", "", "", "")
                        '   Dim txnid As String = BankPaymentButtonClick(amount, Session("CustFirstName"), Session("custmailid"), Session("custPhone"), lblWeekmenu, "http://localhost:1422/ResponseHandling.aspx", "http://localhost:1422/ResponseHandling.aspx", "", "", "", "", "", "", "", "", Session("customerid"), "", "", "", "", "", "", "", "", "", "")


                        '   Dim menudate As DateTime = CType(e.Item.FindControl("elblMenuDAte"), Label).Text
                        Dim ObjInsSaleOrderDetails As New SPDataService
                        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
                        ObjInsSaleOrderDetails.udfnCartSalesOrderBankEntry(Session("CustomerID"), menudate, thisweekmenuid, qty, Session("workingDate"), "Order Placed", varCustMakerID, txnid)
                        ObjInsSaleOrderDetails.CloseConnection()
                        'cart.Add(thisweekmenuid)
                        'Session("ProcessCartMakerID") = varCustMakerID

                        'udfnpayment()




                    Else
                        mp2.Show()
                        lblunabletoProcess.Text = "Order Exceeds Maximum value ,Please contact Our sales Team."
                    End If
                Else
                    mp2.Show()
                    lblunabletoProcess.Text = "Invalid Qty."
                End If
            Else
                mp2.Show()
                lblunabletoProcess.Text = "Unable to exceed the maximum order quantity 9. "
            End If


























        End If

    End Sub


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        ' Response.Redirect("cart.aspx", True)

        Dim ObjInsSaleOrderDetails As New SPDataService
        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
        ObjInsSaleOrderDetails.CloseConnection()

        Session("OrderConfirmationPaymentID") = varCustMakerID






        Dim ObjInsSaleOrderpaymentDetails As New SPDataService
        ObjInsSaleOrderpaymentDetails.udfnExecuteQuery("update   tblMenuOrderDetails set paymenttype='COD',PaymentStatus='PAID',paymentid='" & varCustMakerID & "',diocode='" & Session("officeDiocode") & "'  where  custmakerid='" & Session("ProcessCartMakerID") & "' and paymentstatus IS NULL ")
        ObjInsSaleOrderpaymentDetails.CloseConnection()

        sendconfirmationmail(varCustMakerID)
        Response.Redirect("OrderConfirmation.aspx", True)




    End Sub
    Private Sub udfnpayment()
        Dim ObjInsSaleOrderDetails As New SPDataService
        Dim varCustMakerID As Integer = ObjInsSaleOrderDetails.udfnCustActivityLog(Session("customerid"), Session("StrUserIPAddress"), Session("workingDate"), "default.aspx")
        ObjInsSaleOrderDetails.CloseConnection()

        Session("OrderConfirmationPaymentID") = varCustMakerID






        Dim ObjInsSaleOrderpaymentDetails As New SPDataService
        ObjInsSaleOrderpaymentDetails.udfnExecuteQuery("update   tblMenuOrderDetails set paymenttype='COD',PaymentStatus='PAID',paymentid='" & varCustMakerID & "',diocode='" & Session("officeDiocode") & "'  where  custmakerid='" & Session("ProcessCartMakerID") & "' and paymentstatus IS NULL ")
        ObjInsSaleOrderpaymentDetails.CloseConnection()

        sendconfirmationmail(varCustMakerID)
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




    Protected Sub RepeaterImagestab1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab1.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim orderstatus As String = CType(e.Item.FindControl("linkCartthisweekmonday"), LinkButton).Text

            Dim category As String = CType(e.Item.FindControl("lblcategory"), Label).Text
            Dim Div As String = CType(e.Item.FindControl("lblcategory"), Label).Text


            If category = "Veg" Then
                liMonveg.Visible = True

            End If

            If category = "Nonveg" Then
                liMonNonveg.Visible = True

            End If


            If category = "Lite" Then
                liMonLite.Visible = True

            End If

            If orderstatus = "Order closed" Then
                CType(e.Item.FindControl("linkCartthisweekmonday"), LinkButton).Enabled = False
                CType(e.Item.FindControl("linkCartthisweekmonday"), LinkButton).OnClientClick = False
                '   CType(e.Item.FindControl("cbe"), ConfirmButtonExtender).Enabled = False
                CType(e.Item.FindControl("mpe"), ModalPopupExtender).Enabled = False
                CType(e.Item.FindControl("txtthisweekQty"), TextBox).Enabled = False

            Else
                CType(e.Item.FindControl("linkCartthisweekmonday"), LinkButton).Enabled = False
            End If
        End If
    End Sub
    Protected Sub RepeaterImagestab2_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab2.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim orderstatus As String = CType(e.Item.FindControl("linkCartthisweekTuesday"), LinkButton).Text

            Dim category As String = CType(e.Item.FindControl("lblcategory"), Label).Text
            Dim Div As String = CType(e.Item.FindControl("lblcategory"), Label).Text


            If category = "Veg" Then
                liTueveg.Visible = True

            End If

            If category = "Nonveg" Then
                liTueNonveg.Visible = True

            End If


            If category = "Lite" Then
                liTueLite.Visible = True

            End If

            If orderstatus = "Order closed" Then
                CType(e.Item.FindControl("linkCartthisweekTuesday"), LinkButton).Enabled = False
                CType(e.Item.FindControl("linkCartthisweekTuesday"), LinkButton).OnClientClick = False
                '   CType(e.Item.FindControl("cbe"), ConfirmButtonExtender).Enabled = False
                CType(e.Item.FindControl("mpe"), ModalPopupExtender).Enabled = False
                CType(e.Item.FindControl("txtthisweekQty"), TextBox).Enabled = False
            Else
                CType(e.Item.FindControl("linkCartthisweekTuesday"), LinkButton).Enabled = False
            End If
        End If
    End Sub
    Protected Sub RepeaterImagestab3_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab3.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim orderstatus As String = CType(e.Item.FindControl("linkCartthisweekWednesday"), LinkButton).Text

            Dim category As String = CType(e.Item.FindControl("lblcategory"), Label).Text
            Dim Div As String = CType(e.Item.FindControl("lblcategory"), Label).Text


            If category = "Veg" Then
                liWedveg.Visible = True

            End If

            If category = "Nonveg" Then
                liWedNonveg.Visible = True

            End If


            If category = "Lite" Then
                liWedLite.Visible = True

            End If


            If orderstatus = "Order closed" Then
                CType(e.Item.FindControl("linkCartthisweekWednesday"), LinkButton).Enabled = False
                CType(e.Item.FindControl("linkCartthisweekWednesday"), LinkButton).OnClientClick = False
                '    CType(e.Item.FindControl("cbe"), ConfirmButtonExtender).Enabled = False
                CType(e.Item.FindControl("mpe"), ModalPopupExtender).Enabled = False
                CType(e.Item.FindControl("txtthisweekQty"), TextBox).Enabled = False
            Else
                CType(e.Item.FindControl("linkCartthisweekWednesday"), LinkButton).Enabled = False
            End If
        End If
    End Sub
    Protected Sub RepeaterImagestab4_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab4.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim orderstatus As String = CType(e.Item.FindControl("linkCartthisweekThursday"), LinkButton).Text

            Dim category As String = CType(e.Item.FindControl("lblcategory"), Label).Text
            Dim Div As String = CType(e.Item.FindControl("lblcategory"), Label).Text


            If category = "Veg" Then
                lithuveg.Visible = True

            End If

            If category = "Nonveg" Then
                lithuNonveg.Visible = True

            End If


            If category = "Lite" Then
                lithuLite.Visible = True

            End If

            If orderstatus = "Order closed" Then
                CType(e.Item.FindControl("linkCartthisweekThursday"), LinkButton).Enabled = False
                CType(e.Item.FindControl("linkCartthisweekThursday"), LinkButton).OnClientClick = False
                ' CType(e.Item.FindControl("cbe"), ConfirmButtonExtender).Enabled = False
                CType(e.Item.FindControl("mpe"), ModalPopupExtender).Enabled = False
                CType(e.Item.FindControl("txtthisweekQty"), TextBox).Enabled = False
            Else
                CType(e.Item.FindControl("linkCartthisweekThursday"), LinkButton).Enabled = False
            End If
        End If
    End Sub
    Protected Sub RepeaterImagestab5_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab5.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim orderstatus As String = CType(e.Item.FindControl("linkCartthisweekFriday"), LinkButton).Text

            Dim category As String = CType(e.Item.FindControl("lblcategory"), Label).Text
            Dim Div As String = CType(e.Item.FindControl("lblcategory"), Label).Text


            If category = "Veg" Then
                liFriveg.Visible = True

            End If

            If category = "Nonveg" Then
                liFriNonveg.Visible = True

            End If


            If category = "Lite" Then
                liFriLite.Visible = True

            End If


            If orderstatus = "Order closed" Then
                CType(e.Item.FindControl("linkCartthisweekFriday"), LinkButton).Enabled = False
                CType(e.Item.FindControl("linkCartthisweekFriday"), LinkButton).OnClientClick = False
                '     CType(e.Item.FindControl("cbe"), ConfirmButtonExtender).Enabled = False
                CType(e.Item.FindControl("mpe"), ModalPopupExtender).Enabled = False
                CType(e.Item.FindControl("txtthisweekQty"), TextBox).Enabled = False
            Else
                CType(e.Item.FindControl("linkCartthisweekFriday"), LinkButton).Enabled = False
            End If
        End If
    End Sub
    Protected Sub RepeaterImagestab6_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab6.ItemDataBound
        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim orderstatus As String = CType(e.Item.FindControl("linkCartthisweeksaturday"), LinkButton).Text

            Dim category As String = CType(e.Item.FindControl("lblcategory"), Label).Text
            Dim Div As String = CType(e.Item.FindControl("lblcategory"), Label).Text


            If category = "Veg" Then
                lisatveg.Visible = True

            End If

            If category = "Nonveg" Then
                lisatNonveg.Visible = True

            End If


            If category = "Lite" Then
                lisatLite.Visible = True

            End If

            If orderstatus = "Order closed" Then
                CType(e.Item.FindControl("linkCartthisweeksaturday"), LinkButton).Enabled = False
                CType(e.Item.FindControl("linkCartthisweeksaturday"), LinkButton).OnClientClick = False
                '       CType(e.Item.FindControl("cbe"), ConfirmButtonExtender).Enabled = False
                CType(e.Item.FindControl("mpe"), ModalPopupExtender).Enabled = False
                CType(e.Item.FindControl("txtthisweekQty"), TextBox).Enabled = False
            Else
                CType(e.Item.FindControl("linkCartthisweeksaturday"), LinkButton).Enabled = False
            End If
        End If
    End Sub
    Private Sub btnenquiry_Click(sender As Object, e As EventArgs) Handles btnenquiry.Click
        Mailcustomer()
        MailFORWARDING(txtsubjectenquiry.Text, txtmessageenquiry.Text)
        txtmessageenquiry.Text = ""
        txtsubjectenquiry.Text = ""

        'Dim message As String = "Thank You for Your Enquiry"
        'ClientScript.RegisterStartupScript([GetType](), "alert", (Convert.ToString("alert('") & message) + "');", True)
    End Sub
    Private Sub Mailcustomer()

        Dim reader As New StreamReader(Server.MapPath("~/mailing/m_enquirycustomer.html"))
        Dim readFile As String = reader.ReadToEnd()
        Dim myString As String = ""
        myString = readFile
        myString = myString.Replace("$$name$$", Session("CustomerNAme"))
        myString = myString.Replace("$$Email$$", Session("custmailid"))
        ' myString = myString.Replace("$$message$$", txtmessageenquiry.Text)
        Dim Msg As New System.Net.Mail.MailMessage
        Msg.From = New System.Net.Mail.MailAddress("sales@blueberrit.com")
        Msg.[To].Add(New MailAddress(Session("custmailid")))
        Msg.Subject = "Thanks for your enquiry - Blueberrit"
        Msg.Body = myString.ToString()
        Msg.IsBodyHtml = True

        Dim SMTP As New System.Net.Mail.SmtpClient
        SMTP.EnableSsl = True
        SMTP.Send(Msg)
        reader.Dispose()
        SMTP.Dispose()
    End Sub
    Private Sub MailFORWARDING(ByVal subject As String, ByVal message As String)
        Dim reader As New StreamReader(Server.MapPath("~/mailing/m_enquiryadmin.html"))
        Dim readFile As String = reader.ReadToEnd()
        Dim myString As String = ""
        myString = readFile
        myString = myString.Replace("$$name$$", Session("CustomerNAme"))
        myString = myString.Replace("$$Email$$", Session("custmailid"))
        myString = myString.Replace("$$Subject$$", subject)
        myString = myString.Replace("$$message$$", message)
        myString = myString.Replace("$$ip$$", Session("custCity"))
        Dim Msg As New System.Net.Mail.MailMessage

        Msg.From = New System.Net.Mail.MailAddress("sales@blueberrit.com")

        ' Recipient e-mail address.
        Msg.[To].Add(New MailAddress("sales@blueberrit.com"))
        ' Subject of e-mail
        Msg.Subject = "Thanks for your enquiry - Blueberrit"
        Msg.Body = myString.ToString()
        Msg.IsBodyHtml = True

        Dim SMTP As New System.Net.Mail.SmtpClient
        SMTP.EnableSsl = True
        SMTP.Send(Msg)
        reader.Dispose()
        SMTP.Dispose()
    End Sub
    Private Sub BtnUnableNo_Click(sender As Object, e As EventArgs) Handles BtnUnableNo.Click
        Mailcustomer()
        MailFORWARDING(txtMaxOderSub.Text, txtMaxOrderEnquiry.Text)
        txtMaxOderSub.Text = ""
        txtMaxOrderEnquiry.Text = ""
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