using Excursion_Car_Rental.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion_Car_Rental.Services
{
    public class CategoryService
    {
        MySqlConnection con;
        MySqlCommand cmd;
        public CategoryService()
        {

            DBConnection dbConnection = new DBConnection();
            con = new MySqlConnection(dbConnection.connectionString);


        }
        public List<Category> categories()
        {

            string query = "select * from categories";
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Category> result = new List<Category>();
            while (dr.Read())
            {
                Category category = new Category();
                category.Id = Int32.Parse(dr["id"].ToString());
                category.Type = dr["type"].ToString(); 
                category.Description = dr["description"].ToString();
                category.Created_at = dr["created_at"].ToString();
                result.Add(category);

            }

            con.Close();
            return result;
        }
        public int saveCategory(Category category)
        {
            string query = "insert into categories(`type`, `description`) values(@type,@description)";
            con.Open(); // start connection

            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@type", category.Type); 
            cmd.Parameters.AddWithValue("@description", category.Description);
            int result = cmd.ExecuteNonQuery();

            con.Close(); // end connection
            return result;
        }

        internal int deleteCategory(int id)
        {
            string query = "DELETE FROM `categories` WHERE id=" + id;
            con.Open(); // start connection

            cmd = new MySqlCommand(query, con);
            int result = cmd.ExecuteNonQuery();

            con.Close(); // end connection
            return result;
        }

        internal int updateCategory(Category category)
        {
            string query = "update  categories set `type`=@type, `description`=@description where id=" + category.Id;
            con.Open(); // start connection

            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@type", category.Type); 
            cmd.Parameters.AddWithValue("@description", category.Description);
            int result = cmd.ExecuteNonQuery();

            con.Close(); // end connection
            return result;
        }

        public List<Category> searchCategory(string text)
        {

            string query = "select * from categories where id like '" + text + "%' or type like '" + text + "%' or description like '" + text + "%'";
            con.Open();
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Category> result = new List<Category>();
            while (dr.Read())
            {
                Category category = new Category();
               category.Id = Int32.Parse(dr["id"].ToString());
                category.Type = dr["type"].ToString(); 
                category.Description = dr["description"].ToString();
                category.Created_at = dr["created_at"].ToString();
                result.Add(category);

                //tripGridView.Rows.Add(tripGridView.Rows.Count + 1, dr["id"].ToString(), dr[1].ToString(), dr[2].ToString(), dr["description"].ToString(), dr["created_at"].ToString());
            }

            con.Close();
            return result;
        }

    }
}
