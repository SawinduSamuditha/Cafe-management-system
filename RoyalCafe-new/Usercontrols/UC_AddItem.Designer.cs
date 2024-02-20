namespace RoyalCafe_new.Usercontrols
{
    partial class UC_AddItem
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
            this.lblAddItems = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.cmbFoodCatagory = new System.Windows.Forms.ComboBox();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.lblSellerID = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.txtSellerId = new System.Windows.Forms.TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // lblAddItems
            // 
            this.lblAddItems.AutoSize = true;
            this.lblAddItems.BackColor = System.Drawing.Color.Transparent;
            this.lblAddItems.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItems.ForeColor = System.Drawing.Color.Black;
            this.lblAddItems.Location = new System.Drawing.Point(305, 14);
            this.lblAddItems.Name = "lblAddItems";
            this.lblAddItems.Size = new System.Drawing.Size(189, 38);
            this.lblAddItems.TabIndex = 0;
            this.lblAddItems.Text = "Add Items";
            this.lblAddItems.Click += new System.EventHandler(this.lblAddItems_Click);
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(395, 97);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(141, 22);
            this.txtFoodID.TabIndex = 1;
            // 
            // cmbFoodCatagory
            // 
            this.cmbFoodCatagory.ForeColor = System.Drawing.Color.Transparent;
            this.cmbFoodCatagory.FormattingEnabled = true;
            this.cmbFoodCatagory.Items.AddRange(new object[] {
            "Indian Food",
            "Italian Food",
            "Mexican Food"});
            this.cmbFoodCatagory.Location = new System.Drawing.Point(395, 221);
            this.cmbFoodCatagory.Name = "cmbFoodCatagory";
            this.cmbFoodCatagory.Size = new System.Drawing.Size(141, 24);
            this.cmbFoodCatagory.TabIndex = 2;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodPrice.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.ForeColor = System.Drawing.Color.Transparent;
            this.lblFoodPrice.Location = new System.Drawing.Point(193, 277);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(130, 32);
            this.lblFoodPrice.TabIndex = 3;
            this.lblFoodPrice.Text = "Food Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(205, 154);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 32);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.BackColor = System.Drawing.Color.Transparent;
            this.lblCatagory.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.ForeColor = System.Drawing.Color.Transparent;
            this.lblCatagory.Location = new System.Drawing.Point(193, 221);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(113, 32);
            this.lblCatagory.TabIndex = 5;
            this.lblCatagory.Text = "Catagory";
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodID.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFoodID.Location = new System.Drawing.Point(205, 97);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(108, 34);
            this.lblFoodID.TabIndex = 6;
            this.lblFoodID.Text = "Food ID";
            // 
            // lblSellerID
            // 
            this.lblSellerID.AutoSize = true;
            this.lblSellerID.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerID.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerID.ForeColor = System.Drawing.Color.Transparent;
            this.lblSellerID.Location = new System.Drawing.Point(193, 329);
            this.lblSellerID.Name = "lblSellerID";
            this.lblSellerID.Size = new System.Drawing.Size(119, 32);
            this.lblSellerID.TabIndex = 7;
            this.lblSellerID.Text = "Seller ID";
            this.lblSellerID.Click += new System.EventHandler(this.lblSellerID_Click);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(395, 163);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(141, 22);
            this.txtFoodName.TabIndex = 8;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(395, 287);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(141, 22);
            this.txtFoodPrice.TabIndex = 9;
            // 
            // txtSellerId
            // 
            this.txtSellerId.Location = new System.Drawing.Point(395, 339);
            this.txtSellerId.Name = "txtSellerId";
            this.txtSellerId.Size = new System.Drawing.Size(141, 22);
            this.txtSellerId.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.Beige;
            this.btnAdd.CustomBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(312, 421);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 45);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            // 
            // UC_AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSellerId);
            this.Controls.Add(this.txtFoodPrice);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lblSellerID);
            this.Controls.Add(this.lblFoodID);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.cmbFoodCatagory);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.lblAddItems);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "UC_AddItem";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddItems;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.ComboBox cmbFoodCatagory;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.Label lblSellerID;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.TextBox txtSellerId;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
