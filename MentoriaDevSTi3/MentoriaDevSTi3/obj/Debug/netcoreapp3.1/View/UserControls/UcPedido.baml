   M S B A M L   `   `   `  ����J  FMentoriaDevSTi3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:MentoriaDevSTi3.View.UserControls!MentoriaDevSTi3.View.UserControls  5      0    *MentoriaDevSTi3.View.UserControls.UcPedido   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:MentoriaDevSTi3.View.UserControls     5      .��5	      � ���#EBEBEB  � RowDefinitions  5
   
   �� 5      $��40 �6   �� 5      $	��120 �6   �� 5      .+�5   
   �� $��Pedido��6   $
��Bold"�6!   $��20(�63   ���#0323386A   � 5   
   $��1��6   $
��10,0q�6     5      �� 5      �� 5      .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      $��10 �6'   �� 5      .+�5!      �� .+�5"      �� $��Cliente��6   �� 5#      -   5         ��Name$ 
CmbCliente��5#       �� DisplayMemberPath$
 Nome��6Y   ��63   �� *ListaClientes+6Y   5$      �� 5&      $��2��6   .+�5'      �� $��	Pagamento��6   �� 5(      -   5        $ CmbFormaPagamento��5(      ��6:   �� *ListaPagamentos+5)      5*      � 5,      $��1��6    5-      �� 5.      �� 5/      $��10 �6'   �� 50      $	��100 �6'   �� 51      $��10 �6'   �� 52      $��80 �6'   �� 53      $��10 �6'   �� 54      $	��125 �6'   .+�57      �� .+�58      �� $��Produto��6   �� 59      -   5        $ 
CmbProduto��59      $
 Nome��6Y   ��63   �� *ListaProdutos+5:      5;      �� 5=      $��2��6   .+�5>      �� $��
Quantidade��6   �� 5?      ��6   �� *
Quantidade+5@      �� 5B      $��4��6   .+�5C      �� $��Valor Unit.��6   �� 5D      $��15(�6k   ��6    �� *	ValorUnit+ �� ConverterCulture$ pt-BR�� �� StringFormat$ #,##0.00��6k   5E      �� 5G      -   5         ��Name$ BtnAdicionarItem��5H      $��6��5G         BtnArredondado#��[  5H   3   $��	Adicionar��6[   
��� � �
�������$��25��5I   ?   $��Bottom=�6K   $��0,0,0,10q�6f   5J      5L      5N      � 5P   
   $��2��6   $
��10,0q�6     5Q      �� 5R      �� 5S      $��60 �6    .+�5V      �� 
�������$��1q�6.   
���������5W      �� *ItensAdicionados+��5X      �� 5Y      .R�5Z      � $��5q�6   $��25��6*    5[      �� 5\   "   �� 5]   "   �� 5^   "   .+�5a      �� ��6(   �� *Nome+�� 5c      $��1��6(   �� 5d   "   �6&   �� *
Quantidade+ �� 5e   "   $�UN��6&    �� 5f   "   $�x��6&    �� 5g   "   �6&   �� *	ValorUnit+$ pt-BR��$ #,##0.00��5h      �� 5j      $��2��6(   $��Center=�5k   (   ��5l   (   �� *ValorTotalItem+$ pt-BR��$ #,##0.00���� 5n      $��3��6%     BrdSeparadorItens#��[ 69   5o      5p      5r      �� 5t      $��1��6    �� Orientation$ 
Horizontal=�6&   $��Right=�6?   .+�5u      �� $��25(�6n   $��0,0,20,0q�6|   ��6   �� *ValorTotalPedido+$ pt-BR��$ #,##0.00��6|   �� 5w      -   5        $ BtnFinalizarPedido��5x      $��Finalizar Pedido��5w      #��[  5x   5   
��� � �
�������$��25��5y   ,   $	��150��68   $��Right=�6D   5z      5{      5}      5      5�      