using Excursion_Car_Rental.Models;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excursion_Car_Rental.Services
{
    public class CarService
    {
        MySqlConnection con;
        MySqlCommand cmd;
        public CarService()
        {

            DBConnection dbConnection = new DBConnection();
            con = new MySqlConnection(dbConnection.connectionString);


        }


        public List<Cars> carList(int categoryId,DateTime checkInDate,DateTime checkOutDate)
        {
            List<Cars> cars= new List<Cars>();
            checkInDate=checkInDate.AddDays(-2);
          //  string query = "SELECT *\r\nFROM manage_cars\r\nWHERE id NOT IN (SELECT car_id \r\nFROM orders\r\nWHERE end_date<@checkinDate\r\nAND status NOT IN (2,3));";
            string query = "SELECT * FROM manage_cars WHERE id NOT IN ( SELECT car_id  FROM orders   WHERE end_date>@checkinDate   AND status IN (0, 1) ) AND status!=0 AND category_id=@categoryId;";
            con.Open();
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@checkinDate", checkInDate);
            cmd.Parameters.AddWithValue("@categoryId", categoryId);
            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                Cars car = new Cars();
                car.Id = Int32.Parse(dr["id"].ToString());
                car.BrandName = dr["brand_name"].ToString();
                car.Rank = float.Parse(dr["rank"].ToString());
                cars.Add(car); 

            } 

            con.Close();


            return cars;

        } 
    }
}
