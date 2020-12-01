using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
namespace Med_help
{
    class Hospital
    {
        public List<Doc> a = new List<Doc>();
        private static Hospital instance;
        public List<Patient> b = new List<Patient>();
        


        public static Hospital getInstance()
        {
            if (instance == null)
                instance = new Hospital();
            return instance;
        }
    }
}
