using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForMaraphone
{
    public class DataBase
    {
        public string ConnectString { get; } = "Server =(localdb)\\MSSQLLocalDB; Database = Doctors; Trusted_Connection=True";
    }
}
