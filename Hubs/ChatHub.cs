using System;
using Microsoft.AspNetCore.SignalR;

namespace COMP4952_HCI_FrontEnd.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}