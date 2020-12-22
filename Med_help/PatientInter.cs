using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class PatientInter : Form
    {
        Patient patient1;
        public PatientInter(Patient patient)
        {
            InitializeComponent();
            patient1 = patient;
            Hospital hospital = Hospital.getInstance();
            for (int i = 0; i < hospital.a.Count; i++)
            {

                foreach (KeyValuePair<DateTime, Patient> key in hospital.a[i].q)
                {

                    if (key.Value == patient1)
                    {
                        listBox1.Items.Add(key.Key +" приём у: "+ hospital.a[i]);
                    }
                }
            }
        }

        private void PatientInter_Load(object sender, EventArgs e)
        {

        }

        private void zapis_Click(object sender, EventArgs e)
        { 
            Zapis Login = new Zapis(patient1);
            Login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           RestoreZapis  Login = new RestoreZapis(patient1);
            Login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Naznachs Login = new Naznachs(patient1);
            Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spravki Login = new Spravki(patient1);
            Login.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NewZapis_Click(object sender, EventArgs e)
        {
            Spravki Login = new Spravki(patient1);
            Login.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditZapis_Click(object sender, EventArgs e)
        {
            new RestoreZapis(patient1).ShowDialog();
        }

        private void NewZapis_Click_1(object sender, EventArgs e)
        {
            new Zapis(patient1).ShowDialog();
        }

        private void Spravki_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new Spravki(patient1).listBox1.Items);
        }

        private void Naznaches_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new Naznachs(patient1).listBox1.Items);
        }

        private void Zpais_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Hospital hospital = Hospital.getInstance();
            for (int i = 0; i < hospital.a.Count; i++)
            {

                foreach (KeyValuePair<DateTime, Patient> key in hospital.a[i].q)
                {

                    if (key.Value == patient1)
                    {
                        listBox1.Items.Add(key.Key + " приём у: " + hospital.a[i]);
                    }
                }
            }
        }
    }
}
