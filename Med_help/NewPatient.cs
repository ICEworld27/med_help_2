using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null || textBox1.Text != "")
            {
                if (textBox2.Text != null || textBox2.Text != "")
                {
                    if (textBox3.Text != null || textBox3.Text != "")
                    {
                        if (textBox4.Text != null || textBox4.Text != "")
                        {
                            if (dateTimePicker1.Value.CompareTo(DateTime.Now) <= 0)
                            {
                                Hospital hospital = Hospital.getInstance();
                                hospital.b.Add(new Patient(textBox1.Text, textBox2.Text, textBox1.Text + textBox2.Text, textBox3.Text, dateTimePicker1.Value, Convert.ToInt32(textBox4.Text), textBox3.Text));
                                Close();
                            }
                            else
                            {
                                dateTimePicker1.CalendarTitleBackColor = Color.Red;
                            }

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
                            if (dateTimePicker1.Value.CompareTo(DateTime.Now) >= 0)
                            {
                                Hospital hospital = Hospital.getInstance();
                                hospital.b.Add(new Patient(textBox1.Text, textBox2.Text, textBox1.Text + textBox2.Text, textBox3.Text, dateTimePicker1.Value, Convert.ToInt32(textBox4.Text)));
                            }
                            else
                            {
                                dateTimePicker1.CalendarTitleBackColor = Color.Red;

                            }

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
    }
}
