<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CustReferral.aspx.vb" Inherits="BlueBerrit.CustReferral" %>

<!DOCTYPE html>
<html lang="en-us">
  <head>
     <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="WebThemez">
    <link rel="shortcut icon" href="">
    <title>BlueberrIT</title>
   <%--   <link rel="stylesheet" href="https://blueberrit/assets/font/font1.css">--%>
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <!-- FancyBox -->
	<%--<link href="assets/css/fancybox/jquery.fancybox.css" rel="stylesheet">--%>
    <link rel="stylesheet" href="assets/css/style2.css"> 
    <link rel="stylesheet" href="assets/css/animate.min.css">
    <link rel="stylesheet" href="assets/css/font-awesome.min.css">
   

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

           


           



          
           <section id="contact" class="content-section form contact light space">
      
           
             <div class="container"> 
          
          
            <asp:ScriptManager ID="scriptmanageR" runat="server" />
            
              <div class="tabs-box">
			
			
                  <div class="clearfix"> </div>
                 
                
		 <div class="tab-grids">


             <div id="tab51" class="tab-grid51">
        	  <div class="content cover text-center">
              <div class="heading">
               <h2>REFERRAL</h2>
                
               <p>Have your coworkers sign up with the code below.</p><br /><br />
                   <p>Your referral code is: <asp:Label ID="lblreferralcode" ForeColor="#8a2be2" runat="server"/> </p><br />
                    <p>Their first lunch will be $5.</p><br />
                   <p>Yours is too when they place that order. </p><br />
              </div>
                  
                  
               <div class="row">
            <span id="Span1"></span>
            
         
                <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">
              
                        

                   <span class="input-group">
                        <%--<i class="fa fa-envelope"></i>--%>
                      
                             <asp:TextBox ID="txtReferralEmail" class="lg" placeholder="Email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtReferralEmail" ValidationGroup="2" ErrorMessage="Please enter Email"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate = "txtReferralEmail" ValidationGroup="2" ValidationExpression= "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please enter valid email address"></asp:RegularExpressionValidator>
                       
                    </span>
                    <br /><br />
                 



                    	


                 
                  
                </div><!-- .col-5 -->
                



                <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;">

                     


                    <span class="input-group">
                        <asp:Button ID="btnInviteReferral" CssClass="btn1" runat="server" ValidationGroup="2" Text="INVITE VIA MAIL"/>
                    	
                    </span>
                </div>
         
            
          </div>
             




                  </div>
                 </div>






             


             	</div>

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


	    $(document).ready(function () {
	        $('#signup').click(function (event) {

	            $('#submenu').toggle(1000);
	        });
	    });

    </script>
          </form>
  </body>
</html>
