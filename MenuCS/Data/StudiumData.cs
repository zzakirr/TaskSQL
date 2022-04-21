using MenuCs.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MenuCs.Data
{
    internal class StadiumData
    {
        public void ADD(Stadium stadium)
        {
            using (SqlConnection conn = new SqlConnection(SQL.ConnString))
            {
                conn.Open();
                string query = $"Insert Into Stadiums (Name , HourPrice , Capasity)  values ( '{stadium.Name}' , {stadium.HourPrice} ,{stadium.Capacity})";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();
            }
        }
        public List<Stadium> Select()
        {
            List<Stadium> Slist = new List<Stadium>();
            using (SqlConnection conn = new SqlConnection(SQL.ConnString))
            {

                conn.Open();
                string query = "Select * from Stadiums";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                using (SqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Stadium stad = new Stadium()
                        {
                            ID = dr.GetInt32(0),
                            Name = dr.GetString(1),
                            HourPrice = dr.GetInt32(2),
                            Capacity = dr.GetInt32(3),
                        };
                        Slist.Add(stad);
                    }
                }
            }
            return Slist;
        }
    }
}