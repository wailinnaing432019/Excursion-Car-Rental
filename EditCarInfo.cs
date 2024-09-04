using Excursion_Car_Rental.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursion_Car_Rental
{
    public partial class EditCarInfo : Form
    {
        DBConnection conn = new DBConnection();
        public int car_id;
        public EditCarInfo(int carId,int category_id,string carNumber,string carBrand,int noOfSeat,string driverName,string driverLincense,string driverPhNo,string driverAddress)
        {
            InitializeComponent();
            car_id = carId;
            string query = "SELECT id, type FROM categories";
            MySqlConnection myCon = new MySqlConnection(conn.connectionString);
            try
            {
                myCon.Open();
                MySqlCommand command = new MySqlCommand(query, myCon);
                MySqlDataReader reader = command.ExecuteReader();

                // Clear previous items in case the ComboBox is reused
                editCategoryComboBox.Items.Clear();

                int selectedIndex = -1;

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string type = reader.GetString("type");

                    // Add item to ComboBox
                    editCategoryComboBox.Items.Add($"{id} - {type}");

                    // If this item's id matches category_id, remember its index
                    if (id == category_id)
                    {
                        selectedIndex = editCategoryComboBox.Items.Count - 1;  // Remember the index
                    }
                }

                // Set the selected index if a match was found
                if (selectedIndex != -1)
                {
                    editCategoryComboBox.SelectedIndex = selectedIndex;
                }
                else
                {
                    // Optionally handle the case where no match was found, e.g., select the first item
                    if (editCategoryComboBox.Items.Count > 0)
                    {
                        editCategoryComboBox.SelectedIndex = 0;
                    }
                }

                reader.Close();
                myCon.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            carNumberTextBox.Text = carNumber;
            carBrandTextBox.Text = carBrand;
            noOfSeatsTextBox.Text = noOfSeat.ToString();
            driverNameTextBox.Text = driverName;
            driverLicenseTextBox.Text = driverLincense;
            driverPhNoTextBox.Text = driverPhNo;
            driverAddressTextBox.Text = driverAddress;
        }

        // close the edit car info form when clicked close button
        private void editCarInfoFormClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carInfoUpdateBtn(object sender, EventArgs e)
        { 
            // get selected item from comboBox
            string selectedCategory = editCategoryComboBox.SelectedItem.ToString();
            // separat number from the selected item
            int editCategoryId = int.Parse(selectedCategory.Split('-')[0].Trim());

            string editCarNumber = carNumberTextBox.Text;
            string editCarBrand = carBrandTextBox.Text;
            int editNoOfSeats = int.Parse(noOfSeatsTextBox.Text);
            string editDriverName = driverNameTextBox.Text;
            string editDriverLicense = driverLicenseTextBox.Text;
            string editDriverPhNo = driverPhNoTextBox.Text;
            string editDriverAddress = driverAddressTextBox.Text;

            carInfoUpdate(editCategoryId,editCarNumber,editCarBrand, editNoOfSeats, editDriverName, editDriverLicense, editDriverPhNo, editDriverAddress);
            this.Close();
        }

        private void carInfoUpdate(int category_id, string carNumber, string carBrand, int noOfSeat, string driverName, string driverLincense, string driverPhNo, string driverAddress)
        {
            string query = "UPDATE manage_cars SET category_id=@editCategoryId,car_no=@editCarNumber,brand_name=@editCarBrand,no_of_seat=@editNoOfSeats,driver_name=@editDriverName,driver_lincense=@editDriverLicense,driver_ph_no=@editDriverPhNo,driver_address=@editDriverAddress WHERE id=" + car_id;
            MySqlConnection myCon = new MySqlConnection(conn.connectionString);
            MySqlCommand command = new MySqlCommand(query, myCon);
            command.Parameters.AddWithValue("@editCategoryId",category_id);
            command.Parameters.AddWithValue("@editCarNumber", carNumber);
            command.Parameters.AddWithValue("@editCarBrand", carBrand);
            command.Parameters.AddWithValue("@editNoOfSeats", noOfSeat);
            command.Parameters.AddWithValue("@editDriverName", driverName);
            command.Parameters.AddWithValue("@editDriverLicense", driverLincense);
            command.Parameters.AddWithValue("@editDriverPhNo", driverPhNo);
            command.Parameters.AddWithValue("@editDriverAddress", driverAddress);

            try
            {
                myCon.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Car informations update successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reload()
        {

        }
    }
}
