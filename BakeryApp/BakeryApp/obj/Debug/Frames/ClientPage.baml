   M S B A M L   `   `   `  ����D  @BakeryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BakeryApp.FramesBakeryApp.Frames  5      !    BakeryApp.Frames.ClientPage   5      S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:BakeryApp.Frames     5        N� Title$  
ClientPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��60 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dGridClients��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *id+  5      $ Имя клиента��6%    6:   �� *name+  5      $ Телефон��6%    66   �� *phone+  5      $ ИНН��6%    62   �� *INN+  5      $ 
Почта��6%    64   �� *email+  5      $ 
Адрес��6%    64   �� *	address+5      �� 5   
   -   5         ��Name$ tbSearh��5      $
��Left=�6#   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 
Поиск��6>   $��10,0,0,0q�6e   $��1��6w   
 �� TextWrapping$

 Wrap=�6�   $��Center=�6�   $	��220��6�   $��30��6�   �� 5   
   -   5        $��Добавить��5      $��30��69   $	��130��6E   $��Right=�6Q   $��Center=�6m   $��1��6�   
�������$��0,0,10,0q�6�   �� 5   
   -   5        $!��Очистить поиск��5      $��30��6A   $	��146��6M   $
��Left=�6Y   $��Center=�6t   $��1��6�   
�������$��	254,0,0,0q�6�   5      5      