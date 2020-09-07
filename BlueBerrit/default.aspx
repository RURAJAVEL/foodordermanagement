<%@ Page Language="vb" AutoEventWireup="FALSE" CodeBehind="default.aspx.vb" Inherits="BlueBerrit._default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>
<html lang="en-us">
  <head runat="server">
     <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="WebThemez">
     <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<meta name="title" content="Blueberrit | Food Delivery | Order Food Online ,Catering Services, india , U.S, U.K" />
<meta name="keywords" content="Blueberrit | Food Delivery | Order Food Online,Catering Services, india , U.S, U.K" />

<meta name="description" content="Blueberrit | Food Delivery | Order Food Online,Catering Services, india , U.S, U.K" />
    <title>BlueberrIT | Food Delivery | Order Food Online | Catering Service</title>
    
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
              
              <li class="active">
                <a href="#work-a">Today</a>
              </li>
             
              <li>
                <a href="#about">This Week</a>
              </li>
               <li id="signup">
                            <a href="">Profile</a>
                      
                   
                   
                     </li>
          
                
              
                
                
                
                  </ul>
          </div>
        </div>
      </nav>
    </div>
    








          

            <section id="work-a1" class="page space1">
    
          
  <div id="submenu" hidden>
      
       <a href="cart.aspx"> cart</a> &nbsp;  
        <a href="revieworders.aspx"> review us</a> &nbsp; &nbsp;
        <a href="custprofile.aspx"> profile</a> &nbsp; 
        <a href="custreferral.aspx"> referral</a> &nbsp;   
          <a href="index.aspx">logout</a> 
       
    </div>
   
         </section>
  
         <%-- <script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>--%>

     <%--  <script type="text/javascript">
           $(function () {
               settimeout(function () { $("#work-aa").fadeout(1500); }, 5000)

               $('#work-aa').show();
               settimeout(function () { $("#work-aa").fadeout(1500); }, 5000)

           })
       </script>--%>


          <script type="text/javascript">
              Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(beginRequestHandler);

              function beginRequestHandler() {
                  
                  /// <summary>Raised after an asynchronous postback is finished and control has been returned to the browser.</summary>

                  // set scroll position to null to disable maintaining scroll point after async postback

                  Sys.WebForms.PageRequestManager.getInstance()._scrollPosition = null;

              };
          </script>


           <asp:ScriptManager ID="SM1" runat="server"></asp:ScriptManager>
          <asp:Timer ID="timer1" runat="server" 
Interval="1000" ClientIDMode="AutoID" OnTick="timer1_tick"></asp:Timer>
        
          
            <section id="work-aa"  class="page" hidden>

      <div class="container text-center" >
          <div class="heading">
       
               <ol class="breadcrumb"   style="background-color:#0078c1;"  >
		  <li>
                   <asp:Label ID="lbluser"  ForeColor="white" runat="server" />

                <asp:UpdatePanel id="updPnl" 
runat="server" UpdateMode="Conditional" >
<ContentTemplate>
<asp:Label ID="lblTimer" ForeColor="white" Visible="false" runat="server"></asp:Label>
</ContentTemplate>
<Triggers>
<asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
</Triggers>
</asp:UpdatePanel>


            </li></ol>
           
          </div>
          </div></section>

           <input type="hidden" runat="server" id="key" name="key" />
      <input type="hidden" runat="server" id="hash" name="hash"  />
            <input type="hidden" runat="server" id="txnid" name="txnid" />

          
            <section id="work-a" class="page">
      <div class="container text-center">
          <div class="heading">
            <h2>TODAY MENU</h2>
            
        
          </div>
    
        



                  <div class="tabs-box">


		 <div id="SundayclosedOrder" runat="server"> 	<ul class="tabs-menu52" >
			<li id="litodayveg" runat="server" class="active"><a href="#tab54">VEG</a></li><li id="litodaynonveg"   runat="server"><a href="#tab55" >NON-VEG</a></li><li id="litodayLite" runat="server"><a href="#tab56">LITE</a></li>
			</ul>

            

		 </div>
                     
 

			<div class="clearfix"> </div>

          <div class="tab-grids">
     <div id="todayvegnoorders" runat="server" class="tab-grid54" visible="false">
              <ol class="breadcrumb">
		  <li>
						<asp:Label ID="lbltodayvegnoorders" Visible="false" runat="server"  > </asp:Label>

		  </li>
		 
		 </ol>
         </div>
    <%--Today veg--%>

  <asp:HiddenField ID="hdnvaluetv" runat="server" />
    
     <div id="tab54" runat="server" class="tab-grid54">	

      <ol class="breadcrumb"   >
		  <li>
							<asp:Label ID="lblRestaurantnameToday" runat="server"    > </asp:Label>
                <asp:UpdatePanel id="UpdatePanel1" 
runat="server" UpdateMode="Conditional">
<ContentTemplate>
<asp:Label ID="lbltimertodayveg"  runat="server"></asp:Label>
</ContentTemplate>
<Triggers>
<asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
</Triggers>
</asp:UpdatePanel>

		  </li>
		  
		 </ol>
      

<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
				
								<asp:image runat="server" ID="ImgsingleAnimImag" class="details-left-slider"   />
								
							
					 <div class="details-left-info">
								<P><asp:Label ID="lblRestaurantLoc" runat="server" > </asp:Label> </P>	
                         		<h5>	<asp:Label ID="lblmenu" runat="server" > </asp:Label><asp:Label ID="lblmenuid"  Visible="false" runat="server" > </asp:Label>			</h5>
							<p>Rs. <asp:Label ID="lblprice" runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("MenuTax")%>'> </asp:Label> </a></p>
							<p class="qty">Qty ::</p><asp:textbox    Max="9" type="number" ValidationGroup="2"   id="txttodayQtyveg"    name="quantity"   TextMode="Number"   value="1"  onkeypress="return IsNumeric(event);" ondrop="return false;" onpaste="return false;"  runat="server" />
                      
                   <asp:RequiredFieldValidator runat="server" ID="errvegqty" ForeColor="red"  ControlToValidate="txttodayQtyveg"  ValidationGroup="2" ErrorMessage="please enter quantity" />
                        <asp:RegularExpressionValidator ID="revAvailablePeriod" runat="server" ErrorMessage="Must be greater than 0" ControlToValidate="txttodayQtyveg" ValidationExpression="^[1-9][0-9]*$"  ForeColor="red" ValidationGroup="2" />


                         <script type="text/javascript">


                             function ValidateAndShowPopuptv() {
                                 var validatedtv = Page_ClientValidate("2");

                                 if (validatedtv != 0) {
                                     $find("mpe0").show();

                                 }
                             }
</script>
                  

                           <span id="error" style="color: Red; display: none">* Input digits (0 - 9)</span>
                       
							<div class="btn_form">
								
                             
                                  <asp:LinkButton ID="linkCartTodayVeg" ValidationGroup="2"  runat="server"  OnClientClick="ValidateAndShowPopuptv()"  Enabled="false"  ></asp:LinkButton>

                                
                         
                  
                    <cc1:ModalPopupExtender ID="mpe0" runat="server" PopupControlID="pnlPopuptveg" TargetControlID="hdnvaluetv"
                         CancelControlID="btntvno" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
           <asp:Panel ID="pnlPopuptveg" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header">
                           Order Confirmation
                        </div>
                        <div class="body">

                            <asp:Label ID="lbltodayvOrderedQty" runat="server" ForeColor="#0078c1" /> <br />

                            Select Payment mode? <br />
                             <asp:Button ID="btntvYes" ValidationGroup="2"  runat="server"   CssClass="yes"  Text="CASH ON DELIVERY" OnClick="lnkTodayVeg_click" />
                               <asp:Button ID="btntvPayment" ValidationGroup="2"  runat="server"   CssClass="yes"  Text="Proceed Payment" OnClick="onlinelnkTodayVeg_click" />
                            <asp:Button ID="btntvno" runat="server" Text="CANCEL" CssClass="no" /> 

                        </div>
                        <div class="footer" >
                            
                        
                           
								
								<asp:image runat="server" ID="Image1" CssClass="details-left-slider"  />
							
								
							

                            <div class="details-left-info">
                               
