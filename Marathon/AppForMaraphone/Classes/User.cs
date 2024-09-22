namespace AppForMaraphone.Classes
{
    public class User
    {
        public User (string firstName, string lastName, char roleId)
        {
            RoleId = roleId;
            LastName = lastName;
            FirstName = firstName;
        }
        public string FirstName { get; } = null;
        public string LastName { get; } = null;
        public char RoleId { get; }
    }
}
