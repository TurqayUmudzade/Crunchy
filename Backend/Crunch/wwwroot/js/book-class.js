$(".js-change-trigger").on("click", function() {
    if (!$(this).next().hasClass("hidden"))
        $(this).next().addClass("hidden");
    else
        $(this).next().removeClass("hidden");
});


$(".js-book-class").on("click", function() {

    $(this).parent().next().removeClass("hidden");
});

$("#d1").on("click", function() {
    $('article').addClass("hidden");
    $("#a1").removeClass("hidden");

});

$("#d2").on("click", function() {
    $('article').addClass("hidden");
    $("#a2").removeClass("hidden");

});

$("#d3").on("click", function() {
    $('article').addClass("hidden");
    $("#a3").removeClass("hidden");

});

$("#d4").on("click", function() {
    $('article').addClass("hidden");
    $("#a4").removeClass("hidden");

});

$("#d5").on("click", function() {
    $('article').addClass("hidden");
    $("#a5").removeClass("hidden");

});

$("#d6").on("click", function() {
    $('article').addClass("hidden");
    $("#a6").removeClass("hidden");

});

$("#d7").on("click", function() {
    $('article').addClass("hidden");
    $("#a7").removeClass("hidden");

});

$(".open-payment-modal").click(function (e) {
    e.preventDefault();
    let paymentUrl = $(this).attr("href");

    $.ajax({
        url: paymentUrl,
        type: "get",
        dataType: "html",
        beforeSend: function () {
            $(".preloader").show();
        },
        success: function (response) {
            $(".test-container").html(response);
            //$('#paymentsModal').modal('show');

           // $('[data-toggle="tooltip"]').tooltip();*/
            console.log(response);
        },
        error: function (error) {
            console.log("error not found", "error");
        },
        complete: function () {
            $(".preloader").hide();
        }
    });
});
