using ASPCoreIntro.Models;
using ASPCoreIntro.Services;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ViewEngines;
using System;

namespace ASPCoreIntro.controllers
{
    public class MessageController : Controller
    {
        private IMessenger _messenger;

        public MessageController(IMessenger messenger)
        {
            _messenger = messenger;
        }

        public IActionResult GetMessage()
        {
            var model = _messenger.GetMessage();

            return View("message", model);
        }

        [HttpGet]
        public IActionResult GetError()
        {
            throw new Exception("Oops!!Something went wrong!");
        }

    }
}
