   M S B A M L   `   `   `  ����D  @BakeryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BakeryApp.FramesBakeryApp.Frames  5      $    BakeryApp.Frames.OrderItemPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:BakeryApp.Frames     5        N� Title$  OrderItemPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��21* �6   �� 5      $��60 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dGridItemOrder��5         AutoGenerateColumns .     
IsReadOnly . $��	10,0,10,1q�6Y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *id+  5      $ Название��6%    67   �� *	Item.name+  5      $ Цена��6%    63   �� *
Item.price+ �� StringFormat$ N2��  5      $ Вес��6%    62   �� *Item.weight+$ N2��  5      $ Количество��6%    69   �� *
quantity+5      �� 5   
   -   5        	 ��Name$	 btnAdd��5      $��Добавить��6!   $��30��6I   $	��130��6U   $��Center=�6a   $��1��6|   
�������$��Right=�6�   $��0,0,10,0q�6�   �� 5   
   -   5        $��
Назад��5      $��30��67   $	��130��6C   $
��Left=�6O   $��10,0,0,0q�6j   $��Center=�6|   $��1��6�   
�������6�   5      5      