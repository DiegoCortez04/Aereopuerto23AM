using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aereopuerto.Entities
{
    public class Driver
    {
        [Key] public int PKDriver { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string INE { get; set; }
        public int Phone { get; set; }
    }
}
