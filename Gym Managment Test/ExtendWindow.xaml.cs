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
using System.Windows.Shapes;

namespace Gym_Managment_Test
{
    /// <summary>
    /// Logika interakcji dla klasy ExtendWindow.xaml
    /// </summary>
    public partial class ExtendWindow : Window
    {
        List<decimal> Prices;
        public ExtendWindow(int i)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ID = i;
            UpdateView uv = new UpdateView();
            this.category.ItemsSource = uv.Update();                //zapytanie z bazy danych wypełniające combobox aktualnymi danymi karnetów
            Prices = uv.GetPrices();                                
        }
        private int ID;

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            string message;
            Error error;

            if (string.IsNullOrEmpty(category.Text))         //jeśli nic nie zostało wybrane
            {
                message = "Zaznacz rodzaj karnetu";
                error = new Error(message);
                return;  
            }
            string passvalue = category.Text;
            ClientExtendOperation ced = new ClientExtendOperation();          
            ced.ClientExtend(ID, category.SelectedIndex+1, passvalue);    //problematyczne 

            PaymentAddOperation pay = new PaymentAddOperation();     //dodawanie płatności, jak w client add window
            pay.Add("karnet", Prices[category.SelectedIndex]);

            ClientViewWindow aw = (ClientViewWindow)Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.ClientViewWindow"; });
            if (aw != null)
            {
                aw.Update();                  //uaktualnienie widoku
            }
            this.Close();

            message = "Uaktualniono karnet!";
            error = new Error(message);
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
            else if (e.Key == Key.Enter)
            {
                OK_Click(sender, e);
            }
        }
    }
}
