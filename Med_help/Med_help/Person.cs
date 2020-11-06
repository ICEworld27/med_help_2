using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    public class Person
    {
        public string name;
        public string srname;
        public string otchestvo;
        public string login;
        public string password;
        bool loged = false;
        public Person(string name, string srname, string login, string password, string otchestvo = "")
        {
            this.name = name;
            this.srname = srname;
            this.login = login;
            this.password = password;
            this.otchestvo = otchestvo;
        }
        public bool Login(string login, string password)
        {
            if (this.loged == false)
            {
                if (this.password == password && this.login == login)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
                
            }

        }
    }
}
