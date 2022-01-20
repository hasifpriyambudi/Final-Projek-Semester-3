using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace inventtaris.controller{
    class c_Pengembalian{

        // create object
        model.modelPengembalian modelPengembalian;
        view.pagePengembalian viewPengembalian;

        public c_Pengembalian(view.pagePengembalian viewPengembalian){
            modelPengembalian = new model.modelPengembalian();
            this.viewPengembalian = viewPengembalian;
        }

        public void listPeminjaman(){
            DataSet listPeminjaman = modelPengembalian.listPeminjaman();
            viewPengembalian.listPeminjaman.ItemsSource = listPeminjaman.Tables[0].DefaultView;
            viewPengembalian.listPeminjaman.DisplayMemberPath = listPeminjaman.Tables[0].Columns["id_peminjaman"].ToString();
            viewPengembalian.listPeminjaman.SelectedValuePath = listPeminjaman.Tables[0].Columns["id_peminjaman"].ToString();
        }
        
        public void getInfo(string key){
            modelPengembalian.idPeminjaman = key;
            DataSet data = modelPengembalian.getInfo();
            viewPengembalian.namaPeminjam.Text = data.Tables[0].Rows[0][0].ToString();
            viewPengembalian.namaBarang.Text = data.Tables[0].Rows[0][1].ToString();
            viewPengembalian.jumlahBarang.Text = data.Tables[0].Rows[0][2].ToString();
        }

        public void prosesKembali() {
            if (viewPengembalian.listPeminjaman.SelectedIndex < 0){
                MessageBox.Show("Isi Semua Form dengan Benar");
            }else{
                DataRowView selectedListPeminjaman = viewPengembalian.listPeminjaman.SelectedItem as DataRowView;
                modelPengembalian.idPeminjaman = selectedListPeminjaman["id_peminjaman"].ToString();
                string cekIdPeminjaman = modelPengembalian.cekIdPeminjaman();

                modelPengembalian.jumlahPinjam = Convert.ToInt32(viewPengembalian.jumlahBarang.Text);
                modelPengembalian.idBarang = cekIdPeminjaman.ToString();
                bool result = modelPengembalian.prosesKembali();
                if (result)
                {
                    MessageBox.Show("Pengembalian Berhasil");
                    getData();
                }
                else
                {
                    MessageBox.Show("Pengembalian Gagal");
                }
            }
        }

        public void getData(){
            DataSet data = modelPengembalian.getData();
            viewPengembalian.dgPengembalian.ItemsSource = data.Tables[0].DefaultView;
        }

        // total data peminjaman
        public void totalData(){
            int totalPengembalian = modelPengembalian.totalData();
            viewPengembalian.lblTotalData.Content = totalPengembalian;
        }

        // search pengembalian
        public void searchBarang(){
            modelPengembalian.key = viewPengembalian.keySearch.Text;
            DataSet data = modelPengembalian.searchPengembalian();
            viewPengembalian.dgPengembalian.ItemsSource = data.Tables[0].DefaultView;
            totalData();
        }
    }
}
