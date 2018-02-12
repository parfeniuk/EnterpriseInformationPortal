$(window).resize(function () {
    if (window.innerWidth <= 1200) {
        $('.menu-right').removeClass('navbar-right');
    }
    else
        if (!$('.menu-right').hasClass('navbar-right'))
            $('.menu-right').addClass('navbar-right');
});