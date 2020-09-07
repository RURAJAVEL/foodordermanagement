Imports System.Net.Mail
Imports System.IO
Imports System.Configuration
Imports System.Data
Imports BlueBerrit.ServiceClasses
Imports System.Net
'Imports Newtonsoft.Json.Linq
Public Class BlueBerritRestaurants
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
        varobjBindAnimated.FillDataSetQueryJoin("SELECT     *  FROM         (SELECT     tblRestaurantProfile.Restaurantcode, tblRestaurantProfile.RestaurantName, tblRestaurantProfile.Location, tblRestaurantProfile.Locationcode,   tblRestaurantMenuProfile.MenuName,tblRestaurantMenuProfile.MenuID,tblRestaurantMenuProfile.contain,tblRestaurantMenuProfile.type, tblRestaurantMenuProfile.Description, tblRestaurantMenuProfile.ProductLocation, row_number() OVER (partition BY    tblRestaurantProfile.Restaurantcode   ORDER BY tblRestaurantProfile.Restaurantcode) AS seq FROM         tblRestaurantProfile INNER JOIN   tblRestaurantMenuProfile ON tblRestaurantProfile.Restaurantcode = tblRestaurantMenuProfile.RestaurantCode) AS derv WHERE     seq = 1  ")
        Dim image As New List(Of clsImg)(varobjBindAnimated.objDS.Tables(0).Rows.Count)

        If varobjBindAnimated.objDS.Tables(0).Rows.Count <> 0 Then
            For i = 0 To varobjBindAnimated.objDS.Tables(0).Rows.Count - 1

                image.Add(New clsImg() With { _
                .lblRestaurantname = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("RestaurantName"), _
                                  .lblmenu = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("menuname"), _
                .lblcategory = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("type"), _
                  .lblcontains = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("contain"), _
                .lblRestaurantcode = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("Restaurantcode"), _
                              .lbldescription = varobjBindAnimated.objDS.Tables(0).Rows(i).Item("description"), _
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
    End Class

End Class