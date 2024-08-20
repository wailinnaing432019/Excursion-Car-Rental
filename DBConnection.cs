using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursion_Car_Rental
{
    internal class DBConnection
    {
        public string connectionString; 
        public DBConnection() {
            connectionString = "server=127.0.0.1;user=root;database=excursion_car_rentaldb;password= ";
 
        }
    }

}
