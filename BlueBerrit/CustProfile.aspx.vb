Imports BlueBerrit.ServiceClasses

Public Class CustProfile
    Inherits System.Web.UI.Page
    Dim varsubtotal As Double, vartotalTAx As Double, varTotalAmount As Double, vartotalQuantity As Double
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Session("CustomerID") = "" Or Session("CustomerID") = Nothing Then
                Response.Redirect("index.aspx", True)
            Else
                UDPOPULATEFIELDS()
            End If

        End If
    End Sub
    Private Sub UDPOPULATEFIELDS()
        Dim varObjBindcitylist As New DataBind
        varObjBindcitylist.BindDataListJoin("select * from tblcityprofile", ddcitysignup, "SELECT", "city", "citycode")
        varObjBindcitylist.BindDataListJoin(" SELECT  locationcode,locationname from tbllocationprofile     ", ddlLocation, "SELECT", "locationname", "locationcode")
        varObjBindcitylist.BindDataListJoin(" SELECT OfficeName + ',(' + OfficeAddress + ')' AS OFFICENAME,OFFICECODE FROM tblofficeProfile   ", ddcompanysignup, "", "officename", "officecode")
        varObjBindcitylist = Nothing
        Dim varObjBindofficelist As New DataService
        txtdeliveryAddress.Text = varObjBindofficelist.displaydata("select deliveryaddress from tblofficeprofile where officecode='" & Session("CustomerID").ToString.Substring(0, 14) & "' ")
        varObjBindofficelist.CloseConnection()

        ddcitysignup.SelectedValue = Session("CustomerID").ToString.Substring(0, 6)
        ddlLocation.SelectedValue = Session("CustomerID").ToString.Substring(0, 10)
        ddcompanysignup.SelectedValue = Session("CustomerID").ToString.Substring(0, 14)

        Dim varobjCustUserList As New DataService
        varobjCustUserList.GetSingleRow("tblcustomeruserprofile", "customerid='" & Session("CustomerID").ToString & "' ")
        If varobjCustUserList.objDReader.HasRows Then
            txtnamesignup.Text = varobjCustUserList.objDReader("customername")
            txtmobilesignup.Text = varobjCustUserList.objDReader("phonenumber")
            txtemailsignup.Text = varobjCustUserList.objDReader("mailid")
         

            If IsDBNull(varobjCustUserList.objDReader("weekmenunotification")) Then
                chkweeklynodification.Checked = False
            ElseIf varobjCustUserList.objDReader("weekmenunotification") = True Then
                chkweeklynodification.Checked = True
            Else
                chkweeklynodification.Checked = False
            End If
            If IsDBNull(varobjCustUserList.objDReader("newsletter")) Then
                chkforOffers.Checked = False
            ElseIf varobjCustUserList.objDReader("newsletter") = True Then
                chkforOffers.Checked = True
            Else
                chkforOffers.Checked = False
            End If
            If IsDBNull(varobjCustUserList.objDReader("veg")) Then
                lstInterested.Items(0).Selected = False
            ElseIf varobjCustUserList.objDReader("veg") = True Then
                lstInterested.Items(0).Selected = True
            Else
                lstInterested.Items(0).Selected = False
            End If
            If IsDBNull(varobjCustUserList.objDReader("nonveg")) Then
                lstInterested.Items(1).Selected = False
            ElseIf varobjCustUserList.objDReader("nonveg") = True Then
                lstInterested.Items(1).Selected = True
            Else
                lstInterested.Items(1).Selected = False
            End If
            If IsDBNull(varobjCustUserList.objDReader("Lite")) Then
                lstInterested.Items(2).Selected = False
            ElseIf varobjCustUserList.objDReader("Lite") = True Then
                lstInterested.Items(2).Selected = True
            Else
                lstInterested.Items(2).Selected = False
            End If






        End If



    End Sub

    Private Sub btnupdatecarddetails_Click(sender As Object, e As EventArgs) Handles btnupdatecarddetails.Click
        Dim objdataChkServ As New DataService
        If objdataChkServ.blnFindRecord("tblcustomeruserprofile", "cardname = '" & txtcardname.Text.Trim & "' AND cardno='" & txtcardno.Text.Trim & "'  ") <> True Then

            Dim varkycFeed As New DataService
            varkycFeed.ExecuteQueryConnected("update tblcustomeruserprofile set cardname='" & txtcardname.Text & "',cardno='" & txtcardno.Text & "',expirydate='" & txtmmyy.Text & "',cvcno='" & TXTCVCNO.Text & "' where customerid='" & Session("CustomerID").ToString & "' ")
            varkycFeed.CloseConnection()
            lblredirect.Text = "CARDNAME : " & txtcardname.Text & "<BR/> CARD NO : " & txtcardno.Text & "<BR/> UPDATED SUCCESSFULLY "
            mp3.Show()
            udcardclear()
        Else
            lblredirect.Text = "CARDNAME : " & txtcardname.Text & "<BR/> CARD NO : " & txtcardno.Text & "<BR/> Card Details exists. "
            mp3.Show()
            udcardclear()
        End If



     
    End Sub

    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        Dim veg As Boolean, nonveg As Boolean, Lite As Boolean, Weeknotification As Boolean, newsletter As Boolean
        If lstInterested.Items(0).Selected = True Then veg = True Else veg = False
        If lstInterested.Items(1).Selected = True Then nonveg = True Else nonveg = False
        If lstInterested.Items(2).Selected = True Then Lite = True Else Lite = False
        If chkweeklynodification.Checked = True Then Weeknotification = True Else Weeknotification = False
        If chkforOffers.Checked = True Then newsletter = True Else newsletter = False

        Dim varkycFeed As New DataService
        varkycFeed.ExecuteQueryConnected("update tblcustomeruserprofile set weekmenunotification='" & Weeknotification & "',newsletter='" & newsletter & "',veg='" & veg & "',nonveg='" & nonveg & "',Lite='" & Lite & "' where customerid='" & Session("CustomerID").ToString & "' ")
        varkycFeed.CloseConnection()

        lblredirect.Text = "Profile Updated successfully "
        mp3.Show()
    End Sub

    Private Sub udcardclear()
        txtcardname.Text = ""
        txtcardno.Text = ""
        txtmmyy.Text = ""
        TXTCVCNO.Text = ""
    End Sub

End Class