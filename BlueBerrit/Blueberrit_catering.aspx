<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Blueberrit_catering.aspx.vb" Inherits="BlueBerrit.Blueberrit_catering" %>

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
    <title>CATERING SERVICE | BlueberrIT _ Food Delivery _ Order Food Online _ Catering Service</title>
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

   


       <script type="text/javascript">
           $(document).ready(function() {

               $("#txttotalCatering").keyup(function () {
                   
                   if ($("#txttotalCatering").val() >= 100) {
                       document.getElementById("txttotalCatering").value = "100";
                       
                   }
               });
           })
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
             
                
                    <li>
                <a href="index.aspx#worka">Today</a>
              </li>
             
              <li>
                <a href="index.aspx#about">This Week</a>
              </li>
                 
             
            
             <li id="signup">
                            <a href="index.aspx">HOME</a>
                        </li>
             
            </ul>


          </div>
            
        </div>
      </nav>
    </div>



      <%--part 1--%>

           <asp:ScriptManager id="srm1" runat="server" />

     <section id="homee" class="page" >
      <div class="container text-center"> 
        
           <div class="tabs-box" >
               
               
               <div class="tab-grids">
         
                   <div class="product-main">
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">		



                 	 <div class="details-left-infojob" >				
							
       <h5> <span style="color: #0078c1;">About BlueberIT Catering  </span> </h5>        	
		
                       
                    <p>
                        Catering BlueberrIT is a Indian based boutique catering company that was founded in 2015 . 
                    </p>
                    
                    <p>
                        Catering BlueberrIT specialises in weddings and special event functions for guests of up to 100 and will only take on one wedding a weekend in Indian to ensure that every function gets the full attention it deserves.  We also understand that seeing (or tasting) is believing which is why we always encourage anyone wanting a catering function to meet Antoinette at the Paddington Deli to not only talk through and fine tune the event and catering but to sample first hand some of the catering options available.    
                    </p>
               

                            <p>
                        Whatever your occasion you will need a catering company that can provide you with worry-free exceptional quality catering. At Catering BlueberrIT all of our menus and catering services are specifically tailored to meet our clients themes and outcomes. We offer a range of seasonal food options and take pride in fresh and flavorful foods making for an unforgettable evening     
                    </p>

                
                 




                          
</div></div></div></div></div></div></div>

              

               
          
        </div>
      </div>



    </section>



          <%--part 2--%>

        

          <section id="contact" class="content-section form contact light space" style="background-color:#eee;">
      <div class="container"> 
        
           <div class="tabs-box" >
               
               
               <div class="tab-grids">
          <div id="tab51" class="tab-grid51">
              <div class="content cover text-center">
                   <div class="row">
	

                        

         <div class="large-12 columns">

                        <h2 class="clearfix">
                            get started
                        </h2>

                        <p class="ng-binding" >fill out the form below and we'll be in touch shortly to help with your catering needs.</p>

                        <hr style="border-color:#0078c1;">

                    </div>




                     <div class="col-lg-12 anim fadeInLeft animated" style="visibility: visible;">

                          <span class="input-group">
                      
                          <asp:DropDownList ID="ddcitycatering"  Width="50%"   CssClass="dd" runat="server" /> 
                       <asp:RequiredFieldValidator id="reqFavoriteColor" ValidationGroup="2" ErrorMessage="Select City"  ForeColor="red" InitialValue="SELECT" ControlToValidate="ddcitycatering" Runat="server" ></asp:RequiredFieldValidator>
                    </span><!-- .input-group -->

                         </div>

                     
                       <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">
              
                        
                          
                   
                    
               
                        <span class="input-group">
                     
                         <asp:TextBox ID="txtnamecatering" Enabled="true" AutoComplete="off" class="lg" placeholder="Name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv" runat="server" ForeColor="red" ControlToValidate="txtnamecatering" ValidationGroup="2" ErrorMessage="please enter your Name"></asp:RequiredFieldValidator>
                   
                        
                          </span><!-- .input-group -->
                    
                   	<span class="input-group">
                      
                            <asp:TextBox ID="txtemailcatering" AutoComplete="off" class="lg" placeholder="Email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="red" runat="server" ControlToValidate="txtemailcatering" ValidationGroup="2" ErrorMessage="Please enter Email"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="erremailval" runat="server" ForeColor="red" ControlToValidate = "txtemailcatering" ValidationGroup="2" ValidationExpression= "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please enter valid email address"></asp:RegularExpressionValidator> 
                          
                            
                    </span><!-- .input-group -->

                         

                              <span class="input-group">
                     
                      
                            <asp:TextBox ID="txtDatecatering" class="lg" placeholder="Event Date" AutoComplete="off" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator ID="rqvdate" runat="server" ControlToValidate="txtDatecatering" forecolor="Red" ErrorMessage="Enter Event Date" ValidationGroup="2" ></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="regdate" runat="server" ForeColor="Blue" ErrorMessage="Invalid" ControlToValidate="txtDatecatering" ValidationGroup="2" ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$"></asp:RegularExpressionValidator>
                
                       
                    </span>

    
                  
                </div><!-- .col-5 -->
                
                


                <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;">

                       <span class="input-group">
                        <%--<i class="fa fa-user"></i>--%>
                          
                        <asp:TextBox ID="txtofficecatering" AutoComplete="off" class="lg" placeholder="office Name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ForeColor="red" ControlToValidate="txtofficecatering" ValidationGroup="2" ErrorMessage="please enter your Name"></asp:RequiredFieldValidator>

                        
                    </span>


                    

               



                       <span class="input-group">
                            <i ></i>
           <asp:TextBox ID="txtmobilecatering" class="lg" placeholder="Mobile" AutoComplete="off" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator runat="server" ID="errmobile" ForeColor="red" ControlToValidate="txtmobilecatering" ValidationGroup="2" ErrorMessage="please enter mobileno" />
                          <asp:RegularExpressionValidator ID="errmobileval" ForeColor="red" runat="server" ErrorMessage="Phone Number is not valid" validationGroup="2" ControlToValidate="txtmobilecatering" ValidationExpression="^(1\s*[-\/\.]?)?(\((\d{3})\)|(\d{3}))\s*[-\/\.]?\s*(\d{3})\s*[-\/\.]?\s*(\d{4})\s*(([xX]|[eE][xX][tT])\.?\s*(\d+))*$"></asp:RegularExpressionValidator>
                    </span>
               
                     <span class="input-group" style="text-align:LEFT;">
                            <i ></i>
                 

                           <asp:TextBox ID="txttotalCatering"     AutoComplete="off" class="lg" placeholder="# of people MAX(100)" runat="server"></asp:TextBox>
                          <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator0" ForeColor="red"  ControlToValidate="txttotalCatering"  ValidationGroup="2" ErrorMessage="please enter quantity" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator0" runat="server" ErrorMessage="Must be greater than 0" ControlToValidate="txttotalCatering" ValidationExpression="^[1-9][0-9]*$"  ForeColor="red" ValidationGroup="2" />


                    </span><!-- .input-group -->
                    
                  
                       <span class="input-group">
                        <asp:Button ID="btnsubmitCatering"   CssClass="btn2" BackColor="#0078c1" runat="server" ValidationGroup="2" Text="SUBMIT"/>
                    
                    </span><!-- .input-group -->

                
                </div>
                 
                

 







