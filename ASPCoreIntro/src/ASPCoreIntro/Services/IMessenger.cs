using ASPCoreIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreIntro.Services
{
    public interface IMessenger
    {

        Message GetMessage();

    }
}
