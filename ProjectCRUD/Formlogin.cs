using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjectCRUD
{
    public partial class Formlogin : Form
    {

        OleDbConnection konek = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\Documents\Logindb.accdb");
        public Formlogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            konek.Open();
            string printah = "select count(*) from tb_login where username='" + textBox_usn.Text + "' and password='" + textBox_psw.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, konek);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Login Berhasil");

                Formdata f2 = new Formdata();
                f2.Show();

            }
            else
            {
                MessageBox.Show("Username atau Password salah");
            }
            konek.Close();
        }

       
    }
}
