   M S B A M L   `   `   `  ����I  EMagazinJucarii, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MagazinJucarii.AppWindowMagazinJucarii.AppWindow  5   	   )    #MagazinJucarii.AppWindow.AddComanda   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:MagazinJucarii.AppWindow     5   	   -   5          � Title$  
AddComanda��5   	   $	��450��6   $	��750��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%!  '��       '�� �     �� 5
   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ Center=�64   �� 5       � ��$ 15(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 15(�6)   �� 5       � ��$ 20 20 10 20q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��53* �6   �� 5      $
��147* �6   .+�5#   
   �� $��Adaugare Comanda��6   $��0��5$      $��2��5%      $��30(�5&      �� 5)   
   $��Nume Client��6   $��1��5*      $��0��5+      �� 5-   
   -   5         ��Name$ tbxNumeClient��5-      $��1��5.      $��2��5/      ��50      �� *
NumeClient+�� 52   
   $��DataProcurarii��6   $��2��53      $��0��54      (  "System.Windows.Controls.DatePicker  57   
   -   5          Name$ dpDataProcurarii��57      $��2��58      $��2��59      $��20 20 10 20q�5:      	   SelectedDateFormat$	 Short=�5;      
   Text
 5<      �� *DataProcurarii+�� 5>   
   $��Alege Jucaria��6   $��3��5?      $��0��5@      �� 5B   
   -   5         ��Name$ 
cbxJucarii��5B      $��3��6'   $��20q�64   $��1��6@    �� DisplayMemberPath$ Denumire��6}   ��6P   �� *AppViewModel.Jucarii+6}   �� 5E   
   -   5         ��Name$ btnAddComanda��5E      $��Adauga��6(   $��2��69   $��4��6M   
��� � �
�������$��150 20 150 20q�6�   6�   5F      5G      