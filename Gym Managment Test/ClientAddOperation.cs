using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Gym_Managment_Test
{
    public class ClientAddOperation
    {
        public void ClientAdd(string name, string surname, string telephone, string birthdate, string pesel, int passtype)
        {

            ClientModel client = new ClientModel()
            {
                Name = name,
                Surname = surname,
                Telephone = telephone,
                BirthDate = DateTime.Parse(birthdate),
                PESEL = pesel,
                PassType = passtype,
                ExpDate = DateTime.Now.AddDays(30)
            };
            var db = new DbModel();

            db.Clients.Add(client);
            db.SaveChanges();
           
        }
    }
}
