namespace AppForMaraphone.Classes
{
    public class DonateData
    {
        public string FirstNameRunner { get; }
        public string LastNameRunner { get; }
        public int CountryCode { get; }
        public string CountryName { get; }
        public int CharityCode { get; }
        public DonateData (string firstName, string lastName, int countryCode, string contryName, int charityCode )
        {
            FirstNameRunner = firstName.Trim();
            LastNameRunner = lastName.Trim();
            CountryCode = countryCode;
            CountryName = contryName.Trim();
            CharityCode = charityCode;
        }
        public string GetStringDate ()
        {
            return $"{FirstNameRunner} {LastNameRunner} - {CountryCode} ({CountryName})";
        }
    }
}
