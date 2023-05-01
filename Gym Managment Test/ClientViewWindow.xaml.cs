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
            UpdateView();
        }
        public void UpdateView()                         //odświeża automatycznie datagrid zapytaniem z bazy danych
        {
            UpdateView uv = new UpdateView();
            DataGridList = uv.Update(this.DataGridList);
        }
        public void Update(string c)                         // datagrid wypełniony tylko klientami których użytkownik szuka po nazwisku  
        {
            UpdateView uv = new UpdateView();
            DataGridList = uv.Update(this.DataGridList, c);
        }
        private int validateDataGrid()                          //do operacji edycji lub usunięcia zaznaczonego klienta musi być Id 
        {
            Client c = (Client)DataGridList.SelectedItem;
            return c.Id;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WindowServices.ShowOrActivateWindow(typeof(ClientAddView), "ClientAddWindow");
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridList.SelectedCells.Count == 0)
            {
                return;
            }
            WindowServices.ShowEditWindow(validateDataGrid());
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridList.SelectedCells.Count == 0)
            {
                return;
            }
            WindowServices.ShowConfirmationWindow(validateDataGrid());
        }
        private void Extendcarnet_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridList.SelectedCells.Count == 0)
            {
                return;
            }
            WindowServices.ShowExtendWindow(validateDataGrid());
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void SearchHandler(object sender, KeyEventArgs e)        //Szukanie użytkownika 
        {
            if (e.Key != Key.Enter)                                      //wyłączamy enter
            {
                if (SearchBox.Text == "")
                {
                    UpdateView();
                }
                else
                {
                    Update(SearchBox.Text);                   
                }
            }
        }
   
        private void DataGridList_LoadingRow(object sender, DataGridRowEventArgs e)     //wyświetl klienta na czerwono jesli jego karnet się skończył
        { 
            Client client = e.Row.DataContext as Client;

            if (client.ExpDate < DateTime.Now.Date)
            {
                e.Row.Background = Brushes.DarkRed;
            }
        }
    }
}
