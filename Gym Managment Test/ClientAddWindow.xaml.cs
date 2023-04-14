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
    /// <summary>
    /// Logika interakcji dla klasy ClientAddView.xaml
    /// </summary>
    public partial class ClientAddView : Window
    {
        List<decimal> Prices;
        public ClientAddView() //to okienko służy do dodania klienta
        {
            InitializeComponent();

            UpdateView uv = new UpdateView();
            this.category.ItemsSource = uv.Update();  //idzie zapytanie do bazy danych o wypełnienie comboboxa aktualnymi typami karnetu
            Prices = uv.GetPrices();                   //idzie zapytanie do bazy danych o pobranie aktualnych cen karnetów
        }
        public ClientAddView(int i)   //to okienko służy do edycji, wylącza możliwość dodania typu karnetu  
        {
            InitializeComponent();
            combo.Visibility = Visibility.Hidden;
            Id = i;
            Add.Content = "Uaktualnij";
            GetClient(Id);                     //idzie zapytanie do bazy danych o wypełnienie pól tekstowych aktualnymi danymi klienta
        }

        private void GetClient(int id)
        {
            DbModel db = new DbModel();
            var inquiry = (from client in db.Clients where client.Id.Equals(id) select client).FirstOrDefault();
            if (inquiry!=null)
            {
                Name.Text = inquiry.Name;
                Surname.Text = inquiry.Surname;
                BirthDate.Mask = null;                                         //masked text box jest dosyć problematyczny, najpierw wyłączam maskę
                BirthDate.Text = inquiry.BirthDate.ToString("yyyy-MM-dd");      //maska tworzy się na nowo automatycznie formatem daty z bazy danych 
                Telephone.Text = inquiry.Telephone;
                PESEL.Text = inquiry.PESEL;
                category.Text = " ";
            }
        }

        private int Id = 0;  //domyślnie zero, chyba że zostanie nadpisany

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string message = "";
            Error error;
            message = validate(message);

            if (Id == 0 && message == "")                   //jeśli wywołane zostało pierwsze okienko a więc ID pozostało 0 następuje operacja dodania klienta
            {
                try
                {
                    ClientAddOperation cp = new ClientAddOperation();
                    cp.ClientAdd(
                    Name.Text.Trim(),
                    Surname.Text.Trim(),
                    Telephone.Text.Trim(),
                    BirthDate.Text.Trim(),
                    PESEL.Text.Trim(),
                    category.SelectedIndex + 1
                    );

                    PaymentAddOperation pay = new PaymentAddOperation();    // dodanie płatności do bazy danych
                    pay.Add("karnet", Prices[category.SelectedIndex]);      //tabela do statystki finansowej

                    message = "Pomyślnie dodano klienta!";                 //uda się jeśli metoda validate nie zmieni message           
                    error = new Error(message);
                    error.Show();
                }
                catch (System.FormatException)
                {
                    message = "Niepoprawne dane!";
                    error = new Error(message);
                    error.Show();
                    return;
                }
            }

            else if (Id != 0 && message == "")         //jeśli wywołane zostało drugie okienko i Id !=0  następuje operacja edycji klienta
            {
                try
                {
                    ClientEditOperation cp = new ClientEditOperation();
                    cp.ClientEdit(
                        Id,
                    Name.Text,
                    Surname.Text,
                    Telephone.Text,
                    BirthDate.Text,
                    PESEL.Text
                    );

                    message = "Pomyślnie uaktualniono klienta!";         //uda się jeśli metoda validate nie zmieni message 
                    error = new Error(message);                       
                    error.Show();
                }
                catch (System.FormatException)        
                {
                    message = "Niepoprawne dane!";
                    error = new Error(message);
                    error.Show();
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
                Error error = new Error(message);
                error.Show();
                return msg = " ";
            }
            else if (Name.Text.Length >= 25 || Surname.Text.Length >= 25)
            {
                string message = "Imię lub nazwisko klienta są zbyt długie! Wprowadź akronim!";
                Error error = new Error(message);
                error.Show();
                return msg = " ";
            }
            else if (PESEL.Text.Length  > 11)
            {
                string message = "Niepoprawna długość PESEL!";
                Error error = new Error(message);
                error.Show();
                return msg = " ";
            }
            else if (Telephone.Text.Length > 9)
            {
                string message = "Niepoprawny numer telefonu!";
                Error error = new Error(message);
                error.Show();
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
        private void Wkeychanged(object sender, KeyEventArgs e)          //możliwość wpisywania tylko cyfr w Pesel i telefon i pomijania tab 
        {
            if (!(e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Tab))
            {
                e.Handled = true;
            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            ClientViewWindow aw = (ClientViewWindow)Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.ClientViewWindow"; });
            if (aw != null)
            {
                aw.Update();
            }
            this.Close();                              //triggerowanie metody poprzedniego okienka, aby się odświeżył widok klientów automatycznie przy zamykaniu tego okienka
        }

    }
}
