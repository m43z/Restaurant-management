   M S B A M L   `   `   `  ����T  PRestaurant_ManagementFull, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Restaurant_ManagementFullRestaurant_ManagementFull  5   	   .    (Restaurant_ManagementFull.AddCustomerWnd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Restaurant_ManagementFull     5   	   -   5          � AllowsTransparency  .  � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ AddCustomerWnd��5   	   $��RightToLeft=�5   	   $��vazir)�5   	   $	��400��5   	   $	��300��5   	   .��5      �  � RowDefinitions 5      �� 5      $��30 �6   �� 5      �� 5      $��60 �6   .+�5      �� ���	#FFF8C822._�5      � .+�5   
   �� -   5         ��Name$ TxbTitleCustomer��5   ]   $-��'اضافه کردن مشتری جدید��6   $��Center=�61   $��7,0,0,0q�6L   6]   5   	   5      �� 5      $��1��6   
���   �$��1q�6.   $��8q�6B    �� CornerRadius$ 5��6M   ._�5      �� $��Center=�6   .+�5!   
   ��  �� Orientation$ 
Horizontal=�6   $��Right=�6.   $��0 20 0 0q�6J   .+�5"      �� $��نام :��6   $	��5 0q�6#   $��Center=�60   �� 5#      -   5        	 ��Name$	 TxtFirstName��5#      $	��180��6*   5$      �� 5&   
   $ 
Horizontal=�6   $��Right=�6.   $��0 20 0 0q�6J   .+�5'      �� $��نام خانوادگی :��6   $	��5 0q�6,   $��Center=�69   �� 5(      -   5        $	 TxtLastName��5(      $	��180��6)   5)      �� 5+   
   $ 
Horizontal=�6   $��Right=�6.   $��0 20 0 0q�6J   .+�5,      �� $�� جنسیت :��6   $	��5 0q�6&   $��Center=�63   �� 5-      -   5        
 ��Name$
 	CmbGender��5-      $	��180��6(    �� SelectedValuePath$ Id��64    �� DisplayMemberPath$ Title��6K   5.      �� 50   
   $ 
Horizontal=�6   $��Right=�6.   $��0 20 0 0q�6J   .+�51      �� $��موبایل :��6   $	��5 0q�6&   $��Center=�63   �� 52      -   5        $	 	TxtMobile��52      $	��180��6'   53      �� 56   
   $ 
Horizontal=�6   $��Right=�6.   $��0 20 0 0q�6J   .+�57      �� $��
آدرس :��6   $	��5 0q�6$   $��Center=�61   �� 58      -   5        $	 
TxtAddress��58      $	��180��6(   $��90��64   59      5;   	   5<      �� 5A      $��2��6   ���	#FFF8C822._�5B      �� $��2��6   $��7q�6   
���   �$��1q�6;   $ 5��6O   ._�5C   
   � .+�5D      �� $ 
Horizontal=�6   $��Center=�60   .+�5E      �� -   5        
���   �$��40��5F      $��40��6   ��5E      Z� ��6+   Z� ��5G      �� 5H      .+�5I      �� $��Save.png��6   $��25��6,   $��25��67   �� 5J      $��ذخیره کردن��6   $��8(�60   5K      5M      �� 5O      -	   5         �� IsCancel . 
���   �$��40��5P   #   $��40��6.   $��	160 0 0 0q�6:   ��5O      Z� ��6+   Z� ��5Q      �� 5R      .+�5S      �� $��
cANCEL.png��6   $��25��6.   $��25��69   �� 5T      $��انصراف��6   $��8(�6,   5U      5W      5Z      5[      5\   	   5]      5^      5_      