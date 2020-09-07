<%@ Page Language="vb" AutoEventWireup="FALSE" CodeBehind="index.aspx.vb" Inherits="BlueBerrit.index" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>
<html lang="en-us">
  <head>
     <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="WebThemez">
   <meta http-equiv="Content|Type" content="text/html; charset=UTF|8" />
<meta name="title" content="Blueberrit | Food Delivery | Order Food Online ,Catering Services, india , U.S, U.K" />
<meta name="keywords" content="Blueberrit | Food Delivery | Order Food Online,Catering Services, india , U.S, U.K" />

<meta name="description" content="Blueberrit | Food Delivery | Order Food Online,Catering Services, india , U.S, U.K" />
    <title>BlueberrIT | Food Delivery | Order Food Online | Catering Service</title>
  
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
       <link rel="stylesheet" href="assets/css/style2.css"> 
    <link rel="stylesheet" href="assets/css/animate.min.css">
    <link rel="stylesheet" href="assets/css/font-awesome.min.css">
   
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
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
       
 <script type="text/javascript">
     var specialKeys = new Array();
     specialKeys.push(8); //Backspace
     function IsNumeric(e) {
         var keyCode = e.which ? e.which : e.keyCode
         var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
         //document.getElementById("error").style.display = ret ? "none" : "inline";
         return ret;
     }
    </script>

      <style type="text/css">
   
    .modalPopup
    {
        background-color: #FFFFFF;
      width:40%;
        border: 0.5px solid black;
    }
  
</style>

    <%--  <script>
          window.onload = function () {
              document.getElementById('home').style.height = 418 + "px";
          }
        
	</script>--%>


    
<link rel="stylesheet" href="fp/style.css">


    

       <link rel="stylesheet" href="txtslider/animate.min.css">
  <link rel="stylesheet" href="txtslider/liquid-slider.css">
   



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
                <a href="#worka">Today</a>
              </li>
             
              <li>
                <a href="#about">This Week</a>
              </li>
         

	<li  >
									<a href="#" id="loginButton"><span>Login</span></a>
						                <div id="loginBox"  >                
						                    <asp:panel runat="server" id="loginForm">
						                        <fieldset id="body">
						                            <fieldset>

						                               <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="white" runat="server" ControlToValidate="txtemaillogin" ValidationGroup="3"  ErrorMessage="Please enter Email"></asp:RequiredFieldValidator>
						                               <asp:TextBox ID="txtemaillogin"  placeholder="Email" AutoComplete="off" runat="server"></asp:TextBox>
                        
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="white" runat="server" ControlToValidate = "txtemaillogin" ValidationGroup="3"  ValidationExpression= "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please enter valid email address"></asp:RegularExpressionValidator>
						                            </fieldset>
						                            <fieldset>
						                               
						                              	 <asp:TextBox ID="txtpasswordlogin"  placeholder="Password"  runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ForeColor="white" runat="server" ControlToValidate="txtpasswordlogin" ValidationGroup="3" ErrorMessage="please enter your Password"></asp:RequiredFieldValidator>
						                            </fieldset>
						                             <asp:Button ID="btnsignin" CssClass="btn" runat="server"  BackColor="white" ValidationGroup="3" Text="SIGN IN!"/>
                  <p> <a href="forgotCredential.aspx"   style="color:white;text-align:center;" >Forgot Password?</a></p>

                                            <p>        <a href="#newaccount"   style="color:white;text-align:center;" >Create Account</a></p>
						                           </fieldset>
						                 
						                    </asp:panel>
						                </div>
						          
								   </li>
              


            </ul>
          </div>
            
        </div>
      </nav>
    </div>
          












      <div class="tagline homeversion">
<div class="foodswrapper">
<div class="foodburgerwrapper"><img class="animated fadeInUp twosecdelay preload" style="display:inline-block;max-width:100%;vertical-align:middle;"  src="fp/burger.png" alt=""></div>
<div class="foodpizzawrapper"><img class="animated fadeInDown threesecdelay preload" style="display:inline-block;max-width:100%;vertical-align:middle;" src="fp/pizza.png" alt=""></div>
</div>

<h3>Order from BlueBerrit<br>
in your office</h3>
</div>


<section id="catering" style="position: relative; top: 0px;background-color:#eee;"  >
      <div class="container text-center"> 
            <div class="heading">
           <h2 style="font-weight:normal;">For team lunches try BlueBerrit Catering   <a  href="Blueberrit_catering.aspx" class="btn2" >Learn More</a></h2> 
            
          
          </div>  

          </div></section>
        

  <section id="services" style="position: relative; top: 0px;" class="page"  >
      <div class="container text-center"> 
            <div class="heading">
           <h2>Who we are</h2>
            
            <p>BlueberrIT wants to deliver different flavors of food at your convenient location so you can focus on changing the world, your favorite restaurants and flavors can reach beyond your neighborhood to an entire city. We choose healthy food from your favorite local restaurants and drop it off at your convenient location. BlueberrIT pairs great food with great people for lunch and beyond.</p>
          </div>  
         <div class="row services-list">
					<div class="col-sm-6 col-md-3 text-center service animated fadeInUp visible" data-animation="fadeInUp">
						<div class=""> 
                            <img src="assets/img/work/2.png" alt=""/> 
						</div>
						<h4 class="color-white">1. Get Started</h4>
						<p></p>
					</div><!-- END COLUMN 3 -->
					<div class="col-sm-6 col-md-3 text-center service animated fadeInUp visible" data-animation="fadeInUp" data-animation-delay="200">
						<div class="">
							<img src="assets/img/work/3.png" alt=""/> 
						</div>
						<h4 class="color-white"> 2. Choose</h4>
						<p>Lunch of the day sent via SMS or MMS 9.30 A.M. </p>
					</div><!-- END COLUMN 3 -->
					<div class="col-sm-6 col-md-3 text-center service animated fadeInUp visible" data-animation="fadeInUp" data-animation-delay="400">
						<div class="">
							<img src="assets/img/work/4.png" alt=""/> 
						</div>
						<h4 class="color-white"> 3. Pay</h4>
						<p>Respond "yes" before it's too late 9.30 to 11.30 A.M.</p>
					</div><!-- END COLUMN 3 -->
					<div class="col-sm-6 col-md-3 text-center service animated fadeInUp visible" data-animation="fadeInUp" data-animation-delay="600">
						<div class="">
							<img src="assets/img/work/5.png" alt=""/> 
						</div>
						<h4 class="color-white"> 4. Enjoy</h4>
						<p>Lunch arrives by 12:30 at your office's front desk 12.00 to 12.30 P.M. </p>
					</div><!-- END COLUMN 3 -->
				</div>   
          
      </div>
    </section>


   
          


            <asp:HiddenField ID="HiddenField1" runat="server" />
               <cc1:ModalPopupExtender ID="mp3" runat="server" PopupControlID="PanelActivation" TargetControlID="HiddenField1"  BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="PanelActivation" runat="server" CssClass="modalPopup" align="center" style = "display:none">
      
     <div class="header">
                            Notification
                        </div>
                        <div class="body">
                            <asp:Label ID="lblredirect"  runat="server" />
                        </div>
                        <div class="footer" >
                       
                            <asp:Button ID="BtnRedirect" runat="server" Text="OK" CssClass="yes" />
                        </div>

