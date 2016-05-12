using ASPCoreIntro.Models;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ViewEngines;

namespace ASPCoreIntro.controllers
{
    public class MessageController : Controller
    {

        public IActionResult GetMessage()
        {
            var model = new Message()
            {
                Id = 1,
                Content = "How are you?",
                Sender = "Aftab Ansari"
            };

            return View("message", model);
        }
    }
}
