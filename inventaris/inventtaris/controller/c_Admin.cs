using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace inventtaris.controller
{
    class c_Admin
    {
        model.modelAdmin modelAdmin;
        view.pageAdmin pageAdmin;

        public c_Admin(view.pageAdmin pageAdmin)
        {
            modelAdmin = new model.modelAdmin();
            this.pageAdmin = pageAdmin;
        }

        public void Proses_tambah()
        {
            modelAdmin.nama = pageAdmin.namaAdmin.Text;
            modelAdmin.email = pageAdmin.emailAdmin.Text;
            modelAdmin.user = pageAdmin.userAdmin.Text;
            modelAdmin.pass = pageAdmin.passAdmin.Password;

            if (pageAdmin.namaAdmin.Text=="" || pageAdmin.emailAdmin.Text=="" || pageAdmin.userAdmin.Text=="" || pageAdmin.passAdmin.Password==""){
                MessageBox.Show("Mohon isi semua form!");
            }else{
                bool result = modelAdmin.Proses_tambah();
                if (result){
                    Getdata();
                    MessageBox.Show("Data berhasil ditambah");
                }else{
                    MessageBox.Show("Data gagal ditambahkan");
                }
            }
        }

        public void Getdata(){
            DataSet data = modelAdmin.Getdata();
            pageAdmin.dgadmin.ItemsSource = data.Tables[0].DefaultView;
        }

        public void Totaldata(){
            pageAdmin.lblTotalData.Content = modelAdmin.Totaldata();
        }

        public void Searchadmin(){
            modelAdmin.key = pageAdmin.keySearch.Text;
            DataSet data = modelAdmin.Searchadmin();
            pageAdmin.dgadmin.ItemsSource = data.Tables[0].DefaultView;
            Totaldata();
        }

        public void Deleteadmin(){
            modelAdmin.Idadmin = pageAdmin.idAdmin.Text;
            bool result = modelAdmin.Deleteadmin();
            if (result){
                Getdata();
                MessageBox.Show("Admin berhasil dihapus");
            }else{
                MessageBox.Show("Admin gagal dihapus");
            }
        }

        public void Updateadmin(){
            modelAdmin.Idadmin = pageAdmin.idAdmin.Text;
            modelAdmin.nama = pageAdmin.namaAdmin.Text;
            modelAdmin.user = pageAdmin.userAdmin.Text;
            modelAdmin.email = pageAdmin.emailAdmin.Text;
            modelAdmin.pass = pageAdmin.passAdmin.Password;
            if (pageAdmin.namaAdmin.Text == "" || pageAdmin.emailAdmin.Text == "" || pageAdmin.userAdmin.Text == "" || pageAdmin.passAdmin.Password == ""){
                MessageBox.Show("Mohon isi semua form!");
            }else{
                bool result = modelAdmin.Updateadmin();
                if (result){
                    Getdata();
                    MessageBox.Show("Data berhasil diupdate");
                }else{
                    MessageBox.Show("Data gagal diupdate");
                }
            }
        }
    }
}
