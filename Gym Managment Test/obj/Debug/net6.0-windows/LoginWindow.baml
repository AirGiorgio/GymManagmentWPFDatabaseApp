   M S B A M L   `   `   `  ����M  IGym Managment Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Gym_Managment_TestGym_Managment_Test  5   	   $    Gym_Managment_Test.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Gym_Managment_Test     5   	   -   5          � Title$  LoginWindow��5   	   $
��1000��5	   	   $	��800��5
   	    � WindowStyle$
 None=�5   	   ���	#FF181545.��5      �  � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��350 �6   �� 5      $	��150 �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��400 �6   �� 5      $	��200 �6   .+�5   
   �� $��1��6   $��1��6   ���	#FFB71090$��10q�6E    �� CornerRadius$ 50��6R   6g   �� 5   
   $��1��6   $��1��6"   $��10q�62   .+�5      �� $��Login��6   
�������$
��Bold"�67   $��48(�6I   $��Sitka Small)�6W   $��Center=�6q   �� 5      ���	#FF181545z�5      �� 5       �� ScaleY$ 5Q�6%   5       �� 5!      -   5         ��Name$ 	Userlabel��5!      $��Użytkownik��6'   
�������$��Sitka Small)�6O   $
��Bold"�6h   $��18(�6z   6�   �� 5"      -   5         ��Name$
 User��5"      $��	10,0,10,0q�6$   $��32(�67   ���	#FF4F33E1
�������6q   �� 5#      -   5        $ 	Passlabel��5#      $��Hasło��6'   
�������$
��Bold"�6J   $��Sitka Small)�6\   $��18(�6u   6�   G� 5$      -   5         G�Name$ Password��5$      $��	10,0,10,0q�6,   $��32(�6?   ���	#FF4F33E16g   �� 5%      $��	40,20,0,0q�6   .+�5&      �  5'      �� 5(      $	��150 �6+   �� 5)      $	��150 �6+    5+      �� 5,      $��40 �6)   .+�5.      �� -   5        	 ��Name$	 Login��5.      $��0��6-   $��0,0,10,0q�6=   ���	#FF4F33E1$��24(�6h   $
��Bold"�6v   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FF181545$��5q�6�   
 � 	Resources
 5/       �� 
TargetType �� Property �� Value��%_   '��       �� 50      " ��6$   .�51   "   ��  �@��CornerRadius$ 20��6A   52      53      .��6,   	Zaloguj55      �� 56      -   5        $
	 Exit��56      $��1��6,   $��10,0,0,0q�6<   ���	#FF4F33E1$��24(�6f   $
��Bold"�6t   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FF181545$��5q�6�   
 57      ��%_   '��       �� 58      " ��6$   .�59   "   ��  �@��CornerRadius$ 20��6A   5:      5;      .��6,   
Wyjście5<      5=      5>      5?      �� 5@   
   -   5        $ Errorlbl��5@      $��1��6"   $$��Nieprawidłowe dane logowania!��6/   ���	#FFE3FF16$��16(�6n   $��80,308,80,10q�6|   $��1��6�   5A      5B      