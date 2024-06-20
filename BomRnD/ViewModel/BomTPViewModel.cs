using BomRnD.Model;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using BomRnD.UserControlBomLK;
using BomRnD.Basic_Info;
using BomRnD.UserControlBomTp;

namespace BomRnD.ViewModel
{
    public class BomTPViewModel : BaseViewModel
    {
        //-------------------------Khai báo list hiển thị Unit--------------------------------------------------
        private ObservableCollection<BOM_Unit> _Unitlist;
        public ObservableCollection<BOM_Unit> Unitlist { get => _Unitlist; set { _Unitlist = value; OnPropertyChanged(); } }

        //-------------------------Khai báo list hiển thị Phân loại nhỏ--------------------------------------------------
        private ObservableCollection<BOM_MaPLNhoSx> _PLNholist2;
        public ObservableCollection<BOM_MaPLNhoSx> PLNholist2 { get => _PLNholist2; set { _PLNholist2 = value; OnPropertyChanged(); } }

        //-------------------------Khai báo list hiển thị Phân loại lớn--------------------------------------------------
        private ObservableCollection<BOM_MaPLLonSx> _PLLonlist2;
        public ObservableCollection<BOM_MaPLLonSx> PLLonlist2 { get => _PLLonlist2; set { _PLLonlist2 = value; OnPropertyChanged(); } }

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

        private List<string> _PhanLoailist;
        public List<string> PhanLoailist { get => _PhanLoailist; set { _PhanLoailist = value; OnPropertyChanged(); } }

        private List<string> _Seachlist;
        public List<string> Seachlist { get => _Seachlist; set { _Seachlist = value; OnPropertyChanged(); } }

        private string _MaTim;
        public string MaTim { get => _MaTim; set { _MaTim = value; OnPropertyChanged(); } }

        private string _MaPhanLoai;
        public string MaPhanLoai { get => _MaPhanLoai; set { _MaPhanLoai = value; OnPropertyChanged(); } }

        private string _TimKiem;
        public string TimKiem { get => _TimKiem; set { _TimKiem = value; OnPropertyChanged(); } }

        private int? _BOMTPPage;
        public int? BOMTPPage { get => _BOMTPPage; set { _BOMTPPage = value; OnPropertyChanged(); } }




        private string _MaHang;
        public string MaHang { get => _MaHang; set { _MaHang = value; OnPropertyChanged(); } }

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _TenTiengTrung;
        public string TenTiengTrung { get => _TenTiengTrung; set { _TenTiengTrung = value; OnPropertyChanged(); } }

        private string _QuyCach;
        public string QuyCach { get => _QuyCach; set { _QuyCach = value; OnPropertyChanged(); } }

        private int? _Version;
        public int? Version { get => _Version; set { _Version = value; OnPropertyChanged(); } }

        private string _UnitERP;
        public string UnitERP { get => _UnitERP; set { _UnitERP = value; OnPropertyChanged(); } }

        private string _UnitSx;
        public string UnitSx { get => _UnitSx; set { _UnitSx = value; OnPropertyChanged(); } }

        private double? _TyLeChuyenDoi;
        public double? TyLeChuyenDoi { get => _TyLeChuyenDoi; set { _TyLeChuyenDoi = value; OnPropertyChanged(); } }

        private int? _MaKeToanERP;
        public int? MaKeToanERP { get => _MaKeToanERP; set { _MaKeToanERP = value; OnPropertyChanged(); } }

        private int? _MaPLLonERP;
        public int? MaPLLonERP { get => _MaPLLonERP; set { _MaPLLonERP = value; OnPropertyChanged(); } }

        private int? _MaPLNhoERP;
        public int? MaPLNhoERP { get => _MaPLNhoERP; set { _MaPLNhoERP = value; OnPropertyChanged(); } }

        private int? _MaPL4ERP;
        public int? MaPL4ERP { get => _MaPL4ERP; set { _MaPL4ERP = value; OnPropertyChanged(); } }

        private string _MaPLLonSx;
        public string MaPLLonSx { get => _MaPLLonSx; set { _MaPLLonSx = value; OnPropertyChanged(); } }

        private string _MaPLNhoSx;
        public string MaPLNhoSx { get => _MaPLNhoSx; set { _MaPLNhoSx = value; OnPropertyChanged(); } }

        private string _MauSon;
        public string MauSon { get => _MauSon; set { _MauSon = value; OnPropertyChanged(); } }

        private double? _HNet;
        public double? HNet { get => _HNet; set { _HNet = value; OnPropertyChanged(); } }

        private double? _WNet ;
        public double? WNet  { get => _WNet ; set { _WNet  = value; OnPropertyChanged(); } }

        private double? _DNet;
        public double? DNet { get => _DNet ; set { _DNet  = value; OnPropertyChanged(); } }

        private double? _HGross;
        public double? HGross { get => _HGross; set { _HGross = value; OnPropertyChanged(); } }

        private double? _WGross;
        public double? WGross { get => _WGross; set { _WGross = value; OnPropertyChanged(); } }

        private double? _DGross;
        public double? DGross { get => _DGross; set { _DGross = value; OnPropertyChanged(); } }

