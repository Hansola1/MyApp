   M S B A M L   `   `   `  ����F  BGeckoMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:GeckoMarket.ViewsGeckoMarket.Views  5      "    GeckoMarket.Views.OrdersPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:GeckoMarket.Views     5      c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5        N� Title$  
OrdersPage��5
      $	��720��6   $
��1080��6'   $	��720��64   $
��1080��6D    N� 
Background
 ���� .��5      ��  �� CornerRadius$ 10��6   ���#f0f0f2._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $��* �6$   .+�5      ��    	topButton#��[  6   $
��Left=�6<   $��
20 28 0 35q�6W   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6,   $��15��68   $��15��6C   5       �� 5"      $��1��6   
���   �$ 	0 30 0 10��69   ._�5#      ]� .+�5&      �� $��80��6!   $��80��6,   
�������$	 100��6K   $	��Top=�6^   $
��Left=�6s   $��
50 -20 0 0q�6�   ._�5'      A� ��5(   "   �� 5)   &    �� ImageSource$ /Images/avatar.png��61   5+      5,      �� 50      -   5         ��Name$ UsersName_TextBlock��50   $   $��Users��6A   
�������$��22(�6a   $��SemiBold"�6o   $	��Top=�6�   $��	-25 5 0 3q�6�    �� TextAlignment$ Center=�6�   �� 53      $��25q�6$   
�������$	��Top=�6C   $	��0.9��6X   �� 56      $	��Top=�6%   .+�57      �� -   5          
menuButton#��[ 57   A   ���#373737.��58   "   �� 	 �� Orientation$	 
Horizontal=�6-   .+�59   &     $ Account=�6<     menuButtonIcon#��[ 6K   �� 5:   &   $!��Личный кабинет��60   5;   #   5<      �� 5>      -   5        #��[ 5>   A   .��5?   "   �� $	 
Horizontal=�6-   .+�5@   &     $ folder=�6<   #��[ 6J   �� 5A   &   $��Каталог��60   5B   #   5C      �� 5E      -   5        #��[ 5E   @   
�������.��5F   "   �� $	 
Horizontal=�6-   .+�5G   &     $ basket=�6<   #��[ 6J   �� 5H   &   $��Корзина��60   5I   #   5J      5K      �� 5M      -   5        #��[ 5M   3   $��Bottom=�6W   $��Bottom=�6r   $��
15 0 15 20q�6�   .��5N      �� $	 
Horizontal=�6)   .+�5O   "     $ Logout=�68   #��[ 6F   �� 5P   "   $��
Выйти��6,   5Q      5R      5S      5T      5U      � 5X      $��1��6   $��30 20 20 20q�6#    5Y      �� 5Z      $
��auto �6$   �� 5[      $
��auto �6$   �� 5\      $
��auto �6$   �� 5]      $
��auto �6$   �� 5^      $
��auto �6$   �� 5_      $��* �6$   �� 5`      $
��auto �6$   5b      �� 5e      $ 30��6   
���   �$��1��6;   $��214,96,440,520q�6K   ._�5f      �� -   5        
������ #��[  5f   G   $��Center=�6j   $	��NaN��6�   $	��218��6�   $��0,0,0,34q�6�   5g      �� 5h      $��Заказы��6   $��25(�6&   $��SemiBold"�64   
�������$��280,102,514,585q�6]   $��1��6v   �� 5j      $ 30��6   ���	#FFCBCBCB$��1��6?   $��31,96,666,520q�6O   ._�5k      �� -   5        
������ #��[  5k   N   $��Center=�6q   $	��NaN��6�   $	��218��6�   $��0,0,0,34q�6�   5l      �� 5m      $��Аккаунт��6   $��25(�6'   $��SemiBold"�65   
�������$��72,102,701,585q�6^   $��1��6v   � 5p      $��1��6   $��
0,145,0,59q�6#   .+�5q      �� $ 30��6   
�������$��29,0,32,-37q�6>   
 J� Effect
 5r      3  -System.Windows.Media.Effects.DropShadowEffect  5s         
BlurRadius$ 30Q�6+      Color$ #f1f1f3��6;      ShadowDepth$ 0Q�6K   6]   5u      �� 5x      $#��История покупок��6   $��38(�63   $��SemiBold"�6A   ���#121518$
��Left=�6m   $	��336��6�   $��67,24,0,430q�6�   &   System.Windows.Controls.DataGrid  5{      -   5          Name$ Orders_DataGrid��5{         AutoGenerateColumns$ False��69   $��29,91,32,-37q�6�     DataGridRowStyle1   RowStyle# �  5|        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6L     DataGridCellStyle1   	CellStyle# �  6�   
����������	#FFDEE4EC��5{   U   �� *YourDataCollection+   Columns 5}      4  .System.Windows.Controls.DataGridCheckBoxColumn  5~      ,  &System.Windows.Controls.DataGridColumn   Header$ C��65      CanUserResize$ False��6@      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6V     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6c      HeaderTemplate 5   "   �� 5�   &   .R�5�   *   �� #��[ 63   5�   '   5�      0  *System.Windows.Controls.DataGridTextColumn  5�      $	 №��61      
IsReadOnly$
 True��6<   $ False��6N   $
 auto 6d      Binding 6q   �� *	CatalogID+  5�      $ Вид��61   $
 True��6^   $	 190 6p    6>   �� *TypeReptile+6p     5�      $ Пол��61   $
 True��6]   $	 100 6o    6>   �� *
SexReptile+6o     5�      $ 
Морфа��61   $
 True��6a   $	 365 6s    6@   �� *MorphReptile+6s     5�      $ Цена��61   $
 True��6_   $ 90 6q    6?   �� *CostReptile+6q   5�      5�       � 5�      -	   5          �Name$ 	MainFrame��5�        � NavigationUIVisibility$ Hidden=�6'   $��2��6G   5�      5�      5�      