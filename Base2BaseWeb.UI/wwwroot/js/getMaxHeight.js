//$('.tabpanel #tb3').on('click', function (e) {
//    var highest = $('.billSettings-container').height();
//    $('.debtControl-container').css('height', highest);
//    e.preventDefault();
//});

//$('.billSettings-container').height() = height;
//$('.debtControl-container').height() = height;

function getMaxHeight () {
    var highest = null;
    var hi = 0;
    $(".panel").each(function () {
        var h = $(this).height();
        if (h > hi) {
            hi = h;
            highest = $(this);
        }
    });
    return hi;
}