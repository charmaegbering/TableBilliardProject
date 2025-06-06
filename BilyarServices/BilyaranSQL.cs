using System;
using System.Collections.Generic;
using BilyaranCommon;
using BilyaranServices;
using Microsoft.Data.SqlClient;

namespace BilyaranServices
{
    public class BilyaranSQL : IBilyarDataService
    {
        private string connectionString = "Data Source=DESKTOP-VBQL3K5\\SQLEXPRESS; Initial Catalog=billiards; Integrated Security=True; TrustServerCertificate=True;";

        
        public List<BTables> GetAllTables()
        {
            var tables = new Dictionary<int, BTables>();

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var sqlStatement = "SELECT TableNumber, Name, Payment FROM BilliardTable";
                SqlCommand selectCommand = new SqlCommand(sqlStatement, sqlConnection);
                sqlConnection.Open();

                using (var read = selectCommand.ExecuteReader())
                {
                    while (read.Read())
                    {
                        int tableNumber = Convert.ToInt32(read["TableNumber"]);
                        string name = read["Name"].ToString();
                        int payment = Convert.ToInt32(read["Payment"]);

                        if (!tables.ContainsKey(tableNumber))
                            tables[tableNumber] = new BTables(tableNumber);

                        tables[tableNumber].BilyarPlayers.Add(new Player { Name = name, Payment = payment });
                    }
                }
            }

            return new List<BTables>(tables.Values);
        }

      
        public BTables GetTables(int tableNumber)
        {
            var table = new BTables(tableNumber);

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var Statement = "SELECT Name, Payment FROM BilliardTable WHERE TableNumber = @TableNumber";
                SqlCommand selectCommand = new SqlCommand(Statement, sqlConnection);
                selectCommand.Parameters.AddWithValue("@TableNumber", tableNumber);
                sqlConnection.Open();

                using (var read = selectCommand.ExecuteReader())
                {
                    while (read.Read())
                    {
                        string name = read["Name"].ToString();
                        int payment = Convert.ToInt32(read["Payment"]);
                        table.BilyarPlayers.Add(new Player { Name = name, Payment = payment });
                    }
                }
            }

            return table;
        }

       
        public void AddPlayerToTable(int tableNumber, string playerName)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var Insert = "INSERT INTO BilliardTable (TableNumber, Name, Payment) VALUES (@TableNumber, @Name, @Payment)";
                SqlCommand insertCommand = new SqlCommand(Insert, sqlConnection);
                insertCommand.Parameters.AddWithValue("@TableNumber", tableNumber);
                insertCommand.Parameters.AddWithValue("@Name", playerName);
                insertCommand.Parameters.AddWithValue("@Payment", 0);

                sqlConnection.Open();
                insertCommand.ExecuteNonQuery();
            }
        }

        
        public bool RemovePlayer(int tableNumber)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var Delete = "DELETE FROM BilliardTable WHERE TableNumber = @TableNumber";
                SqlCommand deleteCommand = new SqlCommand(Delete, sqlConnection);
                deleteCommand.Parameters.AddWithValue("@TableNumber", tableNumber);
                sqlConnection.Open();
                int rows = deleteCommand.ExecuteNonQuery();
                return rows > 0;
            }
        }

       
        public bool UpdatePayment(int tableNumber, string playerName, int payment)
        {
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var Update = "UPDATE BilliardTable SET Payment = @Payment WHERE TableNumber = @TableNumber AND Name = @Name";
                SqlCommand updateCommand = new SqlCommand(Update, sqlConnection);
                updateCommand.Parameters.AddWithValue("@Payment", payment);
                updateCommand.Parameters.AddWithValue("@TableNumber", tableNumber);
                updateCommand.Parameters.AddWithValue("@Name", playerName);
                sqlConnection.Open();
                int rows = updateCommand.ExecuteNonQuery();
                return rows > 0;
            }
        }
    }
}
