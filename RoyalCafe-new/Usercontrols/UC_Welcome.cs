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
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int num = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                lblRoyalCafe.ForeColor = Color.Red;
                lblto.ForeColor = Color.Black;
                num++;
            }
            else if (num == 1)
            {
                lblRoyalCafe.ForeColor = Color.Yellow;
                num++;
            }
            else if (num == 2)
            {
                lblRoyalCafe.ForeColor = Color.Green;
                num++;
            }
            else if (num == 3)
            {
                lblRoyalCafe.ForeColor = Color.Cyan;
                num++;
            }
            else if (num == 4)
            {
                lblRoyalCafe.ForeColor = Color.Chocolate;
                num = 0;
            }
        }

        private void lblBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