<p>                            Delivery date : <asp:Label ID="lblOrderDatetv" runat="server" /></p>
						<P><asp:Label ID="lblRestaurantLocModal" runat="server" > </asp:Label> </P>	
                         		<h5>	<asp:Label ID="lblmenuModal" runat="server" > </asp:Label>		</h5>
							<p>Rs. <asp:Label ID="lblpriceModal" runat="server" > </asp:Label> + Tax : Rs. <asp:Label ID="lblMenuTaxModal" runat="server" Text= '<%# Eval("MenuTax")%>'> </asp:Label> </p>
							<div class="flower-type">
                                 <p class="desc"><asp:Label ID="lbldescriptionmodal" runat="server" > </asp:Label></p>
					
						
							<p>Contains  ::<asp:Label ID="lblcontainsModal" runat="server" > </asp:Label></p>
                                	
                                	</div>
						
							

                         

					 </div>













                        </div>
                    </asp:Panel>
       <%--   </section>--%>




							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" runat="server" > </asp:Label></p>
						<a href="#"><asp:Label ID="lblcategory" Visible="false" runat="server" > </asp:Label></a>
						
							<p>Contains  ::<a href="#"><asp:Label ID="lblcontains" runat="server" > </asp:Label><asp:Label ID="Label3"  Visible="false" runat="server" > </asp:Label></a></p>
                            </div>
						
							
				          
                         	 </div>
					 <div class="clearfix"></div>				 	
				 </div>
			 </div>

       


             	
<div class="clearfix"></div>







		 </div>		 
		 <div class="clearfix"></div>
		 	
	 </div>
</div>







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




</div>


              


  <%--Today nonveg--%>

<div id="tab55" runat="server" class="tab-grid55">	

         <ol class="breadcrumb" >
		  <li>
						<asp:Label ID="lblRestaurantname2" runat="server"  > </asp:Label>
                <asp:UpdatePanel id="UpdatePanel2" 
runat="server" UpdateMode="Conditional">
<ContentTemplate>
<asp:Label ID="lbltimertodayNonveg"  runat="server"></asp:Label>
</ContentTemplate>
<Triggers>
<asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
</Triggers>
</asp:UpdatePanel>
		  </li>
		  
		 </ol>

<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
					
								<asp:image runat="server" ID="ImgsingleAnimImag2" class="details-left-slider"   />
							
							
					 <div class="details-left-info">
							
								<p><asp:Label ID="lblRestaurantLoc2" runat="server" > </asp:Label> </p>		
                         <h5><asp:Label ID="lblmenu2" runat="server" > </asp:Label><asp:Label ID="lblmenuid2"  Visible="false" runat="server" > </asp:Label></h5>					
							<p>RS. <asp:Label ID="lblprice2" runat="server" > </asp:Label><a href="#"> + Tax : RS. <asp:Label ID="lblMenuTax2" runat="server" Text= '<%# Eval("MenuTax")%>'> </asp:Label> </a></p>
							<p class="qty">Qty ::</p><asp:textbox  Max="9" type="number" ValidationGroup="3" id="txttodayQtyNonveg" name="quantity" value="1" runat="server"  onkeypress="return IsNumeric(event);" ondrop="return false;" onpaste="return false;" />
						
                          <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ForeColor="red"  ControlToValidate="txttodayQtyNonveg"  ValidationGroup="3" ErrorMessage="please enter quantity" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Must be greater than 0" ControlToValidate="txttodayQtyNonveg" ValidationExpression="^[1-9][0-9]*$"  ForeColor="red" ValidationGroup="3" />


                         <script type="text/javascript">


                             function ValidateAndShowPopuptnv() {
                                 var validatedtnv = Page_ClientValidate("3");

                                 if (validatedtnv != 0) {
                                     $find("mpe1").show();

                                 }
                             }
</script>

                         
                         
                         
                         
                         <span id="error2" style="color: Red; display: none">* Input digits (0 - 9)</span>
                         	<div class="btn_form">
							
                                 <asp:LinkButton ID="lnkcarttodaynonveg"  runat="server" ValidationGroup="3" OnClientClick="ValidateAndShowPopuptnv()"  Enabled="false"  ></asp:LinkButton>




                          
                  
                    <cc1:ModalPopupExtender ID="mpe1" runat="server" PopupControlID="pnlPopuptnv" TargetControlID="hdnvaluetv"
                         CancelControlID="btntnvno" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
           <asp:Panel ID="pnlPopuptnv" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header">
                           Order Confirmation
                        </div>
                        <div class="body">
                            <asp:Label ID="lbltodayNvOrderedQty" runat="server" ForeColor="#0078c1" /><br />
                            Select Payment Mode? <br />
                          

                             <asp:Button ID="btnnvYes"  runat="server"  ValidationGroup="3" CssClass="yes"  Text="CASH ON DELIVERY"  OnClick="lnkTodayNonVeg_click" />
                                 <asp:Button ID="btnnvBankPay" ValidationGroup="2"  runat="server"   CssClass="yes"  Text="Proceed Payment" OnClick="onlinelnkTodaynonVeg_click" />
                            <asp:Button ID="btntnvno" runat="server" Text="CANCEL" CssClass="no" />
                        </div>
                        <div class="footer" >
                           
                        
                            	<asp:image runat="server" ID="Image2" CssClass="details-left-slider"  />

                            <div class="details-left-info">
<P>  Delivery date : <asp:Label ID="lblorderdatetnv" runat="server" /> </P>
						<P><asp:Label ID="lblRestaurantLocModal1" runat="server" > </asp:Label> </P>	
                         		<h5>	<asp:Label ID="lblmenuModal1" runat="server" > </asp:Label>		</h5>
							<p>Rs. <asp:Label ID="lblpriceModal1" runat="server" > </asp:Label> + Tax : Rs. <asp:Label ID="lblMenuTaxModal1" runat="server" Text= '<%# Eval("MenuTax")%>'> </asp:Label> </a></p>
							<div class="flower-type">
                                 <p class="desc"><asp:Label ID="lbldescriptionmodal1" runat="server" > </asp:Label></p>
					
						
							<p>Contains  ::<asp:Label ID="lblcontainsModal1" runat="server" > </asp:Label></p>
                                	
                                	</div>
						
							

                         

					 </div>













                        </div>
                    </asp:Panel>
      <%--    </section>--%>












							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription2" runat="server" > </asp:Label></p>
						<a href="#"><asp:Label ID="lblcategory2" Visible="false" runat="server" > </asp:Label></a><%--</p>--%>
						
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


  <%--Today Lite--%>


<div id="tab56" runat="server" class="tab-grid56">	

         <ol class="breadcrumb"  >
		  <li>
							<asp:Label ID="lblRestaurantname3" runat="server"  > </asp:Label>



                <asp:UpdatePanel id="UpdatePanel3" 
runat="server" UpdateMode="Conditional">
<ContentTemplate>
<asp:Label ID="lbltimertodayLite"  runat="server"></asp:Label>
</ContentTemplate>
<Triggers>
<asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
</Triggers>
</asp:UpdatePanel>


		  </li>
		  
		 </ol>

