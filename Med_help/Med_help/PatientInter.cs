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
            Naznach Login = new Naznach(patient1);
            Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spravki Login = new Spravki(patient1);
            Login.Show();
        }
    }
}
