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
    public partial class FormPesan : Form
    {
        public FormPesan()
        {
            InitializeComponent();
            //untuk mengambil nama username dari form login
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["FormLogin"];
            tbUsername.Text = ((FormLogin)f).tbUsername.Text;
            koneksi = new SqlConnection(kstr);
        }
        //deklarasi string dan sqlconnection yg digunnakan untuk koneksi ke database
        private string kstr = "data source=KIKI; " +
                   "database=Hotel;User ID=sa;Password=test123";
        private SqlConnection koneksi;
        //deklarasi string yg digunakan untuk menampung username,nomor,tipekamar,dan lama menginap
        private string usern, nomor, tipekamar, lamamenginap;

        /// <summary>
        /// event saat mengisi textbox nomor telpon
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event textbox nomor telpon</param>
        /// <remarks>Untuk mengatur input hanya menerima angka</remarks>
   
        private void tbNomor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //membuat event hanya input menerima angka
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event saat mengisi textbox lama menginap
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event textbox nomor telpon</param>
        /// <remarks>Untuk mengatur input hanya menerima angka</remarks>
        private void tbLamaMenginap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //membuat event hanya input menerima angka
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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
        /// Event load combobox tipe kamar
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event combo box</param>
        /// <remarks>Untuk mengisi pilihan combo box tipe kamar</remarks>
        private void FormPesan_Load(object sender, EventArgs e)
        {
            //menambahkan item pada combo box tipe kamar
            cbTipeKamar.Items.Add(new KeyValuePair<string, string>("Single Bed","0"));
            cbTipeKamar.Items.Add(new KeyValuePair<string, string>("Twin Bed", "1"));
            cbTipeKamar.DisplayMember = "key";
            cbTipeKamar.ValueMember = "value";
        }

        /// <summary>
        /// Event button pesan
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button pesan</param>
        /// <remarks>Untuk menyimpan pesanan yang telah diinnpu kedalam database</remarks>
        private void btnPesan_Click(object sender, EventArgs e)
        {
            //membuka koneksi database
            koneksi.Open();
            //menampung hasil textbox dan combo box pada string
            usern = tbUsername.Text;
            nomor = tbNomor.Text;
            tipekamar = cbTipeKamar.Text;
            lamamenginap = tbLamaMenginap.Text;
            //event bila terdapat textbox atau combo box kosong
            if (usern == "" || nomor == "" || tipekamar == "" || lamamenginap == "")
            {
                //menampilkan pesan lengkapi data
                MessageBox.Show("Lengkapi Data Pesanan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                koneksi.Close();
            }
            //event bila tidak terdapat textbox atau combo box kosong
            else
            {
                //deklarasi string untuk menginsert ke database dengan tabel pesanan
                string str = "insert into Pesanan (username,nomor_telepon,tipe_kamar,lama_menginap)" + " values(@um, @nt, @tk, @lm)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                //menambahkan nilai parameter
                cmd.Parameters.Add(new SqlParameter("um", usern));
                cmd.Parameters.Add(new SqlParameter("nt", nomor));
                cmd.Parameters.Add(new SqlParameter("tk", tipekamar));
                cmd.Parameters.Add(new SqlParameter("lm", lamamenginap));
                cmd.ExecuteNonQuery();
                //menutup koneksi database
                koneksi.Close();
                //mereset textbox
                tbNomor.Text = "";
                cbTipeKamar.Text = "";
                tbLamaMenginap.Text = "";
                //menampilkan pesan berhasil memesan kamar
                MessageBox.Show("Berhasil Memesan Kamar", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
