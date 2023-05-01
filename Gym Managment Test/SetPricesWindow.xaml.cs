using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
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
    /// Logika interakcji dla klasy SetPrices.xaml
    /// </summary>
    public partial class SetPrices : Window
    {
        public SetPrices()
        {
            InitializeComponent();
            GetData();
        }

        List<GymPass> inquiry1; 
        List<Services> inquiry2;
        List<decimal> i1= new List<decimal>();
        List<decimal> i2= new List<decimal>();
        List<string> in1;
        List<string> in2;

        private bool HasChanged = false;

        public void GetData()
        {
            DbModel db = new DbModel();
            try
            {
                inquiry1 = (from gympasses in db.GymPasses select gympasses).ToList();            //zapytanie z tabeli karnety
                inquiry2 = (from services in db.Services select services).ToList();               //zapytanie z tabeli usługi
               
                if (inquiry1 != null && inquiry2 !=null)            
                 {
                     OpenPrice.Text = Math.Round(inquiry1.FirstOrDefault(x => x.Name == "Open").Price, 2).ToString();      
                     HalfOpenPrice.Text = Math.Round(inquiry1.FirstOrDefault(x => x.Name == "Half Open").Price, 2).ToString(); 
                     LimitedPrice.Text = Math.Round(inquiry1.FirstOrDefault(x => x.Name == "Limited").Price, 2).ToString(); 
                     StudentPrice.Text = Math.Round(inquiry1.FirstOrDefault(x => x.Name == "Student").Price, 2).ToString(); 
                     OneTimerPrice.Text = Math.Round(inquiry1.FirstOrDefault(x => x.Name == "Jednorazowe").Price, 2).ToString(); 
                     TrainingPrice.Text = Math.Round(inquiry2.FirstOrDefault(x => x.Name == "Diet").Price, 2).ToString(); 
                     DietPrice.Text = Math.Round(inquiry2.FirstOrDefault(x => x.Name == "Training").Price, 2).ToString();
                }
            }
            catch (NullReferenceException)
            {
                WindowServices.ShowMessageWindow("Wystąpiły problemy z ładowaniem wartości!"); 
                this.Close();
            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)                         //jeśli użytkownik kliknie wyjdź, następuje sekwencja metod
        {
            CompareValues(); 
        }
        private void CompareValues()                  
        {   
            try
            {
                i1.Clear();
                i2.Clear();
                in1 = new List<string>() { OpenPrice.Text, HalfOpenPrice.Text, LimitedPrice.Text, StudentPrice.Text, OneTimerPrice.Text };
                in2 = new List<string>() { TrainingPrice.Text, DietPrice.Text };

                foreach (var item in in1)                                //czy wartości da się przekonwertować, czy format danych jest niepoprawny?
                {
                    i1.Add(decimal.Parse(item));
                }
                foreach (var item in in2)                                 
                {
                    i2.Add(decimal.Parse(item));
                }
            }
            catch (FormatException)
            {
                WindowServices.ShowMessageWindow("Nieprawidłowy format wartości!");
                GetData();
                return;
            }

            for (int i = 0; i < i1.Count; i++)       //następnie  porównuje wartości obecnych pól tekstowych z pierwotnymi z bazy danych z 1 zapytania
            {
                if (inquiry1[i].Price != i1[i])
                {
                    HasChanged = true;             //jeśli wartości sie zmieniły  
                }
            }

            for (int i = 0; i < i2.Count; i++)       //porównuje wartości obecnych pól tekstowych z pierwotnymi z bazy danych z 2 zapytania
            {
                if (inquiry2[i].Price != i2[i])
                {
                    HasChanged = true;  //jeśli wartości sie zmieniły 
                }
            }

            if (HasChanged)
            {
                WindowServices.ShowOrActivateWindow(typeof(Confirmation), "Gym_Managment_Test.Confirmation");
                HasChanged = false;
  
            }
            else
            {
                this.Close();
            }
        }
        public void UpdateValues()    //jeśli użytkownik zatwierdzi zmiany w confirmation window, zostanie striggerowana ta metoda
        {
            try
            {
                DbModel db = new DbModel();

                for (int i = 0; i < i1.Count; i++)
                {
                    inquiry1[i].Price = i1[i];           //uaktualnia wartości karnetów w pętli 1 zapytania
                    db.GymPasses.Update(inquiry1[i]);
                    db.SaveChanges();
                }

                for (int i = 0; i < i2.Count; i++)
                {
                    inquiry2[i].Price = i2[i];           //uaktualnia wartości usług w pętli 2 zapytania
                    db.Services.Update(inquiry2[i]);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                WindowServices.ShowMessageWindow("Wystąpił błąd: "+ ex.Message);  
            }
        }
        private void Ikeychanged(object sender, KeyEventArgs e)               //tylko cyfry i przecinki
        {
            if (!(e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Tab || e.Key == Key.OemComma && e.KeyboardDevice.Modifiers == ModifierKeys.None))
            {
                e.Handled = true;
            }
        }
    }
}
