$(".js-change-trigger").on("click", function () {
    if (!$(this).next().hasClass("hidden"))
        $(this).next().addClass("hidden");
    else
        $(this).next().removeClass("hidden");
});


$(".js-book-class").on("click", function () {

    $(this).parent().next().removeClass("hidden");
});

$("#d1").on("click", function () {
    $('article').addClass("hidden");
    $("#a1").removeClass("hidden");

});

$("#d2").on("click", function () {
    $('article').addClass("hidden");
    $("#a2").removeClass("hidden");

});

$("#d3").on("click", function () {
    $('article').addClass("hidden");
    $("#a3").removeClass("hidden");

});

$("#d4").on("click", function () {
    $('article').addClass("hidden");
    $("#a4").removeClass("hidden");

});

$("#d5").on("click", function () {
    $('article').addClass("hidden");
    $("#a5").removeClass("hidden");

});

$("#d6").on("click", function () {
    $('article').addClass("hidden");
    $("#a6").removeClass("hidden");

});

$("#d7").on("click", function () {
    $('article').addClass("hidden");
    $("#a7").removeClass("hidden");

});

//to load todays <article>
var removeHiddenOnce = true;
if (removeHiddenOnce) {
    $("#a1").removeClass("hidden");
    removeHiddenOnce = false
}

$('.js-book-class').on("click", function (e) {
    e.preventDefault();
    let paymentUrl = $(this).attr("href");
   
    $.ajax({
        url: paymentUrl,
        type: "get",
        dataType: "html",
        beforeSend: function () { },
        success: function (response) {
            $(".message").html(response);
            
        },
        error: function (error) {
            $.notify("Error not found", "error");
        },
        complete: function () { }
    });
});