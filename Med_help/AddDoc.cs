using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class AddDoc : Form
    {
        public AddDoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null || textBox1.Text != "")
            {
                if (textBox2.Text != null || textBox2.Text != "")
                {
                    if (textBox3.Text != null || textBox3.Text != "")
                    {
                        if (textBox4.Text != null || textBox4.Text != "")
                        {

                                Hospital hospital = Hospital.getInstance();
                                hospital.a.Add(new Doc(textBox1.Text, textBox2.Text, textBox1.Text + textBox2.Text, textBox3.Text, textBox4.Text));
                                Close();
                            
                        }
                        else
                        {
                            textBox4.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        if (textBox4.Text == null || textBox4.Text == "")
                        {

                                Hospital hospital = Hospital.getInstance();
                                hospital.a.Add(new Doc(textBox1.Text, textBox2.Text, textBox1.Text + textBox2.Text, textBox3.Text, textBox4.Text));

                        }
                        else
                        {
                            textBox4.BackColor = Color.Red;
                        }
                    }
                }
                else
                {
                    textBox2.BackColor = Color.Red;
                }
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

        }

        private void AddDoc_Load(object sender, EventArgs e)
        {

        }
    }
}
