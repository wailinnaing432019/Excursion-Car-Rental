using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion_Car_Rental.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public int CategoryId {  get; set; }
        public string CarNo { get; set; }
        public string BrandName { get; set; }
        public int NumberOfSeats {  get; set; }
        public string DriverName {  get; set; }
        public string DriverLicense { get; set; }
        public string DriverPhone { get; set; }
        public string DriverAddress { get; set; }
        public int Status { get; set; }
        public string CarPhoto {  get; set; }
        public float Rank {  get; set; }
        public string CarDescription { get; set; }
        public string CreatedAt { get; set; }
    }
}
