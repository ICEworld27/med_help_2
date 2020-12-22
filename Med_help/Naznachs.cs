using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class Naznachs : Form
    {
        public Naznachs(Patient patient)
        {
            InitializeComponent();
            for (int i = 0; i < patient.naznach.Count;  i++)
            {
                listBox1.Items.Add(patient.naznach[i]);
            }
            if (patient.naznach.Count <= 0)
            {
                listBox1.Items.Add("Нет назначений!");
            }
        }

        private void Naznach_Load(object sender, EventArgs e)
        {

        }
    }
}
