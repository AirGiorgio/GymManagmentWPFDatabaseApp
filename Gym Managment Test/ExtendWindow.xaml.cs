using Gym_Managment_Test.Repos;
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
        public int ID { get; set; }

        public ExtendWindow(int i)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ID = i;
            UpdateView uv = new UpdateView();
            this.category.ItemsSource = uv.Update();                //zapytanie z bazy danych wypełniające combobox aktualnymi danymi karnetów
            Prices = uv.GetPrices();                                
        }
    
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
            ClientRepo ced = new ClientRepo();          

            ced.ClientExtend(ID, category.SelectedIndex+1, passvalue);     

            PaymentRepo pay = new PaymentRepo();                             //dodawanie płatności 
            pay.AddPayment("karnet", Prices[category.SelectedIndex]);
            WindowServices.UpdateClientsView();
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
