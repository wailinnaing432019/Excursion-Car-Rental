using Excursion_Car_Rental.Models;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Excursion_Car_Rental.Services
{
    public class CustomerService
    {
        MySqlConnection con;
        MySqlCommand cmd;
        public CustomerService()
        {

            DBConnection dbConnection = new DBConnection();
            con = new MySqlConnection(dbConnection.connectionString);


        }

        public int saveCustomer(Customer cus)
        {
            con.Open();
            string query = @"
                            INSERT INTO customers ( `name`,`email`, `ph_no`, `address`)
                            VALUES (@name,@email,@phone,@address);
                            SELECT LAST_INSERT_ID();  ";

            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Clear();
            // Add parameters
            cmd.Parameters.AddWithValue("@name", cus.Name);
            cmd.Parameters.AddWithValue("@email", cus.Email);
            cmd.Parameters.AddWithValue("@phone", cus.Phno);
            cmd.Parameters.AddWithValue("@address", cus.Address);

            // Add other parameters as needed

            // Execute the query and get the newly inserted ID
            // Execute the query and get the newly inserted ID
            object result = cmd.ExecuteScalar();
            int newId = Convert.ToInt32(result);

            MessageBox.Show($"Newly created ID: {newId}");
            return newId;
        }

        public List<Customer> customers()
        {
            string query = "select * from customers;";
            List<Customer> result = new List<Customer>();
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = Int32.Parse(dr["id"].ToString());
                    customer.Name = dr["name"].ToString();
                    customer.Email = dr["email"].ToString();
                    customer.Address = dr["address"].ToString();
                    customer.Phno = dr["ph_no"].ToString();
                    customer.Created_at = dr["created_at"].ToString();
                    result.Add(customer);

                }

                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public List<Customer> searchCustomer(string text)
        {
            string query = "select * from customers where address like '" + text + "%' or name like '" + text + "%' or email like '" + text  + "%' or ph_no like '" +text + "%'";
            List<Customer> result = new List<Customer>();
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = Int32.Parse(dr["id"].ToString());
                    customer.Name = dr["name"].ToString();
                    customer.Email = dr["email"].ToString();
                    customer.Address = dr["address"].ToString();
                    customer.Phno = dr["ph_no"].ToString();
                    customer.Created_at = dr["created_at"].ToString();
                    result.Add(customer);

                }

                con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
    }
}
