using DATA.Entity;
using DATA.Enum;
using Microsoft.AspNetCore.Mvc;
using QLNV.Interface.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Controllers
{
    public class MailController : Controller
    {
        private readonly IMailRepository _mailRepository;
        public MailController(IMailRepository mailRepository)
        {
            _mailRepository = mailRepository;
        }
        public async Task<IActionResult>  Index(int type)
        {
            ViewBag.MailType =await _mailRepository.Getall();
            return View();
        }
        public JsonResult GetByType(string id)
        {
            var type = (EMailType)Enum.Parse(typeof(EMailType), id);
            var data=   _mailRepository.GetbyId(type);
            return new JsonResult(
                new
                {
                    id=data.Id,
                    title=data.Tieude,
                    content=data.Noidung
                }
                );
        }
        [HttpPost]
        public JsonResult UpdateMailContent([FromBody]Noidungmail model)
        {
            var result = _mailRepository.Update(model);
            if (result) return new JsonResult(new { mes = "thanh cong" });
            return new JsonResult(new { mes = "that bai" });
        }
    }
}
