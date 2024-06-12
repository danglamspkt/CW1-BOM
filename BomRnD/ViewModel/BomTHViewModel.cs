using BomRnD.Model;
using DevExpress.DashboardWeb;
using DevExpress.Xpf.Data;
using DevExpress.Xpf.Editors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BomRnD.ViewModel
{
    public class BomTHViewModel : BaseViewModel
    {
        private ObservableCollection<BOM_BomTH> _MaTPList;
        public ObservableCollection<BOM_BomTH> MaTPList { get => _MaTPList; set { _MaTPList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomTH> _MaTPList2;
        public ObservableCollection<BOM_BomTH> MaTPList2 { get => _MaTPList2; set { _MaTPList2 = value; OnPropertyChanged(); } }

        private ObservableCollection<BomTHModel> _BomTHList;
        public ObservableCollection<BomTHModel> BomTHList { get => _BomTHList; set { _BomTHList = value; OnPropertyChanged(); } }

        private string _MaTp;
        public string MaTp { get => _MaTp; set { _MaTp = value; OnPropertyChanged(); } }

        private string _ThiTruong;
        public string ThiTruong { get => _ThiTruong; set { _ThiTruong = value; OnPropertyChanged(); } }

        private BOM_BomTH _SelectedTPList;
        public BOM_BomTH SelectedTPList
        {
            get => _SelectedTPList; set
            {
                _SelectedTPList = value; OnPropertyChanged(); if (SelectedTPList != null)
                {
                    BomTHList = new ObservableCollection<BomTHModel>();

                    var lktp = DataProvider.Ins.DB.BOM_BomTH.Where(x => x.MaTp == SelectedTPList.MaTp && x.ThiTruong == SelectedTPList.ThiTruong);

                    //lktp.OrderBy(x => new { x.MaTp, x.ThiTruong });
                    foreach (var item in lktp)
                    {
                        BomTHModel model = new BomTHModel();

                        var bomlk1 = DataProvider.Ins.DB.BOM_BomBtp.Where(p => p.MaHang == item.MaBtp1).FirstOrDefault();
                        var bomlk2 = DataProvider.Ins.DB.BOM_BomBtp.Where(p => p.MaHang == item.MaBtp2).FirstOrDefault();
                        var bomlk3 = DataProvider.Ins.DB.BOM_BomBtp.Where(p => p.MaHang == item.MaBtp3).FirstOrDefault();
                        var bomnl = DataProvider.Ins.DB.BOM_BomNl.Where(p => p.MaHang == item.MaMuaHang).FirstOrDefault();

                        model.NGC = bomlk1.NGC;
                        model.TenTiengTrung = bomlk1.TenTiengTrung;
                        model.DisplayName = bomlk1.DisplayName;
                        model.MaBanVe1 = bomlk1.MaBanVe;
                        model.MaBanVe2 = bomlk1.MaBanVe2;
                        model.MaBtpTW1 = item.MaBtp1;
                        model.MaBtpTW2 = item.MaBtp2;
                        model.MaBtpTW3 = item.MaBtp3;
                        model.MaBtpVN = bomlk1.MaBTPVN;
                        model.MaMuaHang = item.MaMuaHang;
                        model.TiLeNlBtp = item.TiLeNlBtp;
                        if (bomnl.QuyCach != null) model.QuyCach = bomnl.QuyCach; else model.QuyCach = bomlk1.QuyCach;
                        model.ChatLieu = bomnl.ChatLieu;
                        model.T = bomlk1.T;
                        model.W = bomlk1.W;
                        model.L = bomlk1.L;
                        model.HeSo = item.HeSo;

                        BomTHList.Add(model);
                    }
                }
            }
        }

        public ICommand valuechangecommand { get; set; }

        public BomTHViewModel()
        {
            MaTPList = new ObservableCollection<BOM_BomTH>(DataProvider.Ins.DB.BOM_BomTH.GroupBy(x => new { x.MaTp, x.ThiTruong}).Select(x => x.FirstOrDefault()));
            MaTPList2 = MaTPList;
            MaTp = "";
            ThiTruong = "";

            valuechangecommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                var a = MaTPList2.Where(x => x.MaTp.Contains(MaTp) && x.ThiTruong.Contains(ThiTruong));
                MaTPList = new ObservableCollection<BOM_BomTH>(a);
            });
        }

    }
}
