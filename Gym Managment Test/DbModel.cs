using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Gym_Managment_Test
{
    public class DbModel : DbContext
    {

        public DbSet<ClientModel> Clients { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<GymPassView> GymPasses { get; set; }

        public DbSet<PaymentModel> Payments { get; set; }

        public DbSet<ServicesModel> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)                  
        => options.UseSqlServer("Data Source =.; Initial Catalog = Gym Managment; Integrated Security = True");


    }
}
