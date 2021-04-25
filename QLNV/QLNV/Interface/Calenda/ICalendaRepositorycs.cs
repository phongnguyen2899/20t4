using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Interface.Calenda
{
    public interface ICalendaRepositorycs
    {
        List<Nhanvien> GetfullSchedule();
    }
}
