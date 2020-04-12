//THIS PAGE IS FOR USER BOOKED CLASS LIST

//GLOVAl variable
var url = "/";
//TO GET ID OF THE CLASS WE WANT
$(".modalButton").on("click", function(e) {
    e.preventDefault();
    url = $(this).attr("href");
    $(".modal").show();
});

//CLOSE ON X
$(".close").on("click", function() {
    $(this).parent().parent().hide();
});
//CLOSE WHEN ACTION CHOOSED
$(".button ").on("click", function() {
    $(this).parent().parent().parent(".modal").hide();
});

//AJAX CODE
$('.cancel-yes').on("click", function(e) {
    e.preventDefault();
    let paymentUrl = $(this).attr("href");
    console.log(url);
    $.ajax({
        url: paymentUrl,
        type: "get",
        dataType: "html",
        beforeSend: function() {

        },
        success: function(response) {
            $(".message").html(response);
        },
        error: function(error) {
            console.log(error);
        },
        complete: function() {}
    });
});