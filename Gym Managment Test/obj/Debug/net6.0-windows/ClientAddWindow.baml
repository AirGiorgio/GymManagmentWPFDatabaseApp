   M S B A M L   `   `   `  ����M  IGym Managment Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Gym_Managment_TestGym_Managment_Test  5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4gHclr-namespace:Xceed.Wpf.Toolkit.Obselete;assembly=Xceed.Wpf.Toolkit.NET5Xceed.Wpf.Toolkit.Obselete 5   	   b ^PresentationFramework.Aero2, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5      &     Gym_Managment_Test.ClientAddView   5   
   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Gym_Managment_Test     5   	   YwpfxHclr-namespace:Xceed.Wpf.Toolkit.Obselete;assembly=Xceed.Wpf.Toolkit.NET5     5   	   ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5        � Title$  	AddWindow��5	   	   ���	#FE181545 � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $	��210 �6   �� 5      $	��210 �6   �� 5      $	��210 �6   �� 5      $	��210 �6    � ColumnDefinitions 5   
   �� 5      $	��480 �6   �� 5      $	��480 �6   �� 5      $	��480 �6   .+�5   
   �� $��
20,0,10,10q�6   $��0��6)   $��0��66   .+�5      �� $��40q�6   
�������$��1q�68   $��Italic$�6L   $
��Bold"�6_   
�������$��Imię��6�   $��32(�6�   .��5      �� -   5         ��Name$
 Name��5      $��40(�6(   $
��Bold"�66   ���	#FFC63CA6$��1��6_   6�   5      5      �� 5   
   $��
20,0,10,10q�6   $��1��6)   $��0��66   .+�5       �� $��40q�6   
�������$��1q�68   $��Italic$�6L   $
��Bold"�6_   
�������$��Telefon��6�   $��32(�6�   .��5!      �� -   5        $ 	Telephone��5!      $��40(�6-   $
��Bold"�6;   ���	#FFC63CA6$��3��6d   6�   5"      5#      �� 5$   
   $��
20,0,10,10q�6   $��0��6)   $��1��66   .+�5%      �� $��40q�6   
�������$��1q�68   $��Italic$�6L   $
��Bold"�6_   
�������$��Nazwisko��6�   $��32(�6�   .��5&      �� -   5        $ Surname��5&      $��40(�6+   $
��Bold"�69   ���	#FFC63CA6$��2��6b   6o   5'      5(      �� 5)   
   $��
20,0,10,10q�6   $��1��6)   $��1��66   .+�5*      �� $��40q�6   
�������$��1q�68   $��Italic$�6L   $
��Bold"�6_   
�������$��PESEL��6�   $��32(�6�   .��5+      �� -   5        $ PESEL��5+      $��40(�6*   $
��Bold"�68   ���	#FFC63CA6$��4��6a   6�   5,      5-      �� 5.   
   -   5         ��Name$ Return��5.      $��3��6!   $��1��6.   $��50q�6>   ���	#FF4F33E1$��36(�6b   $
��Bold"�6p   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FFC63CA6$��5q�6�   $��18��6   � 	Resources 5/       �� 
TargetType	 �� Property
 �� Value��%_   '��       �� 50      " ��6   .�51      �� 	 �@��CornerRadius$
 40��65   52      53      .��6    	Powrót54      �� 55   
   -   5        $	 Add��55      $��3��6   $��0��6+   $��50q�6;   ���	#FF4F33E1$��36(�6_   $
��Bold"�6m   
�������$��Sitka Small)�6�   $��Italic$�6�   ���	#FFC63CA6$��5q�6�   $��17��6�    56      ��%_   '��       �� 57      " ��6   .�58      �� 	 �@��CornerRadius$
 40��65   59      5:      .��6    Dodaj5;      �� 5<   
   $��
20,0,10,10q�6   $��2��6)   $��1��66   .+�5=      �� -   5         ��Name$ combo��5=      $��40q�6&   
�������$��1q�6G   $��Italic$�6[   $
��Bold"�6n   
�������$��Kategoria karnetu��6�   $��32(�6�   .��5>      �� -   5         ��Name$ category��5>      $��40(�6.   $
��Bold"�6<   ���	#FFC63CA6
�������$��6��6y   6�   5?      5@      �� 5A   
   $��
20,0,10,10q�6   $��2��6)   $��0��66   .+�5B      �� $��40q�6   
�������$��1q�68   $��Italic$�6L   $
��Bold"�6_   
�������$��Data Urodzenia��6�   $��32(�6�   .��5C      .  (Xceed.Wpf.Toolkit.Obselete.MaskedTextBox  -	   5          Name$ 	BirthDate��5C   %      Mask$ 
0000-00-00��68   $��Sitka Small)�6J   $��40(�6c   ���	#FFC63CA6$
��Bold"�6�   $��5��6�   6�   5D      5E      �� 5F   
   $��0��6   $��2��6   $��4��6-   $-��'Image\Gym-Silhoutte-PNG-Transparent.png��6>   6q   5G      5H      