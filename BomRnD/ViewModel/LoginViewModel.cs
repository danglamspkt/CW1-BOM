using BomRnD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using System.Collections.ObjectModel;

namespace BomRnD.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {

        public bool IsLogin { get; set; }

        private string _Username;
        public string Username { get => _Username; set { _Username = value; OnPropertyChanged(); } }

        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }


        private bool _checkbox;
        public bool checkbox { get => _checkbox; set { _checkbox = value; OnPropertyChanged(); } }

        private Uri _BGSource;
        public Uri BGSource { get => _BGSource; set { _BGSource = value; OnPropertyChanged(); } }

        private ObservableCollection<SysLang> _datalanglist;
        public ObservableCollection<SysLang> datalanglist { get => _datalanglist; set { _datalanglist = value; OnPropertyChanged(); } }

        private string _LOG0001;
        public string LOG0001 { get => _LOG0001; set { _LOG0001 = value; OnPropertyChanged(); } }

        private string _LOG0002;
        public string LOG0002 { get => _LOG0002; set { _LOG0002 = value; OnPropertyChanged(); } }

        private string _LOG0003;
        public string LOG0003 { get => _LOG0003; set { _LOG0003 = value; OnPropertyChanged(); } }

        private string _LOG0004;
        public string LOG0004 { get => _LOG0004; set { _LOG0004 = value; OnPropertyChanged(); } }

        private string _LOG0005;
        public string LOG0005 { get => _LOG0005; set { _LOG0005 = value; OnPropertyChanged(); } }

        private string _LOG0006;
        public string LOG0006 { get => _LOG0006; set { _LOG0006 = value; OnPropertyChanged(); } }

        private string _LOG0007;
        public string LOG0007 { get => _LOG0007; set { _LOG0007 = value; OnPropertyChanged(); } }


        private string _SelectedItem;
        public string SelectedItem
        {
            get => _SelectedItem; set
            {
                _SelectedItem = value; OnPropertyChanged(); if (_SelectedItem != null)
                {
                    string str2 = "English";

                    bool m2 = SelectedItem.Contains(str2);
                    
                    if (m2)
                    {
                        datalanglist = new ObservableCollection<SysLang>();
                        var data = DataProvider.Ins.DB.Dev_Lang.Where(y => y.Id.Contains("LOG"));
                        foreach (var item in data)
                        {
                            SysLang sysLang = new SysLang();
                            sysLang.ID = item.Id;
                            sysLang.data = item.Eng;
                            datalanglist.Add(sysLang);
                        }
                        BomRnD.Properties.Settings.Default.Lang = "English";
                    }
                    else
                    {
                        datalanglist = new ObservableCollection<SysLang>();
                        var data = DataProvider.Ins.DB.Dev_Lang.Where(y => y.Id.Contains("LOG"));
                        foreach (var item in data)
                        {
                            SysLang sysLang = new SysLang();
                            sysLang.ID = item.Id;
                            sysLang.data = item.Viet;
                            datalanglist.Add(sysLang);
                        }
                        BomRnD.Properties.Settings.Default.Lang = "Tiếng Việt";
                    }
                }
            }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand langchanged { get; set; }


        // mọi thứ xử lý sẽ nằm trong này
        public LoginViewModel()
        {
            string uri = "https://drive.google.com/uc?id=" + DataProvider.Ins.DB.BOM_Image.Where(x => x.Id == 1).First().IDImage;
            BGSource = new Uri(uri);
            IsLogin = false;
            Password = "";
            Username = BomRnD.Properties.Settings.Default.UserName;
            checkbox = BomRnD.Properties.Settings.Default.check;
            BomRnD.Properties.Settings.Default.account = null;
            datalanglist = new ObservableCollection<SysLang>();
            var data = DataProvider.Ins.DB.Dev_Lang;
            foreach (var item in data)
            {
                SysLang sysLang = new SysLang();
                sysLang.ID = item.Id;
                sysLang.data = item.Viet;
                datalanglist.Add(sysLang);
            }
            langdata();
            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {

                Login(p);
            }
            );            
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) =>
            {
                Password = p.Password;
            });
            langchanged = new RelayCommand<ComboBox>((p) => { return true; }, (p) =>
            {
                langdata();
            });


        }

        void Login(Window p)
        {
            if (p == null)
                return;
            string passEncode = MD5Hash(Base64Encode(Password));

            var account = DataProvider.Ins.DB.Users.Where(y => y.UserName == Username && y.Password == passEncode).Count();
            if (account > 0)
            {
                IsLogin = true;
                if (checkbox)
                {
                    BomRnD.Properties.Settings.Default.UserName = Username;
                    BomRnD.Properties.Settings.Default.check = true;
                    BomRnD.Properties.Settings.Default.UserLevel = DataProvider.Ins.DB.Users.Where(x => x.UserName == Username).First().IdRole;
                    BomRnD.Properties.Settings.Default.account = Username;
                    BomRnD.Properties.Settings.Default.Save();

                }
                else
                {
                    BomRnD.Properties.Settings.Default.UserName = null;
                    BomRnD.Properties.Settings.Default.check = false;
                    BomRnD.Properties.Settings.Default.UserLevel = DataProvider.Ins.DB.Users.Where(x => x.UserName == Username).First().IdRole;
                    BomRnD.Properties.Settings.Default.account = Username;
                    BomRnD.Properties.Settings.Default.Save();
                }
                p.Close();

            }
            else
            {
                IsLogin = false;
                MessageBox.Show(LOG0007);
            }            
        }

        void langdata()
        {
            LOG0001 = datalanglist.Where(y => y.ID == "LOG0001").First().data;
            LOG0002 = datalanglist.Where(y => y.ID == "LOG0002").First().data;
            LOG0003 = datalanglist.Where(y => y.ID == "LOG0003").First().data;
            LOG0004 = datalanglist.Where(y => y.ID == "LOG0004").First().data;
            LOG0005 = datalanglist.Where(y => y.ID == "LOG0005").First().data;
            LOG0006 = datalanglist.Where(y => y.ID == "LOG0006").First().data;
            LOG0007 = datalanglist.Where(y => y.ID == "LOG0007").First().data;

        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }



        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
