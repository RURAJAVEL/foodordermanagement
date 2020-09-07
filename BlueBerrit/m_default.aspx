<%@ Page Language="vb" AutoEventWireup="FALSE" CodeBehind="m_default.aspx.vb" Inherits="BlueBerrit.m_default" %>
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
     

    <style type="text/css">
    body
    {
        font-family: Arial;
        font-size: 10pt;
    }
    .modalBackground
    {
        background-color: Black;
        filter: alpha(opacity=40);
        opacity: 0.4;
    }
    .modalPopup
    {
        background-color: #FFFFFF;
      width:70%;
        border: 0.5px solid black;
    }
    .modalPopup .header
    {
        background-color: black;
        height: 30px;
        color: White;
        line-height: 30px;
        text-align: center;
        font-weight: bold;
    }
    .modalPopup .body
    {
        min-height: 50px;
        line-height: 30px;
        text-align: center;
        font-weight: bold;
    }
    .modalPopup .footer
    {
        padding: 3px;
    }
    .modalPopup .yes, .modalPopup .no
    {
        height: 23px;
        color: White;
        line-height: 23px;
        text-align: center;
        font-weight: bold;
        cursor: pointer;
    }
    .modalPopup .yes
    {
        background-color: #b87fed;
        border: 1px solid #0DA9D0;
    }
    .modalPopup .no
    {
        background-color: #b87fed;
        border: 1px solid #5C5C5C;
    }
