<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ReviewOrders.aspx.vb" Inherits="BlueBerrit.ReviewOrders" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>
<html lang="en-us">
  <head>
     <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="WebThemez">
    <%--<link rel="shortcut icon" href="">--%>
    <title>BlueberrIT</title>
   <%--   <link rel="stylesheet" href="https://blueberrit/assets/font/font1.css">--%>
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <!-- FancyBox -->
	<%--<link href="assets/css/fancybox/jquery.fancybox.css" rel="stylesheet">--%>
    <link rel="stylesheet" href="assets/css/style2.css"> 
    <link rel="stylesheet" href="assets/css/animate.min.css">
    <link rel="stylesheet" href="assets/css/font-awesome.min.css">
   
       <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script src='http://jquery-star-rating-plugin.googlecode.com/svn/trunk/jquery.rating.js'
    type="text/javascript"></script>
<link rel="Stylesheet" href="http://jquery-star-rating-plugin.googlecode.com/svn/trunk/jquery.rating.css" />
      
    <%--  <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />--%>
<link href="css/cartstyle.css" rel="stylesheet" type="text/css" media="all" />
<%--  <link href='https://blueberrit/assets/font/font2.css' rel='stylesheet' type='text/css'>--%>
<%--  <link href='https://blueberrit/assets/font/font3.css' rel='stylesheet' type='text/css'>--%>
<link rel="stylesheet" type="text/css" href="css/component.css" />

<script src="js/jquery.min.js"></script>
<script src="js/simpleCart.min.js"> </script>


   
       <script type = "text/javascript">
        


           function Confirm() {
               var confirm_value = document.createElement("INPUT");
               confirm_value.type = "hidden";
               confirm_value.name = "confirm_value";
               if (confirm("Do you want to Review us?")) {
                   confirm_value.value = "Yes";
               } else {
                   confirm_value.value = "No";
               }
               document.forms[0].appendChild(confirm_value);
           }


           $(document).ready(function () {
               $('#signup').click(function (event) {

                   $('#submenu').toggle(1000);
               });
           });
    </script>
    <style type="text/css">
   
    .modalPopup
    {
        background-color: #FFFFFF;
      width:40%;
        border: 0.5px solid black;
    }
  
</style>
        </head>
  <body> 
      <form id="form1" runat="server">

          <div id="navbar-top">
      <nav class="navbar navbar-default navbar-static" role="navigation">
        <div class="container">
          <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
              <span class="sr-only">Toggle navigation</span>
              <span class="icon-bar"></span>
              <span class="icon-bar"></span>
              <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand nav-external" href="#home"><img class="logo" src="images/logo.png" alt="BlueBerrit" /></a>
          </div>
          <div class="collapse navbar-collapse">
            <ul class="nav navbar-nav navbar-right">
             
                
                
             
            
             <li id="signup">
                            <a href="">HOME</a>
                        </li>
             
            </ul>
          </div>
        </div>
      </nav>
    </div>
     <div id="submenu" hidden>
     
      <a href="DEFAULT.aspx"> BACK </a> &nbsp; 
      
        <a href="index.aspx">LOGOUT</a>
    </div>

  
    <section id="work-a" >
      <div class="cart">
     <div class="container">
     


         
          
           <asp:ScriptManager runat="server"></asp:ScriptManager>
          
         
          

         <section id="koUnableToProcessRed" class="content-section form contact light space">
            <asp:HiddenField ID="HiddenField1" runat="server" />
               <cc1:ModalPopupExtender ID="mp3" runat="server" PopupControlID="Panel1" TargetControlID="HiddenField1"  BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="center" style = "display:none">
      
     <div class="header1">
                            Notification
                        </div>
                        <div class="body1">
                            <asp:Label ID="lblredirect"  runat="server" />
                        </div>
                        <div class="footer1" >
                       
                            <asp:Button ID="BtnRedirect" runat="server" Text="OK" CssClass="yes" />
                        </div>

