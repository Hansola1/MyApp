   M S B A M L   `   `   `  ����  GeckoMarket    GeckoMarket.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  GeckoMarket��5   	   $	��720��6   $
��1080��6*   $	��720��5   	   $
��1080��6    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   "    � WindowStyle$
 None=�6<   .��5      ��  �� CornerRadius$ 10��6   
�������._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $��* �6$   .+�5      ��    	topButton#��[  6   $
��Left=�6<   $��
20 28 0 35q�6W   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6,   $��15��68   $��15��6C   5      �� 5!      $��1��6   
���   �$ 	0 30 0 10��69   ._�5"      ]� .+�5%      �� $��80��6!   $��80��6,   
�������$	 100��6K   $	��Top=�6^   $
��Left=�6s   $��
50 -20 0 0q�6�   ._�5&      A� ��5'   "   �� 5(   &    �� ImageSource$ /Images/avatar.png��61   5*      5+      �� 5.      $��Users��6$   
�������$��22(�6D   $��SemiBold"�6R   $	��Top=�6h   $��	-25 5 0 3q�6}   	 �� TextAlignment$	 Center=�6�   �� 51      $��25q�6$   
�������$	��Top=�6C   $	��0.9��6X   �� 54      $	��Top=�6%   .+�55      �� -   5          
menuButton#��[ 55   A   .��56   "   �� 
 �� Orientation$
 
Horizontal=�6-   .+�57   &     $ Account=�6<     menuButtonIcon#��[ 6K   �� 58   &   $!��Личный кабинет��60   59   #   5:      �� 5<      -   5        #��[ 5<   A   .��5=   "   �� $
 
Horizontal=�6-   .+�5>   &     $ folder=�6<   #��[ 6J   �� 5?   &   $��Каталог��60   5@   #   5A      �� 5C      -   5        #��[ 5C   @   .��5D   "   �� $
 
Horizontal=�6-   .+�5E   &     $ basket=�6<   #��[ 6J   �� 5F   &   $��Корзина��60   5G   #   5H      5I      �� 5L      #��[ 6!   $��Bottom=�6E   $��Bottom=�6`   $��
15 0 15 20q�6x   .��5M      �� $
 
Horizontal=�6)   .+�5N   "     $ Logout=�68   #��[ 6F   �� 5O   "   $��
Выйти��6,   5P      5Q      5R      5S      5T      � 5W      $��1��6   .+�5Y      �� $7��1Добро пожаловать на GeckoMarket!��6   $��30(�6D   $
��Bold"�6R   $
��Left=�6d   $��Center=�6   $��150,-100,0,0q�6�   5Z       � 5]      -   5          �Name$ 	MainFrame��5]        � NavigationUIVisibility$ Hidden=�6'   $��2��6G   5^      5_      5`      