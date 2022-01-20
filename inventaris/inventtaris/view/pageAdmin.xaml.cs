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
    /// Interaction logic for pageAdmin.xaml
    /// </summary>
    public partial class pageAdmin : Page{
        controller.c_Admin c_Admin;
        public pageAdmin(){
            c_Admin = new controller.c_Admin(this);
            InitializeComponent();
            c_Admin.Getdata();
            c_Admin.Totaldata();
        }

        private void btnTambah(object sender, RoutedEventArgs e){
            c_Admin.Proses_tambah();  
        }

        private void dgadmin_SelectionChanged(object sender, SelectionChangedEventArgs e){
            if(dgadmin.SelectedItem != null)
            {
                object item = dgadmin.SelectedItem;
                idAdmin.Text = (dgadmin.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                namaAdmin.Text= (dgadmin.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                emailAdmin.Text = (dgadmin.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                userAdmin.Text= (dgadmin.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                buttonUpdate.IsEnabled = true;
                buttonTambah.IsEnabled = false;
                buttonCancel.IsEnabled = true;
                buttonDelete.IsEnabled = true;
            }
            else
            {
                cancel();
            }
        }

        private void cancel(){
            idAdmin.Text = "";
            namaAdmin.Text = "";
            emailAdmin.Text = "";
            userAdmin.Text = "";
            buttonUpdate.IsEnabled = false;
            buttonTambah.IsEnabled = true;
            buttonCancel.IsEnabled = false;
            buttonDelete.IsEnabled = false;
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e){
            cancel();
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e){
            c_Admin.Updateadmin();

            
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e){
            if (MessageBox.Show("Yakin ingin menghapus data?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                c_Admin.Deleteadmin();
                cancel();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e){
            c_Admin.Searchadmin();
        }
    }
}
