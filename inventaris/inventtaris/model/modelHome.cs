using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace inventtaris.model{
    class modelHome{

        Koneksi temp;

        public modelHome(){
            temp = new Koneksi();
        }

        // get total barang
        public int totalBarang(){
            DataSet totalBarang = new DataSet();
            string kondisi = "status_barang='1'";
            totalBarang = temp.Select("barang", kondisi);
            int total = totalBarang.Tables[0].Rows.Count;
            return total;
        }

        // get total peminjaman
        public int totalPeminjaman(){
            DataSet totalPeminjaman = new DataSet();
            totalPeminjaman = temp.Select("peminjaman",null);
            int total = totalPeminjaman.Tables[0].Rows.Count;
            return total;
        }

        // get total member
        public int totalMember(){
            DataSet totalMember = new DataSet();
            string kondisi = "status_member='1'";
            totalMember = temp.Select("member", kondisi);
            int total = totalMember.Tables[0].Rows.Count;
            return total;
        }
    }
}
