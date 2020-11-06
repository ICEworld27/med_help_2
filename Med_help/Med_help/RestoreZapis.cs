using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class RestoreZapis : Form
    {
        Patient patient;
        public RestoreZapis(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            Hospital hospital = Hospital.getInstance();
            Dictionary<DateTime, Doc> ab = new Dictionary<DateTime, Doc>();
            for (int i = 0; i < hospital.a.Count; i++)
            {
                foreach (KeyValuePair<DateTime, Patient> key in hospital.a[i].q)
                {
                    if (key.Value == patient)
                    {
                        restore_zapis.Items.Add(key.Key +" - "+ hospital.a[i].profession);
                        ab.Add(key.Key, hospital.a[i]);
                        //00.00.0000 00:00 //16+3=19
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zapisatsa_Click(object sender, EventArgs e)
        {

            if (restore_zapis.SelectedItem != null)
            {
                string text = restore_zapis.SelectedItem.ToString();
                string doc = text.Substring(21);
                string time = text.Substring(0, 19);
                //Doc doc1 = (Doc)doc;
                //DateTime dtime = DateTime.ParseExact(time, "dd.MM.yyyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                DateTime dtime = DateTime.Parse(time);
                Hospital hospital = Hospital.getInstance();
                Doc doc1 = new Doc("","","","","");
                for (int i = 0; i < hospital.a.Count; i++)
                {

                    foreach (KeyValuePair<DateTime, Patient> key in hospital.a[i].q)
                    {

                        if (key.Value == patient && key.Key == dtime)
                        {
                            doc1 = hospital.a[i];
                        }
                    }
                }
                DateTime dt = new DateTime();

                dt = dt.AddYears(timezapis.Value.Year - 1);
                dt = dt.AddMonths(timezapis.Value.Month - 1);
                dt = dt.AddDays(timezapis.Value.Day - 1);
                dt = dt.AddHours(dateTime.Value.Hour - 1);
                dt = dt.AddMinutes(dateTime.Value.Minute - 1);
                
                if (!doc1.q.ContainsKey(dt) && dtime.Hour < 17 && dtime.Hour >= 8)
                {
                    patient.Restor_Record(dtime, doc1, dt);
                    this.Close();
                }
                else
                {
                    label5.Text = "Это время занято или врач не принимает в это время.";
                    label5.ForeColor = Color.Red;
                }

            }
            else
            {
                restore_zapis.BackColor = Color.Crimson;
            }
        }
    }
}