        private double? _NetWeight;
        public double? NetWeight { get => _NetWeight; set { _NetWeight = value; OnPropertyChanged(); } }

        private double? _GrossWeight;
        public double? GrossWeight { get => _GrossWeight; set { _GrossWeight = value; OnPropertyChanged(); } }

        private string _NetTu;
        public string NetTu { get => _NetTu; set { _NetTu = value; OnPropertyChanged(); } }

        private string _GrossTu;
        public string GrossTu { get => _GrossTu; set { _GrossTu = value; OnPropertyChanged(); } }



        private string _MaHang2;
        public string MaHang2 { get => _MaHang2; set { _MaHang2 = value; OnPropertyChanged(); } }

        private string _DisplayName2;
        public string DisplayName2 { get => _DisplayName2; set { _DisplayName2 = value; OnPropertyChanged(); } }

        private string _TenTiengTrung2;
        public string TenTiengTrung2 { get => _TenTiengTrung2; set { _TenTiengTrung2 = value; OnPropertyChanged(); } }

        private string _QuyCach2;
        public string QuyCach2 { get => _QuyCach2; set { _QuyCach2 = value; OnPropertyChanged(); } }

        private int? _Version2;
        public int? Version2 { get => _Version2; set { _Version2 = value; OnPropertyChanged(); } }

        private string _UnitERP2;
        public string UnitERP2 { get => _UnitERP2; set { _UnitERP2 = value; OnPropertyChanged(); } }

        private string _UnitSx2;
        public string UnitSx2 { get => _UnitSx2; set { _UnitSx2 = value; OnPropertyChanged(); } }

        private double? _TyLeChuyenDoi2;
        public double? TyLeChuyenDoi2 { get => _TyLeChuyenDoi2; set { _TyLeChuyenDoi2 = value; OnPropertyChanged(); } }

        private int? _MaKeToanERP2;
        public int? MaKeToanERP2 { get => _MaKeToanERP2; set { _MaKeToanERP2 = value; OnPropertyChanged(); } }

        private int? _MaPLLonERP2;
        public int? MaPLLonERP2 { get => _MaPLLonERP2; set { _MaPLLonERP2 = value; OnPropertyChanged(); } }

        private int? _MaPLNhoERP2;
        public int? MaPLNhoERP2 { get => _MaPLNhoERP2; set { _MaPLNhoERP2 = value; OnPropertyChanged(); } }

        private int? _MaPL4ERP2;
        public int? MaPL4ERP2 { get => _MaPL4ERP2; set { _MaPL4ERP2 = value; OnPropertyChanged(); } }

        private string _MaPLLonSx2;
        public string MaPLLonSx2 { get => _MaPLLonSx2; set { _MaPLLonSx2 = value; OnPropertyChanged(); } }

        private string _MaPLNhoSx2;
        public string MaPLNhoSx2 { get => _MaPLNhoSx2; set { _MaPLNhoSx2 = value; OnPropertyChanged(); } }

        private string _LinkImg;
        public string LinkImg { get => _LinkImg; set { _LinkImg = value; OnPropertyChanged(); } }

        private string _IDImg;
        public string IDImg { get => _IDImg; set { _IDImg = value; OnPropertyChanged(); } }

        private string _MauSon2;
        public string MauSon2 { get => _MauSon2; set { _MauSon2 = value; OnPropertyChanged(); } }

        private double? _HNet2;
        public double? HNet2 { get => _HNet2; set { _HNet2 = value; OnPropertyChanged(); } }

        private double? _WNet2;
        public double? WNet2 { get => _WNet2; set { _WNet2 = value; OnPropertyChanged(); } }

        private double? _DNet2;
        public double? DNet2 { get => _DNet2; set { _DNet2 = value; OnPropertyChanged(); } }

        private double? _HGross2;
        public double? HGross2 { get => _HGross2; set { _HGross2 = value; OnPropertyChanged(); } }

        private double? _WGross2;
        public double? WGross2 { get => _WGross2; set { _WGross2 = value; OnPropertyChanged(); } }

        private double? _DGross2;
        public double? DGross2 { get => _DGross2; set { _DGross2 = value; OnPropertyChanged(); } }

        private double? _NetWeight2;
        public double? NetWeight2 { get => _NetWeight2; set { _NetWeight2 = value; OnPropertyChanged(); } }

        private double? _GrossWeight2;
        public double? GrossWeight2 { get => _GrossWeight2; set { _GrossWeight2 = value; OnPropertyChanged(); } }



        private string _MaHang3;
        public string MaHang3 { get => _MaHang3; set { _MaHang3 = value; OnPropertyChanged(); } }

        private string _DisplayName3;
        public string DisplayName3 { get => _DisplayName3; set { _DisplayName3 = value; OnPropertyChanged(); } }

        private string _TenTiengTrung3;
        public string TenTiengTrung3 { get => _TenTiengTrung3; set { _TenTiengTrung3 = value; OnPropertyChanged(); } }

        private string _QuyCach3;
        public string QuyCach3 { get => _QuyCach3; set { _QuyCach3 = value; OnPropertyChanged(); } }

        private int? _Version3;
        public int? Version3 { get => _Version3; set { _Version3 = value; OnPropertyChanged(); } }

