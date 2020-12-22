namespace Med_help
{
    partial class PatientInter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ZapisM = new System.Windows.Forms.ToolStripMenuItem();
            this.NewZapis = new System.Windows.Forms.ToolStripMenuItem();
            this.EditZapis = new System.Windows.Forms.ToolStripMenuItem();
            this.Zpais = new System.Windows.Forms.ToolStripMenuItem();
            this.Spravki = new System.Windows.Forms.ToolStripMenuItem();
            this.Naznaches = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZapisM,
            this.Spravki,
            this.Naznaches});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Главное меню";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ZapisM
            // 
            this.ZapisM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewZapis,
            this.EditZapis,
            this.Zpais});
            this.ZapisM.Name = "ZapisM";
            this.ZapisM.Size = new System.Drawing.Size(72, 24);
            this.ZapisM.Text = "Запись";
            // 
            // NewZapis
            // 
            this.NewZapis.Name = "NewZapis";
            this.NewZapis.Size = new System.Drawing.Size(229, 26);
            this.NewZapis.Text = "Записаться";
            this.NewZapis.Click += new System.EventHandler(this.NewZapis_Click_1);
            // 
            // EditZapis
            // 
            this.EditZapis.Name = "EditZapis";
            this.EditZapis.Size = new System.Drawing.Size(229, 26);
            this.EditZapis.Text = "Изменить запись";
            this.EditZapis.Click += new System.EventHandler(this.EditZapis_Click);
            // 
            // Zpais
            // 
            this.Zpais.Name = "Zpais";
            this.Zpais.Size = new System.Drawing.Size(229, 26);
            this.Zpais.Text = "Посмотреть записи";
            this.Zpais.Click += new System.EventHandler(this.Zpais_Click);
            // 
            // Spravki
            // 
            this.Spravki.Name = "Spravki";
            this.Spravki.Size = new System.Drawing.Size(82, 24);
            this.Spravki.Text = "Справки";
            this.Spravki.Click += new System.EventHandler(this.Spravki_Click);
            // 
            // Naznaches
            // 
            this.Naznaches.Name = "Naznaches";
            this.Naznaches.Size = new System.Drawing.Size(108, 24);
            this.Naznaches.Text = "Назначения";
            this.Naznaches.Click += new System.EventHandler(this.Naznaches_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(782, 425);
            this.listBox1.TabIndex = 5;
            // 
            // PatientInter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "PatientInter";
            this.Text = "Помошник пациента - HospitalX";
            this.Load += new System.EventHandler(this.PatientInter_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ZapisM;
        private System.Windows.Forms.ToolStripMenuItem Spravki;
        private System.Windows.Forms.ToolStripMenuItem Naznaches;
        private System.Windows.Forms.ToolStripMenuItem NewZapis;
        private System.Windows.Forms.ToolStripMenuItem EditZapis;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem Zpais;
    }
}