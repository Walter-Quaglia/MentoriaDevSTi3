   M S B A M L   `   `   `  ����J  FMentoriaDevSTi3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MentoriaDevSTi3.View.UserControls!MentoriaDevSTi3.View.UserControls  5      2    ,MentoriaDevSTi3.View.UserControls.UcClientes   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:MentoriaDevSTi3.View.UserControls     5      .��5	      � ���#EBEBEB  � RowDefinitions  5
   
   �� 5      $��40 �6   �� 5      $	��120 �6   �� 5      .+�5   
   �� $��Clientes��6   $
��Bold"�6#   $��20(�65   ���#0323386C   �� 5   
      BrdTitulosTelas#��[  6   � 5   
   $��1��6   $
��10,0q�6     5      �� 5      �� 5      .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      $��10 �6'   �� 5      $	��150 �6'   .+�5!      �� .+�5"      �� $
��Nome��6   �� 5#      ��6   �� *Nome+5$      �� 5&      $��2��6   .+�5'      �� $��Data de Nascimento��6   (  "System.Windows.Controls.DatePicker  5(         SelectedDate 6!   �� *DataNascimento+5)      5+      � 5-      $��1��6    5.      �� 5/      $	��100 �6'   �� 50      $��10 �6'   �� 51      �� 52      $��10 �6'   �� 53      $	��200 �6'   �� 54      $��10 �6'   �� 55      $	��150 �6'   .+�58      �� .+�59      �� $	��Cep��6   �� 5:      ��6   �� *Cep+5;      �� 5=      $��2��6   .+�5>      �� $��	Endereço��6   �� 5?      ��6   �� *
Endereco+5@      �� 5B      $��4��6   .+�5C      �� $��Cidade��6   �� 5D      ��6   �� *Cidade+5E      �� 5G      -   5         ��Name$ BtnAdicionar��5H      $��6��5G      
��� � �
�������$
��Left=�5H   Q   $��Bottom=�5I      $��0,0,0,10q�60   $��25��5J      $	��150��6!   ��5L      �� 5M       �� 
TargetType" ��6      BtnArredondado �� BasedOn# [ 64   .�5N      ��  �� Property � �� �� Value$ 	Adicionar��68    �� Triggers 5O      �� 5P   "   	 �� Binding	 6.   �� *	Alteracao+
 �� Value
 True6L   .a�5Q   &   ��  � ��$ Salvar��6@   5R   #   5T      5V      5X      5Z      �� 5\   
   $��2��6   
�������
�������$��1q�6J   $��10q�6^   ��5]      �� *ClientesAdicionados+��5^      �� 5_      .R�5`      � $��5q�6    5a      �� 5b      �� 5c      �� 5d      $	��210 �6/   .+�5g      �� ��6$   �� *Nome+�� 5i      $��1��6$   ��64   �� *
Endereco+�� 5k      $��2��6%    �� Orientation$ 
Horizontal=�5l   )   $��25��6B   $��0,0,0,5q�6N   .+�5m      �� $ 
BtnAlterar��6%   -   5        $	��100��5n   )   $��Alterar��65   #��[ 5o   )   
���p�
�������
 � Tag 5n   G   �� 5p   )   �� 5r      $ 
BtnRemover��6%   -   5        $	��100��5s   )   $��10,0,0,0q�65   $��Remover��6G   #��[ 5t   )   
���  ��
������� 5s   Y   �� 5u   )   5v      �� 5x      $��3��6!     BrdSeparadorItens#��[ 65   5y      5z      5|      5}      5~      