namespace RoyalCafe_new.Usercontrols
{
    partial class UC_Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Welcome));
            this.lblBanner = new System.Windows.Forms.PictureBox();
            this.lblto = new System.Windows.Forms.Label();
            this.lblRoyalCafe = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lblBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.Image = ((System.Drawing.Image)(resources.GetObject("lblBanner.Image")));
            this.lblBanner.Location = new System.Drawing.Point(46, 36);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(693, 223);
            this.lblBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblBanner.TabIndex = 0;
            this.lblBanner.TabStop = false;
            this.lblBanner.Click += new System.EventHandler(this.lblBanner_Click);
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.Location = new System.Drawing.Point(345, 295);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(33, 28);
            this.lblto.TabIndex = 1;
            this.lblto.Text = "To";
            // 
            // lblRoyalCafe
            // 
            this.lblRoyalCafe.AutoSize = true;
            this.lblRoyalCafe.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoyalCafe.Location = new System.Drawing.Point(269, 350);
            this.lblRoyalCafe.Name = "lblRoyalCafe";
            this.lblRoyalCafe.Size = new System.Drawing.Size(196, 49);
            this.lblRoyalCafe.TabIndex = 2;
            this.lblRoyalCafe.Text = "Royal Cafe";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.lblRoyalCafe);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblBanner);
            this.Name = "UC_Welcome";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblBanner;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Label lblRoyalCafe;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
