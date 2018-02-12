$('.navbar').affix({ offset: { top: 30 } });

// Fix immediate replace of 'affix-top' class on 'affix' class if window scrolled allong on less then or equal 100px
$('.navbar').on('affix.bs.affix', function () {
    if (window.pageYOffset <= 100)
    {
        return false;;
    }
});