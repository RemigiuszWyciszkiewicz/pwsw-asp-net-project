﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Services
{
    public class DataBaseConnection
    {
        protected MySqlConnection conn = new MySqlConnection(
           "server=localhost;user id=root;database=bookstore;password=remik;");

        protected void openConnection()
        {
            Console.WriteLine("CONNECTION OPEN");
            conn.Open();
        }

        protected void closeConnection()
        {
            Console.WriteLine("CONNECTION CLOSE");
            conn.Close();
        }
    }
}
