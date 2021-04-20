using Microsoft.EntityFrameworkCore;
using QLNV.Interface.Chucvu;
using QLNV.Repository.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Repository.Chucvu
{
    public class ChucvuRepository : BaseRepository,IChucvuRepository
    {
        public async Task<List<DATA.Entity.Chucvu>> GetAll()
        {
            IQueryable<DATA.Entity.Chucvu> data = base._context.Chucvus;
            return await data.ToListAsync();
        }
    }
}
