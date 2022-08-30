using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallCalculatorRemake
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            calculations();
            chkUnder.Checked = true;
        }


        private void calculations()
        {
            //before anything - if any box is null then add a 0 
            if (txtStandardSingle.Text.Length < 1)
                txtStandardSingle.Text = "0";
            if (txtStandardDouble.Text.Length < 1)
                txtStandardDouble.Text = "0";

            if (txtSr3Single.Text.Length < 1)
                txtSr3Single.Text = "0";
            if (txtSr3Double.Text.Length < 1)
                txtSr3Double.Text = "0";

            if (txtSr4Single.Text.Length < 1)
                txtSr4Single.Text = "0";
            if (txtSr4Double.Text.Length < 1)
                txtSr4Double.Text = "0";

            if (txtPanel.Text.Length < 1)
                txtPanel.Text = "0";


            //tweakable variables
            int leaves_base_price = 3; //breaking point for leaves base price
            double base_price_under_2 = 315;//Convert.ToDouble(txtBasePrice.Text);//585;
            double base_price_under_2_minimum = 585;
            double base_price_over_2 = 450;//Convert.ToDouble(txtBasePrice.Text);//885;
            double base_price_over_2_minimum = 885;
            double price_per_additonal_leaf_base_under_2 = 195;
            double price_per_additonal_leaf_base_over_2 = 295;
            double markup = 1.6;
            //////////////////////

            //door count (leaf) variables
            double standard_single = 0;
            double standard_double = 0;

            standard_single = Convert.ToDouble(txtStandardSingle.Text);
            standard_double = Convert.ToDouble(txtStandardDouble.Text) * 1.5; //2 doors = 3 leaves

            double SR3_single = 0;
            double SR3_double = 0;

            SR3_single = Convert.ToDouble(txtSr3Single.Text) * 1.5;
            SR3_double = (Convert.ToDouble(txtSr3Double.Text) * 1.5) * 1.5; //2 doors = 3 leaves

            double SR4_single = 0;
            double SR4_double = 0;

            SR4_single = (Convert.ToDouble( txtSr4Single.Text) * 2);
            SR4_double = (Convert.ToDouble(txtSr4Double.Text) * 1.5) * 2; //2 doors = 3 leaves

            double panel = 0;
            panel = Convert.ToDouble(txtPanel.Text);
            ////



            //first step is to sum all of the leaves together

            double total_leaves = standard_single + standard_double + SR3_single + SR3_double + SR4_single + SR4_double;

            //get the amount of leaves OVER the base price
            double leaves_over_base_price = 0;
            if (total_leaves > leaves_base_price)
                leaves_over_base_price = total_leaves - leaves_base_price;

            //get the base price
            double base_price = 0;
            double price_per_additonal_leaf;
            if (chkOver.Checked == true)
            {
                base_price = base_price_over_2;
                price_per_additonal_leaf = price_per_additonal_leaf_base_over_2 ;
            }
            else
            {
                base_price = base_price_under_2;
                price_per_additonal_leaf = price_per_additonal_leaf_base_under_2;
            }

            //get the additional price
            double additional_price = price_per_additonal_leaf * leaves_over_base_price;
            if (additional_price < 0)
                additional_price = 0;

            //get the panel cost
            double panel_cost = 0;
            panel_cost = panel * 70;

            //add them all together
            double total_cost = base_price + additional_price + panel_cost; //cost to us


            double total_sales = total_cost * markup; //this is the final

            //if (chkOver.Checked == true)
            //{
            //    if (total_cost < base_price_over_2_minimum) 
            //        total_sales = base_price_over_2_minimum;
            //}
            //else
            //{
            //    if (total_cost < base_price_under_2_minimum) 
            //        total_sales = base_price_under_2_minimum;
            //}

            txtTotal.Text = total_sales.ToString();

        }

        private void txtStandardSingle_TextChanged(object sender, EventArgs e)
        {
            //calculations();
        }

        private void txtStandardDouble_TextChanged(object sender, EventArgs e)
        {
           // calculations();
        }

        private void txtSr3Single_TextChanged(object sender, EventArgs e)
        {
            //calculations();
        }

        private void txtSr3Double_TextChanged(object sender, EventArgs e)
        {
           // calculations();
        }

        private void txtSr4Single_TextChanged(object sender, EventArgs e)
        {
            //calculations();
        }

        private void txtSr4Double_TextChanged(object sender, EventArgs e)
        {
          //  calculations();
        }

        private void txtPanel_TextChanged(object sender, EventArgs e)
        {
          //  calculations();
        }

        private void txtStandardSingle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculations();
            }
        }

        private void txtStandardDouble_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculations();
            }
        }

        private void txtSr3Single_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculations();
            }
        }

        private void txtSr3Double_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculations();
            }
        }

        private void txtSr4Single_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculations();
            }
        }

        private void txtSr4Double_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculations();
            }
        }

        private void txtPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculations();
            }
        }

        private void txtStandardSingle_Leave(object sender, EventArgs e)
        {
            calculations();
        }

        private void txtStandardDouble_Leave(object sender, EventArgs e)
        {
            calculations();
        }

        private void txtSr3Single_Leave(object sender, EventArgs e)
        {
            calculations();
        }

        private void txtSr3Double_Leave(object sender, EventArgs e)
        {
            calculations();
        }

        private void txtSr4Single_Leave(object sender, EventArgs e)
        {
            calculations();
        }

        private void txtSr4Double_Leave(object sender, EventArgs e)
        {
            calculations();
        }

        private void txtPanel_Leave(object sender, EventArgs e)
        {
            calculations();
        }

        private void chkUnder_CheckedChanged(object sender, EventArgs e)
        {
            //885
            calculations();
        }

        private void chkOver_CheckedChanged(object sender, EventArgs e)
        {
            calculations();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                txtStandardSingle.Text = "0";
                txtStandardDouble.Text = "0";
                txtSr3Single.Text = "0";
                txtSr3Double.Text = "0";
                txtSr4Single.Text = "0";
                txtSr4Double.Text = "0";
                txtPanel.Text = "0";
        }

        private void txtStandardSingle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtStandardDouble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtSr3Single_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtSr3Double_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtSr4Single_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtSr4Double_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPanel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtBasePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calculations();
            }
        }

        private void txtBasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtBasePrice_Leave(object sender, EventArgs e)
        {
            calculations();
        }
    }
}
