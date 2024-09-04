using Excursion_Car_Rental.Models;
using Excursion_Car_Rental.Services;
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
    public partial class OrderDetail : Form
    {
        int orderId;
        OrderService orderService;
        public OrderDetail(int id)
        {
            InitializeComponent();
            orderId = id;
            orderService = new OrderService();
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            loadOrder();
        }

        private void updateStatusBtn_Click(object sender, EventArgs e)
        {
            Combox selectedItem = (Combox)orderStatusCombo.SelectedItem;
            int status = Int32.Parse(selectedItem.Value.ToString());

            int orderId =Int32.Parse(txt_orderId.Text);

            int result=orderService.orderStatusUpdate(orderId, status);
            if (result > 0)
            {
                MessageBox.Show("Updated Status");
                loadOrder();
            }
            else
            {
                MessageBox.Show("You can't change the status");
                loadOrder() ;
            }
        }

        public void loadOrder()
        {

            txt_orderId.Text = orderId.ToString();
            OrderResponse order = orderService.orderById(orderId);
            txt_carBrand.Text = order.CarBrand;
            txt_tripRoute.Text = order.TripRoute;
            txt_dateRange.Text = order.TripDate;
            txt_cusAddress.Text = order.CustomerAddress;
            txt_cusName.Text = order.CustomerName;
            txt_cusEmail.Text = order.CustomerEmail;
            txt_cusPhno.Text = order.CustomerPhone;



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
            canceled.Text = "canceled";
            canceled.Value = 3;

            orderStatusCombo.Items.Add(pending);
            orderStatusCombo.Items.Add(working);
            orderStatusCombo.Items.Add(completed);
            orderStatusCombo.Items.Add(canceled);
             
            orderStatusCombo.SelectedIndex = order.Status;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
