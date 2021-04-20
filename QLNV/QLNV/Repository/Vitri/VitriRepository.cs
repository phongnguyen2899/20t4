using Microsoft.EntityFrameworkCore;
using QLNV.Interface.Vitri;
using QLNV.Repository.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Repository.Vitri
{
    public class VitriRepository :BaseRepository,IVitriRepository
    {
        public async Task<List<DATA.Entity.Vitri>> GetAll()
        {
            IQueryable<DATA.Entity.Vitri> data=  base._context.Vitris;
            return await data.ToListAsync();
        }
    }
}
