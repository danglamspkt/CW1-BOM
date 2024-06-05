using BomRnD.Model;
using ControlzEx.Standard;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;
using DevExpress.Data.Linq.Helpers;
using BomRnD.UserControlBomNL;
using MaterialDesignThemes.MahApps;
using BomRnD.UserControlBomKhac;
using BomRnD.UserControlBomLK;
using BomRnD.UserControlBomTH;
using BomRnD.UserControlHome;
using BomRnD.UserControlSetting;
using BomRnD.Basic_Info;
using MahApps.Metro.Controls;

namespace BomRnD.ViewModel
{
    public class BOMNguyenLieuViewModel : BaseViewModel
    {
        //-------------------------Khai báo list hiển thị Phân loại lớn--------------------------------------------------
        private ObservableCollection<BOM_MaPLLonSx> _PLLonlist;
        public ObservableCollection<BOM_MaPLLonSx> PLLonlist { get => _PLLonlist; set { _PLLonlist = value; OnPropertyChanged(); } }

        //-------------------------Khai báo list hiển thị Phân loại nhỏ--------------------------------------------------
        private ObservableCollection<BOM_MaPLNhoSx> _PLNholist;
        public ObservableCollection<BOM_MaPLNhoSx> PLNholist { get => _PLNholist; set { _PLNholist = value; OnPropertyChanged(); } }

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


        private List<string> _Seachlist;
        public List<string> Seachlist { get => _Seachlist; set { _Seachlist = value; OnPropertyChanged(); } }

        private string _MaPLNho;
        public string MaPLNho { get => _MaPLNho; set { _MaPLNho = value; OnPropertyChanged(); } }

        private string _MaPLLon;
        public string MaPLLon { get => _MaPLLon; set { _MaPLLon = value; OnPropertyChanged(); } }

        private string _MaTim;
        public string MaTim { get => _MaTim; set { _MaTim = value; OnPropertyChanged(); } }

        private string _TimKiem;
        public string TimKiem { get => _TimKiem; set { _TimKiem = value; OnPropertyChanged(); } }

        private int? _BOMNLPage;
        public int? BOMNLPage { get => _BOMNLPage; set { _BOMNLPage = value; OnPropertyChanged(); } }


        private string _MaHang;
        public string MaHang { get => _MaHang; set { _MaHang = value; OnPropertyChanged(); } }
        
        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }
        
        private string _TenTiengTrung;
        public string TenTiengTrung { get => _TenTiengTrung; set { _TenTiengTrung = value; OnPropertyChanged(); } }
        
        private string _ChatLieu;
        public string ChatLieu { get => _ChatLieu; set { _ChatLieu = value; OnPropertyChanged(); } }
        
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


        private string _MaHang2;
        public string MaHang2 { get => _MaHang2; set { _MaHang2 = value; OnPropertyChanged(); } }

        private string _DisplayName2;
        public string DisplayName2 { get => _DisplayName2; set { _DisplayName2 = value; OnPropertyChanged(); } }

        private string _TenTiengTrung2;
        public string TenTiengTrung2 { get => _TenTiengTrung2; set { _TenTiengTrung2 = value; OnPropertyChanged(); } }

        private string _ChatLieu2;
        public string ChatLieu2 { get => _ChatLieu2; set { _ChatLieu2 = value; OnPropertyChanged(); } }

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



        private string _MaHang3;
        public string MaHang3 { get => _MaHang3; set { _MaHang3 = value; OnPropertyChanged(); } }

        private string _DisplayName3;
        public string DisplayName3 { get => _DisplayName3; set { _DisplayName3 = value; OnPropertyChanged(); } }

        private string _TenTiengTrung3;
        public string TenTiengTrung3 { get => _TenTiengTrung3; set { _TenTiengTrung3 = value; OnPropertyChanged(); } }

        private string _ChatLieu3;
        public string ChatLieu3 { get => _ChatLieu3; set { _ChatLieu3 = value; OnPropertyChanged(); } }

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

        public BomNLInfoWindows bomNLInfoWindows;

