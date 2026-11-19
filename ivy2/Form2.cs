using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivy2
{
    public partial class Form2 : Form
    {

        private double danielle;
        private double edward;
        private double fatima;

        public Form2(double d, double e, double f)
        {
            InitializeComponent();

            double grandTotal = danielle + edward + fatima;

            lbl_Danielle.Text = "Danielle: ₱" + danielle.ToString("F2");
            lbl_Edward.Text = "Edward: ₱" + edward.ToString("F2");
            lbl_Fatima.Text = "Fatima: ₱" + fatima.ToString("F2");
            lbl_Total.Text = "Grand Total: ₱" + grandTotal.ToString("F2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
