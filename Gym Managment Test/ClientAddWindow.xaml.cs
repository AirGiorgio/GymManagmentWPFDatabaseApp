using Gym_Managment_Test.Repos;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
 
    public partial class ClientAddView : Window
    {
        List<decimal> Prices;
        public int Id { get; set; } = 0;
        public ClientAddView()                                   //to okienko służy do dodania klienta
        {
            InitializeComponent();

            UpdateView uv = new UpdateView();
            this.category.ItemsSource = uv.Update();           //combobox wypełniony
            Prices = uv.GetPrices();                           //aktualne ceny karnetów
        }
        public ClientAddView(int i)                             //to okienko służy do edycji, wylącza możliwość dodania typu karnetu  
        {
            InitializeComponent();
            combo.Visibility = Visibility.Hidden;
            Id = i;
            Add.Content = "Uaktualnij";  
            GetClientById(Id);                                  //idzie zapytanie do bazy danych o wypełnienie pól tekstowych aktualnymi danymi klienta
        }

        private void GetClientById(int id)
        {  
            ClientRepo clientRepo = new ClientRepo();
            var inquiry = clientRepo.GetClientById(id); 

            if (inquiry!=null)
            {
                Name.Text = inquiry.Name;
                Surname.Text = inquiry.Surname;
                BirthDate.Mask = null;                                         
                BirthDate.Text = inquiry.BirthDate.ToString("yyyy-MM-dd");      
                Telephone.Text = inquiry.Telephone;
                PESEL.Text = inquiry.PESEL;
                category.Text = " ";
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ClientRepo cp = new ClientRepo();
            string message = "";
            message = validate(message);

            if (Id == 0 && message == "")                   //jeśli wywołane zostało pierwsze okienko a więc ID pozostało 0 następuje operacja dodania klienta
            {
                try
                {
                    cp.ClientAdd(
                    Name.Text.Trim(),
                    Surname.Text.Trim(),
                    Telephone.Text.Trim(),
                    BirthDate.Text.Trim(),
                    PESEL.Text.Trim(),
                    category.SelectedIndex + 1
                    );

                    PaymentRepo pay = new PaymentRepo();                           // dodanie płatności do bazy danych
                    pay.AddPayment("karnet", Prices[category.SelectedIndex]);      //tabela do statystki finansowej

                    message = "Pomyślnie dodano klienta!";                                   
                    WindowServices.ShowMessageWindow(message);
                }
                catch (System.FormatException)
                {
                    message = "Niepoprawne dane!";
                    WindowServices.ShowMessageWindow(message);
                    return;
                }
            }

            else if (Id != 0 && message == "")                         //jeśli wywołane zostało drugie okienko i Id !=0  następuje operacja edycji klienta
            {
                try
                {
                    cp.ClientEdit(
                        Id,
                    Name.Text,
                    Surname.Text,
                    Telephone.Text,
                    BirthDate.Text,
                    PESEL.Text
                    );

                    message = "Pomyślnie uaktualniono klienta!";                  //uda się jeśli metoda validate nie zmieni message 
                    WindowServices.ShowMessageWindow(message);
                }
                catch (System.FormatException)        
                {
                    message = "Niepoprawne dane!";
                    WindowServices.ShowMessageWindow(message);
                    return;
                }
            }  
        }
        private string validate(string msg)                                         //walidacja danych klienta
        {
            if (string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(Surname.Text)
            || string.IsNullOrEmpty(Telephone.Text) || string.IsNullOrEmpty(BirthDate.Text)
            || string.IsNullOrEmpty(PESEL.Text) || string.IsNullOrEmpty(category.Text)) 
            {
                string message = "Nie wypełniono wszystkich pól!";
                WindowServices.ShowMessageWindow(message);
                return msg = " ";
            }
            else if (Name.Text.Length >= 25 || Surname.Text.Length >= 25)
            {
                string message = "Imię lub nazwisko klienta są zbyt długie! Wprowadź akronim!";
                WindowServices.ShowMessageWindow(message);
                return msg = " ";
            }
            else if (PESEL.Text.Length  > 11)
            {
                string message = "Niepoprawna długość PESEL!";
                WindowServices.ShowMessageWindow(message);
                return msg = " ";
            }
            else if (Telephone.Text.Length > 9)
            {
                string message = "Niepoprawny numer telefonu!";
                WindowServices.ShowMessageWindow(message);
                return msg = " ";
            }
            return msg;
        }
        private void Ikeychanged(object sender, KeyEventArgs e)                    //możliwość wpisywania tylko liter  w polach imie i nazwisko i pomijania tab 
        {
            if (!(e.Key >= Key.A && e.Key <= Key.Z || e.Key == Key.Tab))
            {
                e.Handled = true;
            }
        }
        private void Wkeychanged(object sender, KeyEventArgs e)                    //możliwość wpisywania tylko cyfr w Pesel i telefon i pomijania tab 
        {
            if (!(e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Tab))
            {
                e.Handled = true;
            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)               
        {
            WindowServices.UpdateClientsView();
            this.Close();                                          
        }

    }
}