</asp:Panel>

          










    <section id="worka" style="position: relative; top: 0px;background-color:#eee;" runat="server" class="page" >
      <div class="container text-center">
          <div class="heading">
            <h2>SHOWING CHENNAI'S SAMPLE TODAY LUNCH MENU</h2>
            
           
          </div>
     

                  <div class="tabs-box">

                 <div id="SundayclosedOrder"  runat="server">  
                     
                    <ul class="tabs-menu52"  > 
				<li id="litodayveg" runat="server" class="active"><a href="#tab54">VEG</a></li><li id="litodaynonveg"  runat="server"><a href="#tab55" >NON-VEG</a></li><li id="litodayLite" runat="server"><a href="#tab56">LITE</a></li>
			</ul>  </div>

			<div class="clearfix"> </div>

          <div class="tab-grids">
    
     <div id="todayvegnoorders" runat="server" class="tab-grid54" visible="false">
              <ol class="breadcrumb" >
		  <li >
						<asp:Label ID="lbltodayvegnoorders"    Visible="false" runat="server"  > </asp:Label>

		  </li>
		 
		 </ol>
         </div>
    
 <div id="tab54" runat="server" class="tab-grid54">	

       <ol class="breadcrumb">
		  <li>
						<asp:Label ID="lblRestaurantname" runat="server"  > </asp:Label>

		  </li>
		 
		 </ol>

<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
				
					
								
								
								<asp:image runat="server" ID="ImgsingleAnimImag" class="details-left-slider"    />
								
							
					 <div class="details-left-info">
								<p><asp:Label ID="lblRestaurantLoc" runat="server" > </asp:Label> </p>	
                       <h5>  <asp:Label ID="lblmenu" runat="server" > </asp:Label></h5>					
							<p>Rs. <asp:Label ID="lblprice" runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("MenuTax")%>'> </asp:Label> </a></p>
							
							<div class="btn_form">
								<a href="#newaccount" >SIGNUP / IN TO PROCEED</a>
							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" runat="server" > </asp:Label></p>
						<a href="#lblcategory"><asp:Label ID="lblcategory" Visible="false" runat="server" > </asp:Label></a>
						
						<p>Contains  ::<a href="#"><asp:Label ID="lblcontains" runat="server" > </asp:Label><asp:Label ID="Label3"  Visible="false" runat="server" > </asp:Label></a></p>
                                	</div>
						
							
					 </div>
					 <div class="clearfix"></div>				 	
				 </div></div></div><div class="clearfix"></div></div></div>




     


      <div class="container text-center"> 
          <div class="row">
            <div class="col-lg-12 animated hiding" data-animation="fadeInDown">
              <div id="testimonialsveg" class="carousel slide">
                <ol class="carousel-indicators">
                  <li data-target="#testimonialsveg" data-slide-to="0" class="active"></li>
                  <li data-target="#testimonialsveg" data-slide-to="1" class=""></li>
                  <li data-target="#testimonialsveg" data-slide-to="2" class=""></li>
                
                </ol>
                <div class="carousel-inner">
                  <div class="item active">
                    <p class="quote"><asp:Label ID="lbltodayvegReview1" runat="server" /></p>
                    <p class="client"><asp:Label ID="lbltodayvegUser1" runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lbltodayvegReview2" runat="server" /> </p>
                    <p class="client"><asp:Label ID="lbltodayvegUser2" runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lbltodayvegReview3" runat="server" /></p>
                    <p class="client"><asp:Label ID="lbltodayvegUser3" runat="server" /></p>
                  </div>
               
                </div>
              <%--  <a class="left carousel-control" data-slide="prev" href="#testimonialsveg">&lsaquo;</a>
                <a class="right carousel-control" data-slide="next" href="#testimonialsveg">&rsaquo;</a>--%>
              </div>
            </div>
          </div>      
      </div>



  <%--  </section>--%>





     </div>
<div id="tab55" runat="server" class="tab-grid55">	


   <ol class="breadcrumb" >
		  <li>
							 <asp:Label ID="lblRestaurantname2" runat="server"  > </asp:Label>

		  </li>
		  
		 </ol>

       

<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
						
								<asp:image runat="server" ID="ImgsingleAnimImag2" class="details-left-slider"  />
							
							
					 <div class="details-left-info">
							
								<p><asp:Label ID="lblRestaurantLoc2" runat="server" > </asp:Label> </p>	
                         <h5><asp:Label ID="lblmenu2" runat="server" > </asp:Label></h5>						
							<p>Rs. <asp:Label ID="lblprice2" runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax2" runat="server" Text= '<%# Eval("MenuTax")%>'> </asp:Label> </a></p>
						
                         <div class="btn_form">
								<a href="#newaccount">SIGNUP / IN TO PROCEED</a>
							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription2" runat="server" > </asp:Label></p>
						<a href="#"><asp:Label ID="lblcategory2" runat="server" Visible="false" > </asp:Label></a>
						
                                <p>Contains  ::<a href="#"><asp:Label ID="lblcontains2" runat="server" > </asp:Label><asp:Label ID="Label4"  Visible="false" runat="server" > </asp:Label></a></p>
							</div>
											
					 </div>
					 <div class="clearfix"></div>				 	
				 </div>
			 </div>
		 </div>		 
		 <div class="clearfix"></div>
		 	
	 </div>
</div>





    <div class="container text-center"> 
          <div class="row">
            <div class="col-lg-12 animated hiding" data-animation="fadeInDown">
              <div id="testimonialsnonveg" class="carousel slide">
                <ol class="carousel-indicators">
                  <li data-target="#testimonialsnonveg" data-slide-to="0" class="active"></li>
                  <li data-target="#testimonialsnonveg" data-slide-to="1" class=""></li>
                  <li data-target="#testimonialsnonveg" data-slide-to="2" class=""></li>
                
                </ol>
               <div class="carousel-inner">
                  <div class="item active">
                    <p class="quote"><asp:Label ID="lbltodaynonvegReview1" runat="server" /></p>
                    <p class="client"><asp:Label ID="lbltodaynonveguser1" runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lbltodaynonvegReview2" runat="server" /> </p>
                    <p class="client"><asp:Label ID="lbltodaynonveguser2" runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lbltodaynonvegReview3" runat="server" /></p>
                    <p class="client"><asp:Label ID="lbltodaynonveguser3" runat="server" /></p>
                  </div>
               
                </div>
              <%--  <a class="left carousel-control" data-slide="prev" href="#testimonialsnonveg">&lsaquo;</a>
                <a class="right carousel-control" data-slide="next" href="#testimonialsnonveg">&rsaquo;</a>--%>
              </div>
            </div>
          </div>      
      </div>







</div>
<div id="tab56" runat="server" class="tab-grid56">	

        
     <ol class="breadcrumb" >
		  <li>
							<asp:Label ID="lblRestaurantname3" runat="server"  > </asp:Label>

		  </li>
		  
		 </ol>



