Imports BlueBerrit.ServiceClasses

Public Class CustReferral
    Inherits System.Web.UI.Page
    Dim varsubtotal As Double, vartotalTAx As Double, varTotalAmount As Double, vartotalQuantity As Double
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim varobjgetverification As New DataService
            lblreferralcode.Text = Session("custfirstname") & varobjgetverification.displaydata("select verificationcode from tblcustomeruserprofile where CustomerID='" & Session("customerid") & "' ")
            varobjgetverification.CloseConnection()
        End If
    End Sub
   
   
End Class