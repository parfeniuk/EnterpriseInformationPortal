$(function () {
    loadClientContacts();
    $('.tbs').on('click', switchTab);
});

function loadClientContacts() {
    $.ajax({
        url: $('#tb1').data('request-url').valueOf(),
        dataType: 'html',
        success: function (data) {
            $('#tabContent').html(data);
        }
    });
}
function switchTab() {
    var id = $(this).attr('id');
    var info = $(this).data('info');
    switch (info)
    {
        case 'clientContacts': loadClientData(id);
            break;
        case 'clientPaymentDetails': loadClientData(id);
            break;
        case 'clientDebtDetails': loadClientData(id);
            break;
        case 'clientProducts': loadClientData(id);
            break;
        default:
            break;
    }
}
function loadClientData(id)
{
    $.ajax({
        url: $('#' + id).data('request-url').valueOf(),
        dataType: 'html',
        success: function (data) {
            $('#tabContent').html(data);
            setMaxHeight();
        }
    });
}

function setMaxHeight() {
    var highest = $('.billSettings-container').height();
    $('.debtControl-container').height(highest);
}