   M S B A M L   `   `   `  ����M  IGym Managment Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Gym_Managment_TestGym_Managment_Test  5   	   ,    &Gym_Managment_Test.FinancialStatistics   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Gym_Managment_Test     5   	     � Title$  FinancialStatistics��5   	   ���	#FF181545 � WindowState$ 	Maximized=�5
   	    � WindowStyle$
 None=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��200 �6   �� 5      $	��200 �6   �� 5      $	��200 �6    � ColumnDefinitions 5   
   �� 5      $	��800 �6   �� 5      $	��600 �6   .+�5   
   �� ���	#FF4F33E1$��69,45,44,50q�6)    �� CornerRadius$	 100��6?   $��3��6R   $��4��6f   �� 5   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Klientów ogółem:��6p   $��96,59,217,87q�6�   $��1��6�   �� 5   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Aktywnych karnetów: ��6p   $��24,135,218,199q�6�   $��1��6�   $��2��6�   �� 5   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Karnetów Open: ��6p   $��114,40,221,104q�6�   $��1��6�   $��1��6�   �� 5   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Karnetów Half-Open:��6p   $��34,133,220,12q�6�   $��1��6�   $��1��6�   �� 5   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Karnetów Limited:��6p   $��68,41,219,103q�6�   $��2��6�   $��1��6�   �� 5   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Karnetów Student:��6p   $��67,132,216,13q�6�   $��2��6�   $��1��6�   �� 5   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Sumaryczne dochody��6p   $��179,72,272,72q�6�   6�   �� 5   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Z karnetów:��6p   $��310,10,287,135q�6�   $��3��6�   �� 5    
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��	Z usług:��6p   $��372,82,284,62q�6�   $��3��6�   �� 5!   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Różnica przychodów: ��6p   $��168,30,284,114q�6�   $��2��6�   �� 5"   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Procent zmiany:��6p   $��240,119,284,26q�6�   $��2��6�    J� RenderTransformOrigin$ 0.795,1.507&�6�   �� 5#   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Sumaryczne dochody od��6p   $��125,55,284,91q�6�   $��1��6�   �� 5$   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��początku działalności:��6p   $��134,106,292,40q�6�   $��1��6�   �� 5%   
   -   5         ��Name$
 Exit��5%      $��3��6   $��1��6,   $��213,23,87,61q�6<   ���	#FFC642A6$��36(�6k   $
��Bold"�6y   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FF181545$��10q�6�   $��Wyjście��6   � 	Resources 5&      	 �� 
TargetType
 �� Property �� Value��%_   '��       �� 5'      "	 ��6   .�5(      �� 
 �@��CornerRadius$ 40��65   5)      5*      5+      �� 5,   
   -   5         ��Name$ ClientsTotal��5,      $��36(�6&   $
��Bold"�64   
�������$��Sitka Small)�6Z   $��Italic$�6s   $��X��6�   $��386,55,99,93q�6�   $��1��6�   �� 5-   
   -   5        $ ActivePasses��5-      $��36(�6&   $
��Bold"�64   
�������$��Sitka Small)�6Z   $��Italic$�6s   $��X��6�   $��382,130,71,18q�6�   $��1��6�   �� 5.   
   -   5        $ 
OpenPasses��5.      $��36(�6$   $
��Bold"�62   
�������$��Sitka Small)�6X   $��Italic$�6q   $��X��6�   $��376,36,77,112q�6�   $��1��6�   $��1��6�   �� 5/   
   -   5        $ HalfOpenPasses��5/      $��36(�6(   $
��Bold"�66   
�������$��Sitka Small)�6\   $��Italic$�6u   $��X��6�   $��376,130,77,18q�6�   $��1��6�   $��1��6�   �� 50   
   -   5        $ LimitedPasses��50      $��36(�6'   $
��Bold"�65   
�������$��Sitka Small)�6[   $��Italic$�6t   $��X��6�   $��376,36,77,112q�6�   $��1��6�   $��2��6�   �� 51   
   -   5        $ StudentPasses��51      $��36(�6'   $
��Bold"�65   
�������$��Sitka Small)�6[   $��Italic$�6t   $��X��6�   $��376,128,77,20q�6�   $��1��6�   $��2��6�   �� 52   
   -   5        $ FinancialMonth��52      $��30(�6(   $
��Bold"�66   
�������$��Sitka Small)�6\   $��Italic$�6u   $��X��6�   $��523,132,129,16q�6�   �� 53   
   -	   5        $ PassesTotal��53      $��30(�6%   $
��Bold"�63   
�������$��Sitka Small)�6Y   $��Italic$�6r   $��X��6�   $��536,10,117,135q�6�   $��3��6�   �� 54   
   -
   5        $ ServicesTotal��54      $��30(�6'   $
��Bold"�65   
�������$��Sitka Small)�6[   $��Italic$�6t   $��X��6�   $��537,83,116,65q�6�   $��3��6�   �� 55   
   -   5        $ FinancialDifference��55      $��30(�6-   $
��Bold"�6;   
�������$��Sitka Small)�6a   $��Italic$�6z   $��X��6�   $��534,30,119,118q�6�   $��2��6�   �� 56   
   -   5        $ PercentageDifference��56      $��30(�6.   $
��Bold"�6<   
�������$��Sitka Small)�6b   $��Italic$�6{   $��X��6�   $��534,119,119,29q�6�   $��2��6�   �� 57   
   -   5        $ FinancialTotal��57      $��30(�6(   $
��Bold"�66   
�������$��Sitka Small)�6\   $��Italic$�6u   $��X��6�   $��521,106,129,42q�6�   $��1��6�   �� 58   
   $��30(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��w tym miesiącu:��6p   $��230,132,298,12q�6�   59      5:      