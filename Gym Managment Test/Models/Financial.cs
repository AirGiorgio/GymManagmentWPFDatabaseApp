using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Managment_Test
{
    public  class Financial
    {
        public int ClientsTotal { get; set; } 
        public int ClientsActive { get; set; } 
        public int ActiveOpen { get; set; } 
        public int ActiveHalfOpen { get; set; } 
        public int ActiveLimited { get; set; } 
        public int ActiveStudent { get; set; } 
        public decimal FinancialTotal { get; set; }  
        public decimal FinancialMonth { get; set; }  
        public decimal FinancialPasses { get; set; } 
        public decimal FinancialServices { get; set; } 
        public decimal Difference { get; set; }
        public decimal PercentageDifference { get; set; }
    }
}
