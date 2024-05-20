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


        public ICommand TimNLcommand { get; set; }
        public ICommand ThemNLcommand { get; set; }

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

            TimNLcommand = new RelayCommand<StackPanel>((p) => { return true; }, (p) =>
            {
                BOMNLPage = 1;

                StackPanel stackPanel = new StackPanel();
                additem(stackPanel, 1);

                MainWindow win = Application.Current.MainWindow as MainWindow;

                win.UCMain.Children.Clear();
                win.UCMain.Children.Add(stackPanel);
            });

            ThemNLcommand = new RelayCommand<WrapPanel>((p) => { return true; }, (p) =>
            {
                BomNLAddWindows bomNLAddWindows = new BomNLAddWindows();
                bomNLAddWindows.Show();
            });

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
                        imageBrush.Stretch = Stretch.UniformToFill;
                        imageBrush.Width = 150;
                        imageBrush.Height = 150;
                        imageBrush.Margin = new Thickness(10);
                        string uri = item.LinkImg;
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
                        BomNLInfoWindows bomNLInfoWindows = new BomNLInfoWindows();
                        bomNLInfoWindows.Show();
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
                            imageBrush.Stretch = Stretch.UniformToFill;
                            imageBrush.Width = 300;
                            imageBrush.Height = 300;
                            imageBrush.Margin = new Thickness(10);
                            imageBrush.HorizontalAlignment = HorizontalAlignment.Center;
                            imageBrush.VerticalAlignment = VerticalAlignment.Center;
                            string uri = item.LinkImg;
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
            BomNLInfoWindows bomNLInfoWindows = new BomNLInfoWindows();
            bomNLInfoWindows.Show();
            var bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(x => x.MaHang==mahang).FirstOrDefault();

        }
    }
}
