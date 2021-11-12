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
    public partial class Formdata : Form
    {
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\Documents\dbProduk.accdb");
        public Formdata()
        {
            InitializeComponent();
        }
        void showData()
        {
            koneksi.Open();
            string printah = "select * from tb_produk";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
        

        private void btn_ins_Click(object sender, EventArgs e)
        {
            if (text_brg.Text == "")
            {
                koneksi.Open();
                string printah = "Insert into tb_produk ( namaProduk, kondisi, jumlahBarang, tanggalMasuk ) values ( '" + text_nm.Text + "', '" + text_kondisi.Text + "', '" + text_jb.Text + "', '" + date_tm.Text + "')";
                OleDbCommand cmd = new OleDbCommand(printah, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data berhasil Disimpan");
                text_brg.Clear();
                text_nm.Clear();
                text_kondisi.Clear();
                text_jb.Clear();
                

                showData();
            }
            else
            {
                MessageBox.Show("ID tidak usah diisi");
            }
            
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            if (text_brg.Text == "")
            {
                MessageBox.Show("Isi id terlebih dahulu");
            }
            else
            {
                koneksi.Open();
                OleDbCommand cmd = koneksi.CreateCommand();
                string printah = "UPDATE tb_produk SET  namaProduk='" + text_nm.Text + "', kondisi='" + text_kondisi.Text + "', jumlahBarang='" + text_jb.Text + "',  tanggalMasuk='" + date_tm.Text + "' WHERE produkID =" + text_brg.Text + "";
                cmd.CommandText = printah;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data berhasil Diupdate");
                text_brg.Clear();
                text_nm.Clear();
                text_kondisi.Clear();
                text_jb.Clear();
                showData();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (text_brg.Text == "")
            {
                MessageBox.Show("Isi id terlebih dahulu");
            }
            else
            {
                koneksi.Open();
                OleDbCommand cmd = koneksi.CreateCommand();
                string printah = "DELETE FROM tb_produk WHERE produkID =" + text_brg.Text + "";
                cmd.CommandText = printah;
                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Data berhasil Dihapus");
                text_brg.Clear();
                showData();
            }
            
        }
       

        private void Formdata_Load_1(object sender, EventArgs e)
        {
            showData();
                
        }

        private void btn_src_Click(object sender, EventArgs e)
        {
            koneksi.Open();

          
            string printah = "select * from tb_produk where produkID =" + text_src.Text + "";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           


            koneksi.Close();
        }

       
    }
}
