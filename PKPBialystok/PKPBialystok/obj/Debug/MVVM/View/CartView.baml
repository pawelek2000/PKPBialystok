   M S B A M L   `   `   `  ����G  CPKPBialystok, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:PKPBialystok.MVVM.ViewPKPBialystok.MVVM.View  5      %    PKPBialystok.MVVM.View.CartView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:PKPBialystok.MVVM.View     5      
������ .��5
      � .+�5   
   �� $��25,25,25,100q�6   $��10q�5      ���#4C3B4D  �� CornerRadius$  10��5      ._�5      �� -   5         ��Name$ MyItems��5      $��1��5      
������ $��Hidden=�5      $��Hidden=�5      ��.  ��5      �� *
CartList+ �� SelectedItem 5      �� *SelectedDish+��5      �� 5      .R�5      �� $	��185��6!   $
��1785��5      
������ ._�5      �  � ColumnDefinitions 5   "   �� 5   &   $��2* �67   �� 5    &   $��5* �67   �� 5!   &   $��1* �67   .+�5#   "   �� 
������ ���#4c3b4d$��0,0,10,0q�5%   %   ._�5&   &   �� $
��Fill=�5'   (   ��5&   ,   �� *DishImage.Source+5'   (   5(   #   �� 5*   "    �� Orientation$ Vertical=�6-   $��20,0,0,0q�5+   -   $��1��5,   -   .+�5-   &   �� $��40(�60   $
��Wrap=�5.   ,   ���#4c3b4d��50   ,   �� *Header+�� 52   &   $
��Left=�60   $	��Top=�53   ,   $��20(�54   ,   $��0,20,0,0q�55   ,   $
��Wrap=�56   ,   ���#4c3b4d��58   ,   �� *Description+5;   #   �� 5<   "   $��50��6)   $��50��5=   )   $��X��5>   )   $��2��5?   )   $��Right=�5@   )   $��10,0,0,0q�5A   )   $��28(�5B   )   ���#A53860���#4C3B4D��5E   )   ��  �� ElementName$ MyItems�� �� Path$ DataContext.DeleteCommand���5F   )   �� 5H      5I      5J      ��5L      �� 5M      .R�5N      �� 5O      5R      5T      �� 5U   
   $��Do zapłaty: 348��6   $
��Left=�5V      $��Bottom=�5W      $��Center=�5X      $��50(�5Y      $��80��5Z      $	��700��5[      $��	50,0,0,15q�5\      ���#4C3B4D5]      5^      5_      