using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion_Car_Rental.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int CarId {  get; set; }
        public int CustomerId {  get; set; }
        public int TripId {  get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public int TotalDay {  get; set; }
        public int Status {  get; set; }
        public double TotalAmount {  get; set; }
        public string CreatedAt {  get; set; }
    }
}
