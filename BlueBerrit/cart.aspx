<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="cart.aspx.vb" Inherits="BlueBerrit.cart" %>
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

     <style type="text/css">
   
    .modalPopup
    {
        background-color: #FFFFFF;
      width:50%;
        border: 0.5px solid black;
    }
  
</style>

  




       <script type = "text/javascript">
          


           $(document).ready(function () {
               $('#signup').click(function (event) {

                   $('#submenu').toggle(1000);
               });
           });
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
             
                
                  <li >
                <a href="#work-a">Payment</a>
              </li>
             
            
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
      
        <a href="index.aspx">LOGOUT</a>
    </div>

                       <%-- UNPAID ORDERS added--%>

            <asp:ScriptManager runat="server"></asp:ScriptManager>

            <input type="hidden" runat="server" id="key" name="key" />
      <input type="hidden" runat="server" id="hash" name="hash"  />
            <input type="hidden" runat="server" id="txnid" name="txnid" />
       

          <section id="koUnableToProcess" class="content-section form contact light space">
            <asp:HiddenField ID="hidForModelunable" runat="server" />
               <cc1:ModalPopupExtender ID="mp2" runat="server" PopupControlID="Panel2" TargetControlID="hidForModelunable"  BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel2" runat="server" CssClass="modalPopup" align="center" style = "display:none">
      
     <div class="header1">
                            Notification
                        </div>
                        <div class="body1">
                            <asp:Label ID="lblunabletoProcess"  runat="server" />
                        </div>
                        <div class="footer1" >
                       
                            <asp:Button ID="btnNo" runat="server" Text="OK" CssClass="yes" />
                        </div>

</asp:Panel>

          </section>

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


             <section id="koUnableToProcessPay" class="content-section form contact light space">
         
               <cc1:ModalPopupExtender ID="mp4" runat="server" PopupControlID="Panel3" TargetControlID="linkProceedPayment"  BackgroundCssClass="modalBackground">
</cc1:ModalPopupExtender>
<asp:Panel ID="Panel3" runat="server" CssClass="modalPopup" align="center" style = "display:none">
      
     <div class="header1">
                            Confirmation
                        </div>
                        <div class="body1">
                            Do you want To Proceed Checkout?
                        </div>
                        <div class="footer1" >
                       
                            <asp:Button ID="btnpay" runat="server" Text="OK"  OnClick="linkProceedPayment_click" CssClass="yes" />
                        </div>

</asp:Panel>

          </section>

  
    <section id="work-a" >
      <div class="cart">
     <div class="container">
     

         
         
          
          <asp:Panel ID="Pnlawaitingorder" runat="server">
                      <div class="col-md-9 cart-items">
                       
                <h2>My Food Bag (This order is awaiting your payment) (<asp:Label ID="lblfoodbagcount" runat="server" />)</h2>
                
               <asp:Repeater ID="RepeaterImagestab1" runat="server"  OnItemCommand="rptList_ItemCommand"  >
    <ItemTemplate >
                           <div class="cart-header">
                    <div class="close1">     <asp:LinkButton ID="linkCancelCart"  runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "lnkMakerID")%>' CommandName="CancelCart"> <img src="images/close.png"  alt="Cancel cart" />
                                             </asp:LinkButton>
                  
                    </div>
<div class="close3">
       <asp:LinkButton ID="linkCodCheckOut"  runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "lnkMakerID")%>' CommandName="ProceedPayment"> <img src="images/cod.jpg" height="28px" width="38px"  alt="Cancel cart" />
                                             </asp:LinkButton>
