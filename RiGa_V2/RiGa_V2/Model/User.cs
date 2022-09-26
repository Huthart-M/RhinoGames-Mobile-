using System;
using System.Collections.Generic;
using System.Text;
//add ns
using SQLite;

namespace RiGa_V2.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
    }
}
