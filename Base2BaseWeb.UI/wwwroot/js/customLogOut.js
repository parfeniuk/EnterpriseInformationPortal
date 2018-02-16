$('body').on('click', '.btn-logOut', function (e)
{
    e.preventDefault();
    $.ajax({
        url: $(this).attr('data-request-url').valueOf(),
        type: 'POST',
        dataType: "html",
        success: function (data) {
            window.location.href = 'http://localhost:53678/Home/Index';
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert('Error ' + ' - ' + textStatus);
            //console.log(jqXHR);
        }
    });
});
//$('body').on('click', '.btn-logOut', function (e) {
//    e.preventDefault();
//    $.post($(this).attr('data-request-url').valueOf());
//});