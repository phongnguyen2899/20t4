using Microsoft.AspNetCore.Mvc;
using QLNV.Interface.NhanVien;
using QLNV.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Controllers
{
    public class LienHeController : Controller
    {
        public readonly ILienHeRepository _lienHeRepository;
        public LienHeController(ILienHeRepository lienHeRepository)
        {
            _lienHeRepository = lienHeRepository;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _lienHeRepository.GetAll();
            return View(data.ToList());
        }

        public JsonResult LoadDatLich(int id)
        {
            var nhanvien = _lienHeRepository.GetbyId(id);
            var listpv = _lienHeRepository.GetAllNguoiPV();
            return new JsonResult(new
            {
                nguoipv = listpv,
                ngaypv = nhanvien.ThoigianPV
            });
        }
     

        [HttpPost]
        public JsonResult DatLich([FromBody]DatlichViewModel model)
        {
            var result = _lienHeRepository.Datlich(model);
            if (result)
            {
                return new JsonResult(new
                {
                    mes="thanh cong"
                });
            }
            return new JsonResult(new
            {
                mes="that bai"
            });
        }
    }
}
