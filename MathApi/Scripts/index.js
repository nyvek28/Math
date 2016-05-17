
//alert("Javascript!");
$("#math").click(function () {
    //alert($('#math-form').serialize()); { v1: 4, v2: 5, op: 't' }
    $.ajax({
        url: 'api/calculator',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        data: {
            v1: Number($('#val1').val()),
            v2: Number($('#val2').val()),
            op: $('#op').val() || 'p'
        },
        success: function (res) {
            alert(res.result);
            $('#result').val(res.result);
        }
    });
});

