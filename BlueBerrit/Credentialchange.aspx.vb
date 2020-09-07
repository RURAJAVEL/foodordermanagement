Imports BlueBerrit.ServiceClasses
Imports System.IO
Imports System.Net.Mail

Public Class credentialchange
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then


        End If
    End Sub


    Private Sub btnchangePassword_Click(sender As Object, e As EventArgs) Handles btnchangePassword.Click
        Dim PasswordResetCode As String = If(Not String.IsNullOrEmpty(Request.QueryString("PasswordResetCode")), Request.QueryString("PasswordResetCode"), Guid.Empty.ToString())
        If PasswordResetCode <> "00000000-0000-0000-0000-000000000000" Then

            Dim varObjchangepassword As New SPDataService
            varObjchangepassword.udfnPasswordchange(PasswordResetCode, txtpasswordsignup.Text)
            varObjchangepassword.CloseConnection()



            Dim message As String = "Hi , Your password Changed successfully.  "
            ClientScript.RegisterStartupScript([GetType](), "alert", (Convert.ToString("alert('") & message) + "');", True)
            Response.Redirect("index.aspx", True)
        End If
    End Sub
End Class