   M S B A M L   `   `   `  ����b  ^PresentationFramework.Aero2, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes  5       GeckoMarket   GeckoMarket.App   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      YthemeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2   5        �� 	Resources  5         	topButton �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value  
menuButton  menuButtonIcon.  (MahApps.Metro.IconPacks.PackIconMaterial  searchTextbox	 ��Name
 J� SnapsToDevicePixels ��Name �� Triggers �� 
TargetName  filterTextBox �� BasedOn  pagingButton �� Padding  pagingButtonIcon �� Color �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid ��Name �Name J� Opacity � Points �� Stretch  DataGridStyle15  /System.Windows.Controls.DataGridLengthConverter � ColumnDefinitions � RowDefinitions   SelectAllCommand!   HeadersVisibilityConverter �� 	Converter7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter �� RelativeSource  �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter!  Name"   Column# ��Name$ �� CanContentScroll% ��Name& �� ScrollableHeight' � Maximum( �� Orientation) �� ViewportHeight* �� ViewportSize*+ �� #ComputedVerticalScrollBarVisibility, � Value- �� Mode. �� ScrollableWidth/ �� ViewportWidth,0 �� %ComputedHorizontalScrollBarVisibility1 ]� 
Conditions2 �� Property3 �� Value  DataGridRowStyle1)  #System.Windows.Controls.DataGridRow?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid?  9System.Windows.Controls.Primitives.DataGridCellsPresenter4   
ItemsPanelA	  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter5   DetailsVisibility$6   SelectiveScrollingOrientation#7   RowDetailsScrollingConverter;
  5System.Windows.Controls.SelectiveScrollingOrientation8 
  Vertical:  4System.Windows.Controls.Primitives.DataGridRowHeader
9   Row 	 DataGridCellStyle1*  $System.Windows.Controls.DataGridCell 
 ColumnHeaderGripperStyle  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3   -Microsoft.Windows.Themes.DataGridHeaderBorder:   CanUserSort;   IsClickable<   	IsPressed= J� IsMouseOver>   	IsHovered?   SeparatorBrush@   SeparatorBrushA   SortDirectionB   SortDirectionC   SeparatorVisibilityD   SeparatorVisibilityE n�Name   OptionMark.Static.Background  OptionMark.Static.Border  OptionMark.Static.Glyph # OptionMark.MouseOver.Background  OptionMark.MouseOver.Border  OptionMark.MouseOver.Glyph ! OptionMark.Pressed.Background  OptionMark.Pressed.Border  OptionMark.Pressed.Glyph " OptionMark.Disabled.Background  OptionMark.Disabled.Border  OptionMark.Disabled.Glyph  CheckBoxStyle1F �NameG F�NameH ��Name��%-4  &	        &	 C    &	 �    &	 c    &	 �    7  &	 1    &	 �    (�� *    5�      *DataGrid.FocusBorderBrushKey+)(�� M    5�      $" DataGridSelectAllButtonStyle��"  )&	     &	     &		 "    &	
 �#    &	 �$    7 
 7 
 &	 ='    &	 `'    &	 �'    &	 �'    &	 �'    &	 �'    &	 (    &	 2(    &	 U(    &	 x(    &	 �(    &	 �(    &	 �(    7  7  7  7  7  7  7  7  7  7  7  7  7  �� 5	   
   " ��6"   .�5
      ��  � ��
 ���� 6+   �� 5       � �� �#6E77836+   �� 5       �@�FocusVisualStyle 61   Z� �� 5       � ��$ 30��6'   �� 5       � ��$ 30��6&   �� 5       � ��$ Right=�64   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 50��6K   ._�5      �� $��Center=�6/   $��Center=�6J   5      5      5       5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � �� �#dcdcdc63   5      5      �� 5"   
   " ��6#   .�5#      ��  � ��
 ���� 6+   �� 5$       � ��
 �����6+   �� 5%       �@�FocusVisualStyle 61   Z� �� 5&       � ��$ 35��6'   �� 5'       � ��$
 15 3q�6'   �� 5(       � ��$ 13(�6)   �� 5)       � �� 5*      �� 5+      " ��6&   .R�5,      �� #��z��6!   $ 7��6K   ._�5-      �� $��Center=�6/   $
