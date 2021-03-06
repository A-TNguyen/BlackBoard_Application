﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;



namespace Blackboard_Application.Connection
{
    class SQLServerConnection
    {
        //Pleae make sure to change the AttachDBFileName
        //This is establishing the source connection where the DB is edit : Data Source = DB Path , make sure to add '\\' instead of '\' ; and Intial Catalog = *database name*
        //Where you are running your program from
        
         //Laptop - Main Directory
        //static string stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Andrew Nguyen\\Documents\\Projects\\BlackBoard_Application\\StudentInfo.mdf;Integrated Security=True"; 
        //Laptop - Home Directory
        static string stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\admin\\Documents\\GitHub\\BlackBoard_Application\\StudentInfo.mdf;Integrated Security=True";
        SqlConnection con;
        public void OpenConnection()
        { 
            con = new SqlConnection(stringConnection);
            con.Open();
        }
        public void CloseConnection()
        { 
            con = new SqlConnection(stringConnection);
            con.Close();
        }
        public void ExecuteQueries(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader DataReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public static DataTable ExecuteSql(string sql)
        {
            var con = new SqlConnection(); //Create SQL connection

            var dt = new DataTable(); 
            
                try
                {

                    con.ConnectionString = stringConnection;
                    con.Open();

                    var adapter = new SqlDataAdapter(sql, con);
                        adapter.Fill(dt);
                       
                    con.Close();
                    con = null;

                    return dt;
                }
                //Catch any error code that may occur
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error occured: " + ex.Message,
                        "SQL Server Connection failed to connect",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                }

                //con.Dispose();

                return dt;
            
        }
    }
}
