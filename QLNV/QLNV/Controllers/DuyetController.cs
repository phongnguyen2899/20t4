using DATA.Entity;
using DATA.Enum;
using Microsoft.AspNetCore.Mvc;
using QLNV.Interface.Chucvu;
using QLNV.Interface.Mail;
using QLNV.Interface.NhanVien;
using QLNV.Interface.Vitri;
using QLNV.Repository.NhanVien;
using QLNV.Viewmodels;
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
        private readonly IMailRepository _mailRepository;
        public DuyetController(IDuyetNhanVienRepository duyetNhanVienRepository, IVitriRepository vitriRepository,
            IChucvuRepository chucvuRepository,IMailRepository mailRepository)
        {
            _duyetNhanVienRepository = duyetNhanVienRepository;
            _vitriRepository = vitriRepository;
            _ChucvuRepository = chucvuRepository;
            _mailRepository = mailRepository;
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

            //lay nhan vien da duyet theo idNhanvien
            var nv = _duyetNhanVienRepository.GetnhanviendaduyetbyId(id);

            //lay mau mail co trong bang Mailtonhanviens. neu khong co thi lay noi dung mail mac dinh trong bang
            //noidungmail

            var mailcontent = _mailRepository.GetnoidungmailbyID(id, nv.VitriId);

            if (mailcontent.Id == 1)
            {
                return new JsonResult(
                    new
                    {
                        type="custom",
                        tieude = mailcontent.Tieude,
                        noidung = mailcontent.Noidung,
                        thoigian = ""
                    }
                );
            }

            return new JsonResult(
                    new
                    {
                        type="default",
                        tieude = mailcontent.Tieude,
                        noidung = "Xin chao " + nv.Ten + ", " + mailcontent.Noidung + "",
                        thoigian = "" + nv.ThoigianPV + ""
                    }
                ); ;
        }


        [HttpPost]
        public JsonResult UpdateContentMailforNhanvien([FromBody]MailCustomViewModel Mailcontext)
        {
            var db = new dbcontext();
            var exsistMailfornhanvien = db.Mailtonhanviens.Where(x=>x.NhanvienId==Mailcontext.idnv ).FirstOrDefault();
            if (exsistMailfornhanvien == null)
            {
                var newmailfornhanvien = new Mailtonhanvien()
                {
                    NhanvienId = Mailcontext.idnv,
                    Tieude = Mailcontext.tieudemail,
                    Noidung = Mailcontext.noidungmail
                };
                db.Mailtonhanviens.Add(newmailfornhanvien);
                db.SaveChanges();
                return new JsonResult(
                    new
                    {
                        mes="thanh cong"
                    }
                );
            }
            else
            {
                exsistMailfornhanvien.Tieude = Mailcontext.tieudemail;
                exsistMailfornhanvien.Noidung = Mailcontext.noidungmail;
                db.SaveChanges();
                return new JsonResult(
                    new
                    {
                        mes = "thanh cong"
                    }
                );
            }

        }

        public JsonResult GuimailALL([FromBody] ListMailCustomViewModel list)
        {
            int[] data = list.listId;
            _mailRepository.Guimal(data);
            return new JsonResult(
                    new
                    {
                        mes = "thanh cong"
                    }
                );
        }

        [HttpPost]
        public JsonResult UpdateTime([FromBody]UpdateTGPVViewModel model)
        {

            bool result = _duyetNhanVienRepository.chottime(model.id, model.thoigianpv, model.trangthailienhe);
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
