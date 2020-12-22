using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
namespace Med_help
{
    public class Patient : Person
    {
        List<Document> documents = new List<Document>();
        DateTime bd;
        public List<string> naznach = new List<string>();
        public Med_card Med_Card;
        public List<Reference> references = new List<Reference>();
        
        public Patient(string name, string srname, string login, string password, DateTime bd, int med_number,  string otchestvo = "") : base(name, srname, login, password, otchestvo)
        {
            this.bd = bd;
            Med_Card = new Med_card(med_number, this, new DateTime());
            Hospital hospital = Hospital.getInstance();
           // Id = Hospital.getInstance().b.Count;
            hospital.b.Add(this);

        }
        public Patient()
        {

        }
        public void Add_Record(DateTime time, Doc doc)
        {
            if (!doc.q.ContainsKey(time))
            {
                doc.q.Add(time, this);
                doc.work.Add(this);
            }

                string qrtext = this + "\nGo to: " + doc + "\nTime: " + time; 
                QRCodeEncoder encoder = new QRCodeEncoder(); 
                Bitmap qrcode = encoder.Encode(qrtext); 
            SaveFileDialog save = new SaveFileDialog(); 
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp"; 
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                (qrcode as Image).Save(save.FileName); 
            }
        }
        public void Restor_Record(DateTime time, Doc doc, DateTime newTime)
        {
            if (doc.q.ContainsKey(time))
            {
                foreach (KeyValuePair<DateTime, Patient> key in doc.q)
                {
                    if (key.Value == this)
                    {
                        doc.q.Remove(key.Key);
                    }
                }
                doc.q.Add(newTime, this);
                string qrtext = this + "\nGo to: " + doc + "\nTime: " + newTime;
                QRCodeEncoder encoder = new QRCodeEncoder();
                Bitmap qrcode = encoder.Encode(qrtext);
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    (qrcode as Image).Save(save.FileName);
                }
            }
        }
        public override string ToString()
        {
            string end = "";
            end += srname + " " + name + " " + otchestvo + " Borned in " + bd;
            return end;
        }
    }
}

