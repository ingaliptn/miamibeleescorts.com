
/* Global Variables */
/*------------------------------------------------------------------>*/
var windowWidth = jQuery(window).width();
var windowHeight = jQuery(window).height();
/* Bootstrap Modal Vertical Align Middle */
/*------------------------------------------------------------------>*/
function centerModal() {
		jQuery(this).css('display', 'block');
		var dialog  = jQuery(this).find(".modal-dialog"),
		offset       = (jQuery(window).height() - dialog.height()) / 2,
		bottomMargin = parseInt(dialog.css('marginBottom'), 10);
		if(offset < bottomMargin) offset = bottomMargin;
		dialog.css("margin-top", offset);
}

function roomRentImages() {
	var imageHeight = jQuery('.service-block img').height();
	jQuery('.service-block figure').css('max-height', imageHeight);
}
/* SyncHeight Custom Function */
/*------------------------------------------------------------------>*/
function heightAdjust() {
 	if(jQuery(window).width() < 767) {
		jQuery('.schedule-content').each(function() {
			jQuery('.schedule-box ul').unSyncHeight();
		});
        	jQuery('.home-content .home-content-inn').unSyncHeight();
        	jQuery('.heightAdjust .home-content-inn').unSyncHeight();
		jQuery('.home-content-inn').unSyncHeight();
		jQuery('.service-content').unSyncHeight();
		jQuery('.hostess-box').unSyncHeight();

 	} else {
		jQuery('.schedule-content').each(function() {
			jQuery('.schedule-box ul').syncHeight({updateOnResize: true});
		});
        	jQuery('.home-content .home-content-inn').syncHeight({updateOnResize: true});
        	jQuery('.heightAdjust .home-content-inn').syncHeight({updateOnResize: true});
		jQuery('.home-content-inn').syncHeight({updateOnResize: true});
		jQuery('.service-content').syncHeight({updateOnResize: true});
		jQuery('.hostess-box').syncHeight({updateOnResize: true});
 	}

 }
/*------------------------------------------------------------------>*/
jQuery(document).ready(function () {
	/* Header Nav Responsive
	==================================*/
	jQuery('.header-nav').flexMenu({ responsivePattern: 'toggle', breakpoint: 991});
	jQuery('.menu-icon').click(function() {
		jQuery(this).toggleClass('close-menu');
	});

	/* Home Page | Banner Carousel
        /*------------------------------------------------------------------>*/
	jQuery('.banner-owlcarousel').owlCarousel({
                loop:true,
                margin:0,
                responsiveClass:true,
                nav:true,
                dots:false,
		autoplay:true,
		autoplayTimeout:5000,
		autoplayHoverPause:false,
                navText: ['<i class="fa fa-angle-left"></i>', '<i class="fa fa-angle-right"></i>'],
                responsive:{
                        0:{ items:1 },
                        1000:{ items:1}
                }
        });

	/* Description Page | Hostess bxSlider
        /*------------------------------------------------------------------>*/
	jQuery('.bxSlider').bxSlider({pagerCustom: '#bx-pager', controls:true, pause:5000, auto:true, adaptiveHeight:true,});
	jQuery("#bx-pager ul").bxSlider({
		auto:true,
		minSlides: 1,
		maxSlides: 6,
		slideWidth:100,
		slideMargin: 3,
		moveSlides: 2,
		pager:false,
		speed:400,
		pause:5000,
		controls:true,
		infiniteLoop:false,
		mode:'horizontal',
	});

	/* Tour Page | Rooms and Spa Tabs
        /*------------------------------------------------------------------>*/
        jQuery('.tour-tab li').click(function(){
            if(!jQuery(this).hasClass('active-tab')) {
               var slidetab  = '.tour-slider .'+ jQuery(this).attr('data-tab');
               jQuery('.tour-tab li.active-tab').removeClass('active-tab');
               jQuery(this).addClass('active-tab');
               jQuery('.tour-slider section').css({"height": "0", "overflow": "hidden"})
               jQuery(slidetab).removeAttr("style");
            }

        });

	/* Description Page | All Review & Add an Reviews
	/*------------------------------------------------------------------>*/
	jQuery('.reviews-tab li').click(function(){
	    if(!jQuery(this).hasClass('active')) {
	       var slidetab  = '.reviews-tab-container #'+ jQuery(this).attr('data-tab');
	       jQuery('.reviews-tab li.active').removeClass('active');
	       jQuery(this).addClass('active');
	       jQuery('.review-container').css({"display": "none"});
	       jQuery(slidetab).css({"display": "block"});
	    }
	});

	/* Description Page | Availability Tabs
	/*------------------------------------------------------------------>*/
	jQuery('.availability-tab li').click(function(){
	    if(!jQuery(this).hasClass('active')) {
	       var slidetab  = '.availability-tab-container #'+ jQuery(this).attr('data-tab');
	       jQuery('.availability-tab li.active').removeClass('active');
	       jQuery(this).addClass('active');
	       jQuery('.availability-box').css({"display": "none"});
	      jQuery(slidetab).css({"display": "block"});
	    }
	});

        jQuery('.schedule-tab li span').click(function(){
	    if(!jQuery(this).hasClass('active')) {
	       var slidetab  = '#'+ jQuery(this).attr('data-tab');
	       jQuery('.schedule-tab span.active').removeClass('active');
	       jQuery(this).addClass('active');
	       jQuery('.hostess-schedule-box').css({"display": "none"});
	      jQuery(slidetab).css({"display": "block"});
	    }
	});

	/* Callback Function
        /*------------------------------------------------------------------>*/
	heightAdjust();
	roomRentImages();
    jQuery(document).on('show.bs.modal', '.modal', centerModal);

        /***************Add Event******************/

    jQuery("#wpcf7-f542-o1 input[type='submit']").attr("onClick","ga('send', 'event', { eventCategory: 'from', eventAction: 'submit', eventLabel: 'contact'});");
    jQuery("#wpcf7-f295-o1 input[type='submit']").attr("onClick","ga('send', 'event', { eventCategory: 'from', eventAction: 'submit', eventLabel: 'contact'});");
});
/*------------------------------------------------------------------>*/
jQuery(window).on('load resize', function() {
	/* 	Callback Function
        /*------------------------------------------------------------------>*/
	heightAdjust();
	roomRentImages();
        jQuery('.modal:visible').each(centerModal);
	if(jQuery(window).width() > 991) {
		jQuery('.menu-icon').removeClass('close-menu');
	}
});
