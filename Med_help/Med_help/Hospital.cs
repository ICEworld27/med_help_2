using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    class Hospital
    {
        public List<Doc> a = new List<Doc>();
        public List<Patient> b = new List<Patient>();
        private static Hospital instance;

        private Hospital()
        { }

        public static Hospital getInstance()
        {
            if (instance == null)
                instance = new Hospital();
            return instance;
        }
    }
}
