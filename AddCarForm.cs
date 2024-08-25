using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursion_Car_Rental
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        DBConnection conn = new DBConnection();

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT id, type FROM categories";
            MySqlConnection myCon = new MySqlConnection(conn.connectionString);
            try
            {
                myCon.Open();
                MySqlCommand command = new MySqlCommand(query, myCon);
                MySqlDataReader reader = command.ExecuteReader();

                // clear existing items
                categoryComboBox.Items.Clear();

                while (reader.Read()) 
                {
                    int id = reader.GetInt32("id");
                    string type = reader.GetString("type");

                    // Combine id and type for display
                    categoryComboBox.Items.Add($"{id} - {type}");
                }

                // Optionally, set the default selected item
                if (categoryComboBox.Items.Count > 0) 
                {
                    // select the first item by default
                    categoryComboBox.SelectedIndex = 0;
                }
                reader.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // get selected item from comboBox
            string selectedCategory = categoryComboBox.SelectedItem.ToString();

            // separat number from the selected item
            int categoryId = int.Parse(selectedCategory.Split('-')[0].Trim());

            string carNumber = carNumberTextBox.Text;
            string carBrand = carBrandTextBox.Text;
            int noOfSeats = int.Parse(noOfSeatsTextBox.Text);
            string driverName = driverNameTextBox.Text;
            string driverLicense = driverLicenseTextBox.Text;
            string driverPhNo = driverPhNoTextBox.Text;
            string driverAddress = driverAddressTextBox.Text;

            // insert data into database
            InsertCarInfo(categoryId,carNumber, carBrand, noOfSeats, driverName, driverLicense, driverPhNo, driverAddress);
            
            // after insert car informations and then adding form close
            this.Close();
        }

        // adding car info to database function used in saveBtn_Click
        private void InsertCarInfo(int categoryId,string carNumber,string carBrand,int noOfseats, string driverName, string driverLicense, string driverPhNo, string driverAddress)
        {
            string query = "INSERT INTO manage_cars (category_id,car_no,brand_name,no_of_seat,driver_name,driver_lincense,driver_ph_no,driver_address) VALUES (@categoryId,@carNumber,@carBrand,@noOfSeats,@driverName,@driverLicense,@driverPhNo,@driverAddress)";
            MySqlConnection myCon = new MySqlConnection(conn.connectionString);
            MySqlCommand command = new MySqlCommand(query, myCon);
            command.Parameters.AddWithValue("@categoryId",categoryId);
            command.Parameters.AddWithValue("@carNumber",carNumber);
            command.Parameters.AddWithValue("@carBrand", carBrand);
            command.Parameters.AddWithValue("@noOfSeats", noOfseats);
            command.Parameters.AddWithValue("@driverName",driverName);
            command.Parameters.AddWithValue("@driverLicense", driverLicense);
            command.Parameters.AddWithValue("@driverPhNo", driverPhNo);
            command.Parameters.AddWithValue("@driverAddress", driverAddress);

            try
            {
                myCon.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Car infomations saved successfully.");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        // close the form when click this button
        private void carAddFormCloseBtn(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
