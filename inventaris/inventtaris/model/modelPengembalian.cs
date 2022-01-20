using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace inventtaris.model{
    class modelPengembalian{
        Koneksi temp;

        public string idPeminjaman { get; set; }
        public string idBarang { get; set; }
        public string idBarangPinjam { get; set; }
        public int jumlahPinjam { get; set; }
        public string key { get; set; }
        public modelPengembalian(){
            temp = new Koneksi();
        }

        public DataSet listPeminjaman(){
            return temp.SelectData("SELECT id_peminjaman FROM peminjaman WHERE status='0'", "peminjaman");
        }

        public DataSet getInfo(){
            return temp.SelectData("SELECT b.nama_member, c.nama_barang, a.jumlah from peminjaman a JOIN member b ON a.id_member=b.id_member JOIN barang c ON a.id_barang=c.id_barang WHERE a.id_peminjaman='" + idPeminjaman + "'", "peminjaman");
        }

        public bool prosesKembali(){
            // update barang
            DataSet jumlahAwalBarang = new DataSet();
            jumlahAwalBarang = temp.SelectData("SELECT jumlah_barang FROM barang WHERE id_barang='" + idBarang + "'", "barang");
            int jumlahAkhir = Convert.ToInt32(jumlahAwalBarang.Tables[0].Rows[0][0].ToString());
            jumlahAkhir = jumlahAkhir + jumlahPinjam;
            string dataBarang = "jumlah_barang='" + jumlahAkhir + "'";
            bool updateBarang = temp.Update("barang", dataBarang, "id_barang='" + idBarang + "'");

            // update Peminjaman
            string dataPeminjaman = "status='1'";
            bool updatePeminjaman = temp.Update("peminjaman", dataPeminjaman, "id_peminjaman='" + idPeminjaman + "'");

            // tambah pengembalian
            DateTime today = DateTime.Now;
            string tglKembali = today.ToString("yyyy-MM-dd hh:mm:ss");
            string idAdmin = model.cekLogin.idAdmin;
            string dataPengembalian = "'" + idPeminjaman + "','" + tglKembali + "','" + idAdmin + "'";
            bool tambahPengembalian = temp.Insert("pengembalian", dataPengembalian);

            // cek kondisi
            if (updateBarang && updatePeminjaman && tambahPengembalian){
                return true;
            }else{
                return false;
            }
        }

        public string cekIdPeminjaman(){
            DataSet data = new DataSet();
            data = temp.SelectData("SELECT id_barang from peminjaman Where id_peminjaman='" + idPeminjaman + "'", "admin");
            return data.Tables[0].Rows[0][0].ToString();
        }

        public DataSet getData(){
            DataSet data = new DataSet();
            data = temp.SelectData("Select a.id_peminjaman, a.tanggal_pengembalian, e.nama_admin, b.tanggal_peminjaman, b.jumlah, c.nama_barang, d.nama_member, d.id_member from pengembalian a JOIN peminjaman b ON a.id_peminjaman=b.id_peminjaman JOIN barang c ON b.id_barang=c.id_barang JOIN member d ON b.id_member=d.id_member JOIN admin e ON a.id_admin=e.id_admin", "pengembalian");
            return data;
        }

        public int totalData(){
            int totalPengembalian;

            // cek jika public variabel key kosong
            if (key == ""){
                // jika kosong, get data dari function getData() dan menghitung row
                totalPengembalian = getData().Tables[0].Rows.Count;
            }else{
                // jika tidak kosong, get data dari function searchMember() dan menghitung row
                totalPengembalian = searchPengembalian().Tables[0].Rows.Count;
            }

            // return variabe totalMember
            return totalPengembalian;
        }

        public DataSet searchPengembalian(){
            DataSet pengembalian = new DataSet();
            if (key == ""){
                pengembalian = getData();
            }else{
                pengembalian = temp.SelectData("Select a.id_peminjaman, a.tanggal_pengembalian, e.nama_admin, b.tanggal_peminjaman, b.jumlah, c.nama_barang, d.nama_member, d.id_member from pengembalian a JOIN peminjaman b ON a.id_peminjaman=b.id_peminjaman JOIN barang c ON b.id_barang=c.id_barang JOIN member d ON b.id_member=d.id_member JOIN admin e ON a.id_admin=e.id_admin WHERE a.id_peminjaman LIKE '%" + key + "%' OR a.tanggal_pengembalian LIKE '%" + key + "%' OR e.nama_admin LIKE '%" + key + "%' OR b.tanggal_peminjaman LIKE '%" + key + "%' OR b.jumlah LIKE '%" + key + "%' OR c.nama_barang LIKE '%" + key + "%' OR d.nama_member LIKE '%" + key + "%'", "pengembalian");
            }
            return pengembalian;
        }
    }
}
