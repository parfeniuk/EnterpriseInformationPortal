$(function () {
    loadProductCatalog();
    getProductCategoryId();
     $('#productCategories').change(loadProductCatalog);
});

function loadProductCatalog() {
    $.ajax({
        url: $('#productCatalog').attr('data-request-url').valueOf(),
        data: { id: $('#productCategories').val() },
        dataType: "html",
        success: function (data) {
            $('#productCatalog').html(data);
        }
    });
    var id = $(this).find('option:selected').val();
    $('#btnCreateProductSubcategory').attr('href', $('#btnCreateProductSubcategory').data('request-url')+'/'+id);
}

function getProductCategoryId() {
    var id = $('#productCategories').find('option:first-child').val();
    $('#btnCreateProductSubcategory').attr('href', $('#btnCreateProductSubcategory').data('request-url') + '/' + id);
}