   M S B A M L   `   `   `  ����Q  MTaskManagerApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TaskManagerApplicationTaskManagerApplication  5      .    (TaskManagerApplication.MoveDirectoryPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:TaskManagerApplication     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Regular"�5
      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ MoveDirectoryPage��5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��25 �6   �� 5      $��2* �6   �� 5      $��25 �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��20* �6   �� 5      $��25 �6   .+�5!   
   �� $��1��6   $��17(�6!   From65   �� 5"   
   -   5         ��Name$ fromTextBox��5"      $��0q�6   $��1��63   $��1��6@   6R   �� 5#   
   -   5         ��Name$ fromFindDirectoryButton��5#      $��1��6W   $��2��6d   $��0q�6t   $
��Auto��6�   ��6�   0  *MaterialDesignThemes.Wpf.PackIconExtension  	   Kind$	 DotsVertical=�6�   �� 5%   
   $��3��6   $��17(�6!   To63   �� 5&   
   -   5        $ 	toTextBox��5&      $��0q�6   $��3��61   $��1��6>   6Q   �� 5'   
   -   5        $ toFindDirectoryButton��5'   4   $��3��6S   $��2��6`   $��0q�6p   $
��Auto��6�   $
��Left=�6�   $��25��6�   ��6}     $	 DotsVertical=�6�   5)      5*      