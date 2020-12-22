using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class Zapis : Form
    {
        Patient patient1;
        bool docint;
        public Zapis(Patient patient, bool docint = false)
        {
            InitializeComponent();
            timezapis.MinDate = DateTime.Now;
            timezapis.MaxDate = DateTime.Now.AddYears(1);
            patient1 = patient;
            this.docint = docint;
            if (docint)
            {
                zapisatsa.Text = "Записать";
            }
            Hospital hospital = Hospital.getInstance();
            for (int i = 0; i < hospital.a.Count; i++)
            {
                
                doctorchose.Items.Add(hospital.a[i]);
            }
            
        }

        private void zapisatsa_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();

            dt = dt.AddYears(timezapis.Value.Year-1);
            dt = dt.AddMonths(timezapis.Value.Month-1);
            dt = dt.AddDays(timezapis.Value.Day-1);
            dt = dt.AddHours(dateTime.Value.Hour);
            dt = dt.AddMinutes(dateTime.Value.Minute);
            if (doctorchose.SelectedItem != null)
            {
                if (((Doc)doctorchose.SelectedItem).q.ContainsKey(dt) == false && dt.Hour < 17 && dt.Hour >= 8)
                {
                    patient1.Add_Record(dt, (Doc)doctorchose.SelectedItem);
                    this.Close();
                }
                else
                {
                    label3.Text = "Это время занято или врач не принимает в это время.";
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                doctorchose.BackColor = Color.Crimson;
            }
            
        }

        private void doclist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timezapis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void doctorchose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
