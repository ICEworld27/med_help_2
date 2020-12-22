using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class Rasp : Form
    {
        Doc doc;
        public Rasp(Doc doc)
        {
            InitializeComponent();
            this.doc = doc;
            List<DateTime> good = new List<DateTime>();
            foreach (KeyValuePair<DateTime, Patient> key in doc.q)
            {
                good.Add(key.Key);
            }
            for (int i = 0; i < good.Count-1; i++)
            {
                if (good[i].CompareTo(good[i+1]) > 0)
                {
                    DateTime dateTime = new DateTime();
                    dateTime = good[i];
                    good[i] = good[i + 1];
                    good[i + 1] = dateTime;
                }

            }
            for (int i = 0; i < good.Count; i++)
            {
                listBox1.Items.Add(good[i] + " - " + doc.q[good[i]]);
            }
        }

        private void Rasp_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
