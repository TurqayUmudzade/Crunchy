$(".js-change-trigger").on("click", function() {
    if (!$(this).next().hasClass("hidden"))
        $(this).next().addClass("hidden");
    else
        $(this).next().removeClass("hidden");
});


//Class confirmed message
$(".class-yes").on("click", function() {
    $(this).parent().parent().parent().parent().next(".message").removeClass("hidden");
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