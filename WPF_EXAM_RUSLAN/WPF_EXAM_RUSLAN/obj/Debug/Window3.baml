   M S B A M L   `   `   `  ����J  FWPF_EXAM_RUSLAN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPF_EXAM_RUSLANWPF_EXAM_RUSLAN  5   	       WPF_EXAM_RUSLAN.Window3   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WPF_EXAM_RUSLAN     5   	     � Title$  Window3��5   	   $��283.103��6   $��275.862��6*    � 	Resources 5	         geometryPath E� IsClosed E� 
StartPoint � Points��%�   &	        B� 5
   
   .��5      E�  . $ 10, 10&�6)   .��5      � ; �   ��� -1 h�	 �� h�	 �� ' �� �����67   5      5      5      .��5      �� ��5   
   
� 5      .��5      �  � Color$ Black��6    � Offset$ 0.683Q�6-   � 5      $ 	#FF080C0B��6   $ 0.177Q�61   � 5      $ 	#FE8F8753��6   $ 1Q�61   � 5      $ 	#FE8A8250��6   $ 0.924Q�61   5      .+�5   
   F� 
���  ��#��[  6   
 �� Top$ 10��6A    �� Left$ 10��6Q   A� 5   
   $��15��6   $��15��6   $	 177��6)   $	 120��6:   ��5      
� 5      	 
� RadiusX$	 1Q�6&   
 
� RadiusY$
 1Q�62    
� GradientOrigin$ 0.3, 0.3&�6>   .��5      � $ White��6#   $ 0Q�61   � 5      $ Black��6#   $ 1Q�61   5       � Triggers 5!      :� 5"       :� RoutedEvent$ Window.Loaded��6   .[�5#      �� .��5$      �� .��5%      T�  �� TargetProperty$ (Canvas.Top)�67    g� Duration$ 0:0:5D�5&   (    g� RepeatBehavior$ Forever��69    T� PathGeometry# [  5'   (    T� Source$ Y=�6U   5(      T� 5)      $ (Canvas.Left)�67   $ 0:0:5D�5*   (   $ Forever��69   # [  5+   (   $ X=�6U   5,      5-      5.      5/      51      52      53      