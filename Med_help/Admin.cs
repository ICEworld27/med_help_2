using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    class Admin : Person
    {
       
        public Admin(string name = "admin", string srname = "admin", string login="admin", string password="admin", string otchestvo = "") : base(name, srname, login, password, otchestvo)
        {
            Console.Beep();
        }
    }
}