<div class="product-main">
	 <div class="container">
		
		 <div class="ctnt-bar cntnt">
			 <div class="content-bar">
				 <div class="single-page">					 
				
								<asp:image runat="server" ID="ImgsingleAnimImag3" class="details-left-slider"   />
								
							
					 <div class="details-left-info">
							
								<p><asp:Label ID="lblRestaurantLoc3" runat="server" > </asp:Label> </p>		
                         				<h5><asp:Label ID="lblmenu3" runat="server" > </asp:Label><asp:Label ID="lblmenuid3" Visible="false" runat="server" > </asp:Label></h5>	
							<p>RS. <asp:Label ID="lblprice3" runat="server" > </asp:Label><a href="#"> + Tax : RS. <asp:Label ID="lblMenuTax3" runat="server" Text= '<%# Eval("MenuTax")%>'> </asp:Label> </a></p>
							<p class="qty">Qty ::</p><asp:textbox  Max="9" type="number" id="txttodayQtyLite" ValidationGroup="4" name="quantity" value="1" runat="server"  onkeypress="return IsNumeric(event);" ondrop="return false;" onpaste="return false;" />
						
                         <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ForeColor="red"  ControlToValidate="txttodayQtyLite"  ValidationGroup="4" ErrorMessage="please enter quantity" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Must be greater than 0" ControlToValidate="txttodayQtyLite" ValidationExpression="^[1-9][0-9]*$"  ForeColor="red" ValidationGroup="4" />


                         <script type="text/javascript">


                             function ValidateAndShowPopuptl() {
                                 var validatedtl = Page_ClientValidate("4");

                                 if (validatedtl != 0) {
                                     $find("mpe2").show();

                                 }
                             }
</script>
                         
                         
                         
                         
                         <span id="error3" style="color: Red; display: none">* Input digits (0 - 9)</span>
                         	<div class="btn_form">
							
                               
                                  <asp:LinkButton ID="lnkcarttodayLite"  runat="server" ValidationGroup="4"  OnClientClick="ValidateAndShowPopuptl()"  Enabled="false" ></asp:LinkButton>




                             <%--   <section id="modaltlyesno" class="content-section form contact light space">--%>
                    
                    <cc1:ModalPopupExtender ID="mpe2" runat="server" PopupControlID="pnlPopuptl" TargetControlID="hdnvaluetv"
                       CancelControlID="btntLno" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
           <asp:Panel ID="pnlPopuptl" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header">
                           Order Confirmation
                        </div>
                        <div class="body">
                            <asp:Label ID="lbltodayLOrderedQty" runat="server" ForeColor="#0078c1" /><br />
                            Select Payment Mode? <br />
                               <asp:Button ID="btnLiteYes" ValidationGroup="4"  runat="server"  CssClass="yes"  Text="CASH ON DELIVERY" OnClick="lnkTodayLite_click" />
                              <asp:Button ID="btnLiteBankPay" ValidationGroup="2"  runat="server"   CssClass="yes"  Text="Proceed Payment" OnClick="onlinelnkTodayLite_click" />
                            <asp:Button ID="btntLno" runat="server" Text="CANCEL" CssClass="no" />
                         
                        </div>
                        <div class="footer" >
                          
                        
                            	<asp:image runat="server" ID="Image3" CssClass="details-left-slider"  />

                            <div class="details-left-info">
                              <p>   Delivery date : <asp:Label ID="lblOrderdatetl" runat="server" /></p> 
						<P><asp:Label ID="lblRestaurantLocModal2" runat="server" > </asp:Label> </P>	
                         		<h5>	<asp:Label ID="lblmenuModal2" runat="server" > </asp:Label>		</h5>
							<p>Rs. <asp:Label ID="lblpriceModal2" runat="server" > </asp:Label> + Tax : Rs. <asp:Label ID="lblMenuTaxModal2" runat="server" Text= '<%# Eval("MenuTax")%>'> </asp:Label> </a></p>
							<div class="flower-type">
                                 <p class="desc"><asp:Label ID="lbldescriptionmodal2" runat="server" > </asp:Label></p>
					
						
							<p>Contains  ::<asp:Label ID="lblcontainsModal2" runat="server" > </asp:Label></p>
                                	
                                	</div>
						
							

                         

					 </div>













                        </div>
                    </asp:Panel>
       <%--   </section>--%>











							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription3" runat="server" > </asp:Label></p>
						<a href="#"><asp:Label ID="lblcategory3" Visible="false" runat="server" > </asp:Label></a><%--</p>--%>
						
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
            $("#tab56").hide();
            $(".tabs-menu52 a").click(function (event) {
                event.preventDefault();
                var tab = $(this).attr("href");
                $(".tab-grid54,.tab-grid55,.tab-grid56").not(tab).css("display", "none");
                $(tab).fadeIn("slow");



                if (tab = "#tab54") {

                   
                    if ($('#tab55').length > 0) {
                        document.getElementById("txttodayQtyNonveg").value = "1";
                        document.getElementById("<%=RequiredFieldValidator1.ClientID%>").style.visibility = "hidden";
                        document.getElementById("<%=RegularExpressionValidator1.ClientID%>").style.visibility = "hidden";
                    }
                 
                    if ($('#tab56').length > 0) {
                        document.getElementById("txttodayQtyLite").value = "1";
                        document.getElementById("<%=RequiredFieldValidator2.ClientID%>").style.visibility = "hidden";
                        document.getElementById("<%=RegularExpressionValidator2.ClientID%>").style.visibility = "hidden";
                    }

                }
                if (tab = "#tab55") {

                  
                    if ($('#tab54').length > 0) {
                        document.getElementById("txttodayQtyveg").value = "1";
                        document.getElementById("<%=errvegqty.ClientID%>").style.visibility = "hidden";
                        document.getElementById("<%=revAvailablePeriod.ClientID%>").style.visibility = "hidden";
                    }

                
                    if ($('#tab56').length > 0) {
                        document.getElementById("txttodayQtyLite").value = "1";
                        document.getElementById("<%=RequiredFieldValidator2.ClientID%>").style.visibility = "hidden";
                        document.getElementById("<%=RegularExpressionValidator2.ClientID%>").style.visibility = "hidden";
                    }

                }
                if (tab = "#tab56") {

                 
                    if ($('#tab55').length > 0) {
                        document.getElementById("txttodayQtyNonveg").value = "1";
                        document.getElementById("<%=RequiredFieldValidator1.ClientID%>").style.visibility = "hidden";
                        document.getElementById("<%=RegularExpressionValidator1.ClientID%>").style.visibility = "hidden";
                    }

               
                    if ($('#tab54').length > 0) {
                        document.getElementById("txttodayQtyveg").value = "1";
                        document.getElementById("<%=errvegqty.ClientID%>").style.visibility = "hidden";
                        document.getElementById("<%=revAvailablePeriod.ClientID%>").style.visibility = "hidden";
                    }

                }




            });
            $("ul.tabs-menu52 li a").click(function () {
                $(this).parent().addClass("active a");
                $(this).parent().siblings().removeClass("active a");
            });
        });



			</script>

















           
      </div>
    </section>
        

          
         
            
               
            <asp:HiddenField ID="hidForModel" runat="server" />
               <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panel1" TargetControlID="hidForModelunable"   BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="center" style = "display:none">
    
    <%--  <section id="ko" class="content-section form contact light space"> --%>
     <div class="header">
                            Payment mode
                        </div>
                        <div class="body">
                            
                            <asp:Label  ID="lblDeliveryDate" runat="server" />
                        </div>
                        <div class="footer" >
                           <asp:Button ID="btnclose" CssClass="yes"   runat="server" Text="CASH ON DELIVERY" />
                            <asp:Button ID="btnNo" runat="server" Text="No"  CssClass="no" />
                          
                                                    </div>
           <%-- </section>--%>
     
