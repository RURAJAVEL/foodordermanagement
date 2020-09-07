<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BlueBerritJobs.aspx.vb" Inherits="BlueBerrit.BlueBerritJobs" %>

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
    <title>BLUEBERRIT JOBS | BlueberrIT</title>
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

     <%-- <script>
          window.onload = function () {
              document.getElementById('home').style.height = 418 + "px";
          }
        
	</script>--%>




    


      

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



           <%-- <div id="submenu" hidden>
     
      <a href="index.aspx"> BACK </a> &nbsp; 
        
    </div>--%>


        
           

         

     <section id="homee" class="page" >
      <div class="container text-center"> 
        
           <div class="tabs-box" >
               
               
               <div class="tab-grids">
         
                   <div class="product-main">
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">		



            	
                     <%-- <div class="about-grids">
			 <div class="col-xs-12 about-grid">	--%>
		
                 
                 	 <div class="details-left-infojob">				
							
        <h5> <span style="color: #0078c1"> Jobs </span> </h5>        	
		<p>BlueberrIT is now spicing up the next generation lunch experience for people working in offices. We believe lunch should be convenient, on demand and 
        <br />    at the same time delicious. BlueberrIT sources food from the best restaurants in cities and provides simplicity of SMS ordering to our users. </p>
               
            <p>At BlueberrIT, you will be amongst a team of Sales Managers who are building local restaurant communities, helping them to increase their revenues,<br /> Online Operation Managers who dominate customer service, Vendor Relationship Managers who ensure delicious food to delight our users and  Software Developers  <br /> who are scaling our distributed food delivery model. </p>     
                
                 
                 <p>Being a food lover is not only a prerequisite, but a requirement for any position at BlueberrIT. We are here to make lunch a better experience for everyone. Join us and be a part of the excitement. </p>
                  

                 <p>We are hiring across all divisions. Please expand the following positions for more details. If you think BlueberrIT is the next thing that you want to do, we would love to hear from you. Drop us a line at jobs@BlueberrIT.com</p>




                <%--category1--%>

 <br />
                 
                 <h5> <span style="color: #0078c1"> Business Development </span></h5>
                 
                 

                 <%--category1 job1--%>

