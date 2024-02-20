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
    public partial class UC_AddItem : UserControl
    {
        Connect cn = new Connect();
        String qry;

        public UC_AddItem()
        {
            InitializeComponent();
        }

        private void lblAddItems_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtFoodID.Text != "" && txtFoodName.Text != "" && cmbFoodCatagory.SelectedIndex != -1 && txtFoodPrice.Text != "" && txtSellerId.Text != "")
                {
                    qry = "Insert into FoodItems (FoodID,FoodName,FoodCatagory,FoodPrice,SellerID)" +
                            "values ('" + txtFoodID.Text + "','" + txtFoodName.Text + "','" + cmbFoodCatagory.SelectedItem.ToString() + "','" + txtFoodPrice.Text + "','" + txtSellerId.Text + "')";
                    cn.setData(qry);
                }

                else
                {
                    MessageBox.Show("Input All Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFoodID.Clear();
                    txtFoodName.Clear();
                    txtFoodPrice.Clear();
                    txtSellerId.Clear();
                }
            }

            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void UC_AddItem_Load(object sender, EventArgs e)
        {

        }

        private void lblSellerID_Click(object sender, EventArgs e)
        {

        }
    }
}
