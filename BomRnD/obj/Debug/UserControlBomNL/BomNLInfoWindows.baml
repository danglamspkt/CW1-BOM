   M S B A M L   `   `   `  ����A  =BomRnD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BomRnD.UserControlBomNLBomRnD.UserControlBomNL  5   	   9!clr-namespace:BomRnD.UserControl1BomRnD.UserControl1  5	   	   3clr-namespace:BomRnD.ViewModelBomRnD.ViewModel  5   	   .    (BomRnD.UserControlBomNL.BomNLInfoWindows   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.2, Version=21.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BomRnD.UserControlBomNL     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   c _MaterialDesignThemes.MahApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   ,uc!clr-namespace:BomRnD.UserControl1   5	   	   ]	 YDevExpress.Mvvm.v21.2, Version=21.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm  	 5
   	   0	viewmodelclr-namespace:BomRnD.ViewModel  	 5   	   -   5          �Name$  
mainWindow��5   	      BomNLVM � DataContext# [  5   	   ���	#FFFFF8F5
���   �$��Medium"�5   	   $��14(�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$  Nguyên liệu information��5   	   $	��600��5   	   $	��800��5   	    � WindowState$ Normal=�5   	    � WindowStyle$
 None=�5   	   ���	#FF2F49D8$	��0.5q�5   	   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5    
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase	   Actions.	 5!      6  0System.Windows.Interactivity.InvokeCommandAction  
   Command
 6$   �� *LoadedWindowCommand+   CommandParameter 5"   $   ��  �� ElementName$ 
mainWindow��5#      .��5*      �  � RowDefinitions 5+   
   �� 5,      $
��auto �6   �� 5-      .+�5/   
   � $��0��6   .+�50      *   $BomRnD.UserControl1.ControlBarInfoUC  
 � Tag 6"   �� *Title+$ 
mainWindow��51      � 52   
   $��1��6   .+�53      ��  �� Orientation$ 
Horizontal=�6   .+�54      �� $	��350��6   $	��572��55      $��Center=�56      .+�57      �� -   5         ��Name$ NLAvar��57   !   $	��400��58   !   5:      �� 5;      $
��edit��6   $��2q�5<      $��35��5=      $	��100��5>      $��5 0 0 0q�5?      
����� ���5A      �� *SuaNLcommand+5B      � 5D      $	��450��6   $	��572��5E      .+�5F      �� $��2��6#   1  +MaterialDesignThemes.Wpf.ScrollViewerAssist   IsAutoHideEnabled . $��Disabled=�5H   #   $
��Auto=�5I   #   .��5J      � .+�5K      �� $��10q�6)   .+�5L   "   �� $��Center=�5M   ,   $��32(�5N   ,   $
��Bold"�5O   ,   $��10q�5P   ,   
���  ����5L   ,   �� *MaHang+ �� Mode$ OneTime=�5S   #   �� 5T   "   $
��Left=�5U   ,   $��24(�5V   ,   
���  ��$��5q�5X   ,   ��5T   ,   �� *DisplayName+$ OneTime=�5Z   #   �� 5[   "   $ 
Horizontal=�6-   .+�5\   &   �� $��Chất liệu:��60   $
��Left=�5]   0   $��16(�5^   0   $
��Bold"�5_   0   $��5q�5`   0   $	��150��5a   0   5b   '   �� 5c   &   $
��Left=�5d   0   $��16(�5e   0   
���  ��$��5q�5g   0   ��5c   0   �� *
ChatLieu+$ OneTime=�5i   '   5j   #   �� 5k   "   $ 
Horizontal=�6-   .+�5l   &   �� $��
Quy cách:��60   $
��Left=�5m   0   $��16(�5n   0   $
��Bold"�5o   0   $��5q�5p   0   $	��150��5q   0   5r   '   �� 5s   &   $
��Left=�5t   0   $��16(�5u   0   
���  ��$��5q�5w   0   ��5s   0   �� *	QuyCach+$ OneTime=�5y   '   5z   #   9� 5|   "   $��Stretch=�6+   $��Thông tin chi tiết��5}   +   $
��Bold"�5~   +   .��5   &   �� $��
24,8,24,16q�61   $ Vertical=�5�   1     MaterialDesignBody#���  5�   1   .+�5�   *   �� $ 
Horizontal=�65   .+�5�   .   �� $��Version:��68   $
��Left=�5�   8   $��16(�5�   8   $
��Bold"�5�   8   $��5q�5�   8   $	��210��5�   8   5�   /   �� 5�   .   $
��Left=�5�   8   $��16(�5�   8   
���  ��$��5q�5�   8   ��5�   8   �� *	Version+$ OneTime=�5�   /   5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $��Đơn vị (ERP):��68   $
��Left=�5�   8   $��16(�5�   8   $
��Bold"�5�   8   $��5q�5�   8   $	��210��5�   8   5�   /   �� 5�   .   $
��Left=�5�   8   $��16(�5�   8   
���  ��$��5q�5�   8   ��5�   8   �� *	UnitERP+$ OneTime=�5�   /   5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $ ��Đơn vị (Sản xuất):��68   $
��Left=�5�   8   $��16(�5�   8   $
��Bold"�5�   8   $��5q�5�   8   $	��210��5�   8   5�   /   �� 5�   .   $
��Left=�5�   8   $��16(�5�   8   
���  ��$��5q�5�   8   ��5�   8   �� *UnitSx+$ OneTime=�5�   /   5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $ ��Tỷ lệ chuyển đổi:��68   $
��Left=�5�   8   $��16(�5�   8   $
��Bold"�5�   8   $��5q�5�   8   $	��210��5�   8   5�   /   �� 5�   .   $
��Left=�5�   8   $��16(�5�   8   
���  ��$��5q�5�   8   ��5�   8   �� *TyLeChuyenDoi+$ OneTime=�5�   /   5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $��Mã kế toán (ERP):��68   $
��Left=�5�   8   $��16(�5�   8   $
��Bold"�5�   8   $��5q�5�   8   $	��210��5�   8   5�   /   �� 5�   .   $
��Left=�5�   8   $��16(�5�   8   
���  ��$��5q�5�   8   ��5�   8   �� *MaKeToanERP+$ OneTime=�5�   /   5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $#��Mã phân loại lớn (ERP):��68   $
��Left=�5�   8   $��16(�5�   8   $
��Bold"�5�   8   $��5q�5�   8   $	��210��5�   8   5�   /   �� 5�   .   $
��Left=�5�   8   $��16(�5�   8   
���  ��$��5q�5�   8   ��5�   8   �� *
MaPLLonERP+$ OneTime=�5�   /   5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $#��Mã phân loại nhỏ (ERP):��68   $
��Left=�5�   8   $��16(�5�   8   $
��Bold"�5�   8   $��5q�5�   8   $	��210��5�   8   5�   /   �� 5�   .   $
��Left=�5�   8   $��16(�5�   8   
���  ��$��5q�5�   8   ��5�   8   �� *
MaPLNhoERP+$ OneTime=�5�   /   5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $$��Mã phân loại cuối (ERP):��68   $
��Left=�5�   8   $��16(�5�   8   $
��Bold"�5�   8   $��5q�5�   8   $	��210��5�   8   5�   /   �� 5�   .   $
��Left=�5�   8   $��16(�5�   8   
���  ��$��5q�5�   8   ��5�   8   �� *
MaPL4ERP+$ OneTime=�5�   /   5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� $,��&Mã phân loại lớn (sản xuất):��68   $
��Left=�5�   8   $��16(�5�   8   $
��Bold"�5�   8   $��5q�5�   8   $	��210��5   8   5  /   �� 5  .   $
��Left=�5  8   $��16(�5  8   
���  ��$��5q�5  8   ��5  8   �� *	MaPLLonSx+$ OneTime=�5  /   5  +   �� 5	  *   $ 
Horizontal=�65   .+�5
  .   �� $,��&Mã phân loại nhỏ (sản xuất):��68   $
��Left=�5  8   $��16(�5  8   $
��Bold"�5  8   $��5q�5  8   $	��210��5  8   5  /   �� 5  .   $
��Left=�5  8   $��16(�5  8   
���  ��$��5q�5  8   ��5  8   �� *	MaPLNhoSx+$ OneTime=�5  /   5  +   5  '   5  #   9� 5  "   $��Stretch=�6+   $��Mã Thành phẩm��5  +   $
��Bold"�5  +   .��5  &   &   System.Windows.Controls.DataGrid  $��Right=�6/      AutoGenerateColumns .     
IsReadOnly . 
������ $
��Auto=�5$  /   $
��Auto=�5%  /   ��. ��5!  /   �� *
MaTPList+   Columns 5'  *   0	  *System.Windows.Controls.DataGridTextColumn	  5(  .   ,
  &System.Windows.Controls.DataGridColumn 
  Header$ Mã thành phẩm��6A    
  Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 5*  A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5)  A   �� *MaTp+5*  A   	  5+  .   $$ Thị trường (khách hàng)��6A   $
 auto 5-  A    5,  A   �� *	ThiTruong+5-  A   5/  '   50  #   9� 52  "   $��Stretch=�6+   $��Mã Bán thành phẩm��53  +   $
��Bold"�54  +   .��55  &     $��Right=�6/    .   . 
������ $
��Auto=�5:  /   $
��Auto=�5;  /   ��. ��57  /   �� *
MaBTPList2+ 5=  *   	  5>  .   $ Mã BTP��6A   $
 auto 5@  A    5?  A   �� *
MaBtpTW1+5@  A   	  5A  .   $ 
Số hoạ��6A   $
 auto 5C  A    5B  A   �� *
MaBanVe1+5C  A   	  5D  .   $ 	Quy cách��6A   $
 auto 5F  A    5E  A   �� *QuyCachBtpTW1+5F  A   5H  '   5I  #   5J     5K     5L     5M     5N     5O     5P     5Q     