using Microsoft.AspNetCore.Mvc;
using QLNV.Interface.NhanVien;
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
        public async Task<IActionResult>  Index()
        {
            var data = await _lienHeRepository.GetAll();
            return View(data.ToList());
        }
    }
}