<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
					
								<asp:image runat="server" ID="ImgsingleAnimImag3" class="details-left-slider"  />
								
							
					 <div class="details-left-info">
							
								<p><asp:Label ID="lblRestaurantLoc3" runat="server" > </asp:Label> </p>	
                         		<h5>	<asp:Label ID="lblmenu3" runat="server" > </asp:Label></h5>			
							<p>Rs. <asp:Label ID="lblprice3" runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax3" runat="server" Text= '<%# Eval("MenuTax")%>'> </asp:Label> </a></p>
							
                         <div class="btn_form">
								<a href="#newaccount">SIGNUP / IN TO PROCEED</a>
							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription3" runat="server" > </asp:Label></p>
						<a href="#"><asp:Label ID="lblcategory3" Visible="false" runat="server" > </asp:Label></a>
						
                                  <p>Contains  ::<a href="#"><asp:Label ID="lblcontains3" runat="server" > </asp:Label><asp:Label ID="Label5"  Visible="false" runat="server" > </asp:Label></a></p>
							</div>
						
							
					 </div>
					 <div class="clearfix"></div>				 	
				 </div>
			 </div>
		 </div>		 
		 <div class="clearfix"></div>
		 	
	 </div>
</div>






    <div class="container text-center"> 
          <div class="row">
            <div class="col-lg-12 animated hiding" data-animation="fadeInDown">
              <div id="testimonialsLite" class="carousel slide">
                <ol class="carousel-indicators">
                  <li data-target="#testimonialsLite" data-slide-to="0" class="active"></li>
                  <li data-target="#testimonialsLite" data-slide-to="1" class=""></li>
                  <li data-target="#testimonialsLite" data-slide-to="2" class=""></li>
                
                </ol>
              <div class="carousel-inner">
                  <div class="item active">
                    <p class="quote"><asp:Label ID="lbltodayLiteReview1" runat="server" /></p>
                    <p class="client"><asp:Label ID="lbltodayLiteuser1" runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lbltodayLiteReview2" runat="server" /> </p>
                    <p class="client"><asp:Label ID="lbltodayLiteuser2" runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lbltodayLiteReview3" runat="server" /></p>
                    <p class="client"><asp:Label ID="lbltodayLiteuser3" runat="server" /></p>
                  </div>
               
                </div>
            <%--    <a class="left carousel-control" data-slide="prev" href="#testimonialsvegLite">&lsaquo;</a>
                <a class="right carousel-control" data-slide="next" href="#testimonialsvegLite">&rsaquo;</a>--%>
              </div>
            </div>
          </div>      
      </div>







</div>
          </div></div>







    <script>
        $(document).ready(function () {

         


            if ($('#tab54').length > 0) {
                $("#tab55").hide();
            }
            else {
                $("#litodaynonveg").addClass("active");
            }





            //$("#tab55").hide();
            $("#tab56").hide();
            $(".tabs-menu52 a").click(function (event) {
                event.preventDefault();
                var tab = $(this).attr("href");
                $(".tab-grid54,.tab-grid55,.tab-grid56").not(tab).css("display", "none");
                $(tab).fadeIn("slow");
            });
            $("ul.tabs-menu52 li a").click(function () {
                $(this).parent().addClass("active a");
                $(this).parent().siblings().removeClass("active a");
            });
        });



			</script>


            
      </div>
    </section>
    <section id="about" class="page" style="position: relative; top: 0px;background-color:white;">
      <div class="container text-center"> 
          <div class="heading">
            <h2> SHOWING CHENNAI'S SAMPLE THIS WEEK MENU</h2>
            
           
          </div>

        
   
           <div class="tabs-box" >



               <div id="main-slider" class="liquid-slider">
    <div>
      <h2 class="title" hidden>Monday</h2>
         <ul class="tabs-menu" >
				<li class="active" id="liMonveg" runat="server"><a href="#tab1">VEG</a></li><li  id="liMonNonveg" runat="server"><a href="#tab2">NON-VEG</a></li><li id="liMonLite" runat="server"><a href="#tab3">LITE</a></li>
			</ul>

               <div class="clearfix"></div>
                  <div class="tab-grids">
    
    	
			  

      <ol class="breadcrumb">
		  <li>
							<asp:Label ID="lblRestaurantnameMonday" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>
		

         <asp:Repeater ID="RepeaterImagestab1" runat="server" >
    <ItemTemplate >


   
        <div id='<%# Eval("lblcategoryy")%>'  class="<%# Eval("lblcategoryyy")%>">	

    
      <%--   <ol class="breadcrumb">
		  <li>
							<asp:Label ID="lblRestaurantname" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>--%>



<div class="product-main">
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
					
					
								<asp:image runat="server" ID="ImgsingleAnimImag" class="details-left-slider" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
								
							 
					 <div class="details-left-info">
						
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </p>	
                       <h5>  <asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label>						</h5>
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
						
                         <div class="btn_form">
								<a href="#newaccount">SIGNUP / IN TO PROCEED</a>
							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
						<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a>
						
                                		<p>Contains  ::<a href="#"><asp:Label ID="lblcontains" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></a></p>
							</div>
						
							
					 </div>
					 <div class="clearfix"></div>				 	
				 </div>
			 </div>
		 </div>		 
		 <div class="clearfix"></div>
		 	
	 </div>
</div>





              <div class="col-lg-12 animated hiding" data-animation="fadeInDown">
              <div id='<%# Eval("lblTestimonial")%>' class="carousel slide">
                <ol class="carousel-indicators">
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="0" class="active"></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="1" class=""></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="2" class=""></li>
                
                </ol>
           
                    <div class="carousel-inner">
                  <div class="item active">
                    <p class="quote"><asp:Label ID="lblmonday" Text='<%# Eval("lbl1")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser" Text='<%# Eval("lbl4")%>'  runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lblmonday2" Text='<%# Eval("lbl2")%>' runat="server" /> </p>
                    <p class="client"><asp:Label ID="lblmondayuser2" Text='<%# Eval("lbl5")%>' runat="server" /></p>
                  </div>
                  <div class="item"> 
                    <p class="quote"><asp:Label ID="lblmonday3" Text='<%# Eval("lbl3")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser3" Text='<%# Eval("lbl6")%>' runat="server" /></p>
                  </div>
                 
                </div>
         
              </div>
                 </div>






</div>

          <script>
              $(document).ready(function () {


                  if ($('#tab1').length > 0) {
                      $("#tab2").hide();
                  }
                  else {
                      $("#liMonNonveg").addClass("active");
                  }

                  $("#tab3").hide();
                  $(".tabs-menu a").click(function (event) {
                      event.preventDefault();
                      var tab = $(this).attr("href");
                      $(".tab-grid1,.tab-grid2,.tab-grid3").not(tab).css("display", "none");
                      $(tab).fadeIn("slow");
                  });
                  $("ul.tabs-menu li a").click(function () {
                      $(this).parent().addClass("active a");
                      $(this).parent().siblings().removeClass("active a");
                  });
              });



			</script>
                </ItemTemplate></asp:Repeater>
                        </div>
    </div>
    <div>
      <h2 class="title" hidden>Tuesday</h2>
    <ul class="tabs-menu1">
				<li class="active" id="liTueveg" runat="server" ><a href="#tab4">VEG</a></li><li id="liTueNonveg" runat="server"><a href="#tab5">NON-VEG</a></li><li id="liTueLite" runat="server"><a href="#tab6">LITE</a></li>
			</ul>


			<div class="clearfix"> </div>

          <div class="tab-grids">


                <ol class="breadcrumb">
		  <li>
							 <asp:Label ID="lblRestaurantnameTuesday"   runat="server" > </asp:Label>

		  </li>
		  
		 </ol>

    
    	<asp:Repeater ID="RepeaterImagestab2" runat="server">
    <ItemTemplate>
    
     <div id='<%# Eval("lblcategoryy")%>'  class="<%# Eval("lblcategoryyy")%>">	

        
       <%--  <ol class="breadcrumb">
		  <li>
							 <asp:Label ID="Label1" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>--%>

