   M S B A M L   `   `   `  ����=  9UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UIUI  5   	       UI.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:UI     5   	     � Title$  MovilTravel��5   	   $��181.334��6   $��574.999��6.   $��15(�6>    � 
ResizeMode$ NoResize=�6L    � Icon$ Images/Icon.ico��6b   .��5
      �  � ShowGridLines . .+�5   
   �� -   5         ��Name$ label1��5      $4��.Seleccione sector en donde se encuentra usted.��6    $��
10,0,-10,0q�6Y   $��32.334��6m   $	��Top=�6}   �� 5   
   -   5        $ label2��5      $4��.Seleccione carpeta para crear planilla diaria.��6    $��10,32.334,-10,0q�6Y   $��29.667��6r   $	��Top=�6�   �� 5   
   -   5         ��Name$ cmbLocation��5      $
��24px��6(   $
��Left=�66   $��16.333,75.667,0,0q�6Q   $	��Top=�6l   $
��60px��6�   .@�5      �� $	��MCC��6    � ToolTip 5      �� 5      .+�5      �� Mall Costanera Center6;   5      5      �� 5      $	��PÑ��6    5      �� 5      .+�5      �� Portal Ñuñoa62   5      5      �� 5!      $	��ELL��6    5"      �� 5#      .+�5$      �� 
El LLano6.   5%      5'      5(      �� 5*   
   -   5         ��Name$ txtPath��5*      $
��Left=�6#   $
��24px��6>   $��76.333,75.667,0,0q�6L    �� TextWrapping$
 Wrap=�6g   $�� ��6{   $	��Top=�6�   	 �� 
IsReadOnly	 . $	��391��6�   
���   �6�   �� 5,   
   -   5        
 ��Name$
 	btnSearch��5,      ���#f0f0f0$
��Left=�69   $��472.333,75.667,0,0q�6T   $	��Top=�6p   $��75��6�   $
��24px��6�    J� Effect 5-      3  -System.Windows.Media.Effects.DropShadowEffect  5/         Color$ Black��6#      	Direction$	 320Q�61      ShadowDepth$ 1Q�6A      
BlurRadius$ 1Q�6Q      Opacity$	 1.0Q�6`   .��52      ��  �� TextAlignment$ Right=�6   $��Buscar��6.   53      �� 56   
   -   5        $
 	btnCreate��56      $��Crear��6$   ���#f0f0f0$
��Left=�6I   $��142.334,0,0,10q�6d   $��23��6|   $��75��6�   $��Bottom=�6�    57        58      $ Black��6#   $	 320Q�61   $ 1Q�6A   $ 1Q�6Q   $	 1.0Q�6`   5:      �� 5<   
   -   5        $
 	btnModify��5<      $��	Modificar��6$   ���#f0f0f0$��Right=�6M   $��0,0,193.332,10q�6i   $��23��6�   $��75��6�   $��Bottom=�6�    5=        5>      $ Black��6#   $	 320Q�61   $ 1Q�6A   $ 1Q�6Q   $	 1.0Q�6`   5@      5B      5D      