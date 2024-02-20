using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalCafe_new
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder2.Visible = true;
            uC_PlaceOrder2.BringToFront();
        }

        private void uC_AddItem1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uC_AddItem1.Visible = true;
            uC_AddItem1.BringToFront();
        }

        private void uC_PlaceOrder1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Welcome1_Load(object sender, EventArgs e)
        {

        }

        private void uC_PlaceOrder1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateItem1.Visible = true;
            updateItem1.BringToFront();
        }

        private void uC_Delete1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            uC_Delete1.Visible = true;
            uC_Delete1.BringToFront();
        }

        private void uC_AddItem1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddSeller_Click(object sender, EventArgs e)
        {
            uC_AddSeller1.Visible = true;
            uC_AddItem1.BringToFront();

        }
    }
}
