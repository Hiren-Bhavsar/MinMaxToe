   M S B A M L   `   `   `  ����D  @MinMaxToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MinMaxToe	MinMaxToe  5   	       MinMaxToe.Gameboard   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MinMaxToe     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	   ���#30343F � Title$ 	Gameboard��5   	   $	��500��6   $	��350��6(   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 	gamelabel��5      $��	MinMaxToe��6#   $��0��5      $��1��5      $��Center=�5      $��Center=�5      $��Center=�5      $��19(�5       $��DemiBold"�6   ���#12CAD6$��0,2,0,2q�5"      ���#FA163F5#      �� 5%   
   -   5        $ playerOnePoints��5%      $��P1: 0��6)   $��0��5&      $��0��5'      $��Center=�5(      $��Center=�5)      $��Center=�5*      $��20(�5+      $��DemiBold"�6   ���#12CAD6$��0,2,0,2q�5-      ���#495060���#FA163F5/      �� 51   
   -   5        $ playerTwoPoints��51      $��P2: 0��6)   $��0��52      $��2��53      $��Center=�54      $��Center=�55      $��Center=�56      $��20(�57      $��DemiBold"�6   ���#12CAD6$��0,2,0,2q�59      ���#FA163F5:      �� 5<   
   -   5         ��Name$ button0��5<      $�� ��6"   $��1��5=      $��0��6   $��Center=�5>      $��40(�5?      $��DemiBold"�6   
�������$��0,0,2,2q�5A      $��5,5,0,0q�5B      ���#FA163F���#30343F5E      �� 5G   
   -   5        $ button1��5G      $�� ��6"   $��1��5H      $��1��6   $��Center=�5I      $��40(�5J      $��DemiBold"�6   
�������$��2,0,2,2q�5L      $��0,5,0,0q�5M      ���#FA163F���#30343F5P      �� 5R   
   -   5        $ button2��5R      $�� ��6"   $��1��5S      $��2��6   $��Center=�5T      $��40(�5U      $��DemiBold"�6   
�������$��2,0,0,2q�5W      $��0,5,5,0q�5X      ���#FA163F���#30343F5[      �� 5]   
   -   5        $ button3��5]      $�� ��6"   $��2��5^      $��0��6   $��Center=�5_      $��40(�5`      $��DemiBold"�6   
�������$��0,2,2,2q�5b      $��5,0,0,0q�5c      ���#FA163F���#30343F5f      �� 5h   
   -	   5        $ button4��5h      $�� ��6"   $��2��5i      $��1��6   $��Center=�5j      $��40(�5k      $��DemiBold"�6   
�������$��2,2,2,2q�5m      $��0,0,0,0q�5n      ���#FA163F���#30343F5q      �� 5s   
   -
   5        $ button5��5s      $�� ��6"   $��2��5t      $��2��6   $��Center=�5u      $��40(�5v      $��DemiBold"�6   
�������$��2,2,0,2q�5x      $��0,0,5,0q�5y      ���#FA163F���#30343F5|      �� 5~   
   -   5        $ button6��5~      $�� ��6"   $��3��5      $��0��6   $��Center=�5�      $��40(�5�      $��DemiBold"�6   
�������$��0,2,2,0q�5�      $��5,0,0,5q�5�      ���#FA163F���#30343F5�      �� 5�   
   -   5        $ button7��5�      $�� ��6"   $��3��5�      $��1��6   $��Center=�5�      $��40(�5�      $��DemiBold"�6   
�������$��2,2,2,0q�5�      $��0,0,0,5q�5�      ���#FA163F���#30343F5�      �� 5�   
   -   5        $ button8��5�      $�� ��6"   $��3��5�      $��2��6   $��Center=�5�      $��40(�5�      $��DemiBold"�6   
�������$��2,2,0,0q�5�      $��0,0,5,5q�5�      ���#FA163F���#30343F5�      �� 5�   
   -   5        $ Reset��5�      $��Reset��6    $��4��5�      $��0��6   $��Center=�5�      $��Center=�5�      $��Center=�5�      $��40��5�      $��85��6   $��20(�5�      $��DemiBold"�5�      $	��0,2q�5�      ���#12CAD6���#FA163F���#30343F5�      �� 5�   
   -   5        $ MainMenu��5�      $
��Menu��6#   $��4��5�      $��2��6   $��Center=�5�      $��Center=�5�      $��Center=�5�      $��40��5�      $��85��6   $��20(�5�      $��DemiBold"�5�      $	��0,2q�5�      ���#12CAD6���#FA163F���#30343F5�      5�      5�      