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
            this.SuspendLayout();
            // 
            // timezapis
            // 
            this.timezapis.Location = new System.Drawing.Point(289, 125);
            this.timezapis.MinDate = new System.DateTime(2020, 11, 4, 0, 0, 0, 0);
            this.timezapis.Name = "timezapis";
            this.timezapis.Size = new System.Drawing.Size(250, 27);
            this.timezapis.TabIndex = 1;
            this.timezapis.ValueChanged += new System.EventHandler(this.timezapis_ValueChanged);
            // 
            // zapisatsa
            // 
            this.zapisatsa.Location = new System.Drawing.Point(12, 375);
            this.zapisatsa.Name = "zapisatsa";
            this.zapisatsa.Size = new System.Drawing.Size(776, 52);
            this.zapisatsa.TabIndex = 2;
            this.zapisatsa.Text = "записться";
            this.zapisatsa.UseVisualStyleBackColor = true;
            this.zapisatsa.Click += new System.EventHandler(this.zapisatsa_Click);
            // 
            // doctorchose
            // 
            this.doctorchose.Location = new System.Drawing.Point(289, 30);
            this.doctorchose.Name = "doctorchose";
            this.doctorchose.Size = new System.Drawing.Size(250, 28);
            this.doctorchose.TabIndex = 3;
            this.doctorchose.Text = "Врач:";
            this.doctorchose.SelectedIndexChanged += new System.EventHandler(this.doctorchose_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите дату приема: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите время приема: ";
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "HH:mm";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime.Location = new System.Drawing.Point(289, 198);
            this.dateTime.Name = "dateTime";
            this.dateTime.ShowUpDown = true;
            this.dateTime.Size = new System.Drawing.Size(250, 27);
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
            // Zapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorchose);
            this.Controls.Add(this.zapisatsa);
            this.Controls.Add(this.timezapis);
            this.Name = "Zapis";
            this.Text = "Zapis";
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
    }
}