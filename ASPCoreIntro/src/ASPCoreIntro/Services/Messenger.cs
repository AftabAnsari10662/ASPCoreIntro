using ASPCoreIntro.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace ASPCoreIntro.Services
{
    public class Messenger : IMessenger
    {
        private IConfiguration _configuration;
        private int _id = 1;
        public Messenger(IConfiguration configuration)
        {

            _configuration = configuration;
        }

        public Message GetMessage()
        {
            var content = _configuration["message:content"];
            var sender = _configuration["message:sender"];
            var message = new Message()
            {
                Id  = _id++,
                Content = content,
                Sender = sender
            };

            return message;
        }
    }
}
