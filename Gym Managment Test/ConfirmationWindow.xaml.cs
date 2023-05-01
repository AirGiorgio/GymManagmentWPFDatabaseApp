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
    /// Logika interakcji dla klasy Confirmation.xaml
    /// </summary>
    public partial class Confirmation : Window
    {  
        public Confirmation(int i)          //potwierdzenie usunięcia klienta
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.TBlock.Text = "Czy na pewno chcesz usunąć zaznaczonego klienta?";
            Id = i;
        }
        public Confirmation()                //potwierdza zapisanie zmian w SetPrices
        { 
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.TBlock.Text = "Czy na pewno chcesz zatwierdzić zmiany?";  
        }
        public int Id { get; set; } = 0;

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            if (Id!=0)                                                        //odświeżamy widok poprzedniego okna jeśli to okienko ma usuwać klienta
            {
                ClientRepo cde = new ClientRepo();
                cde.ClientDelete(Id);
                WindowServices.UpdateClientsView();
            }
            else if (Id==0)                                                  // zapytanie do bazy danych wywoływane z poprzedniego okna  jeśli użytkownik zatwierdzi zmiany w tym okienku
            {
                WindowServices.UpdatePrices();
            }
            this.Close();
        }

        private void No_Click(object sender, RoutedEventArgs e)               //przywraca domyślne ceny w polach tekstowych Set Prices jeśli użytkownik nie zatwierdzi zmian lub wprowadzi niepoprawnie dane
        {
            WindowServices.LeavePrices();
            this.Close();              
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
            else if (e.Key == Key.Enter)
            {
                Yes_Click(sender, e);
            }
        }
    }
}
