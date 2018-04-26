document.onscroll = function () {
    if ($(window).scrollTop() > $('#menu-master').height()) {
        $('#menu-master').removeClass('navbar-static-top').addClass('navbar-fixed-top');
    }
    else {
        $('#menu-master').removeClass('navbar-fixed-top').addClass('navbar-static-top');
    }
};