using Microsoft.AspNetCore.Mvc;
using QLNV.Interface.Calenda;
using QLNV.Interface.NhanVien;
using QLNV.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Controllers
{
    public class CalendaController : Controller
    {
        private readonly ICalendaRepositorycs _calendaRepositorycs;
        private readonly ILienHeRepository _lienHeRepository;
        public CalendaController(ICalendaRepositorycs calendaRepositorycs,ILienHeRepository lienHeRepository)
        {
            _calendaRepositorycs = calendaRepositorycs;
            _lienHeRepository = lienHeRepository;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public JsonResult GetSchedule()
        {
            var employee = _calendaRepositorycs.GetfullSchedule();
            var interviewer = _lienHeRepository.GetAllNguoiPV();
            return new JsonResult(
                    new
                    {
                        nhanvien=employee,
                        nguoipv=interviewer
                    }
                );
        }

        public JsonResult GetInterviewById(int idnhanvien)
        {
           var interview= _calendaRepositorycs.GetInterViewById(idnhanvien);
            return new JsonResult(
                new
                {
                    interview=interview
                }
                );
        }

        public JsonResult UpdateSchedule([FromBody]DatlichViewModel model)
        {
            var result = _calendaRepositorycs.UpdateSchedule(model);
            if (result)
            {
                return new JsonResult(
                    new
                    {
                        mes="thanh cong"
                    }
                    );
            }
            return new JsonResult(
                    new
                    {
                        mes = "that bai"
                    }
                    );
        }
        [HttpGet]
        public JsonResult DeleteSchedule(int id)
        {
            var result = _calendaRepositorycs.DeleteSchedule(id);
            if (result)
            {
                return new JsonResult(
                    new
                    {
                        mes = "thanh cong"
                    }
                );
            }
            return new JsonResult(
                    new
                    {
                        mes = "that bai"
                    }
                );
        }
    }
}
