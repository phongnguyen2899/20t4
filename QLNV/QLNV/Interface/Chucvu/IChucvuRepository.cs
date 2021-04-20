using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Interface.Chucvu
{
    public interface IChucvuRepository
    {
        Task<List<DATA.Entity.Chucvu>> GetAll();
    }
}
