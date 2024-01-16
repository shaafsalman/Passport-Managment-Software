using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace PointOfSales.Config
{
    public class UsableFunction
    {
        public int GetNextCargoID()
        {
            int nextID = 1;
            string connectionString = "Data Source = SS-PAVILION; Database = PassportManagmentDB; trusted_connection = true"; // Replace with your connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT MAX(CargoID) FROM Cargo";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextID = Convert.ToInt32(result) + 1;
                    }
                }
            }
            return nextID;
        }


    }
}
