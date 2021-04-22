using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Entity
{
    public class Mailtonhanvien
    {
        public int NhanvienId { get; set; }

        public string Tieude { get; set; }
        public string Noidung { get; set; }


        public Nhanvien Nhanvien { get; set;}

    }
}
