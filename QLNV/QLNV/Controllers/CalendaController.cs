using Microsoft.AspNetCore.Mvc;
using QLNV.Interface.Calenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Controllers
{
    public class CalendaController : Controller
    {
        private readonly ICalendaRepositorycs _calendaRepositorycs;
        public CalendaController(ICalendaRepositorycs calendaRepositorycs)
        {
            _calendaRepositorycs = calendaRepositorycs;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public JsonResult GetSchedule()
        {
            var employee = _calendaRepositorycs.GetfullSchedule();
            return Json(employee);

        }
    }
}
