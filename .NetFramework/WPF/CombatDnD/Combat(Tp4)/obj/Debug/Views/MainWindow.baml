   M S B A M L   `   `   `  ����F  BCombat(Tp4), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Combat_Tp4_Combat_Tp4_  5   	       Combat_Tp4_.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Combat_Tp4_     5   	   -   5          � Title$  
MainWindow��5   	   $��1072.822��6   $��1312.078��6.   .��5	      � -   5         �Name$ 	grdArène��5	      $��3,0,-3,0q�6    � ColumnDefinitions 5
   
   �� 5      $
��226* �6   �� 5      $	��31* �6   �� 5      $	��51* �6   �� 5      $
��242* �6   �� 5      $	��29* �6   �� 5      $	��51* �6   �� 5      $
��232* �6   �� 5      $	��29* �6   �� 5      $	��52* �6   �� 5      $
��239* �6   �� 5      $	��29* �6   �� 5      $	��50* �6   �� 5      $	��43* �6   ��5   
   �� 5       �� ImageSource$2 ,/Combat(Tp4);component/Images/Background.jpg��6    � RowDefinitions 5   
   �� 5      $
��115* �6   �� 5      $	��80* �6   �� 5      $	��40* �6   �� 5       $
��474* �6   �� 5!      $	��83* �6   �� 5"      $	��40* �6   �� 5#      $
��210* �6   .+�5%   
   �� -   5         ��Name$ imgCombattant_2��5%      $
��Left=�6*   $	��187��6E   $��
84,433,0,0q�6R   $	��Top=�6f   $	��125��6~   $-��'/Combat(Tp4);component/Images/Carte.jpg��6�   $��3��6�   $��4��6�   �� 5&   
   -   5        $ imgCombattant_4��5&      $
��Left=�6)   $	��187��6D   $��100,433,0,0q�6Q   $	��Top=�6f   $	��125��6~   $-��'/Combat(Tp4);component/Images/Carte.jpg��6�   $��3��6�   $��3��6�   $��4��6�   �� 5'   
   -   5        $ imgCombattant_6��5'      $
��Left=�6)   $	��187��6D   $��
89,433,0,0q�6Q   $	��Top=�6e   $	��125��6}   $-��'/Combat(Tp4);component/Images/Carte.jpg��6�   $��3��6�   $��6��6�   $��4��6�   �� 5(   
   -   5        $ imgCombattant_8��5(      $
��Left=�6)   $	��187��6D   $��
88,433,0,0q�6Q   $	��Top=�6e   $	��125��6}   $-��'/Combat(Tp4);component/Images/Carte.jpg��6�   $��3��6�   $��9��6�   $��4��6�   �� 5)   
   -   5        $ imgCombattant_1��5)      $
��Left=�6)   $	��187��6D   $��	84,73,0,0q�6Q   $	��Top=�6d   $	��125��6|   $-��'/Combat(Tp4);component/Images/Carte.jpg��6�   $��4��6�   �� 5*   
   -   5        $ imgCombattant_3��5*      $
��Left=�6*   $	��187��6E   $��
100,73,0,0q�6R   $	��Top=�6f   $	��125��6~   $-��'/Combat(Tp4);component/Images/Carte.jpg��6�   $��4��6�   $��3��6�   �� 5+   
   -	   5        $ imgCombattant_5��5+      $
��Left=�6)   $	��187��6D   $��	89,73,0,0q�6Q   $	��Top=�6d   $	��125��6|   $-��'/Combat(Tp4);component/Images/Carte.jpg��6�   $��4��6�   $��6��6�   �� 5,   
   -
   5        $ imgCombattant_7��5,      $
��Left=�6)   $	��187��6D   $��	88,73,0,0q�6Q   $	��Top=�6d   $	��125��6|   $-��'/Combat(Tp4);component/Images/Carte.jpg��6�   $��4��6�   $��9��6�   �� 5-   
   $��Att :��6   $
��Left=�6    $��32��6;   $��221,465,0,0q�6G   $	��Top=�6\   $��34��6t   $��3��6   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5.   
   $��Déf :��6   $
��Left=�6    $��32��6;   $��
221,19,0,0q�6G   $	��Top=�6[   $��34��6s   $��4��6~   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5/   
   -   5         ��Name$ lblAttCombattant_2��5/      $��Att :��6,   $
��Left=�6<   $��32��6W   $��221,465,0,0q�6c   $	��Top=�6x   $��34��6�   $��3��6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 50   
   -   5        $ lblDéfCombattant_2��50      $��Déf :��6,   $
��Left=�6<   $��32��6W   $��
221,19,0,0q�6c   $	��Top=�6w   $��34��6�   $��4��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 51   
   -   5        $ lblLvlCombattant_2��51      $��Lvl :��6,   $
��Left=�6<   $��34��6W   $��
221,44,0,0q�6c   $	��Top=�6w   $��34��6�   $��4��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 52   
   -   5        $ lblAttCombattant_4��52      $��Att :��6,   $
��Left=�6<   $��31��6W   $��237,469,0,0q�6c   $	��Top=�6x   $��34��6�   $��3��6�   $��3��6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 53   
   -   5        $ lblDéfCombattant_4��53      $��Déf :��6,   $
��Left=�6<   $��32��6W   $��
237,22,0,0q�6c   $	��Top=�6w   $��34��6�   $��4��6�   $��3��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 54   
   -   5        $ lblLvlCombattant_4��54      $��Lvl :��6,   $
��Left=�6<   $��33��6W   $��
237,45,0,0q�6c   $	��Top=�6w   $��34��6�   $��4��6�   $��3��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 55   
   -   5        $ lblAttCombattant_6��55      $��Att :��6,   $
��Left=�6<   $��32��6W   $��228,471,0,0q�6c   $	��Top=�6x   $��32��6�   $��3��6�   $��6��6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 56   
   -   5        $ lblDéfCombattant_6��56      $��Déf :��6,   $
��Left=�6<   $��32��6W   $��
228,19,0,0q�6c   $	��Top=�6w   $��32��6�   $��4��6�   $��6��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 57   
   -   5        $ lblLvlCombattant_6��57      $��Lvl :��6,   $
��Left=�6<   $��34��6W   $��
228,43,0,0q�6c   $	��Top=�6w   $��32��6�   $��4��6�   $��6��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 58   
   -   5        $ lblAttCombattant_8��58      $��Att :��6,   $
��Left=�6<   $��32��6W   $��235,468,0,0q�6c   $	��Top=�6x   $��32��6�   $��3��6�   $��9��6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 59   
   -   5        $ lblDéfCombattant_8��59      $��Déf :��6,   $
��Left=�6<   $��32��6W   $��
235,19,0,0q�6c   $	��Top=�6w   $��32��6�   $��4��6�   $��9��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5:   
   -   5        $ lblLvlCombattant_8��5:      $��Lvl :��6,   $
��Left=�6<   $��34��6W   $��
235,43,0,0q�6c   $	��Top=�6w   $��32��6�   $��4��6�   $��9��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5;   
   -   5        $ lblAttCombattant_1��5;      $��Att :��6,   $
��Left=�6<   $��33��6W   $��221,106,0,0q�6c   $	��Top=�6x   $��33��6�   $��2��6�   $��2��6�   ���	#FFEE1313$
��Bold"�6�   �� 5<   
   -   5        $ lblDéfCombattant_1��5<      $��Déf :��6,   $
��Left=�6<   $��33��6W   $��
221,19,0,0q�6c   $	��Top=�6w   $��33��6�   $��1��6�   $��2��6�   ���	#FFEE1313$
��Bold"�6�   �� 5=   
   -   5        $ lblLvlCombattant_1��5=      $��Lvl :��6,   $
��Left=�6<   $��33��6W   $��
221,48,0,0q�6c   $	��Top=�6w   $��33��6�   $��1��6�   $��2��6�   $��2��6�   ���	#FFEE1313$
��Bold"�6�   �� 5>   
   -   5        $ lblAttCombattant_3��5>      $��Att :��6,   $
��Left=�6<   $��33��6W   $��237,106,0,0q�6c   $	��Top=�6x   $��33��6�   $��2��6�   $��3��6�   $��2��6�   ���	#FFEE1313$
��Bold"�6�   �� 5?   
   -   5        $ lblDéfCombattant_3��5?      $��Déf :��6,   $
��Left=�6<   $��33��6W   $��
237,19,0,0q�6c   $	��Top=�6w   $��33��6�   $��1��6�   $��3��6�   $��2��6�   ���	#FFEE1313$
��Bold"�6�   �� 5@   
   -   5        $ lblLvlCombattant_3��5@      $��Lvl :��6,   $
��Left=�6<   $��33��6W   $��
237,48,0,0q�6c   $	��Top=�6w   $��33��6�   $��1��6�   $��3��6�   $��2��6�   $��2��6�   ���	#FFEE1313$
��Bold"�6�   �� 5A   
   -   5        $ lblAttCombattant_5��5A      $��Att :��6,   $
��Left=�6<   $��33��6W   $��228,106,0,0q�6c   $	��Top=�6x   $��33��6�   $��2��6�   $��6��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5B   
   -   5        $ lblDéfCombattant_5��5B      $��Déf :��6,   $
��Left=�6<   $��33��6W   $��
228,19,0,0q�6c   $	��Top=�6w   $��33��6�   $��1��6�   $��6��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5C   
   -   5        $ lblLvlCombattant_5��5C      $��Lvl :��6,   $
��Left=�6<   $��33��6W   $��
228,48,0,0q�6c   $	��Top=�6w   $��33��6�   $��1��6�   $��6��6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5D   
   -    5        $ lblAttCombattant_7��5D      $��Att :��6,   $
��Left=�6<   $��33��6W   $��235,107,0,0q�6c   $	��Top=�6x   $��33��6�   $��2��6�   $��9��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5E   
   -!   5        $ lblDéfCombattant_7��5E      $��Déf :��6,   $
��Left=�6<   $��33��6W   $��
235,20,0,0q�6c   $	��Top=�6w   $��33��6�   $��1��6�   $��9��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5F   
   -"   5        $ lblLvlCombattant_7��5F      $��Lvl :��6,   $
��Left=�6<   $��33��6W   $��
235,49,0,0q�6c   $	��Top=�6w   $��33��6�   $��1��6�   $��9��6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5G   
   -#   5         ��Name$ txtAttCombattant_2��5G      $
��Left=�6.   $��18��6I    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $��32��6�   	 �� TextAlignment$	 Center=�6�   $��4��6�   $��2��6�   
 �� 
IsReadOnly
 . 6�   �� 5H   
   -$   5        $ txtDéfCombattant_2��5H      $
��Left=�6.   $��18��6I   $��0,26,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��4��6�   $��2��6�   
 . 6�   �� 5I   
   -%   5        $ txtLvlCombattant_2��5I      $
��Left=�6.   $��16��6I   $��0,52,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��4��6�   $��2��6�   
 . 6�   �� 5J   
   -&   5        $ txtAttCombattant_4��5J      $
��Left=�6.   $��18��6I   $��	0,473,0,0q�6U   $
 Wrap=�6h   $	��Top=�6|   $��32��6�   $	 Center=�6�   $��3��6�   $��5��6�   
 . $��2��6�   �� 5K   
   -'   5        $ txtDéfCombattant_4��5K      $
��Left=�6.   $��18��6I   $��0,26,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��4��6�   $��5��6�   
 . 6�   �� 5L   
   -(   5        $ txtLvlCombattant_4��5L      $
��Left=�6.   $��16��6I   $��0,50,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��4��6�   $��5��6�   
 . 6�   �� 5M   
   -)   5        $ txtAttCombattant_6��5M      $
��Left=�6.   $��18��6I   $��0,1,0,0q�6U   $
 Wrap=�6f   $	��Top=�6z   $��32��6�   $	 Center=�6�   $��4��6�   $��8��6�   
 . 6�   �� 5N   
   -*   5        $ txtDéfCombattant_6��5N      $
��Left=�6.   $��18��6I   $��0,24,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��4��6�   $��8��6�   
 . 6�   �� 5O   
   -+   5        $ txtLvlCombattant_6��5O      $
��Left=�6.   $��16��6I   $��0,50,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��4��6�   $��8��6�   
 . 6�   �� 5P   
   -,   5        $ txtAttCombattant_8��5P      $
��Left=�6.   $��18��6I   $��1,0,0,0q�6U   $
 Wrap=�6f   $	��Top=�6z   $��32��6�   $��4��6�   $	 Center=�6�   $��11��6�   
 . 6�   �� 5Q   
   --   5        $ txtDéfCombattant_8��5Q      $
��Left=�6.   $��18��6I   $��1,22,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $��4��6�   $	 Center=�6�   $��11��6�   
 . 6�   �� 5R   
   -.   5        $ txtLvlCombattant_8��5R      $
��Left=�6.   $��16��6I   $��1,48,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $��4��6�   $	 Center=�6�   $��11��6�   
 . 6�   �� 5S   
   -/   5        $ txtAttCombattant_1��5S      $
��Left=�6.   $��17��6I   $
 Wrap=�6U   $	��Top=�6i   $��32��6�   $	 Center=�6�   $��1��6�   $��2��6�   
 . 6�   �� 5T   
   -0   5        $ txtDéfCombattant_1��5T      $
��Left=�6.   $��17��6I   $��0,26,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��1��6�   $��2��6�   
 . 6�   �� 5U   
   -1   5        $ txtLvlCombattant_1��5U      $
��Left=�6.   $��17��6I   $��0,53,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��1��6�   $��2��6�   
 . 6�   �� 5V   
   -2   5        $ txtAttCombattant_3��5V      $
��Left=�6.   $��17��6I   $��0,2,0,0q�6U   $
 Wrap=�6f   $	��Top=�6z   $��32��6�   $	 Center=�6�   $��1��6�   $��5��6�   
 . 6�   �� 5W   
   -3   5        $ txtDéfCombattant_3��5W      $
��Left=�6.   $��17��6I   $��0,28,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��1��6�   $��5��6�   
 . 6�   �� 5X   
   -4   5        $ txtLvlCombattant_3��5X      $
��Left=�6.   $��17��6I   $��0,53,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��1��6�   $��5��6�   
 . 6�   �� 5Y   
   -5   5        $ txtAttCombattant_5��5Y      $
��Left=�6.   $��17��6I   $��0,2,0,0q�6U   $
 Wrap=�6f   $	��Top=�6z   $��32��6�   $��1��6�   $��8��6�   
 . $	 Center=�6�   �� 5Z   
   -6   5        $ txtDéfCombattant_5��5Z      $
��Left=�6.   $��17��6I   $��0,28,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��1��6�   $��8��6�   
 . 6�   �� 5[   
   -7   5        $ txtLvlCombattant_5��5[      $
��Left=�6.   $��17��6I   $��0,53,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $	 Center=�6�   $��1��6�   $��8��6�   
 . 6�   �� 5\   
   -8   5        $ txtAttCombattant_7��5\      $
��Left=�6.   $��17��6I   $
 Wrap=�6U   $	��Top=�6i   $��32��6�   $��1��6�   $��11��6�   
 . $	 Center=�6�   �� 5]   
   -9   5        $ txtDéfCombattant_7��5]      $
��Left=�6.   $��17��6I   $��0,26,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $��1��6�   $��11��6�   
 . $	 Center=�6�   �� 5^   
   -:   5        $ txtLvlCombattant_7��5^      $
��Left=�6.   $��17��6I   $��0,51,0,0q�6U   $
 Wrap=�6g   $	��Top=�6{   $��32��6�   $��1��6�   $��11��6�   
 . $	 Center=�6�   �� 5_   
   $
��Left=�6   $��85��6+   $��
25,169,0,0q�67   $	��Top=�6K   $��88��6c   $/��)/Combat(Tp4);component/Images/Vesrsus.png��6n   $��3��6�   $��5��6�   $��2��6�   �� 5`   
   -;   5        $ lblPvCombattant_1��5`      $
��Pv :��6+   $
��Left=�6:   $��
221,73,0,0q�6U   $��33��6i   $��1��6t   $��2��6�   $��2��6�   ���	#FFEE1313$
��Bold"�6�   $��33��6�   $	��Top=�6�   �� 5a   
   -<   5        $ lblExpCombattant_1��5a      $��Exp :��6,   $
��Left=�6<   $��33��6W   $��
221,19,0,0q�6c   $	��Top=�6w   $��33��6�   $��2��6�   $��2��6�   $��2��6�   ���	#FFEE1313$
��Bold"�6�   �� 5b   
   -=   5        $ lblPvCombattant_3��5b      $
��Pv :��6+   $
��Left=�6:   $��33��6U   $��
237,73,0,0q�6a   $	��Top=�6u   $��33��6�   $��1��6�   $��3��6�   $��2��6�   $��2��6�   ���	#FFEE1313$
��Bold"�6�   �� 5c   
   ->   5        $ lblExpCombattant_3��5c      $��Exp :��6,   $
��Left=�6<   $��33��6W   $��
237,19,0,0q�6c   $	��Top=�6w   $��33��6�   $��2��6�   $��3��6�   $��2��6�   $��2��6�   ���	#FFEE1313$
��Bold"�6�   �� 5d   
   -?   5        $ lblPvCombattant_5��5d      $
��Pv :��6+   $
��Left=�6:   $��229,73,0,14q�6U   $��33��6j   $��1��6u   $��6��6�   $��3��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5e   
   -@   5        $ lblExpCombattant_5��5e      $��Exp :��6,   $
��Left=�6<   $��33��6W   $��
229,19,0,0q�6c   $	��Top=�6w   $��33��6�   $��2��6�   $��6��6�   $��3��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5f   
   -A   5        $ lblPvCombattant_7��5f      $
��Pv :��6+   $
��Left=�6:   $��33��6U   $��
235,73,0,0q�6a   $	��Top=�6u   $��33��6�   $��1��6�   $��9��6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5g   
   -B   5        $ lblExpCombattant_7��5g      $��Exp :��6,   $
��Left=�6<   $��33��6W   $��
235,19,0,0q�6c   $	��Top=�6w   $��33��6�   $��2��6�   $��9��6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5h   
   -C   5        $ lblPvCombattant_2��5h      $
��Pv :��6+   $
��Left=�6:   $��33��6U   $��
221,74,0,0q�6a   $	��Top=�6u   $��33��6�   $��4��6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5i   
   -D   5        $ lblExpCombattant_2��5i      $��Exp :��6,   $
��Left=�6<   $��33��6W   $��221,17.197,0,0q�6c   $	��Top=�6{   $��33��6�   $��5��6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5j   
   -E   5        $ lblPvCombattant_4��5j      $
��Pv :��6+   $
��Left=�6:   $��33��6U   $��
237,79,0,0q�6a   $	��Top=�6u   $��33��6�   $��4��6�   $��2��6�   $��3��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5k   
   -F   5        $ lblExpCombattant_4��5k      $��Exp :��6,   $
��Left=�6<   $��33��6W   $��
237,22,0,0q�6c   $	��Top=�6w   $��33��6�   $��5��6�   $��2��6�   $��3��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5l   
   -G   5        $ lblPvCombattant_6��5l      $
��Pv :��6+   $
��Left=�6:   $��33��6U   $	��Top=�6a   $��33��6y   $��4��6�   $��6��6�   $��2��6�   $��
228,74,0,0q�6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5m   
   -H   5        $ lblExpCombattant_6��5m      $��Exp :��6,   $
��Left=�6<   $��33��6W   $	��Top=�6c   $��33��6{   $��5��6�   $��6��6�   $��2��6�   $��
228,17,0,0q�6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5n   
   -I   5        $ lblPvCombattant_8��5n      $
��Pv :��6+   $
��Left=�6:   $��33��6U   $��4��6`   $��9��6m   $��
235,79,0,0q�6}   $��2��6�   $��2��6�   $��33��6�   $	��Top=�6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5o   
   -J   5        $ lblExpCombattant_8��5o      $��Exp :��6,   $
