using DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Viewmodels
{
    public class LienHeNhanVienViewModel:BaseNhanVien
    {
        public ETrangthailienhe Trangthailienhe { get; set; }
        public string DiadiemPV { get; set; }
        public string Ghichu { get; set; }
        public DateTime ThoigianPV { get; set; }
        public ETrangthai Trangthai { get; set; }
    }
}
