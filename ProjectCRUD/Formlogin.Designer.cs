namespace ProjectCRUD
{
    partial class Formlogin
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
            this.btn_login = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBox_psw = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblbetamart = new System.Windows.Forms.Label();
            this.textBox_usn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(37, 330);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(249, 33);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(34, 186);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(81, 16);
            this.username.TabIndex = 1;
            this.username.Text = "Username =";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(34, 264);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 16);
            this.password.TabIndex = 2;
            this.password.Text = "Password =";
            // 
            // textBox_psw
            // 
            this.textBox_psw.BackColor = System.Drawing.Color.Black;
            this.textBox_psw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_psw.ForeColor = System.Drawing.Color.White;
            this.textBox_psw.Location = new System.Drawing.Point(114, 264);
            this.textBox_psw.Multiline = true;
            this.textBox_psw.Name = "textBox_psw";
            this.textBox_psw.Size = new System.Drawing.Size(140, 20);
            this.textBox_psw.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectCRUD.Properties.Resources.Beta_Mart;
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(37, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(37, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 8;
            // 
            // lblbetamart
            // 
            this.lblbetamart.AutoSize = true;
            this.lblbetamart.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbetamart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblbetamart.Location = new System.Drawing.Point(65, 122);
            this.lblbetamart.Name = "lblbetamart";
            this.lblbetamart.Size = new System.Drawing.Size(189, 25);
            this.lblbetamart.TabIndex = 8;
            this.lblbetamart.Text = "BETA MART LOGIN";
            // 
            // textBox_usn
            // 
            this.textBox_usn.BackColor = System.Drawing.Color.Black;
            this.textBox_usn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_usn.ForeColor = System.Drawing.Color.White;
            this.textBox_usn.Location = new System.Drawing.Point(114, 186);
            this.textBox_usn.Multiline = true;
            this.textBox_usn.Name = "textBox_usn";
            this.textBox_usn.Size = new System.Drawing.Size(140, 20);
            this.textBox_usn.TabIndex = 9;
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.textBox_usn);
            this.Controls.Add(this.lblbetamart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_psw);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.btn_login);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Formlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox_psw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblbetamart;
        private System.Windows.Forms.TextBox textBox_usn;
    }
}