<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
				
					
								<asp:image runat="server" ID="ImgsingleAnimImag"  class="details-left-slider" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
							
					 <div class="details-left-info">
							
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </p>	
                         		<h5>	<asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label>		</h5>
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
						
                         	<div class="btn_form">
								<a href="#newaccount">SIGNUP / IN TO PROCEED</a>
							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
							<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a>
					
                                		<p>Contains  ::<a href="#"><asp:Label ID="lblcontains" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></a></p>
							</div>
						
							
					 </div>
					 <div class="clearfix"></div>				 	
				 </div>
			 </div>
		 </div>		 
		 <div class="clearfix"></div>
		 	
	 </div>
</div>




           <div class="col-lg-12 animated hiding" data-animation="fadeInDown">
              <div id='<%# Eval("lblTestimonial")%>' class="carousel slide">
                <ol class="carousel-indicators">
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="0" class="active"></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="1" class=""></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="2" class=""></li>
                
                </ol>
           
                    <div class="carousel-inner">
                  <div class="item active">
                    <p class="quote"><asp:Label ID="lblmonday" Text='<%# Eval("lbl1")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser" Text='<%# Eval("lbl4")%>'  runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lblmonday2" Text='<%# Eval("lbl2")%>' runat="server" /> </p>
                    <p class="client"><asp:Label ID="lblmondayuser2" Text='<%# Eval("lbl5")%>' runat="server" /></p>
                  </div>
                  <div class="item"> 
                    <p class="quote"><asp:Label ID="lblmonday3" Text='<%# Eval("lbl3")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser3" Text='<%# Eval("lbl6")%>' runat="server" /></p>
                  </div>
                 
                </div>
         
              </div>
                 </div>











</div>

          <script>
              $(document).ready(function () {

                  //var myElem = document.getElementById('tab4');
                  //if (myElem != null) {
                  //    $("liTueNonveg").addClass("active");
                  //    $("#tab5").hide();
                  //}


                  if ($('#tab4').length > 0) {
                      $("#tab5").hide();
                  }
                  else {
                      $("#liTueNonveg").addClass("active");
                  }




                  $("#tab6").hide();
                  $(".tabs-menu1 a").click(function (event) {
                      event.preventDefault();
                      var tab = $(this).attr("href");
                      $(".tab-grid4,.tab-grid5,.tab-grid6").not(tab).css("display", "none");
                      $(tab).fadeIn("slow");
                  });
                  $("ul.tabs-menu1 li a").click(function () {
                      $(this).parent().addClass("active a");
                      $(this).parent().siblings().removeClass("active a");
                  });
              });



			</script>
                </ItemTemplate></asp:Repeater>
                        </div>
    </div>          
    <div>
      <h2 class="title" hidden>Wednesday</h2>
      <ul class="tabs-menu2">
				<li class="active" id="liWedveg" runat="server" ><a href="#tab7">VEG</a></li><li id="liWedNonveg" runat="server" ><a href="#tab8">NON-VEG</a></li><li id="liWedLite" runat="server" ><a href="#tab9">LITE</a></li>
			</ul>


			<div class="clearfix"> </div>

          <div class="tab-grids">


                 <ol class="breadcrumb">
		  <li>
							 <asp:Label ID="lblRestaurantnameWednesday" Text= '<%# Eval("lblRestaurantnameWednesday")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>

    
    	<asp:Repeater ID="RepeaterImagestab3" runat="server">
    <ItemTemplate>
    
     <div id='<%# Eval("lblcategoryy")%>'  class="<%# Eval("lblcategoryyy")%>">	

        
      <%--   <ol class="breadcrumb">
		  <li>
							 <asp:Label ID="Label1" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>--%>

<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
					
								<asp:image runat="server" ID="ImgsingleAnimImag" class="details-left-slider" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
								
						
					 <div class="details-left-info">
							
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </p>	
                         			<h5><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>			
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
						
                         	<div class="btn_form">
							<a href="#newaccount">SIGNUP / IN TO PROCEED</a>
							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
					<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a>
			
                                		<p>Contains  ::<a href="#"><asp:Label ID="lblcontains" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></a></p>
							</div>
					
							
					 </div>
					 <div class="clearfix"></div>				 	
				 </div>
			 </div>
		 </div>		 
		 <div class="clearfix"></div>
		 	
	 </div>
</div>






           <div class="col-lg-12 animated hiding" data-animation="fadeInDown">
              <div id='<%# Eval("lblTestimonial")%>' class="carousel slide">
                <ol class="carousel-indicators">
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="0" class="active"></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="1" class=""></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="2" class=""></li>
                
                </ol>
           
                    <div class="carousel-inner">
                  <div class="item active">
                    <p class="quote"><asp:Label ID="lblmonday" Text='<%# Eval("lbl1")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser" Text='<%# Eval("lbl4")%>'  runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lblmonday2" Text='<%# Eval("lbl2")%>' runat="server" /> </p>
                    <p class="client"><asp:Label ID="lblmondayuser2" Text='<%# Eval("lbl5")%>' runat="server" /></p>
                  </div>
                  <div class="item"> 
                    <p class="quote"><asp:Label ID="lblmonday3" Text='<%# Eval("lbl3")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser3" Text='<%# Eval("lbl6")%>' runat="server" /></p>
                  </div>
                 
                </div>
         
              </div>
                 </div>




</div>

          <script>
              $(document).ready(function () {

                  if ($('#tab7').length > 0) {
                      $("#tab8").hide();
                  }
                  else {
                      $("#liWedNonveg").addClass("active");
                  }



                  $("#tab9").hide();
                  $(".tabs-menu2 a").click(function (event) {
                      event.preventDefault();
                      var tab = $(this).attr("href");
                      $(".tab-grid7,.tab-grid8,.tab-grid9").not(tab).css("display", "none");
                      $(tab).fadeIn("slow");
                  });
                  $("ul.tabs-menu2 li a").click(function () {
                      $(this).parent().addClass("active a");
                      $(this).parent().siblings().removeClass("active a");
                  });
              });



			</script>
                </ItemTemplate></asp:Repeater>
                        </div>
    </div>
    <div>
      <h2 class="title" hidden>Thursday</h2>
       <ul class="tabs-menu3">
				<li class="active" id="lithuveg" runat="server"><a href="#tab10">VEG</a></li><li id="lithuNonveg" runat="server"><a href="#tab11">NON-VEG</a></li><li id="lithuLite" runat="server"><a href="#tab12">LITE</a></li>
			</ul>


			<div class="clearfix"> </div>

          <div class="tab-grids">



                <ol class="breadcrumb">
		  <li>
							 <asp:Label ID="lblRestaurantnameThursday" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>



    
    	<asp:Repeater ID="RepeaterImagestab4" runat="server">
    <ItemTemplate>
    
     <div id='<%# Eval("lblcategoryy")%>'  class="<%# Eval("lblcategoryyy")%>">	

       
        <%-- <ol class="breadcrumb">
		  <li>
							 <asp:Label ID="Label1" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>--%>

