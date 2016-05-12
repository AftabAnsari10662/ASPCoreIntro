using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreIntro.Models;
using Microsoft.Extensions.Configuration;

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
            var value = _configuration["message"];
            var message = new Message()
            {
                Id  = _id++,
                Content = value,
                Sender = "ASP.Net Core 1.0"
            };

            return message;
        }
    }
}
