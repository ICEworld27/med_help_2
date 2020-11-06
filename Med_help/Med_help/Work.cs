using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class Work : Form
    {
        Doc doc;
        Patient patient;
        public Work(Doc doc)
        {
            InitializeComponent();
            this.doc = doc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DateTime> good = new List<DateTime>();
            foreach (KeyValuePair<DateTime, Patient> key in doc.q)
            {
                good.Add(key.Key);
            }
            label1.Text = "";
            for (int i = 0; i < good.Count - 1; i++)
            {
                if (good[i].CompareTo(good[i + 1]) > 0)
                {
                    DateTime dateTime = new DateTime();
                    dateTime = good[i];
                    good[i] = good[i + 1];
                    good[i + 1] = dateTime;
                }

            }
            
            patient = doc.q[good[0]];
            label1.Text += "\n" + doc.q[good[0]];
            if (doc.q[good[0]].Med_Card.Ills.Count > 0)
            {
                label1.Text += "\nПоследняя болезнь: " + doc.q[good[0]].Med_Card.Ills[doc.q[good[0]].Med_Card.Ills.Count - 1];
            }
            label1.Text += "\nВремя приёма " + good[0];
            label1.Visible = true;
            button1.Text = "Следующий";
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            good.Remove(good[0]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zapis zapis = new Zapis(patient, true); 
            zapis.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddIll zapis = new AddIll(patient);
            zapis.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            RestoreIll zapis = new RestoreIll(patient);
            zapis.Show();
        }
    }
}
