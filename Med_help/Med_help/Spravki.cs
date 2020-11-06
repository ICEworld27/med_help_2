using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class Spravki : Form
    {
        public Spravki(Patient patient)
        {
            InitializeComponent();
            for (int i = 0; i < patient.references.Count; i++)
            {
                listBox1.Items.Add(patient.references[i]);
            }
            if (patient.references.Count <= 0)
            {
                listBox1.Items.Add("Нет справок!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