��Left=�6<   $��33��6W   $	��Top=�6c   $��33��6{   $��5��6�   $��9��6�   $��
235,22,0,0q�6�   $��2��6�   $��2��6�   $
��Bold"�6�   ���	#FFEE13136�   �� 5p   
   -K   5         ��Name$ btnDémarrer��5p      $��
_Démarrer��6&   $
��Left=�6:   $��60��6U   $��	0,106,0,0q�6a   $��6��6t   $	��Top=�6�   $	��166��6�    J� RenderTransformOrigin$ 1.319,0.633&�6�   $��3��6�   $��4��6�   ���	#FF875CE4$��15(�6  $
��Bold"�6  6$  �� 5q   
   -L   5         ��Name$ chkCombatsRapide��5q      $��Combats Rapide��6-   $��6��6F   $
��Left=�6V   $��37��6q   $��110,129,0,0q�6}   $��6��6�   $	��Top=�6�   $	��141��6�   $ -0.224,0.323&�6�   $��15(�6�   $��2��6�   ���	#FFFBFBFB$
��Bold"�6!  �� 5r   
   -M   5        $ txtPvCombattant_1��5r      $
��Left=�6-   $��17��6H   $
 Wrap=�6T   $	��Top=�6h   $��32��6�   $	 Center=�6�   $��2��6�   $��2��6�   
 . 6�   �� 5s   
   -N   5        $ txtExpCombattant_1��5s      $
��Left=�6.   $��17��6I   $
 Wrap=�6U   $	��Top=�6i   $��41��6�   $	 Center=�6�   $��2��6�   $��2��6�   
 . $��0,23,0,0q�6�   �� 5t   
   -O   5        $ txtPvCombattant_3��5t      $
��Left=�6-   $��17��6H   $
 Wrap=�6T   $	��Top=�6h   $��32��6�   $	 Center=�6�   $��2��6�   $��5��6�   
 . 6�   �� 5u   
   -P   5        $ txtExpCombattant_3��5u      $
��Left=�6.   $��17��6I   $
 Wrap=�6U   $	��Top=�6i   $��41��6�   $	 Center=�6�   $��2��6�   $��5��6�   
 . $��0,23,0,0q�6�   �� 5v   
   -Q   5        $ txtPvCombattant_5��5v      $
��Left=�6-   $��17��6H   $
 Wrap=�6T   $	��Top=�6h   $��32��6�   $	 Center=�6�   $��2��6�   $��8��6�   
 . $��1,0,0,0q�6�   �� 5w   
   -R   5        $ txtExpCombattant_5��5w      $
��Left=�6.   $��17��6I   $
 Wrap=�6U   $	��Top=�6i   $��41��6�   $	 Center=�6�   $��2��6�   $��8��6�   
 . $��1,23,0,0q�6�   �� 5x   
   -S   5        $ txtPvCombattant_7��5x      $
��Left=�6-   $��17��6H   $
 Wrap=�6T   $	��Top=�6h   $��32��6�   $	 Center=�6�   $��2��6�   $��11��6�   
 . 6�   �� 5y   
   -T   5        $ txtExpCombattant_7��5y      $
��Left=�6.   $��17��6I   $
 Wrap=�6U   $	��Top=�6i   $��40��6�   $	 Center=�6�   $��2��6�   $��11��6�   
 . $��0,23,0,0q�6�   �� 5z   
   -U   5        $ txtPvCombattant_8��5z      $
��Left=�6-   $��17��6H   $
 Wrap=�6T   $	��Top=�6h   $��32��6�   $	 Center=�6�   $��5��6�   $��11��6�   
 . $��1,0,0,0q�6�   �� 5{   
   -V   5        $ txtExpCombattant_8��5{      $
��Left=�6.   $��17��6I   $
 Wrap=�6U   $	��Top=�6i   $��39��6�   $	 Center=�6�   $��5��6�   $��11��6�   
 . $��1,23,0,0q�6�   �� 5|   
   -W   5        $ txtPvCombattant_6��5|      $
��Left=�6-   $��17��6H   $
 Wrap=�6T   $	��Top=�6h   $��32��6�   $	 Center=�6�   $��5��6�   $��8��6�   
 . 6�   �� 5}   
   -X   5        $ txtExpCombattant_6��5}      $
��Left=�6.   $��17��6I   $
 Wrap=�6U   $	��Top=�6i   $��42��6�   $	 Center=�6�   $��5��6�   $��8��6�   
 . $��0,23,0,0q�6�   �� 5~   
   -Y   5        $ txtPvCombattant_4��5~      $
��Left=�6-   $��17��6H   $
 Wrap=�6T   $	��Top=�6h   $��32��6�   $	 Center=�6�   $��5��6�   $��5��6�   
 . 6�   �� 5   
   -Z   5        $ txtExpCombattant_4��5      $
��Left=�6.   $��17��6I   $
 Wrap=�6U   $	��Top=�6i   $��41��6�   $	 Center=�6�   $��5��6�   $��5��6�   
 . $��0,23,0,0q�6�   �� 5�   
   -[   5        $ txtPvCombattant_2��5�      $
��Left=�6-   $��17��6H   $
 Wrap=�6T   $	��Top=�6h   $��32��6�   $	 Center=�6�   $��5��6�   $��2��6�   
 . $��2,0,0,0q�6�   �� 5�   
   -\   5        $ txtExpCombattant_2��5�      $
��Left=�6.   $��17��6I   $
 Wrap=�6U   $	��Top=�6i   $��39��6�   $	 Center=�6�   $��5��6�   $��2��6�   
 . $��2,23,0,0q�6�   5�      5�      