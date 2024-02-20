using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalCafe_new.Usercontrols
{
   
    public partial class UC_AddSeller : UserControl
    {
        Connect cn = new Connect();
        String qry;
        public UC_AddSeller()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
{
    if (txtSellerID.Text != "" && txtSellerName.Text != "")
    {
        qry = "Insert into Seller (SellerID,SellerName)" +
                "values ('"+txtSellerID.Text+"',''"+txtSellerName.Text+"')";
                cn.setData(qry);
    }

    else
    {
        MessageBox.Show("Input All Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
    }
}

catch (Exception ex)
{
    throw ex;
}
        }
    }
    }

