using DATA.Entity;
using QLNV.Interface.Calenda;
using QLNV.Repository.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Repository.Calenda
{
    public class CalendaRepository : BaseRepository, ICalendaRepositorycs
    {
        public List<Nhanvien> GetfullSchedule()
        {
            return base._context.Nhanviens.ToList();
        }
    }
}