</div></div></div></div></div></div></div>

              

                   <ol class="breadcrumb" >
		  <li>
						<a style="color:black;">	<asp:Label ID="lblRestaurantnameMonday" Text= "Business Development manager - Restaurants" data-toggle="collapse" data-target="#job1"  runat="server" > </asp:Label></a>

		  </li>
		  
		 </ol>


                <div id="job1" class="collapse" >  
                  <div class="tab-grids">
         
                   <div class="product-main">
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">	
 <div class="details-left-infojob">			
                 <p>Restaurants are everything to BlueberrIT. It is your job to identify perfect BlueberrIT restaurants, convince them to be on the platform, and ensure they are executing at the highest level. You have the ability to walk into any restaurant and onboard them within seconds of pitching BlueberrIT. Once the deal is done, you will expedite the onboarding and training process to ensure their success. Ongoing responsibilities include tasting food, communicating customer feedback, solving packaging problems, and nurturing the relationship with each of our restaurants. Your success in this role will bring more of the city's best restaurants to our users. </p>

                 <h5> <span style="color: #0078c1"> Responsibilities </span> </h5>

                
                     <ul>
                         <li>Strategically target restaurants and cuisine types that round out our offering.</li>
                         <li>Use extensive knowledge of the BlueberrIT product to onboard quality restaurants to the BlueberrIT platform weekly.</li>
                         <li>Work with vendors to create BlueberrIT-specific meals.</li>
                         <li>Take pictures of the meals and upload accurate details of the dishes to the BlueberrIT system.</li>
                         <li>Provide feedback to vendors about daily meals and logistics.</li>
                         <li>Maintain healthy relationships through community, communication, and trust.</li>
                         <li>Strategize and implement solutions to delivery problems to minimize operations errors. </li>

                     </ul>
                 


                 <h5> <span style="color: #0078c1"> Requirements </span> </h5>

                  
                 <ul>
                     <li> Food lover is a must</li>
                     <li>Charismatic and genuine personality that easily builds relationship</li>
                     <li>Excellent written and verbal communications skills</li>
                     <li>Detail-oriented</li>
                     <li>Passionate about growing the local restaurant community</li>
                     <li>Vendor/Account management experience preferred</li>
                     <li>Sales experience</li>
                     <li>Strong local restaurant network preferred</li>
                     <li>Bachelors degree</li>
                 </ul>


                 
                


               <h5>  <span style="color: #0078c1">Apply:</span>Write to us at <a  style="color:#0078c1;"  href="mailto:jobs@blueberrit.com" >jobs@blueberrit.com</a>  </h5>


 



     </div></div></div></div></div></div></div>
               </div>
               
               
                 <%--category1 job2--%>

              
 

                  <ol class="breadcrumb" >
		  <li>
					<a style="color:black;">		<asp:Label ID="Label2" Text= "Catering Business Development manager" data-toggle="collapse" data-target="#job2"  runat="server" > </asp:Label></a>

		  </li>
		  
		 </ol>
                <div id="job2" class="collapse" >  
                <div class="tab-grids">
         
                   <div class="product-main">
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">
     <div class="details-left-infojob">			
                 <p>As the Catering BD intern, you will be leading the charge on building and growing the catering side of our business in San Diego.  </p>

                 <h5> <span style="color: #0078c1"> Responsibilities </span> </h5>

                
                     <ul>
                         <li>Leverage existing relationships and build new ones to sell catering business with companies throughout San Diego.</li>
                         <li>Work with clients and restaurants to guarantee smooth execution of catering operations.</li>
                         <li>Work collaboratively with the BlueberrIT Operations Team and the Catering Team in Seattle and serve as the voice of the catering client.</li>
                         <li>Identify and communicate tech improvements that support catering.</li>
                         <li>Natural extrovert who loves building their network and communicates easily and professionally.</li>
                         <li>Innovative and obsessive problem solver who finds ways around every obstacle.</li>
                         <li>Excellent written communications. </li>
                         <li>Ability to set and hit sales goals. </li>
                     </ul>
                 




                 <h5> <span style="color: #0078c1"> Requirements </span> </h5>

                  
                 <ul>
                     <li>  Sales / Account management experience preferred</li>
                     <li>Bachelors degree preferred</li>
                     <li>Full-time availability with a serious interest in a permanent role in the near future </li>
                   
                 </ul>




                 


                 
                


               <h5>  <span style="color: #0078c1">Apply:</span>Write to us at <a  style="color:#0078c1;"  href="mailto:jobs@blueberrit.com" >jobs@blueberrit.com</a>  </h5>

















                 <%--category2--%>


        <br /><br />

                  



                 <%--category2 job1--%>
         </div></div></div></div></div></div></div>
</div>

                 <div class="tab-grids">
         
                   <div class="product-main">
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">
<div class="details-left-infojob">	
                <h5> <span style="color: #0078c1">Delivery</span></h5>
               </div></div></div></div></div></div></div>
                  <ol class="breadcrumb" >
		  <li>
						<a style="color:black;">		<asp:Label ID="Label1" Text= "Contract Delivery Driver" data-toggle="collapse" data-target="#job3"  runat="server" > </asp:Label> </a>

		  </li>
		  
		 </ol>

               <div id="job3" class="collapse" > 
               <div class="tab-grids">
         
                   <div class="product-main">
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">
<div class="details-left-infojob">			
                 <p>We are looking for a small team of part-time drivers to help us grow our business. There will be plenty of opportunities and incentives to earn more per delivery for successful drivers. Perfect for Uber/Lyft/Sidecar drivers that want a guaranteed wage in a 45 minute window. </p>

                 <h5> <span style="color: #0078c1"> Responsibilities  </span></h5>

                
                     <ul>
                         <li>Pick up pre-scheduled lunches from one restaurant and deliver them to Seattle companies within a consistent timeframe. The pickup will always be at 11:30am and delivery will end at 12:15pm. </li>
                        

                     </ul>
                 


                 <h5> <span style="color: #0078c1">Requirements </span> </h5>

                  
                 <ul>
                     <li> Be available for lunchtime deliveries Monday to Friday</li>
                     <li>Use a reliable smartphone</li>
                     <li>Have strong attention to detail</li>
                     <li>Internally Motivated</li>
                     <li>Punctual</li>
                     <li>Friendly</li>
                   
                 </ul>

                  




 
                 
                


               <h5>  <span style="color: #0078c1">Apply:</span>Write to us at <a  style="color:#0078c1;"  href="mailto:jobs@blueberrit.com" >jobs@blueberrit.com</a>  </h5>















                  


                 
                 
                 
                   </div>


		<%--	 </div></div> --%>


				 </div></div></div></div></div>
                



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

