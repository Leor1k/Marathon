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
                                                        reader.GetString(0),
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
        public static bool ExistUser(string login)
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
                        return true;
                    }
                    else
                    {
                        return false;
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
                        Country countr = new Country(reader.GetInt32(0), reader.GetString(1).Trim(), reader.GetString(2).Trim());
                        list.Add(countr);
                    }
                }
            }
            return list;
        }
        public static void InsertNewRunner(Runner newRunner)
        {
            if (ExistUser(newRunner.Email))
            {
                throw new Exception("Пользователь с такой электронной почтой уже существует");
            }
            else
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
        public static List<Charity> GetCharity()
        {
            List<Charity> list = new List<Charity>();
            string query = "Select * from Charity";
            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //Country countr = new Country(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        //list.Add(countr);
                        Charity cccharity = new Charity(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        list.Add(cccharity);
                    }
                }
            }
            return list;
        }
        public static void CreateRegistration(Registration reg)
        {
            string sqlExpression =
               "DECLARE @LastIdRegistration int = (Select MAX(Regisrtation.RegistrationId) from Regisrtation) " +
               "INSERT INTO [dbo].[Regisrtation] ([RegistrationId], [RannerId], [RegistrationDateTime], [RaceKitOption], [RegistrationStatus], [Cost], [Charity]) " +
               "VALUES (@LastIdRegistration+1,@runId, @DateReg, @Kit, @Status, @Cost, @Char);";

            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                //command.Parameters.AddWithValue("@gender", newRunner.Gender.Trim());
                command.Parameters.AddWithValue("@runId", reg.RanerId);
                command.Parameters.AddWithValue("@DateReg", reg.DateRegestration);
                command.Parameters.AddWithValue("@Kit", reg.RaceKitOption);
                command.Parameters.AddWithValue("@Status", 1);
                command.Parameters.AddWithValue("@Cost", reg.Cost);
                command.Parameters.AddWithValue("@Char", reg.SelectedCharity.CharId);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Регистрация успешна");
            }
        }
        public static int GetIdByEmail(string Email)
        {
            string query = "Select Runner.RunnerId from Runner where Runner.Email = @Email";
            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Email", Email);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
            return 0;
        }
        public static Runner RunnerEnter(User enteredUser)
        {
            string query = "SELECT * FROM dbo.[Runner] WHERE Email = @email";
            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", enteredUser.Email.Trim());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string gender = string.Empty;
                        if (reader.GetInt32(2) == 1)
                        {
                            gender = "Мужчина";
                        }
                        else
                        {
                            gender = "Женщина";
                        }
                        Runner ex = new Runner
                            (
                                enteredUser.Email, 
                                enteredUser.FirstName, 
                                enteredUser.LastName, 
                                'R', 
                                gender, 
                                reader.GetDateTime(3), 
                                GetCountryByCode(reader.GetInt32(4)));
                        return ex;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public static Country GetCountryByCode(int CountryCode)
        {
            List<Country> list = new List<Country>();
            string query = "Select * from Country where  Country.CountryCode = @code";

            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@code", CountryCode);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Country countr = new Country(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        return countr;
                    }
                }
            }
            return null;
        }
        public static void UpDateRunner(Runner ur, string squery)
        {
            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(squery, connection);
                if (ur.Password != null)
                {
                    cmd.Parameters.AddWithValue("@pass", ur.Password);
                }
                cmd.Parameters.AddWithValue("@FirstName", ur.FirstName);
                cmd.Parameters.AddWithValue("@LastName", ur.LastName);
                cmd.Parameters.AddWithValue("@Email", ur.Email);
                cmd.Parameters.AddWithValue("@Code", ur.CountryData.CountryCode);
                cmd.Parameters.AddWithValue("@DateTime", ur.DateBirth);
                int number = cmd.ExecuteNonQuery();
                Console.WriteLine($"Ваши Данные успешно обновленны");
            }
        }
        public static List<DonateData> GetDonateList()
        {
            string query = "Select dbo.[User].FirstName, dbo.[User].LastName, Runner.CountryCode, Country.CountryName, Regisrtation.Charity from dbo.[User]\r\nRight join Runner on dbo.[User].Email = Runner.Email\r\nLeft join Country on Runner.CountryCode = Country.CountryCode\r\nRight join Regisrtation on Runner.RunnerId = Regisrtation.RannerId";
            List <DonateData> list = new List<DonateData>();
            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DonateData donate = new DonateData(reader.GetString(0),reader.GetString(1),reader.GetInt32(2),reader.GetString(3),reader.GetInt32(4));
                        list.Add(donate);                  
                    }
                }
            }
            return list;
        }
        public static void CreateSponsorShip (SponsorShip sp)
        {
            string sqlExpression =
               "DECLARE @LastIdSponsor int = (Select MAX(Sponsorship.SponsorshipId) from Sponsorship) " +
               "DECLARE @RegistrationId int = (Select Regisrtation.RegistrationId from Regisrtation where Regisrtation.RannerId = @RunnerId )" +
               "INSERT INTO [dbo].[Sponsorship] ([SponsorshipId], [SponsorName], [RegistrationId], [Amount]) " +
               "VALUES (@LastIdSponsor+1, @NameDonater, @RegistrationId, @Amount)";

            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@NameDonater", sp.SponsorName);
                command.Parameters.AddWithValue("@RunnerId", sp.RegistrationId);
                command.Parameters.AddWithValue("@Amount", sp.Amount);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Регистрация успешна");
            }
        }
        public static int getRunnerByFirstAndLastNeme()
        {
            string sqlExpression =
              "Select Runner.RunnerId from Runner " +
              "Inner join dbo.[User] on Runner.Email = dbo.[User].Email " +
              "where dbo.[User].FirstName = 'Irishka' and dbo.[User].LastName = 'ChikiPiki' ";

            using (SqlConnection connection = new SqlConnection("Server =(localdb)\\MSSQLLocalDB; Database = Marathon; Trusted_Connection=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.AddWithValue("@NameDonater", sp.SponsorName);
                command.Parameters.AddWithValue("@RunnerId", sp.RegistrationId);
                command.Parameters.AddWithValue("@Amount", sp.Amount);
                int number = command.ExecuteNonQuery();
                MessageBox.Show("Регистрация успешна");
            }
        }

    }
}
