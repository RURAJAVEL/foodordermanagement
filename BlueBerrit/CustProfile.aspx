<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CustProfile.aspx.vb" Inherits="BlueBerrit.CustProfile" %>
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
   <style type="text/css">
   
    .modalPopup
    {
        background-color: #FFFFFF;
      width:40%;
        border: 0.5px solid black;
    }
  
</style>

    <%--  <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />--%>
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<%--  <link href='https://blueberrit/assets/font/font2.css' rel='stylesheet' type='text/css'>--%>
<%--  <link href='https://blueberrit/assets/font/font3.css' rel='stylesheet' type='text/css'>--%>
<link rel="stylesheet" type="text/css" href="css/component.css" />

<script src="js/jquery.min.js"></script>
<script src="js/simpleCart.min.js"> </script>


  
       <script type = "text/javascript">
           function ConfirmProcessCart() {
               var confirm_value = document.createElement("INPUT");
               confirm_value.type = "hidden";
               confirm_value.name = "confirm_value";
               if (confirm("Do you want Cancel food from Basket?")) {
                   confirm_value.value = "Yes";
               } else {
                   confirm_value.value = "No";
               }
               document.forms[0].appendChild(confirm_value);
           }
    </script>
      
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
        <a href="cart.aspx"> CART</a> &nbsp; 
      <a href="DEFAULT.aspx"> HOME</a> &nbsp; 
      <a href="custreferral.aspx"> REFERRAL</a> &nbsp; 
        <a href="index.aspx">LOGOUT</a>
    </div>

           
             <section id="koUnableToProcessRed" class="content-section form contact light space">
            <asp:HiddenField ID="HiddenField1" runat="server" />
               <cc1:ModalPopupExtender ID="mp3" runat="server" PopupControlID="Panel1" TargetControlID="HiddenField1"  BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="center" style = "display:none">
      
     <div class="header1">
                            CARD DETAILS
                        </div>
                        <div class="body1">
                            <asp:Label ID="lblredirect"  runat="server" />
                        </div>
                        <div class="footer1" >
                       
                            <asp:Button ID="BtnRedirect" runat="server" Text="OK" CssClass="yes" />
                        </div>

</asp:Panel>

          </section>

           <section id="contact" class="content-section form contact light space">
      
           
             <div class="container"> 
          
          
            <asp:ScriptManager ID="scriptmanageR" runat="server" />
            
              <div class="tabs-box">
			
			
                  <div class="clearfix"> </div>
                  <ul class="tabs-menu51">
				<li class="active" ><a href="#tab51"  >PROFILE</a></li>
				<li ><a href="#tab52">CARD DETAILS</a></li>
				
          		</ul>
                
		 <div class="tab-grids">


             <div id="tab51" class="tab-grid51">
        	  <div class="content cover text-center">
              <div class="heading">
                <h2>Profile</h2>
                
               
              </div>
                  
                  
               <div class="row">
            <span id="Span1"></span>
            
         
                <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;width:50%;">
              
                           <asp:UpdatePanel ID="updatepanelSignupLocation" runat="server" UpdateMode="always">
                        <ContentTemplate>

                    <span class="input-group">
                        <%--<i class="fa fa-road"></i>--%>
                          <asp:DropDownList ID="ddcitysignup" AutoPostBack="true" CssClass="dd" runat="server" /> 
                       
                    </span><!-- .input-group -->
                    <br /><br />
                    <span class="input-group">
                        <%--<i class="fa fa-road"></i>--%>
                   
                     <asp:DropDownList ID="ddlLocation" AutoPostBack="true" CssClass="dd" runat="server" /> 
                      

                        
                          </span><!-- .input-group -->
                    
                   	<span class="input-group">
                        <%--<i class="fa fa-road"></i>--%>
                          
                              <asp:DropDownList ID="ddcompanysignup" AutoPostBack="true" CssClass="dd" runat="server" /> 
                       
                           
                            
                    </span><!-- .input-group -->



                              <span class="input-group">
                        <%--<i class="fa fa-road"></i>--%>
                      
                             <asp:TextBox ID="txtdeliveryAddress"  AutoComplete="off" class="lg" placeholder="Delivery Address" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtdeliveryAddress" ValidationGroup="2" ErrorMessage="Please enter Email"></asp:RequiredFieldValidator>
                
                       
                    </span>


