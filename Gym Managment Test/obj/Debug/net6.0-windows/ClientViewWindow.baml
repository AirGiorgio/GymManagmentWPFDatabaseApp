   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   M IGym Managment Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Gym_Managment_TestGym_Managment_Test 5   	   )   #Gym_Managment_Test.ClientViewWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Gym_Managment_Test     5   	     � Title$  ClientViewWindow��5	   	   ���	#FF181545 � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��200 �6   �� 5      $	��200 �6   �� 5      $	��200 �6    � ColumnDefinitions 5   
   �� 5      $	��500 �6   �� 5      $	��500 �6   �� 5      $	��500 �6   .+�5   
   �� -   5         ��Name$ Return��5      $��3��6!   $��2��6.   $��100,30q�6>   ���	#FF4F33E1$��36(�6f   $
��Bold"�6t   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FFC63CA6$��5q�6�    � 	Resources 5       �� 
TargetType �� Property	 �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$	 40��65   5      5      .��6    	Powrót5      �� 5    
   -   5        $ Extendcarnet��5       $��3��6(   $��1��65   $��100,30q�6E   ���	#FF4F33E1$��36(�6m   $
��Bold"�6{   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FFC63CA6$��5q�6�    5!      ��%_   '��       �� 5"      " ��6   .�5#      ��  �@��CornerRadius$	 40��65   5$      5%      .��6    
Przedłuż5&      �� 5'   
   -   5        $	 Add��5'      $��1��6   $��2��6+   $��100,30q�6;   ���	#FF4F33E1$��36(�6c   $
��Bold"�6q   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FFC63CA6$��5q�6�    5(      ��%_   '��       �� 5)      " ��6   .�5*      ��  �@��CornerRadius$	 40��65   5+      5,      .��6    Dodaj5-      �� 5.   
   -   5        $
 Edit��5.      $��3��6   $��0��6,   $��100,30q�6<   ���	#FF4F33E1$��36(�6d   $
��Bold"�6r   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FFC63CA6$��5q�6�    5/      ��%_   '��       �� 50      " ��6   .�51      ��  �@��CornerRadius$	 40��65   52      53      .��6    Edytuj54      �� 55   
   -   5        $ Delete��55      $��2��6!   $��2��6.   $��100,30q�6>   ���	#FF4F33E1$��36(�6f   $
��Bold"�6t   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FFC63CA6$��5q�6�    56      ��%_   '��       �� 57      " ��6   .�58      ��  �@��CornerRadius$	 40��65   59      5:      .��6    Usuń5;      &   System.Windows.Controls.DataGrid  5<   
   -   5        
  Name$
 DataGridList��5<         AutoGenerateColumns$ False��6N      CanUserResizeRows$ False��6j      CanUserAddRows$ False��6�      CanUserSortColumns$
 True��6�      CanUserReorderColumns$ False��6�      SelectionMode$ Single=�6�      CanUserResizeColumns$ False��6�   $��2��6  $��50,50,50,50q�6  $��3��61  ���	#FFC63CA6$��3q�6Z  
����������	#FFC63CA6$
��Bold"�6�  $��16(�6�  $��Italic$�6�     Columns 5=      0  *System.Windows.Controls.DataGridTextColumn  5>      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6U      
FontFamily$ Sitka Small)�6`      
FontWeight$
 Bold"�6z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+ �� Mode$ OneWay=�6�     5?      $ Imię��6%   $	 150 6Y   $ Sitka Small)�6e   $
 Bold"�6    63   �� *Name+$ OneWay=�6�     5@      $ Nazwisko��6%   $	 150 6`   $ Sitka Small)�6l   $
 Bold"�6�    67   �� *	Surname+$ OneWay=�6�     5A      $ Telefon��6%   $	 110 6a   $ Calibri)�6m   $
 Bold"�6�    66   �� *	Telephone+$ OneWay=�6�     5B      $ Data urodzenia��6%   $	 150 6�   $ Calibri)�6�   $
 Bold"�6�    6=   �� *	BirthDate+ �� StringFormat$ {0:dd/MM/yyyy}��$ OneWay=�6�     5C      $ Typ karnetu��6%   $	 130 6d   $ Calibri)�6p   $
 Bold"�6�    6:   �� *
PassType+$ OneWay=�6�     5D      $ Karnet ważny do��6%   $	 150 6�   $ Calibri)�6�   $
 Bold"�6�    6>   �� *	ExpDate+$ {0:dd/MM/yyyy}��$ OneWay=�6�    5F       �� Color��%Z   (��       5G   "   * SystemColors.HighlightBrushKey+)�� 6   $ 	#FF4F33E1��5H      5I      5J      �� 5K   
   $��0��6   $��2��6"   $��10,40,10,10q�62   .+�5L      �� $��36(�6   $
��Bold"�6"   
�������$��Sitka Small)�6H   $��Italic$�6a   .��6u   Wyszukaj nazwisko :6�   �� 5M      -   5         ��Name$ 	SearchBox��5M      $��
40,10,40,0q�6W   $��40(�6k   $
��Bold"�6y   ���	#FFC63CA6���	#FFC63CA6$��5q�6�   .��6�   ��5N      �� 5O       �� ImageSource$ Image/1.png��6!    �� Opacity$ 1Q�6<    �� 	Transform 5P      V� 5Q      .~�5R   "   ��  �� ScaleX$ 1Q�61     �� ScaleY$  1Q�6<   �� 5S   "   �� 5T   "   T� 5U   "   ! T� X$! 1Q�65   " T� Y$" 0Q�6;   5V      5X      .��5Y   &   5Z      5[      5\      5]      