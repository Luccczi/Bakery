   M S B A M L   `   `   `  ����D  @BakeryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BakeryApp.FramesBakeryApp.Frames  5      #    BakeryApp.Frames.OrderAddPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:BakeryApp.Frames     5        N� Title$  OrderAddPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��391* �6   �� 5      $
��409* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   �� -   5         ��Name$ btnSave��5      $��Сохранить��6"   $��30��6L   $	��130��6X   $��Right=�6d   $��Center=�6�   $��1��6�   $��1��6�   
�������$��0,0,10,0q�6�   �� 5   
   -   5        $��
Назад��5      $��30��67   $	��130��6C   $
��Left=�6O   $��10,0,0,0q�6j   $��Center=�6|   $��1��6�   
�������6�   �� 5   
   $��Имя клиента��6   $��Right=�6&   $��	0,60,19,0q�6B   $	��Top=�6U   $��30��6m   $	��130��6y   
���   �$��0��6�   �� 5   
   $��Дата заказа��6   $��Right=�6&   $��
0,120,19,0q�6B   $	��Top=�6V   $��30��6n   $	��130��6z   
���   �$��0��6�   �� 5   
   $��Сейчас��6   $
��Left=�6!   $��
10,120,0,0q�6<   $	��Top=�6P   $��30��6h   $	��130��6t   
���   �$��1��6�   �� 5   
   $��Дата доставки��6   $��Right=�6(   $��
0,190,19,0q�6D   $	��Top=�6X   $��30��6p   $	��130��6|   
���   �$��0��6�   �� 5   
   $��Стоимость��6   $��Right=�6$   $��
0,260,20,0q�6@   $	��Top=�6T   $��30��6l   $	��130��6x   
���   �$��0��6�   �� 5   
   -   5         ��Name$ cbClient��5       �� DisplayMemberPath$
 name��6E   $
��Left=�6^   $��	11,60,0,0q�6y   $	��Top=�6�   $	��130��6�   $��30��6�   $��1��6�    �� SelectedItem 6%   �� *Client+6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	dpDateEnd��5      $
��Left=�6(   $��
11,190,0,0q�6C   $��30��6W   $	��130��6c   $	��Top=�6o   $��1��6�   �� 5   
   -   5         ��Name$ tbCost��5      $��1��6"   $
��Left=�62   $��
15,260,0,0q�6M   	 �� TextWrapping$
	 Wrap=�6a   $	��Top=�6u   $	��120��6�   $��30��6�   5      5      