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


$(".js-book-class").on("click", function() {
    var modal = $(this).siblings(".modal");
    modal.show();

});

$(".close").on("click", function() {
    $(this).parent().parent().hide();
});

$(".button ").on("click", function() {
    $(this).parent().parent().parent(".modal").hide();
});

//to load todays <article>
var removeHiddenOnce = true;
if (removeHiddenOnce) {
    $("#a1").removeClass("hidden");
    removeHiddenOnce = false
}

$('.class-yes').on("click", function(e) {
    e.preventDefault();
    let paymentUrl = $(this).attr("href");
    var thisMSg = $(this).parent().parent().parent().parent().next(".message");
    thisMSg.removeClass("hidden");
    
    $.ajax({
        url: paymentUrl,
        type: "get",
        dataType: "html",
        beforeSend: function() {

        },
        success: function(response) {
            thisMSg.html(response);
        },
        error: function(error) {
            console.log(error);
        },
        complete: function() {}
    });
});