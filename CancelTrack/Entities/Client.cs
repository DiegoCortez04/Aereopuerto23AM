using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aereopuerto.Entities
{
    public class Client
    {
        [Key] public int PKCliente { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string INE { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string TypeService { get; set; }
        public int Passengers { get; set; }
        public int NoReserve { get; set; }
    }
}
