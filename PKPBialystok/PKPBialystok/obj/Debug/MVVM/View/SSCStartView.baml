   M S B A M L   `   `   `  ����G  CPKPBialystok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:PKPBialystok.MVVM.ViewPKPBialystok.MVVM.View  5      )    #PKPBialystok.MVVM.View.SSCStartView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:PKPBialystok.MVVM.View     5      .��5	      � 
������   � ColumnDefinitions  5
   
   �� 5      $	��400 �6   �� 5      .+�5   
   �� ���#4c3b4d$��0,0,10,0q�5      ._�5      �� 
������ $��Hidden=�5      $��Hidden=�5      ��.  ��5      �� *CategoryList+ �� SelectedItem 5      �� *SelectedCategory+��5      �� 5      .R�5      �� 5      ��5      �� 5      .R�5      �� $	��120��6    $	��375��5    !   ���	#44ADA8B6$��60(�5#   !   ���#4c3b4d$
��Left=�5%   !   $��	25,15,0,0q�5&   !   
������ $��0,2,0,0q�5(   !   ��5!   !   �� *Name+ J� InputBindings 5)      d� 5*   "    d� Gesture$ 	LeftClicka�5+   /    �� Command 5*   /   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� Path$' !DataContext.CategoryButtonCommand� �� CommandParameter 5,   /   �� 5.      51      53      55      �� 56   
   $��1��58      
������ $��Hidden=�5:      $��Hidden=�5;      ��.  ��56      �� *
DishList+ 57      �� *SelectedDish+��5=      �� 5>      .R�5?      �� 5@      ��5C      �� 5D      .R�5E      �� $	��370��6   $
��1485��5F      
������  5H      d� 5I      $ 	LeftClicka�5J   +    5I   +   ��  �� *FindAncestor+" ��$! DataContext.DishInfoCommand� 5K   +   �� ._�5M      �   5N      �� 5O   "   �� 5P   "   .+�5R      �� 
������ ���#4c3b4d$��0,0,10,0q�5T   %   ._�5U   "   �� $
��Fill=�5V   (   ��5U   (   �� *DishImage.Source+5V   (   5W      (� 5X      $��Center=�6&   $	��Top=�5Y   &   $��1��5Z   &   .��5[   "   �� 	 �� Orientation$	 Vertical=�6-   $	��700��6D   $	��400��6P   .+�5\   &   �� $��60(�60   $
��Wrap=�5]   0   ���#4c3b4d��5_   0   �� *Header+�� 5a   &   $
��Left=�60   $	��Top=�5b   0   $��25(�5c   0   $��0,20,0,0q�5d   0   $
��Wrap=�5e   0   ���#4c3b4d��5g   0   �� *Description+5h   #   5i      5j      5k      5m      5o      �� 5q   
   $��2��6   $��	0,0,0,100q�5s      ��5r      �� *CurrentView+5u      �� 5v   
   $��2��6   $	��100��5w      $��Bottom=�5x      ���	#66FFFFFFy�5z      �� *DetailBorder.Visibility+._�5{      �� $	 
Horizontal=�6   $��Right=�5|      $��0,0,20,0q�5}      .+�5~      �� $��80��6   $	��400��5      $��Cofnij��5�      $��Right=�5�      $��
0,10,10,10q�5�      $��30(�5�      ���#A53860���#4C3B4D��5�      �� *ExitDishInfoCommand+�� 5�      $��80��6   $	��400��5�      $��Dodaj do zamówienia��5�      $��Right=�5�      $��
0,10,10,10q�5�      $��30(�5�      ���#61c9a8���#4C3B4D��5�      �� *AddToCartCommand+5�      5�      5�      5�      