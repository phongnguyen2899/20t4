using DATA.Entity;
using DATA.Enum;
using QLNV.Interface.Mail;
using QLNV.Repository.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Repository.Mail
{
    public class MailRepository : BaseRepository, IMailRepository
    {

        public bool Create(Noidungmail mail)
        {
            throw new NotImplementedException();
        }

        public Noidungmail GetbyId(EMailType type)
        {
            var data = base._context.Noidungmails.Where(x => x.Loaimail == type).FirstOrDefault();
            return data;
        }
    }
}
