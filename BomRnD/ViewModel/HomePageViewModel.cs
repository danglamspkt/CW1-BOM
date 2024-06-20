using BomRnD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomRnD.ViewModel
{
    public class HomePageViewModel : BaseViewModel
    {
        private int _SLTH;
        public int SLTH { get => _SLTH; set { _SLTH = value; OnPropertyChanged(); } }

        private int _SLTp;
        public int SLTp { get => _SLTp; set { _SLTp = value; OnPropertyChanged(); } }

        private int _SLNl;
        public int SLNl { get => _SLNl; set { _SLNl = value; OnPropertyChanged(); } }

        private int _SLBtp;
        public int SLBtp { get => _SLBtp; set { _SLBtp = value; OnPropertyChanged(); } }

        public HomePageViewModel() 
        {
            var th = DataProvider.Ins.DB.BOM_BomTH.GroupBy(x => new { x.MaTp, x.ThiTruong }).Select(x => x.FirstOrDefault());
            SLTH = th.Count();
            var Nl = DataProvider.Ins.DB.BOM_BomNl;
            SLNl = Nl.Count();
            var Btp = DataProvider.Ins.DB.BOM_BomBtp;
            SLBtp = Btp.Count();
            var Tp = DataProvider.Ins.DB.BOM_BomTp;
            SLTp = Tp.Count();

        }
    }
}
