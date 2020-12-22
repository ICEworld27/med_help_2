using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class RestoreIll : Form
    {
        Patient patient;
        public RestoreIll(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            for (int i = 0; i <patient.Med_Card.Ills.Count; i++)
            {
                comboBox1.Items.Add(patient.Med_Card.Ills[i]);
            }
        }

        private void RestoreIll_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0 && richTextBox1.Text != null)
            {
                patient.Med_Card.Ills[comboBox1.SelectedIndex] = new Ill(richTextBox1.Text, (int)numericUpDown1.Value, checkBox1.Checked);
                label3.Text = "Изменена успешно!";
            }
            else
            {
                richTextBox1.BackColor = Color.Crimson;
            }
        }
    }
}
