using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel
{
    /// <summary>
    /// Main class
    /// </summary>
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Event button pesan
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button Pesan</param>
        /// <remarks>Dapat Berpindah ke halaman pesan kamar hotel</remarks>

        private void btnPesan_Click(object sender, EventArgs e)
        {
            //deklarasi form pesan
            FormPesan fm = new FormPesan();
            //membuka form pesan
            fm.Show();
            //menutup form ini
            this.Hide();
        }
        /// <summary>
        /// Event button exit
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button exit</param>
        /// <remarks>Dapat Berpindah ke halaman sebelumnya (login)</remarks>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //deklarasi form login
            FormLogin fm = new FormLogin();
            //membuka form login
            fm.Show();
            //menutup form ini
            this.Hide();
        }
        /// <summary>
        /// Event button list daftar pesanan
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event button list daftar pesanan</param>
        /// <remarks>Dapat Berpindah ke halaman list daftar pesanan (login)</remarks>
        private void btnList_Click(object sender, EventArgs e)
        {
            //deklarasi form pesanan
            FormList fm = new FormList();
            //membuka form pesanan
            fm.Show();
            //menutup form ini
            this.Hide();
        }
    }
}
