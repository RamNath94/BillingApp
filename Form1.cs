using System;

namespace Billing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Amt_TextChanged(object sender, EventArgs e)
        {

            int sum = (int)(Convert.ToInt64(QtyList1.Text) * Convert.ToInt64(priceList1.Text));
            sum += (int)(Convert.ToInt64(QtyList2.Text) * Convert.ToInt64(priceList2.Text));
            sum += (int)(Convert.ToInt64(QtyList3.Text) * Convert.ToInt64(priceList3.Text));

            Amt.Text = sum.ToString();
        }
    }
}