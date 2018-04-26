$('body').on('click', '.tbs', function () {
    var formId = $('#btnClientSave').attr('data-form-id').valueOf();
    if (formId) {
        if (($('#' + formId).data('serialize')) != $('#' + formId).serialize()) {
            if (confirm('Сохранить изменения?')) {
                submitForm(formId);
            };
        }
    }    
});

$('#btnClientSave').on('click', function () {
    var formId = $('#btnClientSave').attr('data-form-id').valueOf();
    if (formId) {
        if (($('#' + formId).data('serialize')) != $('#' + formId).serialize()) {
            if (confirm('Сохранить изменения?')) {
                submitForm(formId);
            };
        }
        else
        {
            alert('Данные не изменились!');
        }
    }
});


function submitForm(id) {
    var form = $('#' + id);
    $.ajax({
        type:'POST',
        url: form.attr('action'),
        data: form.serialize(),
        success: function (response) {
            alert('Изменения сохранены!');
        },
        error: function (jqXHR, textStatus, errorThrown) {
        }
    });
}