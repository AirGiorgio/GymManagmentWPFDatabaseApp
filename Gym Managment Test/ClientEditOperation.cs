using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gym_Managment_Test
{
    public class ClientEditOperation
    {
        public void ClientEdit(int ID, string name, string surname, string telephone, string birthdate, string pesel)
        {
            var db = new DbModel();
            var inquiry = (from client in db.Clients where client.Id.Equals(ID) select client).FirstOrDefault();

            if (inquiry != null)
            {
                inquiry.Name = name;
                inquiry.Surname = surname;
                inquiry.BirthDate = DateTime.Parse(birthdate);
                inquiry.Telephone = telephone;
                inquiry.PESEL = pesel;
                
                db.Clients.Update(inquiry);
                db.SaveChanges();
            }
        }
   
    }
}
