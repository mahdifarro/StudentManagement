   M S B A M L   `   `   `  ����J  FStudentsManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:StudentsManagerStudentsManager  5   	       StudentsManager.LoginForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:StudentsManager     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullZ VMaterialDesignThemes.MahApps, Version=0.1.4.1513, Culture=neutral, PublicKeyToken=nullHmaterialdesign1http://materialdesigninxaml.net/winfx/xaml/themes   65   -   5          � Title$  
Login Form��5   	   $	��600��6   $
��1024��6)    � AllowsTransparency .  � WindowStyle$
 None=�6P    � WindowStartupLocation$ CenterScreen=�6c   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $
��Left=�6   $	��600��6:   $��	394,0,0,0q�6G   $	��Top=�6Z   $	��630��6r   ��5      �� 5      -   5        backgroundImage��5      5      �� 5   
   -   5        $ label1��5      $��Login��6    $
��Left=�60   $��68��6K   $��	26,26,0,0q�6W   $	��Top=�6j   $	��121��6�   $��40(�6�   $
��Bold"�6�   ���	#FF622F966�   �� 5   
   -   5        $ label2��5      $)��#Welcome , Log in with your account ��6    $��22(�6N   $
��Left=�6\   $��48��6w   $��	28,94,0,0q�6�   $	��Top=�6�   $	��513��6�   ���	#FF622F966�   �� 5   
   -   5        $ label3��5      $�� ��6    $
��Left=�6+   $��7��6F   $��
33,139,0,0q�6Q   $	��Top=�6e   $��90��6}   ���	#FF622F966�   � 5   
   $��2��6   $
��Left=�6   $��39��68   $��49.833,157.5,0,0q�6D   $	��Top=�6^   $��233.167��6v   .+�5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   $��39��6M   $��13,20,-13.833,-20q�6Y   $	��Top=�6t   $	��234��6�   '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Account=�6&   $��30��65   $��30��6@   $��Bottom=�6�   $��
-1,0,0,-20q�6�   ��6L   ��  �� ElementName$ txt_Usuario�� �� Path$ BorderBrush�6�   �� 5      -   5        	 ��Name$	 txt_Usuario��5      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 	User Name��6+    %  !MaterialDesignFloatingHintTextBox#��[  6W   $��39,18,-103.833,-20q�6�    �� 
CaretBrush �	#FF622F96���	#FF622F966�   5      � 5   
   $
��Left=�6   $��39��6+   $��49.833,211.527,0,0q�67   $	��Top=�6S   $��233.167��6k    � ColumnDefinitions 5      �� 5      $
��200* �6#   �� 5      $	��33* �6#   .+�5      �� $ 
Horizontal=�6   $
��Left=�62   $��39��6M   $��13,20,-14.2,-20q�6Y   $	��Top=�6r   $	��234��6�   $��2��6�     5      $	 Key=�6&   $��30��61   $��30��6<   $��Bottom=�6�   $��
-1,0,0,-20q�6�   ��6H   �� $ txt_Password��$ BorderBrush�6�   G� 5      -   5         G�Name$ txt_Password��5      $
 Password��63    ) %MaterialDesignFloatingHintPasswordBox#��[ 6^   $��2��6�   $��39,20,-104.2,-20q�6�    G� 
CaretBrush �	#FF622F96���	#FF622F966�   5       �� 5#   
   $ 
Horizontal=�6   $	��Top=�6.   $��40��6F   $��Right=�6R   $��10q�6n   .+�5$      �� -	   5         ��Name$ ButtonClose��5$       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6*   $��30��6p   $��30��6{   $��0q�6�   
�������$��0,3,0,7q�6�   ��6�   Z� ��6�   Z� .��5%        $ Power=�6*   5&      5'      �� 5)   
   -
   5        $ loginButton��5)       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5*      $��20(�6A   $��33,358,839,201q�6O   ���	#FF622F96
������ $��LOGIN��6�   $
��Auto��6�   6�   �� 5+   
   -   5        $ label1_Copy��5+      $��Communication Ways :��6%   $��15(�6D   $
��Left=�6R   $��37��6m   $��
50,438,0,0q�6y   $	��Top=�6�   $	��182��6�   $
��Bold"�6�   ���	#FF622F966�   d� 5-   
    $  MaterialDesignActionToggleButton#��[ 5.      $+ %MaterialDesignActionLightToggleButton��5/      $��85,485,859,35q�63   ���#2c7873$��80��6_   $��80��6k   ��50        51      $ Whatsapp=�52      $��55��6   $��55��6#   1  +MaterialDesignThemes.Wpf.ToggleButtonAssist   	OnContent 54        55      $ EmoticonHappy=�56      58      d� 59   
   #��[ 5:      $+ %MaterialDesignActionLightToggleButton��5;      $��152,485,792,35q�6=   ���	#FFB73A3A$��80��6l   $��80��6x    5<        5=      $ EmoticonHappy=�6*   .��5?        $ Google=�6&   $��55��64   $��55��6@   5@      d� 5A   
   #��[ 5B      $+ %MaterialDesignActionLightToggleButton��5C      $��221,485,723,35q�6=   ���#0f4c75$��80��6j   $��80��6v    5D        5E      $ EmoticonHappy=�5F      .��5H        $ Facebook=�5I      $��55��6!   $��55��6-   5J      �� 5K   
   -   5        $ LabelPassed��5K      $
��Left=�6%   $��36��6@   $��
35,322,0,0q�6L   $	��Top=�6`   $	��359��6x   $��14(�6�   
���  ��$
��Bold"�6�   5M      5N      