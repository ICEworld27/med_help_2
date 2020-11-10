using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class AddSpravka : Form
    {
        Doc doc;
        Patient patient;
        public AddSpravka(Doc doc, Patient patient)
        {
            InitializeComponent();
            this.doc = doc;
            this.patient = patient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null && richTextBox1.Text != "")
            {
                if (textBox1.Text !=null && textBox1.Text != "")
                {
                    doc.Give_Reference(Convert.ToInt32(textBox1.Text), patient, DateTime.Now, richTextBox1.Text);
                    label3.Visible = true;
                    label3.Text = "Добавлено успешно!";
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                }
            }
            else
            {
                richTextBox1.BackColor = Color.Red;
            }
        }
    }
}
