using Excursion_Car_Rental.Models;
using Excursion_Car_Rental.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using Mysqlx;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace Excursion_Car_Rental
{
    public partial class Dashboard : MaterialForm

    {
        MySqlConnection con;
        /*MySqlCommand cmd;*/
        GateService gateService;
        TripService tripService;
        CategoryService categoryService;
        OrderService orderService;
        CustomerService customerService;
        CommonService commonService;
        double totalAmount = 0;
        public Dashboard()
        {
            InitializeComponent();
            DBConnection dbConnection = new DBConnection();
            con = new MySqlConnection(dbConnection.connectionString);

            gateService = new GateService();
            tripService = new TripService();
            categoryService = new CategoryService();
            orderService = new OrderService();
            customerService = new CustomerService();
            commonService = new CommonService();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange900, Primary.Orange900, Accent.DeepOrange400, TextShade.BLACK);




        }



        private void Dashboard_Load(object sender, EventArgs e)
        {
            int avCar = commonService.availableCars();
            txt_availableCars.Text= avCar.ToString();

            txt_availableCars.ForeColor = Color.Red;
            txt_availableCars.Font = new Font("Arial", 24, FontStyle.Bold);

            int toCar = commonService.totalCars();
            txt_totalCars.Text= toCar.ToString();

            txt_totalCars.ForeColor = Color.Red;
            txt_totalCars.Font = new Font("Arial", 24, FontStyle.Bold);

            int unCar=commonService.unAvailableCars();
            txt_unavailableCars.Text= unCar.ToString();

            txt_unavailableCars.ForeColor = Color.Red;
            txt_unavailableCars.Font = new Font("Arial", 24, FontStyle.Bold);

            int toOrder = commonService.totalOrders();
            txt_totalOrders.Text= toOrder.ToString();

            txt_totalOrders.ForeColor = Color.Red;
            txt_totalOrders.Font = new Font("Arial", 24, FontStyle.Bold);

            int pendOrder=commonService.totalPendingOrders();
            txt_pendingOrders.Text= pendOrder.ToString();

            txt_pendingOrders.ForeColor = Color.Red;
            txt_pendingOrders.Font = new Font("Arial", 24, FontStyle.Bold);

            int compOrder=commonService.totalCompleteOrders();
            txt_completOrders.Text= compOrder.ToString();

            txt_completOrders.ForeColor = Color.Red;
            txt_completOrders.Font = new Font("Arial", 24, FontStyle.Bold);


            int canOrder = commonService.totalCancelOrders();
            txt_cancelOrders.Text = canOrder.ToString();

            txt_cancelOrders.ForeColor = Color.Red;
            txt_cancelOrders.Font = new Font("Arial", 24, FontStyle.Bold);


            int totrips = commonService.totalTrips();
            txt_totalTrip.Text = totrips.ToString();

            txt_totalTrip.ForeColor = Color.Red;
            txt_totalTrip.Font = new Font("Arial", 24, FontStyle.Bold);

            int totalInc=commonService.totalIncome();
            txt_totalIncome.Text= totalInc.ToString();

            txt_totalIncome.ForeColor = Color.Red;
            txt_totalIncome.Font = new Font("Arial", 24, FontStyle.Bold);

            int canAmount=commonService.totalCancelAmount();
            txt_lossAmount.Text= canAmount.ToString();

            txt_lossAmount.ForeColor = Color.Red;
            txt_lossAmount.Font = new Font("Arial", 24, FontStyle.Bold);

            // Set the font style and size for labelForTotalCus
            labelForTotalCus.Font = new Font("Arial", 16, FontStyle.Bold);
            labelForTotalCus.ForeColor = Color.Orange;

            labelForTotalCars.Font = new Font("Arial", 16, FontStyle.Bold);
            labelForTotalCars.ForeColor = Color.Orange;

            labelForAvailable.Font = new Font("Arial", 16, FontStyle.Bold);
            labelForAvailable.ForeColor = Color.Orange;

            labelOfTotalCars.Font = new Font("Arial", 16, FontStyle.Bold);
            labelForTotalCars.ForeColor = Color.Orange;

            labelOfCompleteOrder.Font = new Font("Arial", 16, FontStyle.Bold);
            labelOfCompleteOrder.ForeColor = Color.Orange;

            labelOfPendingOrder.Font = new Font("Arial", 16, FontStyle.Bold);
            labelOfPendingOrder.ForeColor = Color.Orange;

            labelOfTotalTrips.Font = new Font("Arial", 16, FontStyle.Bold);
            labelOfTotalTrips.ForeColor = Color.Orange;

            labelOfTotalIncome.Font = new Font("Arial", 16, FontStyle.Bold);
            labelOfTotalIncome.ForeColor = Color.Orange;

            labelOfLossAmount.Font = new Font("Arial", 16, FontStyle.Bold);
            labelOfLossAmount.ForeColor = Color.Orange;



            // Set the font style and size for txt_totalCus
            txt_totalCus.Font = new Font("Arial", 12, FontStyle.Bold);
            txt_totalCus.ForeColor = Color.Red;
            //MessageBox.Show("LOS");


            //read only to the gridviews

            tripGridView.ReadOnly = true;
            orderGridView.ReadOnly = true;
            categoryGridView.ReadOnly = true;
            dataGridView_CarList.ReadOnly = true;

            this.WindowState = FormWindowState.Maximized; // defaulat maximize

            Gate gate = gateService.loadGateData(); // getting gate data
            reloadGateData(gate); // adding data to form


            /*Trip Title Customize Start*/
            labelForTripForm.ForeColor = Color.Red;
            labelForTripForm.Font = new Font("Arial", 24, FontStyle.Bold);
            tripGridView.RowTemplate.Height = 25;
            /*Trip Title Customize End*/

            /*Calling Create Form*/
            doTaskForTripCreateForm();
             
            LoadCarData();
            addEditColAndDeleteColToCarGridViewList();

            doTaskForCategoryCreateForm();
            loadCategory();

            // load orders

            loadOrders();
            addEditColAndDeleteColToOrderGridViewList();

            // load customers
            loadCustomers();

            // load report
            loadReport();

            // puting filter combo data

            Combox all = new Combox();
            all.Text = "All";
            all.Value = 4;

            Combox pending = new Combox();
            pending.Text = "pending";
            pending.Value = 0;


            Combox working = new Combox();
            working.Text = "working";
            working.Value = 1;

            Combox completed = new Combox();
            completed.Text = "completed";
            completed.Value = 2;

            Combox canceled = new Combox();
            canceled.Text = "cancel";
            canceled.Value = 3;

            filterByStatus.Items.Add(all);
            filterByStatus.Items.Add(pending);
            filterByStatus.Items.Add(working);
            filterByStatus.Items.Add(completed);
            filterByStatus.Items.Add(canceled);

            filterByStatus.SelectedIndex = 0;
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
            if (txt_source_trip.Text == "" || txt_destination_trip.Text == "" || txt_price_trip.Text=="")
            {
                destinationError.Text = "Fill the above field";
                destinationError.ForeColor = Color.Red;
                tripPriceError.Text = "Fill the above field";
                tripPriceError.ForeColor = Color.Red;
            }
            else
            {
                Trip trip = new Trip();
                trip.Source = txt_source_trip.Text;
                trip.Destination = txt_destination_trip.Text;
                trip.Description = txt_description_trip.Text;
                trip.Price=Int32.Parse(txt_price_trip.Text.ToString());
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
                    doTaskForTripCreateForm();
                }
            }


        }

        private void loadTripData()
        {
            tripGridView.Rows.Clear();
            List<Trip> tripList = tripService.trips();
            foreach (var trip in tripList)
            {
                tripGridView.Rows.Add(tripGridView.Rows.Count+1, trip.Id, trip.Source, trip.Destination, trip.Price, trip.Description, trip.Created_at);
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
            txt_description_trip.Text = tripGridView.CurrentRow.Cells[5].Value.ToString();
            txt_id_trip.Text = tripGridView.CurrentRow.Cells[1].Value.ToString();
            txt_price_trip.Text = tripGridView.CurrentRow.Cells[4].Value.ToString();

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
                trip.Price = Int32.Parse(txt_price_trip.Text);
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


                    doTaskForTripCreateForm();
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

                    doTaskForTripCreateForm();
                }
                else
                {
                    MessageBox.Show("Error Deleting ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No) {
                doTaskForTripCreateForm();
            }
        }



        private void tripFormDataClear()
        {
            txt_id_trip.Text = "";
            txt_description_trip.Text = "";
            txt_destination_trip.Text = "";
            txt_search_trip.Text = "";
            txt_price_trip.Text = "";
        }

        private void cancelTripUpdateBtn_Click(object sender, EventArgs e)
        {
            doTaskForTripCreateForm();
        }


        private void doTaskForTripCreateForm()
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




        DBConnection conn = new DBConnection();


               private void changeColumnName()
        {
            // the column name is given the desired name
            dataGridView_CarList.Columns["carNumber"].HeaderText = "Car number";
            dataGridView_CarList.Columns["Type"].HeaderText = "Type";
            dataGridView_CarList.Columns["carBrand"].HeaderText = "Brand";
            dataGridView_CarList.Columns["noOfSeat"].HeaderText = "Number of seats";

            dataGridView_CarList.Columns["carRank"].HeaderText = "Ranking";
            dataGridView_CarList.Columns["carRank"].Width = 150;

            dataGridView_CarList.Columns["driverName"].HeaderText = "Driver name";
            dataGridView_CarList.Columns["driverName"].Width = 150;

            dataGridView_CarList.Columns["driverLincense"].HeaderText = "Driver license";
            dataGridView_CarList.Columns["driverLincense"].Width = 150;

            dataGridView_CarList.Columns["driverPhNo"].HeaderText = "Driver phone number";
            dataGridView_CarList.Columns["driverPhNo"].Width = 150;

            dataGridView_CarList.Columns["driverAddress"].HeaderText = "Driver address";
            dataGridView_CarList.Columns["driverAddress"].Width = 150;

            dataGridView_CarList.Columns["carStatus"].HeaderText = "Status";
            dataGridView_CarList.Columns["carStatus"].Width = 150;

            // hidden category_id. This use for retrieve id and type of categories table in EditCarInfo.cs
            // hidden carId for update existing data from database carId use in EditCarInfo.cs UPDATE query
            dataGridView_CarList.Columns["category_id"].Visible = false;
            dataGridView_CarList.Columns["carId"].Visible = false;

            
        }

        private void addEditColAndDeleteColToCarGridViewList()
        {
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

        private void addEditColAndDeleteColToOrderGridViewList()
        {
            // add edit and delete buttons in dataGridView
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "editColumn";
            editColumn.HeaderText = "Edit";
            editColumn.Width = 60;
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            orderGridView.Columns.Add(editColumn); 
        }

        private void addEditColAndDeleteColToCategoryGridViewList()
        {
            // add edit and delete buttons in dataGridView
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "editColumn";
            editColumn.HeaderText = "Edit";
            editColumn.Width = 60;
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            categoryGridView.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "deleteColumn";
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Width = 60;
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            categoryGridView.Columns.Add(deleteColumn);
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
            //dataGridView_CarList.Rows.Clear();
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
                    manage_cars.driver_address AS driverAddress,
                    manage_cars.rank AS carRank,
                    manage_cars.status AS carStatus
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

                // Add a new column for the user-friendly status
                dt.Columns.Add("StatusDescription", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    int status = Convert.ToInt32(row["carStatus"]);
                    switch (status)
                    {
                        case 0:
                            row["StatusDescription"] = "Unavailable";
                            break;
                        case 1:
                            row["StatusDescription"] = "Pending";
                            break;
                        case 2:
                            row["StatusDescription"] = "Available";
                            break;
                    }
                }

                dataGridView_CarList.DataSource = dt;
                dataGridView_CarList.Columns["carStatus"].Visible = false;
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

        
        private void loadCategory()
        {
            categoryGridView.Rows.Clear();
            List<Category> categroyList = categoryService.categories();
            foreach (var category in categroyList)
            {
                categoryGridView.Rows.Add(categoryGridView.Rows.Count + 1, category.Id, category.Type, category.Description, category.Created_at);
            }
        }

        private void categoryAddBtn_Click(object sender, EventArgs e)
        {
            if (txt_categoryType.Text == "" || txt_categoryDescription.Text == "")
            {
                categoryTypeError.Text = "Fill the above field";
                categoryTypeError.ForeColor = Color.Red;
                categoryDescriptionError.Text = "Fill the above field";
                categoryDescriptionError.ForeColor = Color.Red;
            }
            else
            {
                Category category = new Category();
                category.Type = txt_categoryType.Text;
                category.Description = txt_categoryDescription.Text;

                int result = categoryService.saveCategory(category);
                if (result == 0)
                {
                    MessageBox.Show("Something Went Wrong", "Error Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Successfully Created", "Success Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    categoryGridView.Rows.Clear();
                    loadCategory();
                    doTaskForCategoryCreateForm();
                }
            }
        }

        private void categoryUpdateBtn_Click(object sender, EventArgs e)
        {
            if (txt_categoryType.Text == "" || txt_categoryDescription.Text == "")
            {
                categoryTypeError.Text = "Fill the above field";
                categoryTypeError.ForeColor = Color.Red;
                categoryDescriptionError.Text = "Fill the above field";
                categoryDescriptionError.ForeColor = Color.Red;
            }
            else
            {
                Category category = new Category();
                category.Id=Int32.Parse(txt_categoryId.Text);
                category.Type = txt_categoryType.Text;
                category.Description = txt_categoryDescription.Text;

                int result = categoryService.updateCategory(category);
                if (result == 0)
                {
                    MessageBox.Show("Something Went Wrong", "Error Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Successfully Updated", "Success Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    categoryGridView.Rows.Clear();
                    loadCategory();
                    doTaskForCategoryCreateForm();
                }
            }
        }

        private void categoryDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Warning Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int outputResult = categoryService.deleteCategory(Int32.Parse(txt_categoryId.Text));
                if (outputResult > 0)
                {
                    MessageBox.Show("Successfully Deleted ", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    doTaskForCategoryCreateForm();
                }
                else
                {
                    MessageBox.Show("Error Deleting ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                doTaskForCategoryCreateForm();
            }
        }


        private void categoryCancelBtn_Click(object sender, EventArgs e)
        {
            doTaskForCategoryCreateForm();
        }

        private void categoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelForCategoryForm.Text = "Update Category";
            labelForCategoryForm.ForeColor = Color.Red;
            labelForCategoryForm.Font = new Font("Arial", 24, FontStyle.Bold);
            categoryAddBtn.Visible = false;
            categoryUpdateBtn.Visible = true;
            categoryDeleteBtn.Visible = true;
            categoryCancelBtn.Visible = true;
            categoryFormDataClear();
            txt_categoryType.Text = categoryGridView.CurrentRow.Cells[2].Value.ToString(); 
            txt_categoryDescription.Text = categoryGridView.CurrentRow.Cells[3].Value.ToString();
            txt_categoryId.Text = categoryGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void categoryFormDataClear()
        {
            txt_categoryDescription.Text = "";
            txt_categoryType.Text = "";
            txt_categoryId.Text = "";
            categoryTypeError.Text = "";
            categoryDescriptionError.Text = "";
        }

        private void doTaskForCategoryCreateForm()
        {
            labelForCategoryForm.Text = "Create Category";
            labelForCategoryForm.ForeColor= Color.Red;
            categoryUpdateBtn.Visible = false;
            categoryDeleteBtn.Visible = false;
            categoryCancelBtn.Visible = false;
            categoryAddBtn.Visible = true;
            categoryFormDataClear();
            categoryGridView.Rows.Clear();
            loadCategory();
            categoryFormDataClear();
        }


        private void txt_search_category_TextChanged(object sender, EventArgs e)
        {
            categoryGridView.Rows.Clear();

            List<Category> categoryList = categoryService.searchCategory(txt_search_category.Text);
            foreach (var category in categoryList)
            {
                categoryGridView.Rows.Add(tripGridView.Rows.Count + 1, category.Id, category.Type, category.Description, category.Created_at);
            }
        }

        private void txt_categoryType_MouseEnter(object sender, EventArgs e)
        {
            categoryDescriptionError.Text = "";
        }

        private void txt_categoryType_Enter(object sender, EventArgs e)
        {
            categoryTypeError.Text = "";
        }

        private void txt_categoryDescription_Enter(object sender, EventArgs e)
        {
            categoryDescriptionError.Text = "";
        }

        private void createOrderBtn_Click(object sender, EventArgs e)
        {
            OrderForm or=new OrderForm();
            or.ShowDialog();
        }



        // orders

        public void loadOrders()
        {
            List<OrderResponse> orders = orderService.orders();
            foreach (var order in orders)
            {
                orderGridView.Rows.Add(orderGridView.Rows.Count + 1, order.Id, order.CustomerName, order.CarBrand, order.TripRoute, order.CustomerPhone,order.CustomerAddress,order.CustomerEmail,order.TotalDay,order.TotalAmount,order.TripDate, order.CreatedAt,order.OrderStatus);
            }

        }



        private void orderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (orderGridView.Columns[e.ColumnIndex].Name == "editColumn")
                {
                    int orderId= Convert.ToInt32(orderGridView.Rows[e.RowIndex].Cells[1].Value);
                   
                    

                    OrderDetail orderDetail = new OrderDetail(orderId);
                    orderDetail.FormClosed += new FormClosedEventHandler(OrderDetail_FormClosed);
                    DialogResult result = orderDetail.ShowDialog();
                }
            }
        }

        private void OrderDetail_FormClosed(object sender, FormClosedEventArgs e)
        { 
            orderGridView.Rows.Clear();
            loadOrders();
        }

        // customer part
        private void loadCustomers()
        {
            List<Customer> customers = customerService.customers();
            foreach (var customer in customers)
            {
                customersGridView.Rows.Add(customersGridView.Rows.Count + 1, customer.Id, customer.Name,customer.Email,customer.Address,customer.Phno,customer.Created_at);
            }
            totalCustomers.Text = customersGridView.Rows.Count.ToString();
        }

        private void txt_searchCustomer_TextChanged(object sender, EventArgs e)
        {
            string search=txt_searchCustomer.Text;
            List<Customer> customers = customerService.searchCustomer(search);
            customersGridView.Rows.Clear();
            foreach (var customer in customers)
            {
                customersGridView.Rows.Add(customersGridView.Rows.Count + 1, customer.Id, customer.Name, customer.Email, customer.Address, customer.Phno, customer.Created_at);
            }
            totalCustomers.Text = customersGridView.Rows.Count.ToString();
        }


        // load Report
        private void loadReport()
        {
            

            List<OrderResponse> orders = orderService.orders();
            totalAmount = 0;
            foreach (var order in orders)
            {
                reportGridView.Rows.Add(reportGridView.Rows.Count + 1,  order.CarBrand, order.TripRoute, order.TripDate,  order.TotalDay, order.TotalAmount,order.OrderStatus, order.CreatedAt);
                totalAmount += order.TotalAmount;
            }
            totalAmountReport.Text = totalAmount.ToString();
        }

        private void txt_searchReport_TextChanged(object sender, EventArgs e)
        {

            reportGridView.Rows.Clear();
            string txt=txt_searchReport.Text;
            List<OrderResponse> orders = orderService.searchOrder(txt);
            totalAmount = 0;
            foreach (var order in orders)
            {
                reportGridView.Rows.Add(reportGridView.Rows.Count + 1, order.CarBrand, order.TripRoute, order.TripDate, order.TotalDay, order.TotalAmount, order.OrderStatus, order.CreatedAt);
                totalAmount += order.TotalAmount;
            }
            totalAmountReport.Text = totalAmount.ToString();
        }

        private void filterByStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            reportGridView.Rows.Clear();

            Combox selectedStatus = (Combox)filterByStatus.SelectedItem;
            int status =Int32.Parse(selectedStatus.Value.ToString()); 
            List<OrderResponse> orders = orderService.orders(status);
            totalAmount = 0;
            foreach (var order in orders)
            {
                reportGridView.Rows.Add(reportGridView.Rows.Count + 1, order.CarBrand, order.TripRoute, order.TripDate, order.TotalDay, order.TotalAmount, order.OrderStatus, order.CreatedAt);
                totalAmount += order.TotalAmount;
            }
            totalAmountReport.Text = totalAmount.ToString();
        }

        
    }
}

