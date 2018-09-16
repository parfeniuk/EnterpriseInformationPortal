$(function () {
    $('.selectpicker-clients').on('hide.bs.select', function () {
        var id = $('select').val();
        populateSelectBranches(id);
        //populateSelectPhones(id);
    });
});

$(function () {
    $('.selectpicker-branches').on('hide.bs.select', function () {
        var id = $('.selectpicker-branches').val();
        populateSelectPhones(id);
    });
});
//treeCat
$(function () {
    $('.selectpicker-ticket-subject').on('hide.bs.select', function () {
        var id = $('.selectpicker-ticket-subject').val();
        populateSelectSubCategories(id);
        //treeBuilder(id)
    });
});

function populateSelectBranches(id) {
    var selectList = $('.selectpicker-branches');
    var url = selectList.data('request-url');
    var param = { id: id };
    $.ajax({
        dataType: 'json',
        url: url,
        data: param,
        success: function (data) {
            selectList.empty();
            selectList.append('<option class="bs-title-option" value="">Список торговых точек...</option>');
            for (var i = 0; i < data.length; i++) {
                selectList.append('<option value="' + data[i].branchId + '">' + data[i].name + '</option>');
            }
            selectList.selectpicker('refresh');
        }
    });
}

function populateSelectPhones(id) {
    var selectList = $('.selectpicker-phones');
    var url = selectList.data('request-url');
    var param = { id: id };
    $.ajax({
        dataType: 'json',
        url: url,
        data: param,
        success: function (data) {
            console.log(data);
            selectList.empty();
            selectList.append('<option class="bs-title-option" value="">Список телефонов...</option>');
            for (var i = 0; i < data.length; i++) {
                selectList.append('<option value="' + data[i].pointContactPhoneId + '">' + data[i].phone + '</option>');
            }
            selectList.selectpicker('refresh');
        }
    });
}

function populateSelectSubCategories(id) {
    var selectList = $('.selectpicker-ticket-subject-details');
    var url = selectList.data('request-url');
    var param = { id: id };
    $.ajax({
        dataType: 'json',
        url: url,
        data: param,
        error: function () {
            selectList.empty();
            selectList.selectpicker('refresh');
        },
        success: function (data) {
            selectList.empty();
            selectList.append('<option class="bs-title-option" value="">Список подтем...</option>');
            for (var i = 0; i < data.length; i++) {
                selectList.append('<option value="' + data[i].ticketSubjectId + '">' + data[i].name + '</option>');
            }
            selectList.selectpicker('refresh');
        }
    });
}

//function treeBuilder(id) {
//    var param = { id: id };
//    var url = '/Company/Support/GetSubjectTree';

//    //$('#tree').treeview({ data: getTree() });


//    $.ajax({
//        dataType: 'json',
//        url: url,
//        data: param,
//        error: function () {
//            $('#treeCat').treeview();  
//            $('#treeJsonText').text(''); 
//        },
//        success: function (data) {
            
//            var str = JSON.stringify(data);
//            $('#treeCat').treeview({
//                data: str,
//                //backColor: 'green',
//                emptyIcon: 'glyphicon glyphicon-education'                
//            });            
//            $('#treeJsonText').text(str);            
//        }
//    });
//}