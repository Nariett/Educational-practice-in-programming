   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.ShowAnimal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  
ShowAnimal��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ animalDataGrid��5
         AutoGenerateColumns .  $��27,28,28,75q�6H      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+  5      $ Вид��6%    63   �� *Kind+  5      $ Порода��6%    65   �� *Breed+  5      $ Возраст��6%    66   �� *Year+  5      $ Дата принятия��6%    6<   �� *Date+  5      $ Информация��6%    69   �� *Info+5      �� 5   
   -   5         ��Name$ 
ButtonName��5      $��По имени��6%   $
��Left=�68   $��
27,384,0,0q�6S   $	��Top=�6g   $��88��6   6�   �� 5   
   -   5        $ 
ButtonYear��5      $��По возрасту��6%   $
��Left=�6;   $��245,384,0,0q�6V   $	��Top=�6k   $��88��6�   6�   �� 5   
   -   5        $ 
ButtonType��5      $��По типу��6%   $
��Left=�67   $��463,384,0,0q�6R   $	��Top=�6g   $��88��6   6�   �� 5   
   -   5         ��Name$
 Name��5      $
��Left=�6    $��120,386,0,0q�6;    �� TextWrapping$
 Wrap=�6P   $	��120��6d   $��18��6p   $	��Top=�6|   �� 5   
   -   5        $
 Year��5      $
��Left=�6    $��338,386,0,0q�6;   $
 Wrap=�6P   $	��120��6d   $��18��6p   $	��Top=�6|   �� 5   
   -   5        $��Всех��5      $
��Left=�6    $��672,382,0,0q�6;   $	��Top=�6P   $��88��6h   6s   �� 5   
   -   5        $
 Type��5      $
��Left=�6    $��556,384,0,0q�6;   $
 Wrap=�6P   $	��111��6d   $��18��6p   $	��Top=�6|   5      5      