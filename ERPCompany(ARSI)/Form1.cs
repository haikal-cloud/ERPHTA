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

    public partial class Form1 : Form
    {
        formDashboard Dashboard;
        FormTransparent Accounting;
        formHRD HRD;
        formContacts Contacts;
        FormPopUp formPopUp;
        formInPayments InPayments;
        formPlus Plus;
        formUtility Utility;
        formSuppliers Suppliers;

        public Form1()
        {
            InitializeComponent();
        }
        bool SidebarExpand = true;
        bool SalesExpand = true;
        bool PurchaseExpand = false;



        private void PurchaseTransition_Tick(object sender, EventArgs e)
        {
            if (PurchaseExpand == false)
            {
                PurchaseContainer.Height += 10; 
                if(PurchaseContainer.Height >= 370)
                {
                    PurchaseTransition.Stop();
                    PurchaseExpand=true;
                }
            }
            else
            {
                PurchaseContainer.Height -= 10;
                if (PurchaseContainer.Height <= 35)
                {
                    PurchaseTransition.Stop();
                    PurchaseExpand = false;
                }
            }
        }

        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                SidebarPanel.Width -= 10;
                if (SidebarPanel.Width <=53)
                {
                    SidebarExpand = false;
                    SidebarTransition.Stop();

                    DashboardPanel.Width = SidebarPanel.Width;
                    SalesContainer.Width = SidebarPanel.Width;
                    PurchaseContainer.Width = SidebarPanel.Width;
                    InventoryPanel.Width = SidebarPanel.Width;
                    HRDPanel.Width = SidebarPanel.Width;
                    ProductionPanel.Width = SidebarPanel.Width;
                    AccountPanel.Width = SidebarPanel.Width;
                    UtilityPanel.Width = SidebarPanel.Width;
                    LogoutPanel.Width = SidebarPanel.Width;
                }
            }
            else
            {
                SidebarPanel.Width += 10;
                if (SidebarPanel.Width >= 220)
                {
                    SidebarExpand = true;
                    SidebarTransition.Stop();

                    DashboardPanel.Width = SidebarPanel.Width;
                    SalesContainer.Width = SidebarPanel.Width;
                    PurchaseContainer.Width = SidebarPanel.Width;
                    InventoryPanel.Width = SidebarPanel.Width;
                    HRDPanel.Width = SidebarPanel.Width;
                    ProductionPanel.Width = SidebarPanel.Width;
                    AccountPanel.Width = SidebarPanel.Width;
                    UtilityPanel.Width = SidebarPanel.Width;
                    LogoutPanel.Width = SidebarPanel.Width;
                }
            }

        }

        private void SalesTransition_Tick(object sender, EventArgs e)
        {
            if (SalesExpand == false)
            {
                SalesContainer.Height += 10;
                if (SalesContainer.Height >= 165)
                {
                    SalesTransition.Stop();
                    SalesExpand = true;
                }
            }
            else
            {
                SalesContainer.Height -= 10;
                if (SalesContainer.Height <= 35)
                {
                    SalesTransition.Stop();
                    SalesExpand = false;
                }
            }
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PBHTA_Click(object sender, EventArgs e)
        {

        }

        private void BarTiga_Click_1(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SalesTransition.Start();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseTransition.Start();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            if (Dashboard == null)
            {
                Dashboard = new formDashboard();
                Dashboard.FormClosed += Dashboard_FormClosed;
                Dashboard.MdiParent = this;
                Dashboard.Dock = DockStyle.Fill;
                Dashboard.Show();
            }
            else
            {
                Dashboard.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dashboard = null;
        }

        private void SuppliersButton_Click_1(object sender, EventArgs e)
        {
            if (Suppliers == null)
            {
                Suppliers = new formSuppliers();
                Suppliers.FormClosed += Suppliers_FormClosed;
                Suppliers.MdiParent = this;
                Suppliers.Dock = DockStyle.Fill;
                Suppliers.Show();
            }
            else
            {
                Suppliers.Activate();
            }
        }
        private void Suppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Suppliers = null;
        }

        private void ContactsButton_Click(object sender, EventArgs e)
        {
            if (Contacts == null)
            {
                Contacts = new formContacts();
                Contacts.FormClosed += Contacts_FormClosed;
                Contacts.MdiParent = this;
                Contacts.Dock = DockStyle.Fill;
                Contacts.Show();
            }
            else
            {
                Contacts.Activate();
            }
        }
        private void Contacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Contacts = null;
        }
    }
}
