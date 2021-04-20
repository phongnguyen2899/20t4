using DATA.Entity;
using DATA.Enum;
using Microsoft.AspNetCore.Mvc;
using QLNV.Interface.Chucvu;
using QLNV.Interface.NhanVien;
using QLNV.Interface.Vitri;
using QLNV.Repository.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Controllers
{
    public class DuyetController : Controller
    {
        private readonly IDuyetNhanVienRepository _duyetNhanVienRepository;
        private readonly IVitriRepository _vitriRepository;
        private readonly IChucvuRepository _ChucvuRepository;
        public DuyetController(IDuyetNhanVienRepository duyetNhanVienRepository, IVitriRepository vitriRepository,
            IChucvuRepository chucvuRepository)
        {
            _duyetNhanVienRepository = duyetNhanVienRepository;
            _vitriRepository = vitriRepository;
            _ChucvuRepository = chucvuRepository;
        }


        public async Task<IActionResult> Index(string search, int vitri, int chucvu)
        {
            var data = await _duyetNhanVienRepository.GetAll();

            ViewBag.VitriSearch = await _vitriRepository.GetAll();
            ViewBag.ChucvuSearch = await _ChucvuRepository.GetAll();

            if (search!= null)
            {
                data = data.Where(x => x.Ten.Contains(""+search+"")).ToList();
            }
            if (vitri>0)
            {
                data = data.Where(x => x.VitriID == vitri).ToList();
            }
            
            if (chucvu >0)
            {
                data = data.Where(x => x.ChucvuID == chucvu).ToList();
            }

            return View(data);
        }

        public JsonResult Duyet(int id)
        {
            var result = _duyetNhanVienRepository.DuyetCv(id);
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
        public JsonResult Loai(int id)
        {
            var result = _duyetNhanVienRepository.LoaiCv(id);
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
        public async Task<IActionResult> DaduyetCV()
        {
            var data = await _duyetNhanVienRepository.GetallDaduyetOK();

            return View(data);
        }

        public JsonResult GetformMail(int id)
        {
            dbcontext db = new dbcontext();
            var nv = db.Nhanviens.Where(x => x.Id == id).FirstOrDefault();
            var typeofMail = nv.ChucvuId;

            return new JsonResult(
                    new
                    {
                        mes = "" + nv.Ten + ""
                    }
                );
        }
    }
}