</ContentTemplate></asp:UpdatePanel>



                       <span class="input-group">
                        <%--<i class="fa fa-envelope"></i>--%>
                      
                             <asp:TextBox ID="txtemailsignup" AutoComplete="off" class="lg" placeholder="Email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtemailsignup" ValidationGroup="2" ErrorMessage="Please enter Email"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="erremailval" runat="server" ControlToValidate = "txtemailsignup" ValidationGroup="2" ValidationExpression= "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please enter valid email address"></asp:RegularExpressionValidator>
                       
                    </span><!-- .input-group -->



                    	


                 
                  
                </div><!-- .col-5 -->
                



                <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;width:50%;">

                       <span class="input-group">
                        <%--<i class="fa fa-user"></i>--%>
                          
                            <asp:TextBox ID="txtnamesignup" AutoComplete="off" class="lg" placeholder="Name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv" runat="server" ControlToValidate="txtnamesignup" ValidationGroup="2" ErrorMessage="please enter your Name"></asp:RequiredFieldValidator>

                        
                    </span>
                     

                     <span class="input-group">
                        <%--<i class="fa fa-mobile"></i>--%>
                         
 <asp:TextBox ID="txtmobilesignup" class="lg" placeholder="Mobile" AutoComplete="off" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator runat="server" ID="errmobile" ControlToValidate="txtmobilesignup" ValidationGroup="2" ErrorMessage="please enter mobileno" />
                          <asp:RegularExpressionValidator ID="errmobileval" runat="server" ErrorMessage="Phone Number is not valid" validationGroup="2" ControlToValidate="txtmobilesignup" ValidationExpression="^(1\s*[-\/\.]?)?(\((\d{3})\)|(\d{3}))\s*[-\/\.]?\s*(\d{3})\s*[-\/\.]?\s*(\d{4})\s*(([xX]|[eE][xX][tT])\.?\s*(\d+))*$"></asp:RegularExpressionValidator>



                    </span>

                 <span class="input-group">
                            <i class="fa fa-lock"></i>
               <asp:checkboxlist ID="lstInterested" ForeColor="#8a2be2"  RepeatDirection="Horizontal"   ToolTip="I'm interested in" runat="server">
                         <asp:ListItem Text="veg" Value="0" />
                         <asp:ListItem Text="Nonveg" Value="1" />
                         <asp:ListItem Text="Lite" Value="2" />
                 	</asp:checkboxlist>
                    </span>
               
                     <span class="input-group" style="text-align:LEFT;">
                            <i class="fa fa-lock"></i>
                 	<asp:CheckBox runat="server" ID="chkweeklynodification" Text="Email me weekly menu on sunday" ForeColor="#8a2be2"  ></asp:CheckBox>
                    </span><!-- .input-group -->
                    
                     <span class="input-group" style="text-align:LEFT;">
                         <i class="fa fa-refresh"></i>
                 		<asp:CheckBox runat="server" ID="chkforOffers" Text="Email me about new features,discounts,I can advantage of ,and restaurant i love." ForeColor="#8a2be2"  ></asp:CheckBox>
							                     </span><!-- .input-group -->


                    <span class="input-group">
                        <asp:Button ID="btnUpdateProfile" CssClass="btn1" runat="server" ValidationGroup="2" Text="UPDATE PROFILE"/>
                    	<%--<button class="submit" id="Button1" data-loading-text="SENDING...">SEND</button>--%>
                    </span><!-- .input-group -->
                </div>
         <%--   </form>--%>
            
          </div>
             
                  </div>
                 </div>






             <div id="tab52" class="tab-grid52">
        	  <div class="content cover text-center">
              <div class="heading">
                <h2>CARD DETAILS</h2>
                
               
              </div>
                
                  
               <div class="row">
            <span id="Span1"></span>
            
         
                <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">
              
                        <%--   <asp:UpdatePanel ID="updatepanel1" runat="server" UpdateMode="always">
                        <ContentTemplate>--%>

                    <span class="input-group">
                        <%--<i class="fa fa-user"></i>--%>
                          <asp:TextBox ID="txtcardname" AutoComplete="off"  class="lg" placeholder="CARD NAME" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcardname" ValidationGroup="3" ErrorMessage="Please enter CARD NAME"></asp:RequiredFieldValidator>
                       
                    </span><!-- .input-group -->
                    <br /><br />
                    <span class="input-group">
                        <%--<i class="fa fa-user"></i>--%>
                   
                   
                      <asp:TextBox ID="txtcardno" class="lg" AutoComplete="off" placeholder="CARD NO" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcardno" ValidationGroup="3" ErrorMessage="Please enter CARD NO"></asp:RequiredFieldValidator>
                 

                        
                          </span><!-- .input-group -->
                    
                   	<span class="input-group">
                        <%--<i class="fa fa-user"></i>--%>
                          
                           
                       <asp:TextBox ID="txtmmyy" class="lg" AutoComplete="off"  placeholder="MM/YY" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtmmyy" ValidationGroup="3" ErrorMessage="please enter Card MM/YY"></asp:RequiredFieldValidator>
                           
                            
                    </span><!-- .input-group -->



                              <span class="input-group">
                        <%--<i class="fa fa-user"></i>--%>
                      
 <asp:TextBox ID="TXTCVCNO" class="lg" placeholder="CVC NO" AutoComplete="off" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator6" ControlToValidate="TXTCVCNO" ValidationGroup="3" ErrorMessage="please enter CVC NO" />
                       
                
                       
                    </span>






           <span class="input-group">
                        <asp:Button ID="btnupdatecarddetails" CssClass="btn1" runat="server" ValidationGroup="3" Text="UPDATE CARD DETAIL"/>
                    	<%--<button class="submit" id="Button1" data-loading-text="SENDING...">SEND</button>--%>
                    </span><!-- .input-group -->


<%--</contenttemplate></asp:updatepanel>--%>
                    	


                 
                  
                </div><!-- .col-5 -->
                



      
            
          </div>
             
                  </div>
                 </div>


             	</div>

                 </div>
          
                 
                 
                   </div>
    	<!-- .container signup -->


                       <!-- tabs-box -->
			<!-- Comman-js-files -->
		<script >
			    $(document).ready(function () {
			        $("#tab52").hide();
			     


			        $(".tabs-menu51 a").click(function (event) {
			            event.preventDefault();
			            var tab = $(this).attr("href");
			            $(".tab-grid51,.tab-grid52,.tab-grid53").not(tab).css("display", "none");
			            $(tab).fadeIn("slow");
			        });
			        $("ul.tabs-menu51 li a").click(function () {
			            $(this).parent().addClass("active a");
			            $(this).parent().siblings().removeClass("active a");

			        });

			    });




			</script>
		




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


	    $(document).ready(function () {
	        $('#signup').click(function (event) {

	            $('#submenu').toggle(1000);
	        });
	    });

    </script>
          </form>
  </body>
</html>
