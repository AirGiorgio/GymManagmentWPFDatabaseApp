using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Logika interakcji dla klasy ClientViewWindow.xaml
    /// </summary>
    public partial class ClientViewWindow : Window
    {
       
       public ClientViewWindow()
        {
            InitializeComponent();
            Update();
        }
        public void Update()              //odświeża automatycznie datagrid zapytaniem z bazy danych
        {
            UpdateView uv = new UpdateView();
            DataGridList = uv.Update(this.DataGridList);
            
        }
        public void Update(string c)    // datagrid wypełniony tylko klientami których użytkownik szuka po nazwisku - string c
        {
            UpdateView uv = new UpdateView();
            DataGridList = uv.Update(this.DataGridList, c);
        }
        private int validateDataGrid()       //do operacji edycji lub usunięcia zaznaczonego klienta musi być Id 
        {
            ClientModel c = (ClientModel)DataGridList.SelectedItem;
            return c.Id;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var existingWindow = Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.ClientAddWindow"; });
            if (existingWindow != null)
            {
                existingWindow.Activate();
                return;
            }
            else
            {
                ClientAddView cav = new ClientAddView(); cav.Show(); cav.Focus();    //Okienko przeciążone, dodaje użytkownika, nie pobiera nic
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridList.SelectedCells.Count == 0)
            {
                return;
            }
            var existingWindow = Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.ClientAddWindow"; });
            if (existingWindow != null)
            {
                existingWindow.Activate();
                return;
            }
            else
            {
                ClientAddView cav = new ClientAddView(validateDataGrid()); cav.Show(); cav.Focus();  //Okienko przeciązone, edytuje użytkownika, pobiera int ID
            } 
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridList.SelectedCells.Count == 0)
            {
                return;
            }
            var existingWindow = Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.Confirmation"; });
            if (existingWindow != null)
            {
                existingWindow.Activate();
                return;
            }
            else
            {
             Confirmation c = new Confirmation(validateDataGrid()); c.Show(); c.Focus();  //Ta metoda usuwa użytkownika, pobiera int ID
            }
        }
        private void Extendcarnet_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridList.SelectedCells.Count == 0)
            {
                return;
            }
            var existingWindow = Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.ExtendWindow"; });
            if (existingWindow != null)
            {
                existingWindow.Activate();
                return;
            }
            ExtendWindow ce = new ExtendWindow(validateDataGrid()); ce.Show(); ce.Focus();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void SearchHandler(object sender, KeyEventArgs e)        //Szukanie użytkownika , delegat od Key Up i Key Down w kodzie xaml
        {
            if (e.Key != Key.Enter) //ale wyłączamy enter bo może namieszać
            {
                if (SearchBox.Text == "")
                {
                    Update();
                }
                else
                {
                    Update(SearchBox.Text);                   
                }
            }
        }
   
        private void DataGridList_LoadingRow(object sender, DataGridRowEventArgs e)     //wyświetl klienta na czerwono jesli jego karnet się skończył
        { 
            ClientModel client = e.Row.DataContext as ClientModel;

            if (client.ExpDate < DateTime.Now.Date)
            {
                e.Row.Background = Brushes.DarkRed;
            }
        }
    }
}
