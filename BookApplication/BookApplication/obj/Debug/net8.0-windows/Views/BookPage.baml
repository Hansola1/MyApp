   M S B A M L   `   `   `  ����J  FBookApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:BookApplication.ViewsBookApplication.Views  5      $    BookApplication.Views.BookPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:BookApplication.Views     5      $	��600��5      $
��1080��6%     N� 
Background
  �����.��5	      � $	��600��6   $
��1080��6   .+�5
   
    � -   5          �Name$ 	MainFrame��5
        � NavigationUIVisibility$ Hidden=�6#    K� ZIndex$ 1��6C   �� 5   
   $$��Список всех книг��6   $
��Left=�6+   $��	39,10,0,0q�6F   $	��Top=�6Y   $��40(�6q   $	��370��6   �� 5   
   -   5        $!��Добавить книгу��5      $
��Left=�6@   $��
383,23,0,0q�6[   $	��Top=�6o   $��50��6�   $	��202��6�   $��20(�6�   �� 5   
   -   5        $+��%Редактировать книгу��5      $
��Left=�6F   $��
607,23,0,0q�6a   $	��Top=�6u   $��50��6�   $	��202��6�   $��20(�6�   �� 5   
   -   5        $��Удалить книгу��5      $
��Left=�6B   $��
827,23,0,0q�6]   $	��Top=�6q   $��50��6�   $	��196��6�   $��20(�6�   �� 5   
   -   5        $��Выдать книгу��5      $
��Left=�6>   $��
46,532,0,0q�6Y   $	��Top=�6m   $��50��6�   $	��213��6�   $��20(�6�   �� 5   
   -   5        $��Вернуть книгу��5      $
��Left=�6B   $��284,532,0,0q�6]   $	��Top=�6r   $��50��6�   $	��213��6�   $��20(�6�   �� 5   
   
�������$��46,91,24,79q�6$   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ BookDataGrid��5         AutoGenerateColumns$ False��6-   ���	#FFE3E3E3   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Артикул книги��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6b   	   
IsReadOnly$
	 True��6n   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6@   �� *ArticleNumber+6n     5      $! Название книги��6)   $	 200 6[   $
	 True��6g   
 6A   �� *Title+6g     5      $ Жанр��6)   $	 110 6Q   $
	 True��6]   
 67   �� *Genre+6]     5      $ Описание��6)   $	 190 6[   $
	 True��6g   
 6;   �� *Description+6g     5      $ Дата выпуска��6)   $	 150 6z   $
	 True��6�   
 6?   �� *ReleaseDate+ �� StringFormat$ 
dd.MM.yyyy��6�     5      $ Статус��6)   $	 130 6T   $
	 True��6`   
 69   �� *Status+6`     5      $ Читатель��6)   $	 130 6Z   $
	 True��6f   
 6;   �� *
ReaderName+6f   5      5       5!      5"      