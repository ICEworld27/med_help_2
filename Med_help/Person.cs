using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Med_help
{
    public class Person
    {
        public string name;
        public string srname;
        public string otchestvo;
        public string login;
        public string password;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        bool loged = false;
        public Person(string name, string srname, string login, string password, string otchestvo = "")
        {
            
            this.name = name;
            this.srname = srname;
            this.login = login;
            this.password = password;
            this.otchestvo = otchestvo;
        }
        public Person()
        {

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
