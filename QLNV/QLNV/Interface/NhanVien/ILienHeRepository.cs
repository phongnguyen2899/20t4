using DATA.Entity;
using QLNV.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Interface.NhanVien
{
    public interface ILienHeRepository
    {
        Task<List<LienHeNhanVienViewModel>> GetAll();

        Task<List<Nhanvien>> GetAllNguoiPV();

        Nhanvien GetbyId(int id);
        bool Datlich(DatlichViewModel model);
    }
}
