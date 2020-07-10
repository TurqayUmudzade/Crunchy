"use strict";
let requestChat = false;
let msg = "";
let connectionID;


var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();


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
     msg = $('#chat-input').val();
    if (requestChat === false)
    {
        connection.start().then(function () { }).catch(function (err) {
            return console.error(err.toString());
        });
        console.log("Conncetion Started")
        requestChat = true;
    }
    else
    {
        connection.invoke("SendMessage", msg,connectionID).catch(function (err) {
            return console.error(err.toString());
        });
    }

    $('.body').append("<div class='sent-text-container'>" + msg + "</div>");
    //clean textarea
    document.getElementById('chat-input').value = "";

}

function RecieveMsg(msg) {
    $('.body').append("<div class='recieved-text-container'>" + msg + "</div>");
}

//!SIGNALR

connection.on("UserConnected", function (conID) {
    connection.invoke("JoinGroup", conID).catch(function (err) {
        return console.error(err.toString());
    });
    connection.invoke("AddSupportCard", msg,conID).catch(function (err) {
        return console.error(err.toString());
    });
    connectionID = conID;
});


connection.on("ReceiveMessage", function (message) {
    RecieveMsg(message);
});