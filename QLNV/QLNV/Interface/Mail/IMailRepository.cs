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
        Noidungmail GetbyId(EMailType type);
    }
}
