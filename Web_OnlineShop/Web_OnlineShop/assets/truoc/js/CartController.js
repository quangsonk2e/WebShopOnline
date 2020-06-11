var cart = {
    init: function () {
        cart.regEvents();
    },
    regEvents: function () {

        $('#btnContinue').off('click').on('click'), function () {
            window.location.href = "/";
        });
        $('#btnUpdateAll').off('click').on('click', function () { 
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
                contentType:'json',
                type:'POST',
                success:function(result){

                }
            });
        });
    },
    ca: function () { }
}
cart.init();