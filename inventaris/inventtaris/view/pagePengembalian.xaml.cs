using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace inventtaris.view{
    /// <summary>
    /// Interaction logic for pagePengembalian.xaml
    /// </summary>
    public partial class pagePengembalian : Page{

        controller.c_Pengembalian c_Pengembalian;
        public pagePengembalian(){
            InitializeComponent();
            // inisialisasi penggunaan controller
            c_Pengembalian = new controller.c_Pengembalian(this);
            // get list peminjaman belum dikembalikan
            c_Pengembalian.listPeminjaman();
            // get data pengembalian
            c_Pengembalian.getData();
            // get total data
            c_Pengembalian.totalData();
        }

        private void listPeminjaman_SelectionChanged(object sender, SelectionChangedEventArgs e){
            if(listPeminjaman.SelectedItem != null){
                DataRowView data = listPeminjaman.SelectedItem as DataRowView;
                c_Pengembalian.getInfo(data["id_peminjaman"].ToString());
            }else{
                namaPeminjam.Text = "";
                namaBarang.Text = "";
                jumlahBarang.Text = "";
            }
        }

        private void btnTambah_Click(object sender, RoutedEventArgs e){
            c_Pengembalian.prosesKembali();
        }

        private void keySearch_TextChanged(object sender, TextChangedEventArgs e){
            c_Pengembalian.searchBarang();
        }
    }
}
