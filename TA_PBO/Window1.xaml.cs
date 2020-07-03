using System.Windows;

namespace TA_PBO
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(UnsurResult unsurResult)
        {
            InitializeComponent();
            afinitasElektron.Content = unsurResult.ElectronAffinity;
            bonding.Content = unsurResult.BondingType;
            titikDidih.Content = unsurResult.MeltingPoint;
            energiIonisasi.Content = unsurResult.IonizationEnergy;
            jari.Content = unsurResult.AtomicRadius;
            keelektronegatifan.Content = unsurResult.ElectroNegativity;
            konfigurasiElektron.Content = unsurResult.ElectronicConfiguration;
            nama.Text = unsurResult.Name;
            simbolUnsur.Content = unsurResult.Symbol;
            nomorAtom.Content = unsurResult.atomicNumber;
            nomorMassa.Content = unsurResult.AtomicMass;
        }

        public Window1()
        {
            InitializeComponent();
        }

        private void BtnCari_Click(object sender, RoutedEventArgs e)
        {
            UnsurResult unsurResult = new UnsurResult();
            UnsurNama unsur = new UnsurNama();
            unsurResult = unsur.ReturnValue(nama.Text);
            afinitasElektron.Content = unsurResult.ElectronAffinity;
            bonding.Content = unsurResult.BondingType;
            titikDidih.Content = unsurResult.MeltingPoint;
            energiIonisasi.Content = unsurResult.IonizationEnergy;
            jari.Content = unsurResult.AtomicRadius;
            keelektronegatifan.Content = unsurResult.ElectroNegativity;
            konfigurasiElektron.Content = unsurResult.ElectronicConfiguration;
            simbolUnsur.Content = unsurResult.Symbol;
            nomorAtom.Content = unsurResult.atomicNumber;
            nomorMassa.Content = unsurResult.AtomicMass;
            MainWindow wpf = new MainWindow();
            wpf.Simpan(nama.Text);
        }
    }
}
