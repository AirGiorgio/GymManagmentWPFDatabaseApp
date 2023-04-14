using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Managment_Test
{
   public class ClientDeleteOperation
    {
        public void ClientDelete(int i)
        {
            DbModel db = new DbModel();
            var inquiry = (from client in db.Clients
                             where client.Id.Equals(i)
                             select client).FirstOrDefault();

            if (inquiry != null)
            {
                db.Clients.Remove(inquiry);
                db.SaveChanges();
            }
        }
    }
}