<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
				
								<asp:image runat="server" ID="ImgsingleAnimImag" class="details-left-slider" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
								
							
					 <div class="details-left-info">
						
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </p>	
                         			<h5><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>			
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
							
                         	<div class="btn_form">
							<a href="#newaccount">SIGNUP / IN TO PROCEED</a>
							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
						<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a>
						
                                		<p>Contains  ::<a href="#"><asp:Label ID="lblcontains" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></a></p>
							</div>
					
							
					 </div>
					 <div class="clearfix"></div>				 	
				 </div>
			 </div>
		 </div>		 
		 <div class="clearfix"></div>
		 	
	 </div>
</div>





           <div class="col-lg-12 animated hiding" data-animation="fadeInDown">
              <div id='<%# Eval("lblTestimonial")%>' class="carousel slide">
                <ol class="carousel-indicators">
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="0" class="active"></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="1" class=""></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="2" class=""></li>
                
                </ol>
           
                    <div class="carousel-inner">
                  <div class="item active">
                    <p class="quote"><asp:Label ID="lblmonday" Text='<%# Eval("lbl1")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser" Text='<%# Eval("lbl4")%>'  runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lblmonday2" Text='<%# Eval("lbl2")%>' runat="server" /> </p>
                    <p class="client"><asp:Label ID="lblmondayuser2" Text='<%# Eval("lbl5")%>' runat="server" /></p>
                  </div>
                  <div class="item"> 
                    <p class="quote"><asp:Label ID="lblmonday3" Text='<%# Eval("lbl3")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser3" Text='<%# Eval("lbl6")%>' runat="server" /></p>
                  </div>
                 
                </div>
         
              </div>
                 </div>





</div>

           <script>
               $(document).ready(function () {
                   if ($('#tab10').length > 0) {
                       $("#tab11").hide();
                   }
                   else {
                       $("#lithuNonveg").addClass("active");
                   }
                   $("#tab12").hide();
                   $(".tabs-menu3 a").click(function (event) {
                       event.preventDefault();
                       var tab = $(this).attr("href");
                       $(".tab-grid10,.tab-grid11,.tab-grid12").not(tab).css("display", "none");
                       $(tab).fadeIn("slow");
                   });
                   $("ul.tabs-menu3 li a").click(function () {
                       $(this).parent().addClass("active a");
                       $(this).parent().siblings().removeClass("active a");
                   });
               });


               if ($('#tab7').length > 0) {
                   $("#tab8").hide();
               }
               else {
                   $("#liWedNonveg").addClass("active");
               }

















			</script>
                </ItemTemplate></asp:Repeater>
                        </div>
    </div>
                    <div>
      <h2 class="title" hidden>Friday</h2>
     <ul class="tabs-menu4">
				<li class="active" id="liFriveg" runat="server"><a href="#tab13">VEG</a></li><li id="liFriNonveg" runat="server"><a href="#tab14">NON-VEG</a></li><li id="liFriLite" runat="server"><a href="#tab15">LITE</a></li>

      </ul>

			<div class="clearfix"> </div>

          <div class="tab-grids">


                <ol class="breadcrumb">
		  <li>
						 <asp:Label ID="lblRestaurantnameFriday" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>

    
    	<asp:Repeater ID="RepeaterImagestab5" runat="server">
    <ItemTemplate>
    
     <div id='<%# Eval("lblcategoryy")%>'  class="<%# Eval("lblcategoryyy")%>">	

     
       <%--  <ol class="breadcrumb">
		  <li>
						 <asp:Label ID="Label1" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>--%>

<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
					
								<asp:image runat="server" ID="ImgsingleAnimImag" class="details-left-slider" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
								
							
					 <div class="details-left-info">
						
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </p>	
                         			<h5><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>			
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
						
                         	<div class="btn_form">
							<a href="#newaccount">SIGNUP / IN TO PROCEED</a>
							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
						<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a>
					
                                		<p>Contains  ::<a href="#"><asp:Label ID="lblcontains" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></a></p>
							</div>
						
							
					 </div>
					 <div class="clearfix"></div>				 	
				 </div>
			 </div>
		 </div>		 
		 <div class="clearfix"></div>
		 	
	 </div>
</div>





           <div class="col-lg-12 animated hiding" data-animation="fadeInDown">
              <div id='<%# Eval("lblTestimonial")%>' class="carousel slide">
                <ol class="carousel-indicators">
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="0" class="active"></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="1" class=""></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="2" class=""></li>
                
                </ol>
           
                    <div class="carousel-inner">
                  <div class="item active">
                    <p class="quote"><asp:Label ID="lblmonday" Text='<%# Eval("lbl1")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser" Text='<%# Eval("lbl4")%>'  runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lblmonday2" Text='<%# Eval("lbl2")%>' runat="server" /> </p>
                    <p class="client"><asp:Label ID="lblmondayuser2" Text='<%# Eval("lbl5")%>' runat="server" /></p>
                  </div>
                  <div class="item"> 
                    <p class="quote"><asp:Label ID="lblmonday3" Text='<%# Eval("lbl3")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser3" Text='<%# Eval("lbl6")%>' runat="server" /></p>
                  </div>
                 
                </div>
         
              </div>
                 </div>







</div>

          <script>
              $(document).ready(function () {

                  //var myElem = document.getElementById('tab13');
                  //if (myElem != null) {
                  //    $("liFriNonveg").addClass("active");
                  //    $("#tab14").hide();
                  //}


                  if ($('#tab13').length > 0) {
                      $("#tab14").hide();
                  }
                  else {
                      $("#liFriNonveg").addClass("active");
                  }



                  $("#tab14").hide();
                  $("#tab15").hide();
                  $(".tabs-menu4 a").click(function (event) {
                      event.preventDefault();
                      var tab = $(this).attr("href");
                      $(".tab-grid13,.tab-grid14,.tab-grid15").not(tab).css("display", "none");
                      $(tab).fadeIn("slow");
                  });
                  $("ul.tabs-menu4 li a").click(function () {
                      $(this).parent().addClass("active a");
                      $(this).parent().siblings().removeClass("active a");
                  });
              });



			</script>
                </ItemTemplate></asp:Repeater>
                        </div>
    </div>
                  
  
                   <div>
      <h2 class="title" hidden>Saturday</h2>
       <ul class="tabs-menu5" >
				<li class="active" id="lisatveg" runat="server"><a href="#tab16">VEG</a></li><li  id="lisatNonveg" runat="server" ><a href="#tab17"  >NON-VEG</a></li><li id="lisatLite" runat="server"><a href="#tab18" >LITE</a></li>
			</ul>


			<div class="clearfix"> </div>

          <div class="tab-grids" >



              <ol class="breadcrumb" >
		  <li>
						<asp:Label ID="lblRestaurantnameSaturday" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>

    
    	<asp:Repeater ID="RepeaterImagestab6" runat="server">
    <ItemTemplate>
    
     <div id='<%# Eval("lblcategoryy")%>'  class="<%# Eval("lblcategoryyy")%>" >	

       
        <%-- <ol class="breadcrumb" >
		  <li>
						<asp:Label ID="Label1" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>--%>

<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
				
								<asp:image runat="server" ID="ImgsingleAnimImag" class="details-left-slider" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
								
							
					 <div class="details-left-info">
						
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </p>	
                         		<h5><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>				
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
						
                         	<div class="btn_form">
							<a href="#newaccount">SIGNUP / IN TO PROCEED</a>
							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
					<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a>
					
                                		<p>Contains  ::<a href="#"><asp:Label ID="lblcontains" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></a></p>
							</div>
					
							
					 </div>
							 	
				 </div>
			 </div>
		 </div>		 
	
		 	
	 </div>
