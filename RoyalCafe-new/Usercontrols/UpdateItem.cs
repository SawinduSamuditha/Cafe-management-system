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
    public partial class UpdateItem : UserControl
    {
        Connect conn = new Connect();
        String qry;
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            loadData();
        }
        
        public void loadData()
        {
            qry = "Select * From FoodItems";
            DataSet ds = conn.getData(qry);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void lblFoodName_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFoodID.Text != "" && cmbCatagory.SelectedIndex != -1 && txtFoodName.Text !="" && txtPrice.Text != "" && txtSellerID.Text != "")
                {
                    qry = "UPDATE FoodItems " +
                        "SET FoodName = '" + txtFoodName.Text + "', FoodCatagory = '" + cmbCatagory.Text + "', FoodPrice = '" + txtPrice.Text + "', SellerID = '" + txtSellerID.Text + "'" +
                        "WHERE FoodID = '" + txtFoodID.Text + "'";

                    conn.getData(qry);
                    MessageBox.Show("Update Succeeded!");

                    loadData();

                }

                else
                {
                    MessageBox.Show("Input All Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFoodName.Clear();
                    txtPrice.Clear();
                    txtSellerID.Clear();
                    txtFoodID.Clear();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
