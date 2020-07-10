//THIS PAGE IS FOR USER BOOKED CLASS LIST

//GLOVAl variable
var url = "/";
//TO GET ID OF THE CLASS WE WANT
$(".modalButton").on("click", function (e) {
    e.preventDefault();
    url = $(this).attr("href");
    $(".modal").show();
});

//CLOSE ON X
$(".close").on("click", function () {
    $(this).parent().parent().hide();
});
//CLOSE WHEN ACTION CHOOSED
$(".button ").on("click", function () {
    $(this).parent().parent().parent(".modal").hide();
});

//AJAX CODE 
//cancel the class
$('.cancel-yes').on("click", function (e) {
    e.preventDefault();
    console.log("url: "+url);
    $.ajax({
        url: url,
        type: "get",
        dataType: "html",
        beforeSend: function () {
            console.log("sending");
        },
        success: function (response) {
            console.log(response);
            $(".modal").html(response);
            $(".modal").show();

        },
        error: function (error) {
            console.log("error");
            console.log(error);
        },
        complete: function () { }
    });
});