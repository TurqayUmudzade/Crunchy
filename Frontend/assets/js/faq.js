$(document).ready(function() {
    var str = $(".faq-question p").text();
    if (str.includes("Click here")) {
        var index = str.indexOf("Click here");
        str = str.replace("Click here", "<a class='click-here'>Click there</a>");
        $(".faq-question p").text("");
        $(".faq-question p").append(str);
    }
});