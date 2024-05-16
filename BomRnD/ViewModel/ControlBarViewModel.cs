using BomRnD.Model;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BomRnD.ViewModel
{
    public class ControlBarViewModel : BaseViewModel
    {
        private ObservableCollection<SysLang> _datalanglist;
        public ObservableCollection<SysLang> datalanglist { get => _datalanglist; set { _datalanglist = value; OnPropertyChanged(); } }

        private string _CTB0001;
        public string CTB0001 { get => _CTB0001; set { _CTB0001 = value; OnPropertyChanged(); } }

        #region commands
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MaximizeWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MouseMoveWindowCommand { get; set; }
        #endregion

        public ControlBarViewModel()
        {
            
            CloseWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                langdata();
                if (w != null)
                {
                    var check = MessageBox.Show(CTB0001, "Quit app", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (check == MessageBoxResult.Yes) w.Close();
                }
            }
            );
            MaximizeWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    if (w.WindowState != WindowState.Maximized)
                        w.WindowState = WindowState.Maximized;
                    else
                        w.WindowState = WindowState.Normal;
                }
            }
            );
            MinimizeWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    if (w.WindowState != WindowState.Minimized)
                        w.WindowState = WindowState.Minimized;
                    else
                        w.WindowState = WindowState.Maximized;
                }
            }
            );
            MouseMoveWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    w.DragMove();
                }
            }
           );
        }

        void langdata()
        {
            
            if (BomRnD.Properties.Settings.Default.Lang == "English")
            {
                datalanglist = new ObservableCollection<SysLang>();
                var data = DataProvider.Ins.DB.Dev_Lang.Where(y => y.Id.Contains("CTB"));
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
                var data = DataProvider.Ins.DB.Dev_Lang.Where(y => y.Id.Contains("CTB"));
                foreach (var item in data)
                {
                    SysLang sysLang = new SysLang();
                    sysLang.ID = item.Id;
                    sysLang.data = item.Viet;
                    datalanglist.Add(sysLang);
                }                
            }
            CTB0001 = datalanglist.Where(y => y.ID == "CTB0001").First().data;

        }

        FrameworkElement GetWindowParent(UserControl p)
        {
            FrameworkElement parent = p;

            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;

            }

            return parent;
        }

    }
}