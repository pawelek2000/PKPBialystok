   M S B A M L   `   `   `  ����G  CPKPBialystok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:PKPBialystok.MVVM.ViewPKPBialystok.MVVM.View  5      .    (PKPBialystok.MVVM.View.AvailableMenuView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:PKPBialystok.MVVM.View     5      .��5	      � 
������   � ColumnDefinitions  5
   
   �� 5      $	��400 �6   �� 5      .+�5   
   �� ���#4c3b4d$��0,0,10,0q�5      ._�5      �� 
������ $��Hidden=�5      $��Hidden=�5      ��.  ��5      �� *CategoryList+ �� SelectedItem 5      �� *SelectedCategory+��5      �� 5      .R�5      �� 5      ��5      �� 5      .R�5      �� $	��120��6    $	��375��5    !   ���	#44ADA8B6$��60(�5#   !   ���#4c3b4d$
��Left=�5%   !   $��	25,15,0,0q�5&   !   
������ $��0,2,0,0q�5(   !   ��5!   !   �� *Name+ J� InputBindings 5)      d� 5*   "    d� Gesture$ 	LeftClicka�5+   /    �� Command 5*   /   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� Path$' !DataContext.CategoryButtonCommand� �� CommandParameter 5,   /   �� 5.      51      53      55      �� 56   
   -   5        	 ��Name$	 MyItems��56      $��1��59      
������ $��Hidden=�5;      $��Hidden=�5<      ��.  ��57      �� *
DishList+ 58      �� *SelectedDish+��5>      �� 5?      .R�5@      �� 5A      ��5D      �� 5E      .R�5F      �� $	��200��6   $
��1385��5G      
������ ._�5J      �   5L      �� 5M   "   �� 5N   "   �� 5O   "   .+�5R      �� $��3��6%   ���	#804c3b4dy�5T   %   �� *	Available+�� 5V      
������ ���#4c3b4d$��0,0,10,0q�5X   %   ._�5Y   "   �� $
��Fill=�5Z   (   ��5Y   (   �� *DishImage.Source+5Z   (   5[      (� 5\      $��Center=�6&   $	��Top=�5]   &   $��1��5^   &   .��5_   "   �� 
 �� Orientation$
 Vertical=�6-   $	��700��6D   $	��400��6P   .+�5`   &   �� $��60(�60   $
��Wrap=�5a   0   ���#4c3b4d��5c   0   �� *Name+5f   #   5g      �� 5h      $��50��6%   $	��300��5i   )   $��Zmień dostepność��5j   )   $��2��5k   )   $��Center=�5l   )   $��28(�5m   )   ���#61C9A8���#4C3B4D��5p   )   ��  �� ElementName$ MyItems��$( "DataContext.SwitchAvailableCommand���5q   )   �� 5r      5s      5u      5w      5y      5z      