</div>





           <div class="col-lg-12 animated hiding" data-animation="fadeInDown">
              <div id='<%# Eval("lblTestimonial")%>' class="carousel slide">
                <ol class="carousel-indicators">
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="0" class="active"></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="1" class=""></li>
                  <li data-target='#<%# Eval("lblTestimonial")%>' data-slide-to="2" class=""></li>
                
                </ol>
           
                    <div class="carousel-inner">
                  <div class="item active">
                    <p class="quote"><asp:Label ID="lblmonday" Text='<%# Eval("lbl1")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser" Text='<%# Eval("lbl4")%>'  runat="server" /></p>
                  </div>
                  <div class="item">
                    <p class="quote"><asp:Label ID="lblmonday2" Text='<%# Eval("lbl2")%>' runat="server" /> </p>
                    <p class="client"><asp:Label ID="lblmondayuser2" Text='<%# Eval("lbl5")%>' runat="server" /></p>
                  </div>
                  <div class="item"> 
                    <p class="quote"><asp:Label ID="lblmonday3" Text='<%# Eval("lbl3")%>' runat="server" /></p>
                    <p class="client"><asp:Label ID="lblmondayuser3" Text='<%# Eval("lbl6")%>' runat="server" /></p>
                  </div>
                 
                </div>
         
              </div>
                 </div>





</div>

          <script>
              $(document).ready(function () {
                  if ($('#tab16').length > 0) {
                      $("#tab17").hide();
                  }
                  else {
                      $("#lisatNonveg").addClass("active");
                  }
                  $("#tab18").hide();




                  $(".tabs-menu5 a").click(function (event) {
                      event.preventDefault();
                      var tab = $(this).attr("href");
                      $(".tab-grid16,.tab-grid17,.tab-grid18").not(tab).css("display", "none");
                      $(tab).fadeIn("slow");





                  });
                  $("ul.tabs-menu5 li a").click(function () {
                      $(this).parent().addClass("active a");
                      $(this).parent().siblings().removeClass("active a");
                  });
              });




			</script>
                </ItemTemplate></asp:Repeater>
                        </div>
    </div>




                     <div style="background-image:url(images/gallery_bg_img.png);">
      <h2 class="title" hidden>Our Restaurants</h2>
                        

                      

  <div class="heading"  > <h3>We features some of Chennai's best restaurants</h3> 

         <br /><asp:Button ID="btnviewAllRestaurant" CssClass="btn2"  runat="server"   Text="view all restaurant"/>
        
		 </div>
    
              <div class="clearfix"></div>


   
        
           <div class="tabs-box"    >
               
               
               <div class="tab-grids">
         
                   <div class="product-main">
	 <div class="container" >
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">		
    
    
    
  
  
    <asp:Repeater ID="RepeaterImagestabRestaurant" runat="server"  OnItemCommand="rptList_ItemCommand">
    <ItemTemplate>
       
                     
                     <div class="about-grids">
			 <div class="col-md-3 about-grid">

              
                     <asp:image runat="server" ID="ImgsingleAnimImag" class="img-responsive" style="min-height:275px"   ImageUrl= '<%# Eval("ImgsingleAnimImag")%>'   />
            
                  <asp:button ID="btnlinkCancelCart"    runat="server" CssClass="btn1" BackColor="#0078c1"  Text= '<%# Eval("lblRestaurantname")%>' CommandArgument='<%# DataBinder.Eval(Container.DataItem, "lblRestaurantcode")%>' CommandName="ViewAll"  ></asp:button>
                                    
 

				 

			
                  
			 </div></div>
                  
                



                        
        
        </ItemTemplate>
        </asp:Repeater>
    




</div></div></div></div></div></div></div>








                         </div>





               
               </div>



  




    









    </div>
    </div>        
  

   
    	   
    </section>


          <%--cleared--%>
      
        <%--  <section  id="workB" runat="server" class="page" style="position: relative; top: 0px;background-color:white;" >


              
	 <div class="container text-center">
			
		 
     

            




	 </div>
          </section>--%>



            
            <asp:HiddenField ID="hidForModelunable" runat="server" />
               <cc1:ModalPopupExtender ID="mp2" runat="server" PopupControlID="Panel2" TargetControlID="hidForModelunable"  BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel2" runat="server" CssClass="modalPopup" align="center" style = "display:none">
     <%-- <section id="koUnableToProcess" class="content-section form contact light space">--%>
     <div class="header">
                            Notification
                        </div>
                        <div class="body">
                            <asp:Label ID="lblunabletoProcess"  runat="server" />
                        </div>
                        <div class="footer" >
                       
                            <asp:Button ID="BtnUnableNo" runat="server"   PostBackUrl="~/index.aspx#contact" Text="Close" CssClass="yes" />
                        </div>
