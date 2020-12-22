using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Med_help
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doc doc;
            Patient patient;
            
            //try
            //{
                ApplicationContext.getInstance().Load();
            //}
            //finally{
              //  new ERROR().ShowDialog();
            //}
            /*
            if (Hospital.getInstance().c.Count)
            Doc v = new Doc("Vasily", "P", "VasilyP", "Vasa5761", "Lor");
            Patient patient1 = new Patient("D", "D", "D", "D", DateTime.Now, 575575);
            
            v.q.Add(DateTime.Now, patient1);
            */
           // Hospital.getInstance().a.Add(v);

            bool log = false;
            Hospital hospital = Hospital.getInstance();
            if(hospital.admin == null)
            {
                hospital.admin = new Admin();
            }
            for (int i = 0; i < hospital.a.Count; i++)
            {
                if (hospital.a[i].Login(vLogin.Text, vPassword.Text) == true)
                {
                    doc = hospital.a[i];
                    log = true;


                    DocInter Loging = new DocInter(doc);
                    Loging.Show();
                }
            }
            for (int i = 0; i < hospital.b.Count; i++)
            {
                if (hospital.b[i].Login(vLogin.Text, vPassword.Text))
                {
                    patient = hospital.b[i];
                    log = true;
                    

                    PatientInter Login = new PatientInter(patient);
                    Login.Show();
                }
            }
            if (log) 
            {
                vv.Text = "loged";
               // this.Close();
               
            }

        }

        private void vv_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ApplicationContext.getInstance().Save();
        }
    }
}
