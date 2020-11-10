using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class AddNaznach : Form
    {
        Patient person;
        public AddNaznach(Patient person)
        {
            InitializeComponent();
            this.person = person;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && richTextBox1.Text != null)
            {
                person.naznach.Add(richTextBox1.Text);
                label2.Text = "Успешно добавлено!";
            }
            else
            {
                richTextBox1.BackColor = Color.Red;
            }
        }
    }
}
