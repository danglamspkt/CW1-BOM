using BomRnD.Model;
using BomRnD.UserControlBomLK;
using BomRnD.UserControlBomNL;
using BomRnD.UserControlBomTH;
using BomRnD.UserControlBomTp;
using BomRnD.UserControlHome;
using BomRnD.UserControlSetting;
using DevExpress.Mvvm.Native;
using MahApps.Metro.Controls;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BomRnD.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded { get; set; }
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand reloginCommand { get; set; }
        public ICommand Thoat { get; set; }


        private Grid _UCMain;
        public Grid UCMain { get => _UCMain; set { _UCMain = value; OnPropertyChanged(); } }

        public UserControl uc { get; set; }
        public UserControl ucmainmain { get; set; }
        public UserControl uctitle { get; set; }
        public UserControl uccontrol { get; set; }

        private string _txbTitle;
        public string txbTitle { get => _txbTitle; set { _txbTitle = value; OnPropertyChanged(); } }

        private bool _menuchecked;
        public bool menuchecked { get => _menuchecked; set { _menuchecked = value; OnPropertyChanged(); } }

        private bool _leftstace;
        public bool leftstace { get => _leftstace; set { _leftstace = value; OnPropertyChanged(); } }

        private string _Userlogin;
        public string Userlogin { get => _Userlogin; set { _Userlogin = value; OnPropertyChanged(); } }

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _ChucVu;
        public string ChucVu { get => _ChucVu; set { _ChucVu = value; OnPropertyChanged(); } }

        private int _Userlevel;
        public int Userlevel { get => _Userlevel; set { _Userlevel = value; OnPropertyChanged(); } }

        private int _SelectedIndex;
        public int SelectedIndex { get => _SelectedIndex; set { _SelectedIndex = value; OnPropertyChanged(); } }


        private ObservableCollection<SysLang> _datalanglist;
        public ObservableCollection<SysLang> datalanglist { get => _datalanglist; set { _datalanglist = value; OnPropertyChanged(); } }

        private string _MNP0001;
        public string MNP0001 { get => _MNP0001; set { _MNP0001 = value; OnPropertyChanged(); } }

        private string _MNP0002;
        public string MNP0002 { get => _MNP0002; set { _MNP0002 = value; OnPropertyChanged(); } }

        private string _MNP0003;
        public string MNP0003 { get => _MNP0003; set { _MNP0003 = value; OnPropertyChanged(); } }

        private string _MNP0004;
        public string MNP0004 { get => _MNP0004; set { _MNP0004 = value; OnPropertyChanged(); } }

        private string _MNP0005;
        public string MNP0005 { get => _MNP0005; set { _MNP0005 = value; OnPropertyChanged(); } }

        private string _MNP0006;
        public string MNP0006 { get => _MNP0006; set { _MNP0006 = value; OnPropertyChanged(); } }

        private string _MNP0007;
        public string MNP0007 { get => _MNP0007; set { _MNP0007 = value; OnPropertyChanged(); } }

        private string _MNP0008;
        public string MNP0008 { get => _MNP0008; set { _MNP0008 = value; OnPropertyChanged(); } }



        private ListBoxItem _SelectedItem;
        public ListBoxItem SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged(); if (_SelectedItem != null)
                {
                    MainWindow win = Application.Current.MainWindow as MainWindow;
                    switch (SelectedIndex)
                    {
                        case 0:
                            ucmainmain = new UserControl();
                            uc = new HomeMainUC();
                            uctitle = new UserControl();
                            uccontrol = new UserControl();
                            break;
                        case 1:
                            ucmainmain = new BomTHMainUC();
                            uc = new UserControl();
                            uctitle = new BomTHMainTitleUC();
                            uccontrol = new UserControl();
                            break;
                        case 2:
                            ucmainmain = new UserControl();
                            uc = new BomNLMainUC();
                            uctitle = new BomNLMainTItleUC();
                            uccontrol = new BomNLMainControlUC();
                            break;
                        case 3:
                            ucmainmain = new UserControl();
                            uc = new BomLKMainUC();
                            uctitle = new BomLKMainTitleUC();
                            uccontrol = new BomLKMainControlUC();
                            break;
                        case 4:
                            ucmainmain = new UserControl();
                            uc = new BomTPMainUC();
                            uctitle = new BomTPMainTitleUC();
                            uccontrol = new BomTPMainControlUC();
                            break;
                        case 5:
                            ucmainmain = new UserControl();
                            uc = new SettingMainUC();
                            uctitle = new UserControl();
                            uccontrol = new UserControl();
                            break;
                    }
                    if (win.UCMain != null)
                    {
                        win.UCmainmain.Children.Clear();
                        win.UCmainmain.Children.Add(ucmainmain);
                        win.UCMain.Children.Clear();
                        win.UCMain.Children.Add(uc);
                        win.UCTilte.Children.Clear();
                        win.UCTilte.Children.Add(uctitle);
                        win.UCControl.Children.Clear();
                        win.UCControl.Children.Add(uccontrol);

                    } 
                }
            }
        }


        public MainViewModel()
        {
            txbTitle = "Phần mềm quản lý sản xuất CW3";
            langdata();

            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                
                Isloaded = true;
                if (p == null)
                    return;

                p.Hide();
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();

                if (loginWindow.DataContext == null)
                    return;

                var loginVM = loginWindow.DataContext as LoginViewModel;

                if (loginVM.IsLogin)
                {
                    p.Show();
                    langdata();
                    uc = new HomeMainUC();
                    MainWindow win2 = Application.Current.MainWindow as MainWindow;
                    win2.UCMain.Children.Clear();
                    win2.UCMain.Children.Add(uc);
                    Userlogin = BomRnD.Properties.Settings.Default.account;
                    DisplayName = DataProvider.Ins.DB.Users.Where(x => x.UserName == Userlogin).First().DisplayName;
                    Userlevel = DataProvider.Ins.DB.Users.Where(x => x.UserName == Userlogin).First().IdRole;
                    ChucVu = DataProvider.Ins.DB.Users.Where(x => x.UserName == Userlogin).First().ChucVu;
                    if (DataProvider.Ins.DB.Users.Where(x => x.UserName == Userlogin).First().IDHinhAnh == null)
                    {
                        PackIcon packIcon = new PackIcon();
                        packIcon.Width = 64;
                        packIcon.Height = 64;
                        packIcon.HorizontalAlignment = HorizontalAlignment.Center;
                        packIcon.VerticalAlignment = VerticalAlignment.Center;
                        packIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.AccountCircle;
                        MainWindow win = Application.Current.MainWindow as MainWindow;
                        win.ACImg.Children.Clear();
                        win.ACImg.Children.Add(packIcon);
                    }
                    else
                    {
                        Image imageBrush = new Image();
                        imageBrush.Stretch = Stretch.UniformToFill;
                        imageBrush.Width = 64;
                        imageBrush.Height = 64;
                        string uri = "https://drive.google.com/uc?id=" + DataProvider.Ins.DB.Users.Where(x => x.UserName == Userlogin).First().IDHinhAnh;
                        imageBrush.Source = new BitmapImage(new Uri(uri));
                        MainWindow win = Application.Current.MainWindow as MainWindow;
                        win.ACImg.Children.Clear();
                        win.ACImg.Children.Add(imageBrush);
                    }
                }
                else
                {
                    p.Close();
                }
                if (leftstace == false) menuchecked = false;
            });

            reloginCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                Application.Current.Shutdown();
                System.Windows.Forms.Application.Restart();
            });
        }

        void langdata()
        {

            if (BomRnD.Properties.Settings.Default.Lang == "English")
            {
                datalanglist = new ObservableCollection<SysLang>();
                var data = DataProvider.Ins.DB.Dev_Lang.Where(y => y.Id.Contains("MNP"));
                foreach (var item in data)
                {
                    SysLang sysLang = new SysLang();
                    sysLang.ID = item.Id;
                    sysLang.data = item.Eng;
                    datalanglist.Add(sysLang);
                }
            }
            else
            {
                datalanglist = new ObservableCollection<SysLang>();
                var data = DataProvider.Ins.DB.Dev_Lang.Where(y => y.Id.Contains("MNP"));
                foreach (var item in data)
                {
                    SysLang sysLang = new SysLang();
                    sysLang.ID = item.Id;
                    sysLang.data = item.Viet;
                    datalanglist.Add(sysLang);
                }
            }
            MNP0001 = datalanglist.Where(y => y.ID == "MNP0001").First().data;
            MNP0002 = datalanglist.Where(y => y.ID == "MNP0002").First().data;
            MNP0003 = datalanglist.Where(y => y.ID == "MNP0003").First().data;
            MNP0004 = datalanglist.Where(y => y.ID == "MNP0004").First().data;
            MNP0005 = datalanglist.Where(y => y.ID == "MNP0005").First().data;
            MNP0006 = datalanglist.Where(y => y.ID == "MNP0006").First().data;
            MNP0007 = datalanglist.Where(y => y.ID == "MNP0007").First().data;
            MNP0008 = datalanglist.Where(y => y.ID == "MNP0008").First().data;

        }

    }
}
