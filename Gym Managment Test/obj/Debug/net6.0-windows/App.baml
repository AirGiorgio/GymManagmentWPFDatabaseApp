   M S B A M L   `   `   `  ����M  IGym Managment Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Gym_Managment_TestGym_Managment_Test  5      b ^PresentationFramework.Aero2, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5          Gym_Managment_Test.App   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      2local clr-namespace:Gym_Managment_Test     5      ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5        �� 	Resources  5         FocusVisual �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground �� 
TargetType �� 
TargetType ��Name	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName 
 TextBox.Static.Background  ComboBoxEditableTextBox ��Name  ComboBox.Static.Background �� EndPoint �� 
StartPoint � Color � Offset  ComboBox.Static.Border  ComboBox.Static.Glyph ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border ! ComboBox.MouseOver.Background  ComboBox.MouseOver.Border  ComboBox.MouseOver.Glyph * &ComboBox.MouseOver.Editable.Background & "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Background  ComboBox.Pressed.Border  ComboBox.Pressed.Glyph ( $ComboBox.Pressed.Editable.Background $  ComboBox.Pressed.Editable.Border / +ComboBox.Pressed.Editable.Button.Background +  'ComboBox.Pressed.Editable.Button.Border  ! ComboBox.Disabled.Background " ComboBox.Disabled.Border # ComboBox.Disabled.Glyph )$ %ComboBox.Disabled.Editable.Background %% !ComboBox.Disabled.Editable.Border 0& ,ComboBox.Disabled.Editable.Button.Background ,' (ComboBox.Disabled.Editable.Button.Border ( ComboBoxToggleButton F�Name ^� 
Conditions �� Binding �� RelativeSource �� AncestorType �� Value ) ComboBoxEditableTemplate �Name � ColumnDefinitions �Name � AllowsTransparency5  /Microsoft.Windows.Themes.SystemDropShadowChrome  Name   Color �� MaxDropDownHeight  �� ElementName! �� ClearTypeHint" ��Name# ��Name$ ��Name-  'System.Windows.Input.KeyboardNavigation%   DirectionalNavigation& d�Name' d� 	IsChecked( �� Mode) ��Name* �� 
IsReadOnly+ P� 
SourceName, ]� 
Conditions- �� Property * ComboBoxTemplate#. �� SelectionBoxItemStringFormat/ �� ContentStringFormat0 �� SelectionBoxItemTemplate1 �� SelectionBoxItem2 J� IsHitTestVisible3 �� Triggers��%�5  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    '�� �    7   7  7  7  7  7  7  7  7  7 	 &	
 �    &	     &	 F	    &	 �	    &	 �	    &	 
    &	 ;
    &	 ^
    &	 �
    &	 �
    &	 D    &	 g    &	 �    &	 �    &	 �    &	 l    &	 �    &	 +    &	 N    &	 q    &	 �    &	 �    &	  S    &	! v    &	" �    &	# �    &	$ �    &	%     &	& %    &	' J    &	( o    7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7   7 # 7 ! 7 " 7 $ 7 % 7 & 7 ' &	) �    7 ( 7 
 7  &	* �'    7 ( '�� P0    7   7  7  7 * 7 ) �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FF181545��6>   �� 5   
   $ 	#FF4F33E1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      " ��6&   .R�5(      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $
 true��6�   ._�5)      �� $	 contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5*      
 5+      P� 5,       �@��IsDefaulted$
 true��6=   . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver$
 true��6=   . �50   "   �� $ border��6?   8   � ��6S   �� 51   "   $ border��6@   8   � ��6T   52      P� 53       � ��$
 true��6;   . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � {�$ false��6;   . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   �� 5:   "   $ contentPresenter��6K   8 	  � ��6i   5;      5=      5?      5@      �� 5B   
   $ White��6<   �� 5C   
   " ��60   .�5D      ��  �@�OverridesDefaultStyle$
 true��66   �� 5E       �@J�	AllowDrop$
 true��6*   �� 5F       � ��$ 0��6)   �� 5G       � ��$ 0��6*   �� 5H       �@�FocusVisualStyle 61   Z� �� 5I       �@��PanningMode$ VerticalFirst=�69   �� 5J       �@��IsFlicksEnabled$ False��67   �� 5K       � �� 5L      �� 5M      " ��6&   .R�5N      �� $ PART_ContentHost��6'   
������ $|�false��6Z   $��Hidden=�6l   $��Hidden=�6�   5O      5Q      5R      �� 5S   
   $	 0,1&�6A   $	 0,0&�6P   .��5T      � $ White��6   $	 0.0Q�6)   � 5U      $ White��6   $	 1.0Q�6)   5V      �� 5W   
   $ White��69   �� 5X   
   $ 	#FF606060��68   �� 5Y   
   $ White��6F   �� 5Z   
   $ 	#FFABADB3��6B   �� 5[   
   $ Transparent��6M   �� 5\   
   $ Transparent��6I   �� 5]   
   $	 0,1&�6D   $	 0,0&�6S   .��5^      � $ 	#FFECF4FC��6   $	 0.0Q�6-   � 5_      $ 	#FFDCECFC��6   $	 1.0Q�6-   5`      �� 5a   
   $ 	#FF7EB4EA��6<   �� 5b   
   $ 	#FF000000��6;   �� 5c   
   $ 	#FFFFFFFF��6I   �� 5d   
   $ 	#FF7EB4EA��6E   �� 5e   
   $	 0,1&�6T   $	 0,0&�6c   .��5f      � $ 	#FFEBF4FC��6   $	 0.0Q�6-   � 5g      $ 	#FFDCECFC��6   $	 1.0Q�6-   5h      �� 5i   
   $ 	#FF7EB4EA��6L   �� 5j   
   $	 0,1&�6B   $	 0,0&�6Q   .��5k      � $ 	#FFDAECFC��6   $	 0.0Q�6-   � 5l      $ 	#FFC4E0FC��6   $	 1.0Q�6-   5m      �� 5n   
   $ 	#FF569DE5��6:   �� 5o   
   $ 	#FF000000��69   �� 5p   
   $ 	#FFFFFFFF��6G   �� 5q   
   $ 	#FF569DE5��6C   �� 5r   
   $	 0,1&�6R   $	 0,0&�6a   .��5s      � $ 	#FFDAEBFC��6   $	 0.0Q�6-   � 5t      $ 	#FFC4E0FC��6   $	 1.0Q�6-   5u      �� 5v   
   $ 	#FF569DE5��6J   �� 5w   
   $ 	#FFF0F0F0��6?   �� 5x   
   $ 	#FFD9D9D9��6;   �� 5y   
   $ 	#FFBFBFBF��6:   �� 5z   
   $ 	#FFFFFFFF��6H   �� 5{   
   $ 	#FFBFBFBF��6D   �� 5|   
   $ Transparent��6O   �� 5}   
   $ Transparent��6K   �� 5~   
   " d�6-   .�5      ��  �@�OverridesDefaultStyle$
 true��66   �� 5�       � ��$ false��6*   �� 5�       � |�$ false��6*   �� 5�       �@��	ClickMode$ Press=�6*   �� 5�       � �� 5�      �� 5�      " d�6&   .R�5�      �� $ templateRoot��6!   8��  8�� #��z��6�   $
 true��6�   ._�5�      �� $ splitBorder��6%   
