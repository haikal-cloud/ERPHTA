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
    public partial class formSuppliers : Form
    {
        formPlus Plus;
        public formSuppliers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if (Plus == null)
            {
                Plus = new formPlus();
                Plus.FormClosed += Plus_FormClosed;
                Plus.MdiParent = this.ParentForm;
                Plus.Dock = DockStyle.Fill;
                Plus.Show();
            }
            else
            {
                Plus.Activate();
            }
        }
        private void Plus_FormClosed(object sender, FormClosedEventArgs e)
        {
            Plus = null;
        }
    }
}
