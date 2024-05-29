using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace gas_station
{
    public class FuelTypeRepository
    {
        private string _connectionString;

        public FuelTypeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<FuelType> GetAllFuelTypes()
        {
            List<FuelType> fuelTypes = new List<FuelType>();

            using (SqliteConnection connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM FuelTypes";

                using (SqliteCommand command = new SqliteCommand(query, connection))
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fuelTypes.Add(new FuelType
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }

            return fuelTypes;
        }
    }
}
