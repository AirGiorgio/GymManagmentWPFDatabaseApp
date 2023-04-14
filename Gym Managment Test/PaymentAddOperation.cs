using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Gym_Managment_Test
{
    public class PaymentAddOperation
    {
        public void Add(string origin, decimal sum)
        {
            PaymentModel payment = new PaymentModel()
            {
                Sum = sum,
                Origin = origin,
                PayDate = DateTime.Now
            };
            var db = new DbModel();

            db.Payments.Add(payment);
            db.SaveChanges();
        }
    }
}
