$(function() {
    $(".flex a:not(#logo)").hover(function(event) {
        var MyID = event.target.id
        for (var i = 1; i < 6; i++) {
            if (i != MyID) {
                document.getElementById(i).style.color = "grey";
                document.getElementById(i).style.borderBottom = "none";
            } else {
                //done with hover and after
            }
        }
    }, function() {
        for (var i = 1; i < 6; i++) {
            document.getElementById(i).style.color = "white";
            document.getElementById(i).style.borderBottom = "none";
        }
    });
});


$(document).ready(function() {
    console.log("hi");
    var docHeight = $(window).height();
    var footerHeight = $('footer').height();
    var footerTop = $('footer').position().top + footerHeight;
    if (footerTop < docHeight) {
        $('#footer').css('margin-top', 10 + (docHeight - footerTop) + 'px');
    }
});