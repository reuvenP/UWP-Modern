   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PL.ViewsPL.Views  5          PL.Views.CartView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:PL.Views     5        � 	Resources  5	      (   "PL.Views.ByteArrayToImageConverter   imageConverter=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell �� Triggers P� Property P� Value��%�  &	        '       '  �       5
   
   6*   �� 5   
   "  6   .�5      ��  � ��$ Center=�6<   �� 5       � ��$ 18(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � �� �	#FFFF1F1F6+   5      �� 5   
   "  6    5      P� 5       �@ 
IsSelected . . �5      ��  � �� �	#FFFF848463   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   �� $
��Cart��6   $��5q�6!   $��0��6,   $��18(�69   $
��Bold"�6G   .��5      &   System.Windows.Controls.DataGrid     RowBackground �	#FFA1B2D8	   AlternatingRowBackground	 �	#FFD7CEFF
   
IsReadOnly
 .    AutoGenerateColumns .     SelectionMode$ Extended=�6�   ��6h   �� *Cart+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem 6�   �� *SelectedBook+$ PropertyChanged=�$ TwoWay=�   Columns 5       4  .System.Windows.Controls.DataGridTemplateColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6-      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 310 6N      CanUserSort .    SortMemberPath$ Title��6m      SortDirection$ 	AscendingX�6�      CellTemplate 5"      �� 5#      .R�5$   "   �� .+�5%   &   ]� .+�5&   *   �� $
��Bold"�6}   $��Center=�6�   $��Center=�6�   $��0,30,0,0q�6�   ��64   �� *Title+$ PropertyChanged=�$ TwoWay=�6�   5'   '   5(   #   5)      5+        5,      $ Author��6-    . $	 310 6O    . $ Author��6n    5-      �� 5.      .R�5/   "   �� .+�50   &   ]� .+�51   *   �� $
��Bold"�6~   $��Center=�6�   $��Center=�6�   $��0,30,0,0q�6�   ��64   �� *Author+$ PropertyChanged=�$ TwoWay=�6�   52   '   53   #   54      56        57      $ Pages��6-    . $	 310 6N    . $ Pages��6m    58      �� 59      .R�5:   "   �� .+�5;   &   ]� {�.  .+�5<   *   �� $
��Bold"�6}   $��Center=�6�   $��Center=�6�   $��0,30,0,0q�6�   ��64   �� *Pages+$ PropertyChanged=�$ TwoWay=�6�   5=   '   5>   #   5?      5A        5B      $ Year Publication��6-    . $	 310 6Y    . $ YearPublication��6x    5C      �� 5D      .R�5E   "   �� .+�5F   &   ]� .+�5G   *   �� $
��Bold"�6�   $��Center=�6�   $��Center=�6�   $��0,30,0,0q�6�   ��64   �� *YearPublication+$ PropertyChanged=�$ TwoWay=�6�   5H   '   5I   #   5J      5L        5M      $ Image��6-    . $	 335 6N    5N      �� 5O      .R�5P   "   �� $	��100��6l   ��6(   �� *Image+ �� 	Converter# [  6l   5Q      5S      5U      5V      �� 5W   
   $��
Navigation��6   $��5,0,5,5q�6'   $��1��68   $��18(�6E   $
��Bold"�6S   .��5X      �  � ColumnDefinitions 5Y      �� 5Z      $��* �6'   �� 5[      $��* �6'   �� 5\      $��* �6'   .+�5^      �� $��14(�6   $
��Bold"�6'    � ToolTip$+ %Click to move back to the main Window��69   $��50��6i   $	��150��6u   $
��Back��6�   $��0��6�   ��6�   �� *DataContext.Nav2Back+ �� RelativeSource ��  �� AncestorType" �$ OneWay=��� 5_      $��14(�6   $
��Bold"�6'   $) #Click to remove this book from cart��69   $��50��6g   $	��150��6s   $��Remove From Cart��6   $��1��6�   ��6�   �� *RemoveFromCartCMD+$ PropertyChanged=�$ TwoWay=��� 5`      $��14(�6   $
��Bold"�6'   $ Click to Submit Order��69   $��50��6Y   $	��150��6e   $��Submit��6q   $��2��6�   ��6�   �� *DataContext.Nav3To4+ �� " �$ OneWay=�5a      5b      5c      5d      