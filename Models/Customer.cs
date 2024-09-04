using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion_Car_Rental.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nrc {  get; set; }
        public string Address { get; set; }
        public string Phno { get; set; }
        public string Email {  get; set; }
        public string password { get; set; }
        public string Created_at { get; set; }
    }
}
