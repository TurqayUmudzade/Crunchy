$(".js-change-trigger").on("click", function() {
    if (!$(this).next().hasClass("hidden"))
        $(this).next().addClass("hidden");
    else
        $(this).next().removeClass("hidden");
});


$(".js-book-class").on("click", function() {

    $(this).parent().next().removeClass("hidden");
});