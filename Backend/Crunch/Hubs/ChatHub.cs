using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crunch.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage( string message)
        {
            await Clients.Others.SendAsync("ReceiveMessage", message);
        }
    }
}
