using Excursion_Car_Rental.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion_Car_Rental.Services
{
    public class GateService
    {
        MySqlConnection con;
        MySqlCommand cmd;
        public GateService()
        {
            
            DBConnection dbConnection = new DBConnection();
            con = new MySqlConnection(dbConnection.connectionString);

            
        }
        public Gate loadGateData()
        {

            con.Open();
            String query = "select * from gate where id=1";
            cmd = new MySqlCommand(query, con);
            MySqlDataReader gate = cmd.ExecuteReader();
            Gate modelGate = new Gate();

            if (gate.Read())
            {

                modelGate.Name = gate[1].ToString();
                modelGate.Location = gate[2].ToString();
                modelGate.Phno = gate[3].ToString();
                modelGate.Gmail = gate[4].ToString();
                modelGate.Description = gate[5].ToString();
            }
            con.Close();
            return modelGate;
        }

        public int updateGateData(Gate gate)
        {
            string query = "UPDATE `gate` SET `name`=@gateName,`location`=@gateLocation,`ph_no`=@gatePhno,`gmail`=@gateGmail,`description`=@gateDescription WHERE id=1";
            con.Open();
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@gateName", gate.Name);
            cmd.Parameters.AddWithValue("@gateLocation", gate.Location);
            cmd.Parameters.AddWithValue("@gatePhno", gate.Phno);
            cmd.Parameters.AddWithValue("@gateGmail", gate.Gmail);
            cmd.Parameters.AddWithValue("gateDescription", gate.Description);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
    }
}
