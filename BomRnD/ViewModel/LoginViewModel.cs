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


        public ICommand LoginCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand guestLoginCommand { get; set; }


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
            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {

                Login(p);
            }
            );
            guestLoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                var check = MessageBox.Show("Bạn muốn đăng nhập dưới dạng khách?", "Guest Login", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (check == MessageBoxResult.Yes) { Username = "guest"; Password = "guest"; Login(p); } else { }
            }
            );
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) =>
            {
                Password = p.Password;
            }
           );

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
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }

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