</div>

                    <div class="cart-sec">
                        <div class="cart-item cyc">
                          <asp:image runat="server" ID="ImgsingleAnimImag"  ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
                            <asp:button ID="linkOnlineCheckOut"  runat="server"  CssClass="btn1" Height="40%"  Text="Proceed Payment" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "lnkMakerID")%>' CommandName="ProceedOnlinePayment"></asp:button>
                        </div>
                        <div class="cart-item-info">
                           <h4><asp:Label runat="server" Text="Delivery date :" /> <asp:Label ID="lblOrderDAte" Text= '<%# Eval("lblMenuDAte")%>' runat="server" > </asp:Label> </h4><br />
                              <h4><asp:Label runat="server" Text="Restaurant &nbsp;&nbsp;&nbsp; :" /> <asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </h4><br />
                         <h4><asp:Label runat="server"  Text  ="Dish &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:" /> <asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" >  </asp:Label>  <asp:Label ID="lblmakerid" Text= '<%# Eval("lblmakerid")%>' Visible="false" runat="server" >  </asp:Label> </span></h4><br />
                               <h4><span>  </span><asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <span>  </span> + <asp:Label Text="  Tax:: Rs." runat="server" />  <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label>   &nbsp;&nbsp;&nbsp;   <span>  </span> <asp:Label Text=" Qty :: " runat="server" />  <asp:label  runat="server" id="quantity"  text='<%# Eval("lblquantity")%>'  /></h4> <br />
                            <h4><span></span><asp:Label runat="server"  Text  ="Order status :" />  <asp:Label ID="lblpaymentstatus" runat="server" Text= '<%# Eval("lblpaymentstatus")%>'> </asp:Label>  </h4>    
                        </div>
                        <div class="clearfix"></div>
                        <div class="delivery">
                             
                        <p>   Delivered   On &nbsp; <asp:Label ID="lblmenudate" runat="server" Text= '<%# Eval("lblMenuDAte")%>'> </asp:Label>    </p> <br />
                            <p>  [12.00 P.M to 12.30 P.M]  </p>
                            <section id="koCancelCart" >
                              <cc1:ConfirmButtonExtender ID="cbe" runat="server" DisplayModalPopupID="mpe" TargetControlID="linkCancelCart">
                    </cc1:ConfirmButtonExtender>
                    <cc1:ModalPopupExtender ID="mpe" runat="server" PopupControlID="pnlPopup" TargetControlID="linkCancelCart"
                        OkControlID="btnYes" CancelControlID="btnNo" BackgroundCssClass="modalBackground">
                    </cc1:ModalPopupExtender>
           <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="header1">
                            Confirmation
                        </div>
                        <div class="body1">
                            Do you want to cancel your Order?
                        </div>
                        <div class="footer1" >
                            <asp:Button ID="btnYes"  runat="server"  CssClass="yes"  Text="yes" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "lnkMakerID")%>' CommandName="CancelCart" />
                            <asp:Button ID="btnNo" runat="server" Text="No" CssClass="no" />
                        

                        </div>
                    </asp:Panel>
                          </section>

                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
              </ItemTemplate></asp:Repeater>
           
            </div>
               </asp:Panel>
          
         
          <asp:Panel ID="pnlAddpayment" runat="server">
         <div class="col-md-3 cart-total">
			 <a class="continue" href="Default.aspx">Back to Menu</a>
			 <div class="price-details">
				 <h3>Price Details</h3>
				 <span>Total</span>
				 <span class="total"><asp:Label ID="lblsubtotal" runat="server" /></span>
				 <span>Tax</span>
				 <span class="total"><asp:Label ID="lbltaxAmount" runat="server" /></span>
				 <span>Delivery Charges</span>
				 <span class="total" >Rs. 0.00</span>
				 <div class="clearfix"></div>				 
			 </div>	
			 <h4 class="last-price">TOTAL</h4>
			 <span class="total final"><asp:Label ID="lbltotalAmount" runat="server" /></span>
			 <div class="clearfix"></div>
             <asp:CheckBox ID="cbCashOndelivery" runat="server" Text="Cash on delivery" Enabled="false" Checked="true" />
			<asp:LinkButton ID="linkProceedPayment" class="order"   Text="Proceed Payment"   Visible="false" runat="server"  OnClick="linkProceedPayment_click" ></asp:LinkButton>
			</div>
         </asp:Panel>

        
       <asp:Panel ID="pnlconfirmCart" runat="server">
         <div class="col-md-9 cart-items">
                <h2>My Food Bag Confirm Orders (<asp:Label ID="lblfoodbagcountPaid" runat="server" />)</h2>
              
               <asp:Repeater ID="RepeaterImagestab2" runat="server"    >
    <ItemTemplate >
                           <div class="cart-header">
                                 <div class="close2">  <button type="button" id="more"  style="background-color:transparent;"  data-toggle="collapse" data-target='#<%# Eval("lnkmakerid")%>' > 
                           
				 <img src="images/trackorder.png" width="40" height="35"  alt="Track cart" />
		</button>       </div>
                    <div class="close1">   </div>
                    <div class="cart-sec">
                        <div class="cart-item cyc">
                          <asp:image runat="server" ID="ImgsingleAnimImag"  ImageUrl= '<%# Eval("ImgsingleAnimImag1")%>'   />
                        </div>
                        <div class="cart-item-info">
                            <h4><asp:Label runat="server" Text="Delivery date :" /> <asp:Label ID="lblOrderDAte" Text= '<%# Eval("lblMenuDAte")%>' runat="server" > </asp:Label> </h4><br />
                            <h4><asp:Label runat="server" Text="Restaurant &nbsp;&nbsp;&nbsp; :" /> <asp:Label ID="lblRestaurantLoc" Text= '<%# Eval("lblRestaurantLoc")%>' runat="server" > </asp:Label> </h4><br />
                         <h4><asp:Label runat="server"  Text  ="Dish &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:" /> <asp:Label ID="lblmenu" Text= '<%# Eval("lblmenu")%>' runat="server" > </asp:Label></span></h4><br />
                               <h4><span>  </span><asp:Label ID="lblprice" Text= '<%# Eval("lblprice")%>' runat="server" > </asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <span>  </span> + <asp:Label Text="  Tax:: Rs." runat="server" />  <asp:Label ID="lblMenuTax" runat="server" Text= '<%# Eval("lblMenuTax")%>'> </asp:Label>   &nbsp;&nbsp;&nbsp;   <span>  </span> <asp:Label Text=" Qty :: " runat="server" />  <asp:label  runat="server" id="quantity"  text='<%# Eval("lblquantity")%>'  /></h4><br />
                          <h4><asp:Label Text="Total &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;: Rs." runat="server" />  <asp:Label ID="lblconfirmcartGrandTotal" runat="server" Text= '<%# Eval("lblconfirmcartGrandTotal")%>'> </asp:Label>    &nbsp;&nbsp;&nbsp;   <span>  </span> <asp:Label Text=" Track Id : " runat="server" />  <asp:label  runat="server" id="lblconfirmcartTrackID"  text='<%# Eval("lnkmakerid")%>'  /> </h4>
                    
                               </div>
                        <div class="clearfix"></div>
                        <div class="delivery">
                              <div id='<%# Eval("lnkmakerid")%>' class="collapse" >  
                             <p>Payment status&nbsp;&nbsp;&nbsp;::  <asp:Label ID="lblpaidstatus" runat="server" Text= '<%# Eval("lblpaidstatus")%>'> </asp:Label></p>   <br />    
                                   <p>Process status&nbsp;&nbsp;&nbsp;&nbsp;::  <asp:Label ID="lblprocessstatus" runat="server" Text= '<%# Eval("lblprocessstatus")%>'> </asp:Label></p><br />
                        <p>Shipment status&nbsp;&nbsp;::  <asp:Label ID="lblshipmentstatus" runat="server" Text= '<%# Eval("lblshipmentstatus")%>'> </asp:Label></p>    <br /> 
                                   <p>Delivery status&nbsp;&nbsp;&nbsp;&nbsp;::  <asp:Label ID="lbldespatchstatus" runat="server" Text= '<%# Eval("lbldespatchstatus")%>'> </asp:Label></p><br />
                                  
                                   <p>   Delivered  12.00 P.M to 12.30 P.M On &nbsp; <asp:Label ID="lblmenudate" runat="server" Text= '<%# Eval("lblMenuDAte")%>'> </asp:Label>    </p>
                                                                    </div>
                             
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
              </ItemTemplate></asp:Repeater>
           
            </div>
         
         </asp:Panel>



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
    </script>
          </form>
  </body>
</html>
