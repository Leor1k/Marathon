using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForMaraphone.Class
{
    public class User
    {
        public User (string firstName, string lastName, char roleId)
        {
            FirstName = firstName;
            LastName = lastName;
            RoleId = roleId;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public char RoleId { get; }        
    }
}
