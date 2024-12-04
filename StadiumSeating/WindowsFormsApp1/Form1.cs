using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Purpose: To let the user calculate ticket prices.

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal classACost = 15;
                decimal classBCost = 12;
                decimal classCCost = 9;

                decimal classATickets;
                decimal classBTickets;
                decimal classCTickets;

                classATickets = decimal.Parse(soldA.Text);
                classBTickets = decimal.Parse(soldB.Text);
                classCTickets = decimal.Parse(soldC.Text);

                decimal classATotals;
                decimal classBTotals;
                decimal classCTotals;

                classATotals = classATickets * classACost;
                classBTotals = classBTickets * classBCost;
                classCTotals = classCTickets * classCCost;

                revClassA.Text = classATotals.ToString("c");
                revClassB.Text = classBTotals.ToString("c");
                revClassC.Text = classCTotals.ToString("c");

                decimal totalSales;
                totalSales = classATotals + classBTotals + classCTotals;
                revTotal.Text = totalSales.ToString("c");


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            soldA.Text = "";
            soldB.Text = "";
            soldC.Text = "";

            revClassA.Text = "";
            revClassB.Text = "";
            revClassC.Text = "";
            revTotal.Text = "";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void revTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
