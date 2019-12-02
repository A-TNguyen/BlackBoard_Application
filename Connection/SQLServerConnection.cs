using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace Blackboard_Application.Connection
{
    class SQLServerConnection
    {
        //Pleae make sure to change the AttachDBFileName
        //This is establishing the source connection where the DB is edit : Data Source = DB Path , make sure to add '\\' instead of '\' ; and Intial Catalog = *database name*
        public static string stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Andrew Nguyen\\Documents\\Projects\\Blackboard_Application\\BlackBoard_Application\\StudentInfo.mdf;Integrated Security=True";
        
        public static DataTable ExecuteSQL(string sql)
        {
            SqlConnection con = new SqlConnection(); //Create SQL connection
            using (DataTable dt = new DataTable()) //Created using so it can dispose of the variable
            {
                try
                {

                    con.ConnectionString = stringConnection;
                    con.Open();

                    //Create disposable pattern
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
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
                con.Dispose();

                return dt;
            }
        }
    }
}
