   M S B A M L   `   `   `  ����D  @BakeryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BakeryApp	BakeryApp  5   	       BakeryApp.ItemWindow   5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BakeryApp     5   	     � Title$.  (Окно заказа продукции��5	   	   $	��450��6'   $	��500��67   $	��400��6D   $	��500��6S   .��5
      �  � RowDefinitions 5   
   �� 5      $
��360* �6   �� 5      $��60 �6   .+�5   
   �� -   5         ��Name$ tbCount��5      $
��Left=�6#    �� TextWrapping$
 Wrap=�6>   $	��Top=�6R   $	��200��6j   $��30��6v   $��189,227,0,0q�6�   �� 5   
   -   5         ��Name$ 	cbProduct��5      $	��200��6D    �� DisplayMemberPath$
 name��6P   $��189,137,111,0q�6i   $	��Top=�6�   $��30��6�    �� SelectedItem 6&   �� *Item+6�   �� 5   
   -   5        $��Сохранить��5      $��30��6;   $	��180��6G   $��Right=�6S   $��Bottom=�6o   
�������$��1��6�   $��	0,0,10,10q�6�   �� 5   
   -   5        $��Отмена��5      $��30��6:   $	��180��6F   $
��Left=�6R   $��Bottom=�6m   
�������$��1��6�   $��	10,0,0,10q�6�   �� 5   
   $
��Left=�6   $��
50,137,0,0q�6/   $
��Wrap=�6C   $��Продукция��6W   $	��Top=�6h   $��30��6�   $	��100��6�   �� 5   
   $
��Left=�6   $��
50,227,0,0q�6/   $
��Wrap=�6C   $��Количество��6W   $	��Top=�6i   $��30��6�   $	��100��6�   5      5      