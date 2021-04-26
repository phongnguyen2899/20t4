using DATA.Entity;
using QLNV.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Interface.Calenda
{
    public interface ICalendaRepositorycs
    {
        List<Nhanvien> GetfullSchedule();
        Nhanvien GetInterViewById(int idnhanvien);

        bool UpdateSchedule(DatlichViewModel model);
        bool DeleteSchedule(int id);
    }
}
