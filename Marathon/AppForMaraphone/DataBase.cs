using AppForMaraphone.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

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
        public static List<Country> GetCountryList()
        {
            List<Country> list = new List<Country>();
            string query = "Select * from Country";
            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);         
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Country countr = new Country(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        list.Add(countr);
                    }                 
                }
            }
            return list;
        }
        public static void InsertNewRunner (Runner newRunner)
        {
            string sqlExpression = 
                "Declare @IdGender int = (Select Gender.GenderId from Gender where Gender.Gender = @gender)" +
                "DECLARE @LastIdRunner int = (Select MAX(Runner.RunnerId) from Runner) " +
                "INSERT INTO [dbo].[User] ([Email], [Password], [FirstName], [LastName], [RoleId]) " +
                    "VALUES (@Email, @Password, @FirstName, @LastName, N'R') " +
                "INSERT INTO [dbo].[Runner] ([RunnerId], [Email], [Gender], [DateOfBirth], [CountryCode]) " +
                    "VALUES (@LastIdRunner+1,@Email , @IdGender, @DateBirth, @CountryCode);";

            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@gender", newRunner.Gender.Trim());
                command.Parameters.AddWithValue("@Email", newRunner.Email.Trim());
                command.Parameters.AddWithValue("@Password", newRunner.Password.Trim());
                command.Parameters.AddWithValue("@FirstName", newRunner.FirstName.Trim());
                command.Parameters.AddWithValue("@LastName", newRunner.LastName.Trim());
                command.Parameters.AddWithValue("@DateBirth", newRunner.DateBirth);
                command.Parameters.AddWithValue("@CountryCode", newRunner.CountryData.CountryCode);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Регистрация успешна");
            }
        }
    }
}
