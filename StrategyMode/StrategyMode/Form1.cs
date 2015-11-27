using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyMode
{
    public partial class Form1 : Form
    {
        private double total = 0.0d;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalPrices = Convert.ToDouble(txtPrice.Text)*Convert.ToDouble(txtNum.Text);

            total += totalPrices;

            lbxList.Items.Add("单价： " + txtPrice.Text + " 数量: "
                              + txtNum.Text + " 合计： "
                              + totalPrices.ToString());

            lblResult.Text = total.ToString();
        }
    }
}