        private string _UnitERP3;
        public string UnitERP3 { get => _UnitERP3; set { _UnitERP3 = value; OnPropertyChanged(); } }

        private string _UnitSx3;
        public string UnitSx3 { get => _UnitSx3; set { _UnitSx3 = value; OnPropertyChanged(); } }

        private double? _TyLeChuyenDoi3;
        public double? TyLeChuyenDoi3 { get => _TyLeChuyenDoi3; set { _TyLeChuyenDoi3 = value; OnPropertyChanged(); } }

        private int? _MaKeToanERP3;
        public int? MaKeToanERP3 { get => _MaKeToanERP3; set { _MaKeToanERP3 = value; OnPropertyChanged(); } }

        private int? _MaPLLonERP3;
        public int? MaPLLonERP3 { get => _MaPLLonERP3; set { _MaPLLonERP3 = value; OnPropertyChanged(); } }

        private int? _MaPLNhoERP3;
        public int? MaPLNhoERP3 { get => _MaPLNhoERP3; set { _MaPLNhoERP3 = value; OnPropertyChanged(); } }

        private int? _MaPL4ERP3;
        public int? MaPL4ERP3 { get => _MaPL4ERP3; set { _MaPL4ERP3 = value; OnPropertyChanged(); } }

        private string _MaPLLonSx3;
        public string MaPLLonSx3 { get => _MaPLLonSx3; set { _MaPLLonSx3 = value; OnPropertyChanged(); } }

        private string _MaPLNhoSx3;
        public string MaPLNhoSx3 { get => _MaPLNhoSx3; set { _MaPLNhoSx3 = value; OnPropertyChanged(); } }

        private string _LinkImg3;
        public string LinkImg3 { get => _LinkImg3; set { _LinkImg3 = value; OnPropertyChanged(); } }

        private string _IDImg3;
        public string IDImg3 { get => _IDImg3; set { _IDImg3 = value; OnPropertyChanged(); } }

        private string _MauSon3;
        public string MauSon3 { get => _MauSon3; set { _MauSon3 = value; OnPropertyChanged(); } }

        private double? _HNet3;
        public double? HNet3 { get => _HNet3; set { _HNet3 = value; OnPropertyChanged(); } }

        private double? _WNet3;
        public double? WNet3 { get => _WNet3; set { _WNet3 = value; OnPropertyChanged(); } }

        private double? _DNet3;
        public double? DNet3 { get => _DNet3; set { _DNet3 = value; OnPropertyChanged(); } }

        private double? _HGross3;
        public double? HGross3 { get => _HGross3; set { _HGross3 = value; OnPropertyChanged(); } }

        private double? _WGross3;
        public double? WGross3 { get => _WGross3; set { _WGross3 = value; OnPropertyChanged(); } }

        private double? _DGross3;
        public double? DGross3 { get => _DGross3; set { _DGross3 = value; OnPropertyChanged(); } }

        private double? _NetWeight3;
        public double? NetWeight3 { get => _NetWeight3; set { _NetWeight3 = value; OnPropertyChanged(); } }

        private double? _GrossWeight3;
        public double? GrossWeight3 { get => _GrossWeight3; set { _GrossWeight3 = value; OnPropertyChanged(); } }

        public BomTPInfoWindows bomTPInfoWindows;

        bool editdone = false;


        public ICommand TimTPcommand { get; set; }
        public ICommand ThemTPcommand { get; set; }
        public ICommand SuaTPcommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand LoadedaddCommand { get; set; }
        public ICommand LoadedEditCommand { get; set; }
        public ICommand LoadUnitCommand { get; set; }
        public ICommand LoadPLLSxCommand { get; set; }
        public ICommand LoadPLNSxCommand { get; set; }
        public ICommand LoadKtERPCommand { get; set; }
        public ICommand LoadPLLERPCommand { get; set; }
        public ICommand LoadPLNERPCommand { get; set; }
        public ICommand LoadPL4ERPCommand { get; set; }
        public ICommand ChangeLinkingCommand { get; set; }
        public ICommand ChangeLinkingCommand3 { get; set; }



        public BomTPViewModel() 
        {

            PhanLoailist = new List<string>();
            PhanLoailist.Add("<Tất cả>");
            PhanLoailist.Add("Thành phẩm nội địa");
            PhanLoailist.Add("Thành phẩm xuất khẩu");
            MaPhanLoai = PhanLoailist[0];


            Seachlist = new List<string>();
            Seachlist.Add("Mã Hàng");
            Seachlist.Add("Display Name");
            Seachlist.Add("Tên tiếng trung");
            Seachlist.Add("Chất liệu");
            Seachlist.Add("Quy cách");
            Seachlist.Add("Mã phân loại 1 ERP");
            Seachlist.Add("Mã phân loại 2 ERP");
            Seachlist.Add("Mã phân loại 3 ERP");
            Seachlist.Add("Mã phân loại 4 ERP");
            MaTim = Seachlist[0];

            BOMTPPage = 1;

            TimTPcommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BOMTPPage = 1;

                StackPanel stackPanel = new StackPanel();
                additem(stackPanel, 1);

                MainWindow win = Application.Current.MainWindow as MainWindow;

                win.UCMain.Children.Clear();
                win.UCMain.Children.Add(stackPanel);
            });

            ThemTPcommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BomTPAddWindows bomTPAddWindows = new BomTPAddWindows();
                bomTPAddWindows.ShowDialog();
            });
            SuaTPcommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BomTPEditWindows bomTPEditWindows = new BomTPEditWindows();
                bomTPEditWindows.ShowDialog();
            });

            LoadUnitCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                UnitWindow unitWindow = new UnitWindow();
                unitWindow.Show();
            });
            LoadPLLSxCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PLLonSxWindow PLLxWindow = new PLLonSxWindow();
                PLLxWindow.Show();
            });
            LoadPLNSxCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PLNhoSxWindow PL = new PLNhoSxWindow();
                PL.Show();
            });
            LoadKtERPCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaKeToanERPWindow Ma = new MaKeToanERPWindow();
                Ma.Show();
            });
            LoadPLLERPCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PLLonERPWindow pLLonERPWindow = new PLLonERPWindow();
                pLLonERPWindow.Show();
            });
            LoadPLNERPCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PLNhoERPWindow PL = new PLNhoERPWindow();
                PL.Show();
            });
            LoadPL4ERPCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                PL4ERPWindow PL = new PL4ERPWindow();
                PL.Show();
            });

            LoadedaddCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                Unitlist = new ObservableCollection<BOM_Unit>(DataProvider.Ins.DB.BOM_Unit);
                PLLonlist2 = new ObservableCollection<BOM_MaPLLonSx>(DataProvider.Ins.DB.BOM_MaPLLonSx);
                PLNholist2 = new ObservableCollection<BOM_MaPLNhoSx>(DataProvider.Ins.DB.BOM_MaPLNhoSx);
                KeToanERPlist = new ObservableCollection<BOM_MaKeToanERP>(DataProvider.Ins.DB.BOM_MaKeToanERP);
                PLLonERPlist = new ObservableCollection<BOM_MaPLLonERP>(DataProvider.Ins.DB.BOM_MaPLLonERP);
                PLNhoERPlist = new ObservableCollection<BOM_MaPLNhoERP>(DataProvider.Ins.DB.BOM_MaPLNhoERP);
                PL4ERPlist = new ObservableCollection<BOM_MaPL4ERP>(DataProvider.Ins.DB.BOM_MaPL4ERP);

            });

            LoadedEditCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) =>
            {
                Unitlist = new ObservableCollection<BOM_Unit>(DataProvider.Ins.DB.BOM_Unit);
                PLLonlist2 = new ObservableCollection<BOM_MaPLLonSx>(DataProvider.Ins.DB.BOM_MaPLLonSx);
                PLNholist2 = new ObservableCollection<BOM_MaPLNhoSx>(DataProvider.Ins.DB.BOM_MaPLNhoSx);
                KeToanERPlist = new ObservableCollection<BOM_MaKeToanERP>(DataProvider.Ins.DB.BOM_MaKeToanERP);
                PLLonERPlist = new ObservableCollection<BOM_MaPLLonERP>(DataProvider.Ins.DB.BOM_MaPLLonERP);
                PLNhoERPlist = new ObservableCollection<BOM_MaPLNhoERP>(DataProvider.Ins.DB.BOM_MaPLNhoERP);
                PL4ERPlist = new ObservableCollection<BOM_MaPL4ERP>(DataProvider.Ins.DB.BOM_MaPL4ERP);
                var infolist = DataProvider.Ins.DB.BOM_BomTp.Where(x => x.MaHang == MaHang).First();
                MaHang3 = infolist.MaHang;
                QuyCach3 = infolist.QuyCach;
                DisplayName3 = infolist.DisplayName;
                TenTiengTrung3 = infolist.TenTiengTrung;
                UnitERP3 = infolist.UnitERP;
                UnitSx3 = infolist.UnitSx;
                TyLeChuyenDoi3 = infolist.TyLeChuyenDoi;
                Version3 = infolist.Version;
                MaKeToanERP3 = infolist.MaKeToanERP;
                MaPLLonERP3 = infolist.MaPLLonERP;
                MaPLNhoERP3 = infolist.MaPLNhoERP;
                MaPL4ERP3 = infolist.MaPL4ERP;
                MaPLLonSx3 = infolist.MaPLLonSx;
                MaPLNhoSx3 = infolist.MaPLNhoSx;
                LinkImg3 = infolist.LinkImg;
                IDImg3 = infolist.IDImg;
                MauSon3 = infolist.MauSon;
                HNet3 = infolist.HNet;
                WNet3 = infolist.WNet;
                DNet3 = infolist.DNet;
                HGross3 = infolist.HGross;
                WGross3 = infolist.WGross;
                DGross3 = infolist.DGross;
                NetWeight3 = infolist.NetWeight;
                GrossWeight3 = infolist.GrossWeight;


                if (infolist.LinkImg == null || string.IsNullOrEmpty(infolist.LinkImg))
                {
                    PackIcon packIcon = new PackIcon();
                    packIcon.Width = 300;
                    packIcon.Height = 300;
                    packIcon.HorizontalAlignment = HorizontalAlignment.Center;
                    packIcon.VerticalAlignment = VerticalAlignment.Center;
                    packIcon.Margin = new Thickness(10);
                    packIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Image360;
                    packIcon.Foreground = System.Windows.Media.Brushes.Black;
                    p?.Children.Clear();
                    p.Children.Add(packIcon);
                }
                else
                {
                    Image imageBrush = new Image();
                    imageBrush.Stretch = Stretch.Fill;
                    imageBrush.Width = 300;
                    imageBrush.Height = 300;
                    imageBrush.Margin = new Thickness(10);
                    imageBrush.HorizontalAlignment = HorizontalAlignment.Center;
                    imageBrush.VerticalAlignment = VerticalAlignment.Center;
                    string uri = "https://drive.google.com/uc?id=" + infolist.IDImg;
                    imageBrush.Source = new BitmapImage(new Uri(uri));
                    p?.Children.Clear();
                    p.Children.Add(imageBrush);
                }

            });

            AddCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                addTP();
            });
            EditCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                editTP();
            });

            ChangeLinkingCommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) =>
            {
                Image imageBrush = new Image();
                imageBrush.Stretch = Stretch.Fill;
                imageBrush.Width = 300;
                imageBrush.Height = 300;
                imageBrush.Margin = new Thickness(10);
                if (!LinkImg.Contains("https://drive.google.com/file/d/"))
                {
                    MessageBox.Show("Link google drive lỗi!", "Link!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (string.IsNullOrEmpty(IDImg))
                {
                    string a = "https://drive.google.com/file/d/";
                    IDImg = LinkImg.Remove(0, 32);
                    IDImg = IDImg.Remove(IDImg.IndexOf("/"));
                }
                string uri = "https://drive.google.com/uc?id=" + IDImg;
                imageBrush.Source = new BitmapImage(new Uri(uri));
                p?.Children.Clear();
                p.Children.Add(imageBrush);

            });

            ChangeLinkingCommand3 = new RelayCommand<StackPanel>((p) => { return true; }, (p) =>
            {
                Image imageBrush = new Image();
                imageBrush.Stretch = Stretch.Fill;
                imageBrush.Width = 300;
                imageBrush.Height = 300;
                imageBrush.Margin = new Thickness(10);
                if (!LinkImg3.Contains("https://drive.google.com/file/d/"))
                {
                    MessageBox.Show("Link google drive lỗi!", "Link!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (string.IsNullOrEmpty(IDImg3))
                {
                    string a = "https://drive.google.com/file/d/";
                    IDImg3 = LinkImg3.Remove(0, 32);
                    IDImg3 = IDImg3.Remove(IDImg3.IndexOf("/"));
                }
                string uri = "https://drive.google.com/uc?id=" + IDImg3;
                imageBrush.Source = new BitmapImage(new Uri(uri));
                p?.Children.Clear();
                p.Children.Add(imageBrush);

            });

        }

        void addTP()
        {
            var bomtp = DataProvider.Ins.DB.BOM_BomTp;
            var check = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaHang == MaHang2);
            if (MaHang2 == null || check.Count() > 0 || MaHang2.Length == 0)
            {
                MessageBox.Show("Mã hàng đã tồn tại hoặc trống!", "Thêm mã hàng lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                BOM_BomTp bOM_BomTp = new BOM_BomTp();
                bOM_BomTp.MaHang = MaHang2;
                bOM_BomTp.QuyCach = QuyCach2;
                bOM_BomTp.DisplayName = DisplayName2;
                bOM_BomTp.TenTiengTrung = TenTiengTrung2;
                bOM_BomTp.UnitERP = UnitERP2;
                bOM_BomTp.UnitSx = UnitSx2;
                bOM_BomTp.TyLeChuyenDoi = TyLeChuyenDoi2;
                bOM_BomTp.Version = Version2;
                bOM_BomTp.MaKeToanERP = MaKeToanERP2;
                bOM_BomTp.MaPLLonERP = MaPLLonERP2;
                bOM_BomTp.MaPLNhoERP = MaPLNhoERP2;
                bOM_BomTp.MaPL4ERP = MaPL4ERP2;
                bOM_BomTp.MaPLLonSx = MaPLLonSx2;
                bOM_BomTp.MaPLNhoSx = MaPLNhoSx2;
                bOM_BomTp.LinkImg = LinkImg;
                bOM_BomTp.IDImg = IDImg;
                bOM_BomTp.HNet = HNet2;
                bOM_BomTp.WNet = WNet2;
                bOM_BomTp.DNet = DNet2;
                bOM_BomTp.HGross = HGross2;
                bOM_BomTp.WGross = WGross2;
                bOM_BomTp.DGross = DGross2;
                bOM_BomTp.NetWeight = NetWeight2;
                bOM_BomTp.GrossWeight = GrossWeight2;
                bOM_BomTp.MauSon = MauSon2;
                bOM_BomTp.UserName = Properties.Settings.Default.UserName;

                DataProvider.Ins.DB.BOM_BomTp.Add(bOM_BomTp);
                DataProvider.Ins.DB.SaveChanges();
                MaHang2 = null;
                QuyCach2 = null;
                DisplayName2 = null;
                TenTiengTrung2 = null;
                UnitERP2 = null;
                UnitSx2 = null;
                TyLeChuyenDoi2 = null;
                Version2 = null;
                MaKeToanERP2 = null;
                MaPLLonERP2 = null;
                MaPLNhoERP2 = null;
                MaPL4ERP2 = null;
                MaPLLonSx2 = null;
                MaPLNhoSx2 = null;
                LinkImg = null;
                IDImg = null;
                MauSon2 = null;
                HNet2 = null;
                WNet2 = null;
                DNet2 = null;
                HGross2 = null;
                WGross2 = null;
                DGross2 = null;
                NetWeight2 = null;
                GrossWeight2 = null;
            }
        }

        void editTP()
        {
            var bOM_BomTp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaHang == MaHang3).FirstOrDefault();
            {
                bOM_BomTp.MaHang = MaHang3;
                bOM_BomTp.QuyCach = QuyCach3;
                bOM_BomTp.DisplayName = DisplayName3;
                bOM_BomTp.TenTiengTrung = TenTiengTrung3;
                bOM_BomTp.UnitERP = UnitERP3;
                bOM_BomTp.UnitSx = UnitSx3;
                bOM_BomTp.TyLeChuyenDoi = TyLeChuyenDoi3;
                bOM_BomTp.Version = Version3;
                bOM_BomTp.MaKeToanERP = MaKeToanERP3;
                bOM_BomTp.MaPLLonERP = MaPLLonERP3;
                bOM_BomTp.MaPLNhoERP = MaPLNhoERP3;
                bOM_BomTp.MaPL4ERP = MaPL4ERP3;
                bOM_BomTp.MaPLLonSx = MaPLLonSx3;
                bOM_BomTp.MaPLNhoSx = MaPLNhoSx3;
                bOM_BomTp.LinkImg = LinkImg3;
                bOM_BomTp.IDImg = IDImg3;
                bOM_BomTp.HNet = HNet3;
                bOM_BomTp.WNet = WNet3;
                bOM_BomTp.DNet = DNet3;
                bOM_BomTp.HGross = HGross3;
                bOM_BomTp.WGross = WGross3;
                bOM_BomTp.DGross = DGross3;
                bOM_BomTp.NetWeight = NetWeight3;
                bOM_BomTp.GrossWeight = GrossWeight3;
                bOM_BomTp.MauSon = MauSon3;
                bOM_BomTp.UserName = Properties.Settings.Default.UserName;
                DataProvider.Ins.DB.SaveChanges();
                MaHang = MaHang3;
                DisplayName = DisplayName3;
                QuyCach = QuyCach3;
                Version = Version3;
                UnitERP = UnitERP3;
                UnitSx = UnitSx3;
                TyLeChuyenDoi = TyLeChuyenDoi3;
                MaKeToanERP = MaKeToanERP3;
                MaPLLonERP = MaPLLonERP3;
                MaPLNhoERP = MaPLNhoERP3;
                MaPL4ERP = MaPL4ERP3;
                MaPLLonSx = MaPLLonSx3;
                MaPLNhoSx = MaPLNhoSx3;
                MauSon = MauSon3;
                HNet = HNet3;
                WNet = WNet3;
                DNet = DNet3;
                HGross = HGross3;
                WGross = WGross3;
                DGross = DGross3;
                NetWeight = NetWeight3;
                GrossWeight = GrossWeight3;
                editdone = true;

            }
        }

        void additem(StackPanel stackPanel, int? BOMTPPage)
        {

            WrapPanel wrapPanel = new WrapPanel();

            string PLL = null;
            string PLN = null;

            IQueryable<BOM_BomTp> bomtp = DataProvider.Ins.DB.BOM_BomTp;

            switch (MaPhanLoai)
            {
                case "<Tất cả>":
                    if (string.IsNullOrEmpty(TimKiem)) // tất cả thành phẩm, tim kiem = tất cả
                    {
                        bomtp = DataProvider.Ins.DB.BOM_BomTp;
                    }
                    else // tất cả thành phẩm, tim kiem # tất cả
                    {
                        switch (MaTim)
                        {
                            case "Mã Hàng":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaHang.Contains(TimKiem));
                                break;
                            case "Display Name":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.DisplayName.Contains(TimKiem));
                                break;
                            case "Tên tiếng trung":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.TenTiengTrung.Contains(TimKiem));
                                break;
                            case "Quy cách":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.QuyCach.Contains(TimKiem));
                                break;
                            case "Mã phân loại 1 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaKeToanERP.ToString().Contains(TimKiem));
                                break;
                            case "Mã phân loại 2 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPLLonERP.ToString().Contains(TimKiem));
                                break;
                            case "Mã phân loại 3 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPLNhoERP.ToString().Contains(TimKiem));
                                break;
                            case "Mã phân loại 4 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPL4ERP.ToString().Contains(TimKiem));
                                break;
                        }
                    }
                    break;
                case "Thành phẩm nội địa":
                    if (string.IsNullOrEmpty(TimKiem)) // thành phẩm nội địa, tim kiem = tất cả
                    {
                        bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPLNhoSx == "0802");
                    }
                    else // thành phẩm nội địa, tim kiem # tất cả
                    {
                        switch (MaTim)
                        {
                            case "Mã Hàng":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaHang.Contains(TimKiem) && y.MaPLNhoSx=="0802");
                                break;
                            case "Display Name":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.DisplayName.Contains(TimKiem) && y.MaPLNhoSx == "0802");
                                break;
                            case "Tên tiếng trung":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.TenTiengTrung.Contains(TimKiem) && y.MaPLNhoSx == "0802");
                                break;
                            case "Quy cách":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.QuyCach.Contains(TimKiem) && y.MaPLNhoSx == "0802");
                                break;
                            case "Mã phân loại 1 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaKeToanERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == "0802");
                                break;
                            case "Mã phân loại 2 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPLLonERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == "0802");
                                break;
                            case "Mã phân loại 3 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPLNhoERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == "0802");
                                break;
                            case "Mã phân loại 4 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPL4ERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == "0802");
                                break;
                        }
                    }
                    break;
                case "Thành phẩm xuất khẩu":
                    if (string.IsNullOrEmpty(TimKiem)) // thành phẩm xuất khẩu, tim kiem = tất cả
                    {
                        bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPLNhoSx == "0801");
                    }
                    else // thành phẩm nội địa, tim kiem # tất cả
                    {
                        switch (MaTim)
                        {
                            case "Mã Hàng":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaHang.Contains(TimKiem) && y.MaPLNhoSx == "0801");
                                break;
                            case "Display Name":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.DisplayName.Contains(TimKiem) && y.MaPLNhoSx == "0801");
                                break;
                            case "Tên tiếng trung":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.TenTiengTrung.Contains(TimKiem) && y.MaPLNhoSx == "0801");
                                break;
                            case "Quy cách":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.QuyCach.Contains(TimKiem) && y.MaPLNhoSx == "0801");
                                break;
                            case "Mã phân loại 1 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaKeToanERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == "0801");
                                break;
                            case "Mã phân loại 2 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPLLonERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == "0801");
                                break;
                            case "Mã phân loại 3 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPLNhoERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == "0801");
                                break;
                            case "Mã phân loại 4 ERP":
                                bomtp = DataProvider.Ins.DB.BOM_BomTp.Where(y => y.MaPL4ERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == "0801");
                                break;
                        }
                    }
                    break;
            }

            
            int itembom = 0;
            foreach (var item in bomtp)
            {
                itembom++;

                if ((itembom <= (BOMTPPage * 20)) && (itembom >= ((BOMTPPage * 20) - 19)))
                {
                    StackPanel stackPanel1 = new StackPanel();
                    //stackPanel1.Width = 250;
                    //stackPanel1.Height = 250;
                    //stackPanel1.Margin = new Thickness(20);

                    Button button = new Button();
                    button.Width = 250;
                    button.Height = 250;
                    button.Margin = new Thickness(20);
                    button.Style = (Style)Application.Current.TryFindResource("MaterialDesignFlatSecondaryDarkButton");
                    button.Foreground = System.Windows.Media.Brushes.Black;

                    if (item.LinkImg == null)
                    {
                        PackIcon packIcon = new PackIcon();
                        packIcon.Width = 150;
                        packIcon.Height = 150;
                        packIcon.HorizontalAlignment = HorizontalAlignment.Center;
                        packIcon.VerticalAlignment = VerticalAlignment.Center;
                        packIcon.Margin = new Thickness(10);
                        packIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Image;
                        stackPanel1.Children.Add(packIcon);
                    }
                    else
                    {
                        Image imageBrush = new Image();
                        imageBrush.Stretch = Stretch.Fill;
                        imageBrush.Width = 150;
                        imageBrush.Height = 150;
                        imageBrush.Margin = new Thickness(10);
                        string uri = "https://drive.google.com/uc?id=" + item.IDImg;
                        imageBrush.Source = new BitmapImage(new Uri(uri));
                        stackPanel1.Children.Add(imageBrush);
                    }

                    TextBlock textBlock1 = new TextBlock();
                    textBlock1.Text = item.MaHang;
                    textBlock1.HorizontalAlignment = HorizontalAlignment.Center;
                    textBlock1.VerticalAlignment = VerticalAlignment.Center;
                    textBlock1.Margin = new Thickness(10);
                    stackPanel1.Children.Add(textBlock1);
                    TextBlock textBlock2 = new TextBlock();
                    textBlock2.Text = item.QuyCach;
                    textBlock2.HorizontalAlignment = HorizontalAlignment.Center;
                    textBlock2.VerticalAlignment = VerticalAlignment.Center;
                    textBlock2.Margin = new Thickness(10);
                    stackPanel1.Children.Add(textBlock2);

                    button.Click += (sender, args) =>
                    {

                        MaHang = item.MaHang;
                        DisplayName = item.DisplayName;
                        QuyCach = item.QuyCach;
                        Version = item.Version;
                        UnitERP = item.UnitERP;
                        UnitSx = item.UnitSx;
                        TyLeChuyenDoi = item.TyLeChuyenDoi;
                        MaKeToanERP = item.MaKeToanERP;
                        MaPLLonERP = item.MaPLLonERP;
                        MaPLNhoERP = item.MaPLNhoERP;
                        MaPL4ERP = item.MaPL4ERP;
                        MaPLLonSx = item.MaPLLonSx;
                        MaPLNhoSx = item.MaPLNhoSx;
                        MauSon = item.MauSon;
                        HNet = item.HNet;
                        WNet = item.WNet;
                        DNet = item.DNet;
                        HGross = item.HGross;
                        WGross = item.WGross;
                        DGross = item.DGross;
                        NetWeight = item.NetWeight;
                        GrossWeight = item.GrossWeight;

                        NetTu = HNet + " x " + WNet + " x " + DNet;
                        GrossTu = HGross + " x " + WGross + " x " + DGross;


                        bomTPInfoWindows = new BomTPInfoWindows();
                        bomTPInfoWindows.Show();
                        if (item.LinkImg == null)
                        {
                            PackIcon packIcon = new PackIcon();
                            packIcon.Width = 300;
                            packIcon.Height = 300;
                            packIcon.HorizontalAlignment = HorizontalAlignment.Center;
                            packIcon.VerticalAlignment = VerticalAlignment.Center;
                            packIcon.Margin = new Thickness(10);
                            packIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Image;
                            packIcon.Foreground = System.Windows.Media.Brushes.Black;
                            bomTPInfoWindows.TPAvar.Children.Clear();
                            bomTPInfoWindows.TPAvar.Children.Add(packIcon);
                        }
                        else
                        {
                            Image imageBrush = new Image();
                            imageBrush.Stretch = Stretch.Fill;
                            imageBrush.Width = 300;
                            imageBrush.Height = 300;
                            imageBrush.Margin = new Thickness(10);
                            imageBrush.HorizontalAlignment = HorizontalAlignment.Center;
                            imageBrush.VerticalAlignment = VerticalAlignment.Center;
                            string uri = "https://drive.google.com/uc?id=" + item.IDImg;
                            imageBrush.Source = new BitmapImage(new Uri(uri));
                            bomTPInfoWindows.TPAvar.Children.Clear();
                            bomTPInfoWindows.TPAvar.Children.Add(imageBrush);
                        }


                    };


                    button.Content = stackPanel1;
                    wrapPanel.Children.Add(button);
                }
                else if (itembom > (BOMTPPage * 20))
                {
                    break;
                }

            }

            stackPanel.Children.Add(wrapPanel);

            StackPanel stackPanel2 = new StackPanel();
            stackPanel2.Orientation = Orientation.Horizontal;
            stackPanel2.HorizontalAlignment = HorizontalAlignment.Center;

            MaterialDesignThemes.Wpf.PackIcon icon2 = new MaterialDesignThemes.Wpf.PackIcon();
            icon2.Height = 64;
            icon2.Width = 64;
            icon2.Kind = MaterialDesignThemes.Wpf.PackIconKind.SkipPrevious;
            icon2.Foreground = System.Windows.Media.Brushes.Black;
            Button prebtn = new Button();
            prebtn.Style = (Style)Application.Current.TryFindResource("MaterialDesignIconButton");
            prebtn.Width = 64;
            prebtn.Height = 64;
            prebtn.Background = System.Windows.Media.Brushes.Transparent;
            prebtn.Content = icon2;
            prebtn.Click += prebtn_click;
            if (BOMTPPage <= 1) prebtn.IsEnabled = false; else prebtn.IsEnabled = true;
            stackPanel2.Children.Add(prebtn);

            TextBlock textBlock = new TextBlock();
            textBlock.Text = BOMTPPage.ToString() + "/" + ((bomtp.Count() / 20) + 1);
            textBlock.FontSize = 32;
            textBlock.VerticalAlignment = VerticalAlignment.Center;
            textBlock.Margin = new Thickness(10, 0, 10, 0);
            stackPanel2.Children.Add(textBlock);

            MaterialDesignThemes.Wpf.PackIcon icon = new MaterialDesignThemes.Wpf.PackIcon();
            icon.Height = 64;
            icon.Width = 64;
            icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.SkipNext;
            icon.Foreground = System.Windows.Media.Brushes.Black;
            Button nextbtn = new Button();
            nextbtn.Style = (Style)Application.Current.TryFindResource("MaterialDesignIconButton");
            nextbtn.Width = 64;
            nextbtn.Height = 64;
            nextbtn.Background = System.Windows.Media.Brushes.Transparent;
            nextbtn.Content = icon;
            nextbtn.Click += nextbtn_click;
            if (BOMTPPage >= (bomtp.Count() / 20) + 1) nextbtn.IsEnabled = false; else nextbtn.IsEnabled = true;
            stackPanel2.Children.Add(nextbtn);

            stackPanel.Children.Add(stackPanel2);

        }

        void nextbtn_click(object sender, RoutedEventArgs e)
        {
            BOMTPPage++;
            StackPanel stackPanel = new StackPanel();
            additem(stackPanel, BOMTPPage);

            MainWindow win = Application.Current.MainWindow as MainWindow;

            win.UCMain.Children.Clear();
            win.UCMain.Children.Add(stackPanel);
        }

        void prebtn_click(object sender, RoutedEventArgs e)
        {
            BOMTPPage--;
            StackPanel stackPanel = new StackPanel();
            additem(stackPanel, BOMTPPage);

            MainWindow win = Application.Current.MainWindow as MainWindow;

            win.UCMain.Children.Clear();
            win.UCMain.Children.Add(stackPanel);
        }


    }
}
