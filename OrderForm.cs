using Excursion_Car_Rental.Models;
using Excursion_Car_Rental.Services;
using Guna.UI.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Excursion_Car_Rental
{
    public partial class OrderForm : MaterialForm
    {
        CategoryService categoryService;
        CarService carService;
        TripService tripService;
        CustomerService customerService;
        OrderService orderService;
        int totalDays = 0;
        float total = 0;
        public OrderForm()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            tripService = new TripService();
            carService=new CarService();
            customerService = new CustomerService();
            orderService = new OrderService();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            List<Category> categoryList= categoryService.categories();
            foreach (var category in categoryList)
            {
                
                Combox item= new Combox();
                item.Text = category.Type + "  " + category.Description;
                item.Value = category.Id;  

                typeOfCarCombo.Items.Add(item);
              //  MessageBox.Show((typeOfCarCombo.SelectedItem as Models.ComboBox).Value.ToString());
            }

            List<Trip> trips = tripService.trips();
            foreach(var trip in trips)
            {
                Combox item = new Combox();
                item.Text = trip.Destination;
                item.Value = trip.Id;
                item.Price = trip.Price;

                destinationCombo.Items.Add(item);

            }


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
            canceled.Text = "pending";
            canceled.Value = 3;

            orderStatusCombo.Items.Add(pending);
            orderStatusCombo.Items.Add(working);
            orderStatusCombo.Items.Add(completed);
            orderStatusCombo.Items.Add(canceled);


            orderStatusCombo.SelectedIndex = 0;

        }

        private void typeOfCarCombo_SelectedIndexChanged(object sender, EventArgs e) {

            if (sourceCombo.SelectedIndex == 0)
            {
                if (destinationCombo.SelectedIndex >= 0)
                {
                    if (typeOfCarCombo.SelectedIndex >= 0)
                    {
                        DateTime startDate = startDateForTrip.Value;
                        DateTime currentTime = DateTime.Now;
                        DateTime endDate = endDateForTrip.Value;

                        if (startDate != endDate)
                        {
                            if (!(startDate < currentTime || endDate < currentTime || endDate < startDate))
                            {
                                // nextOrderPageBtn.Hide();
                                secPanelOrder.Show();

                                // MessageBox.Show(startDate.ToString());

                                Combox selectedItem = (Combox)typeOfCarCombo.SelectedItem;
                                int categoryId = Int32.Parse(selectedItem.Value.ToString());

                                if (carList.SelectedIndex >= 0)
                                {
                                    gettingTotalAmount();
                                }
                                List<Cars> cars = carService.carList(categoryId, startDate, endDate);

                                carList.Items.Clear();
                                foreach (var car in cars)
                                {
                                    Combox item = new Combox();
                                    item.Text = car.BrandName;
                                    item.Value = car.Id;
                                    item.Price = car.Rank;
                                    carList.Items.Add(item);
                                }



                            }
                            else
                            {
                                MessageBox.Show("no");
                            }
                        }
                    }
                }
            }



            /* Models.ComboBox selectedItem = (Models.ComboBox)typeOfCarCombo.SelectedItem;

             MessageBox.Show(selectedItem.Value.ToString());*/


            /*if (selectedItem != null)
            {
                // Get the value and text
                var selectedValue = selectedItem.Value; // this will give you the trip.Id
                var selectedText = selectedItem.Text;   // this will give you the trip.Destination

                MessageBox.Show("id is"+ selectedValue);
                // Do something with the values
               // Console.WriteLine($"Selected Value: {selectedValue}, Selected Text: {selectedText}");
            }
            else
            {
                // Handle the case where no item is selected
                Console.WriteLine("No item selected.");
            }*/

        }

        private void nextOrderPageBtn_Click(object sender, EventArgs e)
        {

            if (sourceCombo.SelectedIndex == 0)
            {
                if (destinationCombo.SelectedIndex >= 0)
                {
                    if(typeOfCarCombo.SelectedIndex >= 0)
                    {
                        DateTime startDate = startDateForTrip.Value;
                        DateTime currentTime = DateTime.Now;
                        DateTime endDate=endDateForTrip.Value;

                        if (startDate != endDate)
                        {
                            if (!(startDate < currentTime || endDate < currentTime || endDate < startDate))
                            {
                                nextOrderPageBtn.Hide();
                                secPanelOrder.Show();

                               // MessageBox.Show(startDate.ToString());  

                                Combox selectedItem = (Combox)typeOfCarCombo.SelectedItem;
                                int categoryId=Int32.Parse(selectedItem.Value.ToString());


                                List<Cars> cars = carService.carList(categoryId,startDate,endDate);

                                foreach(var car in cars)
                                {
                                    Combox item = new Combox();
                                    item.Text = car.BrandName;
                                    item.Value = car.Id;
                                    item.Price = car.Rank;
                                    carList.Items.Add(item);
                                }



                            }
                            else
                            {
                                MessageBox.Show("no");
                            }
                        }
                    }
                }
            }


            
        }

        private void endDateForTrip_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = startDateForTrip.Value;
            DateTime endDate = endDateForTrip.Value;
            // Calculate the difference in days
            TimeSpan difference =  endDate-startDate;
             totalDays = (int)difference.TotalDays+1;
            txt_totalDays.Text = totalDays.ToString();

            //  gettingTotalAmount();

            changedLoads();
             
        }

        private void startDateForTrip_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = startDateForTrip.Value;
            DateTime endDate = endDateForTrip.Value;
            // Calculate the difference in days
            TimeSpan difference = endDate - startDate;
            totalDays = (int)difference.TotalDays;
            txt_totalDays.Text = totalDays.ToString();

            //  gettingTotalAmount();

            changedLoads();



        }

        private void changedLoads()
        {
            carList.Items.Clear();
            if (sourceCombo.SelectedIndex == 0)
            {
                if (destinationCombo.SelectedIndex >= 0)
                {
                    if (typeOfCarCombo.SelectedIndex >= 0)
                    {
                         DateTime startDate = startDateForTrip.Value;
                        DateTime currentTime = DateTime.Now;
                          DateTime endDate = endDateForTrip.Value;

                        if (startDate != endDate)
                        {
                            if (!(startDate < currentTime || endDate < currentTime || endDate < startDate))
                            {
                                // nextOrderPageBtn.Hide();
                                secPanelOrder.Show();

                                // MessageBox.Show(startDate.ToString());

                                Combox selectedItem = (Combox)typeOfCarCombo.SelectedItem;
                                int categoryId = Int32.Parse(selectedItem.Value.ToString());

                                if (carList.SelectedIndex >= 0)
                                {
                                    gettingTotalAmount();
                                }
                                List<Cars> cars = carService.carList(categoryId, startDate, endDate);

                                
                                foreach (var car in cars)
                                {
                                    Combox item = new Combox();
                                    item.Text = car.BrandName;
                                    item.Value = car.Id;
                                    item.Price = car.Rank;
                                    carList.Items.Add(item);
                                }



                            }
                            else
                            {
                                MessageBox.Show("no");
                            }
                        } 
                    }
                }
            }
        }

        private void carList_SelectedIndexChanged(object sender, EventArgs e)
        {
            gettingTotalAmount();
        }


        private void gettingTotalAmount()
        {
            if (sourceCombo.SelectedIndex == 0)
            {
                if (destinationCombo.SelectedIndex >= 0)
                {
                    if (typeOfCarCombo.SelectedIndex >= 0)
                    {
                        DateTime startDate = startDateForTrip.Value;
                        DateTime currentTime = DateTime.Now;
                        DateTime endDate = endDateForTrip.Value;

                        if (startDate != endDate)
                        {
                            if (!(startDate < currentTime || endDate < currentTime || endDate < startDate))
                            {
                                if (carList.SelectedIndex >= 0)
                                {

                                    Combox selectedItem = (Combox)carList.SelectedItem;
                                    float carRank = float.Parse(selectedItem.Price.ToString());

                                    Combox selectedTrip = (Combox)destinationCombo.SelectedItem;
                                    int tripPrice = Int32.Parse(selectedTrip.Price.ToString());

                                     total = tripPrice * carRank * totalDays;
                                    totalAmount.Text = total.ToString();
                                }
                            }
                        }
                    }
                }
            }

             
        }

        private void destinationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            gettingTotalAmount();
        }

        private void createOrderBtn_Click(object sender, EventArgs e)
        {
            if (sourceCombo.SelectedIndex == 0)
            {
                if (destinationCombo.SelectedIndex >= 0)
                {
                    if (typeOfCarCombo.SelectedIndex >= 0)
                    {
                        DateTime startDate = startDateForTrip.Value;
                        DateTime currentTime = DateTime.Now;
                        DateTime endDate = endDateForTrip.Value;

                        if (startDate != endDate)
                        {
                            if (!(startDate < currentTime || endDate <= currentTime))
                            {
                                if (carList.SelectedIndex >= 0)
                                {
                                    

                                    //getting carId
                                    Combox selectedCar = (Combox)carList.SelectedItem;
                                    int carId = Int32.Parse(selectedCar.Value.ToString());

                                    // getting tripId
                                    Combox selectedTrip=(Combox)destinationCombo.SelectedItem;
                                    int tripId = Int32.Parse(selectedTrip.Value.ToString());

                                    // getting tripId
                                    Combox selectedStatus = (Combox)orderStatusCombo.SelectedItem;
                                    int status = Int32.Parse(selectedStatus.Value.ToString());

                                    // creating user
                                    Customer customer = new Customer();
                                    customer.Name=txt_cus_name.Text;
                                    customer.Address=txt_cus_address.Text;
                                    customer.Email = txt_cus_email.Text;
                                    customer.Phno = txt_cus_phone.Text;

                                    // getting cusId
                                    int cusId = customerService.saveCustomer(customer);

                                    if(cusId > 0)
                                    {
                                        Orders order = new Orders();
                                        order.CustomerId = cusId;
                                        order.CarId = carId;
                                        order.TripId = tripId;
                                        order.StartDate = startDate;
                                        order.EndDate = endDate;
                                        order.TotalAmount = total;
                                        order.TotalDay = totalDays;
                                        order.Status = status;

                                        int result = orderService.saveOrder(order);
                                        if (result > 0)
                                        {
                                            MessageBox.Show("Successfully Created");
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error Creating");
                                        }
                                    }

                                    

                                }
                            }
                        }
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
