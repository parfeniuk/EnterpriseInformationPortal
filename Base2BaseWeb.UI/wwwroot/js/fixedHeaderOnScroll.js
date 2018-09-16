$(window).scroll(function () {
    fixHeaderOnScroll();
});
var rowTdWidth = $('#clients-row-td').width();

var td1Width = $('#clients-td-1').width();
var td2Width = $('#clients-td-2').width();
var td3Width = $('#clients-td-3').width();
var td4Width = $('#clients-td-4').width();
var td5Width = $('#clients-td-5').width();
var td6Width = $('#clients-td-6').width();
var td7Width = $('#clients-td-7').width();

//var header = $('#headerFixed');
//var headerOffsetTop = header.offset().top;

function fixHeaderOnScroll() {

    $('#clients-row-th').width(rowTdWidth);
    $('#clients-th-1').width(td1Width);
    $('#clients-th-2').width(td2Width);
    $('#clients-th-3').width(td3Width);
    $('#clients-th-4').width(td4Width);
    $('#clients-th-5').width(td5Width);
    $('#clients-th-6').width(td6Width);
    $('#clients-th-7').width(td7Width);
    var th1Width = $('#clients-th-1').width();
    console.log('td-1 :'+td1Width);
    console.log('th-1: ' + th1Width);
    //console.log('header.offset().top: ' + headerOffsetTop)
    //console.log('window.scrollTop: '+$(window).scrollTop())

    //if ($(window).scrollTop() > headerOffsetTop) {
    //    header.addClass('header-fixed');
    //}
    //else {
    //    header.removeClass('header-fixed');
    //}
}