</style>

      
      <script type = "text/javascript">
          function Confirm() {
              var confirm_value = document.createElement("INPUT");
              confirm_value.type = "hidden";
              confirm_value.name = "confirm_value";
              if (confirm("Do you want to Place Order?")) {
                  confirm_value.value = "Yes";
              } else {
                  confirm_value.value = "No";
              }
              document.forms[0].appendChild(confirm_value);
          }
        
    </script>
        <script type="text/javascript">
            var specialKeys = new Array();
            specialKeys.push(8); //Backspace
            function IsNumeric(e) {
                var keyCode = e.which ? e.which : e.keyCode
                var ret = ((keyCode >= 48 && keyCode <= 57) || specialKeys.indexOf(keyCode) != -1);
                               if ((keyCode >= 48 && keyCode <= 57)) {
                    $("input").bind("keyup", function (e) {
                        var value = this.value ;
                        if (value >= 10) {
                            $find("mp2").show();
                            this.value = 1;
                        }
                      
                                                                 
                         });
                                   }
                               return ret;
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
              
              <li class="active">
                <a href="#work-a">Today</a>
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
  
          <%-- <script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
<script type="text/javascript">
    $(function () {
        settimeout(function () { $("#fdin").fadeout(1500); }, 5000)

        $('#fdin').show();
        settimeout(function () { $("#fdin").fadeout(1500); }, 5000)

    })
</script>--%>
       

          <div id="fdin"><section id="work-aa" class="page space">
      <div class="container text-center">
          <div class="heading">
       
               <ol class="breadcrumb"  style="background-color:#5f29b2;"  >
		  <li>
                   <asp:Label ID="lbluser"  ForeColor="white" runat="server" />
            </li></ol>
           
          </div>
          </div></section></div>



          
            
        

           <asp:ScriptManager runat="server"></asp:ScriptManager>
         


             <input type="hidden" runat="server" id="key" name="key" />
      <input type="hidden" runat="server" id="hash" name="hash"  />
            <input type="hidden" runat="server" id="txnid" name="txnid" />
        




    <section id="about" class="page space">
      <div class="container text-center"> 
      

        
   
           <div class="tabs-box" >

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

       
    </div>
    </div>        
  

   
    	   
    </section>
    
              <section id="LoginPanel"   class="content-section form contact light space">
            <asp:HiddenField ID="HiddenField1" runat="server" />
               <cc1:ModalPopupExtender ID="mplogin" runat="server" PopupControlID="Panel3" TargetControlID="HiddenField1"  BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel3" runat="server" CssClass="modalPopup" align="center" style = "display:none">
      
     <div class="header">
                           Please Login
                        </div>
                        <div class="body">
                           
                        </div>
                        <div class="footer" >
                        
                            
                              <div class="container"> 
          
          
          
            
              <div class="tabs-box">
					 <div class="tab-grids">
		             <div id="tab52" class="tab-grid52">
        	  <div class="content cover text-center">
              <div class="heading">
              
                
	
				<p>Welcome, please enter the following to continue.</p>
	<p><asp:Label runat="server" ForeColor="Red" ID="lblerror" /></p>
	
               
              </div>
               <div class="row">
            <span id="Span2"></span>
                            <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">
                  
                    <span class="input-group">
                        <%--<i class="fa fa-envelope"></i>--%>
                       <asp:TextBox ID="txtemaillogin" class="lg" placeholder="Email" AutoComplete="off" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="red" runat="server" ControlToValidate="txtemaillogin" ValidationGroup="login" ErrorMessage="Please enter Email"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="red" runat="server" ControlToValidate = "txtemaillogin" ValidationGroup="login" ValidationExpression= "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please enter valid email address"></asp:RegularExpressionValidator>
                          </span><!-- .input-group -->
                    
                        
               
                     <span class="input-group">
                            <%--<i class="fa fa-lock"></i>--%>
                 	 <asp:TextBox ID="txtpasswordlogin" class="lg" placeholder="Password"  runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ForeColor="red" runat="server" ControlToValidate="txtpasswordlogin" ValidationGroup="login" ErrorMessage="please enter your Password"></asp:RequiredFieldValidator>
                    </span><!-- .input-group -->


                 
                    
                </div><!-- .col-5 -->
                
                  

                <div class="col-lg-7 anim fadeInRight animated" style="visibility: visible;">

              <br />
                    <br />
                    <br />
                    

                    <span class="input-group">
                        <asp:Button ID="btnsignin" CssClass="btn1" runat="server"  Width="35%" ValidationGroup="login" Text="SIGN IN!"/>   <%--<asp:Button ID="btnLoginNo" Width="35%" runat="server" Text="No" CssClass="btn1" /> --%>  
                   <br />  <a href="Index.aspx"   style="color:Red;" >I dont want to Login?</a>
                        
                       

                    </span>
                </div>
         

                    


            </div>
                              </div>
                 </div>







               	</div>

                 </div>
          
                 
                 
                   </div>
       
    
			<script >
			    $(document).ready(function () {
			        $("#tab51").hide();
			        $("#tab53").hide();


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
                            
                            
                            
                            
                            
                              
                           
                        </div>

</asp:Panel>

          </section>





            
                <section id="ko" class="content-section form contact light space">
            <asp:HiddenField ID="hidForModel" runat="server" />
               <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panel1" TargetControlID="hidForModel"  BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="center" style = "display:none">
      
     <div class="header">
                            Order Confirmed
                        </div>
                        <div class="body">
                            
                            <asp:Label  ID="lblDeliveryDate" runat="server" />
                        </div>
                        <div class="footer" >
                           <asp:Button ID="btnclose" CssClass="yes"   runat="server" Text="Yes" />
                            <asp:Button ID="btnNo" runat="server" Text="No" CssClass="no" />
                        </div>

</asp:Panel>

          </section>



            <section id="koUnableToProcess" class="content-section form contact light space">
            <asp:HiddenField ID="hidForModelunable" runat="server" />
               <cc1:ModalPopupExtender ID="mp2" runat="server" PopupControlID="Panel2" TargetControlID="hidForModelunable"  CancelControlID="btnUnableYes" BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel2" runat="server" CssClass="modalPopup" align="center" style = "display:none">
      

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
                        <asp:Button ID="BtnUnableNo" CssClass="btn1" runat="server" ValidationGroup="0" Text="SUBMIT!"/><br />
                    	
                    </span>
                <span class="input-group">
                          <asp:Button ID="btnUnableYes" runat="server" Text="Cancel"   CssClass="btn1" />
                    
                         </span>
                    
                </div>
        
                         
            </div>
            </div></div></div>









                       
                          
                        </div>

</asp:Panel>

          </section>

           <section id="Section1" class="content-section form contact light space">

 <div class="container"> 
          
          
          
            
              <div class="tabs-box">
			
			
                  <div class="clearfix"> </div>
                

		 <div class="tab-grids">
		
             	
			
                  <div class="clearfix"> </div>
    <div  class="tab-grid53">
        	  <div class="content cover text-center">
              <div class="heading">
                <h2 >Getting in touch</h2>
                
                  <p>We are working 24 x 7 to fulfill all your needs. To submit your Enquiries, Please fill this form<br/><br/></p>
              </div>
               
                  <div class="row">
            <span id="message"></span>
            
        
                <div class="col-lg-5 anim fadeInLeft animated" style="visibility: visible;">
                                    
                      <span class="input-group">
                        <%--<i class="fa fa-road"></i>--%>
                       
                       
                    </span>
                    	<span class="input-group">
                        <i class="fa fa-book"></i>

                        <asp:TextBox ID="txtsubjectenquiry" AutoPostBack="true" class="lg" placeholder="Subject" runat="server"></asp:TextBox>
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

          <script>
              window.onload = function () {
                  var dateObj = new Date();

                  var day = dateObj.getDay();
                
              }


            

	</script>


          </form>
  </body>
</html>
