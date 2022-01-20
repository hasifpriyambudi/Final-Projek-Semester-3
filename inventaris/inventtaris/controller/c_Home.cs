using System;
using System.Collections.Generic;
using System.Text;

namespace inventtaris.controller{
    class c_Home{
        model.modelHome modelHome;
        view.pageHome viewHome;

        public c_Home(view.pageHome viewHome){
            modelHome = new model.modelHome();
            this.viewHome = viewHome;
        }

        // total barang
        public void totalBarang(){
            viewHome.lblTotalBarang.Content = "(" + modelHome.totalBarang() + ")";
        }

        // total peminjaman
        public void totalPeminjaman(){
            viewHome.lblTotalPeminjaman.Content = "(" + modelHome.totalPeminjaman() + ")";
        }

        // total member
        public void totalMember(){
            viewHome.lblTotalMember.Content = "(" + modelHome.totalMember() + ")";
        }
    }
}
