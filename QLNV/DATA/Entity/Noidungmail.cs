using DATA.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Entity
{
     public class Noidungmail
    {
        public int Id { get; set; }
        public string Tieude { get; set;}
        public string Noidung { get; set;}
        public EMailType Loaimail { get; set; }
    }
}
