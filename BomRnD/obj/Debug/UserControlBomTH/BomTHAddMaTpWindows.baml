   M S B A M L   `   `   `  ����A  =BomRnD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BomRnD.UserControlBomTHBomRnD.UserControlBomTH  5   	   9!clr-namespace:BomRnD.UserControl1BomRnD.UserControl1  5	   	   3clr-namespace:BomRnD.ViewModelBomRnD.ViewModel  5   	   1    +BomRnD.UserControlBomTH.BomTHAddMaTpWindows   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.2, Version=21.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BomRnD.UserControlBomTH     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   c _MaterialDesignThemes.MahApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   ,uc!clr-namespace:BomRnD.UserControl1   5	   	   ]	 YDevExpress.Mvvm.v21.2, Version=21.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm  	 5
   	   0	viewmodelclr-namespace:BomRnD.ViewModel  	 5   	   -   5          �Name$  
mainWindow��5   	      BomTHVM � DataContext# [  5   	   
���   �$��Medium"�5   	   $��14(�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   ���	#FFFFF8F5 � Title$ Mã thành phẩm��5   	   $
��Bold"�5   	   $	��690��5   	   $
��1000��5   	    � WindowState$ Normal=�5   	   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5)      �  � RowDefinitions 5*   
   �� 5+      $
��auto �6   �� 5,      $
��auto �6   �� 5-      .+�5/   
   � $��0��6   .+�50      *   $BomRnD.UserControl1.ControlBarInfoUC  
 � Tag 6"   �� *Title+	 �� ElementName$	 
mainWindow��51      � 52   
   $��1��6   .+�53      �� 
 �� Orientation$
 
Horizontal=�6   .+�54      �� $��Chọn��6     MaterialDesignRaisedButton#��[ 55      $	��100��57      
��� � �$��10q�59      ��56      �� *AddMaTpApplyCommand+59   '   �� 5:      $��Center=�5;      $��Center=�5<      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã thành phẩm��5=      $	��180��5>       % !MaterialDesignFloatingHintTextBox#��[ 5?      $��5q�5@      ��5:      �� *MaTpAddSeach+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�.��5@   %   .  (System.Windows.Interactivity.Interaction   Triggers 5A      /  )System.Windows.Interactivity.EventTrigger  5B         	EventName$ TextChanged��6)   .  (System.Windows.Interactivity.TriggerBase   Actions. 5C      6  0System.Windows.Interactivity.InvokeCommandAction     Command 64   �� *AddMaTpChangeCommand+5D      .��5E   .   5F      5G      5H      � 5I   
   $��2��6   .+�5J      �� $��Right=�6   
������ $
��Auto=�5N      $
��Auto=�5O      ��. ��5K      �� *ThanhPhamAddList+ �� SelectedItem 5L      �� *SelectedTPAddItem+$ OneWayToSource=� �� View 5Q      �� 5R      .P�5S      �� $��Mã thành phẩm��6)    �� Width$
 auto��5U   )    �� DisplayMemberBinding 5T   )   �� *MaHang+5U   )   �� 5V      $��Tên tiếng trung��6)   $
 auto��5X   )    5W   )   �� *TenTiengTrung+5X   )   �� 5Y      $��Display Name��6)   $
 auto��5[   )    5Z   )   �� *DisplayName+5[   )   �� 5\      $��	Quy cách��6)   $
 auto��5^   )    5]   )   �� *	QuyCach+5^   )   �� 5_      $��
Đơn vị��6)   $
 auto��5a   )    5`   )   �� *UnitSx+5a   )   5b      5d      5e      5f      5g      