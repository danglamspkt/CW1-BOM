using BomRnD.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BomRnD.ViewModel
{
    public class BasicViewModel : BaseViewModel
    {
        //-------------------------Khai báo list hiển thị Unit--------------------------------------------------
        private ObservableCollection<BOM_Unit> _Unitlist;
        public ObservableCollection<BOM_Unit> Unitlist { get => _Unitlist; set { _Unitlist = value; OnPropertyChanged(); } }

        //-------------------------Khai báo list hiển thị Phân loại nhỏ--------------------------------------------------
        private ObservableCollection<BOM_MaPLNhoSx> _PLNhoSxlist;
        public ObservableCollection<BOM_MaPLNhoSx> PLNhoSxlist { get => _PLNhoSxlist; set { _PLNhoSxlist = value; OnPropertyChanged(); } }

        //-------------------------Khai báo list hiển thị Phân loại lớn--------------------------------------------------
        private ObservableCollection<BOM_MaPLLonSx> _PLLonSxlist;
        public ObservableCollection<BOM_MaPLLonSx> PLLonSxlist { get => _PLLonSxlist; set { _PLLonSxlist = value; OnPropertyChanged(); } }

        //-------------------------Khai báo list hiển thị PLKetoanERP--------------------------------------------------
        private ObservableCollection<BOM_MaKeToanERP> _MaKeToanERPlist;
        public ObservableCollection<BOM_MaKeToanERP> KeToanERPlist { get => _MaKeToanERPlist; set { _MaKeToanERPlist = value; OnPropertyChanged(); } }

        //-------------------------Khai báo list hiển thị Phân loại nhỏ--------------------------------------------------
        private ObservableCollection<BOM_MaPLLonERP> _PLLonERPlist;
        public ObservableCollection<BOM_MaPLLonERP> PLLonERPlist { get => _PLLonERPlist; set { _PLLonERPlist = value; OnPropertyChanged(); } }

        //-------------------------Khai báo list hiển thị Phân loại nhỏ--------------------------------------------------
        private ObservableCollection<BOM_MaPLNhoERP> _PLNhoERPlist;
        public ObservableCollection<BOM_MaPLNhoERP> PLNhoERPlist { get => _PLNhoERPlist; set { _PLNhoERPlist = value; OnPropertyChanged(); } }

        //-------------------------Khai báo list hiển thị Phân loại nhỏ--------------------------------------------------
        private ObservableCollection<BOM_MaPL4ERP> _PL4ERPlist;
        public ObservableCollection<BOM_MaPL4ERP> PL4ERPlist { get => _PL4ERPlist; set { _PL4ERPlist = value; OnPropertyChanged(); } }


        public ICommand LoadedUnitCommand { get; set; }
        public ICommand LoadedPLLSxCommand { get; set; }
        public ICommand LoadedPLNSxCommand { get; set; }
        public ICommand LoadedKTERPCommand { get; set; }
        public ICommand LoadedPLLERPCommand { get; set; }
        public ICommand LoadedPLNERPCommand { get; set; }
        public ICommand LoadedPL4ERPCommand { get; set; }


        public BasicViewModel() 
        {
            LoadedUnitCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                Unitlist = new ObservableCollection<BOM_Unit>(DataProvider.Ins.DB.BOM_Unit);
            });
            LoadedPLLSxCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                PLLonSxlist = new ObservableCollection<BOM_MaPLLonSx>(DataProvider.Ins.DB.BOM_MaPLLonSx);
            });
            LoadedPLNSxCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                PLNhoSxlist = new ObservableCollection<BOM_MaPLNhoSx>(DataProvider.Ins.DB.BOM_MaPLNhoSx);
            });
            LoadedKTERPCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                KeToanERPlist = new ObservableCollection<BOM_MaKeToanERP>(DataProvider.Ins.DB.BOM_MaKeToanERP);
            });
            LoadedPLLERPCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                PLLonERPlist = new ObservableCollection<BOM_MaPLLonERP>(DataProvider.Ins.DB.BOM_MaPLLonERP);
            });
            LoadedPLNERPCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                PLNhoERPlist = new ObservableCollection<BOM_MaPLNhoERP>(DataProvider.Ins.DB.BOM_MaPLNhoERP);
            });
            LoadedPL4ERPCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                PL4ERPlist = new ObservableCollection<BOM_MaPL4ERP>(DataProvider.Ins.DB.BOM_MaPL4ERP);
            });
        }
    }
}
