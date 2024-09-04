using Excursion_Car_Rental.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Excursion_Car_Rental.Services
{
    public class OrderService
    {
        MySqlConnection con;
        MySqlCommand cmd;
        public OrderService()
        {

            DBConnection dbConnection = new DBConnection();
            con = new MySqlConnection(dbConnection.connectionString);

        }
        public int saveOrder(Orders order)
        {
            string query = "insert into orders( `car_id`, `cus_id`, `trip_id`, `start_date`, `end_date`, `total_day`, `status`, `total_amount`) values(@carId,@cusId,@tripId,@startDate,@endDate,@totalDay,@status,@totalAmount)";
            con.Open(); // start connection

            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@carId", order.CarId);
            cmd.Parameters.AddWithValue("@cusId",order.CustomerId);
            cmd.Parameters.AddWithValue("@tripId",order.TripId);
            cmd.Parameters.AddWithValue("@startDate", order.StartDate);
            cmd.Parameters.AddWithValue("@endDate", order.EndDate);
            cmd.Parameters.AddWithValue("@totalDay", order.TotalDay);
            cmd.Parameters.AddWithValue("@status", order.Status);
            cmd.Parameters.AddWithValue("@totalAmount", order.TotalAmount);


            int result = cmd.ExecuteNonQuery();

            if (result>0)
            {
                string queryUpdate = "update manage_cars set status='1' where id="+order.CarId;
                cmd = new MySqlCommand(queryUpdate, con);
                int result2 = cmd.ExecuteNonQuery();
                return result2;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }

            con.Close(); // end connection
            return result;
        }
        
        // orders
        public List<OrderResponse> orders(int status=4)
        {
           // MessageBox.Show("Services "+status);
           
            List<OrderResponse> orders= new List<OrderResponse>();

            string query = "SELECT    o.id,o.car_id,o.created_at,   c.brand_name AS car_brand,   CONCAT(t.source, '=>', t.destination) AS trip_route,   cust.name AS customer_name,    cust.address AS customer_address,   cust.ph_no AS customer_phone,   cust.email AS customer_email,    CONCAT(o.start_date, '=>', o.end_date) AS trip_date,   o.total_day,   CASE        WHEN o.status = 0 THEN 'pending'      WHEN o.status = 1 THEN 'working'    WHEN o.status = 2 THEN 'completed'      WHEN o.status = 3 THEN 'cancel'     ELSE 'unknown'   END AS order_status,  o.total_amount FROM `orders` o JOIN      `manage_cars` c ON o.car_id = c.id JOIN `trips` t ON    o.trip_id = t.id JOIN `customers` cust ON  o.cus_id = cust.id WHERE (@status IS NULL OR o.status = @status); ";

            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);

                if (status == 4)
                {
                    cmd.Parameters.AddWithValue("@status", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@status",status );
                }
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    OrderResponse order = new OrderResponse();

                    order.Id = Int32.Parse(dr["id"].ToString());
                    order.CustomerName = dr["customer_name"].ToString();
                    order.CustomerEmail = dr["customer_email"].ToString();
                    order.CustomerAddress = dr["customer_address"].ToString();
                    order.CustomerPhone = dr["customer_phone"].ToString();
                    order.TripRoute = dr["trip_route"].ToString();

                    order.CarBrand = dr["car_brand"].ToString();
                    order.OrderStatus = dr["order_status"].ToString();
                   /* order.StartDate = DateTime.Parse(dr["start_date"].ToString());
                    order.EndDate = DateTime.Parse(dr["end_date"].ToString());*/
                    order.TotalAmount = float.Parse(dr["total_amount"].ToString());
                    order.TotalDay = Int32.Parse(dr["total_day"].ToString());
                    order.CreatedAt = dr["created_at"].ToString();

                    order.TripDate = dr["trip_date"].ToString();
                    orders.Add(order);

                }

                con.Close();
                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return orders;
        }
        

        public OrderResponse orderById(int id)
        {
            string query = "SELECT    o.id,o.status,o.car_id,o.created_at,   c.brand_name AS car_brand,   CONCAT(t.source, '=>', t.destination) AS trip_route,   cust.name AS customer_name,    cust.address AS customer_address,   cust.ph_no AS customer_phone,   cust.email AS customer_email,    CONCAT(o.start_date, '=>', o.end_date) AS trip_date,   o.total_day,   CASE        WHEN o.status = 0 THEN 'pending'      WHEN o.status = 1 THEN 'working'    WHEN o.status = 2 THEN 'completed'      WHEN o.status = 3 THEN 'cancel'     ELSE 'unknown'   END AS order_status,  o.total_amount FROM `orders` o JOIN      `manage_cars` c ON o.car_id = c.id JOIN `trips` t ON    o.trip_id = t.id JOIN `customers` cust ON  o.cus_id = cust.id WHERE o.id=@orderId; ";
            OrderResponse order=new OrderResponse();
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@orderId", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { 

                    order.Id = Int32.Parse(dr["id"].ToString());
                    order.CustomerName = dr["customer_name"].ToString();
                    order.CustomerEmail = dr["customer_email"].ToString();
                    order.CustomerAddress = dr["customer_address"].ToString();
                    order.CustomerPhone = dr["customer_phone"].ToString();
                    order.TripRoute = dr["trip_route"].ToString();

                    order.CarBrand = dr["car_brand"].ToString();
                    order.OrderStatus = dr["order_status"].ToString();
                    /* order.StartDate = DateTime.Parse(dr["start_date"].ToString());
                     order.EndDate = DateTime.Parse(dr["end_date"].ToString());*/
                    order.TotalAmount = float.Parse(dr["total_amount"].ToString());
                    order.TotalDay = Int32.Parse(dr["total_day"].ToString());
                    order.CreatedAt = dr["created_at"].ToString();

                    order.Status = Int32.Parse(dr["status"].ToString());
                    order.TripDate = dr["trip_date"].ToString(); 

                }

                con.Close(); 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return order;
        }

        public int orderStatusUpdate(int id,int status)
        {
            string query = "update  orders set `status`=@status where status!=2 and id=" + id;
            try
            {
                con.Open(); // start connection

                cmd = new MySqlCommand(query, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@status",status); 
                int result = cmd.ExecuteNonQuery();

                con.Close(); // end connection
                return result;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }
        
        public List<OrderResponse> searchOrder(string txt)
        {
            List<OrderResponse> orders = new List<OrderResponse>();
 
            string query = @"
                SELECT 
                    o.id,
                    o.car_id,
                    o.created_at,
                    c.brand_name AS car_brand,
                    CONCAT(t.source, '=>', t.destination) AS trip_route,
                    cust.name AS customer_name,
                    cust.address AS customer_address,
                    cust.ph_no AS customer_phone,
                    cust.email AS customer_email,
                    CONCAT(o.start_date, '=>', o.end_date) AS trip_date,
                    o.total_day,
                    CASE
                        WHEN o.status = 0 THEN 'pending'
                        WHEN o.status = 1 THEN 'working'
                        WHEN o.status = 2 THEN 'completed'
                        WHEN o.status = 3 THEN 'cancel'
                        ELSE 'unknown'
                    END AS order_status,
                    o.total_amount
                FROM 
                    `orders` o
                JOIN 
                    `manage_cars` c ON o.car_id = c.id
                JOIN 
                    `trips` t ON o.trip_id = t.id
                JOIN 
                    `customers` cust ON o.cus_id = cust.id

                 WHERE 
                    c.brand_name LIKE CONCAT('%', @searchText, '%') OR
                    CONCAT(t.source, '=>', t.destination) LIKE CONCAT('%', @searchText, '%') OR
                    cust.name LIKE CONCAT('%', @searchText, '%') OR
                    cust.address LIKE CONCAT('%', @searchText, '%') OR
                    cust.ph_no LIKE CONCAT('%', @searchText, '%') OR
                    cust.email LIKE CONCAT('%', @searchText, '%') OR
                    CONCAT(o.start_date, '=>', o.end_date) LIKE CONCAT('%', @searchText, '%') OR
                    o.total_amount LIKE CONCAT('%', @searchText, '%') OR
                    CASE
                        WHEN o.status = 0 THEN 'pending'
                        WHEN o.status = 1 THEN 'working'
                        WHEN o.status = 2 THEN 'completed'
                        WHEN o.status = 3 THEN 'cancel'
                        ELSE 'unknown'
                    END LIKE CONCAT('%', @searchText, '%')
                   ;
            ";
            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@searchText", txt);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    OrderResponse order = new OrderResponse();

                    order.Id = Int32.Parse(dr["id"].ToString());
                    order.CustomerName = dr["customer_name"].ToString();
                    order.CustomerEmail = dr["customer_email"].ToString();
                    order.CustomerAddress = dr["customer_address"].ToString();
                    order.CustomerPhone = dr["customer_phone"].ToString();
                    order.TripRoute = dr["trip_route"].ToString();

                    order.CarBrand = dr["car_brand"].ToString();
                    order.OrderStatus = dr["order_status"].ToString();
                    /* order.StartDate = DateTime.Parse(dr["start_date"].ToString());
                     order.EndDate = DateTime.Parse(dr["end_date"].ToString());*/
                    order.TotalAmount = float.Parse(dr["total_amount"].ToString());
                    order.TotalDay = Int32.Parse(dr["total_day"].ToString());
                    order.CreatedAt = dr["created_at"].ToString();

                    order.TripDate = dr["trip_date"].ToString();
                    orders.Add(order);

                }

                con.Close();
                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return orders;
        }
    }
}