<%--</section>--%>
</asp:Panel>

          






          








  <section id="newaccount" class="page" style="position: relative; top: 0px;background-color:white;" >
      <div class="container text-center"> 

           <div class="tabs-box">
			
			
                
                  <div class="clearfix"> </div>
                  <ul class="tabs-menu51">
				<li class="active" ><a href="#tab51"  >Signup</a></li><%--<li ><a href="#tab52">Login</a></li>--%><li><a href="#tab53">Enquiry</a></li>
          		</ul>

               </div>


          </div>
      </section>




    <section id="contact" style="position: relative; top: 0px;background-color:#eee;" class="content-section form contact light space" >
     
           

             <div class="container"> 
          
          
          
            
              <div class="tabs-box">
			
			
                
             



		 <div class="tab-grids">
		
             	
			
          
             
             	 <div id="tab51" class="tab-grid51">
        	  <div class="content cover text-center">
              <div class="heading">
                <h2>Create an Account</h2>
                
               <p>By creating an account with our BlueBerrIT.com, you will be able to order your lunch faster , Get it off at your convenient location,  view and track your orders in your account and more.</p><br /><br />
              </div>
                  <asp:ScriptManager ID="scriptmanage" runat="server" />
                  
               <div class="row">
            <span id="Span1"></span>
            
         

                <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">
              
                           <asp:UpdatePanel ID="updatepanelSignupLocation" runat="server" UpdateMode="always">
                        <ContentTemplate> 
                          
                    <span class="input-group">
                      
                          <asp:DropDownList ID="ddcitysignup" AutoPostBack="true"    CssClass="dd" runat="server" /> 
                       <asp:RequiredFieldValidator id="reqFavoriteColor" ValidationGroup="2" ErrorMessage="Select City"  ForeColor="red" InitialValue="SELECT" ControlToValidate="ddcitysignup" Runat="server" ></asp:RequiredFieldValidator>
                    </span><!-- .input-group -->
                    
               
                        <span class="input-group">
                     
                   
                     <asp:DropDownList ID="ddlLocation" AppendDataBoundItems="False" AutoPostBack="true" CssClass="dd" runat="server" /> 
                      
                        <asp:RequiredFieldValidator id="RequiredFieldValidator6" ValidationGroup="2" ControlToValidate="ddlLocation" ErrorMessage="Select Location"  ForeColor="red" InitialValue="SELECT"  Runat="server" ></asp:RequiredFieldValidator>
                        
                          </span><!-- .input-group -->
                    
                   	<span class="input-group">
                      
                          
                              <asp:DropDownList ID="ddcompanysignup" AppendDataBoundItems="False" AutoPostBack="true" CssClass="dd" runat="server" /> 
                       
                       <asp:RequiredFieldValidator id="RequiredFieldValidator10" ValidationGroup="2" ControlToValidate="ddcompanysignup" ErrorMessage="Select Company"  ForeColor="red" InitialValue="SELECT"  Runat="server" ></asp:RequiredFieldValidator>    
                            
                    </span><!-- .input-group -->

                         

                              <span class="input-group">
                     
                      
                             <asp:TextBox ID="txtdeliveryAddress" AutoComplete="off"  AutoPostBack="true" class="lg" Width="100%" placeholder="Delivery Address"  enabled="false" BackColor="white" TextMode="MultiLine"     runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="red" runat="server" ControlToValidate="txtdeliveryAddress" ValidationGroup="2" ErrorMessage="Please enter DeliveryAddress"></asp:RequiredFieldValidator>
                
                       
                    </span>

     </ContentTemplate></asp:UpdatePanel>




                       <span class="input-group">
                        <%--<i class="fa fa-envelope"></i>--%>
                      
                             <asp:TextBox ID="txtemailsignup" AutoComplete="off" class="lg" placeholder="Email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="red" runat="server" ControlToValidate="txtemailsignup" ValidationGroup="2" ErrorMessage="Please enter Email"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="erremailval" runat="server" ForeColor="red" ControlToValidate = "txtemailsignup" ValidationGroup="2" ValidationExpression= "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please enter valid email address"></asp:RegularExpressionValidator>
                       
                    </span><!-- .input-group -->


                     <span class="input-group">
                        <%--<i class="fa fa-mobile"></i>--%>
                         
 <asp:TextBox ID="txtmobilesignup" class="lg" placeholder="Mobile" AutoComplete="off" runat="server"></asp:TextBox>
                       <asp:RequiredFieldValidator runat="server" ID="errmobile" ForeColor="red" ControlToValidate="txtmobilesignup" ValidationGroup="2" ErrorMessage="please enter mobileno" />
                          <asp:RegularExpressionValidator ID="errmobileval" ForeColor="red" runat="server" ErrorMessage="Phone Number is not valid" validationGroup="2" ControlToValidate="txtmobilesignup" ValidationExpression="^(1\s*[-\/\.]?)?(\((\d{3})\)|(\d{3}))\s*[-\/\.]?\s*(\d{3})\s*[-\/\.]?\s*(\d{4})\s*(([xX]|[eE][xX][tT])\.?\s*(\d+))*$"></asp:RegularExpressionValidator>



                    </span>
                    	


                 
                  
                </div><!-- .col-5 -->
                
                


                <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;">

                       <span class="input-group">
                        <%--<i class="fa fa-user"></i>--%>
                          
                            <asp:TextBox ID="txtnamesignup" AutoComplete="off" class="lg" placeholder="Name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfv" runat="server" ForeColor="red" ControlToValidate="txtnamesignup" ValidationGroup="2" ErrorMessage="please enter your Name"></asp:RequiredFieldValidator>

                        
                    </span>


                    

               



                       <span class="input-group">
                            <i ></i>
               <asp:checkboxlist ID="lstInterested" ForeColor="black"  RepeatDirection="Horizontal"   ToolTip="I'm interested in" runat="server">
                         <asp:ListItem Text="veg" Value="0" />
                         <asp:ListItem Text="Nonveg" Value="1" />
                         <asp:ListItem Text="Lite" Value="2" />
                 	</asp:checkboxlist>
                    </span>
               
                     <span class="input-group" style="text-align:LEFT;">
                            <i ></i>
                 	<asp:CheckBox runat="server" ID="chkweeklynodification" Text="Email me weekly menu on sunday" ForeColor="black"  ></asp:CheckBox>
                    </span><!-- .input-group -->
                    
                     <span class="input-group" style="text-align:LEFT;">
                         <i ></i>
                 		<asp:CheckBox runat="server" ID="chkforOffers" Text="Email me about new features,discounts,I can advantage of ,and restaurant i love." ForeColor="black"  ></asp:CheckBox>
							                     </span><!-- .input-group -->







               
                     <span class="input-group">
                            <%--<i class="fa fa-lock"></i>--%>
                 	 <asp:TextBox ID="txtpasswordsignup" class="lg" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="red" runat="server" ControlToValidate="txtpasswordsignup" ValidationGroup="2" ErrorMessage="please enter your Password"></asp:RequiredFieldValidator>
                    </span><!-- .input-group -->
                    
                     <span class="input-group">
                         <%--<i class="fa fa-refresh"></i>--%>
                 	 <asp:TextBox ID="txtconfirmpasswordsignup" class="lg" placeholder="Retype Password" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="red" runat="server" ControlToValidate="txtconfirmpasswordsignup" ValidationGroup="2" ErrorMessage="please retype the Password"></asp:RequiredFieldValidator>
                    <asp:CompareValidator id="comparePasswords" runat="server" ForeColor="red" ControlToCompare="txtpasswordsignup" ControlToValidate="txtconfirmpasswordsignup" ErrorMessage="Your passwords do not match up!" Display="Dynamic" />
							                     </span><!-- .input-group -->


                    <span class="input-group">
                        <asp:Button ID="btnsignup" CssClass="btn2" runat="server"   ValidationGroup="2" Text="SIGN UP!"/>
                    
                    </span><!-- .input-group -->
                </div>
         
            
          </div>
             
                  </div>
                 </div>
                 
    <!-- .container signup -->



             
			 <div id="tab52" class="tab-grid52" hidden>
        	  <div class="content cover text-center">
              <div class="heading">
                <h2>Sign In</h2>
                
	
				<p>Welcome, please enter the following to continue.</p>
	
	
               
              </div>
               <div class="row">
            <span id="Span2"></span>
            
          <%--  <form target="#" name="contact">--%>
                <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">
                
                    
                    
                    <span class="input-group">
                        <i ></i>
                      <%-- <asp:TextBox ID="txtemaillogin" class="lg" placeholder="Email" AutoComplete="off" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="red" runat="server" ControlToValidate="txtemaillogin" ValidationGroup="3" ErrorMessage="Please enter Email"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="red" runat="server" ControlToValidate = "txtemaillogin" ValidationGroup="3" ValidationExpression= "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please enter valid email address"></asp:RegularExpressionValidator>--%>
                          </span><!-- .input-group -->
                    
                        
               
                     <span class="input-group">
                            <i ></i>
                 <%--	 <asp:TextBox ID="txtpasswordlogin" class="lg" placeholder="Password"  runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ForeColor="red" runat="server" ControlToValidate="txtpasswordlogin" ValidationGroup="3" ErrorMessage="please enter your Password"></asp:RequiredFieldValidator>--%>
                    </span><!-- .input-group -->


                 
                    
                </div><!-- .col-5 -->
                
                  

                <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;">

              <br />
                    <br />
                    <br />
                    

                    <span class="input-group">
                    <%--    <asp:Button ID="btnsignin" CssClass="btn1" runat="server" Width="50%" BackColor="#0078c1" ValidationGroup="3" Text="SIGN IN!"/>
                     <a href="forgotCredential.aspx"   style="color:Red;" >Forgot Password?</a>--%>
                        
                       

                    </span>
                </div>
         

                    


            </div>
                              </div>
                 </div>
    	<!-- .container signup -->


                 
			 <div id="tab53" class="tab-grid53">
        	  <div class="content cover text-center">
              <div class="heading">
                <h2 >Getting in touch</h2>
                
                  <p>We are working 24 x 7 to fulfill all your needs. To submit your Enquiries, Please fill this form<br/><br/></p>
              </div>
               
                  <div class="row">
            <span id="message"></span><!-- remove #message to stop floating jQuery messages -->
            
           <%-- <form target="#" name="contact">--%>
                     <%-- <asp:UpdatePanel ID="enquirypanel" runat="server" UpdateMode="always" ><ContentTemplate>--%>
                <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">
                
                   
                    <span class="input-group">
                        <%--<i class="fa fa-user"></i>--%>
                        
                        <asp:TextBox ID="txtnameenquiry"  AutoComplete="off" class="lg" placeholder="Name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtnameenquiry" ValidationGroup="0" ForeColor="Red" ErrorMessage="please enter your Name"></asp:RequiredFieldValidator>
                    </span><!-- .input-group -->
                    
                    <span class="input-group">
                        <%--<i class="fa fa-envelope"></i>--%>
                       <asp:TextBox ID="txtemailenquiry" AutoComplete="off" class="lg" placeholder="Email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtemailenquiry" ForeColor="Red" ValidationGroup="0" ErrorMessage="Please enter Email"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate = "txtemailenquiry" ForeColor="Red" ValidationGroup="0" ValidationExpression= "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please enter valid email address"></asp:RegularExpressionValidator>
                          </span><!-- .input-group -->
                    
                   	<span class="input-group">
                        <i class="fa fa-book"></i>

                        <asp:TextBox ID="txtsubjectenquiry" AutoComplete="off" class="lg" placeholder="Subject" runat="server"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtsubjectenquiry" ValidationGroup="0" ForeColor="Red" ErrorMessage="please enter your Name"></asp:RequiredFieldValidator>
                    </span><!-- .input-group -->
                    
                    


                </div><!-- .col-5 -->
                
                <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;">
                
                 	<span class="input-group">
                         <asp:TextBox ID="txtmessageenquiry" AutoComplete="off" class="lg"  placeholder="What's on your mind?" runat="server" TextMode="MultiLine" Rows="6"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtmessageenquiry" ValidationGroup="0" ForeColor="Red" ErrorMessage="please enter your Name"></asp:RequiredFieldValidator>
                    </span><!-- .input-group -->

                    <br />
                    <br />
                       <span class="input-group">
                        <i ></i>
                          <asp:DropDownList ID="ddlEnquiryCity"  CssClass="dd" runat="server" /> 
                       
                    </span><!-- .input-group -->
                    <span class="input-group">
                        <asp:Button ID="btnenquiry" CssClass="btn2" runat="server"   ValidationGroup="0" Text="SUBMIT!"/>
                    	
                    </span><!-- .input-group -->
                </div>
          <%--  </form>--%>
                        <%--  </ContentTemplate></asp:UpdatePanel>--%>
            </div>



                  </div>
                 </div>

                   
             

                 

                  	</div>

               
                  
                  
                  
                    </div>
          
                 
                 
                   </div>
       
    
			   <script >
			       $(document).ready(function () {
			           //$("#tab51").hide();
			           $("#tab53").hide();
			           $("#tab52").hide();

			           $(".tabs-menu51 a").click(function (event) {
			               event.preventDefault();
			               var tab = $(this).attr("href");
			               $(".tab-grid51,.tab-grid52,.tab-grid53").not(tab).css("display", "none");
			               $(tab).fadeIn("slow");


			               if (tab = "#tab51") {
			                  <%-- document.getElementById("txtemaillogin").value = null
			                   document.getElementById("<%=RequiredFieldValidator5.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("<%=RegularExpressionValidator1.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtpasswordlogin").value = null
			                   document.getElementById("<%=RequiredFieldValidator7.ClientID%>").style.visibility = "hidden";--%>

			                   document.getElementById("txtemailenquiry").value = null
			                   document.getElementById("<%=RequiredFieldValidator9.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("<%=RegularExpressionValidator4.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtnameenquiry").value = null
			                   document.getElementById("<%=RequiredFieldValidator8.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtmessageenquiry").value = null
			                   document.getElementById("<%=RequiredFieldValidator12.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtsubjectenquiry").value = null
			                   document.getElementById("<%=RequiredFieldValidator11.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("ddlEnquiryCity").selectedIndex = 0;

			               }
			               if (tab = "#tab53") {
			                 <%--  document.getElementById("txtemaillogin").value = null
			                   document.getElementById("<%=RequiredFieldValidator5.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("<%=RegularExpressionValidator1.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtpasswordlogin").value = null
			                   document.getElementById("<%=RequiredFieldValidator7.ClientID%>").style.visibility = "hidden";--%>

			                   document.getElementById("txtnamesignup").value = null
			                   document.getElementById("<%=rfv.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtemailsignup").value = null
			                   document.getElementById("<%=RequiredFieldValidator1.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("<%=erremailval.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtmobilesignup").value = null
			                   document.getElementById("<%=errmobile.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("<%=errmobileval.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtpasswordsignup").value = null
			                   document.getElementById("<%=RequiredFieldValidator2.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtconfirmpasswordsignup").value = null;
			                   document.getElementById("<%=RequiredFieldValidator3.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("<%=comparePasswords.ClientID%>").style.visibility = "hidden";
			                 
			                   document.getElementById("<%=RequiredFieldValidator4.ClientID%>").style.visibility = "hidden";

			               

			               }

			          <%--     if (tab = "#tab52") {
			                   document.getElementById("txtemailenquiry").value = null
			                   document.getElementById("<%=RequiredFieldValidator9.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("<%=RegularExpressionValidator4.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtnameenquiry").value = null
			                   document.getElementById("<%=RequiredFieldValidator8.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtmessageenquiry").value = null
			                   document.getElementById("<%=RequiredFieldValidator12.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtsubjectenquiry").value = null
			                   document.getElementById("<%=RequiredFieldValidator11.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("ddlEnquiryCity").selectedIndex = 0;

			                   document.getElementById("txtnamesignup").value = null
			                   document.getElementById("<%=rfv.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtemailsignup").value = null
			                   document.getElementById("<%=RequiredFieldValidator1.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("<%=erremailval.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtmobilesignup").value = null
			                   document.getElementById("<%=errmobile.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("<%=errmobileval.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtpasswordsignup").value = null
			                   document.getElementById("<%=RequiredFieldValidator2.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("txtconfirmpasswordsignup").value = null;
			                   document.getElementById("<%=RequiredFieldValidator3.ClientID%>").style.visibility = "hidden";
			                   document.getElementById("<%=comparePasswords.ClientID%>").style.visibility = "hidden";
			                  
			                   document.getElementById("<%=RequiredFieldValidator4.ClientID%>").style.visibility = "hidden";
			           


			                




			               }--%>






			       

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
    </script>
            


        <%--   <script src="txtslider/jquery.min.js"></script>--%>      <%--Removed from txtslider--%>
  <script src="txtslider/jquery.easing.min.js"></script>
  <script src="txtslider/jquery.touchSwipe.min.js"></script>
  <script src="txtslider/jquery.liquid-slider.min.js"></script>  
  <script>
      /**
       * If you need to access the internal property or methods, use this:
       * var api = $.data( $('#main-slider')[0], 'liquidSlider');
       * console.log(api);
       */
      $('#main-slider').liquidSlider();
  </script>



      
          </form>
            
  </body>
</html>
