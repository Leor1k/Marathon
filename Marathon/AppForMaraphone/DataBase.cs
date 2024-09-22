﻿using AppForMaraphone.Classes;
using System;
using System.Data.SqlClient;

namespace AppForMaraphone
{
    public class DataBase
    {
        public string ConnectString { get; } = "Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True";

        public static User UserEnter(string login, string password)
        {
            string query = "SELECT * FROM dbo.[User] WHERE Email = @login";
            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@login", login);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (Hashes.VerifyPassword(password, reader.GetString(1)))
                        {
                            User enteredUser = new User(
                                                        reader.GetString(2),
                                                        reader.GetString(3),
                                                        Convert.ToChar(reader.GetString(4))
                                                    );
                            return enteredUser;
                        }
                        else
                        {
                            return null;
                        }
                        
                    }
                    else
                    {                  
                        return null;
                    }
                }
            }
        }
    }
}