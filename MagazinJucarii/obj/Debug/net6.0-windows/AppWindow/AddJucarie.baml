   M S B A M L   `   `   `  ����I  EMagazinJucarii, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:MagazinJucarii.AppWindowMagazinJucarii.AppWindow  5   	   )    #MagazinJucarii.AppWindow.AddJucarie   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:MagazinJucarii.AppWindow     5   	     � Title$  
AddJucarie��5   	   $	��450��6   $	��500��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%!  '��       '�� �     �� 5
   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ Center=�64   �� 5       � ��$ 20(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ 15(�6)   �� 5       � ��$ 20 20 10 20q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��77* �6   �� 5      $
��173* �6   .+�5#   
   �� $��Adaugare Jucarie��6   $��0��5$      $��2��5%      $��30(�5&      �� 5(   
   $��Denumire��6   $��1��5)      $��0��5*      �� 5,   
   -   5         ��Name$ tbxDenumire��5,      $��1��5-      $��2��5.      ��5/      �� *
Denumire+�� 51   
   $��Varsta Recomandata��6   $��2��52      $��0��53      $
��Wrap=�54      �� 56   
   -   5        $ 	tbxVarsta��56      $��2��57      $��2��58      ��59      �� *VarstaRecomandata+�� 5;   
   $��Serie��6   $��3��5<      $��0��5=      $
��Wrap=�5>      �� 5@   
   -   5        $ tbxSerie��5@      $��3��5A      $��2��5B      ��5C      �� *Serie+�� 5E   
   $
��Pret��6   $��4��5F      $��0��5G      $
��Wrap=�5H      �� 5J   
   -   5        $ tbxPret��5J      $��4��5K      $��2��5L      ��5M      �� *Pret+�� 5O   
   -   5         ��Name$ btnAddJucarie��5O      $��Adauga��6(   
��� � �
�������$��5��5Q      $��2��6   $��84,22,84,22q�5R      	 � Cursor$
	 Hand��6&   64   5S      5T      