using DATA.Entity;
using DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Interface.Mail
{
    public interface IMailRepository
    {
        bool Create(DATA.Entity.Noidungmail mail);
        bool Update(Noidungmail model);
        Noidungmail GetbyId(EMailType type);

        Noidungmail GetnoidungmailbyID(int Idnhanvien,int vitriid);

        void Guimal(int[] Ids);


        //for mailcontroller

        Task<List<Noidungmail>> Getall();
    }
}
