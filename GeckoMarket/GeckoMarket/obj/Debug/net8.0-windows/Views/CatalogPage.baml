   M S B A M L   `   `   `  ����F  BGeckoMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:GeckoMarket.ViewsGeckoMarket.Views  5      #    GeckoMarket.Views.CatalogPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:GeckoMarket.Views     5      c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5        N� Title$  CatalogPage��5
      $	��720��6   $
��1080��6(   $	��720��65   $
��1080��6E    N� 
Background
 ���� .��5      ��  �� CornerRadius$ 10��6   ���#f0f0f2._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $��* �6$   .+�5      ��    	topButton#��[  6   $
��Left=�6<   $��
20 28 0 35q�6W   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6,   $��15��68   $��15��6C   5      �� 5!      $��1��6   
���   �$ 	0 30 0 10��69   ._�5"      ]� .+�5%      �� $��80��6!   $��80��6,   
�������$	 100��6K   $	��Top=�6^   $
��Left=�6s   $��
50 -20 0 0q�6�   ._�5&      A� ��5'   "   �� 5(   &    �� ImageSource$ /Images/avatar.png��61   5*      5+      �� 5/      -   5         ��Name$ UsersName_TextBlock��5/   $   $��Users��6A   
�������$��22(�6a   $��SemiBold"�6o   $	��Top=�6�   $��	-25 5 0 3q�6�    �� TextAlignment$ Center=�6�   �� 52      $��25q�6$   
�������$	��Top=�6C   $	��0.9��6X   �� 55      $	��Top=�6%   .+�56      �� -   5          
menuButton#��[ 56   A   .��57   "   �� 	 �� Orientation$	 
Horizontal=�6-   .+�58   &     $ Account=�6<     menuButtonIcon#��[ 6K   �� 59   &   $!��Личный кабинет��60   5:   #   5;      �� 5=      -   5        #��[ 5=   A   ���#373737.��5>   "   �� $	 
Horizontal=�6-   .+�5?   &     $ folder=�6<   #��[ 6J   �� 5@   &   $��Каталог��60   5A   #   5B      �� 5D      -   5        #��[ 5D   @   
�������.��5E   "   �� $	 
Horizontal=�6-   .+�5F   &     $ basket=�6<   #��[ 6J   �� 5G   &   $��Корзина��60   5H   #   5I      5J      �� 5L      -   5        #��[ 5L   9   $��Bottom=�6]   $��Bottom=�6x   $��
15 0 15 20q�6�   .��5M      �� $	 
Horizontal=�6)   .+�5N   "     $ Logout=�68   #��[ 6F   �� 5O   "   $��
Выйти��6,   5P      5Q      5R      5S      5U      � 5X      $��1��6   $��30 20 20 20q�6#    5Y      �� 5Z      $
��auto �6$   �� 5[      $
��auto �6$   �� 5\      $
��auto �6$   �� 5]      $
��auto �6$   �� 5^      $
��auto �6$   �� 5_      $��* �6$   �� 5`      $
��auto �6$   .+�5e      � $	��543��6   $
��Left=�6#   $��	0,0,0,624q�6>   $��6��6Q   .+�5f      �� $
��20 0q�6    $��Center=�6.   ���	#FF595959
 J� IsHitTestVisible$
 False��6`    K� ZIndex$ 1��5g      $!��Найти на GeckoMarket��6   6=   �� 5i      -   5        $��textBoxSearch��5i        searchTextbox#��[ 63   
����������	#FF595959 �� SelectionBrush �	#FF595959 �� SelectionTextBrush
 �����6�     5j      $ Magnify=�6,   $��15��6;   $��15��6F   $��Center=�6R   $��0 0 15 0q�6m   ���	#FF595959$��Right=�6�   5k      �� 5o      $��Каталог��6   $��1��6+   $��32(�68   $��SemiBold"�6F   $��
0 -600 0 0q�6\   ���#121518$
��Left=�6�   �� 5q      $��5��6   $��3��6'   ���#DAE2EA$��0 -1090 0 10q�6I   �� 5t      $��Right=�6   ���#DEE4EC$��1q�6L   $ 5��6`   ���#ffffff$��	0 650 0 0q�6�   ._�5u      �� $	 
Horizontal=�6!   .+�5v      ��   pagingButton#��[ 6!   .��5w        $ ChevronLeft=�64     pagingButtonIcon#��[ 6G   5x      �� 5z      $��1��6$   ���#DEE4EC$	��3 7q�6=   �� 5|      #��[ 6!   .��5}        $ ChevronRight=�64   #��[ 6H   5~      5      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ Catalog_DataGrid��5�         AutoGenerateColumns$ False��66   $��
0,140,0,28q�6}     DataGridRowStyle1   RowStyle# �  5�        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6G     DataGridCellStyle1   	CellStyle# �  6�   
����������	#FFDEE4EC��5�   R   �� *YourDataCollection+   Columns 5�      4  .System.Windows.Controls.DataGridCheckBoxColumn  5�      -   5        ProductCheckBox��,  &System.Windows.Controls.DataGridColumn   Header$ C��5�   J      CanUserResize$ False��6U      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6k    	 CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [	 6x      HeaderTemplate 5�      �� 5�   "   .R�5�   &   �� #��[	 6/   5�   #   5�      0  *System.Windows.Controls.DataGridTextColumn  5�      $	 №��6-      
IsReadOnly$
 True��68   $ False��6J   $
 auto 6`      Binding 6m   �� *	CatalogID+  5�      $ Вид��6-   $
 True��6Z   $	 190 6l    6:   �� *TypeReptile+6l     5�      $ Пол��6-   $
 True��6Y   $	 100 6k    6:   �� *
SexReptile+6k     5�      $ 
Морфа��6-   $
 True��6]   $	 365 6o    6<   �� *MorphReptile+6o     5�      $ Цена��6-   $
 True��6[   $ 90 6m    6;   �� *CostReptile+6m   5�      5�      �� 5�      -	   5        #��[ 5�   /   $��1��6U   $(��"Добавить в корзину��6e   $
��Left=�6�   $��
30,671,0,0q�6�   $	��Top=�6�   $	��150��6�   $��29��6�   
�������
�������$��12(�6  ���	#FF5959595�       � 5�      -
   5          �Name$ 	MainFrame��5�        � NavigationUIVisibility$ Hidden=�6'   $��2��6G   6]   5�      5�      5�      