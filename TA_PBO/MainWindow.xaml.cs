using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using TA_PBO.RiwayatDataSetTableAdapters;

namespace TA_PBO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string NamaUnsur { get; set; }
        string url = "https://periodic-table-api.herokuapp.com/atomicSymbol/";
        UnsurResult unsurTest;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            NamaUnsur = button.Name;
            Unsur unsur = new Unsur();
            unsurTest = new UnsurResult();
            unsurTest = unsur.ReturnValue(url, NamaUnsur);
            Window1 wpf = new Window1(unsurTest);
            Simpan(NamaUnsur);
            //RiwayatTableAdapter.Fill(RiwayatDataSet.);
            wpf.Show();
        }        
        private void btnLeftMenuHide_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbHideLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }

        private void btnLeftMenuShow_Click(object sender, RoutedEventArgs e)
        {

            ShowHideMenu("sbShowLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }
        private void ShowHideMenu(string Storyboard, Button btnHide, Button btnShow, StackPanel pnl)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(pnl);

            if (Storyboard.Contains("Show"))
            {
                btnHide.Visibility = System.Windows.Visibility.Visible;
                btnShow.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (Storyboard.Contains("Hide"))
            {
                btnHide.Visibility = System.Windows.Visibility.Hidden;
                btnShow.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Bantuan_Click(object sender, RoutedEventArgs e)
        {
            Bantuan wpf = new Bantuan();
            wpf.Show();
        }

        private void Cari_Click(object sender, RoutedEventArgs e)
        {
            Window1 wpf = new Window1();
            wpf.Show();
        }
        private void Riwayat_Click(object sender, RoutedEventArgs e)
        {
            Riwayat wpf = new Riwayat();
            wpf.Show();
        }
        public void Simpan(string unsur)
        {
            string connectionString = string.Format(Properties.Settings.Default.RiwayatConnectionString, Environment.CurrentDirectory);

            DateTime now = DateTime.Today;
            string noww = now.ToString("F");

            string insertSQL = string.Format(Properties.Settings.Default.InsertSQL, unsur, noww);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(insertSQL);
                command.Connection = connection;
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
