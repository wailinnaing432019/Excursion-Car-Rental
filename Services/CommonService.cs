using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursion_Car_Rental.Services
{
    public class CommonService
    {

        MySqlConnection con;
        MySqlCommand cmd;
        
        public CommonService()
        {

            DBConnection dbConnection = new DBConnection();
            con = new MySqlConnection(dbConnection.connectionString);

        }
        public int totalCustomer()
        {
            int totalCus=0;
            string query = "SELECT COUNT(*) FROM customers";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }

        public int totalCars()
        {
            int totalCus = 0;
            string query = "SELECT COUNT(*) FROM manage_cars";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }
        public int availableCars()
        {
            int totalCus = 0;
            string query = "SELECT COUNT(*) FROM manage_cars where status=2";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }

        public int unAvailableCars()
        {
            int totalCus = 0;
            string query = "SELECT COUNT(*) FROM manage_cars where status=0";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }

        public int totalTrips()
        {
            int totalCus = 0;
            string query = "SELECT COUNT(*) FROM trips";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }

        public int totalOrders()
        {
            int totalCus = 0;
            string query = "SELECT COUNT(*) FROM orders";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }


        public int totalIncome()
        {
            int totalCus = 0;
            string query = "SELECT SUM(total_amount) FROM orders WHERE status = 2";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }

        public int totalCancelAmount()
        {
            int totalCus = 0;
            string query = "SELECT SUM(total_amount) FROM orders WHERE status = 3";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }

        public int totalPendingAmount()
        {
            int totalCus = 0;
            string query = "SELECT SUM(total_amount) FROM orders WHERE status = 0";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }


        public int totalPendingOrders()
        {
            int totalCus = 0;
            string query = "SELECT COUNT(*) FROM orders where status=0";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }

        public int totalCompleteOrders()
        {
            int totalCus = 0;
            string query = "SELECT COUNT(*) FROM orders where status=3";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }

        public int totalCancelOrders()
        {
            int totalCus = 0;
            string query = "SELECT COUNT(*) FROM orders where status=0";

            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                totalCus = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return totalCus;
        }


    }
}
