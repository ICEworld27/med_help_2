namespace Med_help
{
    partial class Zapis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timezapis = new System.Windows.Forms.DateTimePicker();
            this.zapisatsa = new System.Windows.Forms.Button();
            this.doctorchose = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timezapis
            // 
            this.timezapis.Location = new System.Drawing.Point(12, 66);
            this.timezapis.MinDate = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            this.timezapis.MinimumSize = new System.Drawing.Size(250, 27);
            this.timezapis.Name = "timezapis";
            this.timezapis.Size = new System.Drawing.Size(373, 27);
            this.timezapis.TabIndex = 1;
            this.timezapis.ValueChanged += new System.EventHandler(this.timezapis_ValueChanged);
            // 
            // zapisatsa
            // 
            this.zapisatsa.Location = new System.Drawing.Point(167, 172);
            this.zapisatsa.Name = "zapisatsa";
            this.zapisatsa.Size = new System.Drawing.Size(106, 41);
            this.zapisatsa.TabIndex = 2;
            this.zapisatsa.Text = "OK";
            this.zapisatsa.UseVisualStyleBackColor = true;
            this.zapisatsa.Click += new System.EventHandler(this.zapisatsa_Click);
            // 
            // doctorchose
            // 
            this.doctorchose.Location = new System.Drawing.Point(12, 12);
            this.doctorchose.MinimumSize = new System.Drawing.Size(250, 0);
            this.doctorchose.Name = "doctorchose";
            this.doctorchose.Size = new System.Drawing.Size(373, 28);
            this.doctorchose.TabIndex = 3;
            this.doctorchose.Text = "Врач:";
            this.doctorchose.SelectedIndexChanged += new System.EventHandler(this.doctorchose_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.MinimumSize = new System.Drawing.Size(176, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите дату приема: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите время приема: ";
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "HH:mm";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.Location = new System.Drawing.Point(12, 119);
            this.dateTime.Name = "dateTime";
            this.dateTime.ShowUpDown = true;
            this.dateTime.Size = new System.Drawing.Size(373, 27);
            this.dateTime.TabIndex = 5;
            this.dateTime.Value = new System.DateTime(2020, 11, 4, 18, 38, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.zapisatsa_Click);
            // 
            // Zapis
            // 
            this.AcceptButton = this.zapisatsa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(397, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorchose);
            this.Controls.Add(this.zapisatsa);
            this.Controls.Add(this.timezapis);
            this.MaximumSize = new System.Drawing.Size(415, 269);
            this.MinimumSize = new System.Drawing.Size(415, 269);
            this.Name = "Zapis";
            this.Text = "Запись на прием - HospitalX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker timezapis;
        private System.Windows.Forms.Button zapisatsa;
        private System.Windows.Forms.ComboBox doctorchose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}