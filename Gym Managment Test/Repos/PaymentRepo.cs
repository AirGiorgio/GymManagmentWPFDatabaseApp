using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Managment_Test.Repos
{
   public class PaymentRepo
    {
        public void AddPayment(string origin, decimal sum)
        {
            Payment payment = new Payment()
            {
                Sum = sum,
                Origin = origin,
                PayDate = DateTime.Now
            };
            var db = new DbModel();

            db.Payments.Add(payment);
            db.SaveChanges();
        }

        public Financial ViewStatistics()
        {
            DbModel db = new DbModel();

            decimal denumerator = (from payments in db.Payments
                                   where payments.PayDate.Month == DateTime.Now.Month - 1
                                   select payments.Sum).Sum();                                 //jeśli za ostatni miesiąc nie ma przychodów, nie możemy dzielić przez 0

            if (denumerator == 0)
            {
                denumerator = 1;
            }

            Financial model = new Financial()
            {
                ClientsTotal = db.Clients.Count(),

                ClientsActive = db.Clients.Where(x => x.ExpDate >= DateTime.Now).Count(),

                ActiveOpen = db.Clients.Where(x => x.ExpDate >= DateTime.Now && x.PassType == 1).Count(),

                ActiveHalfOpen = db.Clients.Where(x => x.ExpDate > DateTime.Now && x.PassType == 2).Count(),

                ActiveLimited = db.Clients.Where(x => x.ExpDate > DateTime.Now && x.PassType == 3).Count(),

                ActiveStudent = db.Clients.Where(x => x.ExpDate > DateTime.Now && x.PassType == 4).Count(),

                FinancialTotal = (from payments in db.Payments select payments.Sum).Sum(),

                FinancialMonth = (from payments in db.Payments where payments.PayDate.Month == DateTime.Now.Month select payments.Sum).Sum(),

                FinancialPasses = (from payments in db.Payments where payments.Origin == "karnet" select payments.Sum).Sum(),

                FinancialServices = (from payments in db.Payments where payments.Origin == "usluga" select payments.Sum).Sum(),

                Difference = (from payments in db.Payments where payments.PayDate.Month == DateTime.Now.Month select payments.Sum).Sum() -
                (from payments in db.Payments where payments.PayDate.Month == DateTime.Now.Month - 1 select payments.Sum).Sum(),

                PercentageDifference = (((from payments in db.Payments where payments.PayDate.Month == DateTime.Now.Month select payments.Sum).Sum() -
                 (from payments in db.Payments where payments.PayDate.Month == DateTime.Now.Month - 1 select payments.Sum).Sum()) / denumerator * 100)

            };
            return model;

        }
    }
}
