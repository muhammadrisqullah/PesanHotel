using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel
{
    /// <summary>
    /// Main class
    /// </summary>
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
        }
        //deklarasi string dan sqlconnection yg digunnakan untuk koneksi ke database
        private string kstr = "data source=KIKI; " +
                   "database=Hotel;User ID=sa;Password=test123";
        private SqlConnection koneksi;
        //deklarasi int
        int indexrow;
        //method untuk menampilkan data grid view

        private void dgview()
        {
            //membuka koneksi database
            koneksi.Open();
            //deklarasi string untuk mengambil semua dari tabel pesanan
            string str = "select * from dbo.Pesanan";
            //deklarasi sqldata adapter dan dataset
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            //mengisi sqldata adapter
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            //menutup koneksi database
            koneksi.Close();
        }

        /// <summary>
        /// Event saat klik picture back
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event picture back</param>
        /// <remarks>Dapat kembali kehalaman berikutnya</remarks>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //deklarasi form menu
            FormMenu fm = new FormMenu();
            //membuka form menu
            fm.Show();
            //menutup form ini
            this.Hide();
        }

        /// <summary>
        /// Event button open
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button open</param>
        /// <remarks>Untuk memperlihatkan data</remarks>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //memangil method dgview
            dgview();
        }

        /// <summary>
        /// Event button hapus
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button hapus</param>
        /// <remarks>Untuk menghapus data yang dipilih</remarks>
        private void btnHapus_Click(object sender, EventArgs e)
        {
            //deklarasi datagridviewrow
            DataGridViewRow data2 = dgv.Rows[indexrow];
            //membuka koneksi database
            koneksi.Open();
            //menampilkan konfirmasi untuk penghapusan data
            DialogResult dr = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Confirmation", MessageBoxButtons.YesNo);
            //event jika memilih konfirmasi yes
            if (dr == DialogResult.Yes)
            {
                //deklarasi string untuk menghapus data dari tabel pesanan
                string str = "Delete dbo.Pesanan WHERE id_pesanan = '" + data2.Cells[0].Value + "'";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                //menutup koneksi database
                koneksi.Close();
                //menampikan pesan data berhasil dihapus
                MessageBox.Show("Data Berhasil dihapus", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //memangil method dgview
                dgview();
            }
            //event jika selain konfirmasi yes
            else
            {
                //menutup koneksi database
                koneksi.Close();
            }
        }

        /// <summary>
        /// Event button report
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button report</param>
        /// <remarks>Untuk membuat report dari hasil semua isi  list daftar pesanan</remarks>
        private void btnReport_Click(object sender, EventArgs e)
        {
            //deklarasi form report
            FormReport fr = new FormReport();
            //menampilkan form report
            fr.Show();
            //menutup form ini
            this.Hide();
        }

        /// <summary>
        /// Event jika mengklik cell list
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event cell list/param>
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //untuk mendapatkan baris dari item yang diklik
            indexrow = e.RowIndex;
            DataGridViewRow data = dgv.Rows[indexrow];
        }

        /// <summary>
        /// Event double click content list
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event double click content list/param>
        private void dgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //menutup form ini
            this.Hide();
            //deklarasi form detail pesanan
            FormDetailPesanan dp = new FormDetailPesanan();
            //mengisi textbox form detail pesanan dari konten yang di double klik
            dp.tbId.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
            dp.tbUsername.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            dp.tbNomor.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
            dp.tbTipe.Text = this.dgv.CurrentRow.Cells[3].Value.ToString();
            dp.tbLama.Text = this.dgv.CurrentRow.Cells[4].Value.ToString();
            //menampilkan form detail pesanan
            dp.Show();
        }
    }
}
