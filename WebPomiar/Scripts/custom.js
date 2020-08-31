$(function () {

    $(window).on('scroll', function () {
        if ($(window).scrollTop() > 10) {
            $('.navbar').addClass('active');
        }
        else {
            $('.navbar').removeClass('active');

        }

    });


});





$(window).scroll(function () {
    if ($(this).scrollTop() > 100) {
        $('.scrollup').fadeIn();
    } else {
        $('.scrollup').fadeOut();
    }
});

$('.scrollup').click(function () {
    $("html, body").animate({
        scrollTop: 0
    }, 500);
    return false;
});


jQuery(function ($) {
    //zresetuj scrolla
    $.scrollTo(0);

    $('#link0').click(function () { $.scrollTo($('body'), 600); });
    $('#link1').click(function () { $.scrollTo($('#about'), 500); });
    $('#link2').click(function () { $.scrollTo($('#features'), 500); });
    $('#link3').click(function () { $.scrollTo($('#download'), 500); });
    $('#link4').click(function () { $.scrollTo($('#pricing'), 500); });
    $('#link5').click(function () { $.scrollTo($('#contact'), 500); });
    $('#link6').click(function () { $.scrollTo($('#pricing'), 700); });
    $('#link7').click(function () { $.scrollTo($('#download'), 700); });

}
);





