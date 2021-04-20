using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Interface.Vitri
{
    public interface IVitriRepository
    {
        Task<List<DATA.Entity.Vitri>> GetAll();
    }
}
