using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class AddIll : Form
    {
        Patient patient;
        public AddIll(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0 && richTextBox1.Text != null)
            {
                patient.Med_Card.Ills.Add(new Ill(richTextBox1.Text, (int)numericUpDown1.Value, checkBox1.Checked));
                label3.Text = "Добавлена успешно!";
            }
            else
            {
                richTextBox1.BackColor = Color.Crimson;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
