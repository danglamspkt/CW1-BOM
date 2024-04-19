using BomRnD.Model;
using BomRnD.UserControlBomKhac;
using BomRnD.UserControlBomLK;
using BomRnD.UserControlBomNL;
using BomRnD.UserControlBomTH;
using BomRnD.UserControlHome;
using BomRnD.UserControlSetting;
using DevExpress.Mvvm.Native;
using MahApps.Metro.Controls;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
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
                            uc = new HomeMainUC();
                            break;
                        case 1:
                            uc = new BomTHMainUC();
                            break;
                        case 2:
                            uc = new BomNLMainUC();
                            break;
                        case 3:
                            uc = new BomLKMainUC();
                            break;
                        case 4:
                            uc = new BomKhacMainUC();
                            break;
                        case 5:
                            uc = new SettingMainUC();
                            break;
                    }                    
                    if (win.UCMain != null)
                    {
                        win.UCMain.Children.Clear();
                        win.UCMain.Children.Add(uc);
                    } 
                }
            }
        }


        public MainViewModel()
        {
            txbTitle = "Phần mềm quản lý sản xuất CW3";


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

            Thoat = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                var check = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Quit app", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (check == MessageBoxResult.Yes) { Application.Current.Shutdown(); } else { }
            });

        }

    }
}
