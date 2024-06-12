using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomRnD.Model
{
    public class BomTHModel
    {
        public string NGC { get; set; }
        public string TenTiengTrung { get; set; }
        public string DisplayName { get; set; }
        public string MaBanVe1 { get; set; }
        public string MaBanVe2 { get; set; }
        public string MaBtpTW1 { get; set; }
        public string MaBtpTW2 { get; set; }
        public string MaBtpTW3 { get; set; }
        public string MaBtpVN { get; set; }
        public string MaMuaHang { get; set; }
        public Nullable<double> TiLeNlBtp { get; set; }
        public string QuyCach { get; set; }
        public string ChatLieu { get; set; }
        public Nullable<double> T { get; set; }
        public Nullable<double> W { get; set; }
        public Nullable<double> L { get; set; }
        public Nullable<int> HeSo { get; set; }
    }
}
