using Excursion_Car_Rental.Models;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion_Car_Rental.Services
{
    public  class TripService
    {
        MySqlConnection con;
        MySqlCommand cmd;
        public TripService() {
            DBConnection dbConnection = new DBConnection();
            con = new MySqlConnection(dbConnection.connectionString);

        }

        public List<Trip> trips()
        {

            string query = "select * from trips";
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Trip> result = new List<Trip>();
            while (dr.Read())
            {
                Trip t = new Trip();
                t.Id = Int32.Parse(dr["id"].ToString());
                t.Source = dr["source"].ToString();
                t.Destination = dr["destination"].ToString();
                t.Price = Int32.Parse(dr["price"].ToString());
                t.Description=dr["description"].ToString();
                t.Created_at = dr["created_at"].ToString();
                result.Add(t);

                //tripGridView.Rows.Add(tripGridView.Rows.Count + 1, dr["id"].ToString(), dr[1].ToString(), dr[2].ToString(), dr["description"].ToString(), dr["created_at"].ToString());
            }

            con.Close();
            return result;
        }
        public int saveTrip(Trip t)
        {
            string query = "insert into trips(`source`, `destination`,`price`, `description`) values(@source,@destination,@price,@description)";
            con.Open(); // start connection

            cmd=new MySqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@source", t.Source);
            cmd.Parameters.AddWithValue("@destination",t.Destination);
            cmd.Parameters.AddWithValue("@price", t.Price);
            cmd.Parameters.AddWithValue("@description", t.Description);
            int result=cmd.ExecuteNonQuery();

            con.Close(); // end connection
            return result;
        }

        internal int deleteTrip(int id)
        {
            string query="DELETE FROM `trips` WHERE id="+id;
            con.Open(); // start connection

            cmd = new MySqlCommand(query, con);
            int result = cmd.ExecuteNonQuery();

            con.Close(); // end connection
            return result;
        }

        internal int updateTrip(Trip trip)
        {
            string query = "update  trips set `source`=@source, `destination`=@destination,`price`=@price, `description`=@description where id=" + trip.Id;
            con.Open(); // start connection

            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@source", trip.Source);
            cmd.Parameters.AddWithValue("@destination", trip.Destination);
            cmd.Parameters.AddWithValue("@price", trip.Price);
            cmd.Parameters.AddWithValue("@description", trip.Description);
            int result = cmd.ExecuteNonQuery();

            con.Close(); // end connection
            return result;
        }

        public List<Trip> searchTrip(string text)
        {
            
            string query = "select * from trips where id like '"+ text+"%' or source like '"+text+"%' or destination like '"+text+"%' or description like '"+text+ "%' or price like '"+text+"%'";
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Trip> result = new List<Trip>();
            while (dr.Read())
            {
                Trip t = new Trip();
                t.Id = Int32.Parse(dr["id"].ToString());
                t.Source = dr["source"].ToString();
                t.Destination = dr["destination"].ToString();
                t.Price = Int32.Parse(dr["price"].ToString());
                t.Description = dr["description"].ToString();
                t.Created_at = dr["created_at"].ToString();
                result.Add(t);

                //tripGridView.Rows.Add(tripGridView.Rows.Count + 1, dr["id"].ToString(), dr[1].ToString(), dr[2].ToString(), dr["description"].ToString(), dr["created_at"].ToString());
            }

            con.Close();
            return result;
        }
    }
}
