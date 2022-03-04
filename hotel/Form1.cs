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
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
        }
        //deklarasi string dan sqlconnection yg digunnakan untuk koneksi ke database
        private string kstr = "data source=KIKI; " +
                   "database=Hotel;User ID=sa;Password=test123";
        private SqlConnection koneksi;

        /// <summary>
        /// Event button login
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button login</param>
        /// <remarks>Dapat melakukan login menggunakan username dan passowrd</remarks>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //membuka koneksi database
            koneksi.Open();
            string query = "Select * from Users where username = '" + tbUsername.Text.Trim() + "' and password = '" + tbPassword.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, koneksi);
            DataTable dtbl = new DataTable();
            SDA.Fill(dtbl);
            //event jika username dan password ada didatabase
            if (dtbl.Rows.Count == 1)
            {
                //menutup koneksi database
                koneksi.Close();
                //deklarasi form menu
                FormMenu fm = new FormMenu();
                //membuka form menu
                fm.Show();
                //menutup form ini
                this.Hide();
            }
            //event jika username dan password tidak ada didatabase
            else
            {
                //menampilkan pesan username/password salah
                MessageBox.Show("Username atau Password Salah");
                //membuka form kembali
                this.Show();
                //menutup koneksi database
                koneksi.Close();
            }

        }


        /// <summary>
        /// Event button exit
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button exit</param>
        /// <remarks>dapat melakukan exit aplikasi</remarks>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //menutup form ini
            this.Close();
        }
        /// <summary>
        /// Event button register
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button Register</param>
        /// <remarks>Dapat melakukan register untuk kebutuhan login</remarks>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //deklarasi form registrasi
            FormRegister fm = new FormRegister();
            //membuka form registrasi
            fm.Show();
            //menutup form ini
            this.Hide();
        }
    }
}
