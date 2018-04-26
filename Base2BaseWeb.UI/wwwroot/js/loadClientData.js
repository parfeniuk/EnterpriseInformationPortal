$(function () {
    loadClientContacts();
    $('body').on('click','.tbs', switchTab);
});

function loadClientContacts() {
    $.ajax({
        url: $('#tb1').data('request-url').valueOf(),
        dataType: 'html',
        success: function (data) {
            $('#tabContent').html(data);
            setSubmitLink();
            saveInitialState();
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
            setSubmitLink();
            saveInitialState();
        }
    });
}
function setMaxHeight() {
    var highest = $('.billSettings-container').height();
    $('.debtControl-container').height(highest);
    highest = $('.franchising-container').height();
    $('.connection-container').height(highest);
    $('.debtCalcMethod-container').height(highest);
}
function setSubmitLink() {
    var formId = $('#tabContent').find('form').attr('id');
    $('#btnClientSave').attr('data-form-id', formId);
}
function saveInitialState() {
    var formId = $('#btnClientSave').attr('data-form-id').valueOf();
    var form = $('#' + formId);
    form.data('serialize', form.serialize());
}