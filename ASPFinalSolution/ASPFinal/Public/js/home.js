/* Theme Name: Joobsy - Responsive Landing Page Template
   Author: Themesdesign
   Version: 1.0.0
*/


(function ($) {

    'use strict';

    //owlCarousel
    $("#owl-testi").owlCarousel({
        autoPlay: 3000, //Set AutoPlay to 3 seconds
        items: 2,
        itemsDesktop: [1199, 2],
        itemsDesktopSmall: [979, 2]
    });

    //$(".labelPosition").on("click", (function () {
    //    if ($(this).text().trim() == "Candidate") {
    //        $("#UserPosition").val("0");
    //    } else {
    //        $("#UserPosition").val("1");
    //    } 
    //}));
})(jQuery)