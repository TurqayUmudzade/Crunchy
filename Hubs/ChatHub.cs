using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Crunch.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage( string message,string groupID)
        {
            await Clients.OthersInGroup(groupID).SendAsync("ReceiveMessage", message);
        }


        public async Task AddSupportCard(string FirstMsg,string groupID)
        {
            await Clients.Others.SendAsync("AddSupportCard", FirstMsg,groupID);
        }


        public override async Task OnConnectedAsync()
        {
           
            await Clients.Caller.SendAsync("UserConnected",Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public async Task JoinGroup(string lobbyID)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, lobbyID);
            Debug.WriteLine("Added to group");
        }


    }
}
