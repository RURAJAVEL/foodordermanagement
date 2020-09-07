Imports System.Net.Mail
Imports System.IO
Imports System.Configuration
Imports System.Data
Imports BlueBerrit.ServiceClasses
Imports System.Net
'Imports Newtonsoft.Json.Linq
Public Class BlueBerritRestaurantMenu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            udpopulatetab1()

        End If
        If IsPostBack Then

        End If



    End Sub


    Private Sub udpopulatetab1()
        Dim varobjBindAnimated As New DataService
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     tblRestaurantProfile.Restaurantcode, tblRestaurantProfile.RestaurantName, tblRestaurantProfile.Location as locationname, tblRestaurantProfile.Locationcode,         tblRestaurantMenuProfile.MenuName,tblRestaurantMenuProfile.contain, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation, tblRestaurantMenuProfile.Price,        tblRestaurantMenuProfile.Tax, tblRestaurantMenuProfile.Type, tblRestaurantMenuProfile.MenuID FROM         tblRestaurantProfile INNER JOIN                       tblRestaurantMenuProfile ON tblRestaurantProfile.Restaurantcode = tblRestaurantMenuProfile.RestaurantCode where tblrestaurantprofile.restaurantcode='" & Session("viewRestaurantMenu") & "'  and tblRestaurantMenuProfile.status='Approved'  ")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1
                lblRestaurantName.Text = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname") & " (Restaurant) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname")
                image.Add(New clsImg() With { _
                .lblRestaurantLoc = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("restaurantname") & " (Restaurant) in " & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("locationname"), _
 .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
   .lblprice = "Rs." & varobjBindAnimated.objDS.Tables(0).Rows(i).Item("price"), _
                              .lblmenutax = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("tax"), _
                .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("type"), _
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
    End Class

End Class