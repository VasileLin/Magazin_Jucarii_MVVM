   M S B A M L   `   `   `  ����I  EMagazinJucarii, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MagazinJucariiMagazinJucarii  5   	       MagazinJucarii.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MagazinJucarii     5   	     � Title$  Meniu��5   	   $	��650��6   $	��500��6$    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 23,10,23,10q�6'   �� 5       � ��
 �**��6+   �� 5       � ��
 �����6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��99* �6   �� 5      $
��302* �6   �� 5      $	��99* �6   .+�5"   
   �� $��1��6   $��Meniul Aplicatiei��5#      
������$��Center=�5%      $��Center=�5&      $��23(�5'      $��31��6"   $	��172��6.   �� 5)   
   -   5         ��Name$ btnAddJucarii��5)      $��Adauga Jucarii��6(   $��1��5*      $��1��6!   ��5+      �� *AddJucarieCommand+�� 5-   
   -   5        $ btnViewJucarii��5-      $��Vizualizeaza Jucarii��6)   $��1��5.      $��2��6!   ��5/      �� *ShowJucarii+�� 51   
   -   5        $ btnAddComenzi��51      $��Adauga Comanda��6(   $��1��52      $��3��6!   ��53      �� *AddComandaCommand+�� 55   
   -   5        $ btnViewComenzi��55      $��Vizualizeaza Comenzile��6)   $��1��56      $��4��6!   ��57      �� *ShowComenzi+�� 59   
   -   5        $ btnViewComenziPret��59      $��1��5:      $��5��6!   $��23,10,23,10q�5;   5   ��6   �� *ShowComenziPret+.��5<      �� $
��Wrap=�6    �� TextAlignment$ Center=�6,   $@��:Vizualizeaza comenzile cu suma cuprinsa intre 30 si 50 lei��6C   5=      �� 5?   
   -   5        $ btnViewJucariiSuma��5?      $��1��5@      $��6��6!   $��23,10,23,10q�5A   <   ��6   �� *ShowJucariiSumaCommand+.��5B      �� $
��Wrap=�6   $ Center=�6,   $7��1Vizualizeaza suma vanzarilor per fiecare jucarie ��6C   5C      �� 5E   
   -   5        $ btnViewComenziData��5E      $��1��5F      $��7��6!   $��23,10,23,10q�5G   <   ��6   �� *ShowComenziDataCommand+.��5H      �� $
��Wrap=�6   $ Center=�6,   $8��2Lista comenzilor efectuate intre anii 2019 si 2022��6C   5I      �� 5K   
   -   5        $ btnJucariiVarstaData��5K      $��1��5L      $��8��6!   $��23,10,23,10q�5M   >   ��6   �� *ShowJucariiVarstaCommand+.��5N      �� $
��Wrap=�6   $ Center=�6,   $=��7Lista jucariilor recomandate copiilor de la 7 la 10 ani��6C   5O      5P      5Q      