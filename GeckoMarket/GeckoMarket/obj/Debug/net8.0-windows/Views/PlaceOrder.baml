   M S B A M L   `   `   `  ����F  BGeckoMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:GeckoMarket.ViewsGeckoMarket.Views  5      "    GeckoMarket.Views.PlaceOrder   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:GeckoMarket.Views     5      c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5        N� Title$  
PlaceOrder��5
      $	��720��6   $
��1080��6(   $	��720��65   $
��1080��6E    N� 
Background
 ���� .��5      ��  �� CornerRadius$ 10��6   ���#f0f0f2._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $��* �6#   .+�5      � $��48,46,50,41q�6   $��2��6(   .+�5      � .+�5      �� $ 30��6   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6/      Color$ #f1f1f3��6?      ShadowDepth$ 0Q�6O   6a   5      �� 5      $'��!Оформление заказа��6    $��40(�69   $��SemiBold"�6G    �� TextAlignment$
 Left=�6]   $��72,43,526,526q�6r   5       �� 5"      $*��$Срок действия карты��6   $��25(�67   $��SemiBold"�6E   $
��Left=�6[   $��77,157,0,438q�6v   $ Center=�6�   
���   �$	��252��6�   �� 5#      -   5        	 ��Name$	 dataCard_TextBox��5#   A      searchTextbox#��[  6   $
��Left=�6[   
 �� TextWrapping$

 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��350��6�   $��42��6�   
���   �$��386,157,0,0q�6�   �� 5%      $��Счет карты��6   $��25(�6.   $��SemiBold"�6<   $
��Left=�6R   $��77,219,0,372q�6m   $ Center=�6�   
���   �$��52��6�   �� 5&      -   5        $	 card_TextBox��5&   A   #��[  6   $
��Left=�6W   $

 Wrap=�6r   $�� ��6�   $	��Top=�6�   $	��350��6�   $��42��6�   
���   �$��386,219,0,0q�6�   �� 5(      $	��CVC��6   $��25(�6'   $��SemiBold"�65   $
��Left=�6K   $��77,282,0,317q�6f   $ Center=�6|   
���   �$��52��6�   �� 5)      -   5        $	 CVC_TextBox��5)   A   #��[  6   $
��Left=�6V   $

 Wrap=�6q   $�� ��6�   $	��Top=�6�   $	��350��6�   $��42��6�   
���   �$��386,282,0,0q�6�   �� 5+      $��
Адрес��6   $��25(�6)   $��SemiBold"�67   $
��Left=�6M   $��77,347,0,245q�6h   $ Center=�6~   
���   �$��78��6�   �� 5,      -   5        $	 address_TextBox��5,   A   #��[  6   $
��Left=�6Z   $

 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��350��6�   $��41��6�   
���   �$��386,347,0,0q�6�   �� 5.      $ 15��6   
���   �$��333,499,246,70q�6>    J� RenderTransformOrigin$ 0.5,0.5&�6V   ._�5/      �� -   5          pagingButton#��[ 5/      $	��NaN��6Y   $��25(�6f   $
��Bold"�6t   
������ 
���   �
������ $��
0,-11,0,-9q�6�   50      �� 51      $!��Оформить заказ��6   $��25(�62   $
��Bold"�6@   $
��Left=�6R   $��425,514,0,88q�6m   $ Center=�6�   
�������$	��213��6�   �� 53      $ 15��6   
������ $��861,34,23,538q�6D   $ 0.5,0.5&�6[   ._�54      �� -   5        #��[ 54      $	��NaN��6X   $��25(�6e   $
��Bold"�6s   
������ 
���   �
������ $��
0,-11,0,-9q�6�   .��55      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Close=�60     menuButtonIcon#��[ 6=   $��30��6e   $��28��6q   $	��Top=�6|   56      57      5:       � 5;      -   5          �Name$ 	MainFrame��5;        � NavigationUIVisibility$ Hidden=�6'   $��2��6G   6]   5<      5=      5>      