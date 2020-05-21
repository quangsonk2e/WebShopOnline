$('.money').mask('000.000.000.000.000.000.000.000.000.000', { reverse: true });
$(document).ready(function () {
    
    $('#money').change(function () {
        var content = $(this).val().replace(/\./gi, '');
        alert(content);
        $('#price').val(content);
        
    });
});
$(document).ready(function () {

    
});