using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    public class Doc : Person
    {
        public string profession;
        public List<Patient> work = new List<Patient>();
        public Dictionary<DateTime, Patient> q = new Dictionary<DateTime, Patient>();
        public Doc(string name, string srname, string login, string password, string profession, string otchestvo = "") : base(name, srname, login, password, otchestvo)
        {
            this.profession = profession;
            Hospital hospital = Hospital.getInstance();
            hospital.a.Add(this);
           // Id = Hospital.getInstance().a.Count;
        }
        public Doc()
        {

        }
        public void Give_Reference(int time, Patient owner, DateTime time_of_issue, string discription)
        {
            owner.references.Add(new Reference(time, owner, time_of_issue, discription));
        }
        public void AddIll(Patient owner, Ill ill)
        {
            if (!owner.Med_Card.Ills.Contains(ill))
            {
                owner.Med_Card.Ills.Add(ill);
            }
        }
        public void RestoreIll(Patient owner, Ill ill, int index)
        {
            owner.Med_Card.Ills[index] = ill;
        }
        public void Next(Patient first)
        {
            work.Remove(first);
            foreach (KeyValuePair<DateTime, Patient> key in q)
            {
                if (key.Value == first)
                {
                    q.Remove(key.Key);
                }
            }
                
        }
        public override string ToString()
        {
            string end = "";
            end += srname + " " + name + " " + otchestvo + " Who works:  " + profession;
            return end;
        }
    }
}
