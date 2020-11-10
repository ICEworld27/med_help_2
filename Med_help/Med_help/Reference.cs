using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    public class Reference : Document
    {
        public Reference(int number, Person owner, DateTime time_of_issue, string discript) : base(number, owner, time_of_issue)
        {

        }
        public override string ToString()
        {
            string end = "";
            end = base.ToString();
            return end;
        }
    }
}
