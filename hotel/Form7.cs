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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HotelDataSet.Pesanan' table. You can move, or remove it, as needed.
            this.PesananTableAdapter.Fill(this.HotelDataSet.Pesanan);

            this.reportViewer1.RefreshReport();
        }

        //event jika form ditutup
        private void FormReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            //deklarasi form list pesanan
            FormList fl = new FormList();
            //menampilkan form list pesanan
            fl.Show();
            //menutup form ini
            this.Hide();
        }
    }
}
