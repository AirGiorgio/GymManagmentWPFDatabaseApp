using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Threading;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace Gym_Managment_Test
{
    public class UpdateView
    {
        DbModel db = new DbModel();
        private DataGrid list;
        public DataGrid Update(DataGrid list)                      //wypełnienie datagrid danymi klientów
        {
            this.list = list;
            var db = new DbModel();
            var inquiry = from client in db.Clients
                           orderby client.Id
                           select client;
            var result = inquiry.ToList();

            list.ItemsSource = result;
            return  list;
        }
        public DataGrid Update(DataGrid list, string c)                 //wypełnienie datagrid danymi klientów na szukane litery nazwiska
        {
            this.list = list;
            
            var inquiry = from client in db.Clients
                            where client.Surname.StartsWith(c)
                            select client;                           
            var result = inquiry.ToList();

            list.ItemsSource = result;
            return list;
        }

        public List<string> Update()                                  //wypełnienie comboboxa danymi o karnetach
        {
            var inquiry = from gympasses in db.GymPasses select gympasses.Name;
            List<string> list = inquiry.ToList();
            
            return list;  
        }
        public List<decimal> GetPrices()                             //pobranie cen karnetów
        {   
            var inquiry = from gympasses in db.GymPasses select gympasses.Price;
            List<decimal> Prices = inquiry.ToList();
            return Prices;
        }

    }
}
