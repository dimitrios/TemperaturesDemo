using System;
using System.Collections.Generic;
using System.Data.SQLite;
using TemperaturesDemo.Models;

namespace TemperaturesDemo.Persistence
{
    public class SqliteTemperatureStore : ITemperatureStore
    {
        private string _connectionString;

        public SqliteTemperatureStore(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public IEnumerable<City> GetCities()
        {
            List<City> cities = new List<City>();

            using (SQLiteConnection sqliteConnection = new SQLiteConnection(_connectionString))
            {
                sqliteConnection.Open();

                using (SQLiteCommand selectCommand = sqliteConnection.CreateCommand())
                {
                    selectCommand.CommandText = @"SELECT City, Country FROM Temperatures";
                    using (SQLiteDataReader sqliteDataReader = selectCommand.ExecuteReader())
                    {
                        while (sqliteDataReader.Read())
                        {
                            cities.Add(new City(Convert.ToString(sqliteDataReader["City"]), Convert.ToString(sqliteDataReader["Country"])));
                        }
                    }
                }
            }

            return cities;
        }

        public void UpdateCityTemperature(City city, double temperature)
        {
            using (SQLiteConnection sqliteConnection = new SQLiteConnection(_connectionString))
            {
                sqliteConnection.Open();

                using (SQLiteCommand updateCommand = sqliteConnection.CreateCommand())
                {
                    updateCommand.CommandText = "UPDATE Temperatures SET Temperature = @temperature WHERE City = @city AND Country = @country;";
                    updateCommand.Parameters.AddWithValue("@city", city.Name);
                    updateCommand.Parameters.AddWithValue("@country", city.Country);
                    updateCommand.Parameters.AddWithValue("@temperature", temperature);
                    updateCommand.ExecuteNonQuery();
                }
            }
        }
    }
}