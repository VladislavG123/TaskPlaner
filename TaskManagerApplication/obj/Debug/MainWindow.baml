   M S B A M L   `   `   `  ����Q  MTaskManagerApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TaskManagerApplicationTaskManagerApplication  5   	   '    !TaskManagerApplication.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:TaskManagerApplication     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � Title$ 
MainWindow��5   	   $	��600��6   $	��275��6,   $	��600��6;   $	��400��6H   .��5      �  � RowDefinitions 5   
   �� 5      $	��21* �6   �� 5      $	��42* �6   �� 5      $	��21* �6   �� 5      $	��42* �6   �� 5      $	��21* �6   �� 5      $	��42* �6   �� 5      $	��22* �6   �� 5      $	��42* �6   �� 5      $	��21* �6   �� 5      $
��257* �6   �� 5      $	��38* �6   .+�5    
   (  "System.Windows.Controls.DatePicker  -   5          Name$ 
datePicker��5       )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Select start date��6)   $��1��6\   )  #MaterialDesignThemes.Wpf.TimePicker  5"   
   -   5          Name$ 
timePicker��5"   $   $��3��68   o� 5$   
   $��5��6   $��Center=�6   .@�5%      m� -   5         m�Name$ periodicityMenuItem��5%      $��Select periodicity��64   $��0q�6P   
�������$��Roboto)�6n   $��15(�6�   .@�5&      m� -   5        $ oneTimeMenuItem��5&      $��One time��6Q   $��5q�6c   6q   m� 5'      $��	Once a...��6    m� IsCheckable .  $��5q�6B   .@�5(      m� -   5        $ onceADayMenuItem��5(      $	��day��6W   $��5q�6d   6r   m� 5)      -   5        $ onceAWeekMenuItem��5)      $
��week��6Y   $��5q�6g   6u   m� 5*      -   5        $ onceAMounthMenuItem��5*      $��mounth��6]   $��5q�6m   6{   m� 5+      -	   5        $ onceAYearMenuItem��5+      $
��year��6Y   $��5q�6g   6u   5,      5-      5.      o� 50   
   $��7��6   $��Center=�6   .@�51      m� -
   5        $ selectTypeMenuItem��51      $��Select type��63   $��0q�6H   
�������$��Roboto)�6f   $��15(�6z   .@�52      m� -   5        $ emailMenuItem��52      $��Email message��6M   $��5q�6d   6r   m� 53      -   5        $ downloadMenuItem��53      $��Download file��6S   $��5q�6k   6y   m� 54      -   5        $ moveDirectoryMenuItem��54      $��Move directory��6]   $��5q�6u   6�   55      56      �� 58   
   	 K� ZIndex$	 -1��6   $��8��6#   $��0 0 0 1q�60   
���   �6J    � 5:   
   -   5        
  �Name$
 frame��5:        � NavigationUIVisibility$ Hidden=�6    $��9��6@   �� 5<   
   -   5         ��Name$ 
nextButton��5<      $
��-4,0q�6=   $��0q�6K   $��10��6W    " MaterialDesignRaisedDarkButton#���  6e   $
��Auto��6�   .��6�   Next6�   5>      5?      