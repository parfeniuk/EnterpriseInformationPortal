$('body').on('change', '.debt-calc-method-check', function () {
    $('.debt-calc-method-check').not(this).prop('checked', false);
});
$('body').on('change', '.franchising-type-check', function () {
    $('.franchising-type-check').not(this).prop('checked', false);
});
$('body').on('change', '.category-type-check', function () {
    $('.category-type-check').not(this).prop('checked', false);
});

