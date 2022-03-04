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
    public partial class FormDetailPesanan : Form
    {
        public FormDetailPesanan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event saat klik picture back
        /// </summary>
        /// <param name="sender">berisi referensi ke objek asal event</param>
        /// <param name="e">isi event picture back</param>
        /// <remarks>Dapat kembali kehalaman berikutnya</remarks>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //deklarasi form list detail pesanan
            FormList fl = new FormList();
            //menampilkan form list detail pesanan
            fl.Show();
            //menutup form ini
            this.Hide();
        }
    }
}
