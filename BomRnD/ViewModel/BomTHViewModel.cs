using BomRnD.Model;
using BomRnD.UserControlBomTH;
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

        private ObservableCollection<BOM_BomTH> _BomTHList2;
        public ObservableCollection<BOM_BomTH> BomTHList2 { get => _BomTHList2; set { _BomTHList2 = value; OnPropertyChanged(); } }



        private ObservableCollection<BOM_BomTp> _ThanhPhamAddList;
        public ObservableCollection<BOM_BomTp> ThanhPhamAddList { get => _ThanhPhamAddList; set { _ThanhPhamAddList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomTp> _ThanhPhamAddListFa;
        public ObservableCollection<BOM_BomTp> ThanhPhamAddListFa { get => _ThanhPhamAddListFa; set { _ThanhPhamAddListFa = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP1AddList;
        public ObservableCollection<BOM_BomBtp> BTP1AddList { get => _BTP1AddList; set { _BTP1AddList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP1AddListFa;
        public ObservableCollection<BOM_BomBtp> BTP1AddListFa { get => _BTP1AddListFa; set { _BTP1AddListFa = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP2AddList;
        public ObservableCollection<BOM_BomBtp> BTP2AddList { get => _BTP2AddList; set { _BTP2AddList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP2AddListFa;
        public ObservableCollection<BOM_BomBtp> BTP2AddListFa { get => _BTP2AddListFa; set { _BTP2AddListFa = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP3AddList;
        public ObservableCollection<BOM_BomBtp> BTP3AddList { get => _BTP3AddList; set { _BTP3AddList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP3AddListFa;
        public ObservableCollection<BOM_BomBtp> BTP3AddListFa { get => _BTP3AddListFa; set { _BTP3AddListFa = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomNl> _MaMuaHangAddList;
        public ObservableCollection<BOM_BomNl> MaMuaHangAddList { get => _MaMuaHangAddList; set { _MaMuaHangAddList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomNl> _MaMuaHangAddListFa;
        public ObservableCollection<BOM_BomNl> MaMuaHangAddListFa { get => _MaMuaHangAddListFa; set { _MaMuaHangAddListFa = value; OnPropertyChanged(); } }




        private ObservableCollection<BOM_BomTp> _ThanhPhamEditList;
        public ObservableCollection<BOM_BomTp> ThanhPhamEditList { get => _ThanhPhamEditList; set { _ThanhPhamEditList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomTp> _ThanhPhamEditListFa;
        public ObservableCollection<BOM_BomTp> ThanhPhamEditListFa { get => _ThanhPhamEditListFa; set { _ThanhPhamEditListFa = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP1EditList;
        public ObservableCollection<BOM_BomBtp> BTP1EditList { get => _BTP1EditList; set { _BTP1EditList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP1EditListFa;
        public ObservableCollection<BOM_BomBtp> BTP1EditListFa { get => _BTP1EditListFa; set { _BTP1EditListFa = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP2EditList;
        public ObservableCollection<BOM_BomBtp> BTP2EditList { get => _BTP2EditList; set { _BTP2EditList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP2EditListFa;
        public ObservableCollection<BOM_BomBtp> BTP2EditListFa { get => _BTP2EditListFa; set { _BTP2EditListFa = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP3EditList;
        public ObservableCollection<BOM_BomBtp> BTP3EditList { get => _BTP3EditList; set { _BTP3EditList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomBtp> _BTP3EditListFa;
        public ObservableCollection<BOM_BomBtp> BTP3EditListFa { get => _BTP3EditListFa; set { _BTP3EditListFa = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomNl> _MaMuaHangEditList;
        public ObservableCollection<BOM_BomNl> MaMuaHangEditList { get => _MaMuaHangEditList; set { _MaMuaHangEditList = value; OnPropertyChanged(); } }

        private ObservableCollection<BOM_BomNl> _MaMuaHangEditListFa;
        public ObservableCollection<BOM_BomNl> MaMuaHangEditListFa { get => _MaMuaHangEditListFa; set { _MaMuaHangEditListFa = value; OnPropertyChanged(); } }



        private int _Id2;
        public int Id2 { get => _Id2; set { _Id2 = value; OnPropertyChanged(); } }

        private string _MaTp2;
        public string MaTp2 { get => _MaTp2; set { _MaTp2 = value; OnPropertyChanged(); } }

        private string _MaBtp21;
        public string MaBtp21 { get => _MaBtp21; set { _MaBtp21 = value; OnPropertyChanged(); } }

        private string _MaBtp22;
        public string MaBtp22 { get => _MaBtp22; set { _MaBtp22 = value; OnPropertyChanged(); } }

        private string _MaBtp23;
        public string MaBtp23 { get => _MaBtp23; set { _MaBtp23 = value; OnPropertyChanged(); } }

        private string _MaMuaHang2;
        public string MaMuaHang2 { get => _MaMuaHang2; set { _MaMuaHang2 = value; OnPropertyChanged(); } }

        private Nullable<double> _TiLeNlBtp2;
        public Nullable<double> TiLeNlBtp2 { get => _TiLeNlBtp2; set { _TiLeNlBtp2 = value; OnPropertyChanged(); } }

        private Nullable<int> _HeSo2;
        public Nullable<int> HeSo2 { get => _HeSo2; set { _HeSo2 = value; OnPropertyChanged(); } }

        private string _GhiChu2;
        public string GhiChu2 { get => _GhiChu2; set { _GhiChu2 = value; OnPropertyChanged(); } }

        private string _ThiTruong2;
        public string ThiTruong2 { get => _ThiTruong2; set { _ThiTruong2 = value; OnPropertyChanged(); } }

        private string _MaTpEdit;
        public string MaTpEdit { get => _MaTpEdit; set { _MaTpEdit = value; OnPropertyChanged(); } }

        private string _MaTpEditSeach;
        public string MaTpEditSeach { get => _MaTpEditSeach; set { _MaTpEditSeach = value; OnPropertyChanged(); } }

        private string _MaBTP1Edit;
        public string MaBTP1Edit { get => _MaBTP1Edit; set { _MaBTP1Edit = value; OnPropertyChanged(); } }

        private string _MaBTP1EditSeach;
        public string MaBTP1EditSeach { get => _MaBTP1EditSeach; set { _MaBTP1EditSeach = value; OnPropertyChanged(); } }

        private string _MaBTP2Edit;
        public string MaBTP2Edit { get => _MaBTP2Edit; set { _MaBTP2Edit = value; OnPropertyChanged(); } }

        private string _MaBTP2EditSeach;
        public string MaBTP2EditSeach { get => _MaBTP2EditSeach; set { _MaBTP2EditSeach = value; OnPropertyChanged(); } }

        private string _MaBTP3Edit;
        public string MaBTP3Edit { get => _MaBTP3Edit; set { _MaBTP3Edit = value; OnPropertyChanged(); } }

        private string _MaBTP3EditSeach;
        public string MaBTP3EditSeach { get => _MaBTP3EditSeach; set { _MaBTP3EditSeach = value; OnPropertyChanged(); } }

        private string _MaMuaHangEdit;
        public string MaMuaHangEdit { get => _MaMuaHangEdit; set { _MaMuaHangEdit = value; OnPropertyChanged(); } }

        private string _MaMuaHangEditSeach;
        public string MaMuaHangEditSeach { get => _MaMuaHangEditSeach; set { _MaMuaHangEditSeach = value; OnPropertyChanged(); } }




        private int _Id3;
        public int Id3 { get => _Id3; set { _Id3 = value; OnPropertyChanged(); } }

        private string _MaTp3;
        public string MaTp3 { get => _MaTp3; set { _MaTp3 = value; OnPropertyChanged(); } }

        private string _MaBtp31;
        public string MaBtp31 { get => _MaBtp31; set { _MaBtp31 = value; OnPropertyChanged(); } }

        private string _MaBtp32;
        public string MaBtp32 { get => _MaBtp32; set { _MaBtp32 = value; OnPropertyChanged(); } }

        private string _MaBtp33;
        public string MaBtp33 { get => _MaBtp33; set { _MaBtp33 = value; OnPropertyChanged(); } }

        private string _MaMuaHang3;
        public string MaMuaHang3 { get => _MaMuaHang3; set { _MaMuaHang3 = value; OnPropertyChanged(); } }

        private Nullable<double> _TiLeNlBtp3;
        public Nullable<double> TiLeNlBtp3 { get => _TiLeNlBtp3; set { _TiLeNlBtp3 = value; OnPropertyChanged(); } }

        private Nullable<int> _HeSo3;
        public Nullable<int> HeSo3 { get => _HeSo3; set { _HeSo3 = value; OnPropertyChanged(); } }

        private string _GhiChu3;
        public string GhiChu3 { get => _GhiChu3; set { _GhiChu3 = value; OnPropertyChanged(); } }

        private string _ThiTruong3;
        public string ThiTruong3 { get => _ThiTruong3; set { _ThiTruong3 = value; OnPropertyChanged(); } }

        private string _MaTpAdd;
        public string MaTpAdd { get => _MaTpAdd; set { _MaTpAdd = value; OnPropertyChanged(); } }

        private string _MaTpAddSeach;
        public string MaTpAddSeach { get => _MaTpAddSeach; set { _MaTpAddSeach = value; OnPropertyChanged(); } }

        private string _MaBTP1Add;
        public string MaBTP1Add { get => _MaBTP1Add; set { _MaBTP1Add = value; OnPropertyChanged(); } }

        private string _MaBTP1AddSeach;
        public string MaBTP1AddSeach { get => _MaBTP1AddSeach; set { _MaBTP1AddSeach = value; OnPropertyChanged(); } }

        private string _MaBTP2Add;
        public string MaBTP2Add { get => _MaBTP2Add; set { _MaBTP2Add = value; OnPropertyChanged(); } }

        private string _MaBTP2AddSeach;
        public string MaBTP2AddSeach { get => _MaBTP2AddSeach; set { _MaBTP2AddSeach = value; OnPropertyChanged(); } }

        private string _MaBTP3Add;
        public string MaBTP3Add { get => _MaBTP3Add; set { _MaBTP3Add = value; OnPropertyChanged(); } }

        private string _MaBTP3AddSeach;
        public string MaBTP3AddSeach { get => _MaBTP3AddSeach; set { _MaBTP3AddSeach = value; OnPropertyChanged(); } }

        private string _MaMuaHangAdd;
        public string MaMuaHangAdd { get => _MaMuaHangAdd; set { _MaMuaHangAdd = value; OnPropertyChanged(); } }

        private string _MaMuaHangAddSeach;
        public string MaMuaHangAddSeach { get => _MaMuaHangAddSeach; set { _MaMuaHangAddSeach = value; OnPropertyChanged(); } }






        private string _test;
        public string test { get => _test; set { _test = value; OnPropertyChanged(); } }

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

                        if (bomlk1 != null) model.NGC = bomlk1.NGC;
                        if (bomlk1 != null) model.TenTiengTrung = bomlk1.TenTiengTrung;
                        if (bomlk1 != null) model.DisplayName = bomlk1.DisplayName;
                        if (bomlk1 != null) model.MaBanVe1 = bomlk1.MaBanVe;
                        if (bomlk1 != null) model.MaBanVe2 = bomlk1.MaBanVe2;
                        model.MaBtpTW1 = item.MaBtp1;
                        model.MaBtpTW2 = item.MaBtp2;
                        model.MaBtpTW3 = item.MaBtp3;
                        if (bomlk1 != null) model.MaBtpVN = bomlk1.MaBTPVN;
                        model.MaMuaHang = item.MaMuaHang;
                        model.TiLeNlBtp = item.TiLeNlBtp;
                        if (bomnl != null) if (bomnl.QuyCach != null) model.QuyCach = bomnl.QuyCach; else if (bomlk1 != null) model.QuyCach = bomlk1.QuyCach;
                        if (bomnl != null) model.ChatLieu = bomnl.ChatLieu;
                        if (bomlk1 != null) model.T = bomlk1.T;
                        if (bomlk1 != null) model.W = bomlk1.W;
                        if (bomlk1 != null) model.L = bomlk1.L;
                        model.HeSo = item.HeSo;
                        model.Id = item.Id;
                        model.GhiChu = item.GhiChu;

                        BomTHList.Add(model);
                    }
                }
            }
        }

        private BomTHModel _SelectedTPItem;
        public BomTHModel SelectedTPItem
        {
            get => _SelectedTPItem; set
            {
                _SelectedTPItem = value; OnPropertyChanged(); if (SelectedTPItem != null)
                {
                    Id2 = SelectedTPItem.Id;
                    var bomth = DataProvider.Ins.DB.BOM_BomTH.Where(b => b.Id == Id2).FirstOrDefault();
                    MaTp2 = bomth.MaTp;
                    MaBtp21 = bomth.MaBtp1;
                    MaBtp22 = bomth.MaBtp2;
                    MaBtp23 = bomth.MaBtp3;
                    ThiTruong2 = bomth.ThiTruong;
                    MaMuaHang2 = bomth.MaMuaHang;
                    TiLeNlBtp2 = bomth.TiLeNlBtp;
                    HeSo2 = bomth.HeSo;
                    GhiChu2 = bomth.GhiChu;
                }
            }
        }


        private BOM_BomTp _SelectedTPAddItem;
        public BOM_BomTp SelectedTPAddItem
        {
            get => _SelectedTPAddItem; set
            {
                _SelectedTPAddItem = value; OnPropertyChanged(); if (SelectedTPAddItem != null)
                {
                    MaTpAdd = SelectedTPAddItem.MaHang;
                }
            }
        }

        private BOM_BomBtp _SelectedBTP1AddItem;
        public BOM_BomBtp SelectedBTP1AddItem
        {
            get => _SelectedBTP1AddItem; set
            {
                _SelectedBTP1AddItem = value; OnPropertyChanged(); if (SelectedBTP1AddItem != null)
                {
                    MaBTP1Add = SelectedBTP1AddItem.MaHang;
                }
            }
        }

        private BOM_BomBtp _SelectedBTP2AddItem;
        public BOM_BomBtp SelectedBTP2AddItem
        {
            get => _SelectedBTP2AddItem; set
            {
                _SelectedBTP2AddItem = value; OnPropertyChanged(); if (SelectedBTP2AddItem != null)
                {
                    MaBTP2Add = SelectedBTP2AddItem.MaHang;
                }
            }
        }

        private BOM_BomBtp _SelectedBTP3AddItem;
        public BOM_BomBtp SelectedBTP3AddItem
        {
            get => _SelectedBTP3AddItem; set
            {
                _SelectedBTP3AddItem = value; OnPropertyChanged(); if (SelectedBTP3AddItem != null)
                {
                    MaBTP3Add = SelectedBTP3AddItem.MaHang;
                }
            }
        }

        private BOM_BomNl _SelectedMuaHangAddItem;
        public BOM_BomNl SelectedMuaHangAddItem
        {
            get => _SelectedMuaHangAddItem; set
            {
                _SelectedMuaHangAddItem = value; OnPropertyChanged(); if (SelectedMuaHangAddItem != null)
                {
                    MaMuaHangAdd = SelectedMuaHangAddItem.MaHang;
                }
            }
        }


        private BOM_BomTp _SelectedTPEditItem;
        public BOM_BomTp SelectedTPEditItem
        {
            get => _SelectedTPEditItem; set
            {
                _SelectedTPEditItem = value; OnPropertyChanged(); if (SelectedTPEditItem != null)
                {
                    MaTpEdit = SelectedTPEditItem.MaHang;
                }
            }
        }

        private BOM_BomBtp _SelectedBTP1EditItem;
        public BOM_BomBtp SelectedBTP1EditItem
        {
            get => _SelectedBTP1EditItem; set
            {
                _SelectedBTP1EditItem = value; OnPropertyChanged(); if (SelectedBTP1EditItem != null)
                {
                    MaBTP1Edit = SelectedBTP1EditItem.MaHang;
                }
            }
        }

        private BOM_BomBtp _SelectedBTP2EditItem;
        public BOM_BomBtp SelectedBTP2EditItem
        {
            get => _SelectedBTP2EditItem; set
            {
                _SelectedBTP2EditItem = value; OnPropertyChanged(); if (SelectedBTP2EditItem != null)
                {
                    MaBTP2Edit = SelectedBTP2EditItem.MaHang;
                }
            }
        }

        private BOM_BomBtp _SelectedBTP3EditItem;
        public BOM_BomBtp SelectedBTP3EditItem
        {
            get => _SelectedBTP3EditItem; set
            {
                _SelectedBTP3EditItem = value; OnPropertyChanged(); if (SelectedBTP3EditItem != null)
                {
                    MaBTP3Edit = SelectedBTP3EditItem.MaHang;
                }
            }
        }

        private BOM_BomNl _SelectedMuaHangEditItem;
        public BOM_BomNl SelectedMuaHangEditItem
        {
            get => _SelectedMuaHangEditItem; set
            {
                _SelectedMuaHangEditItem = value; OnPropertyChanged(); if (SelectedMuaHangEditItem != null)
                {
                    MaMuaHangEdit = SelectedMuaHangEditItem.MaHang;
                }
            }
        }


        public ICommand testbutton { get; set; }
        public ICommand valuechangecommand { get; set; }
        public ICommand UpdateTHCommand { get; set; }
        public ICommand LoadedaddCommand { get; set; }
        public ICommand LoadededitCommand { get; set; }


        public ICommand XoaTHCommand { get; set; }
        public ICommand ThemTHcommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand SuaTHcommand { get; set; }
        public ICommand EditCommand { get; set; }

        public ICommand LoadAddMaTpCommand { get; set; }
        public ICommand AddMaTpChangeCommand { get; set; }
        public ICommand AddMaTpApplyCommand { get; set; }
        public ICommand LoadAddMaBTP1Command { get; set; }
        public ICommand AddMaBTP1ChangeCommand { get; set; }
        public ICommand AddMaBTP1ApplyCommand { get; set; }
        public ICommand LoadAddMaBTP2Command { get; set; }
        public ICommand AddMaBTP2ChangeCommand { get; set; }
        public ICommand AddMaBTP2ApplyCommand { get; set; }
        public ICommand LoadAddMaBTP3Command { get; set; }
        public ICommand AddMaBTP3ChangeCommand { get; set; }
        public ICommand AddMaBTP3ApplyCommand { get; set; }
        public ICommand LoadAddMaMuaHangCommand { get; set; }
        public ICommand AddMaMuaHangChangeCommand { get; set; }
        public ICommand AddMaMuaHangApplyCommand { get; set; }

        public ICommand LoadEditMaTpCommand { get; set; }
        public ICommand EditMaTpChangeCommand { get; set; }
        public ICommand EditMaTpApplyCommand { get; set; }
        public ICommand LoadEditMaBTP1Command { get; set; }
        public ICommand EditMaBTP1ChangeCommand { get; set; }
        public ICommand EditMaBTP1ApplyCommand { get; set; }
        public ICommand LoadEditMaBTP2Command { get; set; }
        public ICommand EditMaBTP2ChangeCommand { get; set; }
        public ICommand EditMaBTP2ApplyCommand { get; set; }
        public ICommand LoadEditMaBTP3Command { get; set; }
        public ICommand EditMaBTP3ChangeCommand { get; set; }
        public ICommand EditMaBTP3ApplyCommand { get; set; }
        public ICommand LoadEditMaMuaHangCommand { get; set; }
        public ICommand EditMaMuaHangChangeCommand { get; set; }
        public ICommand EditMaMuaHangApplyCommand { get; set; }


        public BomTHAddWindows bomTHAddWindows;
        public BomTHAddMaTpWindows bomTHAddMaTpWindows;
        public BomTHAddMaBTP1Windows bomTHAddMaBTP1Windows;
        public BomTHAddMaBTP2Windows bomTHAddMaBTP2Windows;
        public BomTHAddMaBTP3Windows bomTHAddMaBTP3Windows;
        public BomTHAddMaMuaHangWindows bomTHAddMaMuaHangWindows;

        public BomTHEditWindows bomTHEditWindows;
        public BomTHEditMaTpWindows bomTHEditMaTpWindows;
        public BomTHEditMaBTP1Windows bomTHEditMaBTP1Windows;
        public BomTHEditMaBTP2Windows bomTHEditMaBTP2Windows;
        public BomTHEditMaBTP3Windows bomTHEditMaBTP3Windows;
        public BomTHEditMaMuaHangWindows bomTHEditMaMuaHangWindows;

        public BomTHViewModel()
        {
            MaTPList = new ObservableCollection<BOM_BomTH>(DataProvider.Ins.DB.BOM_BomTH.GroupBy(x => new { x.MaTp, x.ThiTruong}).Select(x => x.FirstOrDefault()));
            MaTPList2 = MaTPList;
            MaTp = "";
            ThiTruong = "";

            ThanhPhamEditListFa = new ObservableCollection<BOM_BomTp>(DataProvider.Ins.DB.BOM_BomTp);
            BTP1EditListFa = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
            BTP2EditListFa = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
            BTP3EditListFa = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
            MaMuaHangEditListFa = new ObservableCollection<BOM_BomNl>(DataProvider.Ins.DB.BOM_BomNl);

            testbutton = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                test = Id2.ToString();
            });
            valuechangecommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                var a = MaTPList2.Where(x => x.MaTp.Contains(MaTp) && x.ThiTruong.Contains(ThiTruong));
                MaTPList = new ObservableCollection<BOM_BomTH>(a);
            });
            UpdateTHCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                MaTPList = new ObservableCollection<BOM_BomTH>(DataProvider.Ins.DB.BOM_BomTH.GroupBy(x => new { x.MaTp, x.ThiTruong }).Select(x => x.FirstOrDefault()));
                MaTPList2 = MaTPList;
            });
            ThemTHcommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                bomTHAddWindows = new BomTHAddWindows();
                bomTHAddWindows.Show();
            });
            SuaTHcommand = new RelayCommand<object>((p) => { if (Id2 < 1) return false; return true; }, (p) =>
            {
                bomTHEditWindows = new BomTHEditWindows();
                bomTHEditWindows.Show();
            });
            XoaTHCommand = new RelayCommand<object>((p) => { if (Id2 < 1) return false; return true; }, (p) =>
            {
                if (Id2 < 1)  
                { 
                    MessageBox.Show("Bạn chưa chọn mã hàng"); 
                    return;
                }
                var check = MessageBox.Show("Bạn có chắc chắn muốn xoá mã hàng", "Delete Item", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (check == MessageBoxResult.Yes) 
                {
                    var del = DataProvider.Ins.DB.BOM_BomTH.Where(x=>x.Id==Id2).FirstOrDefault();
                    DataProvider.Ins.DB.BOM_BomTH.Remove(del);
                    DataProvider.Ins.DB.SaveChanges();
                    MaTPList = new ObservableCollection<BOM_BomTH>(DataProvider.Ins.DB.BOM_BomTH.GroupBy(x => new { x.MaTp, x.ThiTruong }).Select(x => x.FirstOrDefault()));
                    MaTPList2 = MaTPList;
                    BomTHList = new ObservableCollection<BomTHModel>();
                    Id2= 0;
                };
            });
            LoadedaddCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                ThanhPhamAddListFa = new ObservableCollection<BOM_BomTp>(DataProvider.Ins.DB.BOM_BomTp);
                BTP1AddListFa = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                BTP2AddListFa = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                BTP3AddListFa = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                MaMuaHangAddListFa = new ObservableCollection<BOM_BomNl>(DataProvider.Ins.DB.BOM_BomNl);
            });
            LoadededitCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                ThanhPhamEditListFa = new ObservableCollection<BOM_BomTp>(DataProvider.Ins.DB.BOM_BomTp);
                BTP1EditListFa = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                BTP2EditListFa = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                BTP3EditListFa = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                MaMuaHangEditListFa = new ObservableCollection<BOM_BomNl>(DataProvider.Ins.DB.BOM_BomNl);

            });

            AddCommand = new RelayCommand<object>((p) => 
            {
                if (string.IsNullOrEmpty(MaTp3)) return false ;
                return true;

            }, (p) =>
            {
                BOM_BomTH bOM_BomTH = new BOM_BomTH();
                bOM_BomTH.MaTp = MaTp3;
                bOM_BomTH.ThiTruong = ThiTruong3;
                bOM_BomTH.MaBtp1 = MaBtp31;
                bOM_BomTH.MaBtp2 = MaBtp32;
                bOM_BomTH.MaBtp3 = MaBtp33;
                bOM_BomTH.MaMuaHang = MaMuaHang3;
                bOM_BomTH.TiLeNlBtp = TiLeNlBtp3;
                bOM_BomTH.HeSo = HeSo3;
                bOM_BomTH.GhiChu = GhiChu3;

                DataProvider.Ins.DB.BOM_BomTH.Add(bOM_BomTH);
                DataProvider.Ins.DB.SaveChanges();

                MaTp3 = null;
                MaBtp31 = null;
                MaBtp32 = null;
                MaBtp33 = null;
                MaMuaHang3 = null;
                TiLeNlBtp3 = null;
                HeSo3 = null;
                GhiChu3 = null;
                ThiTruong3 = null;

                MaTPList = new ObservableCollection<BOM_BomTH>(DataProvider.Ins.DB.BOM_BomTH.GroupBy(x => new { x.MaTp, x.ThiTruong }).Select(x => x.FirstOrDefault()));
                MaTPList2 = MaTPList;

            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(MaTp3)) return false;
                return true;

            }, (p) =>
            {
                var bOM_BomTH = DataProvider.Ins.DB.BOM_BomTH.Where(x=>x.Id==Id2).SingleOrDefault();
                bOM_BomTH.MaTp = MaTp2;
                bOM_BomTH.ThiTruong = ThiTruong2;
                bOM_BomTH.MaBtp1 = MaBtp21;
                bOM_BomTH.MaBtp2 = MaBtp22;
                bOM_BomTH.MaBtp3 = MaBtp23;
                bOM_BomTH.MaMuaHang = MaMuaHang2;
                bOM_BomTH.TiLeNlBtp = TiLeNlBtp2;
                bOM_BomTH.HeSo = HeSo2;
                bOM_BomTH.GhiChu = GhiChu2;
                DataProvider.Ins.DB.SaveChanges();

                MaTPList = new ObservableCollection<BOM_BomTH>(DataProvider.Ins.DB.BOM_BomTH.GroupBy(x => new { x.MaTp, x.ThiTruong }).Select(x => x.FirstOrDefault()));
                MaTPList2 = MaTPList;

            });

            LoadAddMaTpCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                ThanhPhamAddList = new ObservableCollection<BOM_BomTp>(DataProvider.Ins.DB.BOM_BomTp);
                bomTHAddMaTpWindows = new BomTHAddMaTpWindows();
                bomTHAddMaTpWindows.Show();
            });
            AddMaTpChangeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                ThanhPhamAddList = new ObservableCollection<BOM_BomTp>(DataProvider.Ins.DB.BOM_BomTp.Where(x=>x.MaHang.Contains(MaTpAddSeach)));
            });
            AddMaTpApplyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaTp3 = MaTpAdd;
                bomTHAddMaTpWindows.Close();
            });

            LoadAddMaBTP1Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP1AddList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                bomTHAddMaBTP1Windows = new BomTHAddMaBTP1Windows();
                bomTHAddMaBTP1Windows.Show();
            });
            AddMaBTP1ChangeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP1AddList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp.Where(x => x.MaHang.Contains(MaBTP1AddSeach)));
            });
            AddMaBTP1ApplyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaBtp31 = MaBTP1Add;
                bomTHAddMaBTP1Windows.Close();
            });

            LoadAddMaBTP2Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP2AddList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                bomTHAddMaBTP2Windows = new BomTHAddMaBTP2Windows();
                bomTHAddMaBTP2Windows.Show();
            });
            AddMaBTP2ChangeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP2AddList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp.Where(x => x.MaHang.Contains(MaBTP2AddSeach)));
            });
            AddMaBTP2ApplyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaBtp32 = MaBTP2Add;
                bomTHAddMaBTP2Windows.Close();
            });

            LoadAddMaBTP3Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP3AddList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                bomTHAddMaBTP3Windows = new BomTHAddMaBTP3Windows();
                bomTHAddMaBTP3Windows.Show();
            });
            AddMaBTP3ChangeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP3AddList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp.Where(x => x.MaHang.Contains(MaBTP3AddSeach)));
            });
            AddMaBTP3ApplyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaBtp33 = MaBTP3Add;
                bomTHAddMaBTP3Windows.Close();
            });

            LoadAddMaMuaHangCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaMuaHangAddList = new ObservableCollection<BOM_BomNl>(DataProvider.Ins.DB.BOM_BomNl);
                bomTHAddMaMuaHangWindows = new BomTHAddMaMuaHangWindows();
                bomTHAddMaMuaHangWindows.Show();
            });
            AddMaMuaHangChangeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaMuaHangAddList = new ObservableCollection<BOM_BomNl>(DataProvider.Ins.DB.BOM_BomNl.Where(x => x.MaHang.Contains(MaMuaHangAddSeach)));
            });
            AddMaMuaHangApplyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaMuaHang3 = MaMuaHangAdd;
                bomTHAddMaMuaHangWindows.Close();
            });



            LoadEditMaTpCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                ThanhPhamEditList = new ObservableCollection<BOM_BomTp>(DataProvider.Ins.DB.BOM_BomTp);
                bomTHEditMaTpWindows = new BomTHEditMaTpWindows();
                bomTHEditMaTpWindows.Show();
            });
            EditMaTpChangeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                ThanhPhamEditList = new ObservableCollection<BOM_BomTp>(DataProvider.Ins.DB.BOM_BomTp.Where(x => x.MaHang.Contains(MaTpEditSeach)));
            });
            EditMaTpApplyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaTp2 = MaTpEdit;
                bomTHEditMaTpWindows.Close();
            });

            LoadEditMaBTP1Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP1EditList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                bomTHEditMaBTP1Windows = new BomTHEditMaBTP1Windows();
                bomTHEditMaBTP1Windows.Show();
            });
            EditMaBTP1ChangeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP1EditList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp.Where(x => x.MaHang.Contains(MaBTP1EditSeach)));
            });
            EditMaBTP1ApplyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaBtp21 = MaBTP1Edit;
                bomTHEditMaBTP1Windows.Close();
            });

            LoadEditMaBTP2Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP2EditList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                bomTHEditMaBTP2Windows = new BomTHEditMaBTP2Windows();
                bomTHEditMaBTP2Windows.Show();
            });
            EditMaBTP2ChangeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP2EditList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp.Where(x => x.MaHang.Contains(MaBTP2EditSeach)));
            });
            EditMaBTP2ApplyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaBtp22 = MaBTP2Edit;
                bomTHEditMaBTP2Windows.Close();
            });

            LoadEditMaBTP3Command = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP3EditList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp);
                bomTHEditMaBTP3Windows = new BomTHEditMaBTP3Windows();
                bomTHEditMaBTP3Windows.Show();
            });
            EditMaBTP3ChangeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                BTP3EditList = new ObservableCollection<BOM_BomBtp>(DataProvider.Ins.DB.BOM_BomBtp.Where(x => x.MaHang.Contains(MaBTP3EditSeach)));
            });
            EditMaBTP3ApplyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaBtp23 = MaBTP3Edit;
                bomTHEditMaBTP3Windows.Close();
            });

            LoadEditMaMuaHangCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaMuaHangEditList = new ObservableCollection<BOM_BomNl>(DataProvider.Ins.DB.BOM_BomNl);
                bomTHEditMaMuaHangWindows = new BomTHEditMaMuaHangWindows();
                bomTHEditMaMuaHangWindows.Show();
            });
            EditMaMuaHangChangeCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaMuaHangEditList = new ObservableCollection<BOM_BomNl>(DataProvider.Ins.DB.BOM_BomNl.Where(x => x.MaHang.Contains(MaMuaHangEditSeach)));
            });
            EditMaMuaHangApplyCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MaMuaHang2 = MaMuaHangEdit;
                bomTHEditMaMuaHangWindows.Close();
            });
        }

    }
}
