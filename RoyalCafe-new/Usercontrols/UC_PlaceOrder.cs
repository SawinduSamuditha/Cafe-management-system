using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalCafe_new.Usercontrols
{
    public partial class UC_PlaceOrder : UserControl
    {
        Connect conn = new Connect();
        String qry;
        protected int n, total = 0;
        int amount;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtList.Items.Clear();
            String catagory = cmbCatagory.Text;
            qry = "Select FoodName from FoodItems where FoodCatagory = '" + catagory + "'";
            DataSet ds = conn.getData(qry);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtList.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtList.Items.Clear();
            String catagory = cmbCatagory.Text;
            qry = "Select FoodName from FoodItems where FoodCatagory = '" + catagory + "' and FoodName like '" + txtSearch.Text + "%'";
            DataSet ds = conn.getData(qry);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                txtList.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.ResetText();
            txtTotal.Clear();

            string txt = txtList.SelectedItem?.ToString();
            txtItemName.Text = txt;
            qry = "Select FoodPrice from FoodItems where FoodName = '" + txt + "'";

            DataSet ds = conn.getData(qry);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("An Error Occured!");
            }
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 qn = Int64.Parse(txtQuantity.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);

            txtTotal.Text = (qn * price).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtQuantity.Value;
                dataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total = total + int.Parse(txtTotal.Text);

                lblBill.Text = "RS: " + total;
            }

            else
            {
                MessageBox.Show("Minimum quantity nedd to be 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            saveFileDialog.Title = "Save as Text File";


            saveFileDialog.InitialDirectory = @"D:\Royal Cafe GUI CW Code\Bills";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(saveFileDialog.FileName));

                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {

                        sw.WriteLine("ItemName\tPrice\t\tQuantity\t\tTotal");


                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            string itemName = row.Cells[0].Value.ToString();
                            string price = row.Cells[1].Value.ToString();
                            string quantity = row.Cells[2].Value.ToString();
                            string total = row.Cells[3].Value.ToString();


                            sw.WriteLine($"{itemName}\t\t{price}\t\t{quantity}\t\t{total}");
                        }

                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReomve_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            total -= amount;
            lblBill.Text = "RS: " + total.ToString();
        }
    }
}
