using DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Repository.NhanVien
{
    public class BaseRepository
    {
        public readonly dbcontext _context;
        public BaseRepository()
        {
            _context = new dbcontext();
        }
    }
}
