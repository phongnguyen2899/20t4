using DATA.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Controllers
{
    public class ServiceController : Controller
    {
        public ServiceController()
        {
            dbcontext db = new dbcontext();
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
