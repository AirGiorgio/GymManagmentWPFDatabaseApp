   M S B A M L   `   `   `  ����M  IGym Managment Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Gym_Managment_TestGym_Managment_Test  5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4gHclr-namespace:Xceed.Wpf.Toolkit.Obselete;assembly=Xceed.Wpf.Toolkit.NET5Xceed.Wpf.Toolkit.Obselete 5   	   "    Gym_Managment_Test.SetPrices   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Gym_Managment_Test     5   	   YwpfxHclr-namespace:Xceed.Wpf.Toolkit.Obselete;assembly=Xceed.Wpf.Toolkit.NET5     5   	     � Title$  	SetPrices��5	   	   ���	#FF181545 � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��200 �6   �� 5      $	��200 �6   �� 5      $	��200 �6   �� 5      $	��200 �6    � ColumnDefinitions 5   
   �� 5      $	��500 �6   �� 5      $	��500 �6   �� 5      $	��500 �6   .+�5   
   �� ���	#FF4F33E1$��69,45,44,50q�6)    �� CornerRadius$	 100��6?   $��3��6R   $��4��6f   �� 5   
   $��36(�6   $
��Bold"�6   
�������$��Sitka Small)�6D   $��Italic$�6]   $��Cena za karnet Open: ��6p   $��306,69,280,76q�6�   $��2��6�   �� 5   
   $��36(�6   $
��Bold"�6   $��2��60   
�������$��Sitka Small)�6X   $��Italic$�6q   $��Cena za karnet Half-Open:��6�   $��212,154,280,191q�6�   $��2��6�   �� 5   
   $��36(�6   $
��Bold"�6   $��2��60   
�������$��Sitka Small)�6X   $��Italic$�6q   $��Cena za karnet Limited: ��6�   $��257,53,280,92q�6�   $��1��6�   �� 5   
   $��36(�6   $
��Bold"�6   $��2��60   
�������$��Sitka Small)�6X   $��Italic$�6q   $��Cena za karnet Student: ��6�   $��257,156,277,189q�6�   $��1��6�   $��2��6�   �� 5   
   $��36(�6   $
��Bold"�6   $��2��60   
�������$��Sitka Small)�6X   $��Italic$�6q   $!��Cena za trening personalny:��6�   $��179,162,280,184q�6�   $��2��6�   $��2��6�   �� 5   
   $��36(�6   $
��Bold"�6   $��2��60   
�������$��Sitka Small)�6X   $��Italic$�6q   $(��"Cena za konsultację dietetyczną:��6�   $��99,59,274,76q�6�   $��3��6�   �� 5    
   $��36(�6   $
��Bold"�6   $��2��60   
�������$��Sitka Small)�6X   $��Italic$�6q   $$��Cena za wejście jednorazowe: ��6�   $��155,55,277,90q�6�   $��2��6�   �� 5!   
   -   5         ��Name$ 	OpenPrice��5!      $��40(�6%   $
��Bold"�63   ���	#FFC63CA6$��1��6\   $��0,60,493,85q�6   $��1��6�   $��2��6�   $��Right=�6�   $	��254��6�   6�   �� 5"   
   -   5        $ HalfOpenPrice��5"      $��40(�6)   $
��Bold"�67   ���	#FFC63CA6$��2��6`   $��253,154,493,191q�6�   $��1��6�   $��2��6�   $��2��6�   6�   �� 5#   
   -   5        $ LimitedPrice��5#      $��40(�6(   $
��Bold"�66   ���	#FFC63CA6$��3��6_   $��253,46,493,100q�6�   $��1��6�   $��1��6�   $��2��6�   6�   �� 5$   
   -   5        $ StudentPrice��5$      $��40(�6(   $
��Bold"�66   ���	#FFC63CA6$��4��6_   $��255,150,493,195q�6�   $��1��6�   $��1��6�   $��2��6�   $��2��6�   6�   �� 5%   
   -   5        $ TrainingPrice��5%      $��40(�6)   $
��Bold"�67   ���	#FFC63CA6$��5��6`   $��257,156,493,189q�6�   $��1��6�   $��2��6�   $��2��6�   $��2��6�   6�   �� 5&   
   -   5        $ 	DietPrice��5&      $��40(�6%   $
��Bold"�63   ���	#FFC63CA6$��6��6\   $��260,58,490,86q�6   $��1��6�   $��3��6�   $��2��6�   6�   �� 5'   
   -   5        $ OneTimerPrice��5'      $��40(�6)   $
��Bold"�67   ���	#FFC63CA6$��7��6`   $��257,52,493,94q�6�   $��1��6�   $��2��6�   $��2��6�   6�   �� 5(   
   -   5         ��Name$
 Exit��5(      $��3��6   $��2��6,   $��80,19,80,65q�6<   ���	#FFB71090$��36(�6j   $
��Bold"�6x   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FF181545$��10q�6�   $��Zapisz i Wyjdź��6   � 	Resources 5)      	 �� 
TargetType
 �� Property �� Value��%_   '��       �� 5*      "	 ��6   .�5+      �� 
 �@��CornerRadius$ 40��65   5,      5-      5.      5/      50      