������ $��1q�6T   $��Right=�6h   $��0q�6�   $
 true��6�   #��� r�6�   ._�5�   "   F� $ arrow��6'   F����        ���( ��( јaQ     јaQ P����̰( � �    P����        8�� $��Center=�6�   $��0q�6�   $��Center=�6�   5�      5�      
 5�      ^� 5�       5�   "   �� 5�   &    60   �� *
IsEditable+ �� " �� true6�   �� 5�   &    60   �� *IsMouseOver+ �� *Self+	 false6v   �� 5�   &    60   �� *	IsPressed+ �� *Self+	 false6t   �� 5�   &    60   �� *	IsEnabled+ �� *Self+ true6t   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   �� 5�   "   $ splitBorder��6?   8   � ��6X   �� 5�   "   $ splitBorder��6@   8   � ��6Y   5�      P� 5�       �@J�IsMouseOver$
 true��6=   . �5�   "   �� $ arrow��69   8   � ��6L   5�      ^� 5�       5�   "   �� 5�   &    60   �� *IsMouseOver+ �� *Self+ true6v   �� 5�   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8 	  � ��6Z   5�      ^� 5�       5�   "   �� 5�   &    60   �� *IsMouseOver+ �� *Self+ true6v   �� 5�   &    60   �� *
IsEditable+ �� " �� true6�   .0�5�   "   �� $ templateRoot��6?   8 
  � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   �� 5�   "   $ splitBorder��6?   8   � ��6X   �� 5�   "   $ splitBorder��6@   8   � ��6Y   5�      P� 5�       � ��$
 true��6;   . �5�   "   �� $ arrow��69   8   � ��6L   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsPressed+ �� *Self+ true6t   �� 5�   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsPressed+ �� *Self+ true6t   �� 5�   &    60   �� *
