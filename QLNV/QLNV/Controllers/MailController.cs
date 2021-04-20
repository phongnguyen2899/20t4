using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index(int type)
        {
            return View();
        }
    }
}
