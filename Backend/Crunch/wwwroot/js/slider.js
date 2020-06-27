let ID;
var images = ["", "group", "lift", "cardio", "people", "clean"];
$('.slider-nav li').on("click", function() {
    $(this).children("p").removeClass('hidden');
    $(this).siblings().children("p").addClass('hidden');
    ID = $(this).attr('id');
    ID = ID.slice(-1);
    if (ID == 1) {
        $('.js-carousel-highlight').css('top', 82 * parseInt(ID - 1) + 15 + 'px');
    } else
        $('.js-carousel-highlight').css('top', 82 * parseInt(ID - 1) + 16 + 'px');


    $('#sliderImage').attr('src', "/image/sliderHome/" + images[ID] + ".jpg")
});


$('.owl-carousel').owlCarousel({
    loop: true,
    margin: 10,
    nav: true,
    responsive: {
        0: {
            items: 1
        },
        700: {
            items: 1
        },
        1000: {
            items: 5
        }
    }
});