IsEditable+ �� " �� true6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   �� 5�   "   $ splitBorder��6?   8   � ��6X   �� 5�   "   $ splitBorder��6@   8   � ��6Y   5�      P� 5�       � {�$ false��6;   . �5�   "   �� $ arrow��69   8   � ��6L   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsEnabled+ �� *Self+	 false6t   �� 5�   &    60   �� *
IsEditable+ �� " ��	 false6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   5�      ^� 5�       5�   "   �� 5�   &    60   �� *	IsEnabled+ �� *Self+	 false6t   �� 5�   &    60   �� *
IsEditable+ �� " �� true6�   .0�5�   "   �� $ templateRoot��6?   8   � ��6Y   �� 5�   "   $ templateRoot��6@   8   � ��6Z   �� 5�   "   $ splitBorder��6?   8   � ��6X   �� 5�   "   $ splitBorder��6@   8   � ��6Y   5�      5�      5�      5�      �� 5�   
   " ��6;   .R�5�      � $ templateRoot��6   $
 true��6)    5�      �� 5�      $��* �6'   �� 5�      #��� r�6'   $��0 �6z   .+�5�      � $ 
PART_Popup��6   $
 true��6,   $��2��6F   $��Bottom=�6�   #��� .�6�   ��6Z   �� *IsDropDownOpen+ �� *TemplatedParent+.��5�        $ shadow��63   $ Transparent��6C   #��z 6�   ��6W   �� *ActualWidth+$  templateRoot��._�5�      �� $ dropDownBorder��6!   #��� ��69   #��� ��6   $��1q�6�   ._�5�      �� $ DropDownScrollViewer��6+   .��5�   "   � $
 grid��6'   $! Enabled=�65   .+�5�   &   �� $" canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5�   *   �� $# 
