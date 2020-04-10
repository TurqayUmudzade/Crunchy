$(".expandable").on("click", function() {
    if (!$(this).children('.nav-sub-menu').hasClass("nav-sub-menue-open")) {
        $(this).children('.nav-sub-menu').addClass("nav-sub-menue-open");
        $(this).siblings().children('.nav-sub-menu').removeClass("nav-sub-menue-open");
    } else
        $(this).children('.nav-sub-menu').removeClass("nav-sub-menue-open");
});

var validation = $(".email-sent-confirmation").children("h3").text().length;
if (validation == 0) {
    $(".email-sent-confirmation").addClass("hidden");
}

('.js-book-class').on("click", function(e) {

    var s = $('.custom-selector').val();
    paymentUrl = "/MemberArea/BookTheClass?ClassID=" + s;
    $.ajax({
        url: paymentUrl,
        type: "get",
        dataType: "html",
        beforeSend: function() {},
        success: function(response) {
            $(".locations").html(response);
        },
        error: function(error) {
            $.notify("Error not found", "error");
        },
        complete: function() {}
    });
});