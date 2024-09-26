
namespace AppForMaraphone.Classes
{
    public class Country
    {
        public int CountryCode { get; }
        public string Name { get;}
        public string PhotoName { get;}
        public Country(int code, string name, string photo)
        {
            CountryCode = code;
            Name = name;
            PhotoName = photo;
        }
    }
}
