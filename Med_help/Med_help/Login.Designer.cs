namespace Med_help
{
    partial class Login
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
            this.pLogin = new System.Windows.Forms.Label();
            this.pPassword = new System.Windows.Forms.Label();
            this.vLogin = new System.Windows.Forms.TextBox();
            this.vPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLogin.AutoSize = true;
            this.pLogin.Location = new System.Drawing.Point(379, 140);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(46, 20);
            this.pLogin.TabIndex = 0;
            this.pLogin.Text = "Login";
            // 
            // pPassword
            // 
            this.pPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pPassword.AutoSize = true;
            this.pPassword.Location = new System.Drawing.Point(364, 229);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(70, 20);
            this.pPassword.TabIndex = 1;
            this.pPassword.Text = "Password";
            // 
            // vLogin
            // 
            this.vLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vLogin.Location = new System.Drawing.Point(300, 163);
            this.vLogin.MinimumSize = new System.Drawing.Size(200, 30);
            this.vLogin.Name = "vLogin";
            this.vLogin.Size = new System.Drawing.Size(200, 27);
            this.vLogin.TabIndex = 2;
            // 
            // vPassword
            // 
            this.vPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vPassword.Location = new System.Drawing.Point(300, 252);
            this.vPassword.MinimumSize = new System.Drawing.Size(200, 30);
            this.vPassword.Name = "vPassword";
            this.vPassword.Size = new System.Drawing.Size(200, 27);
            this.vPassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(300, 318);
            this.button1.MinimumSize = new System.Drawing.Size(200, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vv
            // 
            this.vv.Location = new System.Drawing.Point(77, 390);
            this.vv.Name = "vv";
            this.vv.Size = new System.Drawing.Size(125, 29);
            this.vv.TabIndex = 5;
            this.vv.Click += new System.EventHandler(this.vv_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(445, 68);
            this.label1.MinimumSize = new System.Drawing.Size(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(325, 68);
            this.label2.MinimumSize = new System.Drawing.Size(124, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hospital";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vPassword);
            this.Controls.Add(this.vLogin);
            this.Controls.Add(this.pPassword);
            this.Controls.Add(this.pLogin);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Login";
            this.Text = "Авторизация - HospitalX";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pLogin;
        private System.Windows.Forms.Label pPassword;
        private System.Windows.Forms.TextBox vLogin;
        private System.Windows.Forms.TextBox vPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label vv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}