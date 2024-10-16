namespace AppForMaraphone.Classes
{
    public class User
    {
        public User (string email,string firstName, string lastName, char roleId)
        {
            Email = email.Trim();
            RoleId = roleId;
            LastName = lastName.Trim();
            FirstName = firstName.Trim();
        }
        public User(string email, string password,string firstName, string lastName, char roleId)
        {
            Email = email.Trim();
            Password = Hashes.HashPassword(password, new byte[16]);
            RoleId = roleId;
            LastName = lastName.Trim();
            FirstName = firstName.Trim();
        }
        public string Email { get; } = null;
        public string Password { get; } =  null;  
        public string FirstName { get; } = null;
        public string LastName { get; } = null;
        public char RoleId { get; }
        
    }
}
