$('body').on('click','#allow-grace-period', function () {
    var id = $(this).attr('id');
    allowDisabled(id);
});
$('body').on('click', '#allow-debt-limit', function () {
    var id = $(this).attr('id');
    allowDisabled(id);
});
$('body').on('click', '#allow-replace-list', function () {
    var id = $(this).attr('id');
    allowDisabled(id);
});
$('body').on('click', '#allow-print-job', function () {
    var id = $(this).attr('id');
    allowDisabled(id);
});
$('body').on('click', '#allow-franchising', function () {
    var id = $(this).attr('id');
    allowDisabled(id);
});
$('body').on('click', '#allow-bill-options-0', function () {
    var id = $(this).attr('id');
    allowDisabled(id);
});
$('body').on('click', '#allow-bill-options-1', function () {
    var id = $(this).attr('id');
    allowDisabled(id);
});

function allowDisabled(className) {
    var elem = $("." + className);
    if (elem.attr('readonly'))
        elem.removeAttr('readonly');
    else elem.attr('readonly', 'true');
}