opaqueRect��64   ��6H   �� *
Background+$  dropDownBorder����6�   �� *ActualHeight+$  dropDownBorder����6�   �� *ActualWidth+$  dropDownBorder��5�   '   �� 5�   &   $$ ItemsPresenter��65   $% 	Contained=�6M   # z 6�   5�   #   5�      5�      5�      5�      d� 5�      $& toggleButton��6   #��z��65   #��z��6_   #��z��6�   $��2��6�   8��  ' 6�   �� *IsDropDownOpen+$( TwoWay=� �� *TemplatedParent+66  �� 5�      $ border��6   8�� #��z��6a   ._�5�      �� $) PART_EditableTextBox��6   #��z��6<   #��z��6�   8�� #��z��6-  * 6�   �� *
IsReadOnly+ �� *TemplatedParent+6-  5�      5�      
 5�      P� 5�       � {�$ false��6/   . �5�      �� $ border��60    �@J�Opacity$
 0.56Q�6D   5�      P� 5�       �@J�IsKeyboardFocusWithin$
 true��6;   . �5�      ��  � ��
 �   �63   5�      P� 5�      $+ 
PART_Popup��63    �@�HasDropShadow$
 true��6K   . �5�      �� $ shadow��6/    � ��$ 0,0,5,5q�6C   �� 5�      $ shadow��6.    �@ Color$ 	#71000000��6B   5�      P� 5       �@��HasItems$ false��6.   . �5     �� $ dropDownBorder��6/    � ��$ 95��6K   5     ]� 5     , 5     �� 5     - �@��
IsGrouping$
 true��6:   �� 5     "- �@%�IsVirtualizingWhenGrouping$ false��6\   ./�5     ��  � ��$ false��6F   5	     P� 5
     $+ DropDownScrollViewer��6C    � ��$ false��6e   . �5     �� $ 
opaqueRect��63    6K   �� *VerticalOffset+$  DropDownScrollViewer�� �@��Top�� 5     $ 
opaqueRect��64    6L   �� *HorizontalOffset+$  DropDownScrollViewer�� �@��Left5     5     �� 5  
   " ��63   .R�5     � $ templateRoot��6   $
 true��6)    5     �� 5     $��* �6'   �� 5     #��� r�6'   $��0 �6z   .+�5     � $ 
PART_Popup��6   $
 true��6,   $��2��6F   $��1q�6�   $��Bottom=�6�   #��� .�6�   ��6Z   �� *IsDropDownOpen+$( TwoWay=� �� *TemplatedParent+.��5       $ shadow��63   $ Transparent��6C   #��z 6�   ��6W   �� *ActualWidth+$  templateRoot��._�5     �� $ dropDownBorder��6!   #��� ��69   #��� ��6   $��1q�6�   ._�5     �� $ DropDownScrollViewer��6+   .��5  "   � $
 grid��6'   $! Enabled=�65   .+�5  &   �� $" canvas��6-   $
��Left=�6=   $��0��6X   $	��Top=�6c   $��0��6{   .+�5  *   �� $# 
opaqueRect��64   ��6H   �� *
Background+$  dropDownBorder����6�   �� *ActualHeight+$  dropDownBorder����6�   �� *ActualWidth+$  dropDownBorder��5  '   �� 5  &   $$ ItemsPresenter��65   $% 	Contained=�6M   # z 6�   5  #   5      5!     5"     5#     d� 5$     $& toggleButton��6   #��z��65   #��z��6_   #��z��6�   $��2��6�   8��  ' 6�   �� *IsDropDownOpen+$( TwoWay=� �� *TemplatedParent+66  �� 5%     $	 contentPresenter��6#   #/ z. 6=   #��z0 6�   #��z1 6�   #��z��6�   #��z��6-  $2 false��6p  #��z��6�  # z 6�  #��z��6�  5&     
 5'     P� 5(     $+ 
PART_Popup��63    �@�HasDropShadow$
 true��6K   . �5)     �� $ shadow��6/    � ��$ 0,0,5,5q�6C   �� 5*     $ shadow��6.    �@ Color$ 	#71000000��6B   5+     P� 5,      �@��HasItems$ false��6.   . �5-     �� $ dropDownBorder��6/    � ��$ 95��6K   5.     ]� 5/     , 50     �� 51     - �@��
IsGrouping$
 true��6:   �� 52     "- �@%�IsVirtualizingWhenGrouping$ false��6\   ./�54     ��  � ��$ false��6F   55     P� 56     $+ DropDownScrollViewer��6C    � ��$ false��6e   . �57     �� $ 
opaqueRect��63    6K   �� *VerticalOffset+$  DropDownScrollViewer�� �@��Top�� 58     $ 
opaqueRect��64    6L   �� *HorizontalOffset+$  DropDownScrollViewer�� �@��Left59     5;     �� 5<  
   " ��6   .�5=     ��  �@�FocusVisualStyle8   61   �� 5>      � ��8  6+   �� 5?      � ��8  6,   �� 5@      � ��# � ��6+   �� 5A      � ��$ 1q�60   �� 5B      � ��$
 Auto=�6K   �� 5C      � ��$
 Auto=�6I   �� 5D      � ��$ 6,3,5,3q�6(   �� 5E      � ��$
 true��6>   �� 5F      �@��PanningMode$
 Both=�69   �� 5G      �@��IsFlicksEnabled$ False��67   �� 5H      � ��8  6)   3 5I     P� 5J      �@��
IsEditable$
 true��60   . �5K     ��  � ��$ false��62   �� 5L      � ��$ 2q�60   �� 5M      � ��8  61   5N     5P     5R     5S     