��Left=�6J   5.      5/      51       53      P� 54       �@J�IsMouseOver$
 True��61   . �55      ��  � ��
 �����63   �� 56       � �� �#ffffff63   57      59      �� 5:   
   "  6'   .�5;      ��  � ��$ 	20 2 20 0q�6'   �� 5<       � ��$ Center=�62   �� 5=       � ��$ 15��6&   �� 5>       � ��$ 15��6'   5?      �� 5B   
   " ��6&   .�5C      ��  � �� �#ffffff6+   �� 5D       � �� �#B0B9C66+   �� 5E       � ��$ 0q�60   �� 5F       � ��$ 12(�6)   �� 5G       � ��$ 15 10q�6(   �� 5H       � ��$ Center=�62   �� 5I       � ��$
 0 10q�6'   �� 5J       � �� 5L      �� 5M      " ��6"   .R�5N      �� $	 border��6   $ 20��6-   #��z��6?   $

 True��6i   $��1q�6�   ���#E0E6ED._�5O      �� $ PART_ContentHost��6'   $|�false��6A   $��Hidden=�6S   $��Hidden=�6z   5P       5R      P� 5S       �@J�IsMouseOver$
 true��69   . �5T      �� $ border��6<    � �� �#d9d9d96P   5U      P� 5V       �@J�IsKeyboardFocused$
 true��6?   . �5W      �� $ border��6<    � ��
 �����6P   5X      5Z      5\      5]      �� 5`   
   " ��6&   8   .�5a      ��  � ��$
 10 7q�6(   �� 5b       � �� 5c      �� 5d      " ��6&   .R�5e      �� $	 border��6!   $ 7��61   #��z��6B   $��1q�6l   ���#E0E6ED$

 True��6�   ._�5f      �� $ PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5g       5i      P� 5j       �@J�IsMouseOver$
 true��6=   . �5k   "   �� $ border��6@    � �� �#d9d9d96T   5l      P� 5m       �@J�IsKeyboardFocused$
 true��6C   . �5n   "   �� $ border��6@    � �� �#d9d9d96T   5o      5q      5s      5t      �� 5w   
   " ��6%   .�5x      ��  � ��
 ���� 6+   �� 5y       � �� �#6C76826+   �� 5z       �@�FocusVisualStyle 61   Z� �� 5{       � ��$	 1 0q�6'   �� 5|       � ��$ 13(�6)   �� 5}       � �� 5~      �� 5      " ��6&   .R�5�      �� #��z��6!   $ 5��6K   $
 10 5q�6\   ._�5�      �� $��Center=�6/   $��Center=�6J   $��0 0 0 1q�6g   5�      5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��61   . �5�      ��  � ��
 �����63   �� 5�       � �� �#ffffff63   5�      5�      �� 5�   
   "  6)   .�5�      ��  � ��$ Center=�62   �� 5�       � ��$ 10��6&   �� 5�       � ��$ 10��6'   5�      �� 5�   
   $ 	#FF000000��6J   �� 5�   
   " ��6   .�5�      ��  � �� 5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ Border��6(   #��� ��68   $

 True��6y   � 5�      $ Arrow��6&   
���   �$��Right=�6B   $��8,8,3,3q�6^   $
 0.15Q�6o    �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5�       5�      P� 5�       �@J�IsMouseOver$
 True��6=   . �5�   "   �� $ Border��6;   # � ��6O    � ��5�      P� 5�       � ��$
 True��6;   . �5�   "   �� $ Border��69   # � ��6M    � ��5�      P� 5�       � {�$ False��6;   . �5�   "   �� $ Arrow��6?    � y�$ 	Collapsed=�6R   5�      5�      5�      5�      �� 5�   
   "  6'   .�5�      ��  � ��
 ���� 6+   �� 5�       � �� �#2225286+   �� 5�       � ��$ 0q�60   �� 5�        �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�69   �� 5�       � ��$
 true��6>   �� 5�       �@��PanningMode$
 Both=�69   �� 5�       �@��IsFlicksEnabled$ False��67   �� 5�       �@ AutoGenerateColumns$ False��64   �� 5�       �@ HeadersVisibility$ Column=�62   �� 5�       � ��$ 0 10 0 0q�6'   �� 5�       � ��$ 5��6)   �� 5�       �@ SelectionMode$ Single=�6.   �� 5�       �@ SelectionUnit$ FullRow=�6.   �� 5�       �@ CanUserAddRows$ False��6/   �� 5�       �@ CanUserDeleteRows$ False��62   �� 5�       �@ CanUserReorderColumns$ False��66   �� 5�       �@ CanUserResizeRows$ False��62   �� 5�       � ��$ 13(�6)   �� 5�       �@ GridLinesVisibility$
 None=�64   �� 5�       �@ ColumnWidth$ * 6,   �� 5�       � �� 5�      �� 5�      "  6&   .R�5�      �� #��z��6!   #��z��6K   #��z��6   # z��6�   $

 True��6�   ._�5�      �� $ DG_ScrollViewer��6+   $|�false��6D   ��5�   "   �� 5�   &   " ��66   .R�5�   *   �  5�   .   �� 5�   2   $
��Auto �6C   �� 5�   2   $��* �6C   �� 5�   2   $
��Auto �6C    5�   .   �� 5�   2   $
��Auto �6@   �� 5�   2   $��* �6@   �� 5�   2   $
��Auto �6@   .+�5�   .   �� #��Z 65   $|�false��6d   ��6v   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z # Z  �� "   ��6�  �� *CellsPanelHorizontalOffset+ �� "     5�   .   $!! PART_ColumnHeadersPresenter��6M   $��1��6r   y�6�   �� *HeadersVisibility+# Z # Z"  �� "   �� 5�   .   $!# PART_ScrollContentPresenter��6E   $��2��6j   #$ z��6~   $��1��6�   �� 5�   .   $% PART_VerticalScrollBar��68   $��2��6X   #' z& 6h   $( Vertical=�6�   $��1��6�   #* z) 6�   #y�z+ 6H  , 6�   �� *VerticalOffset+$- OneWay=� �� *TemplatedParent+6H  � 5�   .   $��1��63   $��2��6C    5�   2   �� 5�   6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� 5�   6   $��* �6G   .+�5�   2   �� $% PART_HorizontalScrollBar��6<   $��1��6^   #' z. 6n   $( 
Horizontal=�6�   #* z/ 6�   #y�z0 6C  , 6�   �� *HorizontalOffset+$- OneWay=� �� *TemplatedParent+6C  5�   /   5�   +   5�   '   .��5�   "   �� #
 z
 61   5�      5�      5�      5�       5�      ]� 5�      1 5�      �� 5�      2 �@��
IsGrouping$
3 true��6:   �� 5�      "2 �@%�IsVirtualizingWhenGrouping$3 false��6\   ./�5�      ��  � ��$ false��6F   5�      5�      �� 5�   
   "  6*   .�5�      ��  � ��$ 0 4 0 0q�6'   �� 5�       � �� �#FFFFFF6+   �� 5�       �@J�SnapsToDevicePixels$
 true��64   �� 5�       �@=�ErrorTemplate 69   Z� �� 5�       �@ ValidationErrorTemplate 5�      �� 5�      .R�5�      �� 
���  ��$��2,0,0,0q�65   $��!��6F   $��Center=�6O   5      5     �� 5      � �� 5     �� 5     "  6&   .R�5     �� $	 
DGR_Border��6!   $	 0 8q�65   $ 5��6C   #��z��6T   $��0q�6~   $

 True��6�   ._�5        5  "   �� 5	  &   $
��Auto �67   �� 5
  &   $��* �67    5  "   �� 5  &   $��* �64   �� 5  &   $
��Auto �64   .+�5  "     $��1��69   #��z4 6I   #
 z
 6s   	  5  "   $��1��6;   $��1��6K   #y�z5 6o  6 6X   �� *AreRowDetailsFrozen+# Z7 # Z8  �� "   6o    5  "   $��2��64   $6 Vertical=�6E   y�6�   �� *HeadersVisibility+# Z # Z9  �� "   5     5     5     5      5     P� 5      �@J�IsMouseOver$
 True��61   . �5     ��  � ��
 �����63   �� 5      � �� �#ffffff63   5     P� 5      �@ 
IsSelected$
 True��60   . �5     ��  � ��
 �����63   �� 5       � �� �#ffffff63   5!     ]� 5"     1 5#     �� 5$     2 �@ 
IsSelected$
3 true��6:   �� 5%     2 �@��IsSelectionActive$3 false��6J   ./�5'     ��  � �� �#dfdfdf63   5(     5*     �� 5+  
   "  6+   .�5,     ��  � ��
 ���� 6+   �� 5-      � ��$ Center=�62   �� 5.      �@�FocusVisualStyle 61   Z� �� 5/      � ��$
 15 0q�6'   �� 50      � �� 51     �� 52     "  6&   .R�53     �� #��z��6!   $��0q�6K   $

 True��6_   ._�54     �� #
 z
 6/   55     56     58     59     �� 5:  
   " n�61   .�5;     ��  � ��$ 8��6&   �� 5<      � ��
 ���� 6+   �� 5=      �@�Cursor$ SizeWE��6'   �� 5>      � �� 5?     �� 5@     " n�6&   .R�5A     �� #��z��6!   # z��6K   5B     5D     5E     �� 5F  
   "  63   .�5G     ��  � ��$ Center=�69   �� 5H      � ��
 ���� 6+   �� 5I      � �� �#69717D6+   �� 5J      � ��$ 
15 0 15 10q�6'   �� 5K      � �� 5L     �� 5M     "  6&   .R�5N     � .+�5O       #��z��69   #��z��6c   #��z��6�   #; z: 6�   #< z��6�   #> z= 6  # z��6A  #@ z? 6e  #B zA 6�  #D zC 6�  ._�5P  "   �� #��z��63   $
��True��6v   #
 z
 6�   #��z��6�   5Q     n� 5R     $E PART_LeftHeaderGripper��6$   $
��Left=�6D   8��  6_   n� 5S     $E PART_RightHeaderGripper��6$   $��Right=�6E   8�� 6a   5T     5U     5W     5X     �� 5\  
   $ 	#FFFFFFFF��6?   �� 5]  
   $ 	#FF707070��6;   �� 5^  
   $ 	#FF212121��6:   �� 5_  
   $ 	#FFF3F9FF��6B   �� 5`  
   $ 	#FF5593FF��6>   �� 5a  
   $ 	#FF212121��6=   �� 5b  
   $ 	#FFD9ECFF��6@   �� 5c  
   $ 	#FF3C77DD��6<   �� 5d  
   $ 	#FF212121��6;   �� 5e  
   $ 	#FFE6E6E6��6A   �� 5f  
   $ 	#FFBCBCBC��6=   �� 5g  
   $ 	#FF707070��6<   �� 5h  
   " ��6'   .�5i     ��  �@�FocusVisualStyle 61   Z� �� 5j      � ��8   6+   �� 5k      � �� �#DAE2EA6,   �� 5l      � ��# � ��6+   �� 5m      � ��$ 1q�60   �� 5n      � �� 5o     �� 5p     " ��6&   .R�5q     � $F templateRoot��6   
