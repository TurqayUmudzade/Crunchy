//cancel the class
$('.js-cancel').on("click", function (e) {
    e.preventDefault();
    let paymentUrl = $(this).attr("href");
    $.ajax({
        url: paymentUrl,
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