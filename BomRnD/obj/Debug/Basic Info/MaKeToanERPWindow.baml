   M S B A M L   `   `   `  ����A  =BomRnD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BomRnD.Basic_InfoBomRnD.Basic_Info  5   	   9!clr-namespace:BomRnD.UserControl1BomRnD.UserControl1  5
   	   3clr-namespace:BomRnD.ViewModelBomRnD.ViewModel  5   	   )    #BomRnD.Basic_Info.MaKeToanERPWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.2, Version=21.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:BomRnD.Basic_Info     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   c _MaterialDesignThemes.MahApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=5.0.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5	   	   ,uc!clr-namespace:BomRnD.UserControl1   5
   	   ]	 YDevExpress.Mvvm.v21.2, Version=21.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm  	 5   	   0	viewmodelclr-namespace:BomRnD.ViewModel  	 5   	   -   5          �Name$  
mainWindow��5   	      BasicVM � DataContext# [  5   	   
���   �$��Medium"�5   	   $��14(�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   ���	#FFFFF8F5 � Title$ Mã kế toán (ERP)��5   	   $
��Bold"�5   	   $	��400��5   	   $	��420��5   	    � WindowState$ Normal=�5   	   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase	   Actions.	 5       6  0System.Windows.Interactivity.InvokeCommandAction  
   Command
 6$   �� *LoadedKTERPCommand+   CommandParameter 5!   $   ��  �� ElementName$ 
mainWindow��5"      .��5%      �  � RowDefinitions 5&   
   �� 5'      $
��auto �6   �� 5(      .+�5*   
   � $��0��6   .+�5+      *   $BomRnD.UserControl1.ControlBarInfoUC  
 � Tag 6"   �� *Title+$ 
mainWindow��5,      � 5-   
   $��1��6   .+�5/      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .     
IsReadOnly . 
������ ��50      �� *KeToanERPlist+   Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ ID Mã��6)    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	 150
 56   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 55   )   �� *MaHang+56   7     57      $ Display Name��6)   $	 250
 59   )    58   )   �� *DisplayName+59   7   5;      5<      5=      5>      