</asp:Panel>

          </section>



        
      <%-- <asp:Panel ID="pnlconfirmCart" runat="server">--%>
         <div class="col-md-9 cart-items">
                <h2>Give your Reviews to serve better.</h2>
              
               <asp:Repeater ID="RepeaterImagestab2" OnItemCommand="rptList_ItemCommand" runat="server"    >
    <ItemTemplate >
                           <div class="cart-header">
                                 <div class="close2">  <button type="button" id="more"  style="background-color:transparent;"  data-toggle="collapse" data-target='#<%# Eval("lnkmakerid")%>' > 
                           
				 <img src="images/reviews.png" width="38" height="35"  alt="Review Food" />
		</button>       </div>
                    <div class="close1">   </div>
                    <div class="cart-sec">
                        <div class="cart-item cyc">
                          <asp:image runat="server" ID="ImgsingleAnimImag"  ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
                           
                        </div>
                        <div class="cart-item-info">
                          
                            <h4><asp:Label runat="server" Text="Restaurant  :" /> <asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </h4><br />
                         <h4><asp:Label runat="server"  Text  ="Dish &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:" /> <asp:Label Text= '<%# Eval("lblmenu")%>'  ID="lblmenu" runat="server" > </asp:Label></span></h4><br />
                               <h4> <asp:Label runat="server"  Text  ="Category &nbsp;&nbsp;&nbsp;:" /> <span>  </span><asp:Label  Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label> <asp:Label ID="lblmenuid" runat="server" Text= '<%# Eval("lblmenuID")%>' Visible="false" />  <span>  </h4><br />
                            <h4><asp:Label runat="server"  Text  ="Contains &nbsp;&nbsp;&nbsp;:" /><span>  </span><asp:Label  Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label> <span>  </h4><br />
                    
                               </div>
                        <div class="clearfix"></div>
                        <div class="delivery">
                              <div id='<%# Eval("lnkmakerid")%>' class="collapse" >  
                               
     


                             <p>Review::  <asp:textbox  ID="txtReview" runat="server" Text= '<%# Eval("txtReview")%>' TextMode="MultiLine"> </asp:textbox></p>   <br />    
                               <asp:LinkButton ID="linkPostReview"   Text="Post Review" runat="server" class="order1"   ></asp:LinkButton>  

                                  <section id="koCancelCart" >
                              <cc1:ConfirmButtonExtender ID="cbe" runat="server" DisplayModalPopupID="mpe" TargetControlID="linkPostReview">
                    </cc1:ConfirmButtonExtender>
                    <cc1:ModalPopupExtender ID="mpe" runat="server" PopupControlID="pnlPopup" TargetControlID="linkPostReview"
                         CancelControlID="btnNo" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
           <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header1">
                            Confirmation
                        </div>
                        <div class="body1">
                            Do you want to post your Review?
                        </div>
                        <div class="footer1" >
                            <asp:Button ID="btnYes"  runat="server"  CssClass="yes"  Text="yes" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "lblmenuid")%>' CommandName="Review" />
                            <asp:Button ID="btnNo" runat="server" Text="No" CssClass="no" />
                        

                        </div>
                    </asp:Panel>
                          </section>

                                                                    </div>
                             
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
              </ItemTemplate></asp:Repeater>
           
            </div>
         
       <%--  </asp:Panel>--%>



        </div>  
      </div>
    </section>
    
    
       

           

          
          <div class="footer_part" style="position: relative; top: 0px;background-color:#eee; background-image:url(images/footer-bg.jpg);"  >
                            
                            <div class="row">
                            	<div class="container">
                                	<div class="col-sm-4">
                                               <h6>Our Services</h6>
                                                <ul>
                                                  <li><a href="index.aspx" class="footer_a">corporate lunch delivery</a></li>
													<li><a href="Blueberrit_catering.aspx" class="footer_a">Catering Services</a></li>
                                                    </ul>
                                     </div>
                                   <div class="col-sm-4">
                                   	       <h6>Quick Links</h6>
                                            <ul>
                                              <li><a href="index.aspx" class="footer_a">Home</a></li>
                                              <li><a href="Blueberrit_aboutus.aspx" class="footer_a">About Us</a></li>
                                              <li><a href="blueberritjobs.aspx" class="footer_a">Carrers</a></li> 
                                            </ul>
                                    </div>
                                  <div class="col-sm-4">
                                            <h6>Contact Info</h6>
                                           
                             
                                            <ul>
                                             <p class="footer_a"><i class="glyphicon glyphicon-envelope"></i>sales@blueberrit.com</p>
                                             </ul>
                                        </div>
                                   
                                    </div>
									
							   </div>
							   <div class="container">
							    <div class="row">
                                    	<div class="col-sm-6">
                                        	<div class="copyright-main-bg">
                                        	  <p class="footer_a">Copyright @2015 BlueBerrIT. All Rights Reserved.</p>
                                              </div>
                                        </div>
  										<div class="col-sm-6">
                                        	<div>
                                        		<p class="footer_a text-right">Powered by <a href="http://www.nisquaretech.com" >NISQUARE TECH</a></p>
                                                </div>
                                  		 </div>
                                    </div>
									</div>
                             
                            </div>
    <script src="assets/js/modernizr-latest.js"></script>
    <%--<script src="assets/js/jquery.min.js"></script>--%>
    <script src="assets/js/bootstrap.min.js"></script>
	<script src="assets/js/jquery.cslider.js"></script>
    <script src="assets/js/isotope.pkgd.min.js"></script>
	<%--<script src="assets/js/jquery.fancybox.pack.js"></script>--%>  
	
          <%--<script src="assets/js/jquery.fancybox-media.js"></script>--%>  
    <script src="assets/js/imagesloaded.min.js"></script>
    <script src="assets/js/jquery.scrollTo.min.js"></script>
    <script src="assets/js/jquery.nav.min.js"></script>
    <script src="assets/js/jquery.appear.min.js"></script>
    <%--<script src="assets/js/twitterFetcher.min.js"></script>--%>
    <script src="assets/js/script.js"></script> 
          
						
	<script type="text/javascript">
	    $(document).ready(function () {
	        $('#da-slider').cslider({
	            autoplay: true,
	            bgincrement: 0
	        });
	    });
    </script>
          </form>
  </body>
</html>
