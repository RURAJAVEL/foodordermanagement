Imports BlueBerrit.ServiceClasses
Imports System.IO
Imports System.Net.Mail

Public Class forgotCredential
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then


        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Dim message As String = ""
        Dim varGenerateCustomercode As New DataService
        varGenerateCustomercode.GetSingleRow("tblcustomeruserprofile", "mailid='" & txtemaillogin.Text & "' ")
        If varGenerateCustomercode.objDReader.HasRows Then


            Dim Customername As String = varGenerateCustomercode.objDReader("customername").ToString
            Dim customerid As String = varGenerateCustomercode.objDReader("customerid")


            MailFORWARDING(Customername, customerid)


            lblredirect.Text = "Hi '" & Customername & "', Your password has sent to '" & txtemaillogin.Text & "' .</br> This may take a minute. Be sure to check your spam folder and add support@blueberrit.com to your address book to ensure delivery.  "
            varGenerateCustomercode.CloseConnection()




        Else

            lblredirect.Text = "Invalid Mailid."
            varGenerateCustomercode.CloseConnection()
            'Exit Sub
        End If
        varGenerateCustomercode.CloseConnection()

        mp3.Show()

    End Sub

    Private Sub MailFORWARDING(ByVal Customername As String, ByVal customerid As String)
        Try

            Try

                Dim mm As New MailMessage
                mm.From = New System.Net.Mail.MailAddress("sales@blueberrit.com")

                ' Recipient e-mail address.
                mm.[To].Add(New System.Net.Mail.MailAddress(txtemaillogin.Text))
                mm.Subject = "BlueBerrit - Password reset request from BlueberrIT - !"
                Dim body As String = "Hello " + Customername + ", <br/>"
                body += "<br/> A password reset request has been received for &nbsp;&nbsp;" + txtemaillogin.Text + "."
                body += "<br /><br />Use the following link to reset it:<br/>"
                body += "<br /><a href = '" + Request.Url.AbsoluteUri.Replace("forgotCredential.aspx", Convert.ToString("credentialchange.aspx?PasswordResetCode=") & customerid) + "'>Click here to Reset your account password.</a>"
                body += "<br /><br />Thanks"
                mm.Body = body
                mm.IsBodyHtml = True

                Dim SMTP As New System.Net.Mail.SmtpClient
                SMTP.EnableSsl = True
                SMTP.Send(mm)
                SMTP.Dispose()







            Catch ex As Exception
                Throw ex
            End Try



        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub BtnRedirect_Click(sender As Object, e As EventArgs) Handles BtnRedirect.Click
        Response.Redirect("index.aspx", True)
    End Sub
End Class