</asp:Panel>

      
          
          
          
          
            <asp:HiddenField ID="HiddenField1" runat="server" />
               <cc1:ModalPopupExtender ID="mp5" runat="server" PopupControlID="Panel3" TargetControlID="HiddenField1"   BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel3" runat="server" CssClass="modalPopup" align="center" style = "display:none">
    
    <%--  <section id="ko" class="content-section form contact light space"> --%>
     <div class="header">
                            Order Confirmed
                        </div>
                        <div class="body">
                            
                            <asp:Label  ID="lblorderclosed" Text="Order Closed." runat="server" />
                        </div>
                        <div class="footer" >
                           <asp:Button ID="btnok" CssClass="yes"   runat="server" Text="ok" />
                          
                          
                                                    </div>
           <%-- </section>--%>
     
</asp:Panel>
          
          
          
            



           
            <asp:HiddenField ID="hidForModelunable" runat="server" />
               <cc1:ModalPopupExtender ID="mp2" runat="server" PopupControlID="Panel2" TargetControlID="hidForModelunable"  CancelControlID="btnUnableYes" BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel2" runat="server" CssClass="modalPopup" align="center" style = "display:none">
       <section id="koUnableToProcess" class="content-section form contact light space">

     <div class="header">
                            Notification
                        </div>
                        <div class="body">
                            <asp:Label ID="lblunabletoProcess" Text="Order Exceeds Maximum value ,Please contact Our sales Team."  runat="server" />
                        </div>
                        <div class="footer" >

 

 <div class="container"> 
          
          
          
            
              <div class="tabs-box">
        <div class="content cover text-center">
                                                 <div class="row">
                  
           <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">

                <span class="input-group">
                     

                        <asp:TextBox ID="txtMaxOderSub" class="lg" placeholder="Subject" runat="server"></asp:TextBox>

                    </span>
                 	<span class="input-group">
                         <asp:TextBox ID="txtMaxOrderEnquiry" class="lg"  placeholder="What's on your mind?" runat="server" TextMode="MultiLine" Rows="6"></asp:TextBox>
                         
                    </span>

                    <br />
                    <br />
                 
                   

               </div>
               
                
                <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;">
            
                      <span class="input-group"></span>
                    <span class="input-group"></span>
                    <span class="input-group"></span>
                    
                        <span class="input-group">
                        <asp:Button ID="BtnUnableNo" CssClass="btn2" runat="server" ValidationGroup="0" Text="SUBMIT!"/><br />
                    	
                    </span>
                <span class="input-group">
                          <asp:Button ID="btnUnableYes" runat="server" Text="Cancel"   CssClass="btn1" />
                    
                         </span>
                    
                </div>
        
                         
            </div>
            </div></div></div>









                       
                          
                        </div>
             </section>
</asp:Panel>
 
        




    <section id="about" class="page space">
      <div class="container text-center"> 
          <div class="heading">
            <h2> SHOWING <%--chennai sample--%> THIS WEEK MENU</h2>
            
           
          </div>

        
   
           <div class="tabs-box" >

                  
    
    	
			    <%--This Week Monday--%>

    <ul class="tabs-menu" >
			

        	<li class="active" id="liMonveg" runat="server"><a href="#tab1">VEG</a></li><li id="liMonNonveg" runat="server"><a href="#tab2">NON-VEG</a></li><li id="liMonLite" runat="server"><a href="#tab3">LITE</a></li>

			</ul>
		
