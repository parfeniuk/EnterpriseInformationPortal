$(window).resize(function () {
    if (window.innerWidth <= 1200) {
        $('#authSection').removeClass('navbar-right');
    }
    else
        if (!$('#authSection').hasClass('navbar-right'))
            $('#authSection').addClass('navbar-right');
});