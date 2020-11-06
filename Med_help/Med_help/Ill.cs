using System;
using System.Collections.Generic;
using System.Text;

namespace Med_help
{
    public class Ill
    {
        string discription;
        int period;
        bool question;
        public Ill(string discription, int period, bool question)
        {
            this.discription = discription;
            this.period = period;
            this.question = question;
        }
        public override string ToString()
        {
            string end = "";
            end += discription + ", длилась " + period +"дней ";
            if (question)
            {
                end += "диагноз под вопросом";
            }
            
            return end;
        }
    }
}
