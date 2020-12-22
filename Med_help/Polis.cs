using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    class Polis : Document
    {
        public Polis(int number, Person owner, DateTime time_of_issue) : base(number, owner, time_of_issue)
        {

        }
    }
}
