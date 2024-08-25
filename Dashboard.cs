using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Dashboard : MaterialForm
{
        public Dashboard()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange900, Primary.Orange900, Accent.DeepOrange400, TextShade.WHITE);
        }
        DBConnection conn = new DBConnection();
        private void tabPage5_Click(object sender, EventArgs e)
        {
            // retrieve type column from categories table by Table INNER JOIN
            string query = @"
                SELECT 
                    manage_cars.id AS carId,
                    manage_cars.category_id AS category_id,
                    manage_cars.car_no AS carNumber,
                    categories.type AS Type, 
                    manage_cars.brand_name AS carBrand,
                    manage_cars.no_of_seat AS noOfSeat,
                    manage_cars.driver_name AS driverName,
                    manage_cars.driver_lincense AS driverLincense,
                    manage_cars.driver_ph_no AS driverPhNo,
                    manage_cars.driver_address AS driverAddress
                    FROM manage_cars
                    INNER JOIN categories ON manage_cars.category_id = categories.id";
            //for hold the data
            DataTable dt = new DataTable();
            MySqlConnection myCon = new MySqlConnection(conn.connectionString);
            try
            {
                myCon.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, myCon);
                mySqlDataAdapter.Fill(dt);
                dataGridView_CarList.DataSource = dt;
                changeColumnName();

                // add edit and delete buttons in dataGridView
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                editColumn.Name = "editColumn";
                editColumn.HeaderText = "Edit";
                editColumn.Width = 60;
                editColumn.Text = "Edit";
                editColumn.UseColumnTextForButtonValue = true;
                dataGridView_CarList.Columns.Add(editColumn);

                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
                deleteColumn.Name = "deleteColumn";
                deleteColumn.HeaderText = "Delete";
                deleteColumn.Width = 60;
                deleteColumn.Text = "Delete";
                deleteColumn.UseColumnTextForButtonValue = true;
                dataGridView_CarList.Columns.Add(deleteColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                myCon.Close();
            }
        }
        /* this function perform change desire name and not visible category_id column that it use for retrieve id and type columns of categories table. Using in tabPage5_Click
            LoadCarData functions
        */
        private void changeColumnName()
        {
            // the column name is given the desired name
            dataGridView_CarList.Columns["carNumber"].HeaderText = "Car number";
            dataGridView_CarList.Columns["Type"].HeaderText = "Type";
            dataGridView_CarList.Columns["carBrand"].HeaderText = "Brand";
            dataGridView_CarList.Columns["noOfSeat"].HeaderText = "Number of seats";

            dataGridView_CarList.Columns["driverName"].HeaderText = "Driver name";
            dataGridView_CarList.Columns["driverName"].Width = 150;

            dataGridView_CarList.Columns["driverLincense"].HeaderText = "Driver license";
            dataGridView_CarList.Columns["driverLincense"].Width = 150;

            dataGridView_CarList.Columns["driverPhNo"].HeaderText = "Driver phone number";
            dataGridView_CarList.Columns["driverPhNo"].Width = 150;

            dataGridView_CarList.Columns["driverAddress"].HeaderText = "Driver address";
            dataGridView_CarList.Columns["driverAddress"].Width = 150;

            // hidden category_id. This use for retrieve id and type of categories table in EditCarInfo.cs
            // hidden carId for update existing data from database carId use in EditCarInfo.cs UPDATE query
            dataGridView_CarList.Columns["category_id"].Visible = false;
            dataGridView_CarList.Columns["carId"].Visible = false;
        }
        private void dataGridView_CarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView_CarList.Columns[e.ColumnIndex].Name == "editColumn")
                {
                    int carId = Convert.ToInt32(dataGridView_CarList.Rows[e.RowIndex].Cells["carId"].Value);
                    int category_id = Convert.ToInt32(dataGridView_CarList.Rows[e.RowIndex].Cells["category_id"].Value);
                    string carNumber = dataGridView_CarList.Rows[e.RowIndex].Cells["carNumber"].Value.ToString();
                    string carBrand = dataGridView_CarList.Rows[e.RowIndex].Cells["carBrand"].Value.ToString();
                    int noOfSeat = Convert.ToInt32(dataGridView_CarList.Rows[e.RowIndex].Cells["noOfSeat"].Value);
                    string driverName = dataGridView_CarList.Rows[e.RowIndex].Cells["driverName"].Value.ToString();
                    string driverLincense = dataGridView_CarList.Rows[e.RowIndex].Cells["driverLincense"].Value.ToString();
                    string driverPhNo = dataGridView_CarList.Rows[e.RowIndex].Cells["driverPhNo"].Value.ToString();
                    string driverAddress = dataGridView_CarList.Rows[e.RowIndex].Cells["driverAddress"].Value.ToString();

                    EditCarInfo editCarInfo = new EditCarInfo(carId,category_id, carNumber, carBrand,noOfSeat,driverName,driverLincense,driverPhNo,driverAddress);
                    DialogResult result = editCarInfo.ShowDialog();
                    LoadCarData();
                }else if (dataGridView_CarList.Columns[e.ColumnIndex].Name == "deleteColumn")
                {
                    int carId = Convert.ToInt32(dataGridView_CarList.Rows[e.RowIndex].Cells["carId"].Value);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?","Delete confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                    {
                        deleteCar(carId);
                        LoadCarData();
                    }
                }
            }
        }

        private void deleteCar(int carId)
        {
            string query = "DELETE FROM manage_cars WHERE id=" + carId;
            MySqlConnection myCon = new MySqlConnection(conn.connectionString);
            MySqlCommand command = new MySqlCommand(query, myCon);

            try
            {
                myCon.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Refresh the DataGridView to show the new data. Using in carAddBtn(),deletColumn and editColumn.
        private void LoadCarData()
        {
            string query = @"
                SELECT 
                    manage_cars.id AS carId,
                    manage_cars.category_id AS category_id,
                    manage_cars.car_no AS carNumber,
                    categories.type AS Type,
                    manage_cars.brand_name AS carBrand,
                    manage_cars.no_of_seat AS noOfSeat,
                    manage_cars.driver_name AS driverName,
                    manage_cars.driver_lincense AS driverLincense,
                    manage_cars.driver_ph_no AS driverPhNo,
                    manage_cars.driver_address AS driverAddress
                    FROM manage_cars
                    INNER JOIN categories ON manage_cars.category_id = categories.id";
            //for hold the data
            DataTable dt = new DataTable();
            MySqlConnection myCon = new MySqlConnection(conn.connectionString);
            try
            {
                myCon.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, myCon);
                mySqlDataAdapter.Fill(dt);
                dataGridView_CarList.DataSource = dt;
                changeColumnName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myCon.Close();
            }
        }
        private void carAddBtn(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();

            // Show the AddCarForm as a dialog
            DialogResult result = addCarForm.ShowDialog();
            LoadCarData();
        }
        
        // insert No. column in dataGridView 
        private void dataGridView_CarList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView_CarList.Rows[e.RowIndex].Cells["noColumn"].Value = (e.RowIndex+1).ToString();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            /*string query = "SELECT type,description FROM categories";
            DataTable dt = new DataTable();
            MySqlConnection myCon = new MySqlConnection(conn.connectionString);
            try
            {
                myCon.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, myCon);
                mySqlDataAdapter.Fill(dt);
                categoryDataGridView.DataSource = dt;

                categoryDataGridView.Columns["type"].HeaderText = "Type";
                categoryDataGridView.Columns["description"].HeaderText = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            MessageBox.Show("working");
        }

        private void categoryAddBtn(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
