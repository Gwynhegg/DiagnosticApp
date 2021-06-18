using Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace DataBase
{
    class DataBaseConnection
    {
        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection connection;

            var dataBasePath = Path.Combine(FileSystem.AppDataDirectory, "DiagnosticApp.db");

            connection = new SQLiteConnection(dataBasePath);

            connection.CreateTable<Section>();
            connection.CreateTable<Symptom>();

            return connection;
        }
    }
}
