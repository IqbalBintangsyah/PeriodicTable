using System.Data.SqlClient;
using System.Windows;

namespace TA_PBO
{
    /// <summary>
    /// Interaction logic for Riwayat.xaml
    /// </summary>
    public partial class Riwayat : Window
    {
        public Riwayat()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            TA_PBO.RiwayatDataSet riwayatDataSet = ((TA_PBO.RiwayatDataSet)(this.FindResource("riwayatDataSet")));
            // Load data into the table Riwayat. You can modify this code as needed.
            TA_PBO.RiwayatDataSetTableAdapters.RiwayatTableAdapter riwayatDataSetRiwayatTableAdapter = new TA_PBO.RiwayatDataSetTableAdapters.RiwayatTableAdapter();
            riwayatDataSetRiwayatTableAdapter.Fill(riwayatDataSet.Riwayat);
            System.Windows.Data.CollectionViewSource riwayatViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("riwayatViewSource")));
            riwayatViewSource.View.MoveCurrentToFirst();
        }
    }
}
