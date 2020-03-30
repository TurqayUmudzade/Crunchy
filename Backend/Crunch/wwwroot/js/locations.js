$('.custom-selector').focus(function () {
    $(this).attr('placeholder', 'Type to Search');
    $(this).attr('color', 'Type to Search');
    $(".custom-options").removeClass("hidden");
}).blur(function () {
    $(this).attr('placeholder', 'Filter by State/Province');
    setTimeout(function () { $(".custom-options").addClass("hidden") }, 400);
})

$('.custom-options > li').click(function (e) {
    $('.custom-selector').val($(this).text());
});

$('.custom-selector').on("change", function () {
    var s = $('.custom-selector').val();
    paymentUrl = "/Locations/search?searchStr=" + s;
    $.ajax({
        url: paymentUrl,
        type: "get",
        dataType: "html",
        beforeSend: function () {
        },
        success: function (response) {
            $(".locations").html(response);
        },
        error: function (error) {
            $.notify("Error not found", "error");
        },
        complete: function () {
        }
    });
});


$('.custom-selector').on("change paste keyup", function () {
    var s = $('.custom-selector').val();
    paymentUrl = "/Locations/selectFill?searchStr=" + s;
    $.ajax({
        url: paymentUrl,
        type: "get",
        dataType: "html",
        beforeSend: function () {
        },
        success: function (response) {
            $(".custom-options").html(response);
        },
        error: function (error) {
            $.notify("Error not found", "error");
        },
        complete: function () {
        }
    });
});
