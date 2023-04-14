using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Managment_Test
{
    public class PaymentModel
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
         
        public string Origin { get; set; }

        public DateTime PayDate { get; set; }
        
        public decimal Sum { get; set; }
    }
}
