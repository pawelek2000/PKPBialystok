   M S B A M L   `   `   `  ����G  CPKPBialystok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PKPBialystok.WindowsPKPBialystok.Windows  5   	   I)clr-namespace:PKPBialystok.MVVM.ViewModelPKPBialystok.MVVM.ViewModel  5   	   -    'PKPBialystok.Windows.OrderDisplayWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PKPBialystok.Windows     5   	   ?	viewModel)clr-namespace:PKPBialystok.MVVM.ViewModel     5   	     � WindowState$  	Maximized=�5	   	    � WindowStyle$
 None=�5
   	   ���#FFEEDB � DataContext 5      7  1PKPBialystok.MVVM.ViewModel.OrderDisplayViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��10 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��150 �6   �� 5      .+�5   
   �� $��0��6   $��3��5      ���#4C3B4D$��
10,10,10,0q�5      ._�5       �� $��..\Images\PKPLogo.png��6   $
��Left=�5!      $��	10,10,0,0q�5"      5#      �� 5%   
   $��1��6   $��3��5&      ���#ADA8B6���#4C3B4D$��10,10,10,10q�5)      �� 5+   
   $��1��6   $��1��5,      $��2��5-      ���#4C3B4D5.      �� 50   
   $��0��6   $��2��51      $��3��52      ���#4C3B4D$��
10,0,10,10q�54      �� 55   
   $��1��6   $��Przygotowywane��56      $��Center=�57      $��Center=�58      $��80(�59      ���#4C3B4D5:      �� 5;   
   $��1��6   $��2��5<      $��Gotowe��5=      $��Center=�5>      $��Center=�5?      $��80(�5@      ���#4C3B4D5A      �� 5D   
   $��3��6   ��5E      �� *Orders+��5F      �� 5G      .R�5H      � $��	72,50,0,0q�6    5I      ��5K      �� 5L      .R�5M      �� $	��120��6   $	��120��5N      ���#A53860$��20q�5P       �� CornerRadius$ 30��5Q      ._�5S      �� $��60(�5T   $   $��Center=�5U   $   $��Center=�5V   $   ���#ffeedb��5S       �� *	OrderID+5W   $   5X      5Y      5[      �� 5]   
   $��3��6   $��3��5^      ��5_      �� *
DoneOrders+��5`      �� 5a      .R�5b      � $��	72,50,0,0q�6    5c      ��5e      �� 5f      .R�5g      �� $	��120��6   $	��120��5h      ���#61C9A8$��20q�5j      $ 30��5k      ._�5m      �� $��60(�5n   $   $��Center=�5o   $   $��Center=�5p   $   ���#ffeedb��5m       �� *	OrderID+5q   $   5r      5s      5u      5w      5x      