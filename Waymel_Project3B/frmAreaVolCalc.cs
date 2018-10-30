using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaVolCalc_3A
{
    public partial class frmAreaVolCalc : Form
    {
        public frmAreaVolCalc()
        {
            InitializeComponent();
        }

        private void frmAreaVolCalc_Load(object sender, EventArgs e)
        {

        }
            private void rdVolume_CheckedChanged(object sender, EventArgs e)
            {
                if (rdVolume.Checked)
                {
                    lblLength.Text = "Length (ft):";
                    txtLength.Text = "0";
                    txtWidth.Text = "0";
                    txtWidth.Visible = true;
                    lblWidth.Visible = true;
                    txtHeight.Text = "0";
                    txtHeight.Visible = true;
                    lblHeight.Visible = true;
                    txtTotal.Text = "";
                    txtDivTotal.Text = "";
                }
            }

            private void rdArea_CheckedChanged(object sender, EventArgs e)
            {
                if (rdArea.Checked)
                {
                    lblLength.Text = "Length (ft):";
                    txtLength.Text = "0";
                    txtWidth.Text = "0";
                    txtWidth.Visible = true;
                    lblWidth.Visible = true;
                    txtHeight.Text = "0";
                    txtHeight.Visible = false;
                    lblHeight.Visible = false;
                    txtTotal.Text = "";
                    txtDivTotal.Text = "";
                }
            }

            private void rdAreaOfCircle_CheckedChanged(object sender, EventArgs e)
            {
                if (rdAreaOfCircle.Checked)
                {
                    lblLength.Text = "Radius (ft):";
                    txtLength.Text = "0";
                    txtWidth.Text = "0";
                    txtWidth.Visible = false;
                    lblWidth.Visible = false;
                    txtHeight.Text = "0";
                    txtHeight.Visible = false;
                    lblHeight.Visible = false;
                    txtTotal.Text = "";
                    txtDivTotal.Text = "";
            }
            }

            private void btnCalculate_Click(object sender, EventArgs e)
            {
                try
                {
                    int length = Convert.ToInt32(txtLength.Text);
                    int width = Convert.ToInt32(txtWidth.Text);
                    int height = Convert.ToInt32(txtHeight.Text);
                    int divisor = Convert.ToInt32(txtDivBy.Text);
                    string strDivisor = txtDivBy.Text;
                    int divLength = 0;
                    double total = 0d;

                    if (rdArea.Checked)
                        total = length * width;
                    else if (rdVolume.Checked)
                        total = length * width * height;
                    else
                        total = Math.PI * Math.Pow(length, 2);

                    //Custom Exception Check - Negative 
                    if (strDivisor.StartsWith("9"))
                    {
                    throw new Exception("Div By value cannot start with the number 9; please enter a different number.");   
                    }
                    //Additional Division Problem as part of 3A requirements
                    divLength = length / divisor;

                    if (rdArea.Checked)
                    {
                        txtTotal.Text = Convert.ToString(total) + " sq. ft.";
                        txtDivTotal.Text = Convert.ToString(divLength);
                    }
                    else if (rdVolume.Checked)
                    { 
                    txtTotal.Text = Convert.ToString(total) + " cubic ft.";
                    txtDivTotal.Text = Convert.ToString(divLength);
                    }
                    else
                        txtTotal.Text = Convert.ToString(total);
                    }

                //Exception handling section - Added to complete Project 3A
                catch(FormatException)
                {
                MessageBox.Show(
                    "Invalid numeric format. Please check all entries and make sure you " +
                    "have entered positive integer values that are < 2147483648.",
                    "Entry Format Error");
                 }
                catch(OverflowException)
                {
                MessageBox.Show(
                    "Overflow Error; please enter smaller numeric values (must be < 2147483648).",
                    "Overflow Error");
                }
                catch (DivideByZeroException)
                {
                MessageBox.Show(
                    "Divide by Zero Error; please a number other than zero in the Div By field.",
                    "Divide by Zero Error");
                }
                catch (Exception ex)
                {
                MessageBox.Show(
                    ex.Message,
                    "Negative Div By Value");
                }
        }

            private void btnClearInputs_Click(object sender, EventArgs e)
            {
                txtLength.Text = "0";
                txtWidth.Text = "0";
                txtHeight.Text = "0";
                txtTotal.Text = "";
                txtDivTotal.Text = "";
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                this.Close();
           

        }

    }
}
