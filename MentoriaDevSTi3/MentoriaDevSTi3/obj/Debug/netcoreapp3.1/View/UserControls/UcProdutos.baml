   M S B A M L   `   `   `  ����J  FMentoriaDevSTi3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MentoriaDevSTi3.View.UserControls!MentoriaDevSTi3.View.UserControls  5      2    ,MentoriaDevSTi3.View.UserControls.UcProdutos   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:MentoriaDevSTi3.View.UserControls     5      .��5	      � ���#EBEBEB  � RowDefinitions  5
   
   �� 5      $��40 �6   �� 5      $��80 �6   �� 5      .+�5   
   �� $��Produtos��6   $
��Bold"�6#   $��20(�65   ���#0323386C   �� 5   
      BrdTitulosTelas#��[  6   � 5   
   $��1��6   $��10q�6    � ColumnDefinitions 5      �� 5      �� 5      $��10 �6#   �� 5      $	��100 �6#   �� 5      $��10 �6#   �� 5      .+�5      �� .+�5      �� $
��Nome��6   �� 5      ��6   �� *Nome+5       �� 5"      $��2��6   .+�5#      �� $��Valor��6   �� 5$      -   5         ��Name$ TxtValor��5$      ��6,   �� *Valor+5%      5&      �� 5(      -   5         ��Name$ BtnAdicionar��5)      $��4��5(      
��� � �
�������$
��Left=�5)   Q   $��Bottom=�5*      $��0,0,0,10q�60   $��25��5+      $	��150��6!   ��5.      �� 5/       �� 
TargetType" ��6     BtnArredondado �� BasedOn# [ 6,   .�50      ��  �� Property � �� �� Value$ 	Adicionar��60    �� Triggers 51      �� 52      	 �� Binding	 6&   �� *	Alteracao+
 �� Value
 True6D   .a�53      ��  � ��$ Salvar��68   54      56      58      59      �� 5;   
   $��2��6   
�������
�������$��1q�6J   $��10q�6^   ��6j   �� *ProdutosAdicionados+��5<      �� 5=      .R�5>      � $��5q�6    5?      �� 5@      �� 5A      �� 5B      $	��210 �6/   .+�5E      �� ��6$   �� *Nome+�� 5G      $��1��6$   ��64   �� *Valor+ �� ConverterCulture$ pt-BR�� �� StringFormat$ #,##0.00���� 5I      $��2��6%    �� Orientation$ 
Horizontal=�5J   %   $��25��6>   $��0,0,0,5q�6J   .+�5L      �� $ 
BtnAlterar��6%   -   5        $	��100��5M   %   $��Alterar��61   #��[ 5N   %   
���p�
�������
 � Tag 5M   C   �� 5O   %   �� 5Q      $ 
BtnRemover��6%   -   5        $	��100��5R   %   $��10,0,0,0q�61   $��Remover��6C   #��[ 5S   %   
���  ��
������� 5R   U   �� 5T   %   5U      �� 5W      $��3��6!     BrdSeparadorItens#��[ 65   5X      5Y      5[      5]      5^      