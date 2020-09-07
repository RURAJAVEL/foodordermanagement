<%@ Page Language="vb" AutoEventWireup="FALSE" CodeBehind="BlueBerritRestaurantMenu.aspx.vb" Inherits="BlueBerrit.BlueBerritRestaurantMenu" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
    <title>BLUEBERRIT RESTAURANTS | BlueberrIT _ Food Delivery _ Order Food Online _ Catering Service</title>
   <%--   <link rel="stylesheet" href="https://blueberrit/assets/font/font1.css">--%>
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <!-- FancyBox -->
	<%--<link href="assets/css/fancybox/jquery.fancybox.css" rel="stylesheet">--%>
    <link rel="stylesheet" href="assets/css/style2.css"> 
    <link rel="stylesheet" href="assets/css/animate.min.css">
    <link rel="stylesheet" href="assets/css/font-awesome.min.css">
   

    
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<%--  <link href='https://blueberrit/assets/font/font2.css' rel='stylesheet' type='text/css'>--%>
<%--  <link href='https://blueberrit/assets/font/font3.css' rel='stylesheet' type='text/css'>--%>
<link rel="stylesheet" type="text/css" href="css/component.css" />

<script src="js/jquery.min.js"></script>
<script src="js/simpleCart.min.js"> </script>


  





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
       


    <style type="text/css">
   
    .modalPopup
    {
        background-color: #FFFFFF;
      width:40%;
        border: 0.5px solid black;
    }
  
</style>

      <script>
          window.onload = function () {
              document.getElementById('home').style.height = 418 + "px";
          }
        
	</script>




    


      

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
             
                
                 
             
            
             <li id="signup">
                            <a href="">HOME</a>
                        </li>
             
            </ul>


          </div>
            
        </div>
      </nav>
    </div>



            <div id="submenu" hidden>
     
      <a href="index.aspx"> BACK </a> &nbsp; 
        
    </div>


        
           

         

     <section id="homed" class="page" >
      <div class="container text-center"> 
        
               <div class="tab-grids">
      
           
            	
                      <div class="about-grids">
			 <div class="col-xs-12 about-grid">	
							
							
                	
		<asp:image runat="server" ID="ImgsingleAnimImag" class="img-responsive2"     ImageUrl="~/UIimages/restaurantprofile/01010101/01010101.jpg"   />
		
                 </div></div>
                



          </div>
          
        
      </div>
    </section>
    



    <section id="about" class="page space">
      <div class="container text-center"> 
         

        
   
        

            
                  <div class="tab-grids">
    
    	
			  
 <ol class="breadcrumb" >
		  <li>
						<asp:Label ID="lblRestaurantName" runat="server" />

		  </li>
		  
		 </ol>
   
		

         <asp:Repeater ID="RepeaterImagestab1" runat="server" >
    <ItemTemplate >
    

    
       



<%--<div class="product-main"  >
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				
                 
                  <div class="single-page" >	--%>				 
						
                      <div class="about-grids">
			 <div class="col-xs-6 about-grid">	
							
								<asp:image runat="server" ID="ImgsingleAnimImag" class="img-responsive1"  max-height="477px"   ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
								
						
					<%-- <div class="details-left-info">--%>
						<p>	<asp:Label ID="lblRestaurantLoc" Visible="false" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label></p>
								
                       <h5>  <asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label>						</h5>
						<%--	<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>--%>
							
							
							<%--<div class="flower-type">--%>
                                <p style="min-height:150px;" ><asp:Label ID="lbldescription"  Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
						<%--<p>Category  ::	<a href="#"><asp:Label ID="lblcategory"  Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a></p>--%>
							
                                		<%--<p>Contains  ::<a href="#"><asp:Label ID="lblcontains" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></a></p>--%>
						<%--	</div>--%>
						
							
					<%-- </div>--%>


                 </div></div>

					<%-- <div class="clearfix"></div>				 	
				 </div>


			 </div>
		 </div>		 
		 <div class="clearfix"></div>
		 	
	 </div>
</div>--%>




                </ItemTemplate></asp:Repeater>
                      
                      
                      
                      
                      
                        </div>

            
   



          

               
    </div>
       
  


         






   
    	   
    </section>



      


            <section id="koUnableToProcess" class="content-section form contact light space">
            <asp:HiddenField ID="hidForModelunable" runat="server" />
               <cc1:ModalPopupExtender ID="mp2" runat="server" PopupControlID="Panel2" TargetControlID="hidForModelunable"  BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel2" runat="server" CssClass="modalPopup" align="center" style = "display:none">
      
     <div class="header">
                            Notification
                        </div>
                        <div class="body">
                            <asp:Label ID="lblunabletoProcess"  runat="server" />
                        </div>
                        <div class="footer" >
                       
                            <asp:Button ID="BtnUnableNo" runat="server" Text="Close" CssClass="yes" />
                        </div>

</asp:Panel>

          </section>

           <asp:HiddenField ID="HiddenField1" runat="server" />
               <cc1:ModalPopupExtender ID="mp3" runat="server" PopupControlID="PanelActivation" TargetControlID="HiddenField1"  BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="PanelActivation" runat="server" CssClass="modalPopup" align="center" style = "display:none">
        <%--<section id="koUnableToProcessRed" class="content-section form contact light space">--%>
     <div class="header">
                            Notification
                        </div>
                        <div class="body">
                            <asp:Label ID="lblredirect"  runat="server" />
                        </div>
                        <div class="footer" >
                       
                            <asp:Button ID="BtnRedirect" runat="server" Text="OK" CssClass="yes" />
                        </div>
            <%-- </section>--%>
</asp:Panel>





      <asp:ScriptManager ID="scriptmanage" runat="server" />



           
   




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
            
<script type="text/javascript">
    $(document).ready(function () {
        $('#signup').click(function (event) {

            $('#submenu').toggle(1000);

        });
    });
    </script>
      
          </form>
            
  </body>
</html>
