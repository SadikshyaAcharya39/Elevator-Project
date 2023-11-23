using MySql.Data.MySqlClient;


namespace Project1_Elevator
{
    internal class MyDatabase
    {
        private MySqlConnection conn;
        private string url = "datasource=localhost;database=Elevator_Project;port=3306;user=root;password=Password3@";

        public MySqlConnection Connect()
        {
            try
            {
                conn = new MySqlConnection(url);
                conn.Open();
                return conn; // Return the connection object if successful
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null; // Return null to indicate failure
            }
        }

        public bool Close()
        {
            bool result = false;
            try
            {
                if (conn != null)
                {
                    conn.Close(); // Close the connection
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    }
}
