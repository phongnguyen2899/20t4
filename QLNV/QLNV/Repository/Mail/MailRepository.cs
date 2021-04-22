using Common;
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

        
      

        public Noidungmail GetnoidungmailbyID(int Idnhanvien, int vitriid)
        {
            var mailtonhanvien = base._context.Mailtonhanviens.Where(x => x.NhanvienId == Idnhanvien).FirstOrDefault();
            if (mailtonhanvien == null)
            {
                var noidungmail = new Noidungmail();
                if (vitriid == 4)
                {
                    noidungmail = base._context.Noidungmails.Where(x => x.Loaimail == EMailType.MaiTTS).FirstOrDefault();
                }
                else if (vitriid== 5)
                {
                    noidungmail = base._context.Noidungmails.Where(x => x.Loaimail == EMailType.MailFresher).FirstOrDefault();
                }
                else if (vitriid == 6)
                {
                    noidungmail = base._context.Noidungmails.Where(x => x.Loaimail == EMailType.MailDev).FirstOrDefault();
                }
                return noidungmail;
            }
            return new Noidungmail
            {
                Id=1,
                Noidung = mailtonhanvien.Noidung,
                Tieude = mailtonhanvien.Tieude
            };
        }

        public void Guimal(int[] Ids)
        {
            for(int i = 0; i < Ids.Length; i++)
            {
                var noidungmail = base._context.Mailtonhanviens.Where(x => x.NhanvienId == Ids[i]).FirstOrDefault();
                if (noidungmail != null)
                {
                    var emailnhanvien = base._context.Nhanviens.Where(x => x.Id == Ids[i]).FirstOrDefault().Email;
                    Mailhelper.SendMail(emailnhanvien, noidungmail.Tieude, noidungmail.Noidung);
                }
                else
                {
                    var nhanvien = base._context.Nhanviens.Where(x => x.Id == Ids[i]).FirstOrDefault();
                    var vitri = nhanvien.VitriId;
                    var emailnhanvien = nhanvien.Email;


                    var mailToTTS = base._context.Noidungmails.Where(x => x.Loaimail == EMailType.MaiTTS).FirstOrDefault();
                    var mailtoFresher = base._context.Noidungmails.Where(x => x.Loaimail == EMailType.MaiTTS).FirstOrDefault();
                    var mailToDev = base._context.Noidungmails.Where(x => x.Loaimail == EMailType.MaiTTS).FirstOrDefault();
                    switch (vitri)
                    {
                        case 4:
                            Mailhelper.SendMail(emailnhanvien, mailToTTS.Tieude, mailToTTS.Noidung);
                            break;
                        case 5:
                            Mailhelper.SendMail(emailnhanvien, mailtoFresher.Tieude, mailtoFresher.Noidung);
                            break;
                        case 6:
                            Mailhelper.SendMail(emailnhanvien, mailToDev.Tieude, mailToDev.Noidung);
                            break;

                    }
                }
            }
        }
    }
}
