using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Someren
{
    class SomerenDB
    {  
       // private static SqlConnection openConnectionDB()
     //   {

            private static string connString = ConfigurationManager
         .ConnectionStrings["MyDatabaseConnection"]
         .ConnectionString;

     /*   // replace this with the connection string you received from Thijs Otter
            string host = "den1.mssql5.gear.host";
            string db = "projectdbgroupb2";
            string user = "projectdbgroupb2";
            string password = "Ps48dm3X-X4!";
            //string port = "3306";

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = host;
                builder.UserID = user;
                builder.Password = password;
                builder.InitialCatalog = db;

                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                
                connection.Open();
                return connection;

            }
            catch (SqlException e)
            {
                SqlConnection connection = null;
                Console.WriteLine(e.ToString());
                return connection;
            }            
        }

        private static void sluitConnectieDB(SqlConnection connection)
        {
            connection.Close();
        }
*/
        public List<SomerenModel.Student> DB_getStudents()
        {
            //   SqlConnection connection = openConnectionDB();
            SqlConnection connection = new SqlConnection(connString);
            List<SomerenModel.Student> studenten_lijst = new List<SomerenModel.Student>();

            connection.Open();
            StringBuilder sb = new StringBuilder();
            // write your query here to ensure a list of students is shown
            sb.Append("#query");

            /* EXAMPLE QUERY */
            //sb.Append("SELECT TOP 20 pc.Name as CategoryName, p.name as ProductName ");
            //sb.Append("FROM [SalesLT].[ProductCategory] pc ");
            //sb.Append("JOIN [SalesLT].[Product] p ");
            //sb.Append("ON pc.productcategoryid = p.productcategoryid;");
            /* */

            String sql = sb.ToString();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SomerenModel.Student student = new SomerenModel.Student();
                studenten_lijst.Add(student);
            }

            return studenten_lijst;
        }

        public static List<SomerenModel.Rooms> DB_getRooms()
        {
            //SqlConnection connection = openConnectionDB();
            SqlConnection connection = new SqlConnection(connString);
            List<SomerenModel.Rooms> rooms_list = new List<SomerenModel.Rooms>();

            connection.Open();
            

            //  SqlCommand command = new SqlCommand(sqlQuery, dbConnection);

         
            string sql = "SELECT RoomNumber, RoomCapacity, RoomType FROM dbo.Rooms";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SomerenModel.Rooms room = new SomerenModel.Rooms();
                room.setRoomNumber((int)reader["RoomNumber"]);
                room.setRoomCapacity((int)reader["RoomCapacity"]);
                room.setRoomType((bool)reader["RoomType"]);
                rooms_list.Add(room);
            }
            reader.Close();
            connection.Close();

            return rooms_list;
        }
    }
}
