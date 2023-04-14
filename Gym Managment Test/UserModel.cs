using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Managment_Test
{
    public class UserModel
    {
        [Column("Id")]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
