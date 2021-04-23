using DATA.Entity;
using Microsoft.EntityFrameworkCore;
using QLNV.Interface.NhanVien;
using QLNV.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Repository.NhanVien
{
    public class LienHeNhanVienRepository : BaseRepository, ILienHeRepository
    {
        public bool Datlich(DatlichViewModel model)
        {
            var nhanvien = base._context.Nhanviens.Where(x => x.Id == model.Id).FirstOrDefault();
            if (nhanvien != null)
            {
                
                try
                {
                    nhanvien.Nguoiphongvan = model.Idnguoipv;
                    nhanvien.ThoigianPV = model.Ngaypv;
                    nhanvien.DiadiemPV = model.Diadiempv;
                    var nguoipv = _context.Nhanviens.Find(model.Idnguoipv);
                    nhanvien.Ghichu = "" + nguoipv.Ten + " Phỏng vấn";
                    _context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public async Task<List<LienHeNhanVienViewModel>> GetAll()
        {
            var data = from x in base._context.Nhanviens
                       join c in _context.Chucvus on x.ChucvuId equals c.Id
                       join v in _context.Vitris on x.VitriId equals v.Id
                       select new LienHeNhanVienViewModel
                       {
                           Id = x.Id,
                           Tenchucvu = c.Tenchucvu,
                           Tenvitri = v.Tenvitri,
                           Ten = x.Ten,
                           Ngaysinhh = x.Ngaysinhh,
                           SDT = x.SDT,
                           Email=x.Email,
                           ThoigianPV=x.ThoigianPV,
                           DiadiemPV=x.DiadiemPV,
                           Ghichu=x.Ghichu,
                           Trangthai=x.Trangthai
                       };
           data= data.Where(x => x.Trangthai == DATA.Enum.ETrangthai.DuyetCV || x.Trangthai == DATA.Enum.ETrangthai.TestOk
            || x.Trangthai == DATA.Enum.ETrangthai.Passv1|| x.Trangthai == DATA.Enum.ETrangthai.Passv2);

            var y = data.ToList();
            return await data.ToListAsync();
        }

        public async Task<List<Nhanvien>> GetAllNguoiPV()
        {
            return base._context.Nhanviens.Where(x => x.Trangthai == DATA.Enum.ETrangthai.AllOk).ToList();
        }

        public Nhanvien GetbyId(int id)
        {
            return base._context.Nhanviens.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
