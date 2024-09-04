﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion_Car_Rental.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Source { get; set; }

        public string Destination { get; set; }

        public string Description { get; set; }
        public int Price {  get; set; }
        public string Created_at {  get; set; }
    }
}
