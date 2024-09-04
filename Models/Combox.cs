using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion_Car_Rental.Models
{
    public class Combox
    {
 
            public string Text { get; set; }
            public object Value { get; set; }
        public double Price {  get; set; }
        public override string ToString()
        {
            return Text;
        }

    }
}
