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
                if (key.Value == patient&& key.Key.CompareTo(DateTime.Now) < 60*60)
                {
                    doc.q.Remove(key.Key);
                }
            }
            label1.Text = "";

            if(good.Count > 0)
            {
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
                label1.Text = "Ваш пациент\n" + doc.q[good[0]];
                if (doc.q[good[0]].Med_Card.Ills.Count > 0)
                {
                    label1.Text += "\nПоследняя болезнь: " + doc.q[good[0]].Med_Card.Ills[doc.q[good[0]].Med_Card.Ills.Count - 1];
                }
                label1.Text += "\nВремя приёма " + good[0];
                label1.Visible = true;
                button1.Text = "Следующий";
                menuStrip1.Visible = true;
                doc.q.Remove(good[0]);
            }
            else
            {
                label1.Text = "Пока никто не записался на ваш приём";
                button1.Text = "Следующий";
                label1.Visible = true;
                menuStrip1.Visible = false;
            }

            
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
            new AddSpravka(doc, patient).Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            RestoreIll zapis = new RestoreIll(patient);
            zapis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNaznach addNaznach = new AddNaznach(patient);
            addNaznach.Show();
        }

        private void Work_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nanach_Click(object sender, EventArgs e)
        {
            AddNaznach addNaznach = new AddNaznach(patient);
            addNaznach.ShowDialog();
        }

        private void Spravka_Click(object sender, EventArgs e)
        {
            AddSpravka addNaznach = new AddSpravka(doc,patient);
            addNaznach.ShowDialog();
        }

        private void New_Click(object sender, EventArgs e)
        {
            AddIll addNaznach = new AddIll(patient);
            addNaznach.ShowDialog();
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            RestoreIll addNaznach = new RestoreIll(patient);
            addNaznach.ShowDialog();
        }

        private void AddZapis_Click(object sender, EventArgs e)
        {
            new Zapis(patient, true).ShowDialog();
        }
    }
}
