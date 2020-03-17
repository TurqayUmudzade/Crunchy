$("#location-selector").change(function() {
    $(".icons").removeClass("hidden");
    $(".membership").removeClass("hidden");
    $("#promocode").removeClass("hidden");
    $(".next a").addClass("active");
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

$(".bonuses").on("click", function() {
    if ($("#bonuslist").hasClass("bonuses-list-open")) {
        $("#bonuslist").removeClass("bonuses-list-open");
    } else {
        $("#bonuslist").addClass("bonuses-list-open");
        $(".bonuses .wrapper .header ::after").css('transform', 'translateY(-50%) rotate(88deg)');
        //transform: translateY(-50%) rotate(88deg);
    }
});



$("#promo").on("click", function() {
    console.log("da");
    $("#bottom").removeClass("hidden");


});