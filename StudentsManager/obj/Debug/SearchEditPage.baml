   M S B A M L   `   `   `  ����J  FStudentsManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:StudentsManagerStudentsManager  5   	   $    StudentsManager.SearchEditPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:StudentsManager     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullZ VMaterialDesignThemes.MahApps, Version=0.1.4.1513, Culture=neutral, PublicKeyToken=nullHmaterialdesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      -   5        $	��600��5      $
��1024��6'     � 
ResizeMode$  NoResize=�64    � WindowStyle$
 None=�6J    � WindowStartupLocation$ CenterScreen=�6t   .��5	      �� ���	#FF622F96.+�5
   
   � $��20q�6   $	��Top=�6   
�������$	��560��6F   .+�5      ��  �� Orientation$ 
Horizontal=�6   $	��Top=�62   $��40��6J   $��Right=�6V   $��10q�6r   .+�5      �� -   5         ��Name$ 
backButton��5       0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6-   $��30��6s   $
��Auto��6~   $��0q�6�   
���   �$��0,0,0,10q�6�   ��6�   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ArrowBackCircle=�6.   5      5      �� 5      -   5         ��Name$ typeDetectorBox��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
 Search by��60   $��22(�6\   ���	#FF622F96$��59,0,720,430q�6�   $
��Bold"�6�   6�     5      $ PersonSearch=�6&   $��39��6:   $��39��6E   ���	#FF622F96$��Bottom=�6h   $��
51,0,0,420q�6�   �� 5      -   5         ��Name$ searchArgTextBox��5      $  ��60   $��18(�6R    % !MaterialDesignFloatingHintTextBox#��[ 6a   $��95,90,547,420q�6�   ���	#FF622F96{�.  6�   �� 5      -   5        	 ��Name$	 resultTextBox��5      
���  ��$
��Left=�6<   $��35��6W   $��
57,145,0,0q�6c   $	��Top=�6w   $	��380��6�   $��20(�6�   �� 5      -   5        $��Search��5      $
��Left=�6&   $��50��6A   $��
57,180,0,0q�6M   $	��Top=�6a   $	��100��6y   $#��Times New Roman (Headings CS))�5      $��25(�5      
����������	#FF622F96��5      Z� �� 5      -   5        
 ��Name$
 userDetailStackPanel��5      $
��Left=�67   $	��320��6R   $��
10,232,0,0q�6_   $	��Top=�6s   $	��964��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 40Q�6#      ShadowDepth$ 25Q�63      	Direction$	 310Q�6D   5      5      5       