   M S B A M L   `   `   `  ����C  ?EventMap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EventMap.Front.ViewEventMap.Front.View  5      '    !EventMap.Front.View.ShowAllEvents   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:EventMap.Front.View     5        N� 
Background
  ����� N� Title$ ShowAllEvents��5
      .��5      � .+�5   
   �� 
�������$��0,0,-2,0q�61    �� Orientation$ 
Horizontal=�6C   $	��Top=�6\   $��50��6t   .+�5      �� -   5        $
��Back��5      $��70��6$   $��15,2,0,5q�6/   $��40��6A   
���  ��6b   �� 5      -   5        $
��Home��5      $��70��6$   $��40��6/   $��15,2,0,5q�6;   
��� � �6a   �� 5      -   5        $��	Selection��5      $��70��6)   $��40��64   $��15,2,0,5q�6@   
����  �6e   �� 5      -   5        $
��Help��5      $��70��6$   $��40��6/   $��15,2,0,5q�6;   
���iii�6c   �� 5      -   5        $��Tutorial��5      $��70��6(   $��40��63   $��15,2,0,5q�6?   
����p��6l   5      � 5   
   $��	10,49,0,0q�6   .+�5      �� -   5        $��
EventsList��5   D   
������$��19,91,22,28q�6/   ��6V   �� *Events+ �� View 5      �� 5      .P�5      �� $	��Tag��6)    �� Width$ 60��6^    �� DisplayMemberBinding 66   �� *Oznaka+6^   �� 5      $
��Name��6)   $	 100��6^    67   �� *Naziv+6^   �� 5      $��
Event type��6)   $ 70��6h    6=   �� *	TipOznaka+6h   �� 5      $��
Visitation��6)   $ 80��6i    6=   �� *
Posecenost+6i   �� 5      $
��City��6)   $ 75��6]    67   �� *Grad+6]   �� 5       $��Country��6)   $ 75��6b    6:   �� *Drzava+6b   �� 5"      $��Humanitarian��6)   $	  85��6?    �� CellTemplate 5#      �� 5$   "   .R�5%   &   �� ��5&   *   �� 5'   .    �� 
TargetType" ��64    �� Triggers 5(   2   �� 5)   6   	 �� Binding	 6B   �� *Humanitarni+
 �� Value
 True6b   .a�5*   :   ��  �� Property � �� �� Value$ Jeste��6Q   5+   7   �� 5,   6   	 6B   �� *Humanitarni+	
 False6b   .a�5-   :   ��  � ��$
 Nije��6Q   5.   7   50   /   52   '   53   #   55      �� 57      $��Avg cost ($)��6)   $ 86��6o    6?   �� *ProsecanTrosak+6o   �� 58      $
��Date��6)   $	 120��6h    67   �� *DatumOdrzavanja+6h   59      ��5;      �� 5<      " ��6   .�5=      ��  � ��$ Disabled=�6W   5>      5@      �� 5D      -   5         ��Name$ FilterTextBox��5D      $�� ��6-   $
��Left=�65   $��
600,26,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��168��6�   $��29��6�   6�   �� 5E      -   5        
����d�$��open search��5E   1   $
��Left=�6G   $��
510,26,0,0q�6b   $	��Top=�6v   $��29��6�   $��74��6�   6�   5G      �� 5H   
   $
��Left=�6   $��	537,8,0,0q�6/   $
��Wrap=�6B   $��
All Events��6V   $	��Top=�6h   $��25(�6�   $
��Bold"�6�   �� 5I   
   -	   5        $��	Add Event��5I      
��� � �$��30,71,707,344q�69   $��35��6P   6\   �� 5J   
   -
   5         ��Name$ ChangeButton��5J      $��Change��6'   
��� ���$��112,71,624,344q�6L   $��35��6d   6p   �� 5K   
   -   5        $��DetailsButton��5K      $��Details��6&   
�������$��193,71,545,344q�6K   $��35��6c   6o   �� 5L   
   -   5        $��DeleteButton��5L      $��Delete��6%   
���  ��$��278,71,460,344q�6G   $��35��6_   6k   5O      5P      