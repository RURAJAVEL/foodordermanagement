﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Credentialchange.aspx.vb" Inherits="BlueBerrit.Credentialchange" %>

<!DOCTYPE html>
<html lang="en-us">
  <head>
     <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="WebThemez">
   <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<meta name="title" content="Blueberrit - Food Delivery _ Order Food Online ,Catering Services, india , U.S, U.K" />
<meta name="keywords" content="Blueberrit - Food Delivery _ Order Food Online,Catering Services, india , U.S, U.K" />

<meta name="description" content="Blueberrit - Food Delivery _ Order Food Online,Catering Services, india , U.S, U.K" />
    <title>CHANGE CREDENTIAL | BlueberrIT _ Food Delivery _ Order Food Online _ Catering Service</title>
   <%--   <link rel="stylesheet" href="https://blueberrit/assets/font/font1.css">--%>
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <!-- FancyBox -->
	<%--<link href="assets/css/fancybox/jquery.fancybox.css" rel="stylesheet">--%>
    <link rel="stylesheet" href="assets/css/style2.css"> 
    <link rel="stylesheet" href="assets/css/animate.min.css">
    <link rel="stylesheet" href="assets/css/font-awesome.min.css">
   

      <%--<link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />--%>
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<%--  <link href='https://blueberrit/assets/font/font2.css' rel='stylesheet' type='text/css'>--%>
<%--  <link href='https://blueberrit/assets/font/font3.css' rel='stylesheet' type='text/css'>--%>
<link rel="stylesheet" type="text/css" href="css/component.css" />

<script src="js/jquery.min.js"></script>
<script src="js/simpleCart.min.js"> </script>


   

<!-- start menu -->




       <script>
           (function (i, s, o, g, r, a, m) {
               i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                   (i[r].q = i[r].q || []).push(arguments)
               }, i[r].l = 1 * new Date(); a = s.createElement(o),
               m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
           })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

           ga('create', 'UA-62117544-2', 'auto');
           ga('send', 'pageview');

</script>


     <%-- <script>
          window.onload = function () {
              document.getElementById('home').style.height = 418 + "px";
          }

	</script>--%>


      <link rel="stylesheet" href="fp/style.css">

     

        </head>
  <body> 
    
      <form id="form1"  runat="server">
      
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
         

                <%--sample menu--%>

           
	











            </ul>
          </div>
            
        </div>
      </nav>
    </div>


      <div class="tagline homeversion">
<div class="foodswrapper">
<div class="foodburgerwrapper"><img class="animated fadeInUp twosecdelay preload" src="fp/burger.png" alt=""></div>
<div class="foodpizzawrapper"><img class="animated fadeInDown threesecdelay preload" src="fp/pizza.png" alt=""></div>
</div>
<%--<h1>Hungry?</h1>--%>
<h3>Order from BlueBerrit<br>
in your office</h3>
</div>


   

    





           <section id="contact" style="position: relative; top: 0px;background-color:white;" class="content-section form contact light space">
      
           
             <div class="container"> 
          
          
          
            
              <div class="tabs-box">
			
			
                  <div class="clearfix"> </div>
              

		 <div class="tab-grids">
		
             	
			
                  
             
             	 <div id="tab51" class="tab-grid51">









         <div class="content cover text-center">
              <div class="heading">
                <h2>Reset Password</h2>
                
               
              </div>
               <div class="row">
            <span id="Span2"></span><!-- remove #message to stop floating jQuery messages -->
            
          <%--  <form target="#" name="contact">--%>
                <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">
                
                    
                    
                     <span class="input-group">
                            <%--<i class="fa fa-lock"></i>--%>
                 	 <asp:TextBox ID="txtpasswordsignup" class="lg" placeholder="Password" runat="server" MaxLength="10" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="red"  runat="server" ControlToValidate="txtpasswordsignup" ValidationGroup="2" ErrorMessage="please enter your Password"></asp:RequiredFieldValidator>
                    </span><!-- .input-group -->
                    
                     <span class="input-group">
                         <%--<i class="fa fa-refresh"></i>--%>
                 	 <asp:TextBox ID="txtconfirmpasswordsignup" class="lg" placeholder="Retype Password" MaxLength="10" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="red" runat="server" ControlToValidate="txtconfirmpasswordsignup" ValidationGroup="2" ErrorMessage="please retype the Password"></asp:RequiredFieldValidator>
                    <asp:CompareValidator id="comparePasswords" runat="server" ForeColor="red" ControlToCompare="txtpasswordsignup" ControlToValidate="txtconfirmpasswordsignup" ErrorMessage="Your passwords do not match up!" Display="Dynamic" />
							                     </span><!-- .input-group -->
                    
                        

                        </div>
                 <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;">
                     <span class="input-group">
                            <%--<i class="fa fa-lock"></i>--%>
                 	   <asp:Button ID="btnchangePassword" CssClass="btn1" runat="server" ValidationGroup="2" Text="change Password"/>
                    </span><!-- .input-group -->


                 
                    
                </div><!-- .col-5 -->
                
                <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;">

              <br />
                    <br />
                    <br />
                    

                    <span class="input-group">
                     
                    
                    </span>
                </div>
         
            </div>
                              </div>


</div></div></div></div></section>
        






           
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
          
						
	
            

      
          </form>
            
  </body>
</html>
