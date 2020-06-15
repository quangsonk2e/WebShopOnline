var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {
        $('a.cart_quantity_up').on('click',function(e){
            e.preventDefault();
            var quantity=parseInt($(this).next().val()) + 1;
            $(this).next().val(quantity);
        });
        $('a.cart_quantity_down').on('click', function (e) {
            e.preventDefault();
            var quantity = parseInt($(this).prev().val());
            if(quantity>0)
                quantity = parseInt($(this).prev().val()) - 1;
            $(this).prev().val(quantity);
        });
        $('a.cart_quantity_delete').on('click', function (e) {
                        e.preventDefault();
                        $(this).parent().parent().remove();
                    });

        $('#btnContinue').off('click').on('click', function () {
            window.location.href = "/";
        });
        $('#btnUpdate').off('click').on('click', function (e) {
            e.preventDefault();
            var cartList=[];
            var listProduct=$('.cart_quantity_input');
            $.each(listProduct,function(i, item){
                cartList.push({
                    Quantity:$(item).val(),
                    Product:{
                        ID:$(item).data('id')
                    }
                });
            });
            $.ajax({
                url:'/Cart/Update',
                data:{cartModel:JSON.stringify(cartList)},
                dataType: 'json',
                type:'POST',
                success:function(result){

                }
            });
        });
    },
    ca: function () { }
}
cart.init();