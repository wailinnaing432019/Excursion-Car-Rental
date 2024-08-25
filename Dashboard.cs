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
            tripService=new TripService();

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
            if (txt_source_trip.Text == "" || txt_destination_trip.Text == "" )
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
            List<Trip> tripList =tripService.trips();
            foreach (var trip in tripList)
            {
                tripGridView.Rows.Add(tripGridView.Rows.Count + 1, trip.Id,trip.Source,trip.Destination,trip.Description,trip.Created_at);
            }
        }

        private void tripGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelForTripForm.Text = "Update Trip";
            labelForTripForm.ForeColor = Color.Red;
            labelForTripForm.Font=new Font("Arial",24,FontStyle.Bold);
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
            DialogResult result=MessageBox.Show("Are you sure you want to delete", "Warning Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int outputResult=tripService.deleteTrip(Int32.Parse(txt_id_trip.Text));
                if (outputResult>0)
                {
                    MessageBox.Show("Successfully Deleted ", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    doTaskForCreateForm();
                }
                else
                {
                    MessageBox.Show("Error Deleting ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(result == DialogResult.No){
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

        private void materialTabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CHanged");

        }
    }
}
