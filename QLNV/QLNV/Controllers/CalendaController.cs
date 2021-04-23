using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Controllers
{
    public class CalendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
