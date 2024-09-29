using System;

namespace AppForMaraphone.Classes
{
    public class Runner : User
    {
        public Runner (string email, string password, string firstName, string lastName, char roleId, string gender, DateTime dateBitth, Country countryData ) : base (email, password,firstName, lastName, roleId)
        {
            Gender = gender;
            DateBirth = dateBitth;
            CountryData = countryData;
        }
        public string Gender { get; }
        public DateTime DateBirth { get; }
        public Country CountryData { get; }
    }
}
