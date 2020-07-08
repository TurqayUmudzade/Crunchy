"use strict";
let requestChat = false;
let msg = "";
let connectionID;
let groupID="";

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
    if (groupID === "") {
        groupID = $('#groupID').text();
        console.log(groupID)
    }
    console.log("here")
     msg = $('#chat-input').val();
    $('.body').append("<div class='sent-text-container'>" + msg + "</div>");
    //clean textarea
    document.getElementById('chat-input').value = "";
    connection.invoke("SendMessage", msg,groupID).catch(function (err) {
        return console.error(err.toString());
    });
}

function RecieveMsg(msg) {
    $('.body').append("<div class='recieved-text-container'>" + msg + "</div>");
}

//!SIGNALR
connection.start().then(function () { }).catch(function (err) {
    return console.error(err.toString());
});

//CALLER
connection.on("UserConnected", function (conID) {
    connectionID = conID;
});

//COMES FROM USR CALLING OTHERS
connection.on("AddSupportCard", function (firstMSG, GroupID) {
     groupID = GroupID; 
    $('.signalR-cards').append("<div class='card'> <div class='card-body'> <h5 class='card-title'>#" + GroupID + "</h5> <p class='card-text'>" + firstMSG + "</p> <a href='/support/home/chat?id=" + GroupID + "' class='btn btn-primary js-joinConvo'>Join Conversation</a> </div> </div>");

});

//
$(document).on('click', '.js-joinConvo', function (e) {
    console.log(groupID)
    connection.invoke("JoinGroup", groupID).catch(function (err) {
        return console.error(err.toString());
    });
});

connection.on("ReceiveMessage", function (message) {
    RecieveMsg(message);
});


