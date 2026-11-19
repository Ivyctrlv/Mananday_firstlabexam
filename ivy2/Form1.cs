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


            string displayDanielle = "Danielle: ₱0.00";
            string displayEdward = "Edward: ₱0.00";
            string displayFatima = "Fatima: ₱0.00";

            if (initial == "D")
            {
                displayDanielle = "Danielle: ₱" + salesAmount.ToString("F2");
            }
            else if (initial == "E")
            {
                displayEdward = "Edward: ₱" + salesAmount.ToString("F2");
            }
            else if (initial == "F")
            {
                displayFatima = "Fatima: ₱" + salesAmount.ToString("F2");
            }
            else
            {
                label1.Text = "Invalid initial! Use D, E, or F.";
                return;
            }

            label1.Text = displayDanielle + "\n" + displayEdward + "\n" + displayFatima;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string summary =
                            "Danielle: ₱" + totalDanielle.ToString("F2") + "\n" +
                            "Edward:   ₱" + totalEdward.ToString("F2") + "\n" +
                            "Fatima:   ₱" + totalFatima.ToString("F2") + "\n" +
                            "TOTAL:    ₱" + (totalDanielle + totalEdward + totalFatima).ToString("F2");

            Form2 summaryForm = new Form2(totalDanielle, totalEdward, totalFatima);
            summaryForm.ShowDialog();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
