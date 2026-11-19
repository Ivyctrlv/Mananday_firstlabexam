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
    public partial class Form1 : Form
    {
        private double totalDanielle = 0;
        private double totalEdward = 0;
        private double totalFatima = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void getSalesPerson_Amount(string salesInitial, double salesAmount)
        {
            string initial = salesInitial.ToUpper();

            if (initial == "D")
            {
                totalDanielle += salesAmount;
            }
            else if (initial == "E")
            {
                totalEdward += salesAmount;
            }
            else if (initial == "F")
            {
                totalFatima += salesAmount;
            }
            else
            {
                label1.Text = "Invalid initial! Use D, E, or F.";
                return;
            }

            label1.Text = "";
            label1.Text =
                "Transaction Recorded!\n\n" +
                "Danielle: ₱" + totalDanielle.ToString("F2") + "\n" +
                "Edward:   ₱" + totalEdward.ToString("F2") + "\n" +
                "Fatima:   ₱" + totalFatima.ToString("F2");
        }  

        private void button3_Click(object sender, EventArgs e)
        {
            string summary =
                            "Danielle: ₱" + totalDanielle.ToString("F2") + "\n" +
                            "Edward:   ₱" + totalEdward.ToString("F2") + "\n" +
                            "Fatima:   ₱" + totalFatima.ToString("F2") + "\n" +
                            "TOTAL:    ₱" + (totalDanielle + totalEdward + totalFatima).ToString("F2");

            label1.Text = summary;
            MessageBox.Show(summary, "Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Refresh();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            if (double.TryParse(textBox2.Text, out double saleAmount) && saleAmount > 0)
            {
                getSalesPerson_Amount(textBox1.Text.Trim(), saleAmount);
            }
            else
            {
                label1.Text = "Please enter a valid positive number for the sale amount.";
            }
        }
    }
}
