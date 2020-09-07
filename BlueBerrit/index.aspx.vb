Imports System.Net.Mail
Imports System.IO
Imports System.Configuration
Imports System.Data
Imports BlueBerrit.ServiceClasses
Imports System.Net

Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            '    If Session("CustomerID") <> "" Or Session("CustomerID") <> Nothing Then Response.Redirect("default.aspx", True)

            Session.Contents.Clear()

            If Session("officecode") = Nothing Then Session("weeklymenuOfficeid") = "01010100010001" Else Session("weeklymenuOfficeid") = Session("officeid")


            udpopulatefieldload()

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


            '''''''Restaurant Listing
            udpopulatetab10()


            '''''''SIGNUP CITY AND OFFICE BIND
            UDPOPULATEFIELDS()
        End If
        If IsPostBack Then

        End If



    End Sub
    Private Sub udpopulatetab7()
        Dim menuid As String
        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.GetSingleRow("tblweekMenu INNER JOIN   tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN   tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID", " tblweekmenu.officeid='" & Session("weeklymenuOfficeid") & "' and tblweekmenu.category='veg' and convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101) and tblweekmenu.status='Approved'  ")

        If varobjBindAnimated.objDReader.HasRows Then
            ImgsingleAnimImag.ImageUrl = varobjBindAnimated.objDReader("productlocation") & "/" & varobjBindAnimated.objDReader("menuid") & ".jpg"

            lblRestaurantname.Text = "Today at " & varobjBindAnimated.objDReader("officename") & " (sample location in ) " & varobjBindAnimated.objDReader("locationname")
            lblRestaurantLoc.Text = varobjBindAnimated.objDReader("restaurantname")
            lblprice.Text = varobjBindAnimated.objDReader("price")
            lblMenuTax.Text = varobjBindAnimated.objDReader("tax")
            lblcategory.Text = varobjBindAnimated.objDReader("category")
            lblmenu.Text = varobjBindAnimated.objDReader("menuname")
            lbldescription.Text = varobjBindAnimated.objDReader("Description")
            lblcontains.Text = varobjBindAnimated.objDReader("contain")
            menuid = varobjBindAnimated.objDReader("menuid").ToString
        Else
            tab54.Visible = False
            litodayveg.Visible = False
            tab55.Visible = True
        End If
        varobjBindAnimated.CloseConnection()

        If menuid = Nothing Then menuid = ""
        Dim varobjBindAnimatedReview As New DataService
        varobjBindAnimatedReview.FillDataSetQueryJoin("select top(3) * from tblcustomerUserReviews where menuid='" & menuid.ToString & "' and checkerid is not null  order by autonum desc   ")
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
        Dim menuid As String
        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.GetSingleRow("tblweekMenu INNER JOIN   tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN   tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID", " tblweekmenu.officeid='" & Session("weeklymenuOfficeid") & "' and tblweekmenu.category='nonveg' and convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101) and tblweekmenu.status='Approved'  ")
        If varobjBindAnimated.objDReader.HasRows Then
            ImgsingleAnimImag2.ImageUrl = varobjBindAnimated.objDReader("productlocation") & "/" & varobjBindAnimated.objDReader("menuid") & ".jpg"

            lblRestaurantname2.Text = "Today at " & varobjBindAnimated.objDReader("officename") & " (sample location in ) " & varobjBindAnimated.objDReader("locationname")
            lblRestaurantLoc2.Text = varobjBindAnimated.objDReader("restaurantname")
            lblprice2.Text = varobjBindAnimated.objDReader("price")
            lblMenuTax2.Text = varobjBindAnimated.objDReader("tax")
            lblcategory2.Text = varobjBindAnimated.objDReader("category")
            lblmenu2.Text = varobjBindAnimated.objDReader("menuname")
            lbldescription2.Text = varobjBindAnimated.objDReader("Description")
            lblcontains2.Text = varobjBindAnimated.objDReader("contain")
            menuid = varobjBindAnimated.objDReader("menuid").ToString
        Else
            tab55.Visible = False
            litodaynonveg.Visible = False

        End If
        varobjBindAnimated.CloseConnection()

        If menuid = Nothing Then menuid = ""
        Dim varobjBindAnimatedReview As New DataService
        varobjBindAnimatedReview.FillDataSetQueryJoin("select top(3) * from tblcustomerUserReviews where menuid='" & menuid.ToString & "' and checkerid is not null  order by autonum desc   ")
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
        Dim menuid As String
        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.GetSingleRow("tblweekMenu INNER JOIN   tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN   tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID", " tblweekmenu.officeid='" & Session("weeklymenuOfficeid") & "' and tblweekmenu.category='lite' and convert(nvarchar(11),menudate,101)=convert(nvarchar(11),'" & Date.UtcNow.AddHours(5.5).ToString("MM/dd/yyyy") & "',101) and tblweekmenu.status='Approved'  ")
        If varobjBindAnimated.objDReader.HasRows Then
            ImgsingleAnimImag3.ImageUrl = varobjBindAnimated.objDReader("productlocation") & "/" & varobjBindAnimated.objDReader("menuid") & ".jpg"

            lblRestaurantname3.Text = "Today at " & varobjBindAnimated.objDReader("officename") & " (sample location in ) " & varobjBindAnimated.objDReader("locationname")
            lblRestaurantLoc3.Text = varobjBindAnimated.objDReader("restaurantname")
            lblprice3.Text = varobjBindAnimated.objDReader("price")
            lblMenuTax3.Text = varobjBindAnimated.objDReader("tax")
            lblcategory3.Text = varobjBindAnimated.objDReader("category")
            lblmenu3.Text = varobjBindAnimated.objDReader("menuname")
            lbldescription3.Text = varobjBindAnimated.objDReader("Description")
            lblcontains3.Text = varobjBindAnimated.objDReader("contain")
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

        If menuid = Nothing Then menuid = ""
        Dim varobjBindAnimatedReview As New DataService
        varobjBindAnimatedReview.FillDataSetQueryJoin("select top(3) * from tblcustomerUserReviews where menuid='" & menuid.ToString & "' and checkerid is not null  order by autonum desc   ")
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
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (SELECT     tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,                                                                         CASE WHEN category = 'Veg' THEN 'tab1' ELSE CASE WHEN category = 'nonveg' THEN 'tab2' ELSE 'tab3' END END AS categoryy,                                                                         CASE WHEN category = 'Veg' THEN 'tab-grid1' ELSE CASE WHEN category = 'nonveg' THEN 'tab-grid2' ELSE 'tab-grid3' END END AS categoryyy,                                                                                                                                               CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThismondayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThismondaynv'                                                                         ELSE 'testimonialsThismondayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '01010100010001') AND (tblweekMenu.Weekday = 'Monday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnameMonday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname")
                ' .lblRestaurantname =  varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname"), _
                image.Add(New clsImg() With { _
                           .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                  .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
            .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                              .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                             .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                  .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
               .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
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
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,case when category='Veg' then 'tab4' else case when category='nonveg' then 'tab5' else 'tab6' end end as categoryy,case when category='Veg' then 'tab-grid4' else case when category='nonveg' then 'tab-grid5' else 'tab-grid6' end end as categoryyy,                                                                      CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThistuesdayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThistuesdaynv'                                                                         ELSE 'testimonialsThistuesdayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '01010100010001') AND (tblweekMenu.Weekday = 'Tuesday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid   ")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnameTuesday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname")
                '.lblRestaurantname =  varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname"), _
                image.Add(New clsImg() With { _
                           .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                  .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
            .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                              .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                             .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                 .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
               .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
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
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,case when category='Veg' then 'tab7' else case when category='nonveg' then 'tab8' else 'tab9' end end as categoryy,case when category='Veg' then 'tab-grid7' else case when category='nonveg' then 'tab-grid8' else 'tab-grid9' end end as categoryyy,                                                                      CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThiswednesdayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThiswednesdaynv'                                                                         ELSE 'testimonialsThiswednesdayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '" & Session("weeklymenuOfficeid") & "') AND (tblweekMenu.Weekday = 'wednesday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid  ")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnameWednesday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname")
                '   .lblRestaurantname =  varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname"), _
                image.Add(New clsImg() With { _
                         .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
                           .lblprice = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
                           .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                             .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                               .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
                         .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
                            .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                             .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                           .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                            .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
                            .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
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
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,case when category='Veg' then 'tab10' else case when category='nonveg' then 'tab11' else 'tab12' end end as categoryy,case when category='Veg' then 'tab-grid10' else case when category='nonveg' then 'tab-grid11' else 'tab-grid12' end end as categoryyy,                                                                       CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThisthursdayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThisthursdaynv'                                                                         ELSE 'testimonialsThisthursdayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '" & Session("weeklymenuOfficeid") & "') AND (tblweekMenu.Weekday = 'thursday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid  ")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnameThursday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname")
                '.lblRestaurantname =  varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname"), _
                image.Add(New clsImg() With { _
                   .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                  .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
            .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                       .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                     .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
               .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
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
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,case when category='Veg' then 'tab13' else case when category='nonveg' then 'tab14' else 'tab15' end end as categoryy,case when category='Veg' then 'tab-grid13' else case when category='nonveg' then 'tab-grid14' else 'tab-grid15' end end as categoryyy,                                                                       CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThisfridayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThisfridaynv'                                                                         ELSE 'testimonialsThisfridayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '" & Session("weeklymenuOfficeid") & "') AND (tblweekMenu.Weekday = 'friday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid  ")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnameFriday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname")
                '.lblRestaurantname =  varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname"), _
                image.Add(New clsImg() With { _
                    .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
              .lblprice = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                  .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
            .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                        .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                      .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
               .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
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
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *   FROM         (SELECT     *                         FROM          (select tblweekMenu.Autonum, tblweekMenu.Weekday, tblweekMenu.MenuDate, tblweekMenu.LocationID, tblweekMenu.RestaurantID,                                                                         tblweekMenu.RestaurantName, tblweekMenu.MenuID, tblweekMenu.MenuName, tblweekMenu.Category, tblweekMenu.status,                                                                         tblweekMenu.MakerID, tblweekMenu.CheckerID, tblweekMenu.officeID, tblweekMenu.OfficeName, tblLocationProfile.Citycode,                                                                         tblLocationProfile.LocationCode, tblLocationProfile.LocationName, tblLocationProfile.createddate, tblLocationProfile.City,                                                                       tblLocationProfile.DIOCODE, tblRestaurantMenuProfile.RestaurantCode, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.Price,                                                                         tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation,                                                                         tblRestaurantMenuProfile.contain,case when category='Veg' then 'tab16' else case when category='nonveg' then 'tab17' else 'tab18' end end as categoryy,case when category='Veg' then 'tab-grid16' else case when category='nonveg' then 'tab-grid17' else 'tab-grid18' end end as categoryyy,                                                                       CASE WHEN tblweekMenu.category = 'veg' THEN 'testimonialsThissaturdayv' ELSE CASE WHEN tblweekMenu.category = 'Nonveg' THEN 'testimonialsThissaturdaynv'                                                                         ELSE 'testimonialsThissaturdayl' END END AS testimonials,                                                                         tblcustomerUserReviews.Customername + '`' + tblcustomerUserReviews.Review AS customername, row_number() OVER (partition BY                                                                         tblcustomerUserReviews.MenuID                                                ORDER BY tblcustomerUserReviews.autonum desc) AS seq                         FROM          tblweekMenu INNER JOIN                                                tblLocationProfile ON SUBSTRING(tblweekMenu.officeID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN                                                tblRestaurantMenuProfile ON tblweekMenu.MenuID = tblRestaurantMenuProfile.MenuID INNER JOIN                                                tblcustomerUserReviews ON tblweekMenu.MenuID = tblcustomerUserReviews.MenuID                         WHERE      (tblweekMenu.officeID = '" & Session("weeklymenuOfficeid") & "') AND (tblweekMenu.Weekday = 'saturday') AND (tblweekMenu.status = 'Approved') AND                                               (tblcustomerUserReviews.checkerid IS NOT NULL)) AS derv  WHERE     seq < 4) src PIVOT (max(Customername) FOR seq IN ([1], [2], [3])) piv order by menuid  ")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantnameSaturday.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname")
                ' .lblRestaurantname =  varobjBindAnimated.objDS.Tables(0).Rows(i).Item("officename") & " (sample location) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname"), _
                image.Add(New clsImg() With { _
    .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname"), _
                     .lblprice = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
                     .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                       .lblcategoryy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryy"), _
                         .lblcategoryyy = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("categoryyy"), _
                   .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("category"), _
                .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
        .lblTestimonial = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("testimonials"), _
                .lbl1 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl2 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl3 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
      .lbl4 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("1"), _
                .lbl5 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("2"), _
                .lbl6 = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("3"), _
                      .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
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
        Public Property lblRestaurantname() As String
            Get
                Return m_lblRestaurantname
            End Get
            Set(value As String)
                m_lblRestaurantname = value
            End Set
        End Property
        Private m_lblRestaurantname As String
        Public Property lblRestaurantcode() As String
            Get
                Return m_lblRestaurantcode
            End Get
            Set(value As String)
                m_lblRestaurantcode = value
            End Set
        End Property
        Private m_lblRestaurantcode As String
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
    Private Sub UDPOPULATEFIELDS()
        Dim varObjBindcitylist As New DataBind
        varObjBindcitylist.BindDataListJoin("select * from tblcityprofile", ddcitysignup, "SELECT CITY", "city", "citycode")
        ddcitysignup.SelectedIndex = -1
        varObjBindcitylist.BindDataListJoin("select * from tblcityprofile", ddlEnquiryCity, "SELECT CITY", "city", "citycode")
        varObjBindcitylist = Nothing
    End Sub
    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        Try

            If ddcitysignup.SelectedItem.Text <> "SELECT CITY" And ddlLocation.SelectedItem.Text <> "select" And ddcompanysignup.SelectedItem.Text <> "SELECT" And txtdeliveryAddress.Text <> "" Then


                Dim message As String = ""
                Dim objdataChkServ As New DataService
                If objdataChkServ.blnFindRecord("tblcustomeruserprofile", "mailid = '" & txtemailsignup.Text.Trim & "' or PhoneNumber='" & txtmobilesignup.Text.Trim & "'  ") <> True Then



                    '   Dim emailstatus As Boolean = verifyemail(txtemailsignup.Text).ToString
                    Dim emailstatus As Boolean = True
                    If emailstatus = True Then



                        Dim rng As New Random
                        Dim digits As String = index.GenerateDigits(rng, 5)
                        Console.WriteLine(digits)

                        Dim status As String = "Not Verified"

                        Dim varGenerateCustomercode As New SPDataService
                        Dim strcustomercode As String = varGenerateCustomercode.udfnGenerateCodecustomer("tblcustomeruserprofile", "customerid", "substring(customerid,1,14)='" & ddcompanysignup.SelectedValue.ToString & "'")
                        varGenerateCustomercode.CloseConnection()

                        strcustomercode = ddcompanysignup.SelectedValue.ToString & strcustomercode

                        Session("StrUserIPAddress") = "::1"


                        Dim veg As Boolean, nonveg As Boolean, Lite As Boolean, Weeknotification As Boolean, newsletter As Boolean
                        If lstInterested.Items(0).Selected = True Then veg = True Else veg = False
                        If lstInterested.Items(1).Selected = True Then nonveg = True Else nonveg = False
                        If lstInterested.Items(2).Selected = True Then Lite = True Else Lite = False
                        If chkweeklynodification.Checked = True Then Weeknotification = True Else Weeknotification = False
                        If chkforOffers.Checked = True Then newsletter = True Else newsletter = False





                        Dim varkycFeed As New DataService
                        varkycFeed.ExecuteQueryConnected("insert into tblcustomeruserprofile(CustomerID, CustomerName, Firstname, LastName,  MailID, PhoneNumber, CreatedDate, Password, Verificationcode,ipaddress, Status,weekmenunotification, newsletter, veg, nonveg, Lite) values ('" & strcustomercode & "','" & txtnamesignup.Text & "','" & txtnamesignup.Text & "', '" & txtnamesignup.Text & "', '" & txtemailsignup.Text & "', '" & txtmobilesignup.Text & "','" & Now.Date & "', '" & txtpasswordsignup.Text & "', '" & digits & "','" & Session("StrUserIPAddress") & "', '" & status & "','" & Weeknotification & "','" & newsletter & "','" & veg & "','" & nonveg & "','" & Lite & "')")
                        varkycFeed.CloseConnection()


                        objdataChkServ.CloseConnection()

                        MailFORWARDING(digits, strcustomercode)







                        txtnamesignup.Text = ""
                        txtemailsignup.Text = ""
                        txtmobilesignup.Text = ""
                        txtpasswordsignup.Text = ""
                        txtconfirmpasswordsignup.Text = ""
                        txtdeliveryAddress.Text = ""
                        ddlLocation.SelectedIndex = 0
                        ddcitysignup.SelectedIndex = 0
                        ddcompanysignup.SelectedIndex = 0


                        message = "Registration successful. Activation email has been sent."
                        mp2.Show()
                        lblunabletoProcess.Text = message
                    Else
                        message = "Invalid MailID."
                        mp2.Show()
                        lblunabletoProcess.Text = message
                    End If


                Else



                    Dim objdataChkServVerifiedornot As New DataService
                    objdataChkServVerifiedornot.GetSingleRow("tblcustomeruserprofile", "mailid = '" & txtemailsignup.Text.Trim & "'  and status='Not Verified'  ")
                    If objdataChkServVerifiedornot.objDReader.HasRows Then


                        Session("digitsReactivation") = objdataChkServVerifiedornot.objDReader("verificationcode").ToString
                        Session("strcustomercodeReactivation") = objdataChkServVerifiedornot.objDReader("CustomerID").ToString
                        objdataChkServVerifiedornot.CloseConnection()

                        message = "Activation mail already sent to  '" & txtemailsignup.Text & "' .<br/> Click Ok to receive activation mail. "
                        mp3.Show()
                        lblredirect.Text = message
                    Else
                        message = "EmailId already exists."
                        mp2.Show()
                        lblunabletoProcess.Text = message
                    End If
                    objdataChkServVerifiedornot.CloseConnection()





                End If
                objdataChkServ.CloseConnection()

            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub MailFORWARDING(ByVal digits As String, ByVal strcustomercode As String)

        Dim reader As New StreamReader(Server.MapPath("~/mailing/CustVerification.html"))
        Dim readFile As String = reader.ReadToEnd()
        Dim myString As String = ""
        myString = readFile
        myString = myString.Replace("$$name$$", txtnamesignup.Text)

        Dim actLink As String = "<a href = '" + Request.Url.AbsoluteUri.Replace("index.aspx", Convert.ToString("CustActivation.aspx?ActivationCode=") & digits & "~" & strcustomercode) + "'>Click here to activate your account.</a>"

        myString = myString.Replace("$$Activation$$", actLink)
      
        Dim Msg As New System.Net.Mail.MailMessage

        Msg.From = New System.Net.Mail.MailAddress("sales@blueberrit.com")

        ' Recipient e-mail address.
        Msg.[To].Add(New MailAddress(txtemailsignup.Text))
        ' Subject of e-mail
        Msg.Subject = "BlueBerrit - Account Activation"
        Msg.Body = myString.ToString()
        Msg.IsBodyHtml = True

        Dim SMTP As New System.Net.Mail.SmtpClient
        SMTP.EnableSsl = True
        SMTP.Send(Msg)

        reader.Dispose()
        SMTP.Dispose()
    End Sub
    Sub clear()
        txtnamesignup.Text = ""
        txtnamesignup.Text = ""
        txtemailsignup.Text = ""
        txtmobilesignup.Text = ""
        txtpasswordsignup.Text = ""
        txtpasswordsignup.Text = ""
        ddcitysignup.SelectedIndex = 0
        ddcompanysignup.SelectedIndex = 0
    End Sub
    Private Shared Function GenerateDigits(ByVal rng As Random, ByVal length As Integer) As String
        Dim chArray As Char() = New Char(length - 1) {}
        Dim i As Integer
        For i = 0 To length - 1
            chArray(i) = Convert.ToChar(rng.Next(10) + &H30)
        Next i
        Return New String(chArray)
    End Function
    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click
        Dim objdataChkServVerifiedornot As New DataService
        objdataChkServVerifiedornot.GetSingleRowSelectField("tblcustomeruserprofile INNER JOIN tblcityProfile ON SUBSTRING(tblcustomeruserprofile.CustomerID, 1, 6) = tblcityProfile.Citycode INNER JOIN tblLocationProfile ON SUBSTRING(tblcustomeruserprofile.CustomerID, 1, 10) = tblLocationProfile.LocationCode INNER JOIN tblofficeProfile ON SUBSTRING(tblcustomeruserprofile.CustomerID, 1, 14) = tblofficeProfile.Officecode", " tblcustomeruserprofile.Status, tblcustomeruserprofile.CustomerID, tblcustomeruserprofile.CustomerName, tblcustomeruserprofile.Firstname, tblcustomeruserprofile.PhoneNumber, tblcityprofile.City, tblLocationprofile.LocationName, tblofficeprofile.OfficeName, tblcustomeruserprofile.MailID,tblofficeprofile.DeliveryAddress,tblcityprofile.state ", " tblcustomeruserprofile.mailid='" & txtemaillogin.Text & "' and tblcustomeruserprofile.password='" & txtpasswordlogin.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS and tblcustomeruserprofile.status='Verified'  ")
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

            txtemaillogin.Text = ""
            txtpasswordlogin.Text = ""

            objdataChkServVerifiedornot.CloseConnection()
            Response.Redirect("default.aspx", False)
        Else
            objdataChkServVerifiedornot.CloseConnection()
            txtpasswordlogin.Text = ""

            mp2.Show()
            lblunabletoProcess.Text = "Invalid Credential"

        End If
        objdataChkServVerifiedornot.CloseConnection()
    End Sub
    Private Sub btnenquiry_Click(sender As Object, e As EventArgs) Handles btnenquiry.Click
        Mailcustomer()
        MailFORWARDING()
        txtemailenquiry.Text = ""
        txtnameenquiry.Text = ""
        txtmessageenquiry.Text = ""
        txtsubjectenquiry.Text = ""
        mp2.Show()
        lblunabletoProcess.Text = "Thanks for Enquiry"
    End Sub
    Private Sub MailFORWARDING()


        Session("StrUserIPAddress") = "::1"
        Dim city As String
        If ddlEnquiryCity.SelectedItem.Text <> "SELECT CITY" Then
            city = ddlEnquiryCity.SelectedItem.Text
        Else
            city = "Location not specified"
        End If


        Dim reader As New StreamReader(Server.MapPath("~/mailing/m_enquiryadmin.html"))
        Dim readFile As String = reader.ReadToEnd()
        Dim myString As String = ""
        myString = readFile
        myString = myString.Replace("$$name$$", txtnameenquiry.Text)
        myString = myString.Replace("$$Email$$", txtemailenquiry.Text)
        myString = myString.Replace("$$Subject$$", txtsubjectenquiry.Text)
        myString = myString.Replace("$$message$$", txtmessageenquiry.Text)
        myString = myString.Replace("$$ip$$", city)
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
    Private Sub Mailcustomer()

        Dim reader As New StreamReader(Server.MapPath("~/mailing/m_enquirycustomer.html"))
        Dim readFile As String = reader.ReadToEnd()
        Dim myString As String = ""
        myString = readFile
        myString = myString.Replace("$$name$$", txtnameenquiry.Text)
        myString = myString.Replace("$$Email$$", txtemailenquiry.Text)
        myString = myString.Replace("$$message$$", txtmessageenquiry.Text)
        Dim Msg As New System.Net.Mail.MailMessage

        Msg.From = New System.Net.Mail.MailAddress("sales@blueberrit.com")


        Msg.[To].Add(New MailAddress(txtemailenquiry.Text))

        Msg.Subject = "Thanks for your enquiry - Blueberrit"
        Msg.Body = myString.ToString()
        Msg.IsBodyHtml = True

        Dim SMTP As New System.Net.Mail.SmtpClient
        SMTP.EnableSsl = True
        SMTP.Send(Msg)

        reader.Dispose()
        SMTP.Dispose()

    End Sub
    Private Sub ddcitysignup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddcitysignup.SelectedIndexChanged
        If ddcitysignup.SelectedItem.Text <> "SELECT CITY" Then

            ddlLocation.Visible = True


            Dim varObjBindofficelist As New DataBind
            varObjBindofficelist.BindDataListJoin(" SELECT  locationcode,locationname from tbllocationprofile where citycode='" & ddcitysignup.SelectedValue.ToString & "'    ", ddlLocation, "SELECT LOCATION", "locationname", "locationcode")
            varObjBindofficelist.BindDataListJoin(" SELECT OfficeName + ',(' + OfficeAddress + ')' AS OFFICENAME,OFFICECODE FROM tblofficeProfile WHERE CITYCODE='" & ddcitysignup.SelectedValue.ToString & "' and locationcode='" & ddlLocation.SelectedValue.ToString & "'  ", ddcompanysignup, "SELECT OFFICE", "officename", "officecode")
            varObjBindofficelist = Nothing
            txtdeliveryAddress.Text = ""
            'ddlLocation.SelectedIndex = 0
            'ddcompanysignup.SelectedIndex = 0
        Else
            Dim varObjBindofficelist As New DataBind
            varObjBindofficelist.BindDataListJoin(" SELECT   locationcode,locationname from tbllocationprofile where citycode='Nothing'    ", ddlLocation, "SELECT", "locationname", "locationcode")
            varObjBindofficelist.BindDataListJoin(" SELECT OfficeName + ',(' + OfficeAddress + ')' AS OFFICENAME,OFFICECODE FROM   tblofficeProfile where CITYCODE='" & ddcitysignup.SelectedValue.ToString & "' and locationcode='" & ddlLocation.SelectedValue.ToString & "'  ", ddcompanysignup, "SELECT", "officename", "officecode")
            varObjBindofficelist = Nothing
            ddlLocation.SelectedIndex = 0
            ddcompanysignup.SelectedIndex = 0
            txtdeliveryAddress.Text = ""
        End If
    End Sub
    Private Sub ddlLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlLocation.SelectedIndexChanged
        If ddlLocation.SelectedItem.Text <> "SELECT LOCATION" Then

            ddcompanysignup.Visible = True

            Dim varObjBindofficelist As New DataBind
            varObjBindofficelist.BindDataListJoin(" SELECT OfficeName + ',(' + OfficeAddress + ')' AS OFFICENAME,OFFICECODE FROM   tblofficeProfile where CITYCODE='" & ddcitysignup.SelectedValue.ToString & "' and locationcode='" & ddlLocation.SelectedValue.ToString & "'  ", ddcompanysignup, "SELECT OFFICE", "officename", "officecode")
            varObjBindofficelist = Nothing
            If ddcompanysignup.SelectedItem.Text <> "SELECT OFFICE" Then
                Dim varObjBindofficedeliveryAddress As New DataService
                txtdeliveryAddress.Text = varObjBindofficedeliveryAddress.displaydata("select deliveryaddress from tblofficeprofile where officecode='" & ddcompanysignup.SelectedValue.ToString & "' ")
                varObjBindofficedeliveryAddress.CloseConnection()

            Else

                txtdeliveryAddress.Text = ""
            End If
        Else
            Dim varObjBindofficelist As New DataBind
            varObjBindofficelist.BindDataListJoin(" SELECT OfficeName + ',(' + OfficeAddress + ')' AS OFFICENAME,OFFICECODE FROM tblofficeProfile WHERE CITYCODE='NOTHING'  ", ddcompanysignup, "", "officename", "officecode")
            varObjBindofficelist = Nothing
            txtdeliveryAddress.Text = ""
            ddcompanysignup.SelectedIndex = 0
        End If
    End Sub
    Private Sub ddcompanysignup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddcompanysignup.SelectedIndexChanged
        If ddcompanysignup.SelectedItem.Text <> "SELECT OFFICE" Then
            Dim varObjBindofficelist As New DataService
            txtdeliveryAddress.Text = varObjBindofficelist.displaydata("select deliveryaddress from tblofficeprofile where officecode='" & ddcompanysignup.SelectedValue.ToString & "' ")
            varObjBindofficelist.CloseConnection()
        Else
            txtdeliveryAddress.Text = ""
        End If
    End Sub
   
    Private Sub BtnRedirect_Click(sender As Object, e As EventArgs) Handles BtnRedirect.Click
        MailFORWARDING(Session("digitsReactivation"), Session("strcustomercodeReactivation"))
    End Sub

    Private Sub udpopulatefieldload()
        '''''login 

        txtemaillogin.Text = ""
        txtpasswordlogin.Text = ""


        ''''signup

        txtnamesignup.Text = ""
        txtemailsignup.Text = ""
        txtmobilesignup.Text = ""
        txtpasswordsignup.Text = ""
        txtconfirmpasswordsignup.Text = ""
        txtdeliveryAddress.Text = ""
        ddlLocation.SelectedIndex = 0
        ddcitysignup.SelectedIndex = 0
        ddcompanysignup.SelectedIndex = 0

        ddlLocation.Visible = False
        ddcompanysignup.Visible = False

        '''''enquiry

        txtemailenquiry.Text = ""
        txtnameenquiry.Text = ""
        txtmessageenquiry.Text = ""
        txtsubjectenquiry.Text = ""


    End Sub
    Private Sub udpopulatetab10()
        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     top(4) *  FROM         (SELECT     tblRestaurantProfile.Restaurantcode, tblRestaurantProfile.RestaurantName, tblRestaurantProfile.Location, tblRestaurantProfile.Locationcode,   tblRestaurantMenuProfile.MenuName,tblRestaurantMenuProfile.MenuID,tblRestaurantMenuProfile.contain,tblRestaurantMenuProfile.type, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation, row_number() OVER (partition BY    tblRestaurantProfile.Restaurantcode   ORDER BY tblRestaurantProfile.Restaurantcode) AS seq FROM         tblRestaurantProfile INNER JOIN   tblRestaurantMenuProfile ON tblRestaurantProfile.Restaurantcode = tblRestaurantMenuProfile.RestaurantCode) AS derv WHERE     seq = 1  ")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1

                image.Add(New clsImg() With { _
                .lblRestaurantname = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("RestaurantName"), _
                                                .lblRestaurantcode = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Restaurantcode"), _
                                                         .ImgsingleAnimImag = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Productlocation") & "/" & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuid") & ".jpg"})


            Next
        End If
        varobjBindAnimated.CloseConnection()
        RepeaterImagestabRestaurant.DataSource = image
        RepeaterImagestabRestaurant.DataBind()








    End Sub
    Protected Sub rptList_ItemCommand(sender As Object, e As RepeaterCommandEventArgs)



        If e.CommandName = "ViewAll" Then
            Dim RestaurantCode As String = e.CommandArgument.ToString()

            If RestaurantCode <> "" Then
                Session("viewRestaurantMenu") = RestaurantCode
                Response.Redirect("BlueBerritRestaurantMenu.aspx", True)
            End If






        End If
    End Sub

    Private Sub btnviewAllRestaurant_Click(sender As Object, e As EventArgs) Handles btnviewAllRestaurant.Click
        Response.Redirect("BlueBerritRestaurants.aspx", True)
    End Sub


    Protected Sub RepeaterImagestab1_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab1.ItemDataBound


        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then


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


        End If




    End Sub

    Protected Sub RepeaterImagestab2_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab2.ItemDataBound


        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then


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


        End If




    End Sub
    Protected Sub RepeaterImagestab3_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab3.ItemDataBound


        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then


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


        End If




    End Sub

    Protected Sub RepeaterImagestab4_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab4.ItemDataBound


        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then


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


        End If




    End Sub

    Protected Sub RepeaterImagestab5_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab5.ItemDataBound


        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then


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


        End If




    End Sub

    Protected Sub RepeaterImagestab6_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.RepeaterItemEventArgs) Handles RepeaterImagestab6.ItemDataBound


        If e.Item.ItemType = ListItemType.Item Or e.Item.ItemType = ListItemType.AlternatingItem Then


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


        End If


     

    End Sub

    'Private Sub btncorporatecatering_Click(sender As Object, e As EventArgs) Handles btncorporatecatering.Click
    '    Response.Redirect("Blueberrit_corporatecatering.ASPX", True)
    'End Sub

    'Private Sub btnmarriagecatering_Click(sender As Object, e As EventArgs) Handles btnmarriagecatering.Click
    '    Response.Redirect("Blueberrit_weddingcatering.ASPX", True)
    'End Sub

    'Private Sub btnprivatecatering_Click(sender As Object, e As EventArgs) Handles btnprivatecatering.Click
    '    Response.Redirect("Blueberrit_Privatecatering.ASPX", True)
    'End Sub

    'Private Sub BtnCateringGetStart_Click(sender As Object, e As EventArgs) Handles BtnCateringGetStart.Click
    '    Response.Redirect("Blueberrit_catering.ASPX", True)
    'End Sub
End Class