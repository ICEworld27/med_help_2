namespace Med_help
{
    partial class Work
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Docs = new System.Windows.Forms.ToolStripMenuItem();
            this.Spravka = new System.Windows.Forms.ToolStripMenuItem();
            this.Nanach = new System.Windows.Forms.ToolStripMenuItem();
            this.Ill = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.AddZapis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваш пациент:";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(758, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Docs,
            this.Ill,
            this.AddZapis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // Docs
            // 
            this.Docs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Spravka,
            this.Nanach});
            this.Docs.Name = "Docs";
            this.Docs.Size = new System.Drawing.Size(101, 24);
            this.Docs.Text = "Документы";
            // 
            // Spravka
            // 
            this.Spravka.Name = "Spravka";
            this.Spravka.Size = new System.Drawing.Size(224, 26);
            this.Spravka.Text = "Новая справка";
            this.Spravka.Click += new System.EventHandler(this.Spravka_Click);
            // 
            // Nanach
            // 
            this.Nanach.Name = "Nanach";
            this.Nanach.Size = new System.Drawing.Size(224, 26);
            this.Nanach.Text = "Новое назначение";
            this.Nanach.Click += new System.EventHandler(this.Nanach_Click);
            // 
            // Ill
            // 
            this.Ill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Restore});
            this.Ill.Name = "Ill";
            this.Ill.Size = new System.Drawing.Size(82, 24);
            this.Ill.Text = "Болезни";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(223, 26);
            this.New.Text = "Новая болезнь";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Restore
            // 
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(223, 26);
            this.Restore.Text = "Изменить болезнь";
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // AddZapis
            // 
            this.AddZapis.Name = "AddZapis";
            this.AddZapis.Size = new System.Drawing.Size(157, 24);
            this.AddZapis.Text = "Записать на приём";
            this.AddZapis.Click += new System.EventHandler(this.AddZapis_Click);
            // 
            // Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Work";
            this.Text = "Работа - HospitalX";
            this.Load += new System.EventHandler(this.Work_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Docs;
        private System.Windows.Forms.ToolStripMenuItem Spravka;
        private System.Windows.Forms.ToolStripMenuItem Nanach;
        private System.Windows.Forms.ToolStripMenuItem Ill;
        private System.Windows.Forms.ToolStripMenuItem AddZapis;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Restore;
    }
}