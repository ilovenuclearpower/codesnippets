using System;
using System.Web;
using Microsoft.AspNet.SignalR; //Imports SignalR, an API for asynchronous web communication in C#.
namespace SignalRChat
{
    public class ChatHub : Hub //Creates a class ChatHub for use by client programs
    {
        public void Send(string name, string message) //Adds a message send method to the connected client.
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message); //Broadcasts the inputted message to all clients using a function call to Clients.All.
        }
    }
}