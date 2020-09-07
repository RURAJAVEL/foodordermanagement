Imports BlueBerrit.ServiceClasses

Public Class CustActivation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then

            Dim activationCode As String = If(Not String.IsNullOrEmpty(Request.QueryString("ActivationCode")), Request.QueryString("ActivationCode"), Guid.Empty.ToString())
            If activationCode <> "00000000-0000-0000-0000-000000000000" Then
                Dim stractivationcode As String() = activationCode.ToString.Split("~")



                Dim objdataChkServVerifiedornot As New DataService
                If objdataChkServVerifiedornot.blnFindRecord("tblcustomeruserprofile", "customerid = '" & stractivationcode(1).ToString & "' and Verificationcode='" & stractivationcode(0).ToString & "'  ") = True Then
                    objdataChkServVerifiedornot.CloseConnection()


                    Dim varkycFeed As New DataService
                    varkycFeed.ExecuteQueryConnected("update tblcustomeruserprofile set status='Verified' where customerid = '" & stractivationcode(1).ToString & "' and Verificationcode='" & stractivationcode(0).ToString & "' ")
                    varkycFeed.CloseConnection()


                    Dim message As String = "Activation successful.Click here to SignIn"
                    mp3.Show()
                    lblredirect.Text = message

                Else
                    Dim message As String = "Activation Failed.click Here to Home"
                    mp3.Show()
                    lblredirect.Text = message
                End If

            Else
                Dim message As String = "Unable to proceed Your Request"
                mp3.Show()
                lblredirect.Text = message
            End If






        End If
    End Sub
    Private Sub BtnRedirect_Click(sender As Object, e As EventArgs) Handles BtnRedirect.Click
        Response.Redirect("index.aspx", True)
    End Sub
End Class