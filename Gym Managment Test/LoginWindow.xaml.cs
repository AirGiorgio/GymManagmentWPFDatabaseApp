using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
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
    /// Logika interakcji dla klasy LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Errorlbl.Visibility = Visibility.Hidden;                          //ukrywa label error, jeśli dane logowania są niepoprawne
        }


        private void Login_Click(object sender, RoutedEventArgs e)
        {

            var db = new DbModel();                              //nieprofesjonalnie zrobione logowanie,
            var inquiry = from users in db.Users select users;   //kod przepuszcza dalej tylko jeśli dane w pamięci będą się zgadzały 
                                                                 //z tym co wpisał użytkownik w pola tekstowe, jednak nie jest to priorytet do poprawy
            foreach (var user in inquiry)
            {
                if (User.Text == user.UserName && Password.Password == user.Password)  //domyślnie dane logowania to :Admin i Haslo
                {
                    this.Hide();
                    MainWindow main = new MainWindow(); main.Show(); main.Focus(); 
                }
                else
                {
                    Errorlbl.Visibility = Visibility.Visible;
                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)         // dołączenie klawiszy do sterowania programem
        {
            if (e.Key == Key.Enter)
            {
                Login_Click(sender, e);
            }
            else if (e.Key == Key.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
