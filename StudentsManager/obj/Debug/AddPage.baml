   M S B A M L   `   `   `  ����J  FStudentsManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:StudentsManagerStudentsManager  5   	       StudentsManager.AddPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:StudentsManager     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullZ VMaterialDesignThemes.MahApps, Version=0.1.4.1513, Culture=neutral, PublicKeyToken=nullHmaterialdesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   -   5        $	��600��5      $
��1024��6'     � 
ResizeMode$  NoResize=�64    � WindowStyle$
 None=�6J    � WindowStartupLocation$ CenterScreen=�6t   .��5	      �� ���	#FF622F96.+�5
   
   � $��20q�6   $	��Top=�6   
�������$	��560��6F   .+�5      ��  �� Orientation$ 
Horizontal=�6   $	��Top=�62   $��40��6J   $��Right=�6V   $��10q�6r   .+�5      �� -   5         ��Name$ 
backButton��5       0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6-   $��30��6s   $
��Auto��6~   $��0q�6�   
���   �$��0,0,0,10q�6�   ��6�   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ArrowBackCircle=�6.   5      5      �� 5      -   5         ��Name$ typeDetectorBox��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  Role��60   $��22(�6W   ���	#FF622F96$��59,0,800,380q�6|   $
��Bold"�6�   6�   �� 5      -   5        $ browserButton��5      $��476,60,36,118q�6,   $	��380��6C   ��6P   Z� .��5      �� -   5         ��Name$ mainPic��5      $F��@C:\Users\Mahdi Farro\Desktop\StudentManaging_V2\Pics\NoImage.PNG��6)   $
��Fill=�6s   5        5      $ 	RenameBox=�6&   $��39��67   $��39��6B   ���	#FF622F96$��Bottom=�6e   $��
51,0,0,381q�6�   �� 5      -   5        	 ��Name$	 nameTextBox��5      $ 
 Full Name��6+   $��18(�6W    % !MaterialDesignFloatingHintTextBox#��[ 6f   $��95,129,547,381q�6�   ���	#FF622F966�     5      $ IdCardOutline=�6&   $��39��6;   $��39��6F   ���	#FF622F96$��Bottom=�6i   $��
51,0,0,311q�6�   �� 5      -   5        $	 nationalCodeTextBox��5      $  National ID��63   $��18(�6a   #��[ 6p   $��95,198,547,313q�6�   ���	#FF622F966�     5      $ Details=�6&   $��39��65   $��39��6@   ���	#FF622F96$��Bottom=�6c   $��
51,0,0,239q�6~   �� 5      -   5        $	 descriptionTextBox��5      $  Description��62   $��18(�6`   #��[ 6o   $��95,267,547,241q�6�   ���	#FF622F966�   �� 5      -	   5        
 ��Name$
 adminChecker��5      $��54,345,547,160q�6-   -  'MaterialDesignThemes.Wpf.CheckBoxAssist   CheckBoxSize$ 35Q�6E   $y�Hidden=�6u   ���	#FF622F96���	#FF622F96$��15(�6�   $
��Bold"�6�   .��6�   Admin5      �� 5      -
   5        $��Submit��5      $
��Left=�6&   $��50��6A   $��519,478,0,0q�6M   $	��Top=�6b   $	��390��6z   $#��Times New Roman (Headings CS))�5      $��25(�5       
����������	#FF622F96��5#      Z� �� 5$      -   5         ��Name$ resultTextBox��5$      
���  ��$
��Left=�6<   $��37��6W   $��476,441,0,0q�6c   $	��Top=�6x   $	��472��6�   $��20(�6�    J� Effect 5%      3  -System.Windows.Media.Effects.DropShadowEffect  5&         
BlurRadius$ 40Q�6#      ShadowDepth$ 25Q�63      	Direction$	 310Q�6D   5(      5)      5*      