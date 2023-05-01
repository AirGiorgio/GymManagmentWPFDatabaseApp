using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gym_Managment_Test
{
    public static class WindowServices
    {
        public static void ShowOrActivateWindow(Type windowType, string windowTitle)
        {
            var existingWindow = Application.Current.Windows.Cast<Window>().SingleOrDefault(w => w.GetType() == windowType && w.Title == windowTitle);
            if (existingWindow != null)
            {
                existingWindow.Activate();
                return;
            }
            var newWindow = (Window)Activator.CreateInstance(windowType);
            newWindow.Title = windowTitle;
            newWindow.Show();
            newWindow.Focus();
        }
        public static void ShowEditWindow(int i)
        {
            var existingWindow = Application.Current.Windows.OfType<ClientAddView>().FirstOrDefault(w => w.Id == i);
            if (existingWindow != null)
            {
                existingWindow.Activate();
            }
            else
            {
                ClientAddView Cav = new ClientAddView(i); Cav.Show(); Cav.Focus();  
            }
        }

        public static void ShowExtendWindow(int i)
        {
            var existingWindow = Application.Current.Windows.OfType<ExtendWindow>().FirstOrDefault(w => w.ID == i);
            if (existingWindow != null)
            {
                existingWindow.Activate(); 
                return;
            }
            ExtendWindow Ew = new ExtendWindow(i); Ew.Show(); Ew.Focus();
        }

        public static void ShowConfirmationWindow(int i)
        {
            var existingWindow = Application.Current.Windows.OfType<Confirmation>().FirstOrDefault(w => w.Id == i);
            if (existingWindow != null)
            {
                existingWindow.Activate();  
                return;
            }
            else
            {
                Confirmation C = new Confirmation(i); C.Show(); C.Focus();  
            }
        }

        public static void ShowMessageWindow(string message)
        {
            var existingWindow = Application.Current.Windows.OfType<Error>().FirstOrDefault(w => w.TBlock.Text == message);
            if (existingWindow != null)
            {
                existingWindow.Activate();
                return;
            }
            Error e = new Error(message);
            e.Show();
            e.Focus();

        }

        public static void UpdatePrices()
        {
            SetPrices sp = (SetPrices)Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.SetPrices"; });
            if (sp != null)
            {
                sp.UpdateValues();
                sp.Close();
            }
        }

        public static void LeavePrices()
        {
            SetPrices sp = (SetPrices)Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.SetPrices"; });
            if (sp != null)
            {
                sp.GetData(); 
            }
        }

        public static void UpdateClientsView()
        {
            ClientViewWindow aw = (ClientViewWindow)Application.Current.Windows.Cast<Window>().SingleOrDefault(w => { return w.GetType().ToString() == "Gym_Managment_Test.ClientViewWindow"; });
            if (aw != null)
            {
                aw.UpdateView();
            }
        }
    }
}
