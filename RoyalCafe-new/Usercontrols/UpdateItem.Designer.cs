namespace RoyalCafe_new.Usercontrols
{
    partial class UpdateItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUpdateItem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.lblSellerID = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSellerID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUpdateItem
            // 
            this.lblUpdateItem.AutoSize = true;
            this.lblUpdateItem.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateItem.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateItem.Location = new System.Drawing.Point(23, 9);
            this.lblUpdateItem.Name = "lblUpdateItem";
            this.lblUpdateItem.Size = new System.Drawing.Size(158, 26);
            this.lblUpdateItem.TabIndex = 0;
            this.lblUpdateItem.Text = "Update Item";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.ForeColor = System.Drawing.Color.Black;
            this.lblFoodName.Location = new System.Drawing.Point(23, 253);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(113, 29);
            this.lblFoodName.TabIndex = 2;
            this.lblFoodName.Text = "FoodName";
            this.lblFoodName.Click += new System.EventHandler(this.lblFoodName_Click);
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodID.ForeColor = System.Drawing.Color.Black;
            this.lblFoodID.Location = new System.Drawing.Point(306, 335);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(93, 29);
            this.lblFoodID.TabIndex = 3;
            this.lblFoodID.Text = "Food ID";
            // 
            // lblSellerID
            // 
            this.lblSellerID.AutoSize = true;
            this.lblSellerID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerID.ForeColor = System.Drawing.Color.Black;
            this.lblSellerID.Location = new System.Drawing.Point(23, 443);
            this.lblSellerID.Name = "lblSellerID";
            this.lblSellerID.Size = new System.Drawing.Size(103, 29);
            this.lblSellerID.TabIndex = 4;
            this.lblSellerID.Text = "Seller ID";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(23, 375);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 29);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.ForeColor = System.Drawing.Color.Black;
            this.lblCatagory.Location = new System.Drawing.Point(23, 310);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(99, 29);
            this.lblCatagory.TabIndex = 6;
            this.lblCatagory.Text = "Catagory";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(142, 260);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(143, 22);
            this.txtFoodName.TabIndex = 7;
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Items.AddRange(new object[] {
            "Italian Food",
            "Indian Food",
            "Mexican Food"});
            this.cmbCatagory.Location = new System.Drawing.Point(142, 317);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(143, 24);
            this.cmbCatagory.TabIndex = 9;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(426, 342);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(143, 22);
            this.txtFoodID.TabIndex = 12;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(142, 381);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // txtSellerID
            // 
            this.txtSellerID.Location = new System.Drawing.Point(142, 450);
            this.txtSellerID.Name = "txtSellerID";
            this.txtSellerID.Size = new System.Drawing.Size(143, 22);
            this.txtSellerID.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.CustomBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(567, 443);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSellerID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.cmbCatagory);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblSellerID);
            this.Controls.Add(this.lblFoodID);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblUpdateItem);
            this.Name = "UpdateItem";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UpdateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.Label lblSellerID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSellerID;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}
