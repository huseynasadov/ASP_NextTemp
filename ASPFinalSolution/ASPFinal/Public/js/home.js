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

    $(".labelPosition").on("click", (function () {
        if ($(this).text().trim() == "Candidate") {
            $("#UserPosition").val("true");

        } else {
            $("#UserPosition").val("false");
        } 
    }));

    $("#FormRegister").on("submit", function (event) {
        event.preventDefault();
        var form = $(this);
        var formData = form.serialize();
        
        $.ajax({
            url: form.attr("action"),
            data: formData,
            type: "POST",
            dataType: "json",
            success: function (res) {
                if (res.status) {
                    location.reload();
                } else {
                    alert("this email have system")
                }
            },
            error: function (res) {

            }
        });
    });

    $("#FormLogin").on("submit", function (event) {
        event.preventDefault();
        var form = $(this);
        var formData = form.serialize();
        $.ajax({
            url: form.attr("action"),
            data: formData,
            type: "POST",
            dataType: "json",
            success: function (res) {
                if (res.status) {
                    location.reload();
                } else {
                    alert("please, do register")
                }
            },
            error: function (res) {

            }
        });
    });

})(jQuery)