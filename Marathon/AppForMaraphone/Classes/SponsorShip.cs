
namespace AppForMaraphone.Classes
{
    public class SponsorShip
    {
        public string SponsorName { get; }
        public int RegistrationId { get; }
        public int Amount { get; }
        public SponsorShip (string name, int registrationId, int amount)
        {
            SponsorName = name;
            RegistrationId = registrationId;
            Amount = amount;
        }
    }
}
