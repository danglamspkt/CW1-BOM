using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomRnD.Model
{
    public class BomTHLkPhuModel
    {
        public int Id { get; set; }
        public string MaBtp { get; set; }
        public string DisplayName { get; set; }
        public string MaBtpPhu { get; set; }
        public Nullable<int> HeSo { get; set; }
        public string GhiChu { get; set; }
        public string UserName { get; set; }
        public string UserNameEdit { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> DateEdit { get; set; }
    }
}
