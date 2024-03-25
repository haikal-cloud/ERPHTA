using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPCompany_ARSI_
{
    public partial class UC_Supplier : UserControl
    {
        public UC_Supplier()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Membuat dan menampilkan form transparan
            FormTransparent formTransparan = new FormTransparent();
            formTransparan.Show();

            // Membuat dan menampilkan form pop-up
            FormPopUp formPopUp = new FormPopUp();
            formPopUp.TopMost = true; // Atur form pop-up menjadi selalu di atas
            formPopUp.ShowDialog();

            // Menyembunyikan form transparan ketika form pop-up ditutup
            formTransparan.Hide();
        }

        private void label_PurchaseOI_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_PaymentC_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_TransparentSupplier_Click(object sender, EventArgs e)
        {

        }

        private void label_InPaymentM_Click(object sender, EventArgs e)
        {

        }

        private void label_InpaymentM2_Click(object sender, EventArgs e)
        {

        }

        private void SearchSideTextBox_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_diSupplier_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_SupplierPchse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_New_Click(object sender, EventArgs e)
        {

        }
    }
}
