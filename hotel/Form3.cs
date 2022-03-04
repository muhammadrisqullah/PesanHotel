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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
        }
        //deklarasi string dan sqlconnection yg digunnakan untuk koneksi ke database
        private string kstr = "data source=KIKI; " +
                   "database=Hotel;User ID=sa;Password=test123";
        private SqlConnection koneksi;
        //deklarasi string yg digunakan untuk menampung username dan password
        private string username, password;


        /// <summary>
        /// Event button exit
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button exit</param>
        /// <remarks>Dapat menutup aplikasi</remarks>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //menutup form ini
            this.Close();
        }

        /// <summary>
        /// Event button login
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button login</param>
        /// <remarks>Dapat berpindah ke halaman login</remarks>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //deklarasi form login
            FormLogin fm = new FormLogin();
            //membuka form login
            fm.Show();
            //menutup form ini
            this.Hide();
        }

        /// <summary>
        /// Event button register
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button register</param>
        /// <remarks>Dapat menyimpan username dan password yang telah diisi ke dalam database</remarks>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //membuka koneksi database
            koneksi.Open();
            string query = "Select * from Users where username = '" + tbUsername.Text.Trim() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, koneksi);
            DataTable dtbl = new DataTable();
            SDA.Fill(dtbl);
            //event jika username sudah dipakai pada database
            if (dtbl.Rows.Count == 1)
            {
                //menampilkan pesan username sudah tidak tersedia
                MessageBox.Show("Username sudah tidak tersedia, Masukan Username lain");
                //mereset textbox
                tbUsername.Text = "";
                tbPassword.Text = "";
                //menutup koneksi database
                koneksi.Close();
                //mebuka form kembali
                this.Show();
                
            }
            //event jika username belum dipakai pada database
            else
            {
                //menampung hasil textbox pada string
                username = tbUsername.Text;
                password = tbPassword.Text;
                //event jika salah satu texbox kosong
                if (username == "" || password == "")
                {
                    //menampilkan pesan masukan username dan passowr
                    MessageBox.Show("Masukkan username dan password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //menutup koneksi database
                    koneksi.Close();
                }
                //event jika  texbox tidak kosong
                else
                {
                    //deklarasi string untuk menginsert ke database dengan tabel Users
                    string str = "insert into Users (username, password)" + " values(@um, @pw)";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    //menambahkan nilai parameter
                    cmd.Parameters.Add(new SqlParameter("um", username));
                    cmd.Parameters.Add(new SqlParameter("pw", password));
                    cmd.ExecuteNonQuery();
                    //menutup koneksi database
                    koneksi.Close();
                    //mereset textbox
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                    //menampilkan pesan registrasi berhasil
                    MessageBox.Show("Registrasi Berhasil", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
