$('body').on('click', '#btnClientSearch', clientSearch);
$('body').on('keyup', '#inputClientSearch', function (e) {
    if ($("#inputClientSearch").is(":focus") &&  e.keyCode === 13) {
        clientSearch();
        e.preventDefault();
    }
});

function clientSearch() {
    var searchStr = $('#inputClientSearch').val();
    var param = { searchString: searchStr };
    var path = $('#inputClientSearch').data('request-url').valueOf();
    $.ajax({
        url: $('#inputClientSearch').data('request-url').valueOf(),
        data: param,
        type: 'GET',
        dataType: 'html',
        success: function (data) {
            $('#clientsFilter').html(data);
        }
    });
}