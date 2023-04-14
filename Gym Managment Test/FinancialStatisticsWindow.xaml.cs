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
    /// Logika interakcji dla klasy FinancialStatistics.xaml
    /// </summary>
    public partial class FinancialStatistics : Window
    {
        public FinancialStatistics()      
        {
            InitializeComponent();

            ViewFinancials vf = new ViewFinancials();
            FinancialModel model = vf.ViewStatistics();

            ClientsTotal.Content = model.ClientsTotal.ToString(); //ilość klientów w sumie

            ActivePasses.Content = model.ClientsActive.ToString(); //ilość aktywnych klientów
             
            OpenPasses.Content = model.ActiveOpen.ToString(); //ilość aktywnych karnetów open

            HalfOpenPasses.Content = model.ActiveHalfOpen.ToString(); // ilość aktywnych karnetów half open

            LimitedPasses.Content = model.ActiveLimited.ToString();  // ilość aktywnych karnetów limited

            StudentPasses.Content = model.ActiveStudent.ToString();  // ilość aktywnych karnetów student

            FinancialMonth.Content = Math.Round(model.FinancialMonth,2).ToString(); //ilość pieniędzy zebranych w tym miesiącu:

            PassesTotal.Content = Math.Round(model.FinancialPasses, 2).ToString(); //w tym ilość pieniędzy zebranej z karnetów

            ServicesTotal.Content = Math.Round(model.FinancialServices, 2).ToString();//w tym ilość pieniędzy zebranej z usług 

            FinancialDifference.Content = Math.Round(model.Difference, 2).ToString();//różnica przychodów między tym a poprzednim miesiącem

            PercentageDifference.Content = Math.Round(model.PercentageDifference).ToString();//procent różnicy

            FinancialTotal.Content = Math.Round(model.FinancialTotal, 2).ToString();//ilość pieniędzy zebranych od początku działalności
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
