using BomRnD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BomRnD.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded { get; set; }
        public ICommand LoadedWindowCommand { get; set; }



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

        private int _Userlevel;
        public int Userlevel { get => _Userlevel; set { _Userlevel = value; OnPropertyChanged(); } }


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
                }
                else
                {
                    p.Close();
                }
                if (leftstace == false) menuchecked = false;
            });
        }
           
    }
}