        bool editdone = false;


        public ICommand TimNLcommand { get; set; }
        public ICommand ThemNLcommand { get; set; }
        public ICommand SuaNLcommand { get; set; }
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

        public BOMNguyenLieuViewModel()
        {
            PLLonlist = new ObservableCollection<BOM_MaPLLonSx>(DataProvider.Ins.DB.BOM_MaPLLonSx);
            BOM_MaPLLonSx bOM_MaPLLonSx = new BOM_MaPLLonSx();
            bOM_MaPLLonSx.MaHang = "0000";
            bOM_MaPLLonSx.DisplayName = "<Tất cả>";
            PLLonlist.Insert(0, bOM_MaPLLonSx);
            MaPLLon = PLLonlist.First().DisplayName;

            PLNholist = new ObservableCollection<BOM_MaPLNhoSx>(DataProvider.Ins.DB.BOM_MaPLNhoSx);
            BOM_MaPLNhoSx bOM_MaPLNhoSx = new BOM_MaPLNhoSx();
            bOM_MaPLNhoSx.MaHang = "0000";
            bOM_MaPLNhoSx.DisplayName = "<Tất cả>";
            PLNholist.Insert(0, bOM_MaPLNhoSx);
            MaPLNho = PLNholist.First().DisplayName;

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

            BOMNLPage = 1;

            TimNLcommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BOMNLPage = 1;

                StackPanel stackPanel = new StackPanel();
                additem(stackPanel, 1);

                MainWindow win = Application.Current.MainWindow as MainWindow;

                win.UCMain.Children.Clear();
                win.UCMain.Children.Add(stackPanel);
            });

            ThemNLcommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BomNLAddWindows bomNLAddWindows = new BomNLAddWindows();
                bomNLAddWindows.ShowDialog();
            });
            SuaNLcommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BomNLEditWindows bomNLEditWindows = new BomNLEditWindows();
                bomNLEditWindows.ShowDialog();
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
                var infolist = DataProvider.Ins.DB.BOM_BomNl.Where(x => x.MaHang == MaHang).First();
                MaHang3 = infolist.MaHang;
                QuyCach3 = infolist.QuyCach;
                DisplayName3 = infolist.DisplayName;
                TenTiengTrung3 = infolist.TenTiengTrung;
                ChatLieu3 = infolist.ChatLieu;
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
                addNL();
            });
            EditCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                editNL();
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
        void addNL()
        {
            var bomnl = DataProvider.Ins.DB.BOM_BomNl;
            var check = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaHang == MaHang2);
            if(MaHang2==null || check.Count() > 0 || MaHang2.Length == 0)
            {
                MessageBox.Show("Mã hàng đã tồn tại hoặc trống!", "Thêm mã hàng lỗi!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                BOM_BomNl bOM_BomNl = new BOM_BomNl();
                bOM_BomNl.MaHang = MaHang2;
                bOM_BomNl.QuyCach = QuyCach2;
                bOM_BomNl.DisplayName = DisplayName2;
                bOM_BomNl.TenTiengTrung = TenTiengTrung2;
                bOM_BomNl.ChatLieu = ChatLieu2;
                bOM_BomNl.UnitERP = UnitERP2;
                bOM_BomNl.UnitSx = UnitSx2;
                bOM_BomNl.TyLeChuyenDoi = TyLeChuyenDoi2;
                bOM_BomNl.Version = Version2;
                bOM_BomNl.MaKeToanERP = MaKeToanERP2;
                bOM_BomNl.MaPLLonERP = MaPLLonERP2;
                bOM_BomNl.MaPLNhoERP = MaPLNhoERP2;
                bOM_BomNl.MaPL4ERP = MaPL4ERP2;
                bOM_BomNl.MaPLLonSx = MaPLLonSx2;
                bOM_BomNl.MaPLNhoSx = MaPLNhoSx2;
                bOM_BomNl.LinkImg = LinkImg;
                bOM_BomNl.IDImg = IDImg;
                bOM_BomNl.UserName = Properties.Settings.Default.UserName;

                DataProvider.Ins.DB.BOM_BomNl.Add(bOM_BomNl);
                DataProvider.Ins.DB.SaveChanges();
                MaHang2 = null;
                QuyCach2 = null;
                DisplayName2 = null;
                TenTiengTrung2 = null;
                ChatLieu2 = null;
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
            }
        }

        void editNL()
        {
            var bOM_BomNl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaHang == MaHang3).FirstOrDefault();            
            {
                bOM_BomNl.MaHang = MaHang3;
                bOM_BomNl.QuyCach = QuyCach3;
                bOM_BomNl.DisplayName = DisplayName3;
                bOM_BomNl.TenTiengTrung = TenTiengTrung3;
                bOM_BomNl.ChatLieu = ChatLieu3;
                bOM_BomNl.UnitERP = UnitERP3;
                bOM_BomNl.UnitSx = UnitSx3;
                bOM_BomNl.TyLeChuyenDoi = TyLeChuyenDoi3;
                bOM_BomNl.Version = Version3;
                bOM_BomNl.MaKeToanERP = MaKeToanERP3;
                bOM_BomNl.MaPLLonERP = MaPLLonERP3;
                bOM_BomNl.MaPLNhoERP = MaPLNhoERP3;
                bOM_BomNl.MaPL4ERP = MaPL4ERP3;
                bOM_BomNl.MaPLLonSx = MaPLLonSx3;
                bOM_BomNl.MaPLNhoSx = MaPLNhoSx3;
                bOM_BomNl.LinkImg = LinkImg3;
                bOM_BomNl.IDImg = IDImg3;
                bOM_BomNl.UserName = Properties.Settings.Default.UserName;
                DataProvider.Ins.DB.SaveChanges();
                MaHang = MaHang3;
                DisplayName = DisplayName3;
                ChatLieu = ChatLieu3;
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
                editdone = true;

            }
        }

        void additem(StackPanel stackPanel, int? BOMNLPage)
        {

            WrapPanel wrapPanel = new WrapPanel();

            string PLL = null;
            string PLN = null;

            IQueryable<BOM_BomNl> bomnl = DataProvider.Ins.DB.BOM_BomNl;


            if (MaPLLon == "<Tất cả>")
            {
                if (MaPLNho == "<Tất cả>")
                {
                    if (string.IsNullOrEmpty(TimKiem)) // pll tất cả, pln tất cả, tim kiem = tất cả
                    {
                        bomnl = DataProvider.Ins.DB.BOM_BomNl;
                    }
                    else // pll tất cả, pln tất cả, tim kiem # tất cả
                    {
                        switch (MaTim)
                        {
                            case "Mã Hàng":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaHang.Contains(TimKiem));
                                break;
                            case "Display Name":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.DisplayName.Contains(TimKiem));
                                break;
                            case "Tên tiếng trung":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.TenTiengTrung.Contains(TimKiem));
                                break;
                            case "Chất liệu":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.ChatLieu.Contains(TimKiem));
                                break;
                            case "Quy cách":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.QuyCach.Contains(TimKiem));
                                break;
                            case "Mã phân loại 1 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaKeToanERP.ToString().Contains(TimKiem));
                                break;
                            case "Mã phân loại 2 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLLonERP.ToString().Contains(TimKiem));
                                break;
                            case "Mã phân loại 3 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLNhoERP.ToString().Contains(TimKiem));
                                break;
                            case "Mã phân loại 4 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPL4ERP.ToString().Contains(TimKiem));
                                break;
                        }
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(TimKiem)) // pll tất cả, pln # tất cả, tim kiem = tất cả
                    {
                        PLN = DataProvider.Ins.DB.BOM_MaPLNhoSx.Where(x => x.DisplayName == MaPLNho).First().MaHang;
                        bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLNhoSx == PLN);
                    }
                    else // pll tất cả, pln # tất cả, tim kiem # tất cả
                    {
                        PLN = DataProvider.Ins.DB.BOM_MaPLNhoSx.Where(x => x.DisplayName == MaPLNho).First().MaHang;
                        switch (MaTim)
                        {
                            case "Mã Hàng":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaHang.Contains(TimKiem) && y.MaPLNhoSx == PLN);
                                break;
                            case "Display Name":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.DisplayName.Contains(TimKiem) && y.MaPLNhoSx == PLN);
                                break;
                            case "Tên tiếng trung":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.TenTiengTrung.Contains(TimKiem) && y.MaPLNhoSx == PLN);
                                break;
                            case "Chất liệu":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.ChatLieu.Contains(TimKiem) && y.MaPLNhoSx == PLN);
                                break;
                            case "Quy cách":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.QuyCach.Contains(TimKiem) && y.MaPLNhoSx == PLN);
                                break;
                            case "Mã phân loại 1 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaKeToanERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == PLN);
                                break;
                            case "Mã phân loại 2 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLLonERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == PLN);
                                break;
                            case "Mã phân loại 3 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLNhoERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == PLN);
                                break;
                            case "Mã phân loại 4 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPL4ERP.ToString().Contains(TimKiem) && y.MaPLNhoSx == PLN);
                                break;
                        }
                    }
                }
            }
            else
            {
                if (MaPLNho == "<Tất cả>")
                {
                    if (string.IsNullOrEmpty(TimKiem)) // pll # tất cả, pln tất cả, tim kiem = tất cả
                    {
                        PLL = DataProvider.Ins.DB.BOM_MaPLLonSx.Where(x => x.DisplayName == MaPLLon).First().MaHang;
                        bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLLonSx == PLL);
                    }
                    else // pll # tất cả, pln tất cả, tim kiem # tất cả
                    {
                        PLL = DataProvider.Ins.DB.BOM_MaPLLonSx.Where(x => x.DisplayName == MaPLLon).First().MaHang;
                        switch (MaTim)
                        {
                            case "Mã Hàng":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaHang.Contains(TimKiem) && y.MaPLLonSx == PLL);
                                break;
                            case "Display Name":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.DisplayName.Contains(TimKiem) && y.MaPLLonSx == PLL);
                                break;
                            case "Tên tiếng trung":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.TenTiengTrung.Contains(TimKiem) && y.MaPLLonSx == PLL);
                                break;
                            case "Chất liệu":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.ChatLieu.Contains(TimKiem) && y.MaPLLonSx == PLL);
                                break;
                            case "Quy cách":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.QuyCach.Contains(TimKiem) && y.MaPLLonSx == PLL);
                                break;
                            case "Mã phân loại 1 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaKeToanERP.ToString().Contains(TimKiem) && y.MaPLLonSx == PLL);
                                break;
                            case "Mã phân loại 2 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLLonERP.ToString().Contains(TimKiem) && y.MaPLLonSx == PLL);
                                break;
                            case "Mã phân loại 3 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLNhoERP.ToString().Contains(TimKiem) && y.MaPLLonSx == PLL);
                                break;
                            case "Mã phân loại 4 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPL4ERP.ToString().Contains(TimKiem) && y.MaPLLonSx == PLL);
                                break;
                        }
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(TimKiem)) // pll # tất cả, pln # tất cả, tim kiem = tất cả
                    {
                        PLN = DataProvider.Ins.DB.BOM_MaPLNhoSx.Where(x => x.DisplayName == MaPLNho).First().MaHang;
                        PLL = DataProvider.Ins.DB.BOM_MaPLLonSx.Where(x => x.DisplayName == MaPLLon).First().MaHang;
                        bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLLonSx == PLL && y.MaPLNhoSx == PLN);

                    }
                    else // pll # tất cả, pln # tất cả, tim kiem # tất cả
                    {
                        PLN = DataProvider.Ins.DB.BOM_MaPLNhoSx.Where(x => x.DisplayName == MaPLNho).First().MaHang;
                        PLL = DataProvider.Ins.DB.BOM_MaPLLonSx.Where(x => x.DisplayName == MaPLLon).First().MaHang;
                        switch (MaTim)
                        {
                            case "Mã Hàng":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaHang.Contains(TimKiem) && y.MaPLLonSx == PLL && y.MaPLNhoSx == PLN);
                                break;
                            case "Display Name":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.DisplayName.Contains(TimKiem) && y.MaPLLonSx == PLL && y.MaPLNhoSx == PLN);
                                break;
                            case "Tên tiếng trung":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.TenTiengTrung.Contains(TimKiem) && y.MaPLLonSx == PLL && y.MaPLNhoSx == PLN);
                                break;
                            case "Chất liệu":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.ChatLieu.Contains(TimKiem) && y.MaPLLonSx == PLL && y.MaPLNhoSx == PLN);
                                break;
                            case "Quy cách":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.QuyCach.Contains(TimKiem) && y.MaPLLonSx == PLL && y.MaPLNhoSx == PLN);
                                break;
                            case "Mã phân loại 1 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaKeToanERP.ToString().Contains(TimKiem) && y.MaPLLonSx == PLL && y.MaPLNhoSx == PLN);
                                break;
                            case "Mã phân loại 2 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLLonERP.ToString().Contains(TimKiem) && y.MaPLLonSx == PLL && y.MaPLNhoSx == PLN);
                                break;
                            case "Mã phân loại 3 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPLNhoERP.ToString().Contains(TimKiem) && y.MaPLLonSx == PLL && y.MaPLNhoSx == PLN);
                                break;
                            case "Mã phân loại 4 ERP":
                                bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(y => y.MaPL4ERP.ToString().Contains(TimKiem) && y.MaPLLonSx == PLL && y.MaPLNhoSx == PLN);
                                break;
                        }
                    }
                }
            }

            int itembom = 0;
            foreach (var item in bomnl)
            {
                itembom++;

                if ((itembom <= (BOMNLPage * 20)) && (itembom >= ((BOMNLPage * 20) - 19)))
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
                        ChatLieu = item.ChatLieu;
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

                        bomNLInfoWindows = new BomNLInfoWindows();
                        bomNLInfoWindows.Show();
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
                            bomNLInfoWindows.NLAvar.Children.Clear();
                            bomNLInfoWindows.NLAvar.Children.Add(packIcon);
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
                            bomNLInfoWindows.NLAvar.Children.Clear();
                            bomNLInfoWindows.NLAvar.Children.Add(imageBrush);
                        }


                    };


                    button.Content = stackPanel1;
                    wrapPanel.Children.Add(button);
                }
                else if (itembom > (BOMNLPage * 20))
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
            if (BOMNLPage <= 1) prebtn.IsEnabled = false; else prebtn.IsEnabled = true;
            stackPanel2.Children.Add(prebtn);

            TextBlock textBlock = new TextBlock();
            textBlock.Text = BOMNLPage.ToString() + "/" + ((bomnl.Count() / 20) + 1);
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
            if (BOMNLPage >= (bomnl.Count() / 20) + 1) nextbtn.IsEnabled = false; else nextbtn.IsEnabled = true;
            stackPanel2.Children.Add(nextbtn);

            stackPanel.Children.Add(stackPanel2);

        }

        void nextbtn_click(object sender, RoutedEventArgs e)
        {
            BOMNLPage++;
            StackPanel stackPanel = new StackPanel();
            additem(stackPanel, BOMNLPage);

            MainWindow win = Application.Current.MainWindow as MainWindow;

            win.UCMain.Children.Clear();
            win.UCMain.Children.Add(stackPanel);
        }

        void prebtn_click(object sender, RoutedEventArgs e)
        {
            BOMNLPage--;
            StackPanel stackPanel = new StackPanel();
            additem(stackPanel, BOMNLPage);

            MainWindow win = Application.Current.MainWindow as MainWindow;

            win.UCMain.Children.Clear();
            win.UCMain.Children.Add(stackPanel);
        }

        void showinfo(object sender, RoutedEventArgs e, string mahang)
        {
            bomNLInfoWindows.Show();
            var bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(x => x.MaHang==mahang).FirstOrDefault();

        }
    }
}
