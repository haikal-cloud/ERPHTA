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
    public partial class formPlus : Form
    {
        formInPayments InPayments;
        public formPlus()
        {
            InitializeComponent();
        }

        private void formPlus_Load(object sender, EventArgs e)
        {
            uC_Information1.Hide();
            uC_InPayment1.Hide();
            uC_Accounting1.Hide();
            uC_Blockings1.Hide();
            uC_Supplier1.Hide();
            uC_Delivery1.Hide();
        }

        private void InPayment_Click(object sender, EventArgs e)
        {
            uC_Information1.Hide();
            uC_InPayment1.Show();
            uC_Accounting1.Hide();
            uC_Blockings1.Hide();
            uC_Supplier1.Hide();
            uC_Delivery1.Hide();
            uC_InPayment1.BringToFront();
        }

       

        private void InformationBtn_Click(object sender, EventArgs e)
        {
            uC_Information1.Show();
            uC_InPayment1.Hide();
            uC_Accounting1.Hide();
            uC_Blockings1.Hide();
            uC_Supplier1.Hide();
            uC_Delivery1.Hide();
            uC_Information1.BringToFront();

        }

        private void AccountingBtn_Click(object sender, EventArgs e)
        {
            uC_Information1.Hide();
            uC_InPayment1.Hide();
            uC_Accounting1.Show();
            uC_Blockings1.Hide();
            uC_Supplier1.Hide();
            uC_Delivery1.Hide();
            uC_Accounting1.BringToFront();
        }

        private void uC_Blockings1_Load(object sender, EventArgs e)
        {

        }

        private void BlockingsBtn_Click(object sender, EventArgs e)
        {
            uC_Information1.Hide();
            uC_InPayment1.Hide();
            uC_Accounting1.Hide();
            uC_Blockings1.Show();
            uC_Supplier1.Hide();
            uC_Delivery1.Hide();
            uC_Blockings1.BringToFront();
        }

        private void SupplierBtn_Click(object sender, EventArgs e)
        {
            uC_Information1.Hide();
            uC_InPayment1.Hide();
            uC_Accounting1.Hide();
            uC_Blockings1.Hide();
            uC_Supplier1.Show();
            uC_Delivery1.Hide();
            uC_Supplier1.BringToFront();
        }

        private void DeliveryBtn_Click(object sender, EventArgs e)
        {
            uC_Information1.Hide();
            uC_InPayment1.Hide();
            uC_Accounting1.Hide();
            uC_Blockings1.Hide();
            uC_Supplier1.Hide();
            uC_Delivery1.Show();
            uC_Delivery1.BringToFront();
        }
        /*private void InPayments_FormClosed(object sender, FormClosedEventArgs e)
{
InPayments = null;
}*/

    }
}
