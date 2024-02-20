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
    public partial class UC_Delete : UserControl
    {
        Connect conn = new Connect();
        String qry;
        public UC_Delete()
        {
            InitializeComponent();
        }

        private void UC_Delete_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            qry = "Select * From FoodItems";
            DataSet ds = conn.getData(qry);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFoodID.Text !="")
                {
                    qry = "DELETE FROM FoodItems " +
                        "WHERE FoodID ='" + txtFoodID.Text + "'";

                    //string qry = "DELETE FROM FoodItems WHERE FoodID = @FoodID";


                    conn.getData(qry);
                    MessageBox.Show("Record Deleted Successfully!");


                    loadData();
                    txtFoodID.Clear();
                }

                else
                {
                    MessageBox.Show("Input Food ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFoodID.Clear() ;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
             
        }
    }
}
