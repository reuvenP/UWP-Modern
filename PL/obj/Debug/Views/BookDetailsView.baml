   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PL.ViewsPL.Views  5          PL.Views.BookDetailsView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:PL.Views     5        � 	Resources  5	      (   "PL.Views.ByteArrayToImageConverter   imageConverter��%   &	          5
   
   6*   5      .��5      � ���	#FFD8D8D8 J� OpacityMask# � ��6"    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   �� $��Book Details��6   $��5q�6)   $��0��64   $��18(�6A   $
��Bold"�6O   .��5      �  5      �� 5      $��5* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   .+�5      �� $��0��6   ��6%   �� *SelectedBook.Image+ �� 	Converter# [  ]� 5      $��1��6   $��Center=�6)   .+�5      �� $��	Title:   ��6    $��Center=�61   $
��Bold"�6L   $��18(�6^   ���	#FFBD197A6l   �� 5      $��Center=�6i   $
��Bold"�6�   $��14(�6�   ��6    �� *SelectedBook.Title+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5      ]� 5      $��2��6   $��Center=�6)   .+�5       �� $��
Author:   ��6    $��Center=�62   $
��Bold"�6M   $��18(�6_   ���	#FFBD197A6m   �� 5!      $��Center=�6j   $
��Bold"�6�   $��14(�6�   ��6    �� *SelectedBook.Author+$ PropertyChanged=�6�   5"      ]� 5#      $��3��6   $��Center=�6)   .+�5$      �� $��	Pages:   ��6    $��Center=�61   $
��Bold"�6L   $��18(�6^   ���	#FFBD197A6l   �� 5%      $��Center=�6i   $
��Bold"�6�   $��14(�6�   ��6    �� *SelectedBook.Pages+$ PropertyChanged=�6�   5&      ]� 5'      $��4��6   $��Center=�6)   .+�5(      �� $��Year Publication:   ��6    $��Center=�6<   $
��Bold"�6W   $��18(�6i   ���	#FFBD197A6w   �� 5)      $��Center=�6s   $
��Bold"�6�   $��14(�6�   ��6    �� *SelectedBook.YearPublication+$ PropertyChanged=�6�   5*      5+      5,      �� 5-   
   $��
Navigation��6   $��5,0,5,5q�6'   $��1��68   $��18(�6E   $
��Bold"�6S   .��5.      �  � ColumnDefinitions 5/      �� 50      $��* �6'   �� 51      $��* �6'   �� 52      $��* �6'   .+�54      ��  � ToolTip$+ %Click to move back to the main Window��6   $��50��6I   $	��150��6U   $
��Back��6b   $��0��6q   $��14(�6�   $
��Bold"�6  ��6�   �� *DataContext.Nav2Back+ �� RelativeSource ��  �� AncestorType" �	 �� Mode$	 OneWay=�6  �� 55      $, &Click to Move to add this book to cart��6   $��50��6J   $	��150��6V   $��Add To Cart��6c   $��1��6y   $��14(�6  $
��Bold"�6  ��6�   �� *DataContext.AddToCartCMD+ �� " �$	 OneWay=�6  �� 56      $&  Click to Move to the cart Window��6   $��50��6D   $	��150��6P   $��
Go To Cart��6]   $��2��6r   $��14(�6�   $
��Bold"�6  ��6�   �� *DataContext.GoToCartCMD+ �� " �$	 OneWay=�6  57      58      59      5:      