$(document).ready(function () {
    $('.popup-gallery').magnificPopup({
        delegate: 'a',
        type: 'image',
        tLoading: 'Loading image #%curr%...',
        mainClass: 'mfp-img-mobile',
        gallery: {
            enabled: true,
            tCounter: '%curr% из %total%',
            navigateByImgClick: true,
            preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
        },
        image: {
            tError: '<a href="%url%">The image #%curr%</a> could not be loaded.',
            //titleSrc: function (item) {
            //    return item.el.attr('title') + '<small>by Marsel Van Oosten</small>';
            //}
        }
    });


    //форма контактной информации
    if ($("#contactForm").length > 0) {
        $("#contactForm").on('submit', function (e) {
            e.preventDefault();
            $("#con_submit").html('ПОДОЖДИТЕ');
            var con_name = $("#f_name").val();
            var con_email = $("#f_email").val();
            var con_message = $("#con_message").val();

            var required = 0;
            $(".required", this).each(function () {
                if ($(this).val() == '') {
                    $(this).addClass('reqError');
                    required += 1;
                }
                else {
                    if ($(this).hasClass('reqError')) {
                        $(this).removeClass('reqError');
                        if (required > 0) {
                            required -= 1;
                        }
                    }
                }
            });

            if (required === 0) {
                $.ajax({
                    type: "POST",
                    url: '../Home/SendMessage',
                    data: { name: con_name, email: con_email, message: con_message },
                    success: function (data) {
                        $("#con_submit").html('отправлено!');
                        $("#contactForm #f_name").val('');
                        $("#contactForm #f_email").val('');
                        $("#contactForm #con_message").val('');
                    }
                });
            }
            else {
                $("#con_submit").html('ошибка');
            }

        });
    }


});