</div></div></div></div></div></div></section>

















          <%--part 3--%>



    <section id="homeed" class="page" >
<div class="about-grids">
			 <div class="col-md-3 about-grid">
							
								<asp:image runat="server" ID="ImgsingleAnimImag" class="img-responsive1"  style="min-height:275px"   ImageUrl= "~/assets/img/catering/1.jpg"   />
								
				
                 </div></div>
          <div class="about-grids">
			 <div class="col-md-3 about-grid">
							
								<asp:image runat="server" ID="Image1" class="img-responsive1"  style="min-height:275px"   ImageUrl= "~/assets/img/catering/2.jpg"   />
								
				
                 </div></div>
          <div class="about-grids">
			 <div class="col-md-3 about-grid">
							
								<asp:image runat="server" ID="Image2" class="img-responsive1"  style="min-height:275px"   ImageUrl= "~/assets/img/catering/3.jpg"   />
								
				
                 </div></div>
          <div class="about-grids">
			 <div class="col-md-3 about-grid">
							
									<asp:image runat="server" ID="Image3" class="img-responsive1"  style="min-height:275px"   ImageUrl= "~/assets/img/catering/4.jpg"   />
								
				
                 </div></div>
 
      </section>   

 <section id="homeer" class="page" >

      <div class="container text-center"> 
        
           <div class="tabs-box" >
               
               
               <div class="tab-grids">
         
                   <div class="product-main">
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">	


<div class="about-grids">
			 <div class="col-md-12 about-grid">
							


                    <ol class="breadcrumb" >
		  <li>
						<a style="color:black;">	<asp:Label ID="lblRestaurantnameMonday" Text= "tailoring themes and menus for clients" data-toggle="collapse" data-target="#job1"  runat="server" > </asp:Label></a>

		  </li>
		  
		 </ol>
								
								
				
                 </div></div>
</div></div></div></div></div></div></div></div>
           </section>





           <section id="homeeA" class="page" >



                 <div class="container text-center"> 
        
           <div class="tabs-box" >
               
               
               <div class="tab-grids">
         
                   <div class="product-main">
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">		


<div class="about-grids">
			 <div class="col-md-4 about-grid">
							
								<asp:image runat="server" ID="Image4" class="img-responsive1"  style="min-height:275px"   ImageUrl= "~/assets/img/ct/1.jpg"   />
								
                   <asp:button ID="btncorporatecatering"   runat="server"  text="CORPORATE CATERING" BackColor="#0078c1" CssClass="btn1"  ></asp:button>
				
                 </div></div>
          <div class="about-grids">
			 <div class="col-md-4 about-grid">
							
								<asp:image runat="server" ID="Image5" class="img-responsive1"  style="min-height:275px"   ImageUrl= "~/assets/img/ct/2.jpg"   />
								 <asp:button ID="btnprivatecatering"   runat="server"  text="PRIVATE CATERING" BackColor="#0078c1" CssClass="btn1"  ></asp:button>
				
                 </div></div>
          <div class="about-grids">
			 <div class="col-md-4 about-grid">
							
								<asp:image runat="server" ID="Image6" class="img-responsive1"  style="min-height:275px"   ImageUrl= "~/assets/img/ct/3.jpg"   />
								<asp:button ID="btnmarriagecatering"   runat="server"  text="MARRIAGE CATERING" BackColor="#0078c1" CssClass="btn1"  ></asp:button>
				
                 </div></div>
         
 </div></div></div></div></div></div></div></div>
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
    <%--<script src="assets/js/jquery.scrollTo.min.js"></script>--%>
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
            
<%--<script type="text/javascript">
    $(document).ready(function () {
        $('#signup').click(function (event) {

            $('#submenu').toggle(1000);

        });
    });
    </script>--%>
      
          </form>
            
  </body>
</html>
