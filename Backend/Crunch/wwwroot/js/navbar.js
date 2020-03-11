$(function() {
    $(".flex a:not(#logo)").hover(function(event) {
        var MyID = event.target.id
        for (var i = 1; i < 6; i++) {
            if (i != MyID) {
                document.getElementById(i).style.color = "grey";
                document.getElementById(i).style.borderBottom = "none";
                console.log("badimcan");
            } else {
                document.getElementById(i).style.color = "white";
                document.getElementById(i).style.borderBottom = "thick solid white";

            }
        }
    }, function() {
        for (var i = 1; i < 6; i++) {
            document.getElementById(i).style.color = "white";
            document.getElementById(i).style.borderBottom = "none";
        }
    });
});