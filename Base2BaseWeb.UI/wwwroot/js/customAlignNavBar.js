//$(window).on('load', toggleMenuStaticClasses);
//$(window).on('load', toggleMenuFixedClasses);

//$(window).resize(toggleMenuStaticClasses);
//$(window).resize(toggleMenuFixedClasses);

//function toggleMenuStaticClasses() {
//    if (window.innerWidth <= 1200) {
//        $('#menu-static-left').removeClass('menu-static-left');
//        $('#menu-static-center').removeClass('menu-static-center');
//        $('#menu-static-right').removeClass('menu-static-right');

//        $('#menu-static-left').removeClass('navbar-nav');
//        $('#menu-static-center').removeClass('navbar-nav');
//        $('#menu-static-right').removeClass('navbar-nav');

//        $('#menu-static > nav').addClass('inline-navbar');
//    }
//    else {
//        $('#menu-static-left').addClass('menu-static-left');
//        $('#menu-static-center').addClass('menu-static-center');
//        $('#menu-static-right').addClass('menu-static-right');

//        $('#menu-static-left').addClass('navbar-nav');
//        $('#menu-static-center').addClass('navbar-nav');
//        $('#menu-static-right').addClass('navbar-nav');

//        $('#menu-static > nav').removeClass('inline-navbar');
//    }
//}

//function toggleMenuFixedClasses() {
//    if (window.innerWidth <= 1200) {
//        $('#menu-fixed-left').removeClass('menu-fixed-left');
//        $('#menu-fixed-center').removeClass('menu-fixed-center');
//        $('#menu-fixed-right').removeClass('menu-fixed-right');
//    }
//    else {
//        $('#menu-fixed-left').addClass('menu-fixed-left');
//        $('#menu-fixed-center').addClass('menu-fixed-center');
//        $('#menu-fixed-right').addClass('menu-fixed-right');
//    }
//}

$(window).on('load', toggleMenuStaticPosition);
$(window).on('load', toggleMenuFixedPosition);

$(window).resize(toggleMenuStaticPosition);
$(window).resize(toggleMenuFixedPosition);

function toggleMenuStaticPosition() {
    if (window.innerWidth <= 1200) {
        //$('#menu-static-left').css('position','static');
        //$('#menu-static-center').css('position', 'static');
        //$('#menu-static-right').css('position', 'static');
    }
    else {
        //$('#menu-static-left').css('position', 'relative');
        //$('#menu-static-center').css('position', 'relative');
        //$('#menu-static-right').css('position', 'relative');
    }
}

function toggleMenuFixedPosition() {
    if (window.innerWidth <= 1200) {
        //$('#menu-fixed-left').css('position', 'static');
        //$('#menu-fixed-center').css('position', 'static');
        //$('#menu-fixed-right').css('position', 'static');
    }
    else {
        //$('#menu-fixed-left').css('position', 'relative');
        //$('#menu-fixed-center').css('position', 'relative');
        //$('#menu-fixed-right').css('position', 'relative');
    }
}