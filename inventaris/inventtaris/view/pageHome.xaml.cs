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

namespace inventtaris.view{
    /// <summary>
    /// Interaction logic for pageHome.xaml
    /// </summary>
    public partial class pageHome : Page{

        controller.c_Home c_Home;
        public pageHome(){
            InitializeComponent();
            c_Home = new controller.c_Home(this);
            
            // get total barang
            c_Home.totalBarang();

            // get total peminjaman
            c_Home.totalPeminjaman();

            // get total member
            c_Home.totalMember();
        }
    }
}
