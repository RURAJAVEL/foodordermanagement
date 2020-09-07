<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="OrderConfirmation.aspx.vb" Inherits="BlueBerrit.orderconfirmation" %>
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
   

    <%--  <link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />--%>
<link href="css/cartstyle.css" rel="stylesheet" type="text/css" media="all" />
<%--  <link href='https://blueberrit/assets/font/font2.css' rel='stylesheet' type='text/css'>--%>
<%--  <link href='https://blueberrit/assets/font/font3.css' rel='stylesheet' type='text/css'>--%>
<link rel="stylesheet" type="text/css" href="css/component.css" />

<script src="js/jquery.min.js"></script>
<script src="js/simpleCart.min.js"> </script>


  
       <script type = "text/javascript">
         

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
         <a href="cart.aspx"> CART </a> &nbsp; 
        <a href="index.aspx">LOGOUT</a>
    </div>

                   
  
    <section id="work-a" class="page">
      <div class="cart">
     <div class="container">
     


         
          
          
          
         
          

        
       <asp:Panel ID="pnlconfirmCart" runat="server">
       
             <div class="col-md-9 cart-items">
             
                <h2 style="background-color:white;text-align:center;color:#0078c1;"> Order  Confirmed <asp:Label ID="lblfoodbagcountPaid" runat="server" Visible="false" /></h2>
                 <asp:Panel ID="Panel2" runat="server">
               <asp:Repeater ID="RepeaterImagestab2" runat="server"   >
    <ItemTemplate >
                           <div class="cart-header">
                  
                    <div class="cart-sec">
                         <div class="cart-item1 cyc"  >
                          <asp:image runat="server" ID="ImgsingleAnimImag"  ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
                        </div>
                         
                        <div class="cart-item-info">
                           
                 
                
                        <%--<h2 style="background-color:#0078c1;text-align:center;color:white;"> Order Summary </h2>--%>
               
                                         
                               <div class="plans_table">
                    <center>   <table width="100%"  cellspacing="0" class="compare_plan">
												<thead>
								   					<tr>
								        				<th class="plans-list"><h3>Order summary</h3></th>
								        				<th class="plans-list"><h3></h3></th>
								        			<th class="plans-list"><h3></h3></th>
								    				</tr>
												</thead>
																
								   				<tbody>
								   					<tr>
                                                          
									        			<td class="plan_list_title">Restautant</td>
												        <td class="price_body"><asp:Label ID="lblRestaurantLoc" ForeColor="#0078c1" Width="100%" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label></td>
												      
									    			</tr>
								    				<tr>
								        				<td class="plan_list_title">Dish</td>
														<td class="price_body"><asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" ForeColor="#0078c1" > </asp:Label> </td>
										        		
								    				</tr>
								    				<tr>
								        				<td class="plan_list_title">Rate</td>
											    	    <td class="price_body"><asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label></td>
											        	
													</tr>
								    				<tr>
											    	    <td class="plan_list_title">Tax</td>
											        	<td class="price_body"><asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label></td>
												      
								    				</tr>
								    				<tr>
								        				<td class="plan_list_title">Quantity</td>
									        			<td class="price_body"><asp:label  runat="server" id="quantity"  text='<%# Eval("lblquantity")%>'  /></td>
												    
								    				</tr>
									    			<tr>
								    	    			<td class="plan_list_title">Total</td>
								        				<td class="price_body"><asp:Label ID="lblconfirmcartGrandTotal" runat="server" Text= '<%# Eval("lblconfirmcartGrandTotal")%>'> </asp:Label></td>
												    
									    			</tr>
								    				<tr>
								        				<td class="plan_list_title">Order status</td>
												        <td class="price_body"><asp:Label ID="lblpaymentstatus" runat="server" Text= '<%# Eval("lblpaymentstatus")%>'> </asp:Label></td>
											    	
								    				</tr>
								    				<tr>
								        				<td class="plan_list_title">Delivered</td>
								        				<td class="price_body"><asp:Label ID="lblmenudate" runat="server" Text= '<%# Eval("lblMenuDAte")%>'> </asp:Label></td>
											        
								    				</tr>
								    				<tr>
								        				<td class="plan_list_title"></td>
												    	<td class="price_body"><asp:label  runat="server" id="lblconfirmcartTrackID"  Visible="false" text='<%# Eval("lnkmakerid")%>'  /></td>
												    
								    				</tr>

                                                       <tr>
								        				<td class="plan_list_title" ></td>
								    				<td class="plan_list_title" style="color:#0078c1;">Delivery Details</td>
                                                           </tr>

                                                        <tr>
								        				<td class="plan_list_title"></td>
								    				<td class="plan_list_title"><asp:Label ID="lblOfficeName" ForeColor="#0078c1" runat="server" Text= '<%# Eval("lblOfficeName")%>'> </asp:Label></td>
                                                           </tr>

                                                        <tr>
								        				<td class="plan_list_title"></td>
								    				<td class="plan_list_title"><asp:Label ID="lblOfficeAddress" ForeColor="#0078c1" runat="server"  Text= '<%# Eval("lblOfficeAddress")%>'> </asp:Label> </td>
                                                           </tr>

                                                        <tr>
								        				<td class="plan_list_title"></td>
								    				<td class="plan_list_title"><asp:Label ID="lblBuildingNAme" runat="server" ForeColor="#0078c1"  Text= '<%# Eval("lblBuildingNAme")%>'> </asp:Label></td>
                                                           </tr>

                                                        <tr>
								        				<td class="plan_list_title"></td>
								    				<td class="plan_list_title"><asp:Label ID="lblDeliveryAddress" ForeColor="#0078c1" runat="server"  Text= '<%# Eval("lblDeliveryAddress")%>'> </asp:Label></td>
                                                           </tr>

												</tbody></table>  	</center>
                             </div>

                       

                           
                      

                            <div class="clearfix"></div>

                             
                          
                            
                                </div>
                        <div class="clearfix"></div>
                      
                      


                       


                    </div>
                </div>
              </ItemTemplate></asp:Repeater>
            </asp:Panel>
            </div></asp:Panel>





         <asp:Panel ID="pnlAddpayment" runat="server">
         <div class="col-md-3 cart-total">
			 <a class="continue" href="Default.aspx">Back to Menu</a>
			 <div class="price-details">
				 <h3>Notification Details</h3>
				
				 <asp:textbox ID="txtNotificationEmail" palceholder="Mail ID" runat="server" > </asp:textbox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="red" runat="server" ControlToValidate="txtNotificationEmail" ValidationGroup="2" ErrorMessage="Please enter Email"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="erremailval" runat="server" ForeColor="red" ControlToValidate = "txtNotificationEmail" ValidationGroup="2" ValidationExpression= "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Please enter valid email address"></asp:RegularExpressionValidator>
                     <br />
                     <asp:textbox ID="txtNotificationMobileNo" runat="server" placeholder="Mobile No" > </asp:textbox>

                       <asp:RequiredFieldValidator runat="server" ID="errmobile" ForeColor="red" ControlToValidate="txtNotificationMobileNo" ValidationGroup="2" ErrorMessage="please enter mobileno" />
                          <asp:RegularExpressionValidator ID="errmobileval" ForeColor="red" runat="server" ErrorMessage="Phone Number is not valid" validationGroup="2" ControlToValidate="txtNotificationMobileNo" ValidationExpression="^(1\s*[-\/\.]?)?(\((\d{3})\)|(\d{3}))\s*[-\/\.]?\s*(\d{3})\s*[-\/\.]?\s*(\d{4})\s*(([xX]|[eE][xX][tT])\.?\s*(\d+))*$"></asp:RegularExpressionValidator>
				
				
				
			
				
				 <div class="clearfix"></div>				 
			 </div>	
			
			 <div class="clearfix"></div>
          
			<asp:LinkButton ID="linkUpdateNotificationContact" class="order"   Text="Update Details" ValidationGroup="2" OnClick="linkchangeNotification_click"   Visible="true" runat="server"  ></asp:LinkButton>
			</div>
     </asp:Panel>


        </div>  
      </div>
    </section>
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
