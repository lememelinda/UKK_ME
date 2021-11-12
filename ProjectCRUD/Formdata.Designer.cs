namespace ProjectCRUD
{
    partial class Formdata
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.text_brg = new System.Windows.Forms.TextBox();
            this.text_nm = new System.Windows.Forms.TextBox();
            this.date_tm = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.text_jb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_kondisi = new System.Windows.Forms.TextBox();
            this.btn_ins = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_src = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.text_src = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(539, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text_brg);
            this.panel1.Controls.Add(this.text_nm);
            this.panel1.Controls.Add(this.date_tm);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.text_jb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.text_kondisi);
            this.panel1.Location = new System.Drawing.Point(23, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 257);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ProdukID";
            // 
            // text_brg
            // 
            this.text_brg.Location = new System.Drawing.Point(178, 49);
            this.text_brg.Name = "text_brg";
            this.text_brg.Size = new System.Drawing.Size(56, 20);
            this.text_brg.TabIndex = 16;
            // 
            // text_nm
            // 
            this.text_nm.Location = new System.Drawing.Point(178, 85);
            this.text_nm.Name = "text_nm";
            this.text_nm.Size = new System.Drawing.Size(161, 20);
            this.text_nm.TabIndex = 15;
            // 
            // date_tm
            // 
            this.date_tm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_tm.Location = new System.Drawing.Point(178, 199);
            this.date_tm.Name = "date_tm";
            this.date_tm.Size = new System.Drawing.Size(161, 20);
            this.date_tm.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(49, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tanggal Masuk";
            // 
            // text_jb
            // 
            this.text_jb.Location = new System.Drawing.Point(178, 162);
            this.text_jb.Name = "text_jb";
            this.text_jb.Size = new System.Drawing.Size(161, 20);
            this.text_jb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jumlah Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kondisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama Barang";
            // 
            // text_kondisi
            // 
            this.text_kondisi.Location = new System.Drawing.Point(178, 124);
            this.text_kondisi.Name = "text_kondisi";
            this.text_kondisi.Size = new System.Drawing.Size(161, 20);
            this.text_kondisi.TabIndex = 3;
            // 
            // btn_ins
            // 
            this.btn_ins.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_ins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ins.ForeColor = System.Drawing.Color.White;
            this.btn_ins.Location = new System.Drawing.Point(539, 345);
            this.btn_ins.Name = "btn_ins";
            this.btn_ins.Size = new System.Drawing.Size(75, 23);
            this.btn_ins.TabIndex = 3;
            this.btn_ins.Text = "Insert";
            this.btn_ins.UseVisualStyleBackColor = false;
            this.btn_ins.Click += new System.EventHandler(this.btn_ins_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upd.ForeColor = System.Drawing.Color.White;
            this.btn_upd.Location = new System.Drawing.Point(657, 345);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(75, 23);
            this.btn_upd.TabIndex = 4;
            this.btn_upd.Text = "Update";
            this.btn_upd.UseVisualStyleBackColor = false;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(780, 345);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 5;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_src
            // 
            this.btn_src.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_src.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_src.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_src.ForeColor = System.Drawing.Color.White;
            this.btn_src.Location = new System.Drawing.Point(897, 345);
            this.btn_src.Name = "btn_src";
            this.btn_src.Size = new System.Drawing.Size(75, 23);
            this.btn_src.TabIndex = 6;
            this.btn_src.Text = "Search";
            this.btn_src.UseVisualStyleBackColor = false;
            this.btn_src.Click += new System.EventHandler(this.btn_src_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.welcome.Location = new System.Drawing.Point(174, 115);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(718, 35);
            this.welcome.TabIndex = 7;
            this.welcome.Text = "SELAMAT DATANG DI BETA MART  ADMIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::ProjectCRUD.Properties.Resources.Beta_Mart1;
            this.pictureBox1.Location = new System.Drawing.Point(378, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // text_src
            // 
            this.text_src.Location = new System.Drawing.Point(539, 153);
            this.text_src.Name = "text_src";
            this.text_src.Size = new System.Drawing.Size(433, 20);
            this.text_src.TabIndex = 9;
            // 
            // Formdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 437);
            this.Controls.Add(this.text_src);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.btn_src);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.btn_ins);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Formdata";
            this.Text = "Formdata";
            this.Load += new System.EventHandler(this.Formdata_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_jb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_kondisi;
        private System.Windows.Forms.Button btn_ins;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_src;
        private System.Windows.Forms.DateTimePicker date_tm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_nm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox text_src;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_brg;
    }
}