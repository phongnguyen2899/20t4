using DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Viewmodels
{
    public class DuyetNhanVienViewModel:BaseNhanVien
    {
        public bool isApply { get; set; }
        public string CV { get; set; }
        public ETrangthai Trangthai { get; set; }
        public int VitriID { get; set; }
        public int ChucvuID { get; set; }
        public ETrangthailienhe Trangthailienhe { get; set; }
        public DateTime ThoigianPV { get; set; }
        public int Diembaitest { get; set; }
        public string DiadiemPV { get; set; }
    }
}
