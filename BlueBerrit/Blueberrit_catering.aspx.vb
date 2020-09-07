Imports BlueBerrit.ServiceClasses
Imports System.Net.Mail
Imports System.IO

Public Class Blueberrit_catering
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            UDPOPULATEFIELDS()
        End If
    End Sub

    Private Sub btncorporatecatering_Click(sender As Object, e As EventArgs) Handles btncorporatecatering.Click
        Response.Redirect("Blueberrit_corporatecatering.ASPX", True)
    End Sub

    Private Sub btnmarriagecatering_Click(sender As Object, e As EventArgs) Handles btnmarriagecatering.Click
        Response.Redirect("Blueberrit_weddingcatering.ASPX", True)
    End Sub

    Private Sub btnprivatecatering_Click(sender As Object, e As EventArgs) Handles btnprivatecatering.Click
        Response.Redirect("Blueberrit_Privatecatering.ASPX", True)
    End Sub

    Private Sub UDPOPULATEFIELDS()
        Dim varObjBindcitylist As New DataBind
        varObjBindcitylist.BindDataListJoin("select * from tblcityprofile", ddcitycatering, "SELECT CITY", "city", "citycode")
        ddcitycatering.SelectedIndex = -1
        varObjBindcitylist = Nothing
    End Sub
    Public Function subDateconvert(ByVal vardate As String, ByVal varinformat As String, ByVal varoutformat As String) As DateTime
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

    Private Sub btnsubmitCatering_Click(sender As Object, e As EventArgs) Handles btnsubmitCatering.Click


        Dim objDataServCreateUser As New DataService
        objDataServCreateUser.ExecuteQueryConnected("insert into tblCateringEnquiries( City,citycode, OfficeName, Name, Mobile, EmailID, TotMembers, EventDate,STATUS) values('" & ddcitycatering.SelectedItem.Text & "','" & ddcitycatering.SelectedValue.ToString & "','" & txtofficecatering.Text & "','" & txtnamecatering.Text & "', '" & txtmobilecatering.Text & "', '" & txtemailcatering.Text & "', '" & txttotalCatering.Text & "', '" & subDateconvert(txtDatecatering.Text, "dd/MM/yyyy", "MM/dd/yyyy") & "', 'Enquired')")
        objDataServCreateUser.CloseConnection()


        udfnmailcustomer()
        udfnadminmail()



        ddcitycatering.Enabled = False
        txtDatecatering.Enabled = False
        txtemailcatering.Enabled = False
        txtmobilecatering.Enabled = False
        txtnamecatering.Enabled = False
        txtofficecatering.Enabled = False
        txttotalCatering.Enabled = False
        btnsubmitCatering.Enabled = False
        btnsubmitCatering.Text = "THANKS!"



        txtDatecatering.CssClass = "lg"
        txtemailcatering.CssClass = "lg"
        txtmobilecatering.CssClass = "lg"
        txtnamecatering.CssClass = "lg"
        txtofficecatering.CssClass = "lg"
        txttotalCatering.CssClass = "lg"
        btnsubmitCatering.CssClass = "btn1"



    End Sub

    Private Sub udfnmailcustomer()
        Dim reader As New StreamReader(Server.MapPath("~/mailing/CustCateringMail.html"))
        Dim readFile As String = reader.ReadToEnd()
        Dim myString As String = ""
        myString = readFile
        myString = myString.Replace("$$name$$", txtnamecatering.Text)

      

        Dim Msg As New System.Net.Mail.MailMessage

        Msg.From = New System.Net.Mail.MailAddress("sales@blueberrit.com")

        ' Recipient e-mail address.
        Msg.[To].Add(New MailAddress(txtemailcatering.Text))
        ' Subject of e-mail
        Msg.Subject = "Re : Catering Request from " & txtofficecatering.Text & " "
        Msg.Body = myString.ToString()
        Msg.IsBodyHtml = True

        Dim SMTP As New System.Net.Mail.SmtpClient
        SMTP.EnableSsl = True
        SMTP.Send(Msg)

        reader.Dispose()
        SMTP.Dispose()
    End Sub

    Private Sub udfnadminmail()
        Dim reader As New StreamReader(Server.MapPath("~/mailing/m_enquiryCateringAdmin.html"))
        Dim readFile As String = reader.ReadToEnd()
        Dim myString As String = ""
        myString = readFile
        myString = myString.Replace("$$name$$", txtnamecatering.Text)
        myString = myString.Replace("$$Email$$", txtemailcatering.Text)
        myString = myString.Replace("$$mobile$$", txtmobilecatering.Text)
        myString = myString.Replace("$$office$$", txtofficecatering.Text)
        myString = myString.Replace("$$city$$", ddcitycatering.SelectedItem.Text)
        myString = myString.Replace("$$Date$$ ", txtDatecatering.Text)
        myString = myString.Replace("$$people$$", txttotalCatering.Text)

        Dim Msg As New System.Net.Mail.MailMessage

        Msg.From = New System.Net.Mail.MailAddress("sales@blueberrit.com")

        ' Recipient e-mail address.
        Msg.[To].Add(New MailAddress("sales@blueberrit.com"))
        ' Subject of e-mail
        Msg.Subject = "Catering Enquiry from " & ddcitycatering.SelectedItem.Text & " "
        Msg.Body = myString.ToString()
        Msg.IsBodyHtml = True

        Dim SMTP As New System.Net.Mail.SmtpClient
        SMTP.EnableSsl = True
        SMTP.Send(Msg)

        reader.Dispose()
        SMTP.Dispose()
    End Sub

End Class