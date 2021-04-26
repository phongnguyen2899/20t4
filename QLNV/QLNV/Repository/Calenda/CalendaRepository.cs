using Common;
using DATA.Entity;
using QLNV.Interface.Calenda;
using QLNV.Repository.NhanVien;
using QLNV.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Repository.Calenda
{
    public class CalendaRepository : BaseRepository, ICalendaRepositorycs
    {
        public bool DeleteSchedule(int id)
        {
            var nhanvien = base._context.Nhanviens.Where(x => x.Id == id).FirstOrDefault();
            var nguoipv = base._context.Nhanviens.Where(x => x.Id == nhanvien.Nguoiphongvan).FirstOrDefault();
            if (nhanvien != null)
            {
                Mailhelper.SendMail(nguoipv.Email, "Huỷ Lịch Phỏng Vấn", "Hủy Lịch Phỏng vấn ngày " + nhanvien.ThoigianPV + " với "+nhanvien.Ten+"");
                var time = DateTime.Parse("0001-01-01 00:00:00.0000000");
                nhanvien.Nguoiphongvan = 0;
                nhanvien.ThoigianPV = time;
                nhanvien.Ghichu = null;
                base._context.SaveChanges();

                return true;
            }
            return false;
        }

        public List<Nhanvien> GetfullSchedule()
        {
            return base._context.Nhanviens.ToList();
        }

        public Nhanvien GetInterViewById(int idnhanvien)
        {
            var nhanvien = base._context.Nhanviens.Where(x => x.Id == idnhanvien).FirstOrDefault();
            var interview = base._context.Nhanviens.Where(x => x.Nguoiphongvan == nhanvien.Nguoiphongvan).FirstOrDefault();
            return interview;

        }

        public bool UpdateSchedule(DatlichViewModel model)
        {
            var data = base._context.Nhanviens.Where(x => x.Id == model.Id).FirstOrDefault();

            if (data != null)
            {
                var nguoipv = base._context.Nhanviens.Where(x => x.Id == data.Nguoiphongvan).FirstOrDefault();

                Mailhelper.SendMail(nguoipv.Email, "Cập nhật lịch phỏng vấn", "Chuyển lịch phỏng vấn " + data.Ten + " từ " + data.ThoigianPV + " sang ngày " + model.Ngaypv + "");
                data.Nguoiphongvan = model.Idnguoipv;
                data.ThoigianPV = model.Ngaypv;
                data.Ghichu = "" + nguoipv.Ten + " Phỏng vấn";
                base._context.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
