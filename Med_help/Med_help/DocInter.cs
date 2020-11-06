using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class DocInter : Form
    {
        Doc doc;
        public DocInter(Doc doc)
        {
            InitializeComponent();
            this.doc = doc;
        }

        private void DocInter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rasp Login = new Rasp(doc);
            Login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work Login = new Work(doc);
            Login.Show();
        }
    }
}
