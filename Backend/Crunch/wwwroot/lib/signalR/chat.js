"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.start().then(function () { }).catch(function (err) {
    return console.error(err.toString());
});

console.log(connection);
connection.on("ReceiveMessage", function (message) {
    RecieveMsg(message);
    console.log("connection recived");
});



//!DESIGN
$(".body").niceScroll({
    cursorcolor: "#ddd",
});
$("#chat-input").niceScroll({
    cursorcolor: "#ddd",
});


//BASIC MECHANICS

//SHOW CHAT
$('.chat-support').on('click', function () {
    $('.chat').removeClass('hidden');
    $('.chat-support').addClass('hidden');
});

//Close CHAT
$('.exit-icon').on('click', function () {
    $('.chat-support').removeClass('hidden');
    $('.chat').addClass('hidden');
});

//!SEND MESSAGE

//Enter press
$('#chat-input').keypress(function (event) {
    if (event.keyCode == 13) {
        //prevent enter from working
        event.preventDefault();
        SendMsg();
    }
});

//Icon press
$('.js-send').on('click', function () {
    SendMsg();

});

function SendMsg() {
    var msg = $('#chat-input').val();
    $('.body').append("<div class='sent-text-container'>" + msg + "</div>");
    //clean textarea
    document.getElementById('chat-input').value = "";
    connection.invoke("SendMessage", msg).catch(function (err) {
        return console.error(err.toString());
    });
}

function RecieveMsg(msg) {
    console.log("recive");
    $('.body').append("<div class='recieved-text-container'>" + msg + "</div>");
}

//!SIGNALR