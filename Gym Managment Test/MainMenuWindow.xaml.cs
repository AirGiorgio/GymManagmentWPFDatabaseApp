using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gym_Managment_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //część kodu, która najbardziej mi przeszkadza, to lambdy, które sprawdzają czy okienko danego typu jest już otwarte, aby nie można było
        //otwierać ich w nieskończoność. Niestety umieszczenie ich w klasie jest problematyczne, ponieważ część okienek w programie jest przeciążona
        //i pobiera różne argumenty. Tutaj akurat ten problem nie występuje.

        private void Clients_Click(object sender, RoutedEventArgs e)          
        {

            var existingWindow = Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.ClientViewWindow"; });
            if (existingWindow != null)
            {
                existingWindow.Activate();
                return;
            }
                ClientViewWindow cvw = new ClientViewWindow(); cvw.Show(); cvw.Focus();
        }

        private void SetPrice_Click(object sender, RoutedEventArgs e)
        {
            var existingWindow = Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.SetPrices"; });
            if (existingWindow != null)
            {
                existingWindow.Activate();
                return;
            }
                SetPrices sp = new SetPrices(); sp.Show(); sp.Focus();
          
        }

        private void Statistics_Click(object sender, RoutedEventArgs e)
        {
            var existingWindow = Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.FinancialStatistics"; });
            if (existingWindow != null)
            {
                existingWindow.Activate();
                return;
            }
                FinancialStatistics fs = new FinancialStatistics(); ; fs.Show(); fs.Focus();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
