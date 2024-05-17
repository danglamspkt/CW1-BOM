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

        //-------------------------Khai báo list hiển thị Bom nguyen liệu--------------------------------------------------
        private ObservableCollection<BOM_BomNl> _BOMNLlist;
        public ObservableCollection<BOM_BomNl> BOMNLlist { get => _BOMNLlist; set { _BOMNLlist = value; OnPropertyChanged(); } }

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

        public ICommand TimNLcommand { get; set; }
        public ICommand ThemNLcommand { get; set; }

        public BOMNguyenLieuViewModel() 
        {
            PLLonlist = new ObservableCollection<BOM_MaPLLonSx>(DataProvider.Ins.DB.BOM_MaPLLonSx);
            BOM_MaPLLonSx bOM_MaPLLonSx = new BOM_MaPLLonSx();
            bOM_MaPLLonSx.MaHang = "0000";
            bOM_MaPLLonSx.DisplayName = "<Tất cả>";
            PLLonlist.Insert(0,bOM_MaPLLonSx);
            MaPLLon = PLLonlist.First().DisplayName;

            PLNholist = new ObservableCollection<BOM_MaPLNhoSx>(DataProvider.Ins.DB.BOM_MaPLNhoSx);
            BOM_MaPLNhoSx bOM_MaPLNhoSx = new BOM_MaPLNhoSx();
            bOM_MaPLNhoSx.MaHang = "0000";
            bOM_MaPLNhoSx.DisplayName = "<Tất cả>";
            PLNholist.Insert(0,bOM_MaPLNhoSx);
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

            TimNLcommand = new RelayCommand<StackPanel>((p) => {return true; }, (p) =>
            {
                BOMNLlist = new ObservableCollection<BOM_BomNl>();                
                WrapPanel wrapPanel = new WrapPanel();
                additem(wrapPanel, BOMNLPage);

               

                p.Children.Clear();
                p.Children.Add(wrapPanel);
            });

            ThemNLcommand = new RelayCommand<WrapPanel>((p) => { return true; }, (p) =>
            {
                TextBlock textBlock = new TextBlock();
                textBlock.Text = "thêm nguyên liệu";
                p.Children.Clear();
                p.Children.Add(textBlock);
            });

        }
        void additem (WrapPanel wrapPanel, int? BOMNLPage)
        {
            var bomnl = DataProvider.Ins.DB.BOM_BomNl;
            int itembom = 0;
            foreach (var item in bomnl)
            {
                itembom++;

                if ((itembom <= (BOMNLPage * 20)) && (itembom >= ((BOMNLPage * 20) - 19)))
                {
                    StackPanel stackPanel = new StackPanel();
                    stackPanel.Width = 250;
                    stackPanel.Height = 250;
                    stackPanel.Margin = new Thickness(20);

                    if (item.LinkImg == null)
                    {
                        PackIcon packIcon = new PackIcon();
                        packIcon.Width = 150;
                        packIcon.Height = 150;
                        packIcon.HorizontalAlignment = HorizontalAlignment.Center;
                        packIcon.VerticalAlignment = VerticalAlignment.Center;
                        packIcon.Margin = new Thickness(10);
                        packIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.AccountCircle;
                        stackPanel.Children.Add(packIcon);
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
                        stackPanel.Children.Add(imageBrush);
                    }

                    TextBlock textBlock1 = new TextBlock();
                    textBlock1.Text = item.MaHang;
                    textBlock1.HorizontalAlignment = HorizontalAlignment.Center;
                    textBlock1.VerticalAlignment = VerticalAlignment.Center;
                    textBlock1.Margin = new Thickness(10);
                    stackPanel.Children.Add(textBlock1);

                    TextBlock textBlock2 = new TextBlock();
                    textBlock2.Text = item.QuyCach;
                    textBlock2.HorizontalAlignment = HorizontalAlignment.Center;
                    textBlock2.VerticalAlignment = VerticalAlignment.Center;
                    textBlock2.Margin = new Thickness(10);
                    stackPanel.Children.Add(textBlock2);

                    wrapPanel.Children.Add(stackPanel);
                }
                else if (itembom > (BOMNLPage * 20))
                {
                    break;
                }

            }
        }
    }
}