<div class="tab-grids">
     <br /><br />

                         <ol class="breadcrumb">
		  <li>
							<asp:Label ID="lblRestaurantnameMonday" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>


         <asp:Repeater ID="RepeaterImagestab1" runat="server" OnItemCommand="rptList_ItemCommand"  >
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
						
						<asp:label   id="elblMenuDAte" Text= '<%# Eval("elblMenuDAte")%>'  Visible="false" runat="server" />	
                         	<P><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' Visible="false" runat="server" > </asp:Label> </P>							
							<h5><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>
                         <p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : Rs. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
							<p class="qty">Qty ::</p><asp:textbox   Max="9"   type="number" id="txtthisweekQty" name="quantity" value="1" runat="server"  onkeypress="return IsNumeric(event);" ondrop="return false;" onpaste="return false;" />
				
                          <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator0" ForeColor="red"  ControlToValidate="txtthisweekQty"  ValidationGroup="0" ErrorMessage="please enter quantity" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator0" runat="server" ErrorMessage="Must be greater than 0" ControlToValidate="txtthisweekQty" ValidationExpression="^[1-9][0-9]*$"  ForeColor="red" ValidationGroup="0" />

  
                         
                         
                         		<span id="error4" style="color: Red; display: none">* Input digits (0 - 9)</span>
                         	<div class="btn_form">
								
                                 <asp:LinkButton ID="linkCartthisweekMonday"    Text='<%# Eval("lnkThisweekText")%>' runat="server" ></asp:LinkButton>

                        
                    
                    <cc1:ModalPopupExtender ID="mpe" runat="server" PopupControlID="pnlPopup" TargetControlID="linkCartthisweekMonday"
                         CancelControlID="btnNo" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
           <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header">
                           Order Confirmation
                        </div>
                        <div class="body">
                            <asp:Label ID="lblThisweekOrderqtymsg" runat="server" ForeColor="#0078c1" Text= '<%# Eval("lblorderQty")%>' />  <br />

                            Select Payment Mode? <br />

                            	 <asp:Button ID="btnYes" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="CASH ON DELIVERY" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCart" />
                             <asp:Button ID="btnYesBankPay" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="Proceed Payment" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCartBank" />
                            <asp:Button ID="btnNo" runat="server" Text="CANCEL" CssClass="no" />
                          
                        </div>
                        <div class="footer" >
                           
                        
                            <asp:image runat="server" ID="Image3" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>' CssClass="details-left-slider"  />

                            <div class="details-left-info">
					<p>  Delivery date : 	<asp:label   id="lblthisweekOrderdate" Text= '<%# Eval("lblOrderDate")%>'   runat="server" />	</p>
						<asp:label   id="Label2" Text= '<%# Eval("elblMenuDAte")%>'  Visible="false" runat="server" />	
                         	
							<h5><asp:Label ID="Label7" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>
                         <p> <asp:Label ID="Label8" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label> + Tax : Rs. <asp:Label ID="Label9" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </p>
						
						
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="Label10" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
					
							<p>Contains  ::<asp:Label ID="Label12" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></p>
                                	
                                	</div>
							<%--<h5>Description  ::</h5>--%>
							

                         

					 </div>













                        </div>
                    </asp:Panel>
      <%--    </section>--%>

							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
					<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a><%--</p>--%>
					
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



                      if ($('#tab2').length > 0) {

                          if (tab = "#tab1") {
                              if ($('#tab3').length > 0) {
                                  document.getElementById("RepeaterImagestab1_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab1_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab1_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab2').length > 0) {
                                  document.getElementById("RepeaterImagestab1_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab1_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab1_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }


                          }
                          if (tab = "#tab2") {
                              if ($('#tab2').length > 0) {
                                  document.getElementById("RepeaterImagestab1_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab1_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab1_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }
                              if ($('#tab1').length > 0) {
                                  document.getElementById("RepeaterImagestab1_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab1_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab1_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }

                          if (tab = "#tab3") {

                              if ($('#tab3').length > 0) {
                                  document.getElementById("RepeaterImagestab1_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab1_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab1_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab1').length > 0) {
                                  document.getElementById("RepeaterImagestab1_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab1_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab1_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }



                      }
                      else {

                          if (tab = "#tab1") {
                              if ($('#tab3').length > 0) {
                                  document.getElementById("RepeaterImagestab1_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab1_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab1_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }

                          }


                          if (tab = "#tab3") {

                              if ($('#tab1').length > 0) {
                                  document.getElementById("RepeaterImagestab1_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab1_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab1_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                          }





                      }







                  });
                  $("ul.tabs-menu li a").click(function () {
                      $(this).parent().addClass("active a");
                      $(this).parent().siblings().removeClass("active a");
                  });
              });



			</script>
                </ItemTemplate></asp:Repeater>
                        </div>

             
   <%--This Week Tuesday--%>




     <ul class="tabs-menu1">
			

         	<li class="active" id="liTueveg" runat="server" ><a href="#tab4">VEG</a></li><li id="liTueNonveg" runat="server"><a href="#tab5">NON-VEG</a></li><li id="liTueLite" runat="server"><a href="#tab6">LITE</a></li>

			</ul>


		

          <div class="tab-grids">

              <br /><br />
                <ol class="breadcrumb">
		  <li>
							<asp:Label ID="lblRestaurantnameTuesday" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>


    
    	<asp:Repeater ID="RepeaterImagestab2" OnItemCommand="rptList_ItemCommand" runat="server">
    <ItemTemplate>
    
     <div id='<%# Eval("lblcategoryy")%>'  class="<%# Eval("lblcategoryyy")%>">	

       <%--  
         <ol class="breadcrumb">
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
							<asp:label   id="elblMenuDAte" Text= '<%# Eval("elblMenuDAte")%>' visible="false"  runat="server" />
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>'  runat="server" > </asp:Label> </p>	
                         						<h5><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : RS. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
							<p class="qty">Qty ::</p><asp:textbox   Max="9" type="number" id="txtthisweekQty" name="quantity" value="1" runat="server"  onkeypress="return IsNumeric(event);" ondrop="return false;" onpaste="return false;" />
					
                         
                          <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator0" ForeColor="red"  ControlToValidate="txtthisweekQty"  ValidationGroup="1" ErrorMessage="please enter quantity" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator0" runat="server" ErrorMessage="Must be greater than 0" ControlToValidate="txtthisweekQty" ValidationExpression="^[1-9][0-9]*$"  ForeColor="red" ValidationGroup="1" />
                         
                         	<span id="error5" style="color: Red; display: none">* Input digits (0 - 9)</span>
                         	<div class="btn_form">
						
                                 <asp:LinkButton ID="linkCartthisweekTuesday"  Text='<%# Eval("lnkThisweekText")%>' runat="server" ></asp:LinkButton>


                            
                  
                    <cc1:ModalPopupExtender ID="mpe" runat="server" PopupControlID="pnlPopup" TargetControlID="linkCartthisweekTuesday"
                         CancelControlID="btnNo" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
           

                                 <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header">
                           Order Confirmation
                        </div>
                        <div class="body">
                            <asp:Label ID="lblThisweekOrderqtymsg" runat="server" ForeColor="#0078c1" Text= '<%# Eval("lblorderQty")%>' />  <br />

                            Select Payment Mode? <br />

                            	 <asp:Button ID="btnYes" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="CASH ON DELIVERY" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCart" />
                             <asp:Button ID="btnYesBankPay" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="Proceed Payment" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCartBank" />
                            <asp:Button ID="btnNo" runat="server" Text="CANCEL" CssClass="no" />
                          
                        </div>
                        <div class="footer" >
                           
                        
                            <asp:image runat="server" ID="Image3" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>' CssClass="details-left-slider"  />

                            <div class="details-left-info">
					<p>  Delivery date : 	<asp:label   id="lblthisweekOrderdate" Text= '<%# Eval("lblOrderDate")%>'   runat="server" />	</p>
						<asp:label   id="Label2" Text= '<%# Eval("elblMenuDAte")%>'  Visible="false" runat="server" />	
                         	
							<h5><asp:Label ID="Label7" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>
                         <p> <asp:Label ID="Label8" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label> + Tax : Rs. <asp:Label ID="Label9" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </p>
						
						
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="Label10" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
					
							<p>Contains  ::<asp:Label ID="Label12" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></p>
                                	
                                	</div>
							<%--<h5>Description  ::</h5>--%>
							

                         

					 </div>













                        </div>
                    </asp:Panel>


        <%--  </section>--%>






							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
						<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a><%--</p>--%>
						
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


                      if ($('#tab5').length > 0) {

                          if (tab = "#tab4") {
                              if ($('#tab6').length > 0) {
                                  document.getElementById("RepeaterImagestab2_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab2_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab2_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab5').length > 0) {
                                  document.getElementById("RepeaterImagestab2_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab2_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab2_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }


                          }
                          if (tab = "#tab5") {
                              if ($('#tab5').length > 0) {
                                  document.getElementById("RepeaterImagestab2_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab2_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab2_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }
                              if ($('#tab4').length > 0) {
                                  document.getElementById("RepeaterImagestab2_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab2_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab2_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }

                          if (tab = "#tab6") {

                              if ($('#tab6').length > 0) {
                                  document.getElementById("RepeaterImagestab2_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab2_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab2_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab4').length > 0) {
                                  document.getElementById("RepeaterImagestab2_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab2_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab2_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }



                      }
                      else {

                          if (tab = "#tab4") {
                              if ($('#tab6').length > 0) {
                                  document.getElementById("RepeaterImagestab2_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab2_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab2_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }

                          }


                          if (tab = "#tab6") {

                              if ($('#tab4').length > 0) {
                                  document.getElementById("RepeaterImagestab2_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab2_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab2_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                          }





                      }





                  });
                  $("ul.tabs-menu1 li a").click(function () {
                      $(this).parent().addClass("active a");
                      $(this).parent().siblings().removeClass("active a");
                  });
              });



			</script>
                </ItemTemplate></asp:Repeater>
                        </div>



               
               <br />
               <br />


   <%--This Week Wednesday--%>






     <ul class="tabs-menu2">
			

         	<li class="active" id="liWedveg" runat="server" ><a href="#tab7">VEG</a></li><li id="liWedNonveg" runat="server" ><a href="#tab8">NON-VEG</a></li><li id="liWedLite" runat="server" ><a href="#tab9">LITE</a></li>

			</ul>


		

          <div class="tab-grids">


               <br /><br />
                  <ol class="breadcrumb">
		  <li>
							<asp:Label ID="lblRestaurantnameWednesday" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>


    
    	<asp:Repeater ID="RepeaterImagestab3" OnItemCommand="rptList_ItemCommand" runat="server">
    <ItemTemplate>
    
     <div id='<%# Eval("lblcategoryy")%>'  class="<%# Eval("lblcategoryyy")%>">	

      
    <%--    <ol class="breadcrumb">
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
							<asp:label   id="elblMenuDAte" Text= '<%# Eval("elblMenuDAte")%>' visible="false" runat="server" />
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </p>	
                         				<h5><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>		
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : RS. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
							<p class="qty">Qty ::</p><asp:textbox   Max="9" type="number" id="txtthisweekQty" name="quantity" value="1" runat="server"  onkeypress="return IsNumeric(event);" ondrop="return false;" onpaste="return false;" />
					
                           <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator0" ForeColor="red"  ControlToValidate="txtthisweekQty"  ValidationGroup="2" ErrorMessage="please enter quantity" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator0" runat="server" ErrorMessage="Must be greater than 0" ControlToValidate="txtthisweekQty" ValidationExpression="^[1-9][0-9]*$"  ForeColor="red" ValidationGroup="2" />
                         
                         
                         	<span id="error6" style="color: Red; display: none">* Input digits (0 - 9)</span>
                         	<div class="btn_form">
					
                                  <asp:LinkButton ID="linkCartthisweekWednesday"  Text='<%# Eval("lnkThisweekText")%>' runat="server" ></asp:LinkButton>
							
                            
                            
                   
                    <cc1:ModalPopupExtender ID="mpe" runat="server" PopupControlID="pnlPopup" TargetControlID="linkCartthisweekWednesday"
                       CancelControlID="btnNo" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
   <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header">
                           Order Confirmation
                        </div>
                        <div class="body">
                            <asp:Label ID="lblThisweekOrderqtymsg" runat="server" ForeColor="#0078c1" Text= '<%# Eval("lblorderQty")%>' />  <br />

                            Select Payment Mode? <br />

                            	 <asp:Button ID="btnYes" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="CASH ON DELIVERY" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCart" />
                             <asp:Button ID="btnYesBankPay" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="Proceed Payment" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCartBank" />
                            <asp:Button ID="btnNo" runat="server" Text="CANCEL" CssClass="no" />
                          
                        </div>
                        <div class="footer" >
                           
                        
                            <asp:image runat="server" ID="Image3" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>' CssClass="details-left-slider"  />

                            <div class="details-left-info">
					<p>  Delivery date : 	<asp:label   id="lblthisweekOrderdate" Text= '<%# Eval("lblOrderDate")%>'   runat="server" />	</p>
						<asp:label   id="Label2" Text= '<%# Eval("elblMenuDAte")%>'  Visible="false" runat="server" />	
                         	
							<h5><asp:Label ID="Label7" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>
                         <p> <asp:Label ID="Label8" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label> + Tax : Rs. <asp:Label ID="Label9" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </p>
						
						
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="Label10" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
					
							<p>Contains  ::<asp:Label ID="Label12" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></p>
                                	
                                	</div>
							<%--<h5>Description  ::</h5>--%>
							

                         

					 </div>













                        </div>
                    </asp:Panel>
   <%--       </section>--%>




                            
                            </div>
							<div class="flower-type">
<p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
							<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a><%--</p>--%>
							
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


                      if ($('#tab8').length > 0) {

                          if (tab = "#tab7") {
                              if ($('#tab9').length > 0) {
                                  document.getElementById("RepeaterImagestab3_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab3_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab3_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab8').length > 0) {
                                  document.getElementById("RepeaterImagestab3_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab3_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab3_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }


                          }
                          if (tab = "#tab8") {
                              if ($('#tab8').length > 0) {
                                  document.getElementById("RepeaterImagestab3_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab3_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab3_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }
                              if ($('#tab7').length > 0) {
                                  document.getElementById("RepeaterImagestab3_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab3_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab3_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }

                          if (tab = "#tab9") {

                              if ($('#tab9').length > 0) {
                                  document.getElementById("RepeaterImagestab3_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab3_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab3_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab7').length > 0) {
                                  document.getElementById("RepeaterImagestab3_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab3_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab3_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }



                      }
                      else {

                          if (tab = "#tab7") {
                              if ($('#tab9').length > 0) {
                                  document.getElementById("RepeaterImagestab3_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab3_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab3_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }

                          }


                          if (tab = "#tab9") {

                              if ($('#tab7').length > 0) {
                                  document.getElementById("RepeaterImagestab3_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab3_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab3_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                          }





                      }






                  });
                  $("ul.tabs-menu2 li a").click(function () {
                      $(this).parent().addClass("active a");
                      $(this).parent().siblings().removeClass("active a");
                  });
              });



			</script>
                </ItemTemplate></asp:Repeater>
                        </div>

               
             

    <%--This Week thursday--%>





      <ul class="tabs-menu3">
				

          <li class="active" id="lithuveg" runat="server"><a href="#tab10">VEG</a></li><li id="lithuNonveg" runat="server"><a href="#tab11">NON-VEG</a></li><li id="lithuLite" runat="server"><a href="#tab12">LITE</a></li>

			</ul>


			

          <div class="tab-grids">

              <br /><br />

                 <ol class="breadcrumb">
		  <li>
							<asp:Label ID="lblRestaurantnamethursday" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>

    
    	<asp:Repeater ID="RepeaterImagestab4" OnItemCommand="rptList_ItemCommand" runat="server">
    <ItemTemplate>
    
     <div id='<%# Eval("lblcategoryy")%>'  class="<%# Eval("lblcategoryyy")%>">	

      
        <%--    <ol class="breadcrumb">
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
						<asp:label   id="elblMenuDAte" Text= '<%# Eval("elblMenuDAte")%>' visible="false" runat="server" />
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </p>
                         			<h5><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>				
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : RS. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
							<p class="qty">Qty ::</p><asp:textbox  Max="9" type="number" id="txtthisweekQty" name="quantity" value="1" runat="server"  onkeypress="return IsNumeric(event);" ondrop="return false;" onpaste="return false;" />
				
                          <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator0" ForeColor="red"  ControlToValidate="txtthisweekQty"  ValidationGroup="3" ErrorMessage="please enter quantity" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator0" runat="server" ErrorMessage="Must be greater than 0" ControlToValidate="txtthisweekQty" ValidationExpression="^[1-9][0-9]*$"  ForeColor="red" ValidationGroup="3" />

                         
                         
                         
                         		<span id="error7" style="color: Red; display: none">* Input digits (0 - 9)</span>
                         	<div class="btn_form">
					
                                  <asp:LinkButton ID="linkCartthisweekThursday"  Text='<%# Eval("lnkThisweekText")%>' runat="server" ></asp:LinkButton>
						
                
                    <cc1:ModalPopupExtender ID="mpe" runat="server" PopupControlID="pnlPopup" TargetControlID="linkCartthisweekThursday"
                       CancelControlID="btnNo" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
           

                             <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header">
                           Order Confirmation
                        </div>
                        <div class="body">
                            <asp:Label ID="lblThisweekOrderqtymsg" runat="server" ForeColor="#0078c1" Text= '<%# Eval("lblorderQty")%>' />  <br />

                            Select Payment Mode? <br />

                            	 <asp:Button ID="btnYes" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="CASH ON DELIVERY" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCart" />
                             <asp:Button ID="btnYesBankPay" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="Proceed Payment" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCartBank" />
                            <asp:Button ID="btnNo" runat="server" Text="CANCEL" CssClass="no" />
                          
                        </div>
                        <div class="footer" >
                           
                        
                            <asp:image runat="server" ID="Image3" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>' CssClass="details-left-slider"  />

                            <div class="details-left-info">
					<p>  Delivery date : 	<asp:label   id="lblthisweekOrderdate" Text= '<%# Eval("lblOrderDate")%>'   runat="server" />	</p>
						<asp:label   id="Label2" Text= '<%# Eval("elblMenuDAte")%>'  Visible="false" runat="server" />	
                         	
							<h5><asp:Label ID="Label7" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>
                         <p> <asp:Label ID="Label8" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label> + Tax : Rs. <asp:Label ID="Label9" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </p>
						
						
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="Label10" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
					
							<p>Contains  ::<asp:Label ID="Label12" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></p>
                                	
                                	</div>
							<%--<h5>Description  ::</h5>--%>
							

                         

					 </div>













                        </div>
                    </asp:Panel>



     <%--     </section>    --%>
                                
                                
                                	</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
							<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a><%--</p>--%>
							
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




                    



              

                      if ($('#tab11').length > 0) {

                          if (tab = "#tab10") {
                              if ($('#tab12').length > 0) {
                                  document.getElementById("RepeaterImagestab4_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab4_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab4_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab11').length > 0) {
                                  document.getElementById("RepeaterImagestab4_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab4_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab4_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }


                          }
                          if (tab = "#tab11") {
                              if ($('#tab11').length > 0) {
                                  document.getElementById("RepeaterImagestab4_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab4_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab4_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }
                              if ($('#tab10').length > 0) {
                                  document.getElementById("RepeaterImagestab4_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab4_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab4_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }

                          if (tab = "#tab12") {

                              if ($('#tab12').length > 0) {
                                  document.getElementById("RepeaterImagestab4_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab4_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab4_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab10').length > 0) {
                                  document.getElementById("RepeaterImagestab4_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab4_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab4_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }



                      }
                      else {

                          if (tab = "#tab10") {
                              if ($('#tab12').length > 0) {
                                  document.getElementById("RepeaterImagestab4_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab4_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab4_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }

                          }


                          if (tab = "#tab12") {

                              if ($('#tab10').length > 0) {
                                  document.getElementById("RepeaterImagestab4_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab4_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab4_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                          }





                      }












                  });
                  $("ul.tabs-menu3 li a").click(function () {
                      $(this).parent().addClass("active a");
                      $(this).parent().siblings().removeClass("active a");
                  });
              });



			</script>
                </ItemTemplate></asp:Repeater>
                        </div>



               
             




    <%--This Week Friday--%>



      <ul class="tabs-menu4">
			

          	<li class="active" id="liFriveg" runat="server"><a href="#tab13">VEG</a></li><li id="liFriNonveg" runat="server"><a href="#tab14">NON-VEG</a></li><li id="liFriLite" runat="server"><a href="#tab15">LITE</a></li>

			</ul>


		

          <div class="tab-grids">
               <br /><br />
                  <ol class="breadcrumb">
		  <li>
							<asp:Label ID="lblRestaurantnameFriday" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>

    
    	<asp:Repeater ID="RepeaterImagestab5" OnItemCommand="rptList_ItemCommand" runat="server">
    <ItemTemplate>
    
     <div id='<%# Eval("lblcategoryy")%>'  class="<%# Eval("lblcategoryyy")%>">	

     
        <%--    <ol class="breadcrumb">
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
						<asp:label   id="elblMenuDAte" Text= '<%# Eval("elblMenuDAte")%>' visible="false" runat="server" />
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </p>
                         					<h5><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>		
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : RS. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
							<p class="qty">Qty ::</p><asp:textbox   Max="9" type="number" id="txtthisweekQty" name="quantity" value="1" runat="server"  onkeypress="return IsNumeric(event);" ondrop="return false;" onpaste="return false;" />
						
                         <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator0" ForeColor="red"  ControlToValidate="txtthisweekQty"  ValidationGroup="4" ErrorMessage="please enter quantity" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator0" runat="server" ErrorMessage="Must be greater than 0" ControlToValidate="txtthisweekQty" ValidationExpression="^[1-9][0-9]*$"  ForeColor="red" ValidationGroup="4" /> 
                         
                         
                         <span id="error8" style="color: Red; display: none">* Input digits (0 - 9)</span>
                         	<div class="btn_form">
				
                                  <asp:LinkButton ID="linkCartthisweekFriday"  Text='<%# Eval("lnkThisweekText")%>' runat="server" ></asp:LinkButton>
						
                                
                         
                    <cc1:ModalPopupExtender ID="mpe" runat="server" PopupControlID="pnlPopup" TargetControlID="linkCartthisweekFriday"
                       CancelControlID="btnNo" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
           

                           <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header">
                           Order Confirmation
                        </div>
                        <div class="body">
                            <asp:Label ID="lblThisweekOrderqtymsg" runat="server" ForeColor="#0078c1" Text= '<%# Eval("lblorderQty")%>' />  <br />

                            Select Payment Mode? <br />

                            	 <asp:Button ID="btnYes" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="CASH ON DELIVERY" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCart" />
                             <asp:Button ID="btnYesBankPay" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="Proceed Payment" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCartBank" />
                            <asp:Button ID="btnNo" runat="server" Text="CANCEL" CssClass="no" />
                          
                        </div>
                        <div class="footer" >
                           
                        
                            <asp:image runat="server" ID="Image3" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>' CssClass="details-left-slider"  />

                            <div class="details-left-info">
					<p>  Delivery date : 	<asp:label   id="lblthisweekOrderdate" Text= '<%# Eval("lblOrderDate")%>'   runat="server" />	</p>
						<asp:label   id="Label2" Text= '<%# Eval("elblMenuDAte")%>'  Visible="false" runat="server" />	
                         	
							<h5><asp:Label ID="Label7" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>
                         <p> <asp:Label ID="Label8" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label> + Tax : Rs. <asp:Label ID="Label9" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </p>
						
						
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="Label10" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
					
							<p>Contains  ::<asp:Label ID="Label12" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></p>
                                	
                                	</div>
							<%--<h5>Description  ::</h5>--%>
							

                         

					 </div>













                        </div>
                    </asp:Panel>




        <%--  </section>--%>


                                
                                	</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
						<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a><%--</p>--%>
						
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

                  if ($('#tab13').length > 0) {
                      $("#tab14").hide();
                  }
                  else {
                      $("#liFriNonveg").addClass("active");
                  }


                  $("#tab15").hide();
                  $(".tabs-menu4 a").click(function (event) {
                      event.preventDefault();
                      var tab = $(this).attr("href");
                      $(".tab-grid13,.tab-grid14,.tab-grid15").not(tab).css("display", "none");
                      $(tab).fadeIn("slow");



                      if ($('#tab14').length > 0) {
                          
                          if (tab = "#tab13") {
                              if ($('#tab15').length > 0) {
                                  document.getElementById("RepeaterImagestab5_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab5_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab5_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab14').length > 0) {
                                  document.getElementById("RepeaterImagestab5_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab5_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab5_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }


                          }
                          if (tab = "#tab14") {
                              if ($('#tab14').length > 0) {
                                  document.getElementById("RepeaterImagestab5_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab5_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab5_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }
                              if ($('#tab13').length > 0) {
                                  document.getElementById("RepeaterImagestab5_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab5_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab5_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }

                          if (tab = "#tab15") {

                              if ($('#tab15').length > 0) {
                                  document.getElementById("RepeaterImagestab5_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab5_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab5_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab13').length > 0) {
                                  document.getElementById("RepeaterImagestab5_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab5_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab5_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }



                      }
                      else {

                          if (tab = "#tab13") {
                              if ($('#tab15').length > 0) {
                                  document.getElementById("RepeaterImagestab5_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab5_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab5_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }
                            
                          }


                          if (tab = "#tab15") {

                              if ($('#tab13').length > 0) {
                                  document.getElementById("RepeaterImagestab5_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab5_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab5_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                          }





                      }



                  });
                  $("ul.tabs-menu4 li a").click(function () {
                      $(this).parent().addClass("active a");
                      $(this).parent().siblings().removeClass("active a");
                  });
              });



			</script>
                </ItemTemplate></asp:Repeater>
                        </div>

               
           


    <%--This Week saturday--%>




      <ul class="tabs-menu5">
			

          	<li class="active" id="lisatveg" runat="server"><a href="#tab16">VEG</a></li><li  id="lisatNonveg" runat="server" ><a href="#tab17"  >NON-VEG</a></li><li id="lisatLite" runat="server"><a href="#tab18" >LITE</a></li>

			</ul>


			

          <div class="tab-grids">
               <br /><br />

                 <ol class="breadcrumb">
		  <li>
							<asp:Label ID="lblRestaurantnamesaturday" Text= '<%# Eval("lblRestaurantname")%>'  runat="server" > </asp:Label>

		  </li>
		  
		 </ol>


    
    	<asp:Repeater ID="RepeaterImagestab6" OnItemCommand="rptList_ItemCommand" runat="server">
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
						<asp:label   id="elblMenuDAte" Text= '<%# Eval("elblMenuDAte")%>' visible="false" runat="server" />
								<p><asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </p>	
                         				<h5><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>		
							<p> <asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label><a href="#"> + Tax : RS. <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </a></p>
							<p class="qty">Qty ::</p><asp:textbox   Max="9" type="number" id="txtthisweekQty" name="quantity" value="1" runat="server"  onkeypress="return IsNumeric(event);" ondrop="return false;" onpaste="return false;" />
                     
                           <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator0" ForeColor="red"  ControlToValidate="txtthisweekQty"  ValidationGroup="5" ErrorMessage="please enter quantity" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator0" runat="server" ErrorMessage="Must be greater than 0" ControlToValidate="txtthisweekQty" ValidationExpression="^[1-9][0-9]*$"  ForeColor="red" ValidationGroup="5" />
                         
                         
                             <span id="error9" style="color: Red; display: none">* Input digits (0 - 9)</span>
							<div class="btn_form">
					
                                  <asp:LinkButton ID="linkCartthisweeksaturday"  Text='<%# Eval("lnkThisweekText")%>' runat="server" ></asp:LinkButton>



                    <cc1:ModalPopupExtender ID="mpe" runat="server" PopupControlID="pnlPopup" TargetControlID="linkCartthisweeksaturday"
                        CancelControlID="btnNo" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
           


             <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header">
                           Order Confirmation
                        </div>
                        <div class="body">
                            <asp:Label ID="lblThisweekOrderqtymsg" runat="server" ForeColor="#0078c1" Text= '<%# Eval("lblorderQty")%>' />  <br />

                            Select Payment Mode? <br />

                            	 <asp:Button ID="btnYes" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="CASH ON DELIVERY" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCart" />
                             <asp:Button ID="btnYesBankPay" ValidationGroup="0"  runat="server"  CssClass="yes"  Text="Proceed Payment" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "elblmenuID")%>' CommandName="AddToCartBank" />
                            <asp:Button ID="btnNo" runat="server" Text="CANCEL" CssClass="no" />
                          
                        </div>
                        <div class="footer" >
                           
                        
                            <asp:image runat="server" ID="Image3" ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>' CssClass="details-left-slider"  />

                            <div class="details-left-info">
					<p>  Delivery date : 	<asp:label   id="lblthisweekOrderdate" Text= '<%# Eval("lblOrderDate")%>'   runat="server" />	</p>
						<asp:label   id="Label2" Text= '<%# Eval("elblMenuDAte")%>'  Visible="false" runat="server" />	
                         	
							<h5><asp:Label ID="Label7" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></h5>
                         <p> <asp:Label ID="Label8" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label> + Tax : Rs. <asp:Label ID="Label9" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label> </p>
						
						
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="Label10" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
					
							<p>Contains  ::<asp:Label ID="Label12" Text= '<%# Eval("lblcontains")%>' runat="server" > </asp:Label></p>
                                	
                                	</div>
							<%--<h5>Description  ::</h5>--%>
							

                         

					 </div>













                        </div>
                    </asp:Panel>




      <%--    </section>--%>



							</div>
							<div class="flower-type">
                                <p class="desc"><asp:Label ID="lbldescription" Text= '<%# Eval("lbldescription")%>' runat="server" > </asp:Label></p>
					<a href="#"><asp:Label ID="lblcategory" Visible="false" Text= '<%# Eval("lblcategory")%>' runat="server" > </asp:Label></a><%--</p>--%>
					
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


                  


                      if ($('#tab17').length > 0) {

                          if (tab = "#tab16") {
                              if ($('#tab18').length > 0) {
                                  document.getElementById("RepeaterImagestab6_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab6_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab6_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab17').length > 0) {
                                  document.getElementById("RepeaterImagestab6_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab6_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab6_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }


                          }
                          if (tab = "#tab17") {
                              if ($('#tab17').length > 0) {
                                  document.getElementById("RepeaterImagestab6_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab6_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab6_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }
                              if ($('#tab16').length > 0) {
                                  document.getElementById("RepeaterImagestab6_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab6_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab6_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }

                          if (tab = "#tab18") {

                              if ($('#tab18').length > 0) {
                                  document.getElementById("RepeaterImagestab6_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab6_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab6_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                              if ($('#tab16').length > 0) {
                                  document.getElementById("RepeaterImagestab6_txtthisweekQty_2").value = "1";
                                  document.getElementById("RepeaterImagestab6_RequiredFieldValidator0_2").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab6_RegularExpressionValidator0_2").style.visibility = "hidden";
                              }
                          }



                      }
                      else {

                          if (tab = "#tab16") {
                              if ($('#tab18').length > 0) {
                                  document.getElementById("RepeaterImagestab6_txtthisweekQty_0").value = "1";
                                  document.getElementById("RepeaterImagestab6_RequiredFieldValidator0_0").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab6_RegularExpressionValidator0_0").style.visibility = "hidden";
                              }

                          }


                          if (tab = "#tab18") {

                              if ($('#tab16').length > 0) {
                                  document.getElementById("RepeaterImagestab6_txtthisweekQty_1").value = "1";
                                  document.getElementById("RepeaterImagestab6_RequiredFieldValidator0_1").style.visibility = "hidden";
                                  document.getElementById("RepeaterImagestab6_RegularExpressionValidator0_1").style.visibility = "hidden";
                              }
                          }





                      }













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
    </div>        
  

   
    	   
    </section>
    
           

           <section id="Section1" class="content-section form contact light space" style="background-color:#eee;">

 <div class="container"> 
          
          
          
            
              <div class="tabs-box">
			
			
                  <div class="clearfix"> </div>
                

		 <div class="tab-grids">
		
             	
			
                  <div class="clearfix"> </div>
    <div id="tab53" class="tab-grid53">
        	  <div class="content cover text-center">
              <div class="heading">
                <h2 >Getting in touch</h2>
                
                  <p>We are working 24 x 7 to fulfill all your needs. To submit your Enquiries, Please fill this form<br/><br/></p>
              </div>
               
                  <div class="row">
            <span id="message"></span>
            
        
                <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">
                                    
                   
                    	<span class="input-group">
                     

                        <asp:TextBox ID="txtsubjectenquiry" AutoComplete="off"  class="lg" placeholder="Subject" runat="server"></asp:TextBox>
                    </span>

                </div>
                
                <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;">
                
                 	<span class="input-group">
                         <asp:TextBox ID="txtmessageenquiry" class="lg"  placeholder="What's on your mind?" runat="server" TextMode="MultiLine" Rows="6"></asp:TextBox>
                         
                    </span>

                    <br />
                    <br />
                 
                    <span class="input-group">
                        <asp:Button ID="btnenquiry" CssClass="btn1" runat="server" ValidationGroup="0" Text="SUBMIT!"/>
                    	
                    </span>
                </div>
        
                         
            </div>



                  </div>
                 </div>	
        </div></div></div>
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

        <%--  <script type="text/javascript">
              window.onload = function () {
                  settimeout(function () { $("#work-aa").fadeout(1500); }, 5000)

                  $('#work-aa').show();
                  settimeout(function () { $("#work-aa").fadeout(1500); }, 5000)

              }

	</script>--%>


          </form>
  </body>
</html>
