   M S B A M L   `   `   `  ����L  HControle de Feira, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Controle_de_Feira.ViewsControle_de_Feira.Views  5   	   '    !Controle_de_Feira.Views.LoginView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   1local%clr-namespace:Controle_de_Feira.Views  5   	     � Title$  Controle de Feira��5	   	    � Icon$Y SC:\Users\Caio\Desktop\Controle-de-feira\Controle de Feira\assets\market-icon-24.png��6#   $	��379��6~   $	��600��6�    � 
ResizeMode$ CanMinimize=�6�    � WindowStyle$ SingleBorderWindow=�6�   
������  � WindowStartupLocation$ CenterScreen=�6�   .��5
      � $��	10,0,0,10q�6    � RowDefinitions 5   
   �� 5      $
��168* �6   �� 5      $
��173* �6    � ColumnDefinitions 5   
   �� 5      $	��76* �6   �� 5      $
��119* �6   �� 5      $
��389* �6   .+�5   
   �� 
�������$��-10,0,0,-10q�6!   $��3��66   $��2��6J   �� 5   
   $��
80,0,0,-10q�6   $��2��6(   $��2��68   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 	#FF8EA6D7��6#   
 � Offset$
 0.098Q�65   � 5      $	 	#FFBABAD7��6#   � 5      $	 	#FF007ACC��6#   $
 0.525Q�65   � 5      $	 	#FFABABE1��6#   $
 1Q�65   5      5      �� 5   
   $��2,10,290,10q�6   $��3��6*   $��2��6>   .+�5       �� $��Login��6   $��Segoe UI Black)�6$   $��24(�6@   $��-4,10q�6N   $	��Top=�6]   $
��Left=�6u   �� 5!       �� Orientation$ 
Horizontal=�6   .+�5"      �� $
��Left=�6   $	��Top=�67   $
��Wrap=�6O   ���#707070�� 6y   $�Não possui uma conta? ��6}   6�   �� 5#      -   5        $
��Left=�5#   M   $	��Top=�6h   $
��Wrap=�6�   ���	#FF2468AC � Cursor$
 Hand��6�   �� 6�   $�Crie uma conta,��6�   6�   5$      �� 5%      $
��Left=�6   $	��Top=�63   $
��Wrap=�6K   ���#707070�� 6u   $$�isso levará menos de 1 minto.��6y   6�   �� 5&      $��-4,15q�6   $ 
Horizontal=�6(   .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Account=�6*   $��Center=�69   ���#7070706T   �� 5(      -   5         ��Name$
 Name��5(      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Usuário��6(   $	��233��6Q   $��5q�6]   $��24��6h   5)      �� 5*      $��-4q�6   $ 
Horizontal=�6%   .+�5+        $	 Key=�6*   $��Center=�65   ���#7070706P   G� 5,      -   5         G�Name$ Password��5,      $ Senha��60   $	��233��6W   $��5q�6c   $��24��6n   5-      � 5.      �� 5/      -   5         ��Name$ Login��5/      $��83,45,114,15q�6$   $��Center=�6:   $��LOGIN��6W   $��Impact)�6g   $��18(�6{   $��95��6�   ���	#FF007ACC���	#FF307CD6���	#FFECE6E66�   50      �� 51   
   $��
80,50,0,44q�6   $��2��6)   $��2��69   .+�52      �� $��	Bem Vindo��6   
�������$��Center=�6<   $��48(�6Y   $��Champagne & Limousines)�6g   $
��Bold"�6�   $
��13,0q�6�   �� 53      $4��.Torne seu Controle de Feira fácil e elegante!��6   
�������$��Center=�6`   $	��282��6}   $��26(�6�   $��Champagne & Limousines)�6�   $
��Wrap=�6�    �� TextAlignment$ Center=�6�   $��
-3,50,-5,0q�6�   $	��101��6�    J� RenderTransformOrigin$ 0.502,0.747&�6  54      55      56      