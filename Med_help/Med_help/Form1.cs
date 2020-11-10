using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_help
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bd = new DateTime();
            bd = DateTime.Now;
            bd = bd.AddYears(-30);
            Patient a;
            DateTime time = new DateTime();
            time = DateTime.Now;
            time = time.AddDays(10);
            a = new Patient("D", "D", "D", "D", bd, 554554);
            a.Add_Record(time, new Doc("Vasily", "Pupkin", "VasilyP", "Vasa5761", "Lor"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime bd = new DateTime();
            bd = DateTime.Now;
            bd = bd.AddYears(-30);
            Patient a;
            DateTime time = new DateTime();
            time = DateTime.Now;
            time = time.AddDays(10);
            a = new Patient("D", "D", "D", "D", bd, 554554);
            Doc c = new Doc("Vasily", "Pupkin", "VasilyP", "Vasa5761", "Lor");
            Doc b = new Doc("Sergey", "Ivanov", "SergeyI", "Sery8561", "Xiryrg");
            b.Give_Reference(555454, a, DateTime.Now);
            a.naznach.Add("Пей таблетки!");
            a.naznach.Add("Плоти налоги!");
            //a.Add_Record(DateTime.Now, c);
            Login Login= new Login();
            Login.Show(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
