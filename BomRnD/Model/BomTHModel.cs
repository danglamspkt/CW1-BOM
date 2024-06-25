using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomRnD.Model
{
    public class BomTHModel
    {
        public int Id { get; set; }
        public int? STT { get; set; }
        public string NGC { get; set; }
        public string MaTp { get; set; }
        public string TenTiengTrung { get; set; }
        public string DisplayName { get; set; }
        public string MaBanVe1 { get; set; }
        public string MaBanVe2 { get; set; }
        public string MaBtpTW1 { get; set; } 
        public string QuyCachBtpTW1 { get; set; }
        public string MaBtpTW2 { get; set; }
        public string QuyCachBtpTW2 { get; set; }
        public string MaBtpTW3 { get; set; }
        public string QuyCachBtpTW3 { get; set; }
        public string MaBtpTW4 { get; set; }
        public string QuyCachBtpTW4 { get; set; }
        public string MaBtpTW5 { get; set; }
        public string QuyCachBtpTW5 { get; set; }
        public string MaBtpTW6 { get; set; }
        public string QuyCachBtpTW6 { get; set; }
        public string MaBtpVN { get; set; }
        public string MaMuaHang { get; set; }
        public string MaMuaHang2 { get; set; }
        public string MaMuaHang3 { get; set; }
        public Nullable<double> TiLeNlBtp { get; set; }
        public Nullable<double> TiLeNlBtp2 { get; set; }
        public Nullable<double> TiLeNlBtp3 { get; set; }
        public string QuyCach { get; set; }
        public string ChatLieu { get; set; }
        public string QuyCach2 { get; set; }
        public string ChatLieu2 { get; set; }
        public string QuyCach3 { get; set; }
        public string ChatLieu3 { get; set; }
        public Nullable<double> T { get; set; }
        public Nullable<double> W { get; set; }
        public Nullable<double> L { get; set; }
        public Nullable<int> HeSo { get; set; }
        public string GhiChu { get; set; }
        public string MauSon { get; set; }

        public Nullable<double> Kg { get; set; }
        public Nullable<double> KgBtp { get; set; }

    }
}
