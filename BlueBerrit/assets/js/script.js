/*-----------------------------------------
Designed and Developed by http://nisquaretech.com/
-------------------------------------------*/
function initNavbar() {

    var scrollSpeed = 750;
    var scrollOffset = 68;
    var easing = 'swing';

    $('#navbar-top .navbar-default ul.nav').onePageNav({
        currentClass: 'active',
        changeHash: false,
        scrollSpeed: scrollSpeed,
        scrollOffset: scrollOffset,
        scrollThreshold: 0.5,
        filter: ':not(.external)',
        easing: easing
    });

    $('.nav-external').click(function (e) {
        e.preventDefault();
        $('html, body').stop().animate({
            scrollTop: $($(this).attr("href")).offset().top - scrollOffset
        }, scrollSpeed, easing);
    });

    $('#navbar-top .navbar-default').affix({
        offset: {
            top: '0'
        }
    });
}
function initPortfolio () {
    var portfolio = $('#portfolio');
    var items = $('.items', portfolio); 
    var filters = $('.filters li a', portfolio); 

    items.imagesLoaded(function() {
        items.isotope({
            itemSelector: '.item',
            layoutMode: 'fitRows',
            transitionDuration: '0.7s'
        });
    });
    
    filters.click(function(){
        var el = $(this);
        filters.removeClass('active');
        el.addClass('active');
        var selector = el.attr('data-filter');
        items.isotope({ filter: selector });
        return false;
    });   
}
function initAnimations() {
    $('.animated').appear(function () {
        var el = $(this);
        var animation = el.data('animation');
        var delay = el.data('delay');
        if (delay) {
            setTimeout(function () {
                el.addClass(animation);
                el.addClass('showing');
                el.removeClass('hiding');
            }, delay);
        } else {
            el.addClass(animation);
            el.addClass('showing');
            el.removeClass('hiding');
        }
    }, {
        accY: -60
    });

    // Service hover animation
	$('.service').hover(function(){
		$('i', this).addClass('animated tada');
	},function(){	
        $('i', this).removeClass('animated tada');
	});
}
//function initStart(){
//	var homeHeight = '418';
//	$('#home').height(homeHeight);
//	// fancybox
//    $(".fancybox").fancybox();
//	$('.collapse ul li a').click(function(){ 
//		$(this).parents('.collapse').removeClass('in');
//		});
//	}
 
$(document).ready(function () {	
	//initStart()
    initNavbar();
    initPortfolio();
    initAnimations(); 
	//$(window).resize(function(){
	//	initStart()
	//});
});
$(window).load(function () {
    $(".loader .fading-line").fadeOut();
    $(".loader").fadeOut("slow");
});
 




// Login Form
$(function () {
    var button = $('#loginButton');
    var box = $('#loginBox');
    var form = $('#loginForm');
    button.removeAttr('href');
    button.mouseup(function (login) {
        box.toggle();
        button.toggleClass('active');
      
    });
    form.mouseup(function () {
        return false;
    });
    $(this).mouseup(function (login) {
        if (!($(login.target).parent('#loginButton').length > 0)) {
            button.removeClass('active');
            box.hide();

            document.getElementById("txtpasswordlogin").value = null;
            document.getElementById("txtemaillogin").value = null;
            //document.getElementById("RequiredFieldValidator5").innerHTML = "";
            ////document.getElementById("RegularExpressionValidator1").innerHTML = "";
            //document.getElementById("RequiredFieldValidator7").innerHTML = "";
            //$('#RegularExpressionValidator1').hide();
            //$('#RequiredFieldValidator5').hide();
            //$('#RequiredFieldValidator7').hide();
           // document.getElementById("<%=RequiredFieldValidator5.ClientID%>").style.visibility = "hidden";
            //document.getElementById("<%=RegularExpressionValidator1.ClientID%>").style.visibility = "hidden";
            //document.getElementById("<%=RequiredFieldValidator7.ClientID%>").style.visibility = "hidden";
                    }
    });
});
