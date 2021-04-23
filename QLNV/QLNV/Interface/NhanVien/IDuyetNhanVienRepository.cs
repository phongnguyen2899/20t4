using DATA.Entity;
using DATA.Enum;
using QLNV.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Interface.NhanVien
{
    public interface IDuyetNhanVienRepository
    {
        Task<List<DuyetNhanVienViewModel>> GetAll();
        bool DuyetCv(int id);
        bool LoaiCv(int id);

        Task<List<DuyetNhanVienViewModel>> GetallDaduyetOK();
        Nhanvien GetnhanviendaduyetbyId(int id);

        bool chottime(int idNV, DateTime thoigianpv, ETrangthailienhe trangthailh);
    }
}
