﻿using MultiExplorer.Services.Interfaces;

namespace MultiExplorer.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
