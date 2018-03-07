   // On anchor click - Save data-unique-attr value of clicked link to sessionStorage
$(function () {
   $('body').on('click', 'ul.menu-fixed-center li a', function () {
         sessionStorage.setItem('activeB2BAnchor', $(this).attr('data-unique-attr').valueOf());
    });
});

  // On page load - Add active class
$(function () {
    var activeB2BAnchor = sessionStorage.getItem('activeB2BAnchor');
    if (activeB2BAnchor) {
        $('ul.menu-fixed-center li a[data-unique-attr="' + activeB2BAnchor + '"]').addClass('active');
    }
});