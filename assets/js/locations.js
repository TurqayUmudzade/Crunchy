$('.custom-selector').focus(function() {
    $(this).attr('placeholder', 'Type to Search');
    $(this).attr('color', 'Type to Search');
    $(".custom-options").removeClass("hidden");
}).blur(function() {
    $(this).attr('placeholder', 'Filter by State/Province');
    $(".custom-options").addClass("hidden");
})