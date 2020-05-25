$('.money').mask('000.000.000.000.000.000.000.000.000.000', { reverse: true });
//$(document).ready(function () {
    
//    $('#money').change(function () {
//        var content = $(this).val().replace(/\./gi, '');
//        alert(content);
//        $('#price').val(content);
        
//    });
//});
//$(document).ready(function () {

    
//});
$('form#ProductCreate').submit(function () {
    $('.money').each(function(){
        $(this).val($(this).val().replace(/\./gi, ''));
        alert($(this).val());
    });

       
});