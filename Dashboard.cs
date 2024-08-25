using Excursion_Car_Rental.Models;
using Excursion_Car_Rental.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursion_Car_Rental
{
    public partial class Dashboard : MaterialForm

    {
        MySqlConnection con;
        MySqlCommand cmd;
        GateService gateService;
        TripService tripService;

        public Dashboard()
        {
            InitializeComponent();
            DBConnection dbConnection = new DBConnection();
            con = new MySqlConnection(dbConnection.connectionString);

            gateService = new GateService();
            tripService = new TripService();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange900, Primary.Orange900, Accent.DeepOrange400, TextShade.BLACK);

        }



        private void Dashboard_Load(object sender, EventArgs e)
        {


            this.WindowState = FormWindowState.Maximized; // defaulat maximize

            Gate gate = gateService.loadGateData(); // getting gate data
            reloadGateData(gate); // adding data to form


            /*Trip Title Customize Start*/
            labelForTripForm.ForeColor = Color.Red;
            labelForTripForm.Font = new Font("Arial", 24, FontStyle.Bold);
            tripGridView.RowTemplate.Height = 25;
            /*Trip Title Customize End*/

            /*Calling Create Form*/
            doTaskForCreateForm();
        }


        // update gate information


        private void reloadGateData(Gate gate)
        {
            txt_gate_name.Text = gate.Name;
            txt_gate_location.Text = gate.Location;
            txt_gate_phone.Text = gate.Phno;
            txt_gate_gmail.Text = gate.Gmail;
            txt_gate_description.Text = gate.Description;
        }

        private void updateInfoBtn_Click(object sender, EventArgs e)
        {
            if (txt_gate_name.Text == "" || txt_gate_location.Text == "" || txt_gate_phone.Text == "" || txt_gate_gmail.Text == "" || txt_gate_description.Text == "")
            {
                MessageBox.Show("Please Fill the blank Field", "WarningException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Gate gate = new Gate();
                gate.Name = txt_gate_name.Text;
                gate.Location = txt_gate_location.Text;
                gate.Phno = txt_gate_phone.Text;
                gate.Gmail = txt_gate_gmail.Text;
                gate.Description = txt_gate_description.Text;

                int result = gateService.updateGateData(gate);

                if (result == 0)
                {
                    MessageBox.Show("An error has occured");
                }
                else
                {
                    MessageBox.Show("Updated your gate information", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Gate gateData = gateService.loadGateData();
                    reloadGateData(gateData);
                }
            }

        }


        private void createTripBtn_Click(object sender, EventArgs e)
        {
            if (txt_source_trip.Text == "" || txt_destination_trip.Text == "")
            {
                destinationError.Text = "Fill the above field";
                destinationError.ForeColor = Color.Red;
            }
            else
            {
                Trip trip = new Trip();
                trip.Source = txt_source_trip.Text;
                trip.Destination = txt_destination_trip.Text;
                trip.Description = txt_description_trip.Text;

                int result = tripService.saveTrip(trip);
                if (result == 0)
                {
                    MessageBox.Show("Something Went Wrong", "Error Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Successfully Created", "Success Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tripGridView.Rows.Clear();
                    loadTripData();
                }
            }


        }

        private void loadTripData()
        {
            tripGridView.Rows.Clear();
            List<Trip> tripList = tripService.trips();
            foreach (var trip in tripList)
            {
                tripGridView.Rows.Add(tripGridView.Rows.Count + 1, trip.Id, trip.Source, trip.Destination, trip.Description, trip.Created_at);
            }
        }

        private void tripGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelForTripForm.Text = "Update Trip";
            labelForTripForm.ForeColor = Color.Red;
            labelForTripForm.Font = new Font("Arial", 24, FontStyle.Bold);
            createTripBtn.Visible = false;
            updateTripBtn.Visible = true;
            deleteTripBtn.Visible = true;
            cancelTripUpdateBtn.Visible = true;
            tripFormDataClear();
            txt_source_trip.Text = tripGridView.CurrentRow.Cells[2].Value.ToString();
            txt_destination_trip.Text = tripGridView.CurrentRow.Cells[3].Value.ToString();
            txt_description_trip.Text = tripGridView.CurrentRow.Cells[4].Value.ToString();
            txt_id_trip.Text = tripGridView.CurrentRow.Cells[1].Value.ToString();

        }



        private void updateTripBtn_Click(object sender, EventArgs e)
        {
            if (txt_source_trip.Text == "" || txt_destination_trip.Text == "")
            {
                destinationError.Text = "Fill the above field";
            }
            else
            {
                Trip trip = new Trip();
                trip.Id = Int32.Parse(txt_id_trip.Text);
                trip.Source = txt_source_trip.Text;
                trip.Destination = txt_destination_trip.Text;
                trip.Description = txt_description_trip.Text;

                int result = tripService.updateTrip(trip);
                if (result == 0)
                {
                    MessageBox.Show("Something Went Wrong", "Error Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Successfully Updated", "Success Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tripGridView.Rows.Clear();
                    loadTripData();


                    doTaskForCreateForm();
                }
            }
        }

        private void deleteTripBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Warning Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int outputResult = tripService.deleteTrip(Int32.Parse(txt_id_trip.Text));
                if (outputResult > 0)
                {
                    MessageBox.Show("Successfully Deleted ", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    doTaskForCreateForm();
                }
                else
                {
                    MessageBox.Show("Error Deleting ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No) {
                doTaskForCreateForm();
            }
        }



        private void tripFormDataClear()
        {
            txt_id_trip.Text = "";
            txt_description_trip.Text = "";
            txt_destination_trip.Text = "";
            txt_search_trip.Text = "";
        }

        private void cancelTripUpdateBtn_Click(object sender, EventArgs e)
        {
            doTaskForCreateForm();
        }


        private void doTaskForCreateForm()
        {
            labelForTripForm.Text = "Create Trip";
            updateTripBtn.Visible = false;
            deleteTripBtn.Visible = false;
            cancelTripUpdateBtn.Visible = false;
            createTripBtn.Visible = true;
            tripFormDataClear();
            tripGridView.Rows.Clear();
            loadTripData();
        }

        private void txt_search_trip_TextChanged(object sender, EventArgs e)
        {
            tripGridView.Rows.Clear();

            List<Trip> tripList = tripService.searchTrip(txt_search_trip.Text);
            foreach (var trip in tripList)
            {
                tripGridView.Rows.Add(tripGridView.Rows.Count + 1, trip.Id, trip.Source, trip.Destination, trip.Description, trip.Created_at);
            }
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELLO ");
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Car");
        }

        /*        private void materialTabControl1_TabIndexChanged(object sender, EventArgs e)
                {
                    MessageBox.Show("CHanged");
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange900, Primary.Orange900, Accent.DeepOrange400, TextShade.WHITE);
                }*/
        DBConnection conn = new DBConnection();
        private void utabPage5_Click(object sender, EventArgs e)
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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
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

                    EditCarInfo editCarInfo = new EditCarInfo(carId, category_id, carNumber, carBrand, noOfSeat, driverName, driverLincense, driverPhNo, driverAddress);
                    DialogResult result = editCarInfo.ShowDialog();
                    LoadCarData();
                } else if (dataGridView_CarList.Columns[e.ColumnIndex].Name == "deleteColumn")
                {
                    int carId = Convert.ToInt32(dataGridView_CarList.Rows[e.RowIndex].Cells["carId"].Value);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
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
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.dataGridView_CarList.Rows[e.RowIndex].Cells["noColumn"].Value = (e.RowIndex + 1).ToString();
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

    }
}

