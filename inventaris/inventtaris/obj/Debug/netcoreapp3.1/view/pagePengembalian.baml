   M S B A M L   `   `   `  ����F  Binventtaris, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:inventtaris.viewinventtaris.view  5      '    !inventtaris.view.pagePengembalian   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:inventtaris.view     5        N� Title$  pagePengembalian��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �  � RowDefinitions 5      �� 5      $��50 �6    �� 5      $	��200 �6    �� 5      $��30 �6    .+�5      � $��0��6    5      �� 5      $��* �6'   �� 5      $��70 �6'   �� 5      $	��200 �6'   .+�5      �� $��Data Pengembalian��6   $
��Left=�64   $��10,0,0,0q�6O   $��Center=�6a   $	��209��6|   $
��Bold"�6�   $��20(�6�   �� 5      $
��Cari��6   $��1��6'   $��Right=�67   $��7,0,0,0q�6S   $��Center=�6d   $
��Bold"�6   �� 5      -   5         ��Name$ 	keySearch��5      $��2��6-   $
��Left=�6=   $��Center=�6X   $��0 0 10 0q�6s    �� TextWrapping$
 Wrap=�6�   $	��140��6�   6�   5      &   System.Windows.Controls.DataGrid  5       -   5          Name$ dgPengembalian��5       $��10,10,10,10q�6/      AutoGenerateColumns$ False��6D   $��1��6`      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ ID Peminjaman��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6b   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6@   �� *id_peminjaman+6b     5#      $ Nama Barang��6)   $		 120 6^   
 6>   �� *nama_barang+6^     5$      $ Nama Member��6)   $		 120 6^   
 6>   �� *nama_member+6^     5%      $ Jumlah��6)   $	 70 6T   
 69   �� *jumlah+6T     5&      $ 
Tgl Pinjam��6)   $		 140 6d   
 6=   �� *tanggal_peminjaman+6d     5'      $ Tgl Kembali��6)   $		 140 6g   
 6>   �� *tanggal_pengembalian+6g     5(      $ 
Nama Admin��6)   $		 120 6\   
 6=   �� *
nama_admin+6\   5*      � 5+      $��2��6    5,      �� 5-      $	��100 �6'   �� 5.      $	��100 �6'   .+�50      � $��0��6   .+�51      �� $��Total Data:��6   $��Right=�62   $	��Top=�6N   $
��Bold"�6f   52      � 53      $��1��6   .+�54      �� -   5         ��Name$ lblTotalData��54      $
��Left=�62   $	��Top=�6M   $
��Bold"�6e   55      56      57      � 59   
   $��1��6    5:      �� 5;      $
��Auto �6    .+�5=      �� $
}�True��6    �� CornerRadius$ 10��6)   ���#f3f5f9$��0��6P   $��10,58,10,-123q�6]   $
��Auto��6t   $
��Auto��6�   ._�5>      � $��2q�6    5?      �� 5@      $	��110 �6+   �� 5A      $	��200 �6+   .+�5C      �  5D      �� 5E      $��50 �6,   �� 5F      $��50 �6,   �� 5G      $��50 �6,   �� 5H      $��50 �6,   �� 5I      $��50 �6,   .+�5K      �� $��0��6    $	��0,5q�6-   $��ID Peminjaman:��6:   $��Center=�6S   $��Right=�6u   �� 5L      $��1��6    $	��0,5q�6-   $��Nama Member:��6:   $��Center=�6Q   $��Right=�6s   �� 5M      $��2��6    $	��0,5q�6-   $��Nama Barang:��6:   $��Center=�6Q   $��Right=�6s   �� 5N      $��3��6    $	��0,5q�6-   $��Jumlah Barang:��6:   $��Center=�6S   $��Right=�6u   5O      � 5Q      $��1��6    5R      �� 5S      $��50 �6,   �� 5T      $��50 �6,   �� 5U      $��50 �6,   �� 5V      $��50 �6,   �� 5W      $��50 �6,   .+�5Y      �� -   5         ��Name$ listPeminjaman��5Y   #   $��0��6;   $
��Left=�6H   $��Center=�6c   $	��200��6~   $��20��6�   6�   �� 5Z      -   5        $ namaPeminjam��5Z   "   $��1��68   $
��Left=�6E   $��Center=�6`   $
 Wrap=�6{   $	��200��6�   ${�False��6�   ���	#FF7D879C � UseLayoutRounding$
 True��6�   �� 5[      -   5        $ 
namaBarang��5[   "   $��2��66   $
��Left=�6C   $��Center=�6^   $
 Wrap=�6y   $	��200��6�   ${�False��6�   ���	#FF7D879C6�   �� 5\      -   5        $ jumlahBarang��5\   "   $��3��68   $
��Left=�6E   $��Center=�6`   $
 Wrap=�6{   $	��200��6�   ${�False��6�   ���	#FF7D879C6�   � 5]      $��4��6    5^      �� 5_   "   $	��100 �63   �� 5`   "   $	��100 �63   .+�5b      �� -   5         ��Name$ 	btnTambah��5b   %   $��0��68   $��
Kembalikan��6H   $
��Left=�6]   $��Center=�6x   ���#0d6efd
�������$��70��6�    � 	Resources 5c   "    �� 
TargetType �� Property �� Value��%^   '��       �� 5d   &   " ��6,   .�5e   *   ��  �@��CornerRadius$ 2��6I   5f   '   5g   #   5h      5i      5j      5k      5l      5m      5n      5o      