using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Managment_Test
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
        [Column("Birth Date")]
        public DateTime BirthDate { get; set; }
        public string Telephone{ get; set; }
        public string PESEL { get; set; }

        [Column("Pass Type")]
        public int PassType { get; set; }

        [Column("Expiration Date")]
        public DateTime ExpDate { get; set; }
    }
}
