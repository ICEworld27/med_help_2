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
            this.SuspendLayout();
            // 
            // pLogin
            // 
            this.pLogin.AutoSize = true;
            this.pLogin.Location = new System.Drawing.Point(357, 80);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(46, 20);
            this.pLogin.TabIndex = 0;
            this.pLogin.Text = "Login";
            // 
            // pPassword
            // 
            this.pPassword.AutoSize = true;
            this.pPassword.Location = new System.Drawing.Point(347, 145);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(70, 20);
            this.pPassword.TabIndex = 1;
            this.pPassword.Text = "Password";
            // 
            // vLogin
            // 
            this.vLogin.Location = new System.Drawing.Point(320, 103);
            this.vLogin.Name = "vLogin";
            this.vLogin.Size = new System.Drawing.Size(125, 27);
            this.vLogin.TabIndex = 2;
            // 
            // vPassword
            // 
            this.vPassword.Location = new System.Drawing.Point(320, 168);
            this.vPassword.Name = "vPassword";
            this.vPassword.Size = new System.Drawing.Size(125, 27);
            this.vPassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vv
            // 
            this.vv.Location = new System.Drawing.Point(320, 274);
            this.vv.Name = "vv";
            this.vv.Size = new System.Drawing.Size(125, 29);
            this.vv.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vPassword);
            this.Controls.Add(this.vLogin);
            this.Controls.Add(this.pPassword);
            this.Controls.Add(this.pLogin);
            this.Name = "Login";
            this.Text = "Login";
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
    }
}