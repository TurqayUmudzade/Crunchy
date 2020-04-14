$("#location-selector").change(function() {
    $(".icons").removeClass("hidden");
    $(".membership").removeClass("hidden");
    $("#promocode").removeClass("hidden");
    $(".next a").addClass("active");
    $('.button').removeClass('btn-off')
});

//when pressed on Day Pass
$('#day-toggle').on("click", function() {
    $(".daily-membership").removeClass("hidden");
    $(".montly-membership").addClass("hidden");
    $('#day-toggle').addClass("active");
    $("#month-toggle").removeClass("active");
    $(".bonuses").addClass("hidden");
    $("#promocode").addClass("hidden");
});

//when pressed on Montly Pass
$('#month-toggle').on("click", function() {
    $(".montly-membership").removeClass("hidden");
    $(".daily-membership").addClass("hidden");
    $('#month-toggle').addClass("active");
    $("#day-toggle").removeClass("active");
    $(".bonuses").removeClass("hidden");
    $("#promocode").removeClass("hidden");
});

//Select Basic Option
$(".basic").on("click", function() {
    $("#basicInput").prop("checked", true);
    $("#premInput").prop("checked", false);
    $(".basic").addClass("active-basic");
    $(".premium").removeClass("active-prem ");
});

//Select Premium Option
$(".premium").on("click", function() {
    $("#premInput").prop("checked", true);
    $("#basicInput").prop("checked", false);
    $(".premium").addClass("active-prem ");
    $(".basic").removeClass("active-basic");
});

//bonuses list icon and list showings
$(".bonuses").on("click", function() {
    if ($("#bonuslist").hasClass("bonuses-list-open")) {
        $("#bonuslist").removeClass("bonuses-list-open");
        $('#minus-plus').removeClass("open");
    } else {
        $("#bonuslist").addClass("bonuses-list-open");
        $('#minus-plus').addClass("open");
    }
});


//for validiton
//idk

$(".myclass:empty").each(function() {
    $(this).remove(); // this references the current element in the iteration
});


var value = $(".field-validation-error").text().length;

if (value != 0) {
    $(".field-validation-error").siblings(":input").addClass("error-asp");
    $(".field-validation-error").siblings("label").addClass("error-asp");
}


//Register 2

//promo code

$("#promo").on("click", function () {
    $("#bottom").removeClass("hidden");
});

$("#promo-apply").on("click", function () {
    var s = $('#promo-input').val();
    paymentUrl = "/Account/Promo?promo=" + s;
    console.log(s);
    $.ajax({
        url: paymentUrl,
        type: "get",
        dataType: "html",
        success: function (response) {
            $(".promo-status").html(response);
        },
        error: function (error) {
            console.log("Error not found", "error");
        },
        complete: function () {
        }
    });
});


//Login
$('#rememberMe').on("click", function () {
    if ($('.fa-check').hasClass('hidden')) {
        $('.fa-check').removeClass("hidden");
    } else {
        $('.fa-check').addClass('hidden');
    }
})
var validation = $(".pin-sent-confirmation").children("h3").text().length;
if (validation == 0) {
    $(".pin-sent-confirmation").addClass("hidden");
}