������ $

 True��6N    5r     �� 5s  "   $
��Auto �63   �� 5t  "   $��* �63   .+�5v     �� $	 checkBoxBorder��6%   $ 3��6=   $ 1q�6N   #��z��6Z   #��z��6�   #��z��6�   #��z��6�   $��1q�6'  #��z��62  ._�5w  "   � $F markGrid��6'   .+�5x  &   F� $G 
optionMark��6+   Y�����4� �� Ѽ�G dԊ Ѩ�D dԊ �    ^>O ��z r�5 ��@ ��\ 
ܺ��� @�j�  �>��4� �� 8�� $��1q�6  $ 0Q�6  $
 None=�6  �� 5y  &   $ indeterminateMark��60   8�� $��2q�6{   $ 0Q�6�   5z  #   5{     �� 5|     $H contentPresenter��6/   $��1��6I   $|�False��6Y   #��z��6k   #��z��6�   $
��True��6�   #
 z
 6�   #��z��6(  5}      5~     P� 5      � ��$
 true��6<   . �5�  "   ��  6E   Z�  �@�FocusVisualStyle�� 5�  "    � ��$ 4,-1,0,0q�6<   5�     P� 5�      �@J�IsMouseOver$
 true��6=   . �5�  "   �� $ checkBoxBorder��6?   8   � ��6[   �� 5�  "   $ checkBoxBorder��6@    � �� �#9575CD6\   �� 5�  "   $ 
optionMark��69   8   � ��6Q   �� 5�  "   $ indeterminateMark��69   8   � ��6X   5�     P� 5�      � {�$ false��6;   . �5�  "   �� $ checkBoxBorder��6?   8   � ��6[   �� 5�  "   $ checkBoxBorder��6@   8   � ��6\   �� 5�  "   $ 
optionMark��69   8   � ��6Q   �� 5�  "   $ indeterminateMark��69   8 	  � ��6X   5�     P� 5�      � ��$
 true��6;   . �5�  "   �� $ checkBoxBorder��6?   8 
  � ��6[   �� 5�  "   $ checkBoxBorder��6@    � �� �#9575CD6\   �� 5�  "   $ 
optionMark��69   8   � ��6Q   �� 5�  "   $ indeterminateMark��69   8   � ��6X   5�     P� 5�      �@d�	IsChecked$
 trueY�6;   . �5�  "   �� $ 
optionMark��6<    �@J�Opacity$ 1Q�6T   �� 5�  "   $ indeterminateMark��6<    �@J�Opacity$ 0Q�6[   5�     P� 5�      6;   Z�  �@d�	IsChecked. �5�  "   �� $ 
optionMark��6<    �@J�Opacity$ 0Q�6T   �� 5�  "   $ indeterminateMark��6<    �@J�Opacity$ 1Q�6[   5�     5�     5�     